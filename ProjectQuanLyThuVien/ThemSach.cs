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
    public partial class ThemSach : Form
    {
        clsConnect cls = new clsConnect();
        Model1 themsach = new Model1();
        public ThemSach()
        {
            
            InitializeComponent();
        }

        private void ThemSach_Load(object sender, EventArgs e)
        {
            cbxTheLoai.DataSource = cls.LoadTheLoai();
            cbxTheLoai.DisplayMember = "TheLoai_Ten";
            cbxTheLoai.ValueMember = "TheLoai_ID";
            List<TacGia> listtacgia = themsach.TacGias.ToList();
            FillDataFromListToComboBox(listtacgia);
            List<NhaXuatBan> listnxb = themsach.NhaXuatBans.ToList();
            FillDataFromListToComboBox(listnxb);
        }

        private void FillDataFromListToComboBox(List<NhaXuatBan> listnxb)
        {
            cbxNXB.DataSource = listnxb;
            cbxNXB.DisplayMember = "NhaXuatBan_Ten";
            cbxNXB.ValueMember = "NhaXuatBan_ID";
        }

        private void FillDataFromListToComboBox(List<TacGia> listtacgia)
        {
            cbxTacGia.DataSource = listtacgia;
            cbxTacGia.DisplayMember = "TacGia_Ten";
            cbxTacGia.ValueMember = "TacGia_ID";
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            NhaXuatBan nxb = new NhaXuatBan();
            TacGia tg = new TacGia();
            try
            {
                if (ValidateData())
                {
                    sach.ISBN_ID = txtMaSach.Text;
                    sach.TenSach = txtTenSach.Text;
                    sach.NgayNhapSach = DateTime.Parse(dateTimePicker1.Text);
                    if (dateTimePicker1.Value.Year < int.Parse(txtNamPH.Text))
                    {
                        MessageBox.Show("Ngày mua không được nhỏ hơn năm PH !");
                    }
                    else
                    {
                        if (int.Parse(txtSoLuong.Text) > 500)
                        {
                            MessageBox.Show("Số lượng nhập không quá 500 !");
                        }
                        else
                        {
                            sach.SoLuong = int.Parse(txtSoLuong.Text);
                            sach.SoLuongKhaDung = int.Parse(txtSoLuong.Text);
                            sach.NhaXuatBan_ID = int.Parse(cbxNXB.SelectedValue.ToString());
                            sach.TacGia_ID = int.Parse(cbxTacGia.SelectedValue.ToString());
                            sach.TheLoai_ID = int.Parse(cbxTheLoai.SelectedValue.ToString());
                            sach.NamPhatHanh = int.Parse(txtNamPH.Text);
                            sach.Gia = float.Parse(txtGia.Text);
                            themsach.TacGias.Add(tg);
                            themsach.NhaXuatBans.Add(nxb);
                            themsach.Saches.Add(sach);
                            themsach.SaveChanges();
                            MessageBox.Show("Đã lưu dữ liệu !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtMaSach.Clear();
                            txtTenSach.Clear();
                            txtSoLuong.Clear();
                            txtNamPH.Clear();
                            txtGia.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                }
            }
            catch
            {
                MessageBox.Show("Sách đã tồn tại !");
            }
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Thoát sẽ xóa đi dữ liệu bạn chưa lưu !", "Bạn vẫn muốn thoát ?",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
           
        }
        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTenSach.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNamPH.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGia.Text))
            {
                return false;
            }
            else
            {
                float gia;
                if (float.TryParse(txtGia.Text, out gia))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void cbxNXB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
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

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
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
