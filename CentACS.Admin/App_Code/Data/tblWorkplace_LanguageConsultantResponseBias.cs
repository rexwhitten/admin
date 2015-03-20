namespace CentACS.Admin.App_Code.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblWorkplace_LanguageConsultantResponseBias
    {
        [Key]
        public int LangaugeResponseBiasKey { get; set; }

        public int? LanguageKey { get; set; }

        public int? ResponseBias { get; set; }

        [StringLength(100)]
        public string ResponseBiasText { get; set; }
    }
}
