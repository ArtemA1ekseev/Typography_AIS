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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet.naimenovanie_prodykcii". При необходимости она может быть перемещена или удалена.
            this.naimenovanie_prodykciiTableAdapter.Fill(this.typographyDataSet.naimenovanie_prodykcii);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number))
            {
                MessageBox.Show(
                "Напишите наименование продукции без цифр!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == naimenovanieprodykciiBindingSource)
            {
                naimenovanieprodykciiBindingSource.Filter = "[naimenovanie_prodykcii] LIKE'" + textBox1.Text + "%'";
                this.dataGridView1.DataSource = naimenovanieprodykciiBindingSource;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.naimenovanieprodykciiBindingSource.EndEdit();
            this.naimenovanie_prodykciiTableAdapter.Update(this.typographyDataSet.naimenovanie_prodykcii);
            dataGridView1.Refresh();
        }
    }
}
