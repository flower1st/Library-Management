using ProjectQuanLyThuVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanLyThuVien
{
    public partial class Login : Form
    {
        private TaiKhoanBT taiKhoanBT;
        public Login()
        {
            InitializeComponent();
            taiKhoanBT = new TaiKhoanBT();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textUsername_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void textUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (textUsername.Text == "Username")
            {
                textUsername.Clear();
            }
        }

        private void textPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (textPassword.Text == "Password")
            {
                textPassword.Clear();
            }
        }

        private void buttonDNhap_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản !");
                return;
            }
            if (string.IsNullOrEmpty(textPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu !");
                return;
            }
            string tenDangNhap = textUsername.Text;
            string matKhau = textPassword.Text;
            DangNhap taikhoan = taiKhoanBT.LayTaiKhoan(tenDangNhap, matKhau);
            if (taikhoan != null)
            {
                MessageBox.Show("Đăng nhập thành công !");
                this.Visible = false;
                BangMenu menu = new BangMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại !");
            }
        }
    }
}
