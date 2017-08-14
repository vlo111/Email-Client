using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Net.Security;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Threading;


namespace Email_Client
{
    public delegate void ClientCommandEventHandler(object sender, string command);
    public delegate void ServerResponseEventHandler(object sender, string response);
    public delegate void DataReceivingEventHandler(object sender);


    public class Pop3Client
    {
        // Data Members
        private string pop3ServerAddress;
        private int pop3ServerPort;
        private string userName;
        private string password;
        private string from;
        private string to;
        private string cc;
        private string subject;
        private string date;
        private string mimeVersion;
        private int totalEmails;
        private int totalEmailSize;
        private string errorMessage;
        private int receiveTimeOut;
        private ArrayList boundry;
        private ArrayList mailType;
        private ArrayList mailFileName;
        private ArrayList mailSections;

        private Socket tcp_Socket;
        private NetworkStream networkStream;
        private SslStream secureStream;
        private string command;


        // Custom Events
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
        //Event that fires when a command has sent
        public event ClientCommandEventHandler SendedCommand;
        //Event that fires when a command response is received from the server
        public event ServerResponseEventHandler ServerResponse;
        //Event that fires when email data receiving has begun
        public event DataReceivingEventHandler StartedDataReceiving;
        //Event that fires when email data receiving has ended
        public event DataReceivingEventHandler EndedDataReceiving;


        // Constructor
        public Pop3Client()
        {
            this.pop3ServerAddress = "";
            this.pop3ServerPort = 110;
            this.userName = "";
            this.password = "";
            this.from = "";
            this.to = "";
            this.cc = "";
            this.subject = "";
            this.date = "";
            this.mimeVersion = "";
            this.totalEmails = 0;
            this.totalEmailSize = 0;
            this.receiveTimeOut = 60;
            this.errorMessage = "";
            this.boundry = new ArrayList();
            this.mailType = new ArrayList();
            this.mailFileName = new ArrayList();
            this.mailSections = new ArrayList();
            this.command = "";
        }


        //Event Raising Methods
        private void RaiseConnectionEstablishing(string popServer, int popPort)
        {
            if (ConnectionEstablishing != null)
            {
                ConnectionEstablishing(this, popServer, popPort);
            }
        }

        private void RaiseConnectionEstablished(string popServer, int popPort)
        {
            if (ConnectionEstablished != null)
            {
                ConnectionEstablished(this, popServer, popPort);
            }
        }

        private void RaiseDisconnected(string popServer)
        {
            if (Disconnected != null)
            {
                Disconnected(this, popServer);
            }
        }

        private void RaiseAuthenticationBegan(string userName)
        {
            if (AuthenticationBegan != null)
            {
                AuthenticationBegan(this, userName);
            }
        }

        private void RaiseAuthenticationFinished(string userName)
        {
            if (AuthenticationFinished != null)
            {
                AuthenticationFinished(this, userName);
            }
        }

        private void RaiseSendedCommand(string command)
        {
            if (SendedCommand != null)
            {
                SendedCommand(this, command);
            }
        }

        private void RaiseServerResponse(string response)
        {
            if (ServerResponse != null)
            {
                ServerResponse(this,response);
            }
        }

        private void RaiseStartedDataReceiving()
        {
            if (StartedDataReceiving != null)
            {
                StartedDataReceiving(this);
            }
        }

        private void RaiseEndedDataReceiving()
        {
            if (EndedDataReceiving != null)
            {
                EndedDataReceiving(this);
            }
        }



        // Properties
        public string Pop3Server
        {
            get
            {
                return this.pop3ServerAddress;
            }
            set
            {
                this.pop3ServerAddress = value;
            }
        }

