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
    public partial class TraSach : Form
    {
        clsConnect cls = new clsConnect();
        public TraSach()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            if (txtDocGia.Text != "")
            {
                ds = cls.LoadDocGiaToTraSach(txtDocGia.Text.Trim());
                if (ds.Tables[0].Rows.Count != 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đọc giả hoặc đọc giả không có sách cần trả !");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã đọc giả muốn trả sách !");
            }
        }
        String ten;
        String ngaymuon;
        int id;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            if(dateTimePicker2.Value < DateTime.Now)
            {
                MessageBox.Show("Ngày trả không khả thi !!");
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = SUMMERIST\\SQLEXPRESS; database = demoqltv1; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "update ChiTietPhieuMuonSach set NgayTraThucSu='" +DateTime.Parse(dateTimePicker2.Text)+ "' where DocGia_ID = '" +txtDocGia.Text+ "' and TenSach ='" + txtTenSach.Text + "'";
                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con;
                cmd1.CommandText = "update Sach set SoLuongKhaDung = SoLuongKhaDung + 1 where TenSach = N'" + txtTenSach.Text + "'";
                cmd1.ExecuteNonQuery();
                con.Close();
                
                MessageBox.Show("Trả sách thành công !");
            }
      
        }

        private void txtDocGia_TextChanged(object sender, EventArgs e)
        {
            //if(txtDocGia.Text =="")
            //{
            //    panel1.Visible = false;
            //    dataGridView1.DataSource = null;
            //}
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
           
        }
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chứ ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TraSach_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {
                    txtTenSach.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    txtNgayMuon.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                }
            }
        }
    }
}
