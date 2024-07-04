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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number))
            {
                MessageBox.Show(
                "Напишите вид оплаты без цифр!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet.vid_oplat". При необходимости она может быть перемещена или удалена.
            this.vid_oplatTableAdapter.Fill(this.typographyDataSet.vid_oplat);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == vidoplatBindingSource)
            {
                vidoplatBindingSource.Filter = "[vid_oplat] LIKE'" + textBox1.Text + "%'";
                this.dataGridView1.DataSource = vidoplatBindingSource;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vidoplatBindingSource.EndEdit();
            this.vid_oplatTableAdapter.Update(this.typographyDataSet.vid_oplat);
            dataGridView1.Refresh();
        }
    }
}
