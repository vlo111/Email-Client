using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Email_Client
{
    public partial class Compose : Form
    {
        ArrayList attachments;
        bool _lock = false;

        public Compose()
        {
            InitializeComponent();
            FontStyle.SelectedItem = "Arial";
            FontSize.SelectedItem = "10";
            this.attachments = new ArrayList();
        }
        #region Draw a blue border in panel
        // Draw a blue border around the inside of the Panel.
        private void ComposePanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = ComposePanel.ClientRectangle;
            rect.Width--;
            rect.Height--;
            e.Graphics.DrawRectangle(Pens.Blue, rect);
        }
        #endregion     
        #region Close window and minimazed

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Send Email

        private void bunifuThinButtonSend_Click(object sender, EventArgs e)
        {
            bool isRecipient = false;
            if (this.bunifuMetroTextboxTo.Text.Length > 0)
            {
                if (this.RecipientsEmailValidation(this.bunifuMetroTextboxTo.Text))
                {
                    isRecipient = true;
                }
                else
                {
                    MessageBox.Show(this, "Recipients' email address is not in the correct format, in \"To: \" field.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (this.bunifuMetroTextboxCc.Text.Length > 0)
            {
                if (!(this.RecipientsEmailValidation(this.bunifuMetroTextboxCc.Text)))
                {
                    MessageBox.Show(this, "Recipients' email address is not in the correct format, in \"Cc: \" field.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    isRecipient = true;
                }
            }

            if (this.bunifuMetroTextboxBcc.Text.Length > 0)
            {
                if (!(this.RecipientsEmailValidation(this.bunifuMetroTextboxBcc.Text)))
                {
                    MessageBox.Show(this, "Recipients' email address is not in the correct format, in \"Bcc: \" field.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    isRecipient = true;
                }
            }

            if (isRecipient == true)
            {
                try
                {
                    Rtf2Html rtf = new Rtf2Html();
                    string Html = rtf.ConvertRtfToHtml(richTextBoxMailMessage);

                    MailMessage mail_message = new MailMessage();
                    mail_message.From = LoginEMail.smtp.UserName;
                    mail_message.To = this.bunifuMetroTextboxTo.Text;
                    mail_message.CC = this.bunifuMetroTextboxCc.Text;
                    mail_message.BCC = this.bunifuMetroTextboxBcc.Text;
                    mail_message.Subject = this.bunifuMetroTextboxSubject.Text;
                    mail_message.MailType = MailEncodingType.HTML;
                    mail_message.MailPriority = MailSendPriority.NORMAL;
                    mail_message.Message = Html;
                    mail_message.Attachments = this.attachments;

                    SendEmail(mail_message);
                    Message_box dialog = new Message_box();
                }
                catch (Exception ex)
                {

                }

            }
            else
            {
                MessageBox.Show(this, "Please enter To address", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SendEmail(object mail_msg)
        {
            try
            {
                MailMessage mail_message = (MailMessage)mail_msg;
                LoginEMail.smtp.SendMail(mail_message);
            }
            catch (SmtpClientException obj)
            {
                MessageBox.Show(this, obj.ErrorMessage, "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion    
        #region Chechk Email Address

        private bool RecipientsEmailValidation(string recipient)
        {
            string[] splits = recipient.Split(new char[] { ',', ';' });

            for (int i = 0; i < splits.Length; i++)
            {
                if (this.EmailValidation(splits[i]))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
        private bool EmailValidation(string email)
        {
            Regex regx = new Regex(@"([a-zA-Z_0-9.-]+\@[a-zA-Z_0-9.-]+\.\w+)", RegexOptions.IgnoreCase);
            if (regx.IsMatch(email))
            {
                return true;
            }
            return false;
        }
        #endregion
        #region Attachment Add and Close

        private void Attachment_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ListViewItem item = new ListViewItem(Path.GetFileName(dialog.FileName) + " (" + ((double)(new FileInfo(dialog.FileName).Length / 1000)).ToString("f2") + " KB)");
                item.ImageIndex = 0;
                item.Tag = dialog.FileName;
                this.attachments.Add(dialog.FileName);
                this.attachmentsList.Items.Add(item);
            }
        }

        private void pictureBoxCancelAttachment_Click(object sender, EventArgs e)
        {
            if (this.attachmentsList.SelectedItems.Count > 0)
            {
                this.attachments.Remove(this.attachmentsList.SelectedItems[0].Tag.ToString());
                this.attachmentsList.SelectedItems[0].Remove();
            }
        }
        #endregion


        #region FormattingToolStrip
        private void Bold_Click(object sender, EventArgs e)
        {
            if (((ToolStripButton)this.FormattingToolStrip.Items[3]).Checked)
            {
                ((ToolStripButton)this.FormattingToolStrip.Items[3]).Checked = false;
            }
            else
            {
                ((ToolStripButton)this.FormattingToolStrip.Items[3]).Checked = true;
            }

            this.SetSelectionFont();
        }

        private void Italic_Click(object sender, EventArgs e)
        {
            if (((ToolStripButton)this.FormattingToolStrip.Items[4]).Checked)
            {
                ((ToolStripButton)this.FormattingToolStrip.Items[4]).Checked = false;
            }
            else
            {
                ((ToolStripButton)this.FormattingToolStrip.Items[4]).Checked = true;
            }

            this.SetSelectionFont();
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            if (((ToolStripButton)this.FormattingToolStrip.Items[5]).Checked)
            {
                ((ToolStripButton)this.FormattingToolStrip.Items[5]).Checked = false;
            }
            else
            {
                ((ToolStripButton)this.FormattingToolStrip.Items[5]).Checked = true;
            }

            this.SetSelectionFont();
        }

        private void FontColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                this.richTextBoxMailMessage.SelectionColor = dialog.Color;
                // ((ToolStripButton)this.FormattingToolStrip.Items[7]).Image = CreateFontColorIcon(dialog.Color);
                ((ToolStripButton)this.FormattingToolStrip.Items[7]).BackColor = dialog.Color;
            }
        }

        private void FontBackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                this.richTextBoxMailMessage.SelectionBackColor = dialog.Color;
                // ((ToolStripButton)this.FormattingToolStrip.Items[8]).Image = CreateFontBackColorIcon(dialog.Color);
                ((ToolStripButton)this.FormattingToolStrip.Items[8]).BackColor = dialog.Color;
            }
        }

        private void SetSelectionFont()
        {
            if (this._lock == true)
                return;
            else
            {

                try
                {
                    System.Drawing.FontStyle style = System.Drawing.FontStyle.Regular;

                    bool bold = ((ToolStripButton)this.FormattingToolStrip.Items[3]).Checked;
                    bool italic = ((ToolStripButton)this.FormattingToolStrip.Items[4]).Checked;
                    bool underline = ((ToolStripButton)this.FormattingToolStrip.Items[5]).Checked;
                    if (bold)
                    {
                        style |= System.Drawing.FontStyle.Bold;
                    }
                    if (italic)
                    {
                        style |= System.Drawing.FontStyle.Italic;
                    }
                    if (underline)
                    {
                        style |= System.Drawing.FontStyle.Underline;
                    }
                    Single styleSingle = 1;
                    if (!string.IsNullOrEmpty(this.FormattingToolStrip.Items[1].Text))
                        styleSingle = Convert.ToSingle(((ToolStripComboBox)this.FormattingToolStrip.Items[1]).Text);
                    string fontFamily = ((ToolStripComboBox)this.FormattingToolStrip.Items[0]).Text;
                    richTextBoxMailMessage.SelectionFont = new Font(fontFamily, styleSingle, style);
                    this.richTextBoxMailMessage.Focus();
                }
                catch (Exception e)
                {

                }
            }
        }
        private Bitmap CreateFontColorIcon(Color color)
        {
            Bitmap bmp = Properties.Resources.fontcolor;
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 12; y < bmp.Height; y++)
                {
                    bmp.SetPixel(x, y, color);
                }
            }

            return bmp;
        }

        private Bitmap CreateFontBackColorIcon(Color color)
        {
            Bitmap bmp = Properties.Resources.fontbackcolor;

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 12; y < bmp.Height; y++)
                {
                    bmp.SetPixel(x, y, color);
                }
            }

            return bmp;
        }

        #endregion


        private void FontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetSelectionFont();
        }

        private void FontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetSelectionFont();
        }

        private void richTextBoxMailMessage_SelectionChanged(object sender, EventArgs e)
        {
            if (this.richTextBoxMailMessage.SelectionFont == null)
                return;
            else
            {
                this._lock = true;

                ((ToolStripComboBox)this.FormattingToolStrip.Items[0]).Text = this.richTextBoxMailMessage.SelectionFont.Name;
                ((ToolStripComboBox)this.FormattingToolStrip.Items[1]).Text = this.richTextBoxMailMessage.SelectionFont.Size.ToString();
                ((ToolStripButton)this.FormattingToolStrip.Items[3]).Checked = this.richTextBoxMailMessage.SelectionFont.Bold;
                ((ToolStripButton)this.FormattingToolStrip.Items[4]).Checked = this.richTextBoxMailMessage.SelectionFont.Italic;
                ((ToolStripButton)this.FormattingToolStrip.Items[5]).Checked = this.richTextBoxMailMessage.SelectionFont.Underline;
                ((ToolStripButton)this.FormattingToolStrip.Items[7]).BackColor = this.richTextBoxMailMessage.SelectionColor;
                ((ToolStripButton)this.FormattingToolStrip.Items[8]).BackColor = this.richTextBoxMailMessage.SelectionBackColor;

                this._lock = false;
            }
        }
        private void pictureBoxClear_Click(object sender, EventArgs e)
        {
            SmtpDialog.SmtpName = "";
            SmtpDialog.SmtpProxy = "";
            LoginEMail.smtp.UserName = "";
            LoginEMail.smtp.Password = "";

            bunifuMetroTextboxTo.Text = "";
            this.bunifuMetroTextboxCc.Text = "";
            this.bunifuMetroTextboxBcc.Text = "";

            this.bunifuMetroTextboxSubject.Text = "";
            this.richTextBoxMailMessage.Text = "";

            this.attachmentsList.Clear();
            attachments.Clear();

            FontStyle.SelectedItem = "Arial";
            FontSize.SelectedItem = "10";
        }

        #region Move Window
        private void ComposePanel_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move.Drag_Form(Handle, e);
        }
        #endregion

    }
}
