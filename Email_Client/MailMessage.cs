using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Email_Client
{
    public enum MailEncodingType
    {
        PLAINTEXT,
        HTML
    }

    public enum MailSendPriority
    {
        HIGH,
        NORMAL,
        LOW
    }
    
    public class MailMessage
    {
        // Data Members
        private string from;
        private string to;
        private string cc;
        private string bcc;
        private string subject;
        private string message;
        private MailEncodingType mailEncodingType;
        private MailSendPriority mailSendPriority;
        private ArrayList attachments;


        // Constructors
        public MailMessage()
        {
            this.from = "";
            this.to = "";
            this.cc = "";
            this.bcc = "";
            this.subject = "";
            this.message = "";
            this.mailEncodingType = MailEncodingType.PLAINTEXT;
            this.mailSendPriority = MailSendPriority.NORMAL;
            this.attachments = new ArrayList();
        }

        public MailMessage(string from, string recipient)
        {
            this.from = from;
            this.to = recipient;
            this.cc = "";
            this.bcc = "";
            this.subject = "";
            this.message = "";
            this.mailEncodingType = MailEncodingType.PLAINTEXT;
            this.mailSendPriority = MailSendPriority.NORMAL;
            this.attachments = new ArrayList();
        }

        public MailMessage(string from, string recipient, string subject, string body)
        {
            this.from = from;
            this.to = recipient;
            this.cc = "";
            this.bcc = "";
            this.subject = subject;
            this.message = body;
            this.mailEncodingType = MailEncodingType.PLAINTEXT;
            this.mailSendPriority = MailSendPriority.NORMAL;
            this.attachments = new ArrayList();
        }


        // Properties
        public string From
        {
            get
            {
                return this.from;
            }
            set
            {
                this.from = value;
            }
        }

        public string To
        {
            get
            {
                return this.to;
            }
            set
            {
                this.to = value;
            }
        }

        public string CC
        {
            get
            {
                return this.cc;
            }
            set
            {
                this.cc = value;
            }
        }

        public string BCC
        {
            get
            {
                return this.bcc;
            }
            set
            {
                this.bcc = value;
            }
        }

        public string Subject
        {
            get
            {
                return this.subject;
            }
            set
            {
                this.subject = value;
            }
        }

        public string Message
        {
            get
            {
                return this.message;
            }
            set
            {
                this.message = value;
            }
        }

        public MailEncodingType MailType
        {
            get
            {
                return this.mailEncodingType;
            }
            set
            {
                this.mailEncodingType = value;
            }
        }

        public MailSendPriority MailPriority
        {
            get
            {
                return this.mailSendPriority;
            }
            set
            {
                this.mailSendPriority = value;
            }
        }

        public ArrayList Attachments
        {
            get
            {
                return this.attachments;
            }
            set
            {
                this.attachments = value;
            }
        }

        public int AttachmentCount
        {
            get
            {
                return this.attachments.Count;
            }
        }
    }
}
