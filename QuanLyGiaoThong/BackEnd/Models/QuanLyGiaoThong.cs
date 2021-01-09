using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BackEnd.Models
{
    public partial class QuanLyGiaoThong : DbContext
    {
        public QuanLyGiaoThong()
            : base("name=QuanLyGiaoThong")
        {
        }

        public virtual DbSet<BienBan> BienBans { get; set; }
        public virtual DbSet<ChiTietBienBan> ChiTietBienBans { get; set; }
        public virtual DbSet<ChiTietQDXP> ChiTietQDXPs { get; set; }
        public virtual DbSet<DangKyGPLX> DangKyGPLXes { get; set; }
        public virtual DbSet<GiayPhepLaiXe> GiayPhepLaiXes { get; set; }
        public virtual DbSet<HoSoDoi_CapLaiGPLX> HoSoDoi_CapLaiGPLX { get; set; }
        public virtual DbSet<KetQuaSatHach> KetQuaSatHaches { get; set; }
        public virtual DbSet<LoaiXe> LoaiXes { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<LuatGiaoThong> LuatGiaoThongs { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<NguoiQuanLy> NguoiQuanLies { get; set; }
        public virtual DbSet<QuyetDinhXuPhat> QuyetDinhXuPhats { get; set; }
        public virtual DbSet<ThanhToan> ThanhToans { get; set; }
        public virtual DbSet<Xe> Xes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BienBan>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<BienBan>()
                .Property(e => e.TongTienPhat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BienBan>()
                .HasMany(e => e.ChiTietBienBans)
                .WithRequired(e => e.BienBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ChiTietBienBan>()
                .Property(e => e.TienPhat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietQDXP>()
                .Property(e => e.TienPhat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DangKyGPLX>()
                .Property(e => e.AnhCaNhan)
                .IsUnicode(false);

            modelBuilder.Entity<DangKyGPLX>()
                .Property(e => e.AnhGiayKhamSucKhoe)
                .IsUnicode(false);

            modelBuilder.Entity<DangKyGPLX>()
                .Property(e => e.AnhCMND_Hochieu)
                .IsUnicode(false);

            modelBuilder.Entity<DangKyGPLX>()
                .Property(e => e.Hang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GiayPhepLaiXe>()
                .Property(e => e.HangGPLX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GiayPhepLaiXe>()
                .Property(e => e.AnhChanDung)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiXe>()
                .HasMany(e => e.Xes)
                .WithOptional(e => e.LoaiXe1)
                .HasForeignKey(e => e.LoaiXe);

            modelBuilder.Entity<LuatGiaoThong>()
                .HasMany(e => e.ChiTietBienBans)
                .WithRequired(e => e.LuatGiaoThong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LuatGiaoThong>()
                .HasMany(e => e.ChiTietQDXPs)
                .WithRequired(e => e.LuatGiaoThong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .HasMany(e => e.Xes)
                .WithOptional(e => e.NguoiDung)
                .HasForeignKey(e => e.ChuXe);

            modelBuilder.Entity<NguoiQuanLy>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiQuanLy>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiQuanLy>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiQuanLy>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiQuanLy>()
                .HasMany(e => e.BienBans)
                .WithOptional(e => e.NguoiQuanLy)
                .HasForeignKey(e => e.NguoiLap);

            modelBuilder.Entity<NguoiQuanLy>()
                .HasMany(e => e.GiayPhepLaiXes)
                .WithOptional(e => e.NguoiQuanLy)
                .HasForeignKey(e => e.NguoiTao);

            modelBuilder.Entity<NguoiQuanLy>()
                .HasMany(e => e.KetQuaSatHaches)
                .WithOptional(e => e.NguoiQuanLy)
                .HasForeignKey(e => e.NguoiTao);

            modelBuilder.Entity<NguoiQuanLy>()
                .HasMany(e => e.LopHocs)
                .WithOptional(e => e.NguoiQuanLy)
                .HasForeignKey(e => e.NguoiTao);

            modelBuilder.Entity<QuyetDinhXuPhat>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<QuyetDinhXuPhat>()
                .Property(e => e.TongTienPhat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<QuyetDinhXuPhat>()
                .HasMany(e => e.ChiTietQDXPs)
                .WithRequired(e => e.QuyetDinhXuPhat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThanhToan>()
                .Property(e => e.SoTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Xe>()
                .Property(e => e.NhanHieu)
                .IsUnicode(false);

            modelBuilder.Entity<Xe>()
                .Property(e => e.NuocSX)
                .IsUnicode(false);

            modelBuilder.Entity<Xe>()
                .Property(e => e.DungTich)
                .IsUnicode(false);

            modelBuilder.Entity<Xe>()
                .Property(e => e.BienSo)
                .IsUnicode(false);
        }
    }
}
