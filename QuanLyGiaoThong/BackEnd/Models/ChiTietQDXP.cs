namespace BackEnd.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietQDXP")]
    public partial class ChiTietQDXP
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaQDXP { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLuat { get; set; }

        public int? DiemTru { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienPhat { get; set; }

        public virtual LuatGiaoThong LuatGiaoThong { get; set; }

        public virtual QuyetDinhXuPhat QuyetDinhXuPhat { get; set; }
    }
}
