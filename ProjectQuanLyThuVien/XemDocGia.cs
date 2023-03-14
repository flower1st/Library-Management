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
    public partial class XemDocGia : Form
    {
        clsConnect cls = new clsConnect();
        Model1 xemdocgia = new Model1();
        DataTable dt;
        public XemDocGia()
        {
            InitializeComponent();
        }
        private void XemDocGia_Load(object sender, EventArgs e)
        {
            dgvDocGia.DataSource = cls.LoadDocGia();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn muốn thoát chứ ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            string mdg = txtMaDG.Text;
            DocGia docgia = xemdocgia.DocGias.FirstOrDefault(s => s.DocGia_ID.CompareTo(mdg) == 0);
            if (docgia == null)
            {
                MessageBox.Show("Đọc giả không tồn tại !");
            }
            else
            {
                docgia.DocGia_Ten = txtTenDG.Text;
                docgia.Mail = txtEmail.Text;
                docgia.SDT = txtSDT.Text;
                if (txtSDT.Text.Length > 10 || txtSDT.Text.Length < 10)
                {
                    MessageBox.Show("SĐT không được ít hơn hoặc quá 11 kí tự !", MessageBoxIcon.Warning.ToString());
                }
                xemdocgia.SaveChanges();
                dgvDocGia.DataSource = cls.LoadDocGia();
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dgvDocGia.SelectedRows.Count > 0)
            {
                string mdg = dgvDocGia.SelectedRows[0].Cells[0].Value.ToString();
                DocGia docgia = xemdocgia.DocGias.FirstOrDefault(s => s.DocGia_ID.CompareTo(mdg) == 0);
                xemdocgia.DocGias.Remove(docgia);
                xemdocgia.SaveChanges();
                dgvDocGia.DataSource = cls.LoadDocGia();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxTim.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                dt = new DataTable();
                dt = cls.TimKiemTenDocGia(textBoxTim.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    dgvDocGia.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Bạn tìm tên đọc giả " + textBoxTim.Text + " không có trong dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    XemDocGia_Load(null, null);
                    textBoxTim.Text = "";
                }
            }
        }

        private void dgvDocGia_SelectionChanged(object sender, EventArgs e)
        {
            dgvDocGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dgvDocGia.SelectedRows.Count > 0)
            {
                if (dgvDocGia.SelectedRows[0].Cells[0].Value != null)
                {
                    txtMaDG.Text = dgvDocGia.SelectedRows[0].Cells[0].Value.ToString();
                    txtTenDG.Text = dgvDocGia.SelectedRows[0].Cells[1].Value.ToString();
                    txtEmail.Text = dgvDocGia.SelectedRows[0].Cells[3].Value.ToString();
                    txtSDT.Text = dgvDocGia.SelectedRows[0].Cells[4].Value.ToString();

                }
            }
        }

        private void txtTenDG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)&& (e.KeyChar == '.'))
            {
                MessageBox.Show("Chỉ được phép nhập chữ !");
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Chỉ được phép nhập số !");
                e.Handled = true;
            }
        }
    }
}
