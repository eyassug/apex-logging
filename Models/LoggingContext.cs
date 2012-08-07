using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace HCMIS.Logging.Models
{
    public class LoggingContext : DbContext
    {
        public LoggingContext()
            : base("name=LoggingEntities")
        {
        }

        public LoggingContext(string name)
            : base(name)
        {
        }

        public DbSet<Log> Logs { get; set; }
    }
}
