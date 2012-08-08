using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCMIS.Logging.Models;

namespace HCMIS.Logging.Loggers
{
    class Profiler : LoggerBase, IProfiler
    {
        public Guid StartOperation(int userId, string page, string action)
        {            
            ProfileLog log = new ProfileLog
            {
                UserID = userId,
                Page = page,
                Action = action,
            };
            Type profileType = typeof(ProfileLog);
            Guid profileGuid = (Guid)profileType.GUID;
            log.OperationID = profileGuid;
            log.TimeStamp = DateTime.Now;
            Repository.Add(log);
            return profileGuid;
        }

        public void EndOperation(Guid operationId)
        {
            var profile = Repository.FindByType<ProfileLog>(p => p.OperationID == operationId).Single();
            profile.EndTime = DateTime.Now;
            Repository.Update(profile);
        }
    }
}
