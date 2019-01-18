using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;
using System.IO;
using System.Threading;

namespace Email_Client
{
    public partial class EmailClient : Form
    {
        ArrayList attachments;
        ArrayList popAttachmentsIndex;
        bool _lock = false;
        Pop3Client pop = null;
        string email = "";
        int msg_id = 0;
        ArrayList attached_file_names;


        public EmailClient()
        {
            InitializeComponent();
            this.SetSelectionFont();
            this.attachments = new ArrayList();
            this.popAttachmentsIndex = new ArrayList();
            this.attached_file_names = new ArrayList();
        }

        private void EmailTimer_Tick(object sender, EventArgs e)
        {
            if (SmtpServer.ContainsFocus)
                this.SmtpServer.BackColor = Color.Ivory;
            else
                this.SmtpServer.BackColor = SystemColors.Window;

            if (SmtpPort.ContainsFocus)
                this.SmtpPort.BackColor = Color.Ivory;
            else
                this.SmtpPort.BackColor = SystemColors.Window;

            if (UserName.ContainsFocus)
                this.UserName.BackColor = Color.Ivory;
            else
                this.UserName.BackColor = SystemColors.Window;

            if (Password.ContainsFocus)
                this.Password.BackColor = Color.Ivory;
            else
                this.Password.BackColor = SystemColors.Window;

            if (PopServer.ContainsFocus)
                this.PopServer.BackColor = Color.Ivory;
            else
                this.PopServer.BackColor = SystemColors.Window;

            if (PopPort.ContainsFocus)
                this.PopPort.BackColor = Color.Ivory;
            else
                this.PopPort.BackColor = SystemColors.Window;

            if (PopUserName.ContainsFocus)
                this.PopUserName.BackColor = Color.Ivory;
            else
                this.PopUserName.BackColor = SystemColors.Window;

            if (PopPassword.ContainsFocus)
                this.PopPassword.BackColor = Color.Ivory;
            else
                this.PopPassword.BackColor = SystemColors.Window;

            if (From.ContainsFocus)
                this.From.BackColor = Color.Ivory;
            else
                this.From.BackColor = SystemColors.Window;

            if (To.ContainsFocus)
                this.To.BackColor = Color.Ivory;
            else
                this.To.BackColor = SystemColors.Window;

            if (Cc.ContainsFocus)
                this.Cc.BackColor = Color.Ivory;
            else
                this.Cc.BackColor = SystemColors.Window;

            if (Bcc.ContainsFocus)
                this.Bcc.BackColor = Color.Ivory;
            else
                this.Bcc.BackColor = SystemColors.Window;

            if (Subject.ContainsFocus)
                this.Subject.BackColor = Color.Ivory;
            else
                this.Subject.BackColor = SystemColors.Window;

            if (FromPopHeader.ContainsFocus)
                this.FromPopHeader.BackColor = Color.Ivory;
            else
                this.FromPopHeader.BackColor = SystemColors.Window;

            if (ToPopHeader.ContainsFocus)
                this.ToPopHeader.BackColor = Color.Ivory;
            else
                this.ToPopHeader.BackColor = SystemColors.Window;

            if (SubjectPopHeader.ContainsFocus)
                this.SubjectPopHeader.BackColor = Color.Ivory;
            else
                this.SubjectPopHeader.BackColor = SystemColors.Window;
        }

