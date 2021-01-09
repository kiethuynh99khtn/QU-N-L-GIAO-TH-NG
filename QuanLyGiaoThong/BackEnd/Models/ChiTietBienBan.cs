namespace BackEnd.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietBienBan")]
    public partial class ChiTietBienBan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBienBan { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLuat { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaQDXP { get; set; }

        public int? DiemTru { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienPhat { get; set; }

        public virtual BienBan BienBan { get; set; }

        public virtual LuatGiaoThong LuatGiaoThong { get; set; }
    }
}
