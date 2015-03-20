namespace CentACS.Admin.App_Code.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblWorkplace_LanguageCompetencyName
    {
        [Key]
        public int LanguageCompetencyNameKey { get; set; }

        public int? LanguageKey { get; set; }

        public int? CompetencyKey { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
    }
}
