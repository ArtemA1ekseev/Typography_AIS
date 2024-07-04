
namespace WindowsFormsApp1
{
    partial class Form27
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form27));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типФайлаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.разрешениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.глубинаЦветDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаСозданияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаИзмененияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typographyDataSet5 = new WindowsFormsApp1.TypographyDataSet5();
            this.prod3TableAdapter = new WindowsFormsApp1.TypographyDataSet5TableAdapters.prod3TableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.cToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.cToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.dToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typographyDataSet5)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.наименованиеDataGridViewTextBoxColumn,
            this.типФайлаDataGridViewTextBoxColumn,
            this.размерDataGridViewTextBoxColumn,
            this.разрешениеDataGridViewTextBoxColumn,
            this.глубинаЦветDataGridViewTextBoxColumn,
            this.датаСозданияDataGridViewTextBoxColumn,
            this.датаИзмененияDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dataGridView1.DataSource = this.prod3BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 206);
            this.dataGridView1.TabIndex = 2;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            this.наименованиеDataGridViewTextBoxColumn.Width = 108;
            // 
            // типФайлаDataGridViewTextBoxColumn
            // 
            this.типФайлаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.типФайлаDataGridViewTextBoxColumn.DataPropertyName = "Тип файла";
            this.типФайлаDataGridViewTextBoxColumn.HeaderText = "Тип файла";
            this.типФайлаDataGridViewTextBoxColumn.Name = "типФайлаDataGridViewTextBoxColumn";
            this.типФайлаDataGridViewTextBoxColumn.ReadOnly = true;
            this.типФайлаDataGridViewTextBoxColumn.Width = 79;
            // 
            // размерDataGridViewTextBoxColumn
            // 
            this.размерDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.размерDataGridViewTextBoxColumn.DataPropertyName = "Размер";
            this.размерDataGridViewTextBoxColumn.HeaderText = "Размер";
            this.размерDataGridViewTextBoxColumn.Name = "размерDataGridViewTextBoxColumn";
            this.размерDataGridViewTextBoxColumn.ReadOnly = true;
            this.размерDataGridViewTextBoxColumn.Width = 71;
            // 
            // разрешениеDataGridViewTextBoxColumn
            // 
            this.разрешениеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.разрешениеDataGridViewTextBoxColumn.DataPropertyName = "Разрешение";
            this.разрешениеDataGridViewTextBoxColumn.HeaderText = "Разрешение";
            this.разрешениеDataGridViewTextBoxColumn.Name = "разрешениеDataGridViewTextBoxColumn";
            this.разрешениеDataGridViewTextBoxColumn.ReadOnly = true;
            this.разрешениеDataGridViewTextBoxColumn.Width = 95;
            // 
            // глубинаЦветDataGridViewTextBoxColumn
            // 
            this.глубинаЦветDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.глубинаЦветDataGridViewTextBoxColumn.DataPropertyName = "Глубина цвет";
            this.глубинаЦветDataGridViewTextBoxColumn.HeaderText = "Глубина цвет";
            this.глубинаЦветDataGridViewTextBoxColumn.Name = "глубинаЦветDataGridViewTextBoxColumn";
            this.глубинаЦветDataGridViewTextBoxColumn.ReadOnly = true;
            this.глубинаЦветDataGridViewTextBoxColumn.Width = 91;
            // 
            // датаСозданияDataGridViewTextBoxColumn
            // 
            this.датаСозданияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.датаСозданияDataGridViewTextBoxColumn.DataPropertyName = "Дата создания";
            this.датаСозданияDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            this.датаСозданияDataGridViewTextBoxColumn.Name = "датаСозданияDataGridViewTextBoxColumn";
            this.датаСозданияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаИзмененияDataGridViewTextBoxColumn
            // 
            this.датаИзмененияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.датаИзмененияDataGridViewTextBoxColumn.DataPropertyName = "Дата изменения ";
            this.датаИзмененияDataGridViewTextBoxColumn.HeaderText = "Дата изменения ";
            this.датаИзмененияDataGridViewTextBoxColumn.Name = "датаИзмененияDataGridViewTextBoxColumn";
            this.датаИзмененияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаИзмененияDataGridViewTextBoxColumn.Width = 110;
            // 
            // prod3BindingSource
            // 
            this.prod3BindingSource.DataMember = "prod3";
            this.prod3BindingSource.DataSource = this.typographyDataSet5;
            // 
            // typographyDataSet5
            // 
            this.typographyDataSet5.DataSetName = "TypographyDataSet5";
            this.typographyDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prod3TableAdapter
            // 
            this.prod3TableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripLabel,
            this.cToolStripTextBox,
            this.dToolStripLabel,
            this.dToolStripTextBox,
            this.fillToolStripButton,
            this.toolStripButton1});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(808, 25);
            this.fillToolStrip.TabIndex = 3;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // cToolStripLabel
            // 
            this.cToolStripLabel.Name = "cToolStripLabel";
            this.cToolStripLabel.Size = new System.Drawing.Size(274, 22);
            this.cToolStripLabel.Text = "Укажите дату создания макета в промежутках от";
            // 
            // cToolStripTextBox
            // 
            this.cToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cToolStripTextBox.Name = "cToolStripTextBox";
            this.cToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // dToolStripLabel
            // 
            this.dToolStripLabel.Name = "dToolStripLabel";
            this.dToolStripLabel.Size = new System.Drawing.Size(23, 22);
            this.dToolStripLabel.Text = "до:";
            // 
            // dToolStripTextBox
            // 
            this.dToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dToolStripTextBox.Name = "dToolStripTextBox";
            this.dToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.ForeColor = System.Drawing.Color.Red;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(75, 22);
            this.fillToolStripButton.Text = "Отобразить";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "❌";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form27
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Picture_for_background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 297);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form27";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Детальная информация по макетам";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form27_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typographyDataSet5)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типФайлаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn разрешениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn глубинаЦветDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаСозданияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаИзмененияDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource prod3BindingSource;
        private TypographyDataSet5 typographyDataSet5;
        private TypographyDataSet5TableAdapters.prod3TableAdapter prod3TableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel cToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox cToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel dToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}