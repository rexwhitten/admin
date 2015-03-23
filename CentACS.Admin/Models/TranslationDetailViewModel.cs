using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentACS.Admin.Models
{
    public class TranslationDetailViewModel
    {
        public Data.tblMaster_Language Language { get; set; }

        public Data.tblMaster_Product Product { get; set; }

        public TranslationDetailViewModel()
        {
            this.Language = new Data.tblMaster_Language();
            this.Product = new Data.tblMaster_Product();
        }
    }
}
