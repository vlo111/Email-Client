using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Win32;

namespace Email_Client
{
    public class Attachment
    {
        private string content_type;
        private string file_name;
        private string file_path;
        private string encoding;
        private long size;

        // Constructor
        public Attachment(string file_path)
        {
            this.file_path = file_path;
            this.encoding = "base64";

            if (this.file_path.Length > 0)
            {
                FileInfo file_info = new FileInfo(this.file_path);
                
                if (file_info.Exists)
                {
                    this.file_name = file_info.Name;
                    this.size = file_info.Length;
                    this.content_type = this.GetContentType(file_info.Extension);
                }
            }
        }

        // Properties
        public string ContentType
        {
            get
            {
                return this.content_type;
            }
        }

        public string FileName
        {
            get
            {
                return this.file_name;
            }
        }

        public string EncodingType
        {
            get
            {
                return this.encoding;
            }
        }

        public long FileSize
        {
            get
            {
                return this.size;
            }
        }

        // Methods
        public string GetMimeMessage()
        {
            StringBuilder msg = new StringBuilder();
            msg.Append("Content-Type: " + this.content_type + "; ");
            msg.Append("name=\"" + this.file_name + "\"\r\n");
            msg.Append("Content-Transfer-Encoding: " + this.encoding + "\r\n");
            msg.Append("Content-Disposition: attachment; ");
            msg.Append("filename=\"" + this.file_name + "\"\r\n\r\n");

            msg.Append(MailEncoder.GetBase64String(this.file_path));

            return msg.ToString();
        }

        private string GetContentType(string file_extension)
        {
            try
            {
                RegistryKey regKey = Registry.ClassesRoot.OpenSubKey(file_extension);
                string contentType = regKey.GetValue("Content Type").ToString();
                
                if (contentType != "" && contentType != null)
                {
                    return contentType;
                }
                else
                {
                    return "application/octet-stream";
                }
            }
            catch (Exception)
            {
                return "application/octet-stream";
            }
        }
    }
}
