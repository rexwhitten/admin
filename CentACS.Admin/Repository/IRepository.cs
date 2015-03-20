using CentACS.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentACS.Admin.Repository
{
    public interface IRepository<TModel> where TModel : IBaseModel
    {
        bool Create(TModel model);

        bool Update(TModel model);

        bool Remove(TModel model);

        TModel GetOne(Int32 Key);

        List<TModel> GetAll();

        bool ContainsKey(int id);

        IEnumerable<TModel> Query(Func<TModel, bool> func);
    }
}
