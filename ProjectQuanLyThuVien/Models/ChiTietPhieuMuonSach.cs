namespace ProjectQuanLyThuVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuMuonSach")]
    public partial class ChiTietPhieuMuonSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChiTietPhieuMuonSach()
        {
            PhieuPhats = new HashSet<PhieuPhat>();
            DocGias = new HashSet<DocGia>();
        }

        [Key]
        public int CTPhieuMuon_ID { get; set; }

        [StringLength(10)]
        public string ISBN_ID { get; set; }

        public DateTime? NgayMuon { get; set; }

        public DateTime? NgayTra { get; set; }

        [StringLength(10)]
        public string NhanVien_ID { get; set; }

        [StringLength(10)]
        public string DocGia_ID { get; set; }

        [StringLength(200)]
        public string DocGia_Ten { get; set; }

        [StringLength(100)]
        public string Mail { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string TenSach { get; set; }

        public DateTime? NgayTraThucSu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuPhat> PhieuPhats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocGia> DocGias { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual Sach Sach { get; set; }
    }
}
