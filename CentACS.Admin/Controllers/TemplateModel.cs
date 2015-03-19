using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentACS.Admin.Controllers
{
    public class TemplateModel
    {
        public Int32 Key { get; set; }

        public String Name { get; set; }

        
    }

    public class TemplateFieldModel
    {
        public Int32 Key { get; set; }

        public Int32 TemplateKey { get; set; }

        public Int32 LanguageKey { get; set; }

        public String Name { get; set; }


    }
}