
namespace WindowsFormsApp1
{
    partial class Form29
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form29));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TypographyDataSet9 = new WindowsFormsApp1.TypographyDataSet9();
            this._2PraicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._2PraicTableAdapter = new WindowsFormsApp1.TypographyDataSet9TableAdapters._2PraicTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TypographyDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._2PraicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this._2PraicBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(911, 931);
            this.reportViewer1.TabIndex = 0;
            // 
            // TypographyDataSet9
            // 
            this.TypographyDataSet9.DataSetName = "TypographyDataSet9";
            this.TypographyDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _2PraicBindingSource
            // 
            this._2PraicBindingSource.DataMember = "2Praic";
            this._2PraicBindingSource.DataSource = this.TypographyDataSet9;
            // 
            // _2PraicTableAdapter
            // 
            this._2PraicTableAdapter.ClearBeforeFill = true;
            // 
            // Form29
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 931);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form29";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прайс-лист";
            this.Load += new System.EventHandler(this.Form29_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TypographyDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._2PraicBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource _2PraicBindingSource;
        private TypographyDataSet9 TypographyDataSet9;
        private TypographyDataSet9TableAdapters._2PraicTableAdapter _2PraicTableAdapter;
    }
}