namespace BackEnd.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HoSoDoi_CapLaiGPLX
    {
        [Key]
        public int MaHoSo { get; set; }

        [StringLength(50)]
        public string LyDo { get; set; }

        [StringLength(50)]
        public string HinhThucNhanGPLX { get; set; }

        [StringLength(50)]
        public string TinhTrang { get; set; }

        public int? MaNguoiDung { get; set; }

        public int? MaGPLX { get; set; }

        public int? MaGD { get; set; }

        public virtual GiayPhepLaiXe GiayPhepLaiXe { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        public virtual ThanhToan ThanhToan { get; set; }
    }
}
