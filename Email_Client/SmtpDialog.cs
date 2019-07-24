using System;
using System.Drawing;
using System.Windows.Forms;
namespace Email_Client
{
    public partial class SmtpDialog : Form
    {


        public static string SmtpName;
        public static string SmtpProxy;
        public static SmtpDialog smtpDialog;
        public static bool _flagHideFirstForm = false;
        public SmtpDialog()
        {
            smtpDialog = this;
            InitializeComponent();
        }
        
        
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

        /// <summary>
        /// Enter submit Server/Port Textboxs, call Button Further click method in order to send to Login Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuTextbox_KeyPress(object sender, EventArgs e)
        {
            KeyPressEventArgs ke = e as KeyPressEventArgs;
            if (ke != null && ke.KeyChar == (char)13)
            {
                bunifuThinButtonFurther_Click(sender, e);
                ke.Handled = true;
            }
        }
        /// <summary>
        /// Save server name and port, send Login Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuThinButtonFurther_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(bunifuTextbox_server.text) && !string.IsNullOrEmpty(bunifuTextbox_port.text))
            {
                SmtpName = bunifuTextbox_server.text;
                SmtpProxy = bunifuTextbox_port.text;
                Hide();
                LoginEMail.LoginEMailInstance.ShowDialog();
                if (!_flagHideFirstForm)
                {
                    if (!this.IsDisposed)
                        Show();
                }
            }
            else
            {
                MessageBox.Show(this, "Please enter your Smtp server name and port", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
