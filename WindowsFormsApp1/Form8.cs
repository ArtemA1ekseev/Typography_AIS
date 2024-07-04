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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet.vid_pechati". При необходимости она может быть перемещена или удалена.
            this.vid_pechatiTableAdapter.Fill(this.typographyDataSet.vid_pechati);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number))
            {
                MessageBox.Show(
                "Напишите вид печати без цифр!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == vidpechatiBindingSource)
            {
                vidpechatiBindingSource.Filter = "[vid_pechati] LIKE'" + textBox1.Text + "%'";
                this.dataGridView1.DataSource = vidpechatiBindingSource;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vidpechatiBindingSource.EndEdit();
            this.vid_pechatiTableAdapter.Update(this.typographyDataSet.vid_pechati);
            dataGridView1.Refresh();
        }
    }
}
