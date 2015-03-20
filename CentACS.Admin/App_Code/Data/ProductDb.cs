namespace CentACS.Admin.App_Code.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProductDb : DbContext
    {
        public ProductDb()
            : base("name=Product")
        {
        }

        public virtual DbSet<tblMaster_Language> tblMaster_Language { get; set; }
        public virtual DbSet<tblMaster_Product> tblMaster_Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblMaster_Language>()
                .Property(e => e.Language)
                .IsUnicode(false);

            modelBuilder.Entity<tblMaster_Language>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<tblMaster_Product>()
                .Property(e => e.ProductID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblMaster_Product>()
                .Property(e => e.ProductName)
                .IsUnicode(false);
        }
    }
}
