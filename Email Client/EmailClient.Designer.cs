namespace Email_Client
{
    partial class EmailClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailClient));
            this.EmailTab = new System.Windows.Forms.TabControl();
            this.CheckMailTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PopMessage = new System.Windows.Forms.WebBrowser();
            this.SaveAttachmentToolStrip = new System.Windows.Forms.ToolStrip();
            this.DownloadAttachment = new System.Windows.Forms.ToolStripButton();
            this.PopAttachments = new System.Windows.Forms.ListView();
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SubjectPopHeader = new System.Windows.Forms.TextBox();
            this.ToPopHeader = new System.Windows.Forms.TextBox();
            this.FromPopHeader = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MailMessages = new System.Windows.Forms.ListView();
            this.Sender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pop3LogOn = new System.Windows.Forms.GroupBox();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Connect = new System.Windows.Forms.Button();
            this.PopPassword = new System.Windows.Forms.TextBox();
            this.PopUserName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PopPort = new System.Windows.Forms.TextBox();
            this.PopServer = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ComposeMailTab = new System.Windows.Forms.TabPage();
            this.SmtpClear = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MailMessage = new System.Windows.Forms.RichTextBox();
            this.FormattingToolStrip = new System.Windows.Forms.ToolStrip();
            this.FontStyle = new System.Windows.Forms.ToolStripComboBox();
            this.FontSize = new System.Windows.Forms.ToolStripComboBox();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Bold = new System.Windows.Forms.ToolStripButton();
            this.Italic = new System.Windows.Forms.ToolStripButton();
            this.Underline = new System.Windows.Forms.ToolStripButton();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FontColor = new System.Windows.Forms.ToolStripButton();
            this.FontBackgroundColor = new System.Windows.Forms.ToolStripButton();
            this.AttachmentToolStrip = new System.Windows.Forms.ToolStrip();
            this.AddAttachment = new System.Windows.Forms.ToolStripButton();
            this.DeleteAttachment = new System.Windows.Forms.ToolStripButton();
            this.Attachments = new System.Windows.Forms.ListView();
            this.label10 = new System.Windows.Forms.Label();
            this.Subject = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Bcc = new System.Windows.Forms.TextBox();
            this.Cc = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.TextBox();
            this.From = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SmtpLogOn = new System.Windows.Forms.GroupBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SmtpPort = new System.Windows.Forms.TextBox();
            this.SmtpServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.EmailTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.ProgressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProxyServerL = new System.Windows.Forms.Label();
            this.ProcyPortL = new System.Windows.Forms.Label();
            this.ProxyServerTB = new System.Windows.Forms.TextBox();
            this.ProxyPortTB = new System.Windows.Forms.TextBox();
            this.EmailTab.SuspendLayout();
            this.CheckMailTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SaveAttachmentToolStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Pop3LogOn.SuspendLayout();
            this.ComposeMailTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.FormattingToolStrip.SuspendLayout();
            this.AttachmentToolStrip.SuspendLayout();
            this.SmtpLogOn.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmailTab
            // 
            this.EmailTab.Controls.Add(this.CheckMailTab);
            this.EmailTab.Controls.Add(this.ComposeMailTab);
            this.EmailTab.Location = new System.Drawing.Point(26, 8);
            this.EmailTab.Name = "EmailTab";
            this.EmailTab.SelectedIndex = 0;
            this.EmailTab.Size = new System.Drawing.Size(656, 507);
            this.EmailTab.TabIndex = 0;
            // 
            // CheckMailTab
            // 
            this.CheckMailTab.Controls.Add(this.groupBox3);
            this.CheckMailTab.Controls.Add(this.groupBox2);
            this.CheckMailTab.Controls.Add(this.Pop3LogOn);
            this.CheckMailTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckMailTab.Location = new System.Drawing.Point(4, 22);
            this.CheckMailTab.Name = "CheckMailTab";
            this.CheckMailTab.Padding = new System.Windows.Forms.Padding(3);
            this.CheckMailTab.Size = new System.Drawing.Size(648, 481);
            this.CheckMailTab.TabIndex = 0;
            this.CheckMailTab.Text = "Check Mail";
            this.CheckMailTab.ToolTipText = "Check Email";
            this.CheckMailTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PopMessage);
            this.groupBox3.Controls.Add(this.SaveAttachmentToolStrip);
            this.groupBox3.Controls.Add(this.PopAttachments);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.SubjectPopHeader);
            this.groupBox3.Controls.Add(this.ToPopHeader);
            this.groupBox3.Controls.Add(this.FromPopHeader);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Silver;
            this.groupBox3.Location = new System.Drawing.Point(27, 271);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 193);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected Message";
            // 
            // PopMessage
            // 
            this.PopMessage.Location = new System.Drawing.Point(86, 99);
            this.PopMessage.MinimumSize = new System.Drawing.Size(20, 20);
            this.PopMessage.Name = "PopMessage";
            this.PopMessage.Size = new System.Drawing.Size(482, 78);
            this.PopMessage.TabIndex = 11;
            // 
            // SaveAttachmentToolStrip
            // 
            this.SaveAttachmentToolStrip.AutoSize = false;
            this.SaveAttachmentToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.SaveAttachmentToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.SaveAttachmentToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DownloadAttachment});
            this.SaveAttachmentToolStrip.Location = new System.Drawing.Point(546, 14);
            this.SaveAttachmentToolStrip.Name = "SaveAttachmentToolStrip";
            this.SaveAttachmentToolStrip.Size = new System.Drawing.Size(43, 25);
            this.SaveAttachmentToolStrip.TabIndex = 10;
            // 
            // DownloadAttachment
            // 
            this.DownloadAttachment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DownloadAttachment.Enabled = false;
            this.DownloadAttachment.Image = global::Email_Client.Properties.Resources.DownloadFile;
            this.DownloadAttachment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DownloadAttachment.Name = "DownloadAttachment";
            this.DownloadAttachment.Size = new System.Drawing.Size(23, 22);
            this.DownloadAttachment.ToolTipText = "Save an attachment";
            this.DownloadAttachment.Click += new System.EventHandler(this.DownloadAttachment_Click);
            // 
            // PopAttachments
            // 
            this.PopAttachments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopAttachments.HideSelection = false;
            this.PopAttachments.Location = new System.Drawing.Point(336, 42);
            this.PopAttachments.MultiSelect = false;
            this.PopAttachments.Name = "PopAttachments";
            this.PopAttachments.Size = new System.Drawing.Size(232, 51);
            this.PopAttachments.SmallImageList = this.images;
            this.PopAttachments.TabIndex = 9;
            this.PopAttachments.UseCompatibleStateImageBehavior = false;
            this.PopAttachments.View = System.Windows.Forms.View.SmallIcon;
            this.PopAttachments.SelectedIndexChanged += new System.EventHandler(this.PopAttachments_SelectedIndexChanged);
            // 
            // images
            // 
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.Color.Transparent;
            this.images.Images.SetKeyName(0, "attachment.ico");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(336, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 16);
            this.label20.TabIndex = 8;
            this.label20.Text = "Attachments:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(5, 102);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 16);
            this.label19.TabIndex = 6;
            this.label19.Text = "Message:";
            // 
            // SubjectPopHeader
            // 
            this.SubjectPopHeader.BackColor = System.Drawing.SystemColors.Window;
            this.SubjectPopHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubjectPopHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectPopHeader.Location = new System.Drawing.Point(86, 71);
            this.SubjectPopHeader.Name = "SubjectPopHeader";
            this.SubjectPopHeader.ReadOnly = true;
            this.SubjectPopHeader.Size = new System.Drawing.Size(244, 21);
            this.SubjectPopHeader.TabIndex = 5;
            // 
            // ToPopHeader
            // 
            this.ToPopHeader.BackColor = System.Drawing.SystemColors.Window;
            this.ToPopHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToPopHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToPopHeader.Location = new System.Drawing.Point(86, 45);
            this.ToPopHeader.Name = "ToPopHeader";
            this.ToPopHeader.ReadOnly = true;
            this.ToPopHeader.Size = new System.Drawing.Size(244, 21);
            this.ToPopHeader.TabIndex = 4;
            // 
            // FromPopHeader
            // 
            this.FromPopHeader.BackColor = System.Drawing.SystemColors.Window;
            this.FromPopHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FromPopHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromPopHeader.Location = new System.Drawing.Point(86, 19);
            this.FromPopHeader.Name = "FromPopHeader";
            this.FromPopHeader.ReadOnly = true;
            this.FromPopHeader.Size = new System.Drawing.Size(244, 21);
            this.FromPopHeader.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(12, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "Subject:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(22, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 16);
            this.label17.TabIndex = 1;
            this.label17.Text = "To:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(22, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "From:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MailMessages);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Silver;
            this.groupBox2.Location = new System.Drawing.Point(27, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 175);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inbox";
            // 
            // MailMessages
            // 
            this.MailMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MailMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sender,
            this.SubjectList,
            this.Date,
            this.Size});
            this.MailMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailMessages.FullRowSelect = true;
            this.MailMessages.HideSelection = false;
            this.MailMessages.Location = new System.Drawing.Point(19, 21);
            this.MailMessages.MultiSelect = false;
            this.MailMessages.Name = "MailMessages";
            this.MailMessages.Size = new System.Drawing.Size(549, 139);
            this.MailMessages.TabIndex = 0;
            this.MailMessages.UseCompatibleStateImageBehavior = false;
            this.MailMessages.View = System.Windows.Forms.View.Details;
            this.MailMessages.SelectedIndexChanged += new System.EventHandler(this.MailMessages_SelectedIndexChanged);
            this.MailMessages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MailMessages_MouseClick);
            // 
            // Sender
            // 
            this.Sender.Text = "Sender";
            this.Sender.Width = 120;
            // 
            // SubjectList
            // 
            this.SubjectList.Text = "Subject";
            this.SubjectList.Width = 200;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 120;
            // 
            // Size
            // 
            this.Size.Text = "Size (in bytes)";
            this.Size.Width = 100;
            // 
            // Pop3LogOn
            // 
            this.Pop3LogOn.Controls.Add(this.Disconnect);
            this.Pop3LogOn.Controls.Add(this.Connect);
            this.Pop3LogOn.Controls.Add(this.PopPassword);
            this.Pop3LogOn.Controls.Add(this.PopUserName);
            this.Pop3LogOn.Controls.Add(this.label12);
            this.Pop3LogOn.Controls.Add(this.label13);
            this.Pop3LogOn.Controls.Add(this.PopPort);
            this.Pop3LogOn.Controls.Add(this.PopServer);
            this.Pop3LogOn.Controls.Add(this.label14);
            this.Pop3LogOn.Controls.Add(this.label15);
            this.Pop3LogOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pop3LogOn.ForeColor = System.Drawing.Color.Silver;
            this.Pop3LogOn.Location = new System.Drawing.Point(27, 8);
            this.Pop3LogOn.Name = "Pop3LogOn";
            this.Pop3LogOn.Size = new System.Drawing.Size(590, 85);
            this.Pop3LogOn.TabIndex = 1;
            this.Pop3LogOn.TabStop = false;
            this.Pop3LogOn.Text = "Log on to Pop3 Server";
            // 
            // Disconnect
            // 
            this.Disconnect.Enabled = false;
            this.Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Disconnect.Location = new System.Drawing.Point(487, 19);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(87, 23);
            this.Disconnect.TabIndex = 9;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Connect
            // 
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Connect.Location = new System.Drawing.Point(487, 46);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(87, 23);
            this.Connect.TabIndex = 8;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // PopPassword
            // 
            this.PopPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopPassword.Location = new System.Drawing.Point(319, 46);
            this.PopPassword.Name = "PopPassword";
            this.PopPassword.PasswordChar = '*';
            this.PopPassword.Size = new System.Drawing.Size(158, 21);
            this.PopPassword.TabIndex = 7;
            this.EmailToolTip.SetToolTip(this.PopPassword, "Type password");
            // 
            // PopUserName
            // 
            this.PopUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopUserName.Location = new System.Drawing.Point(84, 46);
            this.PopUserName.Name = "PopUserName";
            this.PopUserName.Size = new System.Drawing.Size(158, 21);
            this.PopUserName.TabIndex = 6;
            this.EmailToolTip.SetToolTip(this.PopUserName, "Type user name");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(249, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Password :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(6, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 15);
            this.label13.TabIndex = 4;
            this.label13.Text = "User Name :";
            // 
            // PopPort
            // 
            this.PopPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopPort.Location = new System.Drawing.Point(319, 18);
            this.PopPort.Name = "PopPort";
            this.PopPort.Size = new System.Drawing.Size(158, 21);
            this.PopPort.TabIndex = 3;
            this.EmailToolTip.SetToolTip(this.PopPort, "Type pop server port number");
            this.PopPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PopPort_KeyPress);
            // 
            // PopServer
            // 
            this.PopServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopServer.Location = new System.Drawing.Point(84, 19);
            this.PopServer.Name = "PopServer";
            this.PopServer.Size = new System.Drawing.Size(158, 21);
            this.PopServer.TabIndex = 2;
            this.EmailToolTip.SetToolTip(this.PopServer, "Type pop server address");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(249, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Pop Port :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(6, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Pop Server :";
            // 
            // ComposeMailTab
            // 
            this.ComposeMailTab.Controls.Add(this.SmtpClear);
            this.ComposeMailTab.Controls.Add(this.Send);
            this.ComposeMailTab.Controls.Add(this.groupBox1);
            this.ComposeMailTab.Controls.Add(this.SmtpLogOn);
            this.ComposeMailTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComposeMailTab.Location = new System.Drawing.Point(4, 22);
            this.ComposeMailTab.Name = "ComposeMailTab";
            this.ComposeMailTab.Padding = new System.Windows.Forms.Padding(3);
            this.ComposeMailTab.Size = new System.Drawing.Size(648, 481);
            this.ComposeMailTab.TabIndex = 1;
            this.ComposeMailTab.Text = "Compose Mail";
            this.ComposeMailTab.ToolTipText = "Compose Email";
            this.ComposeMailTab.UseVisualStyleBackColor = true;
            // 
            // SmtpClear
            // 
            this.SmtpClear.Image = global::Email_Client.Properties.Resources.Clear;
            this.SmtpClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SmtpClear.Location = new System.Drawing.Point(526, 433);
            this.SmtpClear.Name = "SmtpClear";
            this.SmtpClear.Size = new System.Drawing.Size(79, 36);
            this.SmtpClear.TabIndex = 3;
            this.SmtpClear.Text = "Clear";
            this.SmtpClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EmailToolTip.SetToolTip(this.SmtpClear, "Clear text in fields");
            this.SmtpClear.UseVisualStyleBackColor = true;
            this.SmtpClear.Click += new System.EventHandler(this.SmtpClear_Click);
            // 
            // Send
            // 
            this.Send.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Send.Image = global::Email_Client.Properties.Resources.New_Email;
            this.Send.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Send.Location = new System.Drawing.Point(430, 433);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(79, 36);
            this.Send.TabIndex = 2;
            this.Send.Text = "Send";
            this.Send.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EmailToolTip.SetToolTip(this.Send, "Send an email message");
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.MailMessage);
            this.groupBox1.Controls.Add(this.FormattingToolStrip);
            this.groupBox1.Controls.Add(this.AttachmentToolStrip);
            this.groupBox1.Controls.Add(this.Attachments);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Subject);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Bcc);
            this.groupBox1.Controls.Add(this.Cc);
            this.groupBox1.Controls.Add(this.To);
            this.groupBox1.Controls.Add(this.From);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(27, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 286);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Mail Message";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(9, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Message :";
            // 
            // MailMessage
            // 
            this.MailMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailMessage.Location = new System.Drawing.Point(89, 198);
            this.MailMessage.Name = "MailMessage";
            this.MailMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.MailMessage.Size = new System.Drawing.Size(485, 106);
            this.MailMessage.TabIndex = 14;
            this.MailMessage.Text = "";
            this.EmailToolTip.SetToolTip(this.MailMessage, "Type message here");
            this.MailMessage.SelectionChanged += new System.EventHandler(this.MailMessage_SelectionChanged);
            // 
            // FormattingToolStrip
            // 
            this.FormattingToolStrip.AutoSize = false;
            this.FormattingToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.FormattingToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.FormattingToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontStyle,
            this.FontSize,
            this.Separator1,
            this.Bold,
            this.Italic,
            this.Underline,
            this.Separator2,
            this.FontColor,
            this.FontBackgroundColor});
            this.FormattingToolStrip.Location = new System.Drawing.Point(89, 168);
            this.FormattingToolStrip.Name = "FormattingToolStrip";
            this.FormattingToolStrip.Size = new System.Drawing.Size(374, 25);
            this.FormattingToolStrip.TabIndex = 13;
            // 
            // FontStyle
            // 
            this.FontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontStyle.Items.AddRange(new object[] {
            "Arial",
            "Courier New",
            "Times New Roman",
            "Verdana"});
            this.FontStyle.Name = "FontStyle";
            this.FontStyle.Size = new System.Drawing.Size(150, 25);
            this.FontStyle.Text = "Arial";
            this.FontStyle.ToolTipText = "Font";
            this.FontStyle.SelectedIndexChanged += new System.EventHandler(this.FontStyle_SelectedIndexChanged);
            // 
            // FontSize
            // 
            this.FontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "18",
            "24",
            "32",
            "36"});
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(75, 25);
            this.FontSize.Text = "10";
            this.FontSize.ToolTipText = "Font Size";
            this.FontSize.SelectedIndexChanged += new System.EventHandler(this.FontSize_SelectedIndexChanged);
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Bold
            // 
            this.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bold.Image = global::Email_Client.Properties.Resources.bold;
            this.Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(23, 22);
            this.Bold.ToolTipText = "Bold";
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // Italic
            // 
            this.Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Italic.Image = global::Email_Client.Properties.Resources.italic;
            this.Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(23, 22);
            this.Italic.ToolTipText = "Italic";
            this.Italic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // Underline
            // 
            this.Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Underline.Image = global::Email_Client.Properties.Resources.underline;
            this.Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(23, 22);
            this.Underline.ToolTipText = "Underline";
            this.Underline.Click += new System.EventHandler(this.Underline_Click);
            // 
            // Separator2
            // 
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(6, 25);
            // 
            // FontColor
            // 
            this.FontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontColor.Image = global::Email_Client.Properties.Resources.fontcolor;
            this.FontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontColor.Name = "FontColor";
            this.FontColor.Size = new System.Drawing.Size(23, 22);
            this.FontColor.ToolTipText = "Font Color";
            this.FontColor.Click += new System.EventHandler(this.FontColor_Click);
            // 
            // FontBackgroundColor
            // 
            this.FontBackgroundColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontBackgroundColor.Image = global::Email_Client.Properties.Resources.fontbackcolor;
            this.FontBackgroundColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontBackgroundColor.Name = "FontBackgroundColor";
            this.FontBackgroundColor.Size = new System.Drawing.Size(23, 22);
            this.FontBackgroundColor.ToolTipText = "Font Background Color";
            this.FontBackgroundColor.Click += new System.EventHandler(this.FontBackgroundColor_Click);
            // 
            // AttachmentToolStrip
            // 
            this.AttachmentToolStrip.AutoSize = false;
            this.AttachmentToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.AttachmentToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.AttachmentToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAttachment,
            this.DeleteAttachment});
            this.AttachmentToolStrip.Location = new System.Drawing.Point(455, 101);
            this.AttachmentToolStrip.Name = "AttachmentToolStrip";
            this.AttachmentToolStrip.Size = new System.Drawing.Size(65, 25);
            this.AttachmentToolStrip.TabIndex = 12;
            this.AttachmentToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.AttachmentToolStrip_ItemClicked);
            // 
            // AddAttachment
            // 
            this.AddAttachment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddAttachment.Image = global::Email_Client.Properties.Resources.add;
            this.AddAttachment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddAttachment.Name = "AddAttachment";
            this.AddAttachment.Size = new System.Drawing.Size(23, 22);
            this.AddAttachment.Tag = "Add";
            this.AddAttachment.ToolTipText = "Add an attachment";
            // 
            // DeleteAttachment
            // 
            this.DeleteAttachment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteAttachment.Enabled = false;
            this.DeleteAttachment.Image = global::Email_Client.Properties.Resources.delete;
            this.DeleteAttachment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteAttachment.Name = "DeleteAttachment";
            this.DeleteAttachment.Size = new System.Drawing.Size(23, 22);
            this.DeleteAttachment.Tag = "Delete";
            this.DeleteAttachment.ToolTipText = "Remove an attachment";
            // 
            // Attachments
            // 
            this.Attachments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attachments.HideSelection = false;
            this.Attachments.Location = new System.Drawing.Point(89, 106);
            this.Attachments.MultiSelect = false;
            this.Attachments.Name = "Attachments";
            this.Attachments.Size = new System.Drawing.Size(360, 58);
            this.Attachments.SmallImageList = this.images;
            this.Attachments.TabIndex = 11;
            this.EmailToolTip.SetToolTip(this.Attachments, "Attachments list");
            this.Attachments.UseCompatibleStateImageBehavior = false;
            this.Attachments.View = System.Windows.Forms.View.SmallIcon;
            this.Attachments.SelectedIndexChanged += new System.EventHandler(this.Attachments_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(5, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Attachments :";
            // 
            // Subject
            // 
            this.Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject.Location = new System.Drawing.Point(87, 78);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(206, 21);
            this.Subject.TabIndex = 9;
            this.EmailToolTip.SetToolTip(this.Subject, "Type the subject for this message");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(9, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Subject :";
            // 
            // Bcc
            // 
            this.Bcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcc.Location = new System.Drawing.Point(368, 51);
            this.Bcc.Name = "Bcc";
            this.Bcc.Size = new System.Drawing.Size(206, 21);
            this.Bcc.TabIndex = 7;
            this.EmailToolTip.SetToolTip(this.Bcc, "Type recipients\' email addresses, separated by semicolons or commas");
            // 
            // Cc
            // 
            this.Cc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cc.Location = new System.Drawing.Point(87, 51);
            this.Cc.Name = "Cc";
            this.Cc.Size = new System.Drawing.Size(206, 21);
            this.Cc.TabIndex = 6;
            this.EmailToolTip.SetToolTip(this.Cc, "Type recipients\' email addresses, separated by semicolons or commas");
            // 
            // To
            // 
            this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.Location = new System.Drawing.Point(368, 24);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(206, 21);
            this.To.TabIndex = 5;
            this.EmailToolTip.SetToolTip(this.To, "Type recipients\' email addresses, separated by semicolons or commas");
            // 
            // From
            // 
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Location = new System.Drawing.Point(87, 24);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(206, 21);
            this.From.TabIndex = 4;
            this.EmailToolTip.SetToolTip(this.From, "Type sender email address");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(309, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Bcc :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(16, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cc :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(309, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "To :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(16, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "From :";
            // 
            // SmtpLogOn
            // 
            this.SmtpLogOn.Controls.Add(this.ProxyPortTB);
            this.SmtpLogOn.Controls.Add(this.ProxyServerTB);
            this.SmtpLogOn.Controls.Add(this.ProcyPortL);
            this.SmtpLogOn.Controls.Add(this.ProxyServerL);
            this.SmtpLogOn.Controls.Add(this.Password);
            this.SmtpLogOn.Controls.Add(this.UserName);
            this.SmtpLogOn.Controls.Add(this.label4);
            this.SmtpLogOn.Controls.Add(this.label3);
            this.SmtpLogOn.Controls.Add(this.SmtpPort);
            this.SmtpLogOn.Controls.Add(this.SmtpServer);
            this.SmtpLogOn.Controls.Add(this.label2);
            this.SmtpLogOn.Controls.Add(this.label1);
            this.SmtpLogOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmtpLogOn.ForeColor = System.Drawing.Color.Silver;
            this.SmtpLogOn.Location = new System.Drawing.Point(27, 10);
            this.SmtpLogOn.Name = "SmtpLogOn";
            this.SmtpLogOn.Size = new System.Drawing.Size(597, 125);
            this.SmtpLogOn.TabIndex = 0;
            this.SmtpLogOn.TabStop = false;
            this.SmtpLogOn.Text = "Log on to Smtp Server";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(398, 98);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(176, 21);
            this.Password.TabIndex = 7;
            this.EmailToolTip.SetToolTip(this.Password, "Type password");
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(117, 98);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(176, 21);
            this.UserName.TabIndex = 6;
            this.EmailToolTip.SetToolTip(this.UserName, "Type user name");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(309, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Name :";
            // 
            // SmtpPort
            // 
            this.SmtpPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmtpPort.Location = new System.Drawing.Point(398, 24);
            this.SmtpPort.Name = "SmtpPort";
            this.SmtpPort.Size = new System.Drawing.Size(176, 21);
            this.SmtpPort.TabIndex = 3;
            this.EmailToolTip.SetToolTip(this.SmtpPort, "Type smtp server port number");
            this.SmtpPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SmtpPort_KeyPress);
            // 
            // SmtpServer
            // 
            this.SmtpServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmtpServer.Location = new System.Drawing.Point(117, 24);
            this.SmtpServer.Name = "SmtpServer";
            this.SmtpServer.Size = new System.Drawing.Size(176, 21);
            this.SmtpServer.TabIndex = 2;
            this.EmailToolTip.SetToolTip(this.SmtpServer, "Type smtp server address");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(309, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Smtp Port :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Smtp Server :";
            // 
            // EmailTimer
            // 
            this.EmailTimer.Enabled = true;
            this.EmailTimer.Interval = 10;
            this.EmailTimer.Tick += new System.EventHandler(this.EmailTimer_Tick);
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressLabel});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip.Location = new System.Drawing.Point(0, 525);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(706, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(61, 17);
            this.ProgressLabel.Text = "Email Client";
            // 
            // ProxyServerL
            // 
            this.ProxyServerL.AutoSize = true;
            this.ProxyServerL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProxyServerL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProxyServerL.Location = new System.Drawing.Point(16, 61);
            this.ProxyServerL.Name = "ProxyServerL";
            this.ProxyServerL.Size = new System.Drawing.Size(81, 15);
            this.ProxyServerL.TabIndex = 8;
            this.ProxyServerL.Text = "Proxy Server :";
            // 
            // ProcyPortL
            // 
            this.ProcyPortL.AutoSize = true;
            this.ProcyPortL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProcyPortL.ForeColor = System.Drawing.Color.Black;
            this.ProcyPortL.Location = new System.Drawing.Point(309, 61);
            this.ProcyPortL.Name = "ProcyPortL";
            this.ProcyPortL.Size = new System.Drawing.Size(68, 15);
            this.ProcyPortL.TabIndex = 9;
            this.ProcyPortL.Text = "Proxy Port :";
            // 
            // ProxyServerTB
            // 
            this.ProxyServerTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProxyServerTB.Location = new System.Drawing.Point(117, 61);
            this.ProxyServerTB.Name = "ProxyServerTB";
            this.ProxyServerTB.Size = new System.Drawing.Size(176, 21);
            this.ProxyServerTB.TabIndex = 10;
            // 
            // ProxyPortTB
            // 
            this.ProxyPortTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProxyPortTB.Location = new System.Drawing.Point(398, 61);
            this.ProxyPortTB.Name = "ProxyPortTB";
            this.ProxyPortTB.Size = new System.Drawing.Size(176, 21);
            this.ProxyPortTB.TabIndex = 11;
            // 
            // EmailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 547);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.EmailTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EmailClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Client";
            this.EmailTab.ResumeLayout(false);
            this.CheckMailTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.SaveAttachmentToolStrip.ResumeLayout(false);
            this.SaveAttachmentToolStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.Pop3LogOn.ResumeLayout(false);
            this.Pop3LogOn.PerformLayout();
            this.ComposeMailTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FormattingToolStrip.ResumeLayout(false);
            this.FormattingToolStrip.PerformLayout();
            this.AttachmentToolStrip.ResumeLayout(false);
            this.AttachmentToolStrip.PerformLayout();
            this.SmtpLogOn.ResumeLayout(false);
            this.SmtpLogOn.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl EmailTab;
        private System.Windows.Forms.TabPage CheckMailTab;
        private System.Windows.Forms.TabPage ComposeMailTab;
        private System.Windows.Forms.GroupBox SmtpLogOn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SmtpPort;
        private System.Windows.Forms.TextBox SmtpServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox From;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.TextBox Bcc;
        private System.Windows.Forms.TextBox Cc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView Attachments;
        private System.Windows.Forms.ToolStrip AttachmentToolStrip;
        private System.Windows.Forms.ToolStripButton AddAttachment;
        private System.Windows.Forms.ToolStripButton DeleteAttachment;
        private System.Windows.Forms.ToolStrip FormattingToolStrip;
        private System.Windows.Forms.ToolStripComboBox FontStyle;
        private System.Windows.Forms.ToolStripComboBox FontSize;
        private System.Windows.Forms.ToolStripButton Bold;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.ToolStripButton Italic;
        private System.Windows.Forms.ToolStripButton Underline;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.ToolStripButton FontColor;
        private System.Windows.Forms.ToolStripButton FontBackgroundColor;
        private System.Windows.Forms.RichTextBox MailMessage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.ToolTip EmailToolTip;
        private System.Windows.Forms.Timer EmailTimer;
        private System.Windows.Forms.GroupBox Pop3LogOn;
        private System.Windows.Forms.TextBox PopPassword;
        private System.Windows.Forms.TextBox PopUserName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PopPort;
        private System.Windows.Forms.TextBox PopServer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView MailMessages;
        private System.Windows.Forms.ColumnHeader Sender;
        private System.Windows.Forms.ColumnHeader SubjectList;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox SubjectPopHeader;
        private System.Windows.Forms.TextBox ToPopHeader;
        private System.Windows.Forms.TextBox FromPopHeader;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ListView PopAttachments;
        private System.Windows.Forms.ToolStrip SaveAttachmentToolStrip;
        private System.Windows.Forms.ToolStripButton DownloadAttachment;
        private System.Windows.Forms.ImageList images;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ProgressLabel;
        private System.Windows.Forms.Button SmtpClear;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.WebBrowser PopMessage;
        private System.Windows.Forms.TextBox ProxyPortTB;
        private System.Windows.Forms.TextBox ProxyServerTB;
        private System.Windows.Forms.Label ProcyPortL;
        private System.Windows.Forms.Label ProxyServerL;
    }
}

