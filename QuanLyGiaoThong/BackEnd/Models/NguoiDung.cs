namespace BackEnd.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguoiDung()
        {
            BienBans = new HashSet<BienBan>();
            DangKyGPLXes = new HashSet<DangKyGPLX>();
            GiayPhepLaiXes = new HashSet<GiayPhepLaiXe>();
            HoSoDoi_CapLaiGPLX = new HashSet<HoSoDoi_CapLaiGPLX>();
            QuyetDinhXuPhats = new HashSet<QuyetDinhXuPhat>();
            Xes = new HashSet<Xe>();
        }

        [Key]
        public int MaNguoiDung { get; set; }

        [StringLength(30)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(20)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(30)]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaySinh { get; set; }

        [StringLength(3)]
        public string GioiTinh { get; set; }

        [StringLength(100)]
        public string NoiDKHKTT { get; set; }

        [StringLength(12)]
        public string CMND { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapCMND { get; set; }

        [StringLength(30)]
        public string NoiCapCMND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BienBan> BienBans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyGPLX> DangKyGPLXes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiayPhepLaiXe> GiayPhepLaiXes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoSoDoi_CapLaiGPLX> HoSoDoi_CapLaiGPLX { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuyetDinhXuPhat> QuyetDinhXuPhats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Xe> Xes { get; set; }
    }
}
