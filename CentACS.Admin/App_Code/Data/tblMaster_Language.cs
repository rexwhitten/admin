namespace CentACS.Admin.App_Code.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblMaster_Language
    {
        [Key]
        public int LanguageKey { get; set; }

        [StringLength(50)]
        public string Language { get; set; }

        [StringLength(4)]
        public string Code { get; set; }

        public int? Rank { get; set; }

        public bool? Active { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
