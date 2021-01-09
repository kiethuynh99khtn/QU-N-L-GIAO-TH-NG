namespace BackEnd.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LuatGiaoThong")]
    public partial class LuatGiaoThong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LuatGiaoThong()
        {
            ChiTietBienBans = new HashSet<ChiTietBienBan>();
            ChiTietQDXPs = new HashSet<ChiTietQDXP>();
        }

        [Key]
        public int MaLuat { get; set; }

        [StringLength(100)]
        public string TenDieuLuat { get; set; }

        public string NoiDung { get; set; }

        [StringLength(50)]
        public string MucPhat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietBienBan> ChiTietBienBans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietQDXP> ChiTietQDXPs { get; set; }
    }
}
