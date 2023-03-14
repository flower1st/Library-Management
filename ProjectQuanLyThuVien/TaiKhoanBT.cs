using ProjectQuanLyThuVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQuanLyThuVien
{
    class TaiKhoanBT
    {
        private readonly TaiKhoanDT taiKhoanDT;
        public TaiKhoanBT()
        {
            taiKhoanDT = new TaiKhoanDT();
        }
        public DangNhap LayTaiKhoan(string tenDangNhap, string matKhau)
        {
            matKhau = Helpers.MaHoaMD5(matKhau);
            return taiKhoanDT.LayTaiKhoan(tenDangNhap, matKhau);
        }
    }
}
