
namespace ProjectQuanLyThuVien
{
    partial class ThongKeMuonTra
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ThongKeSachMuonTra = new ProjectQuanLyThuVien.ThongKeSachMuonTra();
            this.ThongKeSachMuonTraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThongKeSachMuonTraTableAdapter = new ProjectQuanLyThuVien.ThongKeSachMuonTraTableAdapters.ThongKeSachMuonTraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeSachMuonTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeSachMuonTraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ThongKeSachMuonTraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectQuanLyThuVien.ReportThongKeMuonTra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(979, 601);
            this.reportViewer1.TabIndex = 0;
            // 
            // ThongKeSachMuonTra
            // 
            this.ThongKeSachMuonTra.DataSetName = "ThongKeSachMuonTra";
            this.ThongKeSachMuonTra.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ThongKeSachMuonTraBindingSource
            // 
            this.ThongKeSachMuonTraBindingSource.DataMember = "ThongKeSachMuonTra";
            this.ThongKeSachMuonTraBindingSource.DataSource = this.ThongKeSachMuonTra;
            // 
            // ThongKeSachMuonTraTableAdapter
            // 
            this.ThongKeSachMuonTraTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKeMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 601);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ThongKeMuonTra";
            this.Text = "ThongKeMuonTra";
            this.Load += new System.EventHandler(this.ThongKeMuonTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeSachMuonTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeSachMuonTraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ThongKeSachMuonTraBindingSource;
        private ThongKeSachMuonTra ThongKeSachMuonTra;
        private ThongKeSachMuonTraTableAdapters.ThongKeSachMuonTraTableAdapter ThongKeSachMuonTraTableAdapter;
    }
}