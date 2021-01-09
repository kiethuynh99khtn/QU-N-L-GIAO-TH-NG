namespace BackEnd.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KetQuaSatHach")]
    public partial class KetQuaSatHach
    {
        [Key]
        public int MaKQ { get; set; }

        public int? DiemLT { get; set; }

        public int? DiemTH { get; set; }

        [StringLength(10)]
        public string DanhGiaLT { get; set; }

        [StringLength(10)]
        public string DanhGiaTH { get; set; }

        [Column("KetQuaSatHach")]
        [StringLength(10)]
        public string KetQuaSatHach1 { get; set; }

        public int? MaDangKy { get; set; }

        public int? NguoiTao { get; set; }

        public virtual DangKyGPLX DangKyGPLX { get; set; }

        public virtual NguoiQuanLy NguoiQuanLy { get; set; }
    }
}
