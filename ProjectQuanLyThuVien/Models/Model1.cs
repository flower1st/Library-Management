using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProjectQuanLyThuVien.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model4")
        {
        }

        public virtual DbSet<ChiTietPhieuMuonSach> ChiTietPhieuMuonSaches { get; set; }
        public virtual DbSet<ChiTietTheLoai> ChiTietTheLoais { get; set; }
        public virtual DbSet<DangNhap> DangNhaps { get; set; }
        public virtual DbSet<DocGia> DocGias { get; set; }
        public virtual DbSet<LuatThuVien> LuatThuViens { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public virtual DbSet<PhieuPhat> PhieuPhats { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TacGia> TacGias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietPhieuMuonSach>()
                .Property(e => e.ISBN_ID)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuMuonSach>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietPhieuMuonSach>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietTheLoai>()
                .HasMany(e => e.Saches)
                .WithRequired(e => e.ChiTietTheLoai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Admin_YN)
                .IsFixedLength();

            modelBuilder.Entity<NhaXuatBan>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhaXuatBan>()
                .HasMany(e => e.Saches)
                .WithRequired(e => e.NhaXuatBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.ISBN_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TacGia>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TacGia>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<TacGia>()
                .HasMany(e => e.Saches)
                .WithRequired(e => e.TacGia)
                .WillCascadeOnDelete(false);
        }
    }
}
