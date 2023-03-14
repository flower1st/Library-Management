
namespace ProjectQuanLyThuVien
{
    partial class LienHe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LienHe));
            this.pictureYoutube = new System.Windows.Forms.PictureBox();
            this.pictureFb = new System.Windows.Forms.PictureBox();
            this.pictureInsta = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureYoutube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInsta)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureYoutube
            // 
            this.pictureYoutube.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureYoutube.BackColor = System.Drawing.Color.Cyan;
            this.pictureYoutube.Image = ((System.Drawing.Image)(resources.GetObject("pictureYoutube.Image")));
            this.pictureYoutube.Location = new System.Drawing.Point(0, 166);
            this.pictureYoutube.Name = "pictureYoutube";
            this.pictureYoutube.Size = new System.Drawing.Size(72, 68);
            this.pictureYoutube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureYoutube.TabIndex = 15;
            this.pictureYoutube.TabStop = false;
            this.pictureYoutube.Click += new System.EventHandler(this.pictureYoutube_Click);
            // 
            // pictureFb
            // 
            this.pictureFb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureFb.BackColor = System.Drawing.Color.Cyan;
            this.pictureFb.Image = ((System.Drawing.Image)(resources.GetObject("pictureFb.Image")));
            this.pictureFb.Location = new System.Drawing.Point(78, 166);
            this.pictureFb.Name = "pictureFb";
            this.pictureFb.Size = new System.Drawing.Size(72, 68);
            this.pictureFb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFb.TabIndex = 14;
            this.pictureFb.TabStop = false;
            this.pictureFb.Click += new System.EventHandler(this.pictureFb_Click);
            // 
            // pictureInsta
            // 
            this.pictureInsta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureInsta.BackColor = System.Drawing.Color.Cyan;
            this.pictureInsta.Image = ((System.Drawing.Image)(resources.GetObject("pictureInsta.Image")));
            this.pictureInsta.Location = new System.Drawing.Point(156, 166);
            this.pictureInsta.Name = "pictureInsta";
            this.pictureInsta.Size = new System.Drawing.Size(72, 68);
            this.pictureInsta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureInsta.TabIndex = 13;
            this.pictureInsta.TabStop = false;
            this.pictureInsta.Click += new System.EventHandler(this.pictureInsta_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DarkKhaki;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(740, 234);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "Mọi thắc mắc xin vui lòng liên hệ 1 trong các thông tin liên lạc dưới đây !\n\nCode" +
    " Không Chạy Team xin cảm ơn vì bạn đã sử dụng phần mềm của chúng tôi ! <3 UwU";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(654, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LienHe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 615);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureYoutube);
            this.Controls.Add(this.pictureFb);
            this.Controls.Add(this.pictureInsta);
            this.Controls.Add(this.richTextBox1);
            this.Name = "LienHe";
            this.Text = "LienHe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureYoutube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInsta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureYoutube;
        private System.Windows.Forms.PictureBox pictureFb;
        private System.Windows.Forms.PictureBox pictureInsta;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}