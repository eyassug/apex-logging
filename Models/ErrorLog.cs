using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace HCMIS.Logging.Models
{
    [Table("ErrorLog")]
    public class ErrorLog : Log
    {
        public string AppVersion { get; set; }
        public string DbVersion { get; set; }
        public int ErrorLevel { get; set; }
        public string Form { get; set; }
        public string Activity { get; set; }
        public string Exception { get; set; }
        public string StackTrace { get; set; }

        public int LineNumber { get; set; }
        public string ExceptionType { get; set; }
        public string Message { get; set; }
        public string Method { get; set; }
        public string File { get; set; }

        public DateTime Date { get; set; }
        public string IPAddress { get; set; }
        public int VPNIP { get; set; }
        public string WareHouse { get; set; }


    }
}
