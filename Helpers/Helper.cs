using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Diagnostics;

namespace HCMIS.Logging.Helpers
{
    class Helper
    {
        /// <summary>
        /// Gets the IP address of the local machine where the app is running.
        /// </summary>
        /// <returns></returns>
        public static string GetIP()
        {
            string strHostName = "";
            strHostName = System.Net.Dns.GetHostName();

            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);

            IPAddress[] addr = ipEntry.AddressList;

            return addr[addr.Length - 2].ToString();
        }

        /// <summary>
        /// Gets the line number that raised the exception
        /// </summary>
        /// <param name="ex">Exception</param>
        /// <returns></returns>
        public static int GetLineNumber(Exception ex)
        {
            var st = new StackTrace(ex, true);
            // Get the top stack frame
            var frame = st.GetFrame(0);
            // Get the line number from the stack frame
            var line = frame.GetFileLineNumber();
            return line;
        }
    }
}
