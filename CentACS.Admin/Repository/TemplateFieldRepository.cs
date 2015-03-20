using CentACS.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentACS.Admin.Repository
{
    public class TemplateFieldRepository : BaseRepository<TemplateFieldModel>, IRepository<TemplateFieldModel>
    {
        public bool Create(TemplateFieldModel model)
        {
            int key = this.Keys.Max() + 1;

            model.Key = key;
            this.TryAdd(key, model);

            return true;
        }

        public bool Update(TemplateFieldModel model)
        {
            this[model.Key] = model;

            return true;
        }

        public bool Remove(TemplateFieldModel model)
        {
            this.TryRemove(model.Key,out model);

            return true;
        }

        public TemplateFieldModel GetOne(int Key)
        {
            // Db 

            // Repository 

            return this[Key];
        }

        public List<TemplateFieldModel> GetAll()
        {
            // Db 

            // Repository 

            return this.Values.ToList();
        }


        public IEnumerable<TemplateFieldModel> Where(Func<TemplateFieldModel, bool> func)
        {
            return this.Where(func);
        }
    }
}