namespace BackEnd.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xe")]
    public partial class Xe
    {
        [Key]
        public int MaXe { get; set; }

        [StringLength(20)]
        public string NhanHieu { get; set; }

        [StringLength(50)]
        public string NuocSX { get; set; }

        public int? NamSX { get; set; }

        [StringLength(10)]
        public string DungTich { get; set; }

        public int? LoaiXe { get; set; }

        [StringLength(20)]
        public string BienSo { get; set; }

        public int? MaGD { get; set; }

        public int? ChuXe { get; set; }

        public virtual LoaiXe LoaiXe1 { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        public virtual ThanhToan ThanhToan { get; set; }
    }
}
