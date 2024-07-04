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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet.vid_zakazchika". При необходимости она может быть перемещена или удалена.
            this.vid_zakazchikaTableAdapter.Fill(this.typographyDataSet.vid_zakazchika);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number))
            {
                MessageBox.Show(
                "Напишите вид заказчика без цифр!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == vidzakazchikaBindingSource)
            {
                vidzakazchikaBindingSource.Filter = "[vid_zakazchika] LIKE'" + textBox1.Text + "%'";
                this.dataGridView1.DataSource = vidzakazchikaBindingSource;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vidzakazchikaBindingSource.EndEdit();
            this.vid_zakazchikaTableAdapter.Update(this.typographyDataSet.vid_zakazchika);
            dataGridView1.Refresh();
        }
    }
}
