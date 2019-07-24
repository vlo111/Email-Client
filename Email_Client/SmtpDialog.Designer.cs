namespace Email_Client
{
    partial class SmtpDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmtpDialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuThinButtonFurther = new ns1.BunifuThinButton2();
            this.bunifuTextbox_port = new ns1.BunifuTextbox();
            this.bunifuTextbox_server = new ns1.BunifuTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.Error_Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 56);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(413, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 36);
            this.label5.TabIndex = 8;
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
            this.label4.Location = new System.Drawing.Point(449, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please select SMTP";
            // 
            // bunifuThinButtonFurther
            // 
            this.bunifuThinButtonFurther.ActiveBorderThickness = 1;
            this.bunifuThinButtonFurther.ActiveCornerRadius = 20;
            this.bunifuThinButtonFurther.ActiveFillColor = System.Drawing.Color.Tomato;
            this.bunifuThinButtonFurther.ActiveForecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButtonFurther.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.bunifuThinButtonFurther.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.bunifuThinButtonFurther.Location = new System.Drawing.Point(319, 550);
            this.bunifuThinButtonFurther.Margin = new System.Windows.Forms.Padding(5, 5, 20, 10);
            this.bunifuThinButtonFurther.Name = "bunifuThinButtonFurther";
            this.bunifuThinButtonFurther.Size = new System.Drawing.Size(172, 49);
            this.bunifuThinButtonFurther.TabIndex = 1;
            this.bunifuThinButtonFurther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButtonFurther.Click += new System.EventHandler(this.bunifuThinButtonFurther_Click);
            // 
            // bunifuTextbox_port
            // 
            this.bunifuTextbox_port.BackColor = System.Drawing.Color.Brown;
            this.bunifuTextbox_port.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox_port.BackgroundImage")));
            this.bunifuTextbox_port.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox_port.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuTextbox_port.ForeColor = System.Drawing.Color.Black;
            this.bunifuTextbox_port.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox_port.Icon")));
            this.bunifuTextbox_port.Location = new System.Drawing.Point(12, 478);
            this.bunifuTextbox_port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTextbox_port.Name = "bunifuTextbox_port";
            this.bunifuTextbox_port.Size = new System.Drawing.Size(479, 43);
            this.bunifuTextbox_port.TabIndex = 2;
            this.bunifuTextbox_port.text = "587";
            this.bunifuTextbox_port.KeyPress += new System.EventHandler(this.bunifuTextbox_KeyPress);
            // 
            // bunifuTextbox_server
            // 
            this.bunifuTextbox_server.BackColor = System.Drawing.Color.Brown;
            this.bunifuTextbox_server.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox_server.BackgroundImage")));
            this.bunifuTextbox_server.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox_server.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuTextbox_server.ForeColor = System.Drawing.Color.Black;
            this.bunifuTextbox_server.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox_server.Icon")));
            this.bunifuTextbox_server.Location = new System.Drawing.Point(12, 387);
            this.bunifuTextbox_server.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTextbox_server.Name = "bunifuTextbox_server";
            this.bunifuTextbox_server.Size = new System.Drawing.Size(479, 42);
            this.bunifuTextbox_server.TabIndex = 3;
            this.bunifuTextbox_server.text = "smtp.gmail.com";
            this.bunifuTextbox_server.KeyPress += new System.EventHandler(this.bunifuTextbox_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 269);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "SMTP SERVER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(166, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "SMTP PORT";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Error_Label
            // 
            this.Error_Label.AutoSize = true;
            this.Error_Label.BackColor = System.Drawing.Color.Black;
            this.Error_Label.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.Error_Label.Location = new System.Drawing.Point(12, 574);
            this.Error_Label.Name = "Error_Label";
            this.Error_Label.Size = new System.Drawing.Size(0, 25);
            this.Error_Label.TabIndex = 8;
            // 
            // SmtpDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(503, 618);
            this.Controls.Add(this.Error_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuTextbox_server);
            this.Controls.Add(this.bunifuTextbox_port);
            this.Controls.Add(this.bunifuThinButtonFurther);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SmtpDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuThinButton2 bunifuThinButtonFurther;
        private ns1.BunifuTextbox bunifuTextbox_port;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuTextbox bunifuTextbox_server;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label Error_Label;
    }
}

