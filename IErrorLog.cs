using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCMIS.Logging
{
    public interface IErrorLog : ILog
    {
        void SaveError(int userId, int appVersion, int dbVersion, int errorLevel, string page, string activity, DateTime errorDate, Exception exception);
    }
}
