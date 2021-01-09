namespace BackEnd.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BienBan")]
    public partial class BienBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BienBan()
        {
            ChiTietBienBans = new HashSet<ChiTietBienBan>();
        }

        [Key]
        public int MaBienBan { get; set; }

        public string CanCu { get; set; }

        [StringLength(12)]
        public string CMND { get; set; }

        public int? NguoiLap { get; set; }

        [Column(TypeName = "money")]
        public decimal? TongTienPhat { get; set; }

        public int? DiemTru { get; set; }

        [StringLength(30)]
        public string TrangThai { get; set; }

        public int? MaGPLX { get; set; }

        public int? MaGD { get; set; }

        public int? MaNguoiDung { get; set; }

        public virtual GiayPhepLaiXe GiayPhepLaiXe { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        public virtual NguoiQuanLy NguoiQuanLy { get; set; }

        public virtual ThanhToan ThanhToan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietBienBan> ChiTietBienBans { get; set; }
    }
}
