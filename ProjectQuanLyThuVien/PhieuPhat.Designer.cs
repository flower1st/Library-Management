
namespace ProjectQuanLyThuVien
{
    partial class PhieuPhat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuPhat));
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxMaLuat = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Firebrick;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(686, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 539);
            this.panel3.TabIndex = 3;
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThoat.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(424, 104);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(133, 39);
            this.buttonThoat.TabIndex = 6;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(65, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(299, 286);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 235);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PhieuPhat_ID";
            this.Column1.HeaderText = "Mã Phiếu Phạt";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CTPhieuMuon_ID";
            this.Column2.HeaderText = "Mã phiếu mượn";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LuatThuVien_ID";
            this.Column3.HeaderText = "Mã Luật";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GhiChu";
            this.Column4.HeaderText = "Ghi chú";
            this.Column4.Name = "Column4";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.buttonThoat);
            this.panel1.Controls.Add(this.cbxMaLuat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnGhi);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaPM);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaPP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 286);
            this.panel1.TabIndex = 5;
            // 
            // cbxMaLuat
            // 
            this.cbxMaLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaLuat.FormattingEnabled = true;
            this.cbxMaLuat.Location = new System.Drawing.Point(168, 119);
            this.cbxMaLuat.Name = "cbxMaLuat";
            this.cbxMaLuat.Size = new System.Drawing.Size(121, 33);
            this.cbxMaLuat.TabIndex = 45;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.LightSalmon;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(548, 20);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(99, 45);
            this.btnXoa.TabIndex = 44;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGhi.BackColor = System.Drawing.Color.LightSalmon;
            this.btnGhi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGhi.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.Location = new System.Drawing.Point(424, 20);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(99, 45);
            this.btnGhi.TabIndex = 43;
            this.btnGhi.Text = "GHI";
            this.btnGhi.UseVisualStyleBackColor = false;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(168, 172);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(479, 96);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ghi chú:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã luật:";
            // 
            // txtMaPM
            // 
            this.txtMaPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPM.Location = new System.Drawing.Point(168, 69);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(240, 24);
            this.txtMaPM.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã phiếu mượn:";
            // 
            // txtMaPP
            // 
            this.txtMaPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPP.Location = new System.Drawing.Point(168, 21);
            this.txtMaPP.Name = "txtMaPP";
            this.txtMaPP.Size = new System.Drawing.Size(240, 24);
            this.txtMaPP.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã phiếu phạt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "PHIẾU PHẠT";
            // 
            // PhieuPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 552);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "PhieuPhat";
            this.Text = "PhieuPhat";
            this.Load += new System.EventHandler(this.PhieuPhat_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.ComboBox cbxMaLuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label5;
    }
}