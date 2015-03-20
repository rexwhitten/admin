namespace CentACS.Admin.App_Code.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblWorkplace_LanguageCapacitorReport
    {
        [Key]
        public int LanguageCapacitorCompReportKey { get; set; }

        public int? LanguageKey { get; set; }

        [StringLength(50)]
        public string ReportHeader { get; set; }

        [StringLength(75)]
        public string EstimatedFit { get; set; }

        [StringLength(50)]
        public string InterpretationOfFit { get; set; }

        [StringLength(50)]
        public string FitLegend { get; set; }

        [StringLength(50)]
        public string OptimumHeader { get; set; }

        [StringLength(50)]
        public string ActualHeader { get; set; }

        [StringLength(50)]
        public string AvailableHeader { get; set; }

        [StringLength(200)]
        public string DescriptionHeader { get; set; }

        [StringLength(75)]
        public string IndicatorPrefix { get; set; }

        [StringLength(10)]
        public string SourceText { get; set; }
    }
}
