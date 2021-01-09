namespace BackEnd.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LopHoc")]
    public partial class LopHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LopHoc()
        {
            DangKyGPLXes = new HashSet<DangKyGPLX>();
        }

        [Key]
        public int MaLopHoc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHoc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThiSatHach { get; set; }

        [StringLength(30)]
        public string NguoiHuongDan { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(10)]
        public string LoaiLop { get; set; }

        public int? NguoiTao { get; set; }

        public int? MaDangKy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyGPLX> DangKyGPLXes { get; set; }

        public virtual NguoiQuanLy NguoiQuanLy { get; set; }
    }
}
