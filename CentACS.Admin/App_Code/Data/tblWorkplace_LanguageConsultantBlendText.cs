namespace CentACS.Admin.App_Code.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblWorkplace_LanguageConsultantBlendText
    {
        [Key]
        public int ConsultantBlendTextKey { get; set; }

        public int? LanguageKey { get; set; }

        [StringLength(75)]
        public string ReportHeader { get; set; }

        [StringLength(30)]
        public string InterpretGuide { get; set; }

        [StringLength(10)]
        public string Note { get; set; }

        [StringLength(500)]
        public string NoteText { get; set; }

        [StringLength(10)]
        public string NameHeader { get; set; }

        [StringLength(10)]
        public string BlendsHeader { get; set; }

        [StringLength(20)]
        public string DefinitionHeader { get; set; }
    }
}
