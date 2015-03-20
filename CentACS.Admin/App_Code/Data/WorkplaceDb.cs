namespace CentACS.Admin.App_Code.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WorkplaceDb : DbContext
    {
        public WorkplaceDb()
            : base("name=Workplace")
        {
        }

        public virtual DbSet<tblWorkplace_LanguageCapacitorHighPerformance> tblWorkplace_LanguageCapacitorHighPerformance { get; set; }
        public virtual DbSet<tblWorkplace_LanguageCapacitorInterpretation> tblWorkplace_LanguageCapacitorInterpretation { get; set; }
        public virtual DbSet<tblWorkplace_LanguageCapacitorIntro> tblWorkplace_LanguageCapacitorIntro { get; set; }
        public virtual DbSet<tblWorkplace_LanguageCapacitorReport> tblWorkplace_LanguageCapacitorReport { get; set; }
        public virtual DbSet<tblWorkplace_LanguageCompetencyName> tblWorkplace_LanguageCompetencyName { get; set; }
        public virtual DbSet<tblWorkplace_LanguageConsultant> tblWorkplace_LanguageConsultant { get; set; }
        public virtual DbSet<tblWorkplace_LanguageConsultantBlendText> tblWorkplace_LanguageConsultantBlendText { get; set; }
        public virtual DbSet<tblWorkplace_LanguageConsultantResponseBias> tblWorkplace_LanguageConsultantResponseBias { get; set; }
        public virtual DbSet<tblWorkplace_LanguageConsultantTOC> tblWorkplace_LanguageConsultantTOC { get; set; }
        public virtual DbSet<tblWorkplace_LanguageNarratorGroup> tblWorkplace_LanguageNarratorGroup { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
