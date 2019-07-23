using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Email_Client
{
    [Flags]
    enum ConnectionState : int
    {
        INTERNET_CONNECTION_MODEM = 0x1, INTERNET_CONNECTION_LAN = 0x2, INTERNET_CONNECTION_PROXY = 0x4, INTERNET_RAS_INSTALLED = 0x10, INTERNET_CONNECTION_OFFLINE = 0x20, INTERNET_CONNECTION_CONFIGURED = 0x40
    }

    public class Internet
    {
        [DllImport("wininet.dll", CharSet = CharSet.Auto)]
        static extern bool InternetGetConnectedState(ref ConnectionState lpdwFlags, int dwReserved);

        public Internet()
        {

        }

        public static bool IsConnectedToInternet()
        {
            ConnectionState Description = 0;
            bool conn = InternetGetConnectedState(ref Description, 0);
            return conn;
        }
    }
}
