namespace ProjectQuanLyThuVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocGia")]
    public partial class DocGia
    {
        [Key]
        [StringLength(10)]
        public string DocGia_ID { get; set; }

        [Required]
        [StringLength(200)]
        public string DocGia_Ten { get; set; }

        public int? CTPhieuMuon_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Mail { get; set; }

        [Required]
        [StringLength(50)]
        public string SDT { get; set; }

        public virtual ChiTietPhieuMuonSach ChiTietPhieuMuonSach { get; set; }
    }
}
