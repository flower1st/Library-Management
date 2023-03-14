namespace ProjectQuanLyThuVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DangNhap")]
    public partial class DangNhap
    {
        [Key]
        public int MaTaiKhoan { get; set; }

        [Required]
        [StringLength(100)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(250)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(100)]
        public string TenHienThi { get; set; }
    }
}
