using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace HCMIS.Logging.Models
{
    [Table("ErrorLogs")]
    public class ErrorLog : Log
    {
        public string AppVersion { get; set; }
        public string DbVersion { get; set; }
        public ErrorLevel ErrorLevel { get; set; }
        public string Page { get; set; }
        public string Activity { get; set; }
        public string Exception { get; set; }

    }

    public enum ErrorLevel
    {
        Low,
        Medium,
        High,
        Critical,
        Fatal
    }
}
