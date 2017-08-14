using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Email_Client
{
    public class Rtf2Html
    {
        private string textColour;
        private string backgroundColour;
        private bool bold;
        private bool italic;
        private bool underline;
        private string font;
        private short size;
        private long originalStart;
        private long originalLength;


        public string ConvertRtfToHtml(RichTextBox Box)
        {
            string HTML = "";
            string tempTextColor = "";
            string tempBackgroundColor = "";

            if (Box.Text.Length == 0)
                return "<html></html>";
            else
            {
                // Store original selections
                originalStart = 0;
                originalLength = Box.Text.Length;
                // Select first character
                Box.Select(0, 1);
                // Add HTML header
                HTML = "<html>";
                // Set up initial parameters
                textColour = "#" + Box.SelectionColor.R.ToString("X2") + Box.SelectionColor.G.ToString("X2") + Box.SelectionColor.B.ToString("X2");
                backgroundColour = "#" + Box.SelectionBackColor.R.ToString("X2") + Box.SelectionBackColor.G.ToString("X2") + Box.SelectionBackColor.B.ToString("X2");
                bold = Box.SelectionFont.Bold;
                italic = Box.SelectionFont.Italic;
                underline = Box.SelectionFont.Underline;
                font = Box.SelectionFont.FontFamily.Name;
                size = Convert.ToInt16(Box.SelectionFont.Size);

                // Include first 'style' parameters in the HTML
                HTML += "<span style=\"font-family: " + font + "; font-size: " + size + "pt; color: " + textColour + "; background-color: " + backgroundColour + "\">";
                // Include bold tag, if required
                if (bold == true)
                    HTML += "<b>";
                // Include italic tag, if required
                if (italic == true)
                    HTML += "<i>";
                // Include underline tag, if required
                if (underline == true)
                    HTML += "<u>";
                // Finally, add our first character
                if (Box.Text.Substring(0, 1) == Convert.ToChar(10).ToString())
                {
                    HTML += "<br>";
                }
                else if (Box.Text.Substring(0, 1) == " ")
                {
                    HTML += "&nbsp;";
                }
                else
                {
                    HTML += Box.Text.Substring(0, 1);
                }

                // Loop around all remaining characters
                for (int count = 2; count <= Box.Text.Length; count++)
                {
                    // Select current character
                    Box.Select(count - 1, 1);
                    // If this is a line break, add HTML tag
                    if (Box.Text.Substring(count - 1, 1) == Convert.ToChar(10).ToString())
                    {
                        HTML += "<br>";
                    }
                    else if (Box.Text.Substring(count - 1, 1) == " ")
                    {
                        HTML += "&nbsp;";
                        continue;
                    }

                    tempTextColor = "#" + Box.SelectionColor.R.ToString("X2") + Box.SelectionColor.G.ToString("X2") + Box.SelectionColor.B.ToString("X2");
                    tempBackgroundColor = "#" + Box.SelectionBackColor.R.ToString("X2") + Box.SelectionBackColor.G.ToString("X2") + Box.SelectionBackColor.B.ToString("X2");
                    // Check/implement any changes in style
                    if (!(tempTextColor.Equals(textColour, StringComparison.OrdinalIgnoreCase)) || (!(tempBackgroundColor.Equals(backgroundColour, StringComparison.OrdinalIgnoreCase))) || (!(Box.SelectionFont.FontFamily.Name.Equals(font, StringComparison.OrdinalIgnoreCase))) || (Box.SelectionFont.Size != size))
                    {
                        HTML += "</span><span style=\"font-family: " + Box.SelectionFont.FontFamily.Name + "; font-size: " + Box.SelectionFont.Size + "pt; color: " + tempTextColor + "; background-color: " + tempBackgroundColor + "\">";
                    }

                    // Check for bold changes
                    if (Box.SelectionFont.Bold != bold)
                    {
                        if (Box.SelectionFont.Bold == false)
                        {
                            HTML += "</b>";
                        }
                        else
                        {
                            HTML += "<b>";
                        }
                    }

                    // Check for italic changes
                    if (Box.SelectionFont.Italic != italic)
                    {
                        if (Box.SelectionFont.Italic == false)
                        {
                            HTML += "</i>";
                        }
                        else
                        {
                            HTML += "<i>";
                        }
                    }

                    // Check for underline changes
                    if (Box.SelectionFont.Underline != underline)
                    {
                        if (Box.SelectionFont.Underline == false)
                        {
                            HTML += "</u>";
                        }
                        else
                        {
                            HTML += "<u>";
                        }
                    }

                    // Add the actual character
                    HTML += Box.Text.Substring(count - 1, 1);
                    // Update variables with current style
                    textColour = "#" + Box.SelectionColor.R.ToString("X2") + Box.SelectionColor.G.ToString("X2") + Box.SelectionColor.B.ToString("X2");
                    backgroundColour = "#" + Box.SelectionBackColor.R.ToString("X2") + Box.SelectionBackColor.G.ToString("X2") + Box.SelectionBackColor.B.ToString("X2");
                    bold = Box.SelectionFont.Bold;
                    italic = Box.SelectionFont.Italic;
                    underline = Box.SelectionFont.Underline;
                    font = Box.SelectionFont.FontFamily.Name;
                    size = Convert.ToInt16(Box.SelectionFont.Size);
                }

                // Close off any open bold/italic/underline tags
                if (bold == true)
                    HTML += "";
                if (italic == true)
                    HTML += "";
                if (underline == true)
                    HTML += "";

                // Terminate outstanding HTML tags
                HTML += "</span></html>";
                // Return HTML
                return HTML;
            }
        }
    }
}
