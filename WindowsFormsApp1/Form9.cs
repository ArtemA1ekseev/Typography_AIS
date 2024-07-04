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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet.sostoianie_zakaza". При необходимости она может быть перемещена или удалена.
            this.sostoianie_zakazaTableAdapter.Fill(this.typographyDataSet.sostoianie_zakaza);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number))
            {
                MessageBox.Show(
                "Напишите состояние заказа без цифр!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == sostoianiezakazaBindingSource)
            {
                sostoianiezakazaBindingSource.Filter = "[sostoanie_zakaza] LIKE'" + textBox1.Text + "%'";
                this.dataGridView1.DataSource = sostoianiezakazaBindingSource;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sostoianiezakazaBindingSource.EndEdit();
            this.sostoianie_zakazaTableAdapter.Update(this.typographyDataSet.sostoianie_zakaza);
            dataGridView1.Refresh();
        }
    }
}
