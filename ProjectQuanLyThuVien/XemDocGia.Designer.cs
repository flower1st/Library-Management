
namespace ProjectQuanLyThuVien
{
    partial class XemDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemDocGia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.textBoxTim);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.Salmon;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTim.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(880, 67);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(73, 28);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTim
            // 
            this.textBoxTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTim.Location = new System.Drawing.Point(619, 67);
            this.textBoxTim.Name = "textBoxTim";
            this.textBoxTim.Size = new System.Drawing.Size(255, 26);
            this.textBoxTim.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xem Đọc Giả";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(399, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDocGia.Location = new System.Drawing.Point(0, 107);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.Size = new System.Drawing.Size(1143, 304);
            this.dgvDocGia.TabIndex = 1;
            this.dgvDocGia.SelectionChanged += new System.EventHandler(this.dgvDocGia_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DocGia_ID";
            this.Column1.HeaderText = "Mã đọc giả";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DocGia_Ten";
            this.Column2.HeaderText = "Tên đọc giả";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CTPhieuMuon_ID";
            this.Column3.HeaderText = "Mã phiếu mượn";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Mail";
            this.Column4.HeaderText = "Địa chỉ email";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SDT";
            this.Column5.HeaderText = "Số điện thoại ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.buttonThoat);
            this.panel2.Controls.Add(this.buttonXoa);
            this.panel2.Controls.Add(this.buttonSua);
            this.panel2.Controls.Add(this.txtSDT);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtTenDG);
            this.panel2.Controls.Add(this.txtMaDG);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 232);
            this.panel2.TabIndex = 2;
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.IndianRed;
            this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThoat.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(415, 156);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(95, 40);
            this.buttonThoat.TabIndex = 10;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.IndianRed;
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonXoa.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(281, 156);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(95, 40);
            this.buttonXoa.TabIndex = 9;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.IndianRed;
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSua.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(155, 156);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(95, 40);
            this.buttonSua.TabIndex = 8;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(589, 81);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(241, 26);
            this.txtSDT.TabIndex = 7;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(589, 21);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // txtTenDG
            // 
            this.txtTenDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDG.Location = new System.Drawing.Point(155, 81);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(272, 26);
            this.txtTenDG.TabIndex = 5;
            this.txtTenDG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDG_KeyPress);
            // 
            // txtMaDG
            // 
            this.txtMaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDG.Location = new System.Drawing.Point(155, 21);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.ReadOnly = true;
            this.txtMaDG.Size = new System.Drawing.Size(221, 26);
            this.txtMaDG.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(463, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(517, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đọc giả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đọc giả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(518, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên đọc giả:";
            // 
            // XemDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1143, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvDocGia);
            this.Controls.Add(this.panel1);
            this.Name = "XemDocGia";
            this.Text = "XemDocGia";
            this.Load += new System.EventHandler(this.XemDocGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox textBoxTim;
        private System.Windows.Forms.Label label6;
    }
}