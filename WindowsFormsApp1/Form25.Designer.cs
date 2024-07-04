
namespace WindowsFormsApp1
{
    partial class Form25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form25));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prod1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typographyDataSet5 = new WindowsFormsApp1.TypographyDataSet5();
            this.prod1TableAdapter = new WindowsFormsApp1.TypographyDataSet5TableAdapters.prod1TableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.aToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.aToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.наименованиеПродукцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.материалDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod1BindingSource)).BeginInit();
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
            this.наименованиеПродукцииDataGridViewTextBoxColumn,
            this.материалDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dataGridView1.DataSource = this.prod1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(518, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // prod1BindingSource
            // 
            this.prod1BindingSource.DataMember = "prod1";
            this.prod1BindingSource.DataSource = this.typographyDataSet5;
            // 
            // typographyDataSet5
            // 
            this.typographyDataSet5.DataSetName = "TypographyDataSet5";
            this.typographyDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prod1TableAdapter
            // 
            this.prod1TableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripLabel,
            this.aToolStripTextBox,
            this.fillToolStripButton,
            this.toolStripButton1});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(542, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // aToolStripLabel
            // 
            this.aToolStripLabel.Name = "aToolStripLabel";
            this.aToolStripLabel.Size = new System.Drawing.Size(200, 22);
            this.aToolStripLabel.Text = "Введите наименование продукции:";
            // 
            // aToolStripTextBox
            // 
            this.aToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aToolStripTextBox.Name = "aToolStripTextBox";
            this.aToolStripTextBox.Size = new System.Drawing.Size(100, 25);
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
            // наименованиеПродукцииDataGridViewTextBoxColumn
            // 
            this.наименованиеПродукцииDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.наименованиеПродукцииDataGridViewTextBoxColumn.DataPropertyName = "Наименование продукции";
            this.наименованиеПродукцииDataGridViewTextBoxColumn.HeaderText = "Наименование продукции";
            this.наименованиеПродукцииDataGridViewTextBoxColumn.Name = "наименованиеПродукцииDataGridViewTextBoxColumn";
            this.наименованиеПродукцииDataGridViewTextBoxColumn.ReadOnly = true;
            this.наименованиеПродукцииDataGridViewTextBoxColumn.Width = 150;
            // 
            // материалDataGridViewTextBoxColumn
            // 
            this.материалDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.материалDataGridViewTextBoxColumn.DataPropertyName = "Материал";
            this.материалDataGridViewTextBoxColumn.HeaderText = "Материал";
            this.материалDataGridViewTextBoxColumn.Name = "материалDataGridViewTextBoxColumn";
            this.материалDataGridViewTextBoxColumn.ReadOnly = true;
            this.материалDataGridViewTextBoxColumn.Width = 82;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость, (руб.)";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            this.стоимостьDataGridViewTextBoxColumn.Width = 109;
            // 
            // Form25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Picture_for_background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 292);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form25";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Детальная информация по продукции";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form25_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prod1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typographyDataSet5)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource prod1BindingSource;
        private TypographyDataSet5 typographyDataSet5;
        private TypographyDataSet5TableAdapters.prod1TableAdapter prod1TableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel aToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox aToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеПродукцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn материалDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
    }
}