        public int Pop3Port
        {
            get
            {
                return this.pop3ServerPort;
            }
            set
            {
                this.pop3ServerPort = value;
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

        public string From
        {
            get
            {
                return this.from;
            }
        }

        public string To
        {
            get
            {
                return this.to;
            }
        }

        public string CC
        {
            get
            {
                return this.cc;
            }
        }

        public string Subject
        {
            get
            {
                return this.subject;
            }
        }

        public string Date
        {
            get
            {
                return this.date;
            }
        }

        public string MimeVersion
        {
            get
            {
                return this.mimeVersion;
            }
        }

        public int TotalEmails
        {
            get
            {
                return this.totalEmails;
            }
        }

        public int TotalEmailSize
        {
            get
            {
                return this.totalEmailSize;
            }
        }

        public int ReceiveTimeOut
        {
            get
            {
                return this.receiveTimeOut;
            }
            set
            {
                this.receiveTimeOut = value;
            }
        }

        public string ErrorMessage
        {
            get
            {
                return this.errorMessage;
            }
        }

        public int MailSections
        {
            get
            {
                return this.mailSections.Count;
            }
        }



        // Methods
        public void Connect()
        {
            string message = "";
            string response = "";
            this.tcp_Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress[] ip_Addresses;

            try
            {
                 ip_Addresses = Dns.GetHostAddresses(this.Pop3Server);
            }
            catch (Exception)
            {
                this.errorMessage = "Pop server \"" + this.Pop3Server + "\" does not exist.";
                throw new SmtpClientException(this.errorMessage);
            }
            IPEndPoint remote_EndPoint = new IPEndPoint(ip_Addresses[0], this.Pop3Port);
            
            //Raise Connection Establishing Event
            this.RaiseConnectionEstablishing(this.pop3ServerAddress, this.pop3ServerPort);
            try
            {
                this.tcp_Socket.Connect((EndPoint)remote_EndPoint);
            }
            catch
            {
                this.errorMessage = "Unable to connect to Pop3 server: " + this.pop3ServerAddress + ",on port " + this.pop3ServerPort+".";
                throw new Pop3ClientException(this.errorMessage);              
            }

            this.networkStream = new NetworkStream(this.tcp_Socket);
            this.secureStream = new SslStream(this.networkStream,true);
            this.secureStream.AuthenticateAsClient(this.pop3ServerAddress);
            response = this.GetResponseFromStream();
            if (!response.Substring(0, 3).Equals("+ok", StringComparison.OrdinalIgnoreCase))
            {
                this.errorMessage = "Server " + this.pop3ServerAddress + " did not send welcome message.";
                this.Disconnect();
                throw new Pop3ClientException(this.errorMessage);
            }

            // Raise Connection Established Event
            this.RaiseConnectionEstablished(this.pop3ServerAddress, this.pop3ServerPort);

            message = "USER " + this.userName + "\r\n";   // It includees user id and domain name
            this.command = "USER";
            Thread.Sleep(2000);
            // Raise Authentication Began Event
            this.RaiseAuthenticationBegan(this.userName);
            this.WriteMessageToStream(message);
            response = this.GetResponseFromStream();
            if (!response.Substring(0, 3).Equals("+ok", StringComparison.OrdinalIgnoreCase))
            {
                this.errorMessage = response;
                this.Disconnect();
                throw new Pop3ClientException(this.errorMessage);
            }

            message = "PASS " + this.password + "\r\n";
            this.command = "PASS";
            this.WriteMessageToStream(message);
            response = this.GetResponseFromStream();
            if (!response.Substring(0, 3).Equals("+ok", StringComparison.OrdinalIgnoreCase))
            {
                this.errorMessage = response;
                this.Disconnect();
                throw new Pop3ClientException(this.errorMessage);
            }
            //Raise Authentication Finished Event (on Authentication success)
            this.RaiseAuthenticationFinished(this.userName);
            return;
        }

        public void Connect(string server, int port, string user_name, string password)
        {
            this.pop3ServerAddress = server;
            this.pop3ServerPort = port;
            this.userName = user_name;
            this.password = password;
            this.Connect();
        }

        public void Disconnect()
        {
            if (this.tcp_Socket != null && this.secureStream != null)
            {
                string message;
                string response = "";
                message = "QUIT\r\n";
                this.command = "QUIT";
                this.WriteMessageToStream(message);
                response = this.GetResponseFromStream();
                if (!response.Substring(0, 3).Equals("+ok", StringComparison.OrdinalIgnoreCase))
                {
                    this.errorMessage = response;
                    throw new Pop3ClientException(this.errorMessage);
                }

                if (this.tcp_Socket.Connected)
                {
                    this.tcp_Socket.Close();
                    
                }
                this.tcp_Socket = null;
                this.networkStream = null;
                this.secureStream = null;
                //Raise Disconnected Event
                this.RaiseDisconnected(this.pop3ServerAddress);
                return;
            }
            else
            {
                this.errorMessage = "Not connected to Pop server.";
                throw new Pop3ClientException(this.errorMessage);
            }
        }

        public void GetMailBoxDetails()
        {
            if (this.tcp_Socket != null && this.secureStream != null)
            {
                string message;
                string response = "";
                message = "STAT\r\n";
                this.command = "STAT";
                this.WriteMessageToStream(message);
                response = this.GetResponseFromStream();
                if (!response.Substring(0, 3).Equals("+ok", StringComparison.OrdinalIgnoreCase))
                {
                    this.errorMessage = response;
                    throw new Pop3ClientException(this.errorMessage);
                }

                int indexFirstSpace = response.IndexOf(" ", 3);
                int indexSecondSpace = response.IndexOf(" ", indexFirstSpace + 1);
                int indexLineTermination = response.IndexOf("\r\n", indexSecondSpace + 1);

                if (indexFirstSpace == -1 || indexSecondSpace == -1 || indexLineTermination == -1)
                {
                    this.errorMessage = "Server sent an invalid reply for STAT command.";
                    throw new Pop3ClientException(this.errorMessage);
                }
                else
                {
                    this.totalEmails = Convert.ToInt32(response.Substring(indexFirstSpace + 1, indexSecondSpace - (indexFirstSpace + 1)));
                    this.totalEmailSize = Convert.ToInt32(response.Substring(indexSecondSpace + 1, indexLineTermination - (indexSecondSpace + 1)));
                    return;
                }
            }
            else
            {
                this.errorMessage = "Not connected to Pop server.";
                throw new Pop3ClientException(this.errorMessage);
            }
        }

        public int GetMailSize(int message_id)
        {
            if (this.tcp_Socket != null && this.secureStream != null)
            {
                if (message_id >= 1 && message_id <= this.totalEmails)
                {
                    string message;
                    string response = "";
                    message = "LIST " + message_id + "\r\n";
                    this.command = "LIST";
                    this.WriteMessageToStream(message);
                    response = this.GetResponseFromStream();
                    if (!response.Substring(0, 3).Equals("+ok", StringComparison.OrdinalIgnoreCase))
                    {
                        this.errorMessage = response;
                        throw new Pop3ClientException(this.errorMessage);
                    }

                    int indexFirstSpace = response.IndexOf(" ", 3);
                    int indexSecondSpace = response.IndexOf(" ", indexFirstSpace + 1);
                    int indexLineTermination = response.IndexOf("\r\n", indexSecondSpace + 1);

                    if (indexFirstSpace == -1 || indexSecondSpace == -1 || indexLineTermination == -1)
                    {
                        this.errorMessage = "Server sent an invalid reply for LIST command.";
                        throw new Pop3ClientException(this.errorMessage);
                    }
                    else
                    {
                        int mail_size = Convert.ToInt32(response.Substring(indexSecondSpace + 1, indexLineTermination - (indexSecondSpace + 1)));
                        return mail_size;
                    }
                }
                else
                {
                    this.errorMessage = "Message Id is invalid.";
                    throw new Pop3ClientException(this.errorMessage);
                }
            }
            else
            {
                this.errorMessage = "Not connected to Pop server.";
                throw new Pop3ClientException(this.errorMessage);
            }
        }

        public void DeleteEmail(int message_id)
        {
            if (this.tcp_Socket != null && this.secureStream != null)
            {
                if (message_id >= 1 && message_id <= this.totalEmails)
                {
                    string message;
                    string response = "";
                    message = "DELE " + message_id + "\r\n";
                    this.command = "DELE";
                    this.WriteMessageToStream(message);
                    response = this.GetResponseFromStream();
                    if (!response.Substring(0, 3).Equals("+ok", StringComparison.OrdinalIgnoreCase))
                    {
                        this.errorMessage = response;
                        throw new Pop3ClientException(this.errorMessage);
                    }
                    return;
                }
                else
                {
                    this.errorMessage = "Message Id is invalid.";
                    throw new Pop3ClientException(this.errorMessage);
                }
            }
            else
            {
                this.errorMessage = "Not connected to Pop server.";
                throw new Pop3ClientException(this.errorMessage);
            }
        }

        public void ResetServer()
        {
            if (this.tcp_Socket != null && this.secureStream != null)
            {
                string message;
                string response = "";
                message = "RSET\r\n";
                this.command = "RSET";
                this.WriteMessageToStream(message);
                response = this.GetResponseFromStream();
                if (!response.Substring(0, 3).Equals("+ok", StringComparison.OrdinalIgnoreCase))
                {
                    this.errorMessage = response;
                    throw new Pop3ClientException(this.errorMessage);
                }
                return;
            }
            else
            {
                this.errorMessage = "Not connected to Pop server.";
                throw new Pop3ClientException(this.errorMessage);
            }
        }

        public string FetchEmail(int message_id)
        {
            if (this.tcp_Socket != null && this.secureStream != null)
            {
                if (message_id >= 1 && message_id <= this.totalEmails)
                {
                    string message;
                    string response = "";
                    string email;

                    message = "RETR "+message_id+"\r\n";
                    this.command = "RETR";
                    // Raise Started Data Receiving Event
                    this.RaiseStartedDataReceiving();
                    this.WriteMessageToStream(message);
                    response = this.GetResponseFromStream();
                    int index = response.IndexOf("\r\n");
                    email = response.Substring(index + 2, response.Length - (index + 2)).Replace("\0","");
                    this.ParseEmail(email);
                    // Raise Ended Data Receiving Event
                    this.RaiseEndedDataReceiving();
                    return email;
                }
                else
                {
                    this.errorMessage = "Message Id is invalid.";
                    throw new Pop3ClientException(this.errorMessage);
                }
            }
            else
            {
                this.errorMessage = "Not connected to Pop server.";
                throw new Pop3ClientException(this.errorMessage);
            }
        }

        public string FetchEmailTop(int message_id, int lines_fetch_from_top)
        {
            if (this.tcp_Socket != null && this.secureStream != null)
            {
                if (message_id >= 1 && message_id <= this.totalEmails)
                {
                    string message;
                    string response = "";
                    string email;

                    message = "TOP " + message_id + " " + lines_fetch_from_top + "\r\n";
                    this.command = "TOP";
                    // Raise Started Data Receiving Event
                    //this.RaiseStartedDataReceiving();
                    this.WriteMessageToStream(message);
                    response = this.GetResponseFromStream();
                    int index = response.IndexOf("\r\n");
                    email = response.Substring(index + 2, response.Length - (index + 2)).Replace("\0", "");
                    this.ParseEmailForHeader(email);
                    // Raise Ended Data Receiving Event
                    //this.RaiseEndedDataReceiving();
                    return email;
                }
                else
                {
                    this.errorMessage = "Message Id is invalid.";
                    throw new Pop3ClientException(this.errorMessage);
                }
            }
            else
            {
                this.errorMessage = "Not connected to Pop server.";
                throw new Pop3ClientException(this.errorMessage);
            }
        }

        public void GetMailSection(int mail_section, ref string body, ref string type, ref string file_name)
        {
            if (mail_section >= 1 || mail_section <= this.mailSections.Count)
            {
                body = this.mailSections[mail_section - 1].ToString();
                type = this.mailType[mail_section - 1].ToString();
                file_name = this.mailFileName[mail_section - 1].ToString();
            }
            else
            {
                throw new Pop3ClientException("Mail section is invalid.");
            }
        }

        public void SaveAttachment(string base64_text, string path)
        {
            FileStream fs = null;

            try
            {
                fs = File.Create(path);
            }
            catch
            {
                throw new Pop3ClientException("File path is invalid.");
            }

            if (base64_text != null && base64_text != "")
            {
                string str = "";
                int i = 0;

                while (!(str = base64_text.Substring(i, 1)).Equals(""))
                {
                    fs.Write(Convert.FromBase64String(str), 0, 1);
                    i++;
                }
                return;
            }
            else
            {
                throw new Pop3ClientException("Encoded text is null.");
            }
        }

        private void ParseEmail(string email)
        {
            string emailInLowerCase = email.ToLower();
            int index_mime = 0;
            int index_Termination = 0;
            this.from = "";
            this.to = "";
            this.cc = "";
            this.subject = "";
            this.date = "";
            this.mimeVersion = "";
            this.boundry.Clear();
            this.mailType.Clear();
            this.mailFileName.Clear();
            this.mailSections.Clear();

            index_mime = emailInLowerCase.IndexOf("from: ", 0);
            if (index_mime != -1)
            {
                index_Termination = email.IndexOf("\r\n", index_mime + 5);
                this.from = email.Substring(index_mime + 5, index_Termination - (index_mime + 5)).Trim();
            }

            index_mime = emailInLowerCase.IndexOf("to: ", 0);
            if (index_mime != -1)
            {
                index_Termination = email.IndexOf("\r\n", index_mime + 3);
                this.to = email.Substring(index_mime + 3, index_Termination - (index_mime + 3)).Trim();
            }

            index_mime = emailInLowerCase.IndexOf("cc: ", 0);
            if (index_mime != -1)
            {
                index_Termination = email.IndexOf("\r\n", index_mime + 3);
                this.cc = email.Substring(index_mime + 3, index_Termination - (index_mime + 3)).Trim();
            }

            index_mime = emailInLowerCase.IndexOf("subject: ", 0);
            if (index_mime != -1)
            {
                index_Termination = email.IndexOf("\r\n", index_mime + 8);
                this.subject = email.Substring(index_mime + 8, index_Termination - (index_mime + 8)).Trim();
            }

            index_mime = emailInLowerCase.IndexOf("date: ", 0);
            if (index_mime != -1)
            {
                index_Termination = email.IndexOf("\r\n", index_mime + 5);
                this.date = email.Substring(index_mime + 5, index_Termination - (index_mime + 5)).Trim();
            }

            index_mime = emailInLowerCase.IndexOf("mime-version: ", 0);
            if (index_mime != -1)
            {
                index_Termination = email.IndexOf("\r\n", index_mime + 13);
                this.mimeVersion = email.Substring(index_mime + 13, index_Termination - (index_mime + 13)).Trim();
            }

            index_mime = emailInLowerCase.IndexOf("boundary=", 0);
            string temp = "";
            for(;index_mime != -1; index_mime = emailInLowerCase.IndexOf("boundary=", index_Termination + 1))
            {
                index_Termination = emailInLowerCase.IndexOf("\r\n", index_mime + 9);
                temp = email.Substring(index_mime + 9,index_Termination - (index_mime + 9));
                temp = temp.TrimStart(new char[] {'"'});
                temp = temp.TrimEnd(new char[] {'"'});
                this.boundry.Add("--" + temp);
            }

            index_mime = emailInLowerCase.IndexOf("\r\ncontent-type:",0);
            string substring;
            while(index_mime != -1)
            {
                substring = "";
                index_Termination = emailInLowerCase.IndexOf("\r\n\r\n",index_mime + 15);

                if(index_Termination == -1)
                {
                    break;
                }
                substring = email.Substring(index_mime + 15, index_Termination - (index_mime + 15));

                if(substring.ToLower().IndexOf("text/html",0) != -1)
                {
                    this.mailType.Add("text/html");
                    this.mailFileName.Add("");
                }
                else if(substring.ToLower().IndexOf("base64",0) != -1)
                {
                    this.mailType.Add("base64");
                    int index1 = substring.ToLower().IndexOf("name=",0);
                    int index2 = substring.IndexOf("\r\n",index1 + 5);
                    this.mailFileName.Add(substring.Substring(index1 + 5,index2 - (index1 + 5)));
                }
                else if (substring.ToLower().IndexOf("text/plain", 0) != -1)
                {
                    this.mailType.Add("text/plain");
                    this.mailFileName.Add("");
                }
                else
                {
                    this.mailType.Add("");
                    this.mailFileName.Add("");
                }

                index_Termination += 4;
                int index = emailInLowerCase.IndexOf("\r\ncontent-type:",index_Termination);
                if(index != -1)
                {
                    substring = email.Substring(index_Termination,index - index_Termination);
                }
                else
                {
                    substring = email.Substring(index_Termination);
                }

                this.mailSections.Add(substring);

                if(index != -1)
                {
                    index_mime = index;
                }
                else
                {
                    index_mime = -1;
                }
            }

            if(this.boundry.Count > 0)
            {
                for(int i=0; i<this.boundry.Count; i++)
                {
                    for(int j=0; j<this.mailSections.Count; j++)
                    {
                        index_mime = this.mailSections[j].ToString().IndexOf(this.boundry[i].ToString(),0);
                        
                        if(index_mime != -1)
                        {
                            if (index_mime != 0)
                            {
                                this.mailSections[j] = this.mailSections[j].ToString().Substring(0, index_mime - 1);
                            }
                            else
                            {
                                this.mailSections[j] = "";
                            }
                        }
                    }
                }
             }
        }

        private void ParseEmailForHeader(string email)
        {
            this.from = "";
            this.subject = "";
            this.date = "";

            string emailInLowerCase = email.ToLower();
            int index_mime = 0;
            int index_Termination = 0;

            index_mime = emailInLowerCase.IndexOf("from: ", 0);
            if (index_mime != -1)
            {
                index_Termination = email.IndexOf("\r\n", index_mime + 5);
                this.from = email.Substring(index_mime + 5, index_Termination - (index_mime + 5)).Trim();
            }

            index_mime = emailInLowerCase.IndexOf("subject: ", 0);
            if (index_mime != -1)
            {
                index_Termination = email.IndexOf("\r\n", index_mime + 8);
                this.subject = email.Substring(index_mime + 8, index_Termination - (index_mime + 8)).Trim();
            }

            index_mime = emailInLowerCase.IndexOf("date: ", 0);
            if (index_mime != -1)
            {
                index_Termination = email.IndexOf("\r\n", index_mime + 5);
                this.date = email.Substring(index_mime + 5, index_Termination - (index_mime + 5)).Trim();
            }
        }

        private string GetResponseFromStream()
        {
            DateTime startDateTime = DateTime.Now;
            TimeSpan timeSpan = DateTime.Now - startDateTime;
            ASCIIEncoding en = new ASCIIEncoding();
            string server_response = "";
            byte[] inputBuffer = new byte[1024];
            int readBytes = 0;

            while (timeSpan.Seconds < this.receiveTimeOut)
            {
               if (this.networkStream.DataAvailable)
               {
                   do
                   {
                        readBytes = this.secureStream.Read(inputBuffer, 0, inputBuffer.Length);
                       
                        if (readBytes == 0)
                        {
                            break;
                        }

                        server_response += en.GetString(inputBuffer, 0, readBytes);
                        if (this.command != "TOP" && this.command != "RETR")
                        {
                             if (server_response.IndexOf("\r\n") != -1)
                             {
                                 break;
                             }
                        }
                        else
                        {
                            if (server_response.IndexOf("\r\n.\r\n") != -1)
                            {
                                break;
                            }
                        }

                    } while (readBytes != 0);

                    break;
               }
               else
               {
                    timeSpan = DateTime.Now - startDateTime;
               }
            }
            // Raise Server Response Event
            this.RaiseServerResponse(server_response);
            return server_response;
        }

        private void WriteMessageToStream(string msg)
        {
            ASCIIEncoding en = new ASCIIEncoding();
            byte[] outputBuffer = en.GetBytes(msg);
            this.secureStream.Write(outputBuffer,0,outputBuffer.Length); 
            // Raise Sended Command Event
            this.RaiseSendedCommand(this.command);
        }
    }
}
