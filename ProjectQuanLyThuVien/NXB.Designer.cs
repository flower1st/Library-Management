
namespace ProjectQuanLyThuVien
{
    partial class NXB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NXB));
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.richTextBoxThongTin = new System.Windows.Forms.RichTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSĐT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNXB
            // 
            this.dgvNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvNXB.Location = new System.Drawing.Point(3, 158);
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.Size = new System.Drawing.Size(1206, 237);
            this.dgvNXB.TabIndex = 8;
            this.dgvNXB.SelectionChanged += new System.EventHandler(this.dgvNXB_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NhaXuatBan_ID";
            this.Column1.HeaderText = "Mã NXB";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NhaXuatBan_Ten";
            this.Column2.HeaderText = "Tên NXB";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ThongTin";
            this.Column3.HeaderText = "Thông Tin";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Mail";
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SDT";
            this.Column5.HeaderText = "SĐT";
            this.Column5.Name = "Column5";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 158);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "NHÀ XUẤT BẢN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(418, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OliveDrab;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtMaNXB);
            this.panel2.Controls.Add(this.richTextBoxThongTin);
            this.panel2.Controls.Add(this.txtMail);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSĐT);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTenNXB);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1206, 258);
            this.panel2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 55;
            this.label5.Text = "Mã NXB: ";
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Enabled = false;
            this.txtMaNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNXB.Location = new System.Drawing.Point(108, 37);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.ReadOnly = true;
            this.txtMaNXB.Size = new System.Drawing.Size(241, 29);
            this.txtMaNXB.TabIndex = 54;
            // 
            // richTextBoxThongTin
            // 
            this.richTextBoxThongTin.Location = new System.Drawing.Point(508, 24);
            this.richTextBoxThongTin.Name = "richTextBoxThongTin";
            this.richTextBoxThongTin.Size = new System.Drawing.Size(478, 147);
            this.richTextBoxThongTin.TabIndex = 53;
            this.richTextBoxThongTin.Text = "";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(108, 219);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(384, 29);
            this.txtMail.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 51;
            this.label4.Text = "Email:";
            // 
            // txtSĐT
            // 
            this.txtSĐT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSĐT.Location = new System.Drawing.Point(108, 159);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.Size = new System.Drawing.Size(280, 29);
            this.txtSĐT.TabIndex = 50;
            this.txtSĐT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSĐT_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 49;
            this.label3.Text = "SĐT: ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 47;
            this.label1.Text = "Thông tin: ";
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNXB.Location = new System.Drawing.Point(108, 98);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(384, 29);
            this.txtTenNXB.TabIndex = 31;
            this.txtTenNXB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenNXB_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 22);
            this.label10.TabIndex = 30;
            this.label10.Text = "Tên NXB: ";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(992, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 45);
            this.button1.TabIndex = 46;
            this.button1.Text = "THÊM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(992, 126);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 45);
            this.btnThoat.TabIndex = 45;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(992, 75);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(99, 45);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // NXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 659);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvNXB);
            this.Name = "NXB";
            this.Text = "NXB";
            this.Load += new System.EventHandler(this.NXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNXB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSĐT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBoxThongTin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNXB;
    }
}