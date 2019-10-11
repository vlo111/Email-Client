using System;

namespace Email_Client
{
    partial class LoginEMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginEMail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuFlatButtonGoBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.ProgressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bunifuMaterialTextboxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipseForPasswodTBox = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFlatButtonShowHidePassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuThinButtonFurther = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuTextboxPassword = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTextboxLogin = new Bunifu.Framework.UI.BunifuTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bunifuFlatButtonGoBack);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 56);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // bunifuFlatButtonGoBack
            // 
            this.bunifuFlatButtonGoBack.Activecolor = System.Drawing.Color.Black;
            this.bunifuFlatButtonGoBack.BackColor = System.Drawing.Color.Black;
            this.bunifuFlatButtonGoBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButtonGoBack.BackgroundImage")));
            this.bunifuFlatButtonGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonGoBack.BorderRadius = 0;
            this.bunifuFlatButtonGoBack.ButtonText = "";
            this.bunifuFlatButtonGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButtonGoBack.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonGoBack.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonGoBack.Iconimage = null;
            this.bunifuFlatButtonGoBack.Iconimage_right = null;
            this.bunifuFlatButtonGoBack.Iconimage_right_Selected = null;
            this.bunifuFlatButtonGoBack.Iconimage_Selected = null;
            this.bunifuFlatButtonGoBack.IconMarginLeft = 0;
            this.bunifuFlatButtonGoBack.IconMarginRight = 0;
            this.bunifuFlatButtonGoBack.IconRightVisible = true;
            this.bunifuFlatButtonGoBack.IconRightZoom = 0D;
            this.bunifuFlatButtonGoBack.IconVisible = true;
            this.bunifuFlatButtonGoBack.IconZoom = 90D;
            this.bunifuFlatButtonGoBack.IsTab = false;
            this.bunifuFlatButtonGoBack.Location = new System.Drawing.Point(14, 9);
            this.bunifuFlatButtonGoBack.Name = "bunifuFlatButtonGoBack";
            this.bunifuFlatButtonGoBack.Normalcolor = System.Drawing.Color.Black;
            this.bunifuFlatButtonGoBack.OnHovercolor = System.Drawing.Color.Black;
            this.bunifuFlatButtonGoBack.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButtonGoBack.selected = false;
            this.bunifuFlatButtonGoBack.Size = new System.Drawing.Size(58, 41);
            this.bunifuFlatButtonGoBack.TabIndex = 14;
            this.bunifuFlatButtonGoBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonGoBack.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonGoBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonGoBack.Click += new System.EventHandler(this.bunifuFlatButtonGoBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(158, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 36);
            this.label2.TabIndex = 11;
            this.label2.Text = "Go to Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(406, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 36);
            this.label5.TabIndex = 10;
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
            this.label4.Location = new System.Drawing.Point(442, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.DarkCyan;
            this.statusStrip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressLabel});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(0, 597);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip.Size = new System.Drawing.Size(503, 21);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 13;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(86, 16);
            this.ProgressLabel.Text = "Email Client";
            // 
            // bunifuMaterialTextboxPassword
            // 
            this.bunifuMaterialTextboxPassword.BackColor = System.Drawing.Color.Brown;
            this.bunifuMaterialTextboxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuMaterialTextboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextboxPassword.ForeColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextboxPassword.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextboxPassword.HintText = "";
            this.bunifuMaterialTextboxPassword.isPassword = false;
            this.bunifuMaterialTextboxPassword.LineFocusedColor = System.Drawing.Color.Brown;
            this.bunifuMaterialTextboxPassword.LineIdleColor = System.Drawing.Color.Brown;
            this.bunifuMaterialTextboxPassword.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.bunifuMaterialTextboxPassword.LineThickness = 3;
            this.bunifuMaterialTextboxPassword.Location = new System.Drawing.Point(60, 454);
            this.bunifuMaterialTextboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextboxPassword.Name = "bunifuMaterialTextboxPassword";
            this.bunifuMaterialTextboxPassword.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bunifuMaterialTextboxPassword.Size = new System.Drawing.Size(414, 41);
            this.bunifuMaterialTextboxPassword.TabIndex = 14;
            this.bunifuMaterialTextboxPassword.Text = "Enter password";
            this.bunifuMaterialTextboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextboxPassword.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextboxPassword_OnValueChanged);
            this.bunifuMaterialTextboxPassword.Enter += new System.EventHandler(this.bunifuMaterialTextboxPassword_Enter);
            this.bunifuMaterialTextboxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuTextboxLoginAndPassword_KeyPress);
            this.bunifuMaterialTextboxPassword.Leave += new System.EventHandler(this.bunifuMaterialTextboxPassword_Leave);
            // 
            // bunifuElipseForPasswodTBox
            // 
            this.bunifuElipseForPasswodTBox.ElipseRadius = 10;
            this.bunifuElipseForPasswodTBox.TargetControl = this.bunifuMaterialTextboxPassword;
            // 
            // bunifuFlatButtonShowHidePassword
            // 
            this.bunifuFlatButtonShowHidePassword.Activecolor = System.Drawing.Color.Brown;
            this.bunifuFlatButtonShowHidePassword.BackColor = System.Drawing.Color.Brown;
            this.bunifuFlatButtonShowHidePassword.BackgroundImage = global::Email_Client.Properties.Resources.hide;
            this.bunifuFlatButtonShowHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButtonShowHidePassword.BorderRadius = 0;
            this.bunifuFlatButtonShowHidePassword.ButtonText = "";
            this.bunifuFlatButtonShowHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButtonShowHidePassword.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButtonShowHidePassword.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButtonShowHidePassword.Iconimage = null;
            this.bunifuFlatButtonShowHidePassword.Iconimage_right = null;
            this.bunifuFlatButtonShowHidePassword.Iconimage_right_Selected = null;
            this.bunifuFlatButtonShowHidePassword.Iconimage_Selected = null;
            this.bunifuFlatButtonShowHidePassword.IconMarginLeft = 0;
            this.bunifuFlatButtonShowHidePassword.IconMarginRight = 0;
            this.bunifuFlatButtonShowHidePassword.IconRightVisible = true;
            this.bunifuFlatButtonShowHidePassword.IconRightZoom = 0D;
            this.bunifuFlatButtonShowHidePassword.IconVisible = true;
            this.bunifuFlatButtonShowHidePassword.IconZoom = 90D;
            this.bunifuFlatButtonShowHidePassword.IsTab = false;
            this.bunifuFlatButtonShowHidePassword.Location = new System.Drawing.Point(425, 461);
            this.bunifuFlatButtonShowHidePassword.Name = "bunifuFlatButtonShowHidePassword";
            this.bunifuFlatButtonShowHidePassword.Normalcolor = System.Drawing.Color.Brown;
            this.bunifuFlatButtonShowHidePassword.OnHovercolor = System.Drawing.Color.Brown;
            this.bunifuFlatButtonShowHidePassword.OnHoverTextColor = System.Drawing.Color.Brown;
            this.bunifuFlatButtonShowHidePassword.selected = false;
            this.bunifuFlatButtonShowHidePassword.Size = new System.Drawing.Size(43, 25);
            this.bunifuFlatButtonShowHidePassword.TabIndex = 15;
            this.bunifuFlatButtonShowHidePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButtonShowHidePassword.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButtonShowHidePassword.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButtonShowHidePassword.Click += new System.EventHandler(this.bunifuFlatButtonShowHidePassword_Click);
            // 
            // bunifuThinButtonFurther
            // 
            this.bunifuThinButtonFurther.ActiveBorderThickness = 1;
            this.bunifuThinButtonFurther.ActiveCornerRadius = 20;
            this.bunifuThinButtonFurther.ActiveFillColor = System.Drawing.Color.Tomato;
            this.bunifuThinButtonFurther.ActiveForecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButtonFurther.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.bunifuThinButtonFurther.BackColor = System.Drawing.Color.Black;
            this.bunifuThinButtonFurther.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButtonFurther.BackgroundImage")));
            this.bunifuThinButtonFurther.ButtonText = "Further";
            this.bunifuThinButtonFurther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButtonFurther.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButtonFurther.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButtonFurther.IdleBorderThickness = 1;
            this.bunifuThinButtonFurther.IdleCornerRadius = 20;
            this.bunifuThinButtonFurther.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.bunifuThinButtonFurther.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButtonFurther.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.bunifuThinButtonFurther.Location = new System.Drawing.Point(276, 538);
            this.bunifuThinButtonFurther.Margin = new System.Windows.Forms.Padding(5, 5, 20, 10);
            this.bunifuThinButtonFurther.Name = "bunifuThinButtonFurther";
            this.bunifuThinButtonFurther.Size = new System.Drawing.Size(207, 49);
            this.bunifuThinButtonFurther.TabIndex = 11;
            this.bunifuThinButtonFurther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButtonFurther.Click += new System.EventHandler(this.bunifuThinButtonFurther_Click);
            // 
            // bunifuTextboxPassword
            // 
            this.bunifuTextboxPassword.BackColor = System.Drawing.Color.Brown;
            this.bunifuTextboxPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextboxPassword.BackgroundImage")));
            this.bunifuTextboxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextboxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextboxPassword.ForeColor = System.Drawing.Color.Black;
            this.bunifuTextboxPassword.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextboxPassword.Icon")));
            this.bunifuTextboxPassword.Location = new System.Drawing.Point(15, 451);
            this.bunifuTextboxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTextboxPassword.Name = "bunifuTextboxPassword";
            this.bunifuTextboxPassword.Size = new System.Drawing.Size(468, 46);
            this.bunifuTextboxPassword.TabIndex = 8;
            this.bunifuTextboxPassword.text = "";
            // 
            // bunifuTextboxLogin
            // 
            this.bunifuTextboxLogin.BackColor = System.Drawing.Color.Brown;
            this.bunifuTextboxLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextboxLogin.BackgroundImage")));
            this.bunifuTextboxLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextboxLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextboxLogin.ForeColor = System.Drawing.Color.Gray;
            this.bunifuTextboxLogin.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextboxLogin.Icon")));
            this.bunifuTextboxLogin.Location = new System.Drawing.Point(12, 368);
            this.bunifuTextboxLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTextboxLogin.Name = "bunifuTextboxLogin";
            this.bunifuTextboxLogin.Size = new System.Drawing.Size(471, 45);
            this.bunifuTextboxLogin.TabIndex = 8;
            this.bunifuTextboxLogin.text = "Email address mail";
            this.bunifuTextboxLogin.KeyPress += new System.EventHandler(this.bunifuTextboxLoginAndPassword_KeyPress);
            this.bunifuTextboxLogin.Enter += new System.EventHandler(this.bunifuTextboxLogin_Enter);
            this.bunifuTextboxLogin.Leave += new System.EventHandler(this.bunifuTextboxLogin_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 269);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginEMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(503, 618);
            this.Controls.Add(this.bunifuFlatButtonShowHidePassword);
            this.Controls.Add(this.bunifuMaterialTextboxPassword);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.bunifuThinButtonFurther);
            this.Controls.Add(this.bunifuTextboxPassword);
            this.Controls.Add(this.bunifuTextboxLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginEMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginEMail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextboxLogin;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextboxPassword;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButtonFurther;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ProgressLabel;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonGoBack;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextboxPassword;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseForPasswodTBox;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButtonShowHidePassword;
    }
}