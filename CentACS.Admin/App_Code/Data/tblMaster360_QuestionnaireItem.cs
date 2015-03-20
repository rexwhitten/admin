namespace CentACS.Admin.App_Code.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblMaster360_QuestionnaireItem
    {
        [Key]
        public int QuestionnaireItemKey { get; set; }

        public int CompetencyKey { get; set; }

        [Required]
        [StringLength(200)]
        public string ItemText { get; set; }

        public bool IsPublic { get; set; }

        public bool Archived { get; set; }

        public bool Approved { get; set; }

        [Required]
        [StringLength(20)]
        public string Mean { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
