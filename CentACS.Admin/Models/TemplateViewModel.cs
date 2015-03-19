using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentACS.Admin.Models
{
    public class TemplateViewModel
    {
        public TemplateModel Template { get; set; }

        public ProductModel Product { get; set; }

        public TemplateViewModel()
        {
            this.Template = new TemplateModel();
            this.Product = new ProductModel();
        }
    }
}