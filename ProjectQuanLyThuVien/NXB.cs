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
    public partial class NXB : Form
    {
        clsConnect cls = new clsConnect();
        Model1 nhaxb = new Model1();
        public NXB()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                NhaXuatBan nxb = new NhaXuatBan();
                nxb.NhaXuatBan_Ten = txtTenNXB.Text;
                nxb.ThongTin = richTextBoxThongTin.Text;
                nxb.Mail = txtMail.Text;
                nxb.SDT = txtSĐT.Text;
                if(txtSĐT.Text.Length > 11 || txtSĐT.Text.Length < 11)
                {
                    MessageBox.Show("Số điện thoại không khả dụng !");
                }
                else
                {
                    nhaxb.NhaXuatBans.Add(nxb);
                    nhaxb.SaveChanges();
                    FillDataToDataGridView(nhaxb.NhaXuatBans.ToList());
                    MessageBox.Show("Thêm thành công !");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        private void FillDataToDataGridView(List<NhaXuatBan> nhaXuatBans)
        {
            dgvNXB.Rows.Clear();
            for (int i = 0; i < nhaXuatBans.Count; i++)
            {
                int index = dgvNXB.Rows.Add();
                dgvNXB.Rows[index].Cells[0].Value = nhaXuatBans[i].NhaXuatBan_ID;
                dgvNXB.Rows[index].Cells[1].Value = nhaXuatBans[i].NhaXuatBan_Ten;
                dgvNXB.Rows[index].Cells[2].Value = nhaXuatBans[i].ThongTin;
                dgvNXB.Rows[index].Cells[3].Value = nhaXuatBans[i].Mail;
                dgvNXB.Rows[index].Cells[4].Value = nhaXuatBans[i].SDT;
            }
        }
        private void NXB_Load(object sender, EventArgs e)
        {
            List<NhaXuatBan> nhaXuatBans =nhaxb.NhaXuatBans.ToList();
            FillDataToDataGridView(nhaXuatBans);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int mnxb = int.Parse(txtMaNXB.Text);
            NhaXuatBan nxb = nhaxb.NhaXuatBans.FirstOrDefault(s => s.NhaXuatBan_ID.CompareTo(mnxb) == 0);
            if (nxb == null)
            {
                MessageBox.Show("Nhà xuất bản không tồn tại !");
            }
            else
            {
                nxb.NhaXuatBan_Ten = txtTenNXB.Text;
                nxb.ThongTin = richTextBoxThongTin.Text;
                nxb.Mail = txtMail.Text;
                nxb.SDT = txtSĐT.Text;
                nhaxb.SaveChanges();
                FillDataToDataGridView(nhaxb.NhaXuatBans.ToList());
                MessageBox.Show("Sửa thành công !");
            }
        }

        private void dgvNXB_SelectionChanged(object sender, EventArgs e)
        {
            dgvNXB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dgvNXB.SelectedRows.Count > 0)
            {
                if (dgvNXB.SelectedRows[0].Cells[0].Value != null)
                {
                    txtMaNXB.Text = dgvNXB.SelectedRows[0].Cells[0].Value.ToString();
                    txtTenNXB.Text = dgvNXB.SelectedRows[0].Cells[1].Value.ToString();
                    richTextBoxThongTin.Text = dgvNXB.SelectedRows[0].Cells[2].Value.ToString();
                    txtMail.Text = dgvNXB.SelectedRows[0].Cells[3].Value.ToString();
                    txtSĐT.Text = dgvNXB.SelectedRows[0].Cells[4].Value.ToString();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenNXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && (e.KeyChar == '.'))
            {
                MessageBox.Show("Chỉ được phép nhập chữ !");
                e.Handled = true;
            }
        }

        private void txtSĐT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Chỉ được phép nhập số !");
                e.Handled = true;
            }
        }
    }
}
