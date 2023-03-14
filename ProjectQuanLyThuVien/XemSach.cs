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
    public partial class XemSach : Form
    {

        clsConnect cls = new clsConnect();
        Model1 xemsach = new Model1();
        public XemSach()
        {
            InitializeComponent();
        }

        private void XemSach_Load(object sender, EventArgs e)
        {
            dgvXemSach.DataSource = cls.LoadDataSach();
            List<ChiTietTheLoai> listtheloai = xemsach.ChiTietTheLoais.ToList();
            FillDataFromListToComboBox(listtheloai);
            List<NhaXuatBan> listnxb = xemsach.NhaXuatBans.ToList();
            FillDataFromListToComboBox(listnxb);
            List<TacGia> listtg = xemsach.TacGias.ToList();
            FillDataFromListToComboBox(listtg);
        }

        private void FillDataFromListToComboBox(List<NhaXuatBan> listnxb)
        {
            cbxNXB.DataSource = listnxb;
            cbxNXB.DisplayMember = "NhaXuatBan_Ten";
            cbxNXB.ValueMember = "NhaXuatBan_ID";
        }

        private void FillDataFromListToComboBox(List<TacGia> listtg)
        {
            cbxTacGia.DataSource = listtg;
            cbxTacGia.DisplayMember = "TacGia_Ten";
            cbxTacGia.ValueMember = "TacGia_ID";
        }

        private void FillDataFromListToComboBox(List<ChiTietTheLoai> listtheloai)
        {
            cbxTheLoai.DataSource = listtheloai;
            cbxTheLoai.DisplayMember = "TheLoai_Ten";
            cbxTheLoai.ValueMember = "TheLoai_ID";
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string MS = txtMaSach.Text;
            Sach sach = xemsach.Saches.FirstOrDefault(s => s.ISBN_ID.CompareTo(MS) == 0);
            if (sach == null)
            {
                MessageBox.Show("Sách không tồn tại !");
            }
            else
            {
                sach.TenSach = txtTenSach.Text;
                sach.NgayNhapSach = DateTime.Parse(dateTimePicker2.Text);
                sach.SoLuongKhaDung = int.Parse(txtSoLuong.Text);
                sach.SoLuong = int.Parse(txtSoLuong.Text);
                sach.TheLoai_ID = int.Parse(cbxTheLoai.SelectedValue.ToString());
                sach.NhaXuatBan_ID = int.Parse(cbxNXB.SelectedValue.ToString());
                sach.TacGia_ID = int.Parse(cbxTacGia.SelectedValue.ToString());
                sach.NamPhatHanh = int.Parse(txtNamPH.Text);
                sach.Gia = float.Parse(txtGia.Text);
                xemsach.SaveChanges();
                dgvXemSach.DataSource = cls.LoadDataSach();
                MessageBox.Show("Sửa thành công !");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dgvXemSach.SelectedRows.Count > 0)
            {
                string MS = dgvXemSach.SelectedRows[0].Cells[0].Value.ToString();
                NhaXuatBan nxb = new NhaXuatBan();
                Sach sach = xemsach.Saches.FirstOrDefault(s => s.ISBN_ID.CompareTo(MS) == 0);
                xemsach.Saches.Remove(sach);
                xemsach.SaveChanges();
                dgvXemSach.DataSource = cls.LoadDataSach();
            }
        }

        private void dgvXemSach_SelectionChanged(object sender, EventArgs e)
        {
            dgvXemSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dgvXemSach.SelectedRows.Count > 0)
            {
                if (dgvXemSach.SelectedRows[0].Cells[0].Value != null)
                {
                    txtMaSach.Text = dgvXemSach.SelectedRows[0].Cells[0].Value.ToString();
                    txtTenSach.Text = dgvXemSach.SelectedRows[0].Cells[1].Value.ToString();
                    txtSoLuong.Text = dgvXemSach.SelectedRows[0].Cells[2].Value.ToString();
                    cbxTacGia.Text = dgvXemSach.SelectedRows[0].Cells[4].Value.ToString();
                    cbxTheLoai.SelectedIndex = cbxTheLoai.FindStringExact(dgvXemSach.SelectedRows[0].Cells[3].Value.ToString());
                    cbxNXB.SelectedIndex = cbxNXB.FindStringExact(dgvXemSach.SelectedRows[0].Cells[5].Value.ToString());
                    dateTimePicker2.Text = dgvXemSach.SelectedRows[0].Cells[6].Value.ToString();
                    txtNamPH.Text = dgvXemSach.SelectedRows[0].Cells[7].Value.ToString();
                    txtGia.Text = dgvXemSach.SelectedRows[0].Cells[8].Value.ToString();
                }
            }
        }
        DataTable dt;
        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (textTimKiem.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                dt = new DataTable();
                dt = cls.TimKiemTheoTen(textTimKiem.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    dgvXemSach.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Bạn tìm sách " + textTimKiem.Text + " không có trong dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    XemSach_Load(null, null);
                    textTimKiem.Text = "";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvXemSach.DataSource = cls.LoadDataSach();
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Chỉ được phép nhập số !");
                e.Handled = true;
            }
        }

        private void txtNamPH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Chỉ được phép nhập số !");
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Chỉ được phép nhập số !");
                e.Handled = true;
            }
        }

        private void cbxTheLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void cbxNXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void cbxTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }
    }
}
