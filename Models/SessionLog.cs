﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace HCMIS.Logging.Models
{
    [Table("SessionLogs")]
    public class SessionLog : Log
    {
        public DateTime LoginTime { get; set; }
        public DateTime LogoutTime { get; set; }
    }
}
