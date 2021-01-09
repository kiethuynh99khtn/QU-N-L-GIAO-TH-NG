namespace BackEnd.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiayPhepLaiXe")]
    public partial class GiayPhepLaiXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiayPhepLaiXe()
        {
            BienBans = new HashSet<BienBan>();
            HoSoDoi_CapLaiGPLX = new HashSet<HoSoDoi_CapLaiGPLX>();
            QuyetDinhXuPhats = new HashSet<QuyetDinhXuPhat>();
        }

        [Key]
        public int MaGPLX { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapGPLX { get; set; }

        [StringLength(2)]
        public string HangGPLX { get; set; }

        public int? MaNguoiDung { get; set; }

        [StringLength(10)]
        public string ThoiHanSuDung { get; set; }

        [StringLength(100)]
        public string AnhChanDung { get; set; }

        public int? DiemGPLX { get; set; }

        [StringLength(30)]
        public string TrangThai { get; set; }

        public int? NguoiTao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BienBan> BienBans { get; set; }

        public virtual NguoiQuanLy NguoiQuanLy { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoSoDoi_CapLaiGPLX> HoSoDoi_CapLaiGPLX { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuyetDinhXuPhat> QuyetDinhXuPhats { get; set; }
    }
}
