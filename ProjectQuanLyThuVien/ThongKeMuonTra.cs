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
    public partial class ThongKeMuonTra : Form
    {
        public ThongKeMuonTra()
        {
            InitializeComponent();
        }

        private void ThongKeMuonTra_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ThongKeSachMuonTra.ThongKeSachMuonTra' table. You can move, or remove it, as needed.
            this.ThongKeSachMuonTraTableAdapter.Fill(this.ThongKeSachMuonTra._ThongKeSachMuonTra);

            this.reportViewer1.RefreshReport();
        }
    }
}
