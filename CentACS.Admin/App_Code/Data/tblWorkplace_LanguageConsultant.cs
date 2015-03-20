namespace CentACS.Admin.App_Code.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblWorkplace_LanguageConsultant
    {
        [Key]
        public int LanguageConsultantKey { get; set; }

        public int? LanguageKey { get; set; }

        [StringLength(50)]
        public string DevelopedBy { get; set; }

        public string Introduction { get; set; }

        [StringLength(15)]
        public string Note { get; set; }

        [StringLength(500)]
        public string NoteText { get; set; }

        [StringLength(50)]
        public string Pure { get; set; }

        [StringLength(50)]
        public string Situational { get; set; }

        [StringLength(50)]
        public string Polarized { get; set; }

        [StringLength(50)]
        public string EvidenceBias { get; set; }

        [StringLength(500)]
        public string EvidenceBiasLegend { get; set; }

        [StringLength(75)]
        public string ItemResponses { get; set; }
    }
}
