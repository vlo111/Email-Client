using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Email_Client
{
    public partial class LoginEMail : Form
    {
        public static SmtpClient smtp = null;
        string _exception_type = "success";
        bool ShowHidePasswordButton = true;// Defaulf Hide/ // ...true... //
        public LoginEMail()
        {
            InitializeComponent();
            bunifuFlatButtonShowHidePassword.Hide();
        }
        #region Singlton For one Form

        private static LoginEMail _loginEMail;
        public static LoginEMail LoginEMailInstance
        {
            get
            {
                if (_loginEMail == null)
                {
                    _loginEMail = new LoginEMail();
                }
                return _loginEMail;
            }
        }
        #endregion

        #region Draw a blue border in panel
        /// <summary>
        /// Draw a blue border around the inside of the Panel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = panel1.ClientRectangle;
            rect.Width--;
            rect.Height--;
            e.Graphics.DrawRectangle(Pens.Blue, rect);
        }
        #endregion     

        #region Window Close and minimaze
        /// <summary>
        /// Panel Close |label|
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Panel minimazed |label|
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion
        
        #region Further click and Textboxs Keypress ENTER
        /// <summary>
        /// Check Smtp Server/Port and Username/Password, return (A new Message) FORM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuThinButtonFurther_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(bunifuTextboxLogin.text) &&
                !string.IsNullOrEmpty(bunifuMaterialTextboxPassword.Text) &&
                bunifuTextboxLogin.text != "Email address mail" &&
                bunifuMaterialTextboxPassword.Text != "Password")
            {
                try
                {
                    if (Internet.IsConnectedToInternet())
                    {
                        smtp = new SmtpClient(SmtpDialog.SmtpName, Convert.ToInt32(SmtpDialog.SmtpProxy));
                        if (EmailValidation(bunifuTextboxLogin._TextBox.Text))
                        {
                            if (Internet.IsConnectedToInternet())
                            {
                                smtp.UserName = bunifuTextboxLogin.text;
                                smtp.Password = bunifuMaterialTextboxPassword.Text;


                                smtp.ConnectionEstablishing += new ConnectEventHandler(smtp_ConnectionEstablishing);
                                smtp.ConnectionEstablished += new ConnectEventHandler(smtp_ConnectionEstablished);
                                smtp.AuthenticationBegan += new AuthenticateEventHandler(smtp_AuthenticationBegan);
                                smtp.AuthenticationFinished += new AuthenticateEventHandler(smtp_AuthenticationFinished);
                                smtp.StartedDataTransfer += new DataTransferEventHandler(smtp_StartedDataTransfer);
                                smtp.EndedDataTransfer += new DataTransferEventHandler(smtp_EndedDataTransfer);
                                smtp.Disconnected += new DisconnectEventHandler(smtp_Disconnected);

                                smtp.SendMail(new MailMessage
                                {
                                    From = bunifuTextboxLogin.text,
                                    To = "",
                                    Subject = ""
                                });

                            }
                        }
                        else
                        {
                            MessageBox.Show(this, "Email address is not in the correct format.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "You must connect to the internet.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (FormatException)
                {
                    _exception_type = "port_error";
                    MessageBox.Show(this, "Smtp Port name is not valid. Please, enter correct Port name", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception exception)
                {
                    var smtpClientException = (SmtpClientException)exception;

                    if (smtpClientException.ErrorMessage.Contains("Smtp server"))
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                finally
                {
                    if (smtp != null)
                    {
                        if (smtp.errorMessage == _exception_type)
                        {
                            this.Hide();
                            SmtpDialog._flagHideFirstForm = true;
                            Compose compose = new Compose();
                            compose.ShowDialog();
                        }
                        else if (_exception_type == "port_error")
                        {
                            _exception_type = "success";
                        }
                        else if (smtp.errorMessage != "")
                            MessageBox.Show(this, smtp.errorMessage, "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Please enter your email or password", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Text boxs enter
        /// <summary>
        /// Enter submit Password/Login Textboxs, call Button Further click method in order to Connect Email server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuTextboxLoginAndPassword_KeyPress(object sender, EventArgs e)
        {
            KeyPressEventArgs ke = e as KeyPressEventArgs;
            if (ke != null && ke.KeyChar == (char)13)
            {
                bunifuThinButtonFurther_Click(sender, e);
                ke.Handled = true;
            }
        }

        #endregion
        
        #region SMTP Settings Events

        void smtp_ConnectionEstablishing(object sender, string Server, int Port)
        {
            if (this.statusStrip.InvokeRequired)
            {
                ConnectEventHandler con = new ConnectEventHandler(this.smtp_ConnectionEstablishing);
                this.Invoke(con, new object[] { sender, Server, Port });
            }
            else
            {
                this.ProgressLabel.Text = "Connecting to smtp server \"" + Server + "\" on port " + Port;
            }
        }
        void smtp_Disconnected(object sender, string Server)
        {
            if (this.statusStrip.InvokeRequired)
            {
                DisconnectEventHandler discon = new DisconnectEventHandler(this.smtp_Disconnected);
                this.Invoke(discon, new object[] { sender, Server });
            }
            else
            {
                this.ProgressLabel.Text = "Disconnected with the smtp server \"" + Server + "\"";
                Thread.Sleep(500);
                this.bunifuThinButtonFurther.Enabled = true;
                this.ProgressLabel.Text = "Email Client";
            }
        }

        void smtp_EndedDataTransfer(object sender)
        {
            if (this.statusStrip.InvokeRequired)
            {
                DataTransferEventHandler data = new DataTransferEventHandler(this.smtp_EndedDataTransfer);
                this.Invoke(data, new object[] { sender });
            }
            else
            {
                this.ProgressLabel.Text = "Email message has sent";
            }
        }

        void smtp_StartedDataTransfer(object sender)
        {
            if (this.statusStrip.InvokeRequired)
            {
                DataTransferEventHandler data = new DataTransferEventHandler(this.smtp_StartedDataTransfer);
                this.Invoke(data, new object[] { sender });
            }
            else
            {
                this.ProgressLabel.Text = "Sending email message";
            }
        }

        void smtp_AuthenticationFinished(object sender, string userName)
        {
            if (this.statusStrip.InvokeRequired)
            {
                AuthenticateEventHandler auth = new AuthenticateEventHandler(this.smtp_AuthenticationFinished);
                this.Invoke(auth, new object[] { sender, userName });
            }
            else
            {
                this.ProgressLabel.Text = "Verification is completed";
            }
        }

        void smtp_AuthenticationBegan(object sender, string userName)
        {
            if (this.statusStrip.InvokeRequired)
            {
                AuthenticateEventHandler auth = new AuthenticateEventHandler(this.smtp_AuthenticationBegan);
                this.Invoke(auth, new object[] { sender, userName });
            }
            else
            {
                this.ProgressLabel.Text = "Verifying user name and password";
            }
        }

        void smtp_ConnectionEstablished(object sender, string Server, int Port)
        {
            if (this.statusStrip.InvokeRequired)
            {
                ConnectEventHandler con = new ConnectEventHandler(this.smtp_ConnectionEstablished);
                this.Invoke(con, new object[] { sender, Server, Port });
            }
            else
            {
                this.ProgressLabel.Text = "Connection is established with the smtp server \"" + Server + "\"";
            }
        }
        #endregion
        
        #region Check Email Regex
        /// <summary>
        /// Validation Email address through Regex expression
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private bool EmailValidation(string email)
        {
            Regex regx = new Regex(@"([a-zA-Z_0-9.-]+\@[a-zA-Z_0-9.-]+\.\w+)", RegexOptions.IgnoreCase);
            if (regx.IsMatch(email))
            {
                return true;
            }
            return false;
        }

        #region // I can use it's too ))
        /*bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        */
        #endregion
        
        #endregion
        #region Move Window
        /// <summary>
        /// Mouse Move Panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move.Drag_Form(Handle, e);
        }
        #endregion

        #region Go Back Form
        /// <summary>
        /// Go Back Smtp Server/Port Form(First Form)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuFlatButtonGoBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        #endregion

        #region Custom Place Holder
        /// <summary>
        /// ForeColor = Color.Black;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuMaterialTextboxPassword_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextboxPassword.Text == "Enter password")
            {
                bunifuMaterialTextboxPassword.Text = "";
            }
            bunifuMaterialTextboxPassword.ForeColor = Color.Black;
        }

        /// <summary>
        /// ForeColor = Color.Gray IF LoginTEXT = "Email address mail" //  ForeColor = Color.Silver;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuMaterialTextboxPassword_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextboxPassword.Text == "")
            {
                bunifuMaterialTextboxPassword.ForeColor = Color.Gray;
                bunifuMaterialTextboxPassword.Text = "Enter password";
            }
            else
                bunifuMaterialTextboxPassword.ForeColor = Color.Silver;
        }
        
        /// <summary>
        ///  ForeColor = Color.Black;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuTextboxLogin_Enter(object sender, EventArgs e)
        {
            if (bunifuTextboxLogin.text == "Email address mail")
                bunifuTextboxLogin.text = "";
            bunifuTextboxLogin.ForeColor = Color.Black;
        }

        /// <summary>
        /// ForeColor = Color.Gray IF LoginTEXT = "Email address mail" //  ForeColor = Color.Silver;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuTextboxLogin_Leave(object sender, EventArgs e)
        {
            if (bunifuTextboxLogin.text == "")
            {
                bunifuTextboxLogin.ForeColor = Color.Gray;
                bunifuTextboxLogin.text = "Email address mail";
            }
            else
                bunifuTextboxLogin.ForeColor = Color.Silver;
        }

        #endregion

        /// <summary>
        /// Change icon Show and Hide button // .. Show and Hide Password if click button(Show/Hide) .. //
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuFlatButtonShowHidePassword_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextboxPassword.isPassword == true)
            {
                bunifuFlatButtonShowHidePassword.BackgroundImage = Properties.Resources.show;
                ShowHidePasswordButton = false;
                bunifuMaterialTextboxPassword.isPassword = false;
            }
            else
            {
                bunifuFlatButtonShowHidePassword.BackgroundImage = Properties.Resources.hide;
                ShowHidePasswordButton = true;
                bunifuMaterialTextboxPassword.isPassword = true;
            }
        }
        /// <summary>
        /// Every write value, need to set attribute isPassword true/false(show, hide) // Icon hide/show if value 0 || .. //
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuMaterialTextboxPassword_OnValueChanged(object sender, EventArgs e)
        {
            if (bunifuMaterialTextboxPassword.Text != "" && bunifuMaterialTextboxPassword.Text != "Enter password")
            {
                bunifuFlatButtonShowHidePassword.Show();
                if (ShowHidePasswordButton)
                    bunifuMaterialTextboxPassword.isPassword = true;
            }
            else
            {
                bunifuFlatButtonShowHidePassword.Hide();
                if (!ShowHidePasswordButton)
                    bunifuMaterialTextboxPassword.isPassword = false;
            }
        }
    }
}