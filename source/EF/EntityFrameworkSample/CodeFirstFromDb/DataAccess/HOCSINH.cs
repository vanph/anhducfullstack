namespace CodeFirstFromDb.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOCSINH")]
    public partial class Hocsinh
    {
        [Key]
        [StringLength(10)]
        public string MaSo { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(10)]
        public string MaLop { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        public virtual LopHoc LopHoc { get; set; }
    }
}