        private void SmtpPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (this.CheckInputValidation(SmtpServer.Text, SmtpPort.Text, UserName.Text, Password.Text, From.Text, To.Text, Cc.Text, Bcc.Text, ProxyServerTB.Text, ProxyPortTB.Text))
            {
                if (this.EmailValidation(this.From.Text))
                {
                    bool isRecipient = false;

                    if (this.To.Text.Length > 0)
                    {
                        if (this.RecipientsEmailValidation(this.To.Text))
                        {
                            isRecipient = true;
                        }
                        else
                        {
                            MessageBox.Show(this, "Recipients' email address is not in the correct format, in \"To: \" field.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (this.Cc.Text.Length > 0)
                    {
                        if (!(this.RecipientsEmailValidation(this.Cc.Text)))
                        {
                            MessageBox.Show(this, "Recipients' email address is not in the correct format, in \"Cc: \" field.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            isRecipient = true;
                        }
                    }

                    if (this.Bcc.Text.Length > 0)
                    {
                        if (!(this.RecipientsEmailValidation(this.Bcc.Text)))
                        {
                            MessageBox.Show(this, "Recipients' email address is not in the correct format, in \"Bcc: \" field.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            isRecipient = true;
                        }
                    }
                    if (Internet.IsConnectedToInternet())
                    {
                        if (isRecipient == true)
                        {
                            Rtf2Html rtf = new Rtf2Html();
                            string Html = rtf.ConvertRtfToHtml(this.MailMessage);

                            MailMessage mail_message = new MailMessage();
                            mail_message.From = this.From.Text;
                            mail_message.To = this.To.Text;
                            mail_message.CC = this.Cc.Text;
                            mail_message.BCC = this.Bcc.Text;
                            mail_message.Subject = this.Subject.Text;
                            mail_message.MailType = MailEncodingType.HTML;
                            mail_message.MailPriority = MailSendPriority.NORMAL;
                            mail_message.Message = Html;
                            mail_message.Attachments = this.attachments;

                            //Thread thread = new Thread(new ParameterizedThreadStart(this.SendEmail));
                            //thread.Start(mail_message);
                            SendEmail(mail_message);
                            Message_box dialog = new Message_box();
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "You must connect to the internet.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Sender email address is not in the correct format.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SmtpClear_Click(object sender, EventArgs e)
        {
            this.SmtpServer.Text = "";
            this.SmtpPort.Text = "";
            this.UserName.Text = "";
            this.Password.Text = "";
            this.From.Text = "";
            this.To.Text = "";
            this.Cc.Text = "";
            this.Bcc.Text = "";
            this.Subject.Text = "";
            this.MailMessage.Text = "";
            this.Attachments.Clear();
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
                this.Send.Enabled = true;
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

        private void AttachmentToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Tag == null)
                return;
            else if (e.ClickedItem.Tag.ToString() == "Add")
            {
                OpenFileDialog dialog = new OpenFileDialog();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem item = new ListViewItem(Path.GetFileName(dialog.FileName) + " (" + ((double)(new FileInfo(dialog.FileName).Length / 1000)).ToString("f2") + " KB)");
                    item.ImageIndex = 0;
                    item.Tag = dialog.FileName;
                    this.attachments.Add(dialog.FileName);
                    this.Attachments.Items.Add(item);
                }
            }
            else if (e.ClickedItem.Tag.ToString() == "Delete")
            {
                if (this.Attachments.SelectedItems.Count > 0)
                {
                    this.attachments.Remove(this.Attachments.SelectedItems[0].Tag.ToString());
                    this.Attachments.SelectedItems[0].Remove();
                }
            }
        }

        private void Attachments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Attachments.SelectedItems.Count > 0)
            {
                this.AttachmentToolStrip.Items[1].Enabled = true;
            }
            else
            {
                this.AttachmentToolStrip.Items[1].Enabled = false;
            }
        }

        private void FontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetSelectionFont();
        }

        private void FontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetSelectionFont();
        }

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
                this.MailMessage.SelectionColor = dialog.Color;
                ((ToolStripButton)this.FormattingToolStrip.Items[7]).Image = CreateFontColorIcon(dialog.Color);
            }
        }

        private void FontBackgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                this.MailMessage.SelectionBackColor = dialog.Color;
                ((ToolStripButton)this.FormattingToolStrip.Items[8]).Image = CreateFontBackColorIcon(dialog.Color);
            }
        }

        private void MailMessage_SelectionChanged(object sender, EventArgs e)
        {
            if (this.MailMessage.SelectionFont == null)
                return;
            else
            {
                this._lock = true;

                ((ToolStripComboBox)this.FormattingToolStrip.Items[0]).Text = this.MailMessage.SelectionFont.Name;
                ((ToolStripComboBox)this.FormattingToolStrip.Items[1]).Text = this.MailMessage.SelectionFont.Size.ToString();
                ((ToolStripButton)this.FormattingToolStrip.Items[3]).Checked = this.MailMessage.SelectionFont.Bold;
                ((ToolStripButton)this.FormattingToolStrip.Items[4]).Checked = this.MailMessage.SelectionFont.Italic;
                ((ToolStripButton)this.FormattingToolStrip.Items[5]).Checked = this.MailMessage.SelectionFont.Underline;
                ((ToolStripButton)this.FormattingToolStrip.Items[7]).Image = this.CreateFontColorIcon(this.MailMessage.SelectionColor);
                ((ToolStripButton)this.FormattingToolStrip.Items[8]).Image = this.CreateFontBackColorIcon(this.MailMessage.SelectionBackColor);

                this._lock = false;
            }
        }

