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
    public partial class Form6 : Form
    {


        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet13.yslygi". При необходимости она может быть перемещена или удалена.
            this.yslygiTableAdapter.Fill(this.typographyDataSet13.yslygi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet13.yslygi". При необходимости она может быть перемещена или удалена.
            this.yslygiTableAdapter.Fill(this.typographyDataSet13.yslygi);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number))
            {
                MessageBox.Show(
                "Напишите услугу без цифр!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == yslygiBindingSource)
            {
                yslygiBindingSource.Filter = "[naimenovanie_yslygi] LIKE'" + textBox1.Text + "%'";
                this.dataGridView1.DataSource = yslygiBindingSource;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.yslygiBindingSource.EndEdit();
            this.yslygiTableAdapter.Update(this.typographyDataSet13.yslygi);
            dataGridView1.Refresh();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.yslygiTableAdapter.FillBy(this.typographyDataSet13.yslygi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
