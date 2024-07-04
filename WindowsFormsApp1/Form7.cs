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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet13.material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.typographyDataSet13.material);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number))
            {
                MessageBox.Show(
                "Напишите материал без цифр!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == materialBindingSource)
            {
                materialBindingSource.Filter = "[material] LIKE'" + textBox1.Text + "%'";
                this.dataGridView1.DataSource = materialBindingSource;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialBindingSource.EndEdit();
            this.materialTableAdapter.Update(this.typographyDataSet13.material);
            dataGridView1.Refresh();
        }
    }
}
