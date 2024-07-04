
namespace WindowsFormsApp1
{
    partial class Form28
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form28));
            this.Otch1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TypographyDataSet6 = new WindowsFormsApp1.TypographyDataSet6();
            this._1RekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TypographyDataSet10 = new WindowsFormsApp1.TypographyDataSet10();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Otch1TableAdapter = new WindowsFormsApp1.TypographyDataSet6TableAdapters.Otch1TableAdapter();
            this._1RekTableAdapter = new WindowsFormsApp1.TypographyDataSet10TableAdapters._1RekTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Otch1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypographyDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1RekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypographyDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // Otch1BindingSource
            // 
            this.Otch1BindingSource.DataMember = "Otch1";
            this.Otch1BindingSource.DataSource = this.TypographyDataSet6;
            // 
            // TypographyDataSet6
            // 
            this.TypographyDataSet6.DataSetName = "TypographyDataSet6";
            this.TypographyDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _1RekBindingSource
            // 
            this._1RekBindingSource.DataMember = "1Rek";
            this._1RekBindingSource.DataSource = this.TypographyDataSet10;
            // 
            // TypographyDataSet10
            // 
            this.TypographyDataSet10.DataSetName = "TypographyDataSet10";
            this.TypographyDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Otch1BindingSource;
            reportDataSource2.Name = "DataSet3";
            reportDataSource2.Value = this._1RekBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(771, 911);
            this.reportViewer1.TabIndex = 0;
            // 
            // Otch1TableAdapter
            // 
            this.Otch1TableAdapter.ClearBeforeFill = true;
            // 
            // _1RekTableAdapter
            // 
            this._1RekTableAdapter.ClearBeforeFill = true;
            // 
            // Form28
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 911);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form28";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реквизиты компании";
            this.Load += new System.EventHandler(this.Form28_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Otch1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypographyDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1RekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypographyDataSet10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Otch1BindingSource;
        private TypographyDataSet6 TypographyDataSet6;
        private System.Windows.Forms.BindingSource _1RekBindingSource;
        private TypographyDataSet10 TypographyDataSet10;
        private TypographyDataSet6TableAdapters.Otch1TableAdapter Otch1TableAdapter;
        private TypographyDataSet10TableAdapters._1RekTableAdapter _1RekTableAdapter;
    }
}