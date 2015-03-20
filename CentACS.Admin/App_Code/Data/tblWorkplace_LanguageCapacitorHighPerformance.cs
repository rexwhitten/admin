namespace CentACS.Admin.App_Code.Data
{
    using CentACS.Admin.App_Code.Attributes;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [TranslationTableType(TranslationTableType.A)]
    public partial class tblWorkplace_LanguageCapacitorHighPerformance
    {
        [Key]
        public int CapacitorHighPerfKey { get; set; }

        public int? LanguageKey { get; set; }

        public int? HighPerfStrategy { get; set; }

        [StringLength(15)]
        public string Text { get; set; }
    }
}
