using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentACS.Admin.Repository
{
    using CentACS.Admin.Models;
    using System.Collections.Concurrent;

    public class BaseRepository<TModel> : ConcurrentDictionary<Int32,TModel> where TModel: IBaseModel
    {
        public Int32 GetNextId()
        {
            return this.Keys.Max() + 1;
        }

        public BaseRepository()
        {

        }
    }
}