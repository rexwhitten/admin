using CentACS.Admin.App_Code.Data;
using CentACS.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentACS.Admin.Repository
{
    public class TemplateFieldRepository : BaseRepository<TemplateFieldModel>, IRepository<TemplateFieldModel>
    {
        #region [ Db ] 
        private WorkplaceDb Db
        {
            get { return new WorkplaceDb(); }
        }
        #endregion

        public bool Create(TemplateFieldModel model)
        {
            // Db 
            var record = new tblWorkplace_LanguageCapacitorHighPerformance()
            {
                LanguageKey = model.LanguageKey,
                HighPerfStrategy = 1,
                Text = model.TranslatedValue
            };

            Db.Entry(record).State = System.Data.Entity.EntityState.Added;
            Db.SaveChangesAsync();

            var new_id = Db.tblWorkplace_LanguageCapacitorHighPerformance
                            .Where( r => r.LanguageKey == model.LanguageKey && r.Text == model.TranslatedValue)
                            .First()
                            .CapacitorHighPerfKey;

            // Repository
            model.Key = new_id;
            this.TryAdd(new_id, model);

            return true;
        }

        public bool Update(TemplateFieldModel model)
        {
            // Db 
            var record = Db.tblWorkplace_LanguageCapacitorHighPerformance
                            .Where(r => r.CapacitorHighPerfKey == model.Key)
                            .First();

            record.Text = model.TranslatedValue;

            Db.Entry(record).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChangesAsync();

            // Repository
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
            if (this.ContainsKey(Key) == false)
            {
                var record = Db.tblWorkplace_LanguageCapacitorHighPerformance
                  .Where(r => r.CapacitorHighPerfKey == Key)
                  .First();

                this.TryAdd(Key, new TemplateFieldModel()
                {
                     Key = record.CapacitorHighPerfKey,
                     LanguageKey = record.LanguageKey.Value,
                     Name = "Text",
                     TemplateKey = 1,
                     TranslatedValue = record.Text,
                     BaseValue = this.Db.tblWorkplace_LanguageCapacitorHighPerformance.Where( r => r.LanguageKey == 1 && r.CapacitorHighPerfKey == record.CapacitorHighPerfKey).First().Text
                });
            }
            
            // Repository 

            return this[Key];
        }

        public List<TemplateFieldModel> GetAll()
        {
            // Db 
            if (this.Count == 0)
            {
                var results = Db.tblWorkplace_LanguageCapacitorHighPerformance.Where(r => r.LanguageKey > 0).ToList();

                results.Select(r => new TemplateFieldModel()
                  {
                      Key = r.CapacitorHighPerfKey,
                      BaseValue = this.GetBaseTranslatedValue(r.HighPerfStrategy.Value),
                      LanguageKey = r.LanguageKey.Value,
                      Name = "Text",
                      TemplateKey = 1,
                      TranslatedValue = r.Text
                  }).ToList()
                  .ForEach(r => this.TryAdd(r.Key, r));
            }

            // Repository 

            return this.Values.ToList();
        }

        private string GetBaseTranslatedValue(int HighPerfStrategy)
        {
            string value = "no base value";

            var results = this.Db.tblWorkplace_LanguageCapacitorHighPerformance
                                        .Where(e => e.LanguageKey == 1 && e.HighPerfStrategy == HighPerfStrategy);

            if (results.Any())
            {
                value = results.First().Text;
            }
                              
            return value;
        }


        public IEnumerable<TemplateFieldModel> Query(Func<TemplateFieldModel, bool> func)
        {
            return this.Query(func);
        }
    }
}