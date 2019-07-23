using System.Drawing;

namespace Email_Client
{
    partial class Message_box
    {
        private System.Windows.Forms.PictureBox Icon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Icon_delay;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message_box));
            this.Icon_delay = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Icon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.bunifuElipseForm = new ns1.BunifuElipse(this.components);
            this.bunifuThinButtonSend = new ns1.BunifuThinButton2();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Icon_delay
            // 
            this.Icon_delay.Enabled = true;
            this.Icon_delay.Interval = 4500;
            this.Icon_delay.Tick += new System.EventHandler(this.Icon_delay_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email successfully sent";
            // 
            // Icon
            // 
            this.Icon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Icon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon.ErrorImage = null;
            this.Icon.Image = ((System.Drawing.Image)(resources.GetObject("Icon.Image")));
            this.Icon.InitialImage = null;
            this.Icon.Location = new System.Drawing.Point(69, 60);
            this.Icon.Margin = new System.Windows.Forms.Padding(0);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(129, 120);
            this.Icon.TabIndex = 0;
            this.Icon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 34);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(226, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipseForm
            // 
            this.bunifuElipseForm.ElipseRadius = 50;
            this.bunifuElipseForm.TargetControl = this;
            // 
            // bunifuThinButtonSend
            // 
            this.bunifuThinButtonSend.ActiveBorderThickness = 1;
            this.bunifuThinButtonSend.ActiveCornerRadius = 20;
            this.bunifuThinButtonSend.ActiveFillColor = System.Drawing.Color.Tomato;
            this.bunifuThinButtonSend.ActiveForecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButtonSend.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.bunifuThinButtonSend.BackColor = System.Drawing.Color.Maroon;
            this.bunifuThinButtonSend.ButtonText = "OK";
            this.bunifuThinButtonSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButtonSend.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButtonSend.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButtonSend.IdleBorderThickness = 1;
            this.bunifuThinButtonSend.IdleCornerRadius = 20;
            this.bunifuThinButtonSend.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.bunifuThinButtonSend.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButtonSend.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(41)))), ((int)(((byte)(91)))));
            this.bunifuThinButtonSend.Location = new System.Drawing.Point(69, 225);
            this.bunifuThinButtonSend.Margin = new System.Windows.Forms.Padding(5, 5, 20, 10);
            this.bunifuThinButtonSend.Name = "bunifuThinButtonSend";
            this.bunifuThinButtonSend.Size = new System.Drawing.Size(129, 37);
            this.bunifuThinButtonSend.TabIndex = 18;
            this.bunifuThinButtonSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButtonSend.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this.bunifuThinButtonSend;
            // 
            // Message_box
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(264, 281);
            this.Controls.Add(this.bunifuThinButtonSend);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Icon);
            this.ForeColor = System.Drawing.Color.LightGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.Name = "Message_box";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email client message";
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuElipse bunifuElipseForm;
        private ns1.BunifuThinButton2 bunifuThinButtonSend;
        private ns1.BunifuElipse bunifuElipse1;
    }
}