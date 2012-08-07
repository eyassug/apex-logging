using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCMIS.Logging.Loggers;

namespace HCMIS.Logging
{
    public static class LogManager
    {
        public static IActivityLog GetActivityLogger()
        {
            IActivityLog logger = new ActivityLogger();
            logger.Setup(new object());
            return logger;
        }

        public static IErrorLog GetErrorLogger()
        {
            IErrorLog logger = new ErrorLogger();
            logger.Setup(new object());
            return logger;
        }

        public static ISessionLog GetSessionLogger()
        {
            throw new NotImplementedException();
        }

        public static IProfiler GetProfilerLogger()
        {
            throw new NotImplementedException();
        }
    }
}
