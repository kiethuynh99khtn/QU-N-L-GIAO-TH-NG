namespace BackEnd.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DangKyGPLX")]
    public partial class DangKyGPLX
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DangKyGPLX()
        {
            KetQuaSatHaches = new HashSet<KetQuaSatHach>();
        }

        [Key]
        public int MaDangKy { get; set; }

        [StringLength(100)]
        public string NoiCuTru { get; set; }

        [StringLength(100)]
        public string DonViCongTac { get; set; }

        [StringLength(100)]
        public string AnhCaNhan { get; set; }

        [StringLength(100)]
        public string AnhGiayKhamSucKhoe { get; set; }

        [StringLength(100)]
        public string AnhCMND_Hochieu { get; set; }

        [StringLength(50)]
        public string QuocTich { get; set; }

        [StringLength(2)]
        public string Hang { get; set; }

        public int? MaGD { get; set; }

        public int? MaNguoiDung { get; set; }

        public int? MaLopHoc { get; set; }

        public virtual LopHoc LopHoc { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        public virtual ThanhToan ThanhToan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KetQuaSatHach> KetQuaSatHaches { get; set; }
    }
}
