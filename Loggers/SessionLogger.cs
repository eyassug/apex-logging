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
            throw new NotImplementedException();
        }

        public void Logout(int userId, DateTime logoutTime, int logoutType)
        {
            var sessions = Repository.FindByType<SessionLog>(s => s.UserID == userId);
            foreach (SessionLog session in sessions)
            {   
               session.EndTime = logoutTime;
               Repository.Update(session);
            }
            
        }
    }
}
