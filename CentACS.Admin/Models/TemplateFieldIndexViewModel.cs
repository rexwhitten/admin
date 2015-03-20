using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentACS.Admin.Models
{
    public class TemplateFieldIndexViewModel
    {
        public List<LanguageModel> Lanuages { get; set; }

        public List<TemplateFieldModel> Fields { get; set; }

        public TemplateFieldIndexViewModel()
        {
            this.Lanuages = new List<LanguageModel>();
            this.Fields = new List<TemplateFieldModel>();
        }
    }
}