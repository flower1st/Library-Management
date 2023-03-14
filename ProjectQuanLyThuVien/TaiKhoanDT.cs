using ProjectQuanLyThuVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQuanLyThuVien
{
    class TaiKhoanDT
    {
        public DangNhap LayTaiKhoan(string tenDangNhap, string matkhau)
        {
            using (var dbContext = new Model1())
            {
                return dbContext.DangNhaps.Where(s => s.TenDangNhap == tenDangNhap && s.MatKhau == matkhau).FirstOrDefault();
            }
        }
    }
}
