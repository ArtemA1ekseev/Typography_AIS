
namespace WindowsFormsApp1
{
    partial class Form21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form21));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zAKAZZBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typographyDataSet12 = new WindowsFormsApp1.TypographyDataSet12();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.zAKAZZTableAdapter = new WindowsFormsApp1.TypographyDataSet12TableAdapters.ZAKAZZTableAdapter();
            this.кодЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеПродукцииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дизайнерDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.наименованиеМакетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьМакетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видОплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скидкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.итогоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAKAZZBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typographyDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox4);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox3);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодЗаказаDataGridViewTextBoxColumn,
            this.наименованиеПродукцииDataGridViewTextBoxColumn,
            this.фИОКлиентаDataGridViewTextBoxColumn,
            this.датаЗаказаDataGridViewTextBoxColumn,
            this.дизайнерDataGridViewCheckBoxColumn,
            this.наименованиеМакетаDataGridViewTextBoxColumn,
            this.стоимостьМакетаDataGridViewTextBoxColumn,
            this.видОплатыDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.скидкаDataGridViewTextBoxColumn,
            this.итогоDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dataGridView1.DataSource = this.zAKAZZBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            // 
            // zAKAZZBindingSource
            // 
            this.zAKAZZBindingSource.DataMember = "ZAKAZZ";
            this.zAKAZZBindingSource.DataSource = this.typographyDataSet12;
            // 
            // typographyDataSet12
            // 
            this.typographyDataSet12.DataSetName = "TypographyDataSet12";
            this.typographyDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zAKAZZTableAdapter
            // 
            this.zAKAZZTableAdapter.ClearBeforeFill = true;
            // 
            // кодЗаказаDataGridViewTextBoxColumn
            // 
            this.кодЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Код заказа";
            resources.ApplyResources(this.кодЗаказаDataGridViewTextBoxColumn, "кодЗаказаDataGridViewTextBoxColumn");
            this.кодЗаказаDataGridViewTextBoxColumn.Name = "кодЗаказаDataGridViewTextBoxColumn";
            this.кодЗаказаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиеПродукцииDataGridViewTextBoxColumn
            // 
            this.наименованиеПродукцииDataGridViewTextBoxColumn.DataPropertyName = "Наименование продукции";
            resources.ApplyResources(this.наименованиеПродукцииDataGridViewTextBoxColumn, "наименованиеПродукцииDataGridViewTextBoxColumn");
            this.наименованиеПродукцииDataGridViewTextBoxColumn.Name = "наименованиеПродукцииDataGridViewTextBoxColumn";
            this.наименованиеПродукцииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОКлиентаDataGridViewTextBoxColumn
            // 
            this.фИОКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ФИО клиента";
            resources.ApplyResources(this.фИОКлиентаDataGridViewTextBoxColumn, "фИОКлиентаDataGridViewTextBoxColumn");
            this.фИОКлиентаDataGridViewTextBoxColumn.Name = "фИОКлиентаDataGridViewTextBoxColumn";
            this.фИОКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаЗаказаDataGridViewTextBoxColumn
            // 
            this.датаЗаказаDataGridViewTextBoxColumn.DataPropertyName = "Дата заказа";
            resources.ApplyResources(this.датаЗаказаDataGridViewTextBoxColumn, "датаЗаказаDataGridViewTextBoxColumn");
            this.датаЗаказаDataGridViewTextBoxColumn.Name = "датаЗаказаDataGridViewTextBoxColumn";
            this.датаЗаказаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // дизайнерDataGridViewCheckBoxColumn
            // 
            this.дизайнерDataGridViewCheckBoxColumn.DataPropertyName = "Дизайнер";
            resources.ApplyResources(this.дизайнерDataGridViewCheckBoxColumn, "дизайнерDataGridViewCheckBoxColumn");
            this.дизайнерDataGridViewCheckBoxColumn.Name = "дизайнерDataGridViewCheckBoxColumn";
            this.дизайнерDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // наименованиеМакетаDataGridViewTextBoxColumn
            // 
            this.наименованиеМакетаDataGridViewTextBoxColumn.DataPropertyName = "Наименование макета";
            resources.ApplyResources(this.наименованиеМакетаDataGridViewTextBoxColumn, "наименованиеМакетаDataGridViewTextBoxColumn");
            this.наименованиеМакетаDataGridViewTextBoxColumn.Name = "наименованиеМакетаDataGridViewTextBoxColumn";
            this.наименованиеМакетаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьМакетаDataGridViewTextBoxColumn
            // 
            this.стоимостьМакетаDataGridViewTextBoxColumn.DataPropertyName = "Стоимость макета";
            resources.ApplyResources(this.стоимостьМакетаDataGridViewTextBoxColumn, "стоимостьМакетаDataGridViewTextBoxColumn");
            this.стоимостьМакетаDataGridViewTextBoxColumn.Name = "стоимостьМакетаDataGridViewTextBoxColumn";
            this.стоимостьМакетаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // видОплатыDataGridViewTextBoxColumn
            // 
            this.видОплатыDataGridViewTextBoxColumn.DataPropertyName = "Вид оплаты";
            resources.ApplyResources(this.видОплатыDataGridViewTextBoxColumn, "видОплатыDataGridViewTextBoxColumn");
            this.видОплатыDataGridViewTextBoxColumn.Name = "видОплатыDataGridViewTextBoxColumn";
            this.видОплатыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            resources.ApplyResources(this.количествоDataGridViewTextBoxColumn, "количествоDataGridViewTextBoxColumn");
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // скидкаDataGridViewTextBoxColumn
            // 
            this.скидкаDataGridViewTextBoxColumn.DataPropertyName = "Скидка";
            resources.ApplyResources(this.скидкаDataGridViewTextBoxColumn, "скидкаDataGridViewTextBoxColumn");
            this.скидкаDataGridViewTextBoxColumn.Name = "скидкаDataGridViewTextBoxColumn";
            this.скидкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // итогоDataGridViewTextBoxColumn
            // 
            this.итогоDataGridViewTextBoxColumn.DataPropertyName = "Итого";
            resources.ApplyResources(this.итогоDataGridViewTextBoxColumn, "итогоDataGridViewTextBoxColumn");
            this.итогоDataGridViewTextBoxColumn.Name = "итогоDataGridViewTextBoxColumn";
            this.итогоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form21
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Picture_for_background_2;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form21";
            this.Load += new System.EventHandler(this.Form21_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAKAZZBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typographyDataSet12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private TypographyDataSet12 typographyDataSet12;
        private System.Windows.Forms.BindingSource zAKAZZBindingSource;
        private TypographyDataSet12TableAdapters.ZAKAZZTableAdapter zAKAZZTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеПродукцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn дизайнерDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеМакетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьМакетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видОплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn скидкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn итогоDataGridViewTextBoxColumn;
    }
}