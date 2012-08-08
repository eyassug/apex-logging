using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCMIS.Logging.Models;

namespace HCMIS.Logging.Loggers
{
    class SessionLogger : LoggerBase, ISessionLog
    {

        public void Login(int userId, DateTime loginDate)
        {
            SessionLog session = new SessionLog
            {
                UserID = userId,
                TimeStamp = DateTime.Now,
            };
            Repository.Add(session);
        }

        public void KeepAlive(int userId, DateTime time)
        {
           // what is this method supposed to do
        }

        public void Logout(int userId, DateTime logoutTime, int logoutType)
        {
            var session = Repository.FindByType<SessionLog>(s => s.UserID == userId).Single();
            session.EndTime = logoutTime;
            Repository.Update(session);
        }
    }
}
