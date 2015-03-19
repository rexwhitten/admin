using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentACS.Admin.Models
{
    public class ProductModel : IBaseModel
    {
        public Int32 Key { get; set; }

        public String Name { get; set; }
    }
}