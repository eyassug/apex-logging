﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace HCMIS.Logging.Models
{
    [Table("ActivityLog")]
    public class ActivityLog : Log
    {
        public int ActivityID { get; set; }
        public string Page { get; set; }
        public string ActivityName { get; set; }
        public string ClassName { get; set; }
    }
}
