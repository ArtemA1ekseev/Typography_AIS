using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet3.PROD". При необходимости она может быть перемещена или удалена.
            this.pRODTableAdapter.Fill(this.typographyDataSet3.PROD);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form16 Form16 = new Form16();
            Form16.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form16 Form16 = new Form16();
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
                ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
                ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
                for (int i = 1; i < dataGridView1.Rows.Count + 1; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        ExcelApp.Cells[i + 1, j + 1] = dataGridView1.Rows[i - 1].Cells[j].Value;
                    }
                }
                ExcelApp.Cells[1, 1] = "Артикул продукции";
                ExcelApp.Cells[1, 2] = "Наименование услуги";
                ExcelApp.Cells[1, 3] = "Наименование продукции";
                ExcelApp.Cells[1, 4] = "Ширина, (мм.)";
                ExcelApp.Cells[1, 5] = "Высота, (мм.)";
                ExcelApp.Cells[1, 6] = "Вид печати";
                ExcelApp.Cells[1, 7] = "Материал";
                ExcelApp.Cells[1, 8] = "Стоимость, (руб.)";
                ExcelApp.Columns.AutoFit();
                ExcelApp.Rows.AutoFit();
                saveFileDialog1.FileName = "Продукция.xlsx";
                saveFileDialog1.Filter = "Файл Excel (*.xlsx)|*.xlsx";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ExcelWorkBook.SaveAs(saveFileDialog1.FileName);
                }
                ExcelApp.Visible = true;
                ExcelApp.UserControl = true;
                this.Close();
                Form16.Show();
            }
            catch (Exception)
            {
                MessageBox.Show(
                   "Ошибка Экспорта!",
                   "Ошибка!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == pRODBindingSource)
            {
                pRODBindingSource.Filter = "[Наименование услуги] LIKE'" + textBox1.Text + "%'";
                this.dataGridView1.DataSource = pRODBindingSource;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == pRODBindingSource)
            {
                pRODBindingSource.Filter = "[Наименование продукции] LIKE'" + textBox2.Text + "%'";
                this.dataGridView1.DataSource = pRODBindingSource;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == pRODBindingSource)
            {
                pRODBindingSource.Filter = "[Вид печати] LIKE'" + textBox3.Text + "%'";
                this.dataGridView1.DataSource = pRODBindingSource;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == pRODBindingSource)
            {
                pRODBindingSource.Filter = "[Материал] LIKE'" + textBox4.Text + "%'";
                this.dataGridView1.DataSource = pRODBindingSource;
            }
        }
    }
}
