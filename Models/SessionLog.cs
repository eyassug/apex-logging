using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace HCMIS.Logging.Models
{
    [Table("SessionLog")]
    public class SessionLog : Log
    {
        public Guid SessionID { get; set; }
        public DateTime EndTime { get; set; }
    }
}
