using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCMIS.Logging.Loggers;

namespace HCMIS.Logging
{
    public static class LogManager
    {
        #region Fields
        private static string _connectionString="LoggingEntities";

        #endregion

        #region Private Helper Methods
        static void CheckIfConnectionStringExists()
        {
            if (String.IsNullOrEmpty(ConnectionString))
                throw new Exception("Connection string is not set. Use LogManager.ConnectionString to set a new connection string.");
        }
        #endregion

        #region Methods
        public static IActivityLog GetActivityLogger()
        {
            CheckIfConnectionStringExists();
            IActivityLog logger = new ActivityLogger();
            return logger;
        }

        public static IErrorLog GetErrorLogger()
        {
            CheckIfConnectionStringExists();
            IErrorLog logger = new ErrorLogger();
            return logger;
        }

        public static ISessionLog GetSessionLogger()
        {
            CheckIfConnectionStringExists();
            ISessionLog logger = new SessionLogger();
            return logger;
        }

        public static IProfiler GetProfilerLogger()
        {
            CheckIfConnectionStringExists();
            IProfiler logger = new Profiler();
            return logger;
        }

        #endregion

        #region Properties

        public static string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value;}
        }

        #endregion

    }
}
