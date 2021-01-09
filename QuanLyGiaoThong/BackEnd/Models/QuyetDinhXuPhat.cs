namespace BackEnd.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuyetDinhXuPhat")]
    public partial class QuyetDinhXuPhat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuyetDinhXuPhat()
        {
            ChiTietQDXPs = new HashSet<ChiTietQDXP>();
        }

        [Key]
        public int MaQDXP { get; set; }

        [StringLength(12)]
        public string CMND { get; set; }

        public string CanCu { get; set; }

        public string TinhTietTangGiam { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTienPhat { get; set; }

        public int? DiemTru { get; set; }

        [StringLength(30)]
        public string TrangThai { get; set; }

        public int? MaGPLX { get; set; }

        public int? MaNguoiDung { get; set; }

        public int? MaNguoiQuanLy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietQDXP> ChiTietQDXPs { get; set; }

        public virtual GiayPhepLaiXe GiayPhepLaiXe { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        public virtual NguoiQuanLy NguoiQuanLy { get; set; }
    }
}
