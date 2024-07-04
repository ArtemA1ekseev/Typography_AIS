
namespace WindowsFormsApp1
{
    partial class Form30
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form30));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TypographyDataSet9 = new WindowsFormsApp1.TypographyDataSet9();
            this._3KvitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._3KvitTableAdapter = new WindowsFormsApp1.TypographyDataSet9TableAdapters._3KvitTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TypographyDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._3KvitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this._3KvitBindingSource;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this._3KvitBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1210, 819);
            this.reportViewer1.TabIndex = 0;
            // 
            // TypographyDataSet9
            // 
            this.TypographyDataSet9.DataSetName = "TypographyDataSet9";
            this.TypographyDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _3KvitBindingSource
            // 
            this._3KvitBindingSource.DataMember = "3Kvit";
            this._3KvitBindingSource.DataSource = this.TypographyDataSet9;
            // 
            // _3KvitTableAdapter
            // 
            this._3KvitTableAdapter.ClearBeforeFill = true;
            // 
            // Form30
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 819);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form30";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Квитанция об оплате";
            this.Load += new System.EventHandler(this.Form30_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TypographyDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._3KvitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.BindingSource _3KvitBindingSource;
        public TypographyDataSet9 TypographyDataSet9;
        public TypographyDataSet9TableAdapters._3KvitTableAdapter _3KvitTableAdapter;
    }
}