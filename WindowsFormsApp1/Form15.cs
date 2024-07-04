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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet3.SOS_GOT_ZAK". При необходимости она может быть перемещена или удалена.
            this.sOS_GOT_ZAKTableAdapter.Fill(this.typographyDataSet3.SOS_GOT_ZAK);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form14 Form14 = new Form14();
            Form14.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form14 Form14 = new Form14();
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
                ExcelApp.Cells[1, 2] = "ФИО клиента";
                ExcelApp.Cells[1, 3] = "Дата готовности";
                ExcelApp.Cells[1, 4] = "Состояние заказа";
                ExcelApp.Columns.AutoFit();
                ExcelApp.Rows.AutoFit();
                saveFileDialog1.FileName = "Состояние готовности заказов.xlsx";
                saveFileDialog1.Filter = "Файл Excel (*.xlsx)|*.xlsx";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ExcelWorkBook.SaveAs(saveFileDialog1.FileName);
                }
                ExcelApp.Visible = true;
                ExcelApp.UserControl = true;
                this.Close();
                Form14.Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == sOSGOTZAKBindingSource)
            {
                sOSGOTZAKBindingSource.Filter = "[ФИО клиента] LIKE'" + textBox1.Text + "%'";
                this.dataGridView1.DataSource = sOSGOTZAKBindingSource;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == sOSGOTZAKBindingSource)
            {
                sOSGOTZAKBindingSource.Filter = "[Состояние заказа] LIKE'" + textBox2.Text + "%'";
                this.dataGridView1.DataSource = sOSGOTZAKBindingSource;
            }
        }
    }
}
