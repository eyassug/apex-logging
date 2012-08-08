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
        public string Page { get; set; }
        public string Activity { get; set; }
        public string Exception { get; set; }

    }
}
