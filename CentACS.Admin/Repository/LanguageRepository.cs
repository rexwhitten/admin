using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentACS.Admin.Repository
{
    using CentACS.Admin.Models;
    using CentACS.Admin.App_Code.Data;

    public class LanguageRepository : BaseRepository<LanguageModel> , IRepository<LanguageModel>
    {
        /// <summary>
        /// Database Context
        /// </summary>
        private ProductDb db
        {
            get { return new ProductDb(); }
        }

        public bool Create(LanguageModel model)
        {
            tblMaster_Language record = new tblMaster_Language();

            record.Active = true;
            record.Code = model.Code;
            record.DateCreated = DateTime.Now;
            record.Language = model.Name;
            record.Rank = 0;

            db.Entry(record).State = System.Data.Entity.EntityState.Added;
            db.SaveChangesAsync();

            record = db.tblMaster_Language.Where(l => l.Language == model.Name).First();

            model.Key = record.LanguageKey;
            this.TryAdd(model.Key, model);
            
            return true;
        }

        public bool Update(LanguageModel model)
        {
            tblMaster_Language record = db.tblMaster_Language.Where(l => l.LanguageKey == model.Key).First();

            db.Entry(record).State = System.Data.Entity.EntityState.Modified;
            db.SaveChangesAsync();

            this[model.Key] = model;

            return true;
        }

        public bool Remove(LanguageModel model)
        {
            tblMaster_Language record = db.tblMaster_Language.Where(l => l.LanguageKey == model.Key).First();

            db.Entry(record).State = System.Data.Entity.EntityState.Deleted;

            db.SaveChangesAsync();

            this.TryRemove(model.Key, out model);

            return true;
        }

        public LanguageModel GetOne(int Key)
        {
            return this[Key];
        }

        public List<LanguageModel> GetAll()
        {
            if (this.Count == 0)
            {
                db.tblMaster_Language.Select(l => new LanguageModel()
                {
                     Key = l.LanguageKey,
                     Name = l.Language,
                     Code = l.Code
                })
                .ToList()
                .ForEach(l =>
                {
                    this.TryAdd(l.Key, l);
                });
            }

            return this.Values.ToList();
        }


        public IEnumerable<LanguageModel> Where(Func<LanguageModel, bool> func)
        {
            return this.Where(func);
        }
    }
}