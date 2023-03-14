namespace ProjectQuanLyThuVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            ChiTietPhieuMuonSaches = new HashSet<ChiTietPhieuMuonSach>();
        }

        [Key]
        [StringLength(10)]
        public string NhanVien_ID { get; set; }

        [StringLength(200)]
        public string NhanVien_Ten { get; set; }

        [StringLength(50)]
        public string VaiTro { get; set; }

        [MaxLength(1)]
        public byte[] Admin_YN { get; set; }

        [StringLength(100)]
        public string Mail { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuMuonSach> ChiTietPhieuMuonSaches { get; set; }
    }
}
