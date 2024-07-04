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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet12.ZAKAZZ". При необходимости она может быть перемещена или удалена.
            this.zAKAZZTableAdapter.Fill(this.typographyDataSet12.ZAKAZZ);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form20 Form20 = new Form20();
            Form20.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form20 Form20 = new Form20();
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
                ExcelApp.Cells[1, 1] = "Код заказа";
                ExcelApp.Cells[1, 2] = "Наименование продукции";
                ExcelApp.Cells[1, 3] = "ФИО клиента";
                ExcelApp.Cells[1, 4] = "Дата заказа";
                ExcelApp.Cells[1, 5] = "Дизайнер";
                ExcelApp.Cells[1, 6] = "Наименование макета";
                ExcelApp.Cells[1, 7] = "Стоимость разработки макета, (руб.)";
                ExcelApp.Cells[1, 8] = "Вид оплаты";
                ExcelApp.Cells[1, 9] = "Количество, (шт.)";
                ExcelApp.Cells[1, 10] = "Скидка, %";
                ExcelApp.Cells[1, 11] = "Итого, (руб.)";
                ExcelApp.Columns.AutoFit();
                ExcelApp.Rows.AutoFit();
                saveFileDialog1.FileName = "Заказы.xlsx";
                saveFileDialog1.Filter = "Файл Excel (*.xlsx)|*.xlsx";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ExcelWorkBook.SaveAs(saveFileDialog1.FileName);
                }
                ExcelApp.Visible = true;
                ExcelApp.UserControl = true;
                this.Close();
                Form20.Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == zAKAZZBindingSource)
            {
                zAKAZZBindingSource.Filter = "[Наименование продукции] LIKE'" + textBox1.Text + "%'";
                this.dataGridView1.DataSource = zAKAZZBindingSource;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == zAKAZZBindingSource)
            {
                zAKAZZBindingSource.Filter = "[ФИО клиента] LIKE'" + textBox2.Text + "%'";
                this.dataGridView1.DataSource = zAKAZZBindingSource;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == zAKAZZBindingSource)
            {
                zAKAZZBindingSource.Filter = "[Вид оплаты] LIKE'" + textBox3.Text + "%'";
                this.dataGridView1.DataSource = zAKAZZBindingSource;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == zAKAZZBindingSource)
            {
                zAKAZZBindingSource.Filter = "[Наименование макета] LIKE'" + textBox4.Text + "%'";
                this.dataGridView1.DataSource = zAKAZZBindingSource;
            }
        }
    }
}
