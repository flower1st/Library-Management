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
    public partial class PhieuPhat : Form
    {
        clsConnect cls = new clsConnect();
        Model1 phieuphat = new Model1();
        public PhieuPhat()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhieuPhat_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cls.LoadDataLuat();
            cbxMaLuat.DataSource = cls.LoadDataLuat();
            cbxMaLuat.DisplayMember = "LuatThuVien_ID";
            cbxMaLuat.ValueMember = "LuatThuVien_ID";
        }
        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtMaPM.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMaPP.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            PhieuPhat pp = new PhieuPhat();
            try
            {
                //if (ValidateData())
                //{
                //    pp.Pho
                //    dg.DocGia_ID = textBoxMaDG.Text;
                //    dg.DocGia_Ten = textBoxTenDG.Text;
                //    dg.Mail = textBoxEmail.Text;
                //    dg.SDT = textBoxSDT.Text;
                //    if (textBoxSDT.Text.Length > 11)
                //    {
                //        MessageBox.Show("SĐT không được quá 11 kí tự !", MessageBoxIcon.Warning.ToString());
                //    }
                //    docgia.DocGias.Add(dg);
                //    docgia.SaveChanges();
                //    MessageBox.Show("Đã lưu dữ liệu !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //string mpp = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                //PhieuPhat pp = phieuphat.PhieuPhats.FirstOrDefault(s => s.PhieuPhat_ID.CompareTo(mpp) == 0);
                //xemsach.Saches.Remove(sach);
                //xemsach.SaveChanges();
                //dgvXemSach.DataSource = cls.LoadDataSach();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
