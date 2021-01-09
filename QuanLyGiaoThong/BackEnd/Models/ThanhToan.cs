namespace BackEnd.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhToan")]
    public partial class ThanhToan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThanhToan()
        {
            BienBans = new HashSet<BienBan>();
            DangKyGPLXes = new HashSet<DangKyGPLX>();
            HoSoDoi_CapLaiGPLX = new HashSet<HoSoDoi_CapLaiGPLX>();
            Xes = new HashSet<Xe>();
        }

        [Key]
        public int MaGD { get; set; }

        [StringLength(50)]
        public string NoiDungTT { get; set; }

        [Column(TypeName = "money")]
        public decimal? SoTien { get; set; }

        [StringLength(50)]
        public string HinhThucTT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BienBan> BienBans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyGPLX> DangKyGPLXes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoSoDoi_CapLaiGPLX> HoSoDoi_CapLaiGPLX { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Xe> Xes { get; set; }
    }
}
