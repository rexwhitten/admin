namespace CentACS.Admin.App_Code.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblWorkplace_LanguageCapacitorIntro
    {
        [Key]
        public int LanguageCapacitorKey { get; set; }

        public int? LanguageKey { get; set; }

        [StringLength(20)]
        public string DevelopedBy { get; set; }

        [StringLength(20)]
        public string SummaryHeader { get; set; }

        public string SummaryText { get; set; }

        [StringLength(30)]
        public string ReportDescHeader { get; set; }

        public string ReportDescText { get; set; }

        [StringLength(100)]
        public string CompetencySubHeader { get; set; }

        [StringLength(75)]
        public string CompetencyHeader { get; set; }

        [StringLength(25)]
        public string ImportantNote { get; set; }

        public string ImportantNoteText { get; set; }
    }
}
