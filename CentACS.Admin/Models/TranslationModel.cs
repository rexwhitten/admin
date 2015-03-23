using CentACS.Admin.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentACS.Admin.Models
{
    public class TranslationIndexModel
    {
        public List<tblMaster_Product> ProductsList { get; set; }
        public List<tblMaster_Language> LanguageList { get; set; }

        public List<TranslationModel> TranslationList { get; set; }

        public TranslationIndexModel()
        {
            this.ProductsList = new List<tblMaster_Product>();
            this.LanguageList = new List<tblMaster_Language>();
            this.TranslationList = new List<TranslationModel>();
        }
    }


    public class TranslationModel
    {
        public tblMaster_Product Product { get; set; }

        public tblMaster_Language Language { get; set; }

        public TranslationModel()
        {
            this.Product = new tblMaster_Product();
            this.Language = new tblMaster_Language();
        }
    }
}