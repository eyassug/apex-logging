using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCMIS.Logging.Models;

namespace HCMIS.Logging.Loggers
{
    class SessionLogger : LoggerBase, ISessionLog
    {

        public Guid Login(int userId)
        {
            SessionLog session = new SessionLog
            {
                UserID = userId
            };
            session.SessionID = Guid.NewGuid();
            session.TimeStamp = DateTime.Now;
            Repository.Add(session);
            return session.SessionID;
        }

        public void KeepAlive(int userId, DateTime time)
        {
            throw new NotImplementedException();
        }

        public void Logout(Guid sessionID)
        {
            var session = Repository.FindByType<SessionLog>(s => s.SessionID == sessionID).Single();
            session.EndTime = DateTime.Now;
            Repository.Update(session);
        }
    }
}
