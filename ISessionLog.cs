using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCMIS.Logging
{
    public interface ISessionLog : ILog
    {
        void Login(int userId, DateTime loginDate);
        void KeepAlive(int userId, DateTime time);
        void Logout(int userId, DateTime logoutTime, int logoutType);
    }
}
