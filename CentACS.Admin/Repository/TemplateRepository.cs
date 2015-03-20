using CentACS.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentACS.Admin.Repository
{
    public class TemplateRepository : BaseRepository<TemplateModel>, IRepository<TemplateModel>
    {
        public bool Create(TemplateModel model)
        {
            // Db 
            
            // Repository 
            Int32 n = this.Keys.Max() + 1;

            this.TryAdd(n, m);

            return true;
        }

        public bool Update(TemplateModel model)
        {
            // Db 

            // Repository 
            this[model.Key] = model;

            return true;
        }

        public bool Remove(TemplateModel model)
        {
            // Db 

            // Repository 
            this.TryRemove(model.Key, out model);

            return true;
        }

        public TemplateModel GetOne(int Key)
        {
            TemplateModel model = new TemplateModel();

            // Db 

            // Repository 
            model = this[Key];


            return model;
        }

        public List<TemplateModel> GetAll()
        {
            // Db 
            if (this.Count == 0)
            {
                
            }

            // Repository 

            return this.Values.ToList();
        }


        public IEnumerable<TemplateModel> Where(Func<TemplateModel, bool> func)
        {
            // Db 

            // Repository 

            return this.Where(func);
        }
    }
}