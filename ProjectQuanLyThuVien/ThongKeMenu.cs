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
    public partial class ThongKeMenu : Form
    {
        clsConnect cls = new clsConnect();
        public ThongKeMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongKeMuonTra tkmt = new ThongKeMuonTra();
            tkmt.Show();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ThongKeMenu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cls.LoadDataReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
