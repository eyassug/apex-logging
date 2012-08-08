﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCMIS.Logging.Loggers;

namespace HCMIS.Logging
{
    public static class LogManager
    {
        #region Methods
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
            ISessionLog logger = new SessionLogger();
            logger.Setup(new object());
            return logger;
        }

        public static IProfiler GetProfilerLogger()
        {
            IProfiler logger = new Profiler();
            logger.Setup(new object());
            return logger;
        }

        #endregion


    }
}
