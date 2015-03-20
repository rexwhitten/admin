namespace CentACS.Admin.App_Code.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblWorkplace_LanguageConsultantTOC
    {
        [Key]
        public int ConsultantTOCKey { get; set; }

        public int? LanguageKey { get; set; }

        [StringLength(50)]
        public string ReportTitle { get; set; }

        [StringLength(50)]
        public string Introduction { get; set; }

        [StringLength(50)]
        public string IndivTraitScores { get; set; }

        [StringLength(50)]
        public string ResponseBias { get; set; }

        [StringLength(50)]
        public string ItemResponses { get; set; }

        [StringLength(50)]
        public string TraitBlends { get; set; }

        [StringLength(50)]
        public string TraitSummary { get; set; }

        [StringLength(10)]
        public string Page { get; set; }

        [StringLength(50)]
        public string Rights { get; set; }
    }
}
