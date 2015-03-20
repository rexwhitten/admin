using CentACS.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentACS.Admin.Repository
{
    public class Cluster
    {
        #region [ Static Repositories ]
        private static LanguageRepository lang = new LanguageRepository();
        private static ProductRepository products = new ProductRepository();
        private static TemplateRepository templates = new TemplateRepository();
        private static TemplateFieldRepository templateFields = new TemplateFieldRepository();
        #endregion

        #region [ Repositories ] 
        public static IRepository<LanguageModel> Languages
        {
            get { return lang; }
        }

        public static IRepository<ProductModel> Products
        {
            get { return products; }
        }

        public static IRepository<TemplateModel> Templates
        {
            get { return templates; }
        }

        public static IRepository<TemplateFieldModel> TemplateFields
        {
            get { return templateFields;  }
        }
        #endregion

        
    }
}