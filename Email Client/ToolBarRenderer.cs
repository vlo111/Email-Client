using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Email_Client
{
    public class ToolBarRenderer : ToolStripProfessionalRenderer
    {
        // Default Constructor
        public ToolBarRenderer()
        {

        }

        // Just would not draw Border
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            
        }

        // just don't draw background
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            
        }
    }
}
