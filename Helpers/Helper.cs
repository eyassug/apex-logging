using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace HCMIS.Logging.Helpers
{
    class Helper
    {
        public static string GetIP()
        {
            string strHostName = "";
            strHostName = System.Net.Dns.GetHostName();

            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);

            IPAddress[] addr = ipEntry.AddressList;

            return addr[addr.Length - 2].ToString();
        }
    }
}
