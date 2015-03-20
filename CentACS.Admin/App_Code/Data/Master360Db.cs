namespace CentACS.Admin.App_Code.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Master360Db : DbContext
    {
        public Master360Db()
            : base("name=Master360Db")
        {
        }

        public virtual DbSet<tblMaster360_QuestionnaireItem> tblMaster360_QuestionnaireItem { get; set; }
        public virtual DbSet<tblMaster360_QuestionnaireText> tblMaster360_QuestionnaireText { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblMaster360_QuestionnaireItem>()
                .Property(e => e.Mean)
                .IsUnicode(false);
        }
    }
}
