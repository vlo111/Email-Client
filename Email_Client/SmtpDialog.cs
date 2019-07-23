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
        // Draw a blue border around the inside of the Panel.
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = panel1.ClientRectangle;
            rect.Width--;
            rect.Height--;
            e.Graphics.DrawRectangle(Pens.Blue, rect);
        }
        #endregion     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

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
                    Show();
                }
            }
            else
            {
                MessageBox.Show(this, "Please enter your Smtp server name and port", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move.Drag_Form(Handle, e);
        }

        private void bunifuTextbox_KeyPress(object sender, EventArgs e)
        {
            KeyPressEventArgs ke = e as KeyPressEventArgs;
            if (ke != null && ke.KeyChar == (char)13)
            {
                bunifuThinButtonFurther_Click(sender, e);
                ke.Handled = true;
            }
        }
    }
}
