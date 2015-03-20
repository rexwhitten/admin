using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentACS.Admin.Repository
{
    using CentACS.Admin.Models;
    using System.Collections.Concurrent;

    public class BaseRepository<TModel> : ConcurrentDictionary<Int32,TModel> where TModel : IBaseModel
    {
        #region [ Public Methods ] 
        public Int32 GetNextId()
        {
            return this.Keys.Max() + 1;
        }
        #endregion

        #region [ Constructors ]
        public BaseRepository() : base()
        {
            
        }
        #endregion

        public IEnumerable<TModel> ExecQuery(Func<TModel, bool> func)
        {
            return this.Where(M => func.Invoke(M.Value) == true)
                        .Select(M => M.Value);
        }
    }
}