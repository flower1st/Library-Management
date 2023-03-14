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
    public partial class ThemTacGia : Form
    {
        clsConnect cls = new clsConnect();
        Model1 themtg = new Model1();
        public ThemTacGia()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát sẽ xóa đi dữ liệu bạn chưa lưu !", "Bạn vẫn muốn thoát ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            TacGia tg = new TacGia();
            try
            {
                if (ValidateData())
                {
                    tg.TacGia_Ten = txtTenTG.Text;
                    tg.Email = txtEmail.Text;
                    tg.SDT = txtSDT.Text;
                    if (txtSDT.Text.Length > 10 || txtSDT.Text.Length < 10)
                    {
                        MessageBox.Show("SĐT không khả thi !", MessageBoxIcon.Warning.ToString());
                    }
                    else
                    {
                        themtg.TacGias.Add(tg);
                        themtg.SaveChanges();
                        MessageBox.Show("Đã lưu dữ liệu !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTenTG.Clear();
                        txtEmail.Clear();
                        txtSDT.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                }
            }
            catch
            {
                MessageBox.Show("Tác giả đã tồn tại !");
            }
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtTenTG.Text))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ThemTacGia_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cls.LoadDataTG();
        }


        private void buttonSua_Click(object sender, EventArgs e)
        {
            int taciga = int.Parse(txtMaTG.Text);
            TacGia tg = themtg.TacGias.FirstOrDefault(s => s.TacGia_ID.CompareTo(taciga) == 0);
            if (tg == null)
            {
                MessageBox.Show("Tác giả không tồn tại !");
            }
            else
            {
                tg.TacGia_Ten =txtTenTG.Text;
                tg.Email = txtEmail.Text;
                tg.SDT = txtSDT.Text;
                if (txtSDT.Text.Length > 10 || txtSDT.Text.Length < 10)
                {
                    MessageBox.Show("SĐT không khả thi !", MessageBoxIcon.Warning.ToString());
                }
                else
                {
                    themtg.SaveChanges();
                    dataGridView1.DataSource = cls.LoadDataTG();
                    MessageBox.Show("Sửa thành công !");
                }
               
            }
        }

        private void txtTenTG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && (e.KeyChar == '.'))
            {
                MessageBox.Show("Chỉ được phép nhập chữ !");
                e.Handled = true;
            }
        }

        private void txtMaTG_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Chỉ được phép nhập số !");
                e.Handled = true;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {
                    txtMaTG.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    txtTenTG.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    txtEmail.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    txtSDT.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cls.LoadDataTG();
        }
    }
}
