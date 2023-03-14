using ProjectQuanLyThuVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ProjectQuanLyThuVien
{
    public partial class MuonSach : Form
    {
        clsConnect cls = new clsConnect();
        Model1 muonsach = new Model1();
        public MuonSach()
        {
            InitializeComponent();
        }
        private void MuonSach_Load(object sender, EventArgs e)
        {
            List<Sach> listmuonsach = muonsach.Saches.ToList();
            FillDataFromListToComboBox(listmuonsach);
        }

        private void FillDataFromListToComboBox(List<Sach> listmuonsach)
        {
            comboBoxTenSach.DataSource = listmuonsach;
            comboBoxTenSach.DisplayMember = "TenSach";
            comboBoxTenSach.ValueMember = "ISBN_ID";
        }
 
        private void buttonTim_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            if (txtTimDocGia.Text != "")
            {
                ds = cls.LoadDocGiaToDT(txtTimDocGia.Text.Trim());
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMaDG.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtTenDG.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtSDT.Text = ds.Tables[0].Rows[0][4].ToString();
                }
                else
                {
                    txtMaDG.Clear();
                    txtTenDG.Clear();
                    txtEmail.Clear();
                    txtSDT.Clear();
                    MessageBox.Show("Không tìm thấy đọc giả !");
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChiTietPhieuMuonSach ctpm = new ChiTietPhieuMuonSach();
            try
            {
                if (ValidateData())
                {
                    ctpm.DocGia_ID = txtMaDG.Text;
                    ctpm.DocGia_Ten = txtTenDG.Text;
                    ctpm.NgayMuon = DateTime.Parse(dateTimePicker1.Text);
                    ctpm.NgayTra = DateTime.Parse(dateTimePicker2.Text);
                    ctpm.Mail = txtEmail.Text;
                    ctpm.SDT = txtSDT.Text;
                    ctpm.NhanVien_ID = txtThuThu.Text;
                    ctpm.TenSach = comboBoxTenSach.Text;
                    muonsach.ChiTietPhieuMuonSaches.Add(ctpm);
                    muonsach.SaveChanges();                  
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = SUMMERIST\\SQLEXPRESS; database = demoqltv1; integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "update Sach set SoLuongKhaDung = SoLuongKhaDung - 1 where TenSach = N'"+comboBoxTenSach.Text+"'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Đã cho mượn !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaDG.Clear();
                    txtTenDG.Clear();
                    txtEmail.Clear();
                    txtSDT.Clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                }
            }
            catch 
            {
                MessageBox.Show("Sách đã được mượn !");
            }
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtTenDG.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtThuThu.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát sẽ xóa đi dữ liệu bạn chưa lưu !", "Bạn vẫn muốn thoát ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            txtTimDocGia.Clear();
        }

        private void txtTimDocGia_TextChanged(object sender, EventArgs e)
        {
            if(txtTimDocGia.Text=="")
            {
                txtMaDG.Clear();
                txtTenDG.Clear();
                txtEmail.Clear();
                txtSDT.Clear();
            }
        }

        private void comboBoxTenSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }
    }
}
