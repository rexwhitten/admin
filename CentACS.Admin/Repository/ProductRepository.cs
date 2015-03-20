
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentACS.Admin.Repository
{
    using CentACS.Admin.Models;
    using CentACS.Admin.App_Code.Data;

    public class ProductRepository : BaseRepository<ProductModel>, IRepository<ProductModel>
    {
        #region [ Fields ] 
        private ProductDb Db
        {
            get { return new ProductDb(); }
        }
        #endregion


        public ProductRepository()
        {
             
        }

        public bool Create(ProductModel model)
        {
             //Db 
            tblMaster_Product record = new tblMaster_Product();
            record.DateCreated = DateTime.Now;
            record.ProductID = model.Name.Substring(0, 4);
            record.ProductName = model.Name;
            record.Rank = 0;

            Db.tblMaster_Product.Add(record);
            Db.SaveChangesAsync();

            // Updte Repository
            Int32 new_id = Db.tblMaster_Product.Where(p => p.ProductName == model.Name).First().ProductKey;

            if (this.ContainsKey(new_id))
            {
                this[new_id] = model;
            }
            else
            {
                this.TryAdd(new_id, model);
            }

            return true;
        }

        public bool Update(ProductModel model)
        {
            //Db 
            tblMaster_Product record = Db.tblMaster_Product.Where(p => p.ProductKey == model.Key).First();
            record.ProductName = model.Name;
            record.ProductID = model.Name.Substring(0, 4);
            record.Rank = 0;

            Db.Entry<tblMaster_Product>(record).State = System.Data.Entity.EntityState.Modified;

            Db.SaveChangesAsync();

            this[model.Key] = model;

            return true;
        }

        public bool Remove(ProductModel model)
        {
            // Db 
            tblMaster_Product record = Db.tblMaster_Product.Where(p => p.ProductKey == model.Key).First();

            Db.Entry(record).State = System.Data.Entity.EntityState.Deleted;
            Db.SaveChangesAsync();

            // Repository
            var result = this.TryRemove(model.Key, out model);

            return result;
        }

        public ProductModel GetOne(int Key)
        {
            return this[Key];
        }

        public List<ProductModel> GetAll()
        {
            if (this.Count == 0)
            {
                this.Db.tblMaster_Product.Select(p => new ProductModel()
                {
                    Key = p.ProductKey,
                    Name = p.ProductName

                }).ToList().ForEach(p => this.TryAdd(p.Key, p));
            }

            return this.Values.ToList();
        }

        public IEnumerable<ProductModel> Query(Func<ProductModel, bool> func)
        {
            if (this.Count == 0)
            {
                this.GetAll();
            }

            return this.ExecQuery(func);
        }
    }
}