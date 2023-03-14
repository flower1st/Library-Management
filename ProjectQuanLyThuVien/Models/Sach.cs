namespace ProjectQuanLyThuVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            ChiTietPhieuMuonSaches = new HashSet<ChiTietPhieuMuonSach>();
        }

        [Key]
        [StringLength(10)]
        public string ISBN_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string TenSach { get; set; }

        public int SoLuong { get; set; }

        public int TacGia_ID { get; set; }

        public int TheLoai_ID { get; set; }

        public int NhaXuatBan_ID { get; set; }

        public DateTime? NgayNhapSach { get; set; }

        public int? NamPhatHanh { get; set; }

        public double? Gia { get; set; }

        public int? SoLuongKhaDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuMuonSach> ChiTietPhieuMuonSaches { get; set; }

        public virtual ChiTietTheLoai ChiTietTheLoai { get; set; }

        public virtual NhaXuatBan NhaXuatBan { get; set; }

        public virtual TacGia TacGia { get; set; }
    }
}
