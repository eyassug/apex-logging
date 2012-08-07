using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCMIS.Logging.Models;

namespace HCMIS.Logging.Repository
{
    public class LogRepository:GenericRepository<LoggingContext,Log>
    {
        public IQueryable<ActivityLog> GetAllActivityLogs()
        {
            return Context.Logs.OfType<ActivityLog>();
        }

        public IQueryable<ErrorLog> GetAllErrorLogs()
        {
            return Context.Logs.OfType<ErrorLog>();
        }

        public IQueryable<SessionLog> GetAllSessionLogs()
        {
            return Context.Logs.OfType<SessionLog>();
        }

        public IQueryable<ProfileLog> GetAllProfileLogs()
        {
            return Context.Logs.OfType<ProfileLog>();
        }
    }
}
