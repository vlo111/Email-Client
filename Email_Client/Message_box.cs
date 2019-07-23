using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Email_Client
{
    public partial class Message_box : Form
    {
        public Message_box()
        {
            InitializeComponent();
            this.Show();
            this.Icon.Enabled = true;
            Icon_delay.Start();
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

        private void Icon_delay_Tick(object sender, EventArgs e)
        {
            this.Icon.Enabled = false;
            Icon_delay.Stop();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Button Round

        /// <summary>
        /// Veragrel formi buttunin ev nra parametr kavelana BorderRadius hatkutyun@
        /// </summary>
        class RoundedButton : Button
        {
            GraphicsPath GetRoundPath(RectangleF Rect, int radius)
            {
                float r2 = radius / 2f;
                GraphicsPath GraphPath = new GraphicsPath();

                GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
                GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
                GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
                GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
                GraphPath.AddArc(Rect.X + Rect.Width - radius,
                                 Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
                GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
                GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
                GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);

                GraphPath.CloseFigure();
                return GraphPath;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
                GraphicsPath GraphPath = GetRoundPath(Rect, 20);

                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }
        #endregion

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Move Window
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Mouse_Move.Drag_Form(Handle, e);
        }
        #endregion
    }

}
