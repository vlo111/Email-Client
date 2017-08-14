using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Email_Client
{
    public class MailEncoder
    {
        public static string GetBase64String(string filePath)
        {
            string base64Data = "";
            if (File.Exists(filePath))
            {
                FileStream fileStream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                byte[] buffer = new byte[fileStream.Length];
                int bytesRead = fileStream.Read(buffer, 0, buffer.Length);
                base64Data = Convert.ToBase64String(buffer, 0, bytesRead);
                fileStream.Close();

                StringBuilder data = new StringBuilder();
                int nextChunk = 76;

                for (int i = 0; i < base64Data.Length; )
                {
                    if (base64Data.Length - (i + nextChunk) < 0)
                    {
                        nextChunk = base64Data.Length - i;
                    }

                    data.Append(base64Data.Substring(i, nextChunk));
                    data.Append("\r\n");
                    i += nextChunk;
                }

                //data.Append("\r\n");
                return data.ToString();

            }
            else
            {
                return null;
            }
        }

        public static string ConvertToQP(string s, string charset)
        {
            if (s == null) { return null; }
            if (charset == null) charset = "ISO-8859-1"; // default charset

            // environment newline char
            char[] nl = Environment.NewLine.ToCharArray();

            // source char array
            char[] source = s.ToCharArray();
            char ch;

            StringBuilder sb = new StringBuilder();
            StringBuilder currLine = new StringBuilder();
            bool bNewline = false;

            Encoding oEncoding = Encoding.GetEncoding(charset);

            for (int sidx = 0; sidx < s.Length; sidx++)
            {
                ch = source[sidx];

                // RULE # 4: LINE BREAKS
                if (ch == nl[0] && sidx <= (s.Length - nl.Length))
                {
                    // peek ahead make sure the "whole" newline is present
                    if (s.Substring(sidx, nl.Length) == Environment.NewLine)
                    {
                        // RULE #3: ENCODE WHITESPACE PRECEEDING A HARD BREAK
                        if (currLine.Length > 0)
                        {
                            if (source[sidx - 1] == ' ')
                            {   // if char is preceded by space char add =20
                                currLine.Remove(currLine.Length - 1, 1);
                                currLine.Append("=20");
                            }
                            else if (source[sidx - 1] == '\t')
                            {   // if char is preceded by tab char add =09
                                currLine.Remove(currLine.Length - 1, 1);
                                currLine.Append("=09");
                            }
                        }

                        // flag for new line
                        bNewline = true;
                        sidx += nl.Length - 1;  // jump ahead 

                    }
                    else
                    {	// not actually a newline.  Encode per Rule #1
                        currLine.Append("=0" + Convert.ToString((byte)ch, 16).ToUpper());
                    }
                }
                // RULE #1 and #2
                // Optional characters are: !"#$@[\]^`{|}~
                else if (ch > 126 || (ch < 32 && ch != '\t') || ch == '=')
                {
                    byte[] outByte = new byte[10];
                    int iCount = oEncoding.GetBytes("" + ch, 0, 1, outByte, 0);

                    for (int i = 0; i < iCount; i++)
                    {
                        if (outByte[i] < 16)
                            currLine.Append("=0" + Convert.ToString(outByte[i], 16).ToUpper());
                        else
                            currLine.Append("=" + Convert.ToString(outByte[i], 16).ToUpper());
                    }
                }
                else
                {
                    currLine.Append(ch);
                }

                // Rule #5: MAXIMUM length 76 characters per line
                if (currLine.Length >= 76)
                {
                    // just make sure not to split an encoded char
                    string cLine = currLine.ToString();
                    int breakAt = cLine.LastIndexOf("=");
                    if (breakAt < 70) breakAt = 74;
                    sb.Append(cLine.Substring(0, breakAt) + "=\r\n");
                    currLine = new StringBuilder(cLine.Substring(breakAt));
                }

                if (bNewline)
                {
                    // RFC 822 linebreak = CRLF
                    sb.Append(currLine.ToString() + "\r\n");
                    currLine = new StringBuilder();
                    bNewline = false;
                }
            }

            // add last line
            sb.Append(currLine.ToString());

            return sb.ToString();
        }

    }
}
