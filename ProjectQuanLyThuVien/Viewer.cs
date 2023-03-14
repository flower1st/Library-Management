using ProjectQuanLyThuVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQuanLyThuVien
{
    public partial class Viewer : Form
    {
        Model1 docgia = new Model1();
        public Viewer()
        {
            InitializeComponent();
        }
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát chứ ?","Cảnh báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }         
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            textBoxMaDG.Clear();
            textBoxTenDG.Clear();
            textBoxEmail.Clear();
            textBoxSDT.Clear();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {

            DocGia dg = new DocGia();
            try
            {
                if (ValidateData())
                {
                    dg.DocGia_ID = textBoxMaDG.Text;
                    dg.DocGia_Ten = textBoxTenDG.Text;
                    dg.Mail = textBoxEmail.Text;
                    dg.SDT = textBoxSDT.Text;
                    if (textBoxSDT.Text.Length > 10 || textBoxSDT.Text.Length < 10)
                    {
                        MessageBox.Show("SĐT không khả thi !", MessageBoxIcon.Warning.ToString());
                    }
                    docgia.DocGias.Add(dg);
                    docgia.SaveChanges();
                    MessageBox.Show("Đã lưu dữ liệu !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(textBoxMaDG.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxTenDG.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxSDT.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Viewer_Load(object sender, EventArgs e)
        {

        }

        private void textBoxTenDG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)&& !char.IsWhiteSpace(e.KeyChar) || (e.KeyChar == '.'))
            {
                MessageBox.Show("Chỉ được phép nhập chữ !");
                e.Handled = true;
            }
        }

        private void textBoxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Chỉ được phép nhập số !");
                e.Handled = true;
            }
        }
    }
}
