using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCMIS.Logging.Models;

namespace HCMIS.Logging.Loggers
{
    public class ActivityLogger : LoggerBase, IActivityLog
    {
        public void SaveAction(int userId, int activityId, string page, string activityName)
        {
            var log = new ActivityLog
                                  {
                                      UserID = userId,
                                      ActivityID = activityId,
                                      Page = page,
                                      ActivityName = activityName,
                                      TimeStamp = DateTime.Now
                                  };
            Repository.Add(log);
        }
    }
}
