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
    public partial class BangMenu : Form
    {
        public BangMenu()
        {
            InitializeComponent();
        }

        private void xEMĐỌCGIẢToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDocGia xemdg = new XemDocGia();
            xemdg.Show();
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chứ ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tÌMKIẾMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NXB nxb = new NXB();
            nxb.Show();
        }

        private void đỌCGIẢToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tHÊMSÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            ThemSach themsach = new ThemSach();
            themsach.Show();
        }

        private void xEMSÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemSach xemsach = new XemSach();
            xemsach.Show();
        }

        private void tÌMTHEOTÊNSÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NXB timsach = new NXB();
            timsach.Show();
        }

        private void tHÊMĐỌCGIẢToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viewer docgia = new Viewer();
            docgia.Show();
        }

        private void mƯỢNSÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuonSach muonsach = new MuonSach();
            muonsach.Show();
        }

        private void tÁCGIẢToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void tHÊMTÁCGIẢToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTacGia themtacgia = new ThemTacGia();
            themtacgia.Show();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            LuatThuVien ltv = new LuatThuVien();
            ltv.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LienHe lh = new LienHe();
            lh.Show();
        }

        private void tHỐNGKÊToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeMenu tkmenu = new ThongKeMenu();
            tkmenu.Show();
        }

        private void tRẢSÁCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraSach trasach = new TraSach();
            trasach.ShowDialog();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            PhieuPhat pp = new PhieuPhat();
            pp.Show();
        }
    }
}
