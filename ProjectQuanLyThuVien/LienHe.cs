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
    public partial class LienHe : Form
    {
        public LienHe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void pictureYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCGT-AyjH64IHzkUWAq9e-xg");
        }

        private void pictureFb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Quản-lý-thư-viện-project-528169203980033/?ref=page_internal");
        }

        private void pictureInsta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/littlefreelibrary/");
        }
    }
}
