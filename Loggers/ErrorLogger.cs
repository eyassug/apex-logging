using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCMIS.Logging.Models;

namespace HCMIS.Logging.Loggers
{
    public class ErrorLogger : LoggerBase, IErrorLog
    {
        public void SaveError(int userId, int appVersion, int dbVersion, int errorLevel, string page, string activity, DateTime errorDate, Exception exception)
        {
            var log = new ErrorLog
                          {
                              UserID = userId,
                              TimeStamp = DateTime.Now,
                              Activity = activity,
                              AppVersion = appVersion.ToString(),
                              DbVersion = dbVersion.ToString(),
                              Page = page,
                              ErrorLevel = (ErrorLevel)errorLevel,
                              Exception = exception.Message,
                          };
            Repository.Add(log);
        }
    }
}
