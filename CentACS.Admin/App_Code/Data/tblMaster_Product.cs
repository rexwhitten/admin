namespace CentACS.Admin.App_Code.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblMaster_Product
    {
        [Key]
        public int ProductKey { get; set; }

        [StringLength(3)]
        public string ProductID { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        public int? Rank { get; set; }

        public DateTime? DateCreated { get; set; }
    }
}