        private void PopPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (this.CheckInputValidationForPop(this.PopServer.Text, this.PopPort.Text, this.PopUserName.Text, this.PopPassword.Text))
            {
                if (Internet.IsConnectedToInternet())
                {
                    Thread th = new Thread(new ThreadStart(this.ReceiveEmails));
                    th.Start();
                }
                else
                {
                    MessageBox.Show(this, "You must connect to the internet.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void pop_Disconnected(object sender, string Server)
        {
            if (this.statusStrip.InvokeRequired)
            {
                DisconnectEventHandler discon = new DisconnectEventHandler(this.pop_Disconnected);
                this.Invoke(discon, new object[] { sender, Server });
            }
            else
            {
                this.ProgressLabel.Text = "Disconnected with the pop server \"" + Server + "\"";
                Thread.Sleep(500);
                this.Send.Enabled = true;
                this.ProgressLabel.Text = "Email Client";
            }
        }

        private void pop_EndedDataReceiving(object sender)
        {
            if (this.statusStrip.InvokeRequired)
            {
                DataReceivingEventHandler data = new DataReceivingEventHandler(this.pop_EndedDataReceiving);
                this.Invoke(data, new object[] { sender });
            }
            else
            {
                this.ProgressLabel.Text = "Email message has received";
            }
        }

        private void pop_StartedDataReceiving(object sender)
        {
            if (this.statusStrip.InvokeRequired)
            {
                DataReceivingEventHandler data = new DataReceivingEventHandler(this.pop_StartedDataReceiving);
                this.Invoke(data, new object[] { sender });
            }
            else
            {
                this.ProgressLabel.Text = "Receiving email message";
            }
        }

        private void pop_AuthenticationFinished(object sender, string userName)
        {
            if (this.statusStrip.InvokeRequired)
            {
                AuthenticateEventHandler auth = new AuthenticateEventHandler(this.pop_AuthenticationFinished);
                this.Invoke(auth, new object[] { sender, userName });
            }
            else
            {
                this.ProgressLabel.Text = "Verification is completed";
            }
        }

        private void pop_AuthenticationBegan(object sender, string userName)
        {
            if (this.statusStrip.InvokeRequired)
            {
                AuthenticateEventHandler auth = new AuthenticateEventHandler(this.pop_AuthenticationBegan);
                this.Invoke(auth, new object[] { sender, userName });
            }
            else
            {
                this.ProgressLabel.Text = "Verifying user name and password";
            }
        }

        private void pop_ConnectionEstablished(object sender, string Server, int Port)
        {
            if (this.statusStrip.InvokeRequired)
            {
                ConnectEventHandler con = new ConnectEventHandler(this.pop_ConnectionEstablished);
                this.Invoke(con, new object[] { sender, Server, Port });
            }
            else
            {
                this.ProgressLabel.Text = "Connection is established with the pop server \"" + Server + "\"";
            }
        }

        private void pop_ConnectionEstablishing(object sender, string Server, int Port)
        {
            if (this.statusStrip.InvokeRequired)
            {
                ConnectEventHandler con = new ConnectEventHandler(this.pop_ConnectionEstablishing);
                this.Invoke(con, new object[] { sender, Server, Port });
            }
            else
            {
                this.ProgressLabel.Text = "Connecting to pop server \"" + Server + "\" on port " + Port;
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            if (this.pop != null)
            {
                DialogResult result = MessageBox.Show(this, "Do you want to disconnect with the pop server \"" + this.pop.Pop3Server + "\" ?", "Email Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        this.pop.Disconnect();
                        this.MailMessages.Items.Clear();
                        this.FromPopHeader.Text = "";
                        this.ToPopHeader.Text = "";
                        this.SubjectPopHeader.Text = "";
                        this.PopAttachments.Items.Clear();
                        this.PopMessage.DocumentText = "<html></html>";
                        MessageBox.Show(this, "You are disconnected with the pop server " + this.pop.Pop3Server + ".", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.EnableDisableConnectButton(true);
                        this.EnableDisableDisconnectButton(false);
                    }
                    catch (Pop3ClientException err)
                    {
                        MessageBox.Show(this, err.ErrorMessage, "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void MailMessages_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && this.MailMessages.SelectedItems.Count > 0)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                Image image = (Image)Email_Client.Properties.Resources.delete;
                menu.Items.Add("Delete", image);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menu_ItemClicked);
                menu.Show(Control.MousePosition);
            }
            else if (e.Button == MouseButtons.Left && this.MailMessages.SelectedItems.Count > 0)
            {
                int index = this.MailMessages.SelectedItems[0].Index;
                index = index + 1;
                this.email = "";
                this.msg_id = index;
                this.FromPopHeader.Text = "";
                this.ToPopHeader.Text = "";
                this.SubjectPopHeader.Text = "";
                this.PopMessage.DocumentText = "<html></html>";
                this.PopAttachments.Items.Clear();
                this.attached_file_names.Clear();
                this.popAttachmentsIndex.Clear();

                Thread th = new Thread(new ThreadStart(this.FetchEmailCallBack));
                th.Start();
            }
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Do you want to delete the selected message?", "Email Client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int index = this.MailMessages.SelectedItems[0].Index;
                index = index + 1;
                try
                {
                    this.pop.DeleteEmail(index);
                    this.MailMessages.SelectedItems[0].Remove();

                    if (this.msg_id == index)
                    {
                        this.FromPopHeader.Text = "";
                        this.ToPopHeader.Text = "";
                        this.SubjectPopHeader.Text = "";
                        this.PopAttachments.Items.Clear();
                        this.PopMessage.DocumentText = "<html></html>";
                    }
                    MessageBox.Show(this, "Message having id " + index + " is deleted.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Pop3ClientException err)
                {
                    MessageBox.Show(this, err.ErrorMessage, "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DownloadAttachment_Click(object sender, EventArgs e)
        {
            int selected_index = this.PopAttachments.SelectedItems[0].Index;
            int index = Convert.ToInt32(this.popAttachmentsIndex[selected_index].ToString());
            string selectedFile = this.PopAttachments.SelectedItems[0].Text;
            selectedFile = selectedFile.Trim(new char[] { '"' });
            string file_name = Path.GetFileNameWithoutExtension(selectedFile);
            string file_extension = Path.GetExtension(selectedFile);

            SaveFileDialog obj = new SaveFileDialog();
            obj.Title = "Save a File";
            obj.FileName = file_name;
            obj.Filter = "Document (*" + file_extension + ")|*" + file_extension + "|All Files|*.*";
            obj.FilterIndex = 1;

            if (obj.ShowDialog(this) == DialogResult.OK)
            {
                string content = "";
                string content_type = "";
                string attached_file_name = "";

                this.pop.GetMailSection(index, ref content, ref content_type, ref attached_file_name);
                byte[] decoded_data = MailDecoder.ConvertFromBase64String(content);
                File.WriteAllBytes(obj.FileName, decoded_data);

                MessageBox.Show(this, "File \"" + Path.GetFileName(obj.FileName) + "\" has saved.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void PopAttachments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.PopAttachments.SelectedItems.Count > 0)
            {
                this.SaveAttachmentToolStrip.Items[0].Enabled = true;
            }
            else
            {
                this.SaveAttachmentToolStrip.Items[0].Enabled = false;
            }
        }

        private void MailMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(this.MailMessages.SelectedItems.Count > 0))
            {
                this.FromPopHeader.Text = "";
                this.ToPopHeader.Text = "";
                this.SubjectPopHeader.Text = "";
                this.PopAttachments.Items.Clear();
                this.PopMessage.DocumentText = "<html></html>";
            }
        }

        // The delegate used to enable or disable a button control, in another thread
        private delegate void EnableDisableEventHandler(bool enable);

        private void EnableDisableSendButton(bool enable)
        {
            if (this.Connect.InvokeRequired)
            {
                EnableDisableEventHandler obj = new EnableDisableEventHandler(this.EnableDisableSendButton);
                this.Invoke(obj, new object[] { enable });
            }
            else
            {
                this.Send.Enabled = enable;
            }
        }

        private void EnableDisableConnectButton(bool enable)
        {
            if (this.Connect.InvokeRequired)
            {
                EnableDisableEventHandler obj = new EnableDisableEventHandler(this.EnableDisableConnectButton);
                this.Invoke(obj, new object[] { enable });
            }
            else
            {
                this.Connect.Enabled = enable;
            }
        }

        private void EnableDisableDisconnectButton(bool enable)
        {
            if (this.Connect.InvokeRequired)
            {
                EnableDisableEventHandler obj = new EnableDisableEventHandler(this.EnableDisableDisconnectButton);
                this.Invoke(obj, new object[] { enable });
            }
            else
            {
                this.Disconnect.Enabled = enable;
            }
        }

        // The delegate used to insert an item in the Inbox ListView
        private delegate void InboxItemEventHandler(ListViewItem item);

        private void InsertItem(ListViewItem item)
        {
            if (this.MailMessages.InvokeRequired)
            {
                InboxItemEventHandler obj = new InboxItemEventHandler(this.InsertItem);
                this.Invoke(obj, new object[] { item });
            }
            else
            {
                this.MailMessages.Items.Add(item);
            }
        }

        // The delegate used to Add attached file names in Pop Attachments ListView
        private delegate void InsertPopAttachedFileNamesEventHandler(ArrayList attached_file_names);
        private void InsertPopAttachedFileNames(ArrayList attached_file_names)
        {
            if (this.MailMessages.InvokeRequired)
            {
                InsertPopAttachedFileNamesEventHandler obj = new InsertPopAttachedFileNamesEventHandler(this.InsertPopAttachedFileNames);
                this.Invoke(obj, new object[] { attached_file_names });
            }
            else
            {
                this.PopAttachments.Items.Clear();
                for (int i = 0; i < attached_file_names.Count; i++)
                {
                    this.PopAttachments.Items.Add((ListViewItem)attached_file_names[i]);
                }
            }
        }

        // The delegate used to clear the items in Pop Attachments ListView
        private delegate void ClearPopAttachmentsEventHandler();

        private void ClearPopAttachments()
        {
            if (this.PopAttachments.InvokeRequired)
            {
                ClearPopAttachmentsEventHandler obj = new ClearPopAttachmentsEventHandler(this.ClearPopAttachments);
                this.Invoke(obj, new object[] { });
            }
            else
            {
                this.PopAttachments.Items.Clear();
            }
        }

        // The delegate used to write Pop Message in browser
        private delegate void WritePopMessageEventHandler(string content);

        private void WritePopMessage(string content)
        {
            if (this.PopMessage.InvokeRequired)
            {
                WritePopMessageEventHandler obj = new WritePopMessageEventHandler(this.WritePopMessage);
                this.Invoke(obj, new object[] { content });
            }
            else
            {
                this.PopMessage.DocumentText = content.Trim();
            }
        }

        // The delegate used to update Status Bar
        private delegate void UpdateStatusBarEventHandler(string text);

        private void UpdateStatusBar(string text)
        {
            if (this.statusStrip.InvokeRequired)
            {
                UpdateStatusBarEventHandler obj = new UpdateStatusBarEventHandler(this.UpdateStatusBar);
                this.Invoke(obj, new object[] { text });
            }
            else
            {
                this.ProgressLabel.Text = text;
            }
        }

        // The delegate used to update Pop message header
        private delegate void UpdatePopMessageHeaderEventHandler(string from, string to, string subject);

        private void UpdatePopMessageHeader(string from, string to, string subject)
        {
            if (this.FromPopHeader.InvokeRequired || this.ToPopHeader.InvokeRequired || this.SubjectPopHeader.InvokeRequired)
            {
                UpdatePopMessageHeaderEventHandler obj = new UpdatePopMessageHeaderEventHandler(this.UpdatePopMessageHeader);
                this.Invoke(obj, new object[] { from, to, subject });
            }
            else
            {
                this.FromPopHeader.Text = from.Trim();
                this.ToPopHeader.Text = to.Trim();
                this.SubjectPopHeader.Text = subject.Trim();
            }
        }





        // Helping methods for Pop3 Client user Interface

        private void ReceiveEmails()
        {
            try
            {
                Pop3Client pop_client = new Pop3Client();
                pop_client.Pop3Server = this.PopServer.Text;
                pop_client.Pop3Port = Convert.ToInt32(this.PopPort.Text);
                pop_client.UserName = this.PopUserName.Text;
                pop_client.Password = this.PopPassword.Text;
                this.EnableDisableConnectButton(false);

                pop_client.ConnectionEstablishing += new ConnectEventHandler(this.pop_ConnectionEstablishing);
                pop_client.ConnectionEstablished += new ConnectEventHandler(this.pop_ConnectionEstablished);
                pop_client.AuthenticationBegan += new AuthenticateEventHandler(this.pop_AuthenticationBegan);
                pop_client.AuthenticationFinished += new AuthenticateEventHandler(this.pop_AuthenticationFinished);
                pop_client.StartedDataReceiving += new DataReceivingEventHandler(this.pop_StartedDataReceiving);
                pop_client.EndedDataReceiving += new DataReceivingEventHandler(this.pop_EndedDataReceiving);
                pop_client.Disconnected += new DisconnectEventHandler(this.pop_Disconnected);

                this.pop = pop_client;

                pop_client.Connect();
                this.EnableDisableDisconnectButton(true);
                pop_client.GetMailBoxDetails();   //it sets the TotalEmails and TotalEmailSize properties

                if (pop_client.TotalEmails >= 1)
                {
                    this.UpdateStatusBar("Retrieving Emails");
                    this.FillInboxListView(pop_client);
                    this.UpdateStatusBar("Email Client");
                }
                else
                {
                    this.UpdateStatusBar("Email Client");
                    MessageBox.Show(this, "No email message exists in the inbox!.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SmtpClientException err)
            {
                MessageBox.Show(this, err.ErrorMessage, "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.UpdateStatusBar("Email Client");
                this.EnableDisableConnectButton(true);
                this.EnableDisableDisconnectButton(false);
            }
        }

        private void FetchEmailCallBack()
        {
            try
            {
                this.email = this.pop.FetchEmail(this.msg_id);
                this.UpdatePopMessageHeader(this.pop.From, this.pop.To, this.pop.Subject);

                string content = "";
                string content_type = "";
                string attached_file_name = "";
                bool isHtmlIncluded = false;
                int plain_text_message_section = -1;

                for (int i = 1; i <= this.pop.MailSections; i++)
                {
                    this.pop.GetMailSection(i, ref content, ref content_type, ref attached_file_name);

                    if (content_type.ToLower().Equals("text/html"))
                    {
                        this.WritePopMessage(content);
                        isHtmlIncluded = true;
                    }
                    else if (content_type.ToLower().Equals("base64"))
                    {
                        ListViewItem item = new ListViewItem(attached_file_name);
                        item.ImageIndex = 0;
                        attached_file_names.Add(item);
                        this.popAttachmentsIndex.Add(i);
                    }
                    else if (content_type.ToLower().Equals("text/plain"))
                    {
                        plain_text_message_section = i;
                    }
                }

                this.InsertPopAttachedFileNames(attached_file_names);

                if (isHtmlIncluded == false && plain_text_message_section != -1)
                {
                    this.pop.GetMailSection(plain_text_message_section, ref content, ref content_type, ref attached_file_name);
                    this.WritePopMessage(content);
                }

                this.UpdateStatusBar("Email Client");

            }
            catch (Pop3ClientException err)
            {
                MessageBox.Show(this, err.ErrorMessage, "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckInputValidationForPop(string pop_server, string pop_port, string user_name, string password)
        {
            if (pop_server.Equals(""))
            {
                MessageBox.Show(this, "You must provide pop server address.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (pop_port.Equals(""))
            {
                MessageBox.Show(this, "You must provide pop port number.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (user_name.Equals(""))
            {
                MessageBox.Show(this, "You must provide username.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (password.Equals(""))
            {
                MessageBox.Show(this, "You must provide password.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void FillInboxListView(Pop3Client obj)
        {
            ArrayList sender = new ArrayList();
            ArrayList subject = new ArrayList();
            ArrayList date = new ArrayList();
            ArrayList size = new ArrayList();
            DateTime date_time; string temp = "";

            this.MailMessages.Items.Clear();

            for (int i = 1; i <= obj.TotalEmails; i++)
            {
                string emailHeader = obj.FetchEmailTop(i, 0);
                sender.Add(obj.From);
                subject.Add(obj.Subject);
                try
                {
                    date_time = DateTime.Parse(obj.Date);
                    temp = date_time.ToString("D");
                    date.Add(temp);
                }
                catch (Exception)
                {
                    date.Add(obj.Date);
                }

                size.Add(obj.GetMailSize(i));
            }

            for (int j = 0; j < sender.Count; j++)
            {
                ListViewItem item = new ListViewItem();

                item.Text = sender[j].ToString();
                item.SubItems.Add(subject[j].ToString());
                item.SubItems.Add(date[j].ToString());
                item.SubItems.Add(size[j].ToString());

                this.InsertItem(item);
            }
        }




        // Helping Methods for Smtp Client user interface

        private void SendEmail(object mail_msg)
        {
            try
            {
                MailMessage mail_message = (MailMessage)mail_msg;

                SmtpClient smtp = new SmtpClient(this.SmtpServer.Text, Convert.ToInt32(this.SmtpPort.Text));
                smtp.UserName = this.UserName.Text;
                smtp.Password = this.Password.Text;

                this.EnableDisableSendButton(false);

                smtp.ConnectionEstablishing += new ConnectEventHandler(smtp_ConnectionEstablishing);
                smtp.ConnectionEstablished += new ConnectEventHandler(smtp_ConnectionEstablished);
                smtp.AuthenticationBegan += new AuthenticateEventHandler(smtp_AuthenticationBegan);
                smtp.AuthenticationFinished += new AuthenticateEventHandler(smtp_AuthenticationFinished);
                smtp.StartedDataTransfer += new DataTransferEventHandler(smtp_StartedDataTransfer);
                smtp.EndedDataTransfer += new DataTransferEventHandler(smtp_EndedDataTransfer);
                smtp.Disconnected += new DisconnectEventHandler(smtp_Disconnected);

                smtp.SendMail(mail_message);
                //MessageBox.Show(this, "Email successfuly sent", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Message_box dialog = new Message_box();
            }
            catch (SmtpClientException obj)
            {
                MessageBox.Show(this, obj.ErrorMessage, "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.EnableDisableSendButton(true);
                this.ProgressLabel.Text = "Email Client";
            }
        }

        private bool CheckInputValidation(string smtp_server, string smtp_port, string user_name, string password, string from, string to, string cc, string bcc, string proxy_server, string proxy_port)
        {
            if (smtp_server.Equals(""))
            {
                MessageBox.Show(this, "You must provide smtp server address.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (smtp_port.Equals(""))
            {
                MessageBox.Show(this, "You must provide smtp port number.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (proxy_server.Equals(""))
            {
                MessageBox.Show(this, "You must provide proxy address.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (proxy_port.Equals(""))
            {
                MessageBox.Show(this, "You must provide proxy port number.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (user_name.Equals(""))
            {
                MessageBox.Show(this, "You must provide username.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (password.Equals(""))
            {
                MessageBox.Show(this, "You must provide password.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (from.Equals(""))
            {
                MessageBox.Show(this, "You must provide sender email address.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if ((!(to.Equals(""))) || (!(cc.Equals(""))) || (!(bcc.Equals(""))))
            {
                return true;
            }
            else if (to.Equals("") && cc.Equals("") && bcc.Equals(""))
            {
                MessageBox.Show(this, "You must provide recipient email address.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

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

        private void SetSelectionFont()
        {
            if (this._lock == true)
                return;
            else
            {
                System.Drawing.FontStyle style = System.Drawing.FontStyle.Regular;
                if (((ToolStripButton)this.FormattingToolStrip.Items[3]).Checked)
                {
                    style |= System.Drawing.FontStyle.Bold;
                }
                if (((ToolStripButton)this.FormattingToolStrip.Items[4]).Checked)
                {
                    style |= System.Drawing.FontStyle.Italic;
                }
                if (((ToolStripButton)this.FormattingToolStrip.Items[5]).Checked)
                {
                    style |= System.Drawing.FontStyle.Underline;
                }
                try
                {
                    this.MailMessage.SelectionFont = new Font(((ToolStripComboBox)this.FormattingToolStrip.Items[0]).Text, Convert.ToSingle(((ToolStripComboBox)this.FormattingToolStrip.Items[1]).Text), style);
                    this.MailMessage.Focus();
                }
                catch (Exception)
                {
                }
            }
        }

        private Bitmap CreateFontColorIcon(Color color)
        {
            Bitmap bmp = Email_Client.Properties.Resources.fontcolor;

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
            Bitmap bmp = Email_Client.Properties.Resources.fontbackcolor;

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 12; y < bmp.Height; y++)
                {
                    bmp.SetPixel(x, y, color);
                }
            }

            return bmp;
        }
    }
}