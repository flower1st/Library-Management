namespace ProjectQuanLyThuVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuPhat")]
    public partial class PhieuPhat
    {
        [Key]
        [StringLength(10)]
        public string PhieuPhat_ID { get; set; }

        public int? CTPhieuMuon_ID { get; set; }

        [StringLength(10)]
        public string LuatThuVien_ID { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        public virtual ChiTietPhieuMuonSach ChiTietPhieuMuonSach { get; set; }

        public virtual LuatThuVien LuatThuVien { get; set; }
    }
}
