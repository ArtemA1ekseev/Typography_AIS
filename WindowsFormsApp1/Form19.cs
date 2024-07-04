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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void Form19_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet11.KL". При необходимости она может быть перемещена или удалена.
            this.kLTableAdapter.Fill(this.typographyDataSet11.KL);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form18 Form18 = new Form18();
            Form18.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form18 Form18 = new Form18();
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
                ExcelApp.Cells[1, 1] = "ФИО";
                ExcelApp.Cells[1, 2] = "Адрес";
                ExcelApp.Cells[1, 3] = "Телефон";
                ExcelApp.Cells[1, 4] = "E-mail";
                ExcelApp.Cells[1, 5] = "Вид заказчика";
                ExcelApp.Cells[1, 6] = "Наименование организации";
                ExcelApp.Cells[1, 7] = "Юридический адрес";
                ExcelApp.Cells[1, 8] = "ИНН/КПП";
                ExcelApp.Cells[1, 9] = "Расчетный счет";
                ExcelApp.Columns.AutoFit();
                ExcelApp.Rows.AutoFit();
                saveFileDialog1.FileName = "Клиенты.xlsx";
                saveFileDialog1.Filter = "Файл Excel (*.xlsx)|*.xlsx";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ExcelWorkBook.SaveAs(saveFileDialog1.FileName);
                }
                ExcelApp.Visible = true;
                ExcelApp.UserControl = true;
                this.Close();
                Form18.Show();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == kLBindingSource)
            {
                kLBindingSource.Filter = "[Вид заказчика] LIKE'" + textBox1.Text + "%'";
                this.dataGridView1.DataSource = kLBindingSource;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
