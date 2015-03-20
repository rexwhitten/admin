using CentACS.Admin.App_Code.Data;
using CentACS.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentACS.Admin.Repository
{
    public class TemplateRepository : BaseRepository<TemplateModel>, IRepository<TemplateModel>
    {
        private WorkplaceDb Db
        {
            get { return new WorkplaceDb(); }
        }

        public bool Create(TemplateModel model)
        {
            // Db 
            // We will use Tables Names for a Potential Template Name 

            // Repository 
            Int32 n = this.Keys.Max() + 1;

            this.TryAdd(n, model);

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

            if (this.ContainsKey(Key) == false)
            {
                
            }

            // Db

            // Repository 
            model = this[Key];

            return model;
        }

        public List<TemplateModel> GetAll()
        {
            // Proto 
            if (this.Count == 0)
            {
                this.TryAdd(1, new TemplateModel()
                {
                    Key = 1,
                    Name = "Capcitor High Performance",
                    Product = Cluster.Products
                                      .Query(l => l.Key == 9)
                                      .First()
                });
            }

            // Db 
            // No Db? ? 

            // Repository 



            return this.Values.ToList();
        }

        public IEnumerable<TemplateModel> Query(Func<TemplateModel, bool> func)
        {
            // Db 

            // Repository 

            return this.Query(func);
        }
    }
}