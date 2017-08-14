using System;
using System.Collections.Generic;
using System.Text;

namespace Email_Client
{
    public class Pop3ClientException : Exception
    {
        private string errorMessage = "";

        public Pop3ClientException(string error_message)
        {
            this.errorMessage = error_message;
        }

        public string ErrorMessage
        {
            get
            {
                return this.errorMessage;
            }
        }
    }
}
