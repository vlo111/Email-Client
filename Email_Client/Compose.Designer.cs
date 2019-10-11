namespace Email_Client
{
    partial class Compose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compose));
            this.ComposePanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.attachmentsList = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuThinButtonSend = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBoxClear = new System.Windows.Forms.PictureBox();
            this.pictureBoxCancelAttachment = new System.Windows.Forms.PictureBox();
            this.pictureBoxAttach = new System.Windows.Forms.PictureBox();
            this.bunifuMetroTextboxSubject = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextboxTo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextboxCc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextboxBcc = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.richTextBoxMailMessage = new System.Windows.Forms.RichTextBox();
            this.FormattingToolStrip = new System.Windows.Forms.ToolStrip();
            this.FontStyle = new System.Windows.Forms.ToolStripComboBox();
            this.FontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Bold = new System.Windows.Forms.ToolStripButton();
            this.Italic = new System.Windows.Forms.ToolStripButton();
            this.Underline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FontColor = new System.Windows.Forms.ToolStripButton();
            this.FontBackgroundColor = new System.Windows.Forms.ToolStripButton();
            this.ComposePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancelAttachment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttach)).BeginInit();
            this.FormattingToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComposePanel
            // 
            this.ComposePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComposePanel.Controls.Add(this.label5);
            this.ComposePanel.Controls.Add(this.label4);
            this.ComposePanel.Controls.Add(this.label2);
            this.ComposePanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.ComposePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComposePanel.Location = new System.Drawing.Point(0, 0);
            this.ComposePanel.Name = "ComposePanel";
            this.ComposePanel.Size = new System.Drawing.Size(783, 56);
            this.ComposePanel.TabIndex = 0;
            this.ComposePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ComposePanel_Paint);
            this.ComposePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ComposePanel_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(666, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 36);
            this.label5.TabIndex = 14;
            this.label5.Text = "_";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(713, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 36);
            this.label4.TabIndex = 13;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(276, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "A new message";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.ComposePanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipseForm
            // 
            this.bunifuElipseForm.ElipseRadius = 50;
            this.bunifuElipseForm.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(233, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bcc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(233, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 36);
            this.label7.TabIndex = 14;
            this.label7.Text = "Subject";
            // 
            // attachmentsList
            // 
            this.attachmentsList.BackColor = System.Drawing.Color.Black;
            this.attachmentsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.attachmentsList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachmentsList.ForeColor = System.Drawing.Color.White;
            this.attachmentsList.HideSelection = false;
            this.attachmentsList.Location = new System.Drawing.Point(28, 494);
            this.attachmentsList.MultiSelect = false;
            this.attachmentsList.Name = "attachmentsList";
            this.attachmentsList.Size = new System.Drawing.Size(629, 93);
            this.attachmentsList.TabIndex = 11;
            this.attachmentsList.UseCompatibleStateImageBehavior = false;
            this.attachmentsList.View = System.Windows.Forms.View.SmallIcon;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuThinButtonSend);
            this.panel2.Controls.Add(this.pictureBoxClear);
            this.panel2.Controls.Add(this.pictureBoxCancelAttachment);
            this.panel2.Controls.Add(this.pictureBoxAttach);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 656);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 90);
            this.panel2.TabIndex = 24;
            // 
            // bunifuThinButtonSend
            // 
            this.bunifuThinButtonSend.ActiveBorderThickness = 1;
            this.bunifuThinButtonSend.ActiveCornerRadius = 20;
            this.bunifuThinButtonSend.ActiveFillColor = System.Drawing.Color.Tomato;
            this.bunifuThinButtonSend.ActiveForecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButtonSend.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.bunifuThinButtonSend.BackColor = System.Drawing.Color.Black;
            this.bunifuThinButtonSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButtonSend.BackgroundImage")));
            this.bunifuThinButtonSend.ButtonText = "Send";
            this.bunifuThinButtonSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButtonSend.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButtonSend.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButtonSend.IdleBorderThickness = 1;
            this.bunifuThinButtonSend.IdleCornerRadius = 20;
            this.bunifuThinButtonSend.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.bunifuThinButtonSend.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButtonSend.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.bunifuThinButtonSend.Location = new System.Drawing.Point(28, 13);
            this.bunifuThinButtonSend.Margin = new System.Windows.Forms.Padding(5, 5, 20, 10);
            this.bunifuThinButtonSend.Name = "bunifuThinButtonSend";
            this.bunifuThinButtonSend.Size = new System.Drawing.Size(241, 58);
            this.bunifuThinButtonSend.TabIndex = 17;
            this.bunifuThinButtonSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButtonSend.Click += new System.EventHandler(this.bunifuThinButtonSend_Click);
            // 
            // pictureBoxClear
            // 
            this.pictureBoxClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClear.Image = global::Email_Client.Properties.Resources.trash;
            this.pictureBoxClear.Location = new System.Drawing.Point(700, 23);
            this.pictureBoxClear.Name = "pictureBoxClear";
            this.pictureBoxClear.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxClear.TabIndex = 22;
            this.pictureBoxClear.TabStop = false;
            this.pictureBoxClear.Click += new System.EventHandler(this.pictureBoxClear_Click);
            // 
            // pictureBoxCancelAttachment
            // 
            this.pictureBoxCancelAttachment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCancelAttachment.Image = global::Email_Client.Properties.Resources.cancel;
            this.pictureBoxCancelAttachment.Location = new System.Drawing.Point(364, 23);
            this.pictureBoxCancelAttachment.Name = "pictureBoxCancelAttachment";
            this.pictureBoxCancelAttachment.Size = new System.Drawing.Size(48, 48);
            this.pictureBoxCancelAttachment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCancelAttachment.TabIndex = 23;
            this.pictureBoxCancelAttachment.TabStop = false;
            this.pictureBoxCancelAttachment.Click += new System.EventHandler(this.pictureBoxCancelAttachment_Click);
            // 
            // pictureBoxAttach
            // 
            this.pictureBoxAttach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAttach.Image = global::Email_Client.Properties.Resources.paper;
            this.pictureBoxAttach.Location = new System.Drawing.Point(298, 23);
            this.pictureBoxAttach.Name = "pictureBoxAttach";
            this.pictureBoxAttach.Size = new System.Drawing.Size(48, 43);
            this.pictureBoxAttach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAttach.TabIndex = 21;
            this.pictureBoxAttach.TabStop = false;
            this.pictureBoxAttach.Click += new System.EventHandler(this.Attachment_Click);
            // 
            // bunifuMetroTextboxSubject
            // 
            this.bunifuMetroTextboxSubject.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextboxSubject.BorderColorIdle = System.Drawing.Color.LimeGreen;
            this.bunifuMetroTextboxSubject.BorderColorMouseHover = System.Drawing.Color.Brown;
            this.bunifuMetroTextboxSubject.BorderThickness = 3;
            this.bunifuMetroTextboxSubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextboxSubject.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextboxSubject.ForeColor = System.Drawing.Color.White;
            this.bunifuMetroTextboxSubject.isPassword = false;
            this.bunifuMetroTextboxSubject.Location = new System.Drawing.Point(161, 226);
            this.bunifuMetroTextboxSubject.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuMetroTextboxSubject.Name = "bunifuMetroTextboxSubject";
            this.bunifuMetroTextboxSubject.Size = new System.Drawing.Size(496, 45);
            this.bunifuMetroTextboxSubject.TabIndex = 29;
            this.bunifuMetroTextboxSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextboxTo
            // 
            this.bunifuMetroTextboxTo.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextboxTo.BorderColorIdle = System.Drawing.Color.LimeGreen;
            this.bunifuMetroTextboxTo.BorderColorMouseHover = System.Drawing.Color.Brown;
            this.bunifuMetroTextboxTo.BorderThickness = 3;
            this.bunifuMetroTextboxTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextboxTo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextboxTo.ForeColor = System.Drawing.Color.White;
            this.bunifuMetroTextboxTo.isPassword = false;
            this.bunifuMetroTextboxTo.Location = new System.Drawing.Point(161, 81);
            this.bunifuMetroTextboxTo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuMetroTextboxTo.Name = "bunifuMetroTextboxTo";
            this.bunifuMetroTextboxTo.Size = new System.Drawing.Size(496, 45);
            this.bunifuMetroTextboxTo.TabIndex = 25;
            this.bunifuMetroTextboxTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextboxCc
            // 
            this.bunifuMetroTextboxCc.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextboxCc.BorderColorIdle = System.Drawing.Color.LimeGreen;
            this.bunifuMetroTextboxCc.BorderColorMouseHover = System.Drawing.Color.Brown;
            this.bunifuMetroTextboxCc.BorderThickness = 3;
            this.bunifuMetroTextboxCc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextboxCc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextboxCc.ForeColor = System.Drawing.Color.White;
            this.bunifuMetroTextboxCc.isPassword = false;
            this.bunifuMetroTextboxCc.Location = new System.Drawing.Point(298, 135);
            this.bunifuMetroTextboxCc.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextboxCc.Name = "bunifuMetroTextboxCc";
            this.bunifuMetroTextboxCc.Size = new System.Drawing.Size(275, 33);
            this.bunifuMetroTextboxCc.TabIndex = 27;
            this.bunifuMetroTextboxCc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextboxBcc
            // 
            this.bunifuMetroTextboxBcc.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextboxBcc.BorderColorIdle = System.Drawing.Color.LimeGreen;
            this.bunifuMetroTextboxBcc.BorderColorMouseHover = System.Drawing.Color.Brown;
            this.bunifuMetroTextboxBcc.BorderThickness = 3;
            this.bunifuMetroTextboxBcc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextboxBcc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextboxBcc.ForeColor = System.Drawing.Color.White;
            this.bunifuMetroTextboxBcc.isPassword = false;
            this.bunifuMetroTextboxBcc.Location = new System.Drawing.Point(298, 171);
            this.bunifuMetroTextboxBcc.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextboxBcc.Name = "bunifuMetroTextboxBcc";
            this.bunifuMetroTextboxBcc.Size = new System.Drawing.Size(275, 33);
            this.bunifuMetroTextboxBcc.TabIndex = 28;
            this.bunifuMetroTextboxBcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // richTextBoxMailMessage
            // 
            this.richTextBoxMailMessage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxMailMessage.Location = new System.Drawing.Point(28, 279);
            this.richTextBoxMailMessage.Name = "richTextBoxMailMessage";
            this.richTextBoxMailMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBoxMailMessage.Size = new System.Drawing.Size(629, 197);
            this.richTextBoxMailMessage.TabIndex = 30;
            this.richTextBoxMailMessage.Text = "";
            this.richTextBoxMailMessage.SelectionChanged += new System.EventHandler(this.richTextBoxMailMessage_SelectionChanged);
            // 
            // FormattingToolStrip
            // 
            this.FormattingToolStrip.AutoSize = false;
            this.FormattingToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.FormattingToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.FormattingToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontStyle,
            this.FontSize,
            this.toolStripSeparator1,
            this.Bold,
            this.Italic,
            this.Underline,
            this.toolStripSeparator2,
            this.FontColor,
            this.FontBackgroundColor});
            this.FormattingToolStrip.Location = new System.Drawing.Point(28, 603);
            this.FormattingToolStrip.Name = "FormattingToolStrip";
            this.FormattingToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.FormattingToolStrip.Size = new System.Drawing.Size(413, 37);
            this.FormattingToolStrip.TabIndex = 31;
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
            this.FontStyle.Size = new System.Drawing.Size(170, 37);
            this.FontStyle.ToolTipText = "Font style";
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
            this.FontSize.Size = new System.Drawing.Size(90, 37);
            this.FontSize.ToolTipText = "Font Size";
            this.FontSize.SelectedIndexChanged += new System.EventHandler(this.FontSize_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // Bold
            // 
            this.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bold.Image = ((System.Drawing.Image)(resources.GetObject("Bold.Image")));
            this.Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(23, 34);
            this.Bold.ToolTipText = "Bold";
            this.Bold.Click += new System.EventHandler(this.Bold_Click);
            // 
            // Italic
            // 
            this.Italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Italic.Image = ((System.Drawing.Image)(resources.GetObject("Italic.Image")));
            this.Italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(23, 34);
            this.Italic.ToolTipText = "Italic";
            this.Italic.Click += new System.EventHandler(this.Italic_Click);
            // 
            // Underline
            // 
            this.Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Underline.Image = global::Email_Client.Properties.Resources.underline;
            this.Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(23, 34);
            this.Underline.ToolTipText = "Underline";
            this.Underline.Click += new System.EventHandler(this.Underline_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // FontColor
            // 
            this.FontColor.BackColor = System.Drawing.Color.White;
            this.FontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontColor.Image = global::Email_Client.Properties.Resources.fontcolor;
            this.FontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontColor.Name = "FontColor";
            this.FontColor.Size = new System.Drawing.Size(23, 34);
            this.FontColor.ToolTipText = "FontColor";
            this.FontColor.Click += new System.EventHandler(this.FontColor_Click);
            // 
            // FontBackgroundColor
            // 
            this.FontBackgroundColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontBackgroundColor.Image = global::Email_Client.Properties.Resources.fontbackcolor;
            this.FontBackgroundColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontBackgroundColor.Name = "FontBackgroundColor";
            this.FontBackgroundColor.Size = new System.Drawing.Size(23, 34);
            this.FontBackgroundColor.ToolTipText = "Font Background Color";
            this.FontBackgroundColor.Click += new System.EventHandler(this.FontBackgroundColor_Click);
            // 
            // Compose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(783, 746);
            this.Controls.Add(this.FormattingToolStrip);
            this.Controls.Add(this.richTextBoxMailMessage);
            this.Controls.Add(this.bunifuMetroTextboxSubject);
            this.Controls.Add(this.bunifuMetroTextboxBcc);
            this.Controls.Add(this.bunifuMetroTextboxCc);
            this.Controls.Add(this.bunifuMetroTextboxTo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.attachmentsList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComposePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Compose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compose";
            this.ComposePanel.ResumeLayout(false);
            this.ComposePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancelAttachment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttach)).EndInit();
            this.FormattingToolStrip.ResumeLayout(false);
            this.FormattingToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ComposePanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButtonSend;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView attachmentsList;
        private System.Windows.Forms.PictureBox pictureBoxAttach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxClear;
        private System.Windows.Forms.PictureBox pictureBoxCancelAttachment;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextboxSubject;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextboxBcc;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextboxCc;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextboxTo;
        private System.Windows.Forms.RichTextBox richTextBoxMailMessage;
        private System.Windows.Forms.ToolStrip FormattingToolStrip;
        private System.Windows.Forms.ToolStripComboBox FontStyle;
        private System.Windows.Forms.ToolStripComboBox FontSize;
        private System.Windows.Forms.ToolStripButton Bold;
        private System.Windows.Forms.ToolStripButton Italic;
        private System.Windows.Forms.ToolStripButton Underline;
        private System.Windows.Forms.ToolStripButton FontColor;
        private System.Windows.Forms.ToolStripButton FontBackgroundColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}