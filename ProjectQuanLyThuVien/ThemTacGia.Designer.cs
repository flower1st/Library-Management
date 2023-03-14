
namespace ProjectQuanLyThuVien
{
    partial class ThemTacGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemTacGia));
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenTG
            // 
            this.txtTenTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTG.Location = new System.Drawing.Point(118, 243);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(240, 24);
            this.txtTenTG.TabIndex = 22;
            this.txtTenTG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenTG_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên tác giả: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 146);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 39);
            this.label4.TabIndex = 2;
            this.label4.Text = "THÊM TÁC GIẢ ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(118, 309);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 24);
            this.txtEmail.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Email:";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(118, 372);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(240, 24);
            this.txtSDT.TabIndex = 27;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "SĐT: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(380, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 467);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TacGia_ID";
            this.Column1.HeaderText = "Mã tác giả";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TacGia_Ten";
            this.Column2.HeaderText = "Tên tác giả";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Email";
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SDT";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.Name = "Column4";
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(118, 488);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(100, 37);
            this.buttonThem.TabIndex = 31;
            this.buttonThem.Text = "THÊM";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(258, 488);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(100, 37);
            this.buttonSua.TabIndex = 32;
            this.buttonSua.Text = "SỬA";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.SlateGray;
            this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(258, 583);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(100, 37);
            this.buttonThoat.TabIndex = 34;
            this.buttonThoat.Text = "THOÁT";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // txtMaTG
            // 
            this.txtMaTG.Enabled = false;
            this.txtMaTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTG.Location = new System.Drawing.Point(118, 178);
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.ReadOnly = true;
            this.txtMaTG.Size = new System.Drawing.Size(240, 24);
            this.txtMaTG.TabIndex = 36;
            this.txtMaTG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaTG_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Mã tác giả: ";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.SlateBlue;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(118, 420);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 37);
            this.btnLoad.TabIndex = 37;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // ThemTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(941, 632);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtMaTG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTenTG);
            this.Controls.Add(this.label2);
            this.Name = "ThemTacGia";
            this.Text = "ThemTacGia";
            this.Load += new System.EventHandler(this.ThemTacGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtMaTG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLoad;
    }
}