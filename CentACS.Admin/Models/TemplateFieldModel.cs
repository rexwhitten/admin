using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentACS.Admin.Models
{
    public class TemplateFieldModel : IBaseModel
    {
        public Int32 Key { get; set; }

        public Int32 TemplateKey { get; set; }

        public Int32 LanguageKey { get; set; }

        public String Name { get; set; }

        public String BaseValue { get; set; }

        public String TranslatedValue { get; set; }

        public TemplateFieldModel()
        {

        }
    }
}