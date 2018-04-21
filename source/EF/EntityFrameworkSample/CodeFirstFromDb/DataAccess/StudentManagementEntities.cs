namespace CodeFirstFromDb.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StudentManagementEntities : DbContext
    {
        public StudentManagementEntities()
            : base("name=StudentManagementEntities")
        {
        }

        public virtual DbSet<Hocsinh> HOCSINHs { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hocsinh>()
                .Property(e => e.MaSo)
                .IsFixedLength();

            modelBuilder.Entity<Hocsinh>()
                .Property(e => e.MaLop)
                .IsFixedLength();

            modelBuilder.Entity<LopHoc>()
                .Property(e => e.MaLop)
                .IsFixedLength();
        }
    }
}
