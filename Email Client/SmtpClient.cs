using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace Email_Client
{
    public delegate void ConnectEventHandler(object sender,string Server,int Port);
    public delegate void AuthenticateEventHandler(object sender, string userName);
    public delegate void DisconnectEventHandler(object sender, string Server);
    public delegate void DataTransferEventHandler(object sender);


    public class SmtpClient
    {
        // Data Members
        private string smtpServer;
        private int smtpPort;
        private MailMessage mailMessage;
        private int timeOut;
        private string userName;
        private string password;
        private string errorMessage;


        private Socket tcp_Socket;
        private NetworkStream networkStream;
        private SslStream secureStream;


        //Custom Events
        
        //Event that fires when connection is establishing with target SMTP server.
        public event ConnectEventHandler ConnectionEstablishing;
        //Event that fires when connection established with target SMTP server.
        public event ConnectEventHandler ConnectionEstablished;
        //Event that fires when dicconnected with target SMTP server.
        public event DisconnectEventHandler Disconnected;
        //Event that fires when authentication has begun
        public event AuthenticateEventHandler AuthenticationBegan;
        //Event that fires when authentication finished successfully
        public event AuthenticateEventHandler AuthenticationFinished;
        //Event that fires when email data transfer has begun
        public event DataTransferEventHandler StartedDataTransfer;
        //Event that fires when email data transfer has ended
        public event DataTransferEventHandler EndedDataTransfer;
        

        // Constructors
        public SmtpClient()
        {
            this.SmtpServer = "";
            this.smtpPort = 25;
            this.timeOut = 60;
            this.userName = "";
            this.password = "";
            this.errorMessage = "";
        }

        public SmtpClient(string server)
        {
            this.smtpServer = server;
            this.smtpPort = 25;
            this.timeOut = 60;
            this.userName = "";
            this.password = "";
            this.errorMessage = "";
        }

        public SmtpClient(string server, int port)
        {
            this.smtpServer = server;
            this.smtpPort = port;
            this.timeOut = 60;
            this.userName = "";
            this.password = "";
            this.errorMessage = "";
        }


        //Event Raising Methods
        private void RaiseConnectionEstablishing(string smtpServer, int smtpPort)
        {
            if (ConnectionEstablishing != null)
            {
                ConnectionEstablishing(this, smtpServer, smtpPort);
            }
        }

        private void RaiseConnectionEstablished(string smtpServer, int smtpPort)
        {
            if (ConnectionEstablished != null)
            {
                ConnectionEstablished(this, smtpServer, smtpPort);
            }
        }

        private void RaiseDisconnected(string smtpServer)
        {
            if (Disconnected != null)
            {
                Disconnected(this, smtpServer);
            }
        }

        private void RaiseAuthenticationBegan(string userName)
        {
            if (AuthenticationBegan != null)
            {
                AuthenticationBegan(this,userName);
            }
        }

        private void RaiseAuthenticationFinished(string userName)
        {
            if (AuthenticationFinished != null)
            {
                AuthenticationFinished(this,userName);
            }
        }

        private void RaiseStartedDataTransfer()
        {
            if (StartedDataTransfer != null)
            {
                StartedDataTransfer(this);
            }
        }

        private void RaiseEndedDataTransfer()
        {
            if (EndedDataTransfer != null)
            {
                EndedDataTransfer(this);
            }
        }



        // Properties
        public string SmtpServer
        {
            get
            {
                return this.smtpServer;
            }
            set
            {
                this.smtpServer = value;
            }
        }

        public int SmtpPort
        {
            get
            {
                return this.smtpPort;
            }
            set
            {
                this.smtpPort = value;
            }
        }

        public int TimeOut
        {
            get
            {
                return this.timeOut;
            }
            set
            {
                this.timeOut = value;
            }
        }

        public string UserName
        {
            get
            {
                return this.userName;
            }
            set
            {
                this.userName = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }


        //Methods
        public void SendMail(MailMessage mailMessage)
        {
            this.mailMessage = mailMessage;

            this.tcp_Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress[] ip_Addresses;
            try
            {
                ip_Addresses = Dns.GetHostAddresses(this.smtpServer);
            }
            catch (Exception)
            {
                this.errorMessage = "Smtp server \"" + this.smtpServer + "\" does not exist.";
                throw new SmtpClientException(this.errorMessage);
            }
            IPEndPoint remote_EndPoint = new IPEndPoint(ip_Addresses[0], this.SmtpPort);

            //Raise Connection Establishing Event
            this.RaiseConnectionEstablishing(this.smtpServer, this.smtpPort);
            try
            {
                tcp_Socket.Connect((EndPoint)remote_EndPoint);
            }
            catch 
            {
                this.errorMessage = "Unable to connect to SMTP server: " + this.smtpServer + ",on port " + this.smtpPort + ".";
                throw new SmtpClientException(this.errorMessage);
            }
            
            this.networkStream = new NetworkStream(this.tcp_Socket);
            byte[] buffer;
            string responseText = "";
            string[] commands = new string[] { "EHLO", "MAIL FROM:", "RCPT TO:", "DATA", "", "QUIT" };
            string[] responses = new string[] {"250","250","250","354","250","221"};
            string message = "";
            bool flag = false;
            ASCIIEncoding encoding = new ASCIIEncoding();

            if (this.WaitForResponse("220",ref responseText,true) == false)
            {
                this.errorMessage = "Did not get welcome message from SMTP server: " + this.smtpServer +".\r\nServer said: " + responseText;
                this.tcp_Socket.Close();
                throw new SmtpClientException(this.errorMessage);
            }
            else
            {
                //Raise Connection Established Event
                this.RaiseConnectionEstablished(this.smtpServer, this.smtpPort);

                for (int i = 0; i < commands.Length; i++)
                {
                    message = commands[i];

                    switch (i)
                    {
                        case 0:
                            message += " " + Dns.GetHostEntry("127.0.0.1").HostName + "\r\n";
                            break;
                        case 1:
                            message += "<" + this.mailMessage.From + ">\r\n";
                            break;
                        case 2:
                            flag = true;
                            break;
                        case 3:
                            message += "\r\n";
                            break;
                        case 4:
                            message += this.GetEmailInformation();
                            break;
                        case 5:
                            message += "\r\n";
                            break;
                    }

                    if (flag == true)
                    {
                        string recipientAddress = "";

                        if (this.mailMessage.To.Length > 0)
                        {
                            string[] split = this.mailMessage.To.Split(new char[]{',',';'});

                            for (int j = 0; j < split.Length; j++)
                            {
                                if (split[j].Trim() != "")
                                {
                                    recipientAddress = "<" + split[j] + ">";
                                    message = "RCPT TO: " + recipientAddress + "\r\n";
                                    this.SendDataThroughSecureStream(message);

                                    if (this.WaitForResponse("250", ref responseText, false) == false)
                                    {
                                        this.errorMessage = "Server rejected the email address: " + recipientAddress + ".";
                                        this.tcp_Socket.Close();
                                        throw new SmtpClientException(this.errorMessage);
                                    }
                                }
                            }
                        }

                        if (this.mailMessage.CC.Length > 0)
                        {
                            string[] split = this.mailMessage.CC.Split(new char[] { ',', ';' });

                            for (int j = 0; j < split.Length; j++)
                            {
                                recipientAddress = "<" + split[j] + ">";
                                message = "RCPT TO: " + recipientAddress + "\r\n";
                                this.SendDataThroughSecureStream(message);

                                if (this.WaitForResponse("250", ref responseText, false) == false)
                                {
                                    this.errorMessage = "Server rejected the email address: " + recipientAddress + ".";
                                    this.tcp_Socket.Close();
                                    throw new SmtpClientException(this.errorMessage);
                                }
                            }
                        }

                        if (this.mailMessage.BCC.Length > 0)
                        {
                            string[] split = this.mailMessage.BCC.Split(new char[] { ',', ';' });

                            for (int j = 0; j < split.Length; j++)
                            {
                                recipientAddress = "<" + split[j] + ">";
                                message = "RCPT TO: " + recipientAddress + "\r\n";
                                this.SendDataThroughSecureStream(message);

                                if (this.WaitForResponse("250", ref responseText, false) == false)
                                {
                                    this.errorMessage = "Server rejected the email address: " + recipientAddress + ".";
                                    this.tcp_Socket.Close();
                                    throw new SmtpClientException(this.errorMessage);
                                }
                            }
                        }
                        flag = false;
                    }
                    else
                    {
                        if (i == 0)
                        {
                            this.SendDataThroughNetworkStream(message);
                            if (this.WaitForResponse(responses[0], ref responseText, true) == false)
                            {
                                this.errorMessage = "Did not get " + responses[0] + " reply from server for command " + commands[0] + ".\r\nServer said: " + responseText;
                                this.tcp_Socket.Close();
                                throw new SmtpClientException(this.errorMessage);
                            }
                            else
                            {
                                message = "STARTTLS\r\n";
                                this.SendDataThroughNetworkStream(message);
                                if (this.WaitForResponse("220", ref responseText, true) == false)
                                {
                                    this.errorMessage = "Did not get " + "220" + " reply from server for command " + "STARTTLS" + ".\r\nServer said: " + responseText;
                                    this.tcp_Socket.Close();
                                    throw new SmtpClientException(this.errorMessage);
                                }
                                else
                                {
                                    this.secureStream = new SslStream(this.networkStream, true, new RemoteCertificateValidationCallback(OnCertificateValidation));
                                    this.secureStream.AuthenticateAsClient("localhost");

                                    if (this.secureStream.IsAuthenticated)
                                    {
                                        message = "Ehlo " + Dns.GetHostEntry("127.0.0.1").HostName + "\r\n";
                                        this.SendDataThroughSecureStream(message);
                                        if (this.WaitForResponse(responses[0], ref responseText, false) == false)
                                        {
                                            this.errorMessage = "Did not get " + responses[0] + " reply from server for command " + commands[0] + ".\r\nServer said: " + responseText;
                                            this.tcp_Socket.Close();
                                            throw new SmtpClientException(this.errorMessage);
                                        }
                                        else
                                        {
                                            if (responseText.IndexOf("Auth Login", StringComparison.OrdinalIgnoreCase) >= 0)
                                            {
                                                message = "Auth Login" + "\r\n";
                                                this.SendDataThroughSecureStream(message);
                                                if (this.WaitForResponse("334", ref responseText, false) == false)
                                                {
                                                    this.errorMessage = "Did not get 334 reply from server for AUTH LOGIN" + ".\r\nServer said: " + responseText;
                                                    this.tcp_Socket.Close();
                                                    throw new SmtpClientException(this.errorMessage);
                                                }
                                                else
                                                {
                                                    buffer = encoding.GetBytes(this.userName);  // Not include Domain Name
                                                    message = Convert.ToBase64String(buffer) + "\r\n";
                                                    //Raise Authentication Began Event
                                                    this.RaiseAuthenticationBegan(this.userName);
                                                    this.SendDataThroughSecureStream(message);

                                                    if (this.WaitForResponse("334", ref responseText, false) == false)
                                                    {
                                                        this.errorMessage = "Did not get 334 reply from server for UserName Confirmation" + ".\r\nServer said: " + responseText;
                                                        this.tcp_Socket.Close();
                                                        throw new SmtpClientException(this.errorMessage);
                                                    }
                                                    else
                                                    {
                                                        buffer = encoding.GetBytes(this.password);
                                                        message = Convert.ToBase64String(buffer) + "\r\n";
                                                        this.SendDataThroughSecureStream(message);

                                                        if (this.WaitForResponse("235", ref responseText, false) == false)
                                                        {
                                                            this.errorMessage = "Did not get 235 reply from server for Password Confirmation" + ".\r\nServer said: " + responseText;
                                                            this.tcp_Socket.Close();
                                                            throw new SmtpClientException(this.errorMessage);
                                                        }
                                                        else
                                                        {
                                                            //Raise Authentication Finished Event
                                                            this.RaiseAuthenticationFinished(this.userName);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (i == 4)
                        {
                            // Raise Started Data Transfer Event
                            this.RaiseStartedDataTransfer();
                            this.SendDataThroughSecureStream(message);
                            if (this.WaitForResponse(responses[i], ref responseText, false) == false)
                            {
                                this.errorMessage = "Did not get " + responses[i] + " reply from server for command " + commands[i] + ".\r\nServer said: " + responseText;
                                this.tcp_Socket.Close();
                                throw new SmtpClientException(this.errorMessage);
                            }
                            else
                            {
                                // Raise Ended Data Transfer Event
                                this.RaiseEndedDataTransfer();
                            }
                        }
                        else
                        {
                            this.SendDataThroughSecureStream(message);
                            if (this.WaitForResponse(responses[i], ref responseText, false) == false)
                            {
                                this.errorMessage = "Did not get " + responses[i] + " reply from server for command " + commands[i] + ".\r\nServer said: " + responseText;
                                this.tcp_Socket.Close();
                                throw new SmtpClientException(this.errorMessage);
                            }

                            if (i == 5)
                            {
                                if (tcp_Socket.Connected)
                                {
                                    tcp_Socket.Close();
                                    //Raise Disconnected Event
                                    this.RaiseDisconnected(this.smtpServer);
                                }
                            }
                        }
                    }
                }
            }
            if (tcp_Socket.Connected)
            {
                tcp_Socket.Close();
                //Raise Disconnected Event
                this.RaiseDisconnected(this.smtpServer);
            }
            return;
        }

        public void SendMail(string from, string recipient, string subject, string body)
        {
            this.mailMessage = new MailMessage(from, recipient, subject, body);
            this.SendMail(this.mailMessage);
        }

        private void SendDataThroughNetworkStream(string msg)
        {
            byte[] buff = Encoding.ASCII.GetBytes(msg);
            networkStream.Write(buff, 0, buff.Length);
        }

        private void SendDataThroughSecureStream(string msg)
        {
            byte[] buff = Encoding.ASCII.GetBytes(msg);
            secureStream.Write(buff, 0, buff.Length);
        }

        // Get Header, Data, and Attachments
        private string GetEmailInformation()
        {
            StringBuilder msg = new StringBuilder();
            msg.Append("MIME-Version: 1.0\r\n");
            msg.Append("From: <" + this.mailMessage.From + ">\r\n");
            msg.Append("To: " + this.mailMessage.To + "\r\n");
            if (this.mailMessage.CC.Length > 0)
            {
                msg.Append("Cc: " + this.mailMessage.CC + "\r\n");
            }
            msg.Append("Subject: " + this.mailMessage.Subject + "\r\n");
            msg.Append("Date: " + DateTime.Now.ToString("F") + "\r\n");

            switch (this.mailMessage.MailPriority)
            {
                case MailSendPriority.HIGH:
                    msg.Append("Priority: High\r\n");
                    break;
                case MailSendPriority.LOW:
                    msg.Append("Priority: Low\r\n");
                    break;
                case MailSendPriority.NORMAL:
                    msg.Append("Priority: Normal\r\n");
                    break;
            }

            string guid = "--boundary_0_" + Guid.NewGuid().ToString();

            if (this.mailMessage.AttachmentCount > 0)
            {
                msg.Append("Content-Type: multipart/mixed; ");
                msg.Append("boundary=\"" + guid + "\"\r\n");
                msg.Append("\r\n");
                msg.Append("--" + guid + "\r\n");
            }

            switch (this.mailMessage.MailType)
            {
                case MailEncodingType.PLAINTEXT:
                    msg.Append("Content-Type: text/plain; ");
                    break;
                case MailEncodingType.HTML:
                    msg.Append("Content-Type: text/html; ");
                    break;
            }
            msg.Append("charset=\"us-ascii\"\r\n");
            msg.Append("Content-Transfer-Encoding: 7bit\r\n");
            msg.Append("\r\n");
            msg.Append(this.mailMessage.Message + "\r\n\r\n");

            for (int i = 0; i < this.mailMessage.AttachmentCount; i++)
            {
                msg.Append("--" + guid + "\r\n");
                Attachment attachment = new Attachment(this.mailMessage.Attachments[i].ToString());
                msg.Append(attachment.GetMimeMessage());
            }

            if (this.mailMessage.AttachmentCount > 0)
            {
                msg.Append("--" + guid + "--");
            }
            
            msg.Append("\r\n.\r\n");
       
            return msg.ToString();
        }

        private bool WaitForResponse(string responseCode,ref string responseText,bool isNetworkStream)
        {
            DateTime startDateTime = DateTime.Now;
            TimeSpan timeSpan = DateTime.Now - startDateTime;
            byte[] buffer = new byte[1024];
            ASCIIEncoding encoding = new ASCIIEncoding();
            int bytesRead = 0;

            while (timeSpan.Seconds < this.timeOut)
            {
                if (networkStream.DataAvailable)
                {
                    if (isNetworkStream == true)
                    {
                        bytesRead = networkStream.Read(buffer, 0, buffer.Length);
                    }
                    else
                    {
                        bytesRead = secureStream.Read(buffer, 0, buffer.Length);
                    }
                    responseText = encoding.GetString(buffer, 0, buffer.Length);
                    if (responseText.Substring(0, responseCode.Length).Equals(responseCode))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    timeSpan = DateTime.Now - startDateTime;
                }
            }
            return false;
        }

        private static bool OnCertificateValidation(object sender,X509Certificate certificate,X509Chain chain,SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
