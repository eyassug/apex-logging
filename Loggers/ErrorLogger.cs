using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCMIS.Logging.Models;
using HCMIS.Logging.Helpers;

namespace HCMIS.Logging.Loggers
{
    public class ErrorLogger : LoggerBase, IErrorLog
    {
        public void SaveError(int userId, int appVersion, int dbVersion, int errorLevel, string page, string activity, string warehouse, DateTime errorDate, Exception exception)
        {
            var log = new ErrorLog
                          {
                              UserID = userId,
                              TimeStamp = DateTime.Now,
                              Activity = activity,
                              AppVersion = appVersion.ToString(),
                              DbVersion = dbVersion.ToString(),
                              Form = page,
                              ErrorLevel = errorLevel,
                              Exception = Convert.ToString(exception),
                              File = exception.Source,
                              Method = Convert.ToString(exception.TargetSite),
                              Message = exception.Message,
                              ExceptionType = Convert.ToString(exception.GetType()),
                              IPAddress = Helper.GetIP(),
                              WareHouse = warehouse,
                              Date = errorDate
                          };
            Repository.Add(log);
        }
        
    }
}
