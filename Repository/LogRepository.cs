using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HCMIS.Logging.Models;

namespace HCMIS.Logging.Repository
{
    public class LogRepository:GenericRepository<LoggingContext,Log>
    {
        /// <summary>
        /// Gets a list of a specific type of Log 
        /// </summary>
        /// <typeparam name="TType">ActivityLog, ErrorLog, ProfileLog, SessionLog</typeparam>
        /// <param name="predicate">Lambda expression</param>
        /// <returns></returns>
        public IQueryable<TType> FindByType<TType>(System.Linq.Expressions.Expression<Func<TType, bool>> predicate) where TType : Log
        {
            var query = Context.Logs.OfType<TType>().Where(predicate);
            return query;
        }
    }
}
