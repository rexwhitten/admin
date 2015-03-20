namespace CentACS.Admin.App_Code.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblWorkplace_LanguageCapacitorInterpretation
    {
        [Key]
        public int CapacitorInterpretationKey { get; set; }

        public int? LanguageKey { get; set; }

        public int? FitInterpretation { get; set; }

        [StringLength(45)]
        public string Text { get; set; }
    }
}
