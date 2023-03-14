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
    public partial class LuatThuVien : Form
    {
        clsConnect cls = new clsConnect();
        
        public LuatThuVien()
        {
            InitializeComponent();
        }

        private void LuatThuVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cls.LoadDataLuat();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {
                    richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                }
            }
        }
    }
}
