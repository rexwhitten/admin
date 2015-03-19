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
        public static LanguageRepository Languages
        {
            get { return lang; }
        }

        public static ProductRepository Products
        {
            get { return products; }
        }

        public static TemplateRepository Templates
        {
            get { return templates; }
        }

        public static TemplateFieldRepository TemplateFields
        {
            get { return templateFields;  }
        }
        #endregion

        
    }
}