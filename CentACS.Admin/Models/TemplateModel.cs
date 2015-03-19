using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CentACS.Admin.Models
{
    public class TemplateModel : IBaseModel
    {
        public ProductModel Product { get; set; }
        public Int32 Key { get; set; }
        public String Name { get; set; }
        public TemplateModel()
        {
            this.Key = 0;
            this.Name = "";

            this.Product = new ProductModel()
            {
                Key = 0,
                Name = ""
            };
        }
    }
}