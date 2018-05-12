namespace Hrm.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HrmEntities : DbContext
    {
        public HrmEntities()
            : base("name=HrmEntities")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organization>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Organization>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Organization>()
                .Property(e => e.ModifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Organization)
                .WillCascadeOnDelete(false);
        }
    }
}
