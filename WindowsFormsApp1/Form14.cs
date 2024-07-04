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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet4.sostoianie_zakaza". При необходимости она может быть перемещена или удалена.
            this.sostoianie_zakazaTableAdapter.Fill(this.typographyDataSet4.sostoianie_zakaza);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet11.klienti". При необходимости она может быть перемещена или удалена.
            this.klientiTableAdapter.Fill(this.typographyDataSet11.klienti);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet4.sostoianie_gotovnosti_zakaza". При необходимости она может быть перемещена или удалена.
            this.sostoianie_gotovnosti_zakazaTableAdapter.Fill(this.typographyDataSet4.sostoianie_gotovnosti_zakaza);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sostoianiegotovnostizakazaBindingSource.Filter = "data_gotovnosti = '" + textBox1.Text + "'";
            }
            catch (Exception)
            {
                   MessageBox.Show(
                   "Ошибка! Проверьте правильность своих действий!",
                   "Ошибка!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
                   textBox1.Text = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sostoianiegotovnostizakazaBindingSource.Filter = "";
            textBox1.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Form15 Form15 = new Form15();
                DialogResult result = MessageBox.Show(
                "Нажмите 'Да', если хотите перейти к экспорту данных. Нажмите 'Нет', чтобы вернуться к редактированию данных. После перехода к экспорту редактировать данные будет нельзя!",
                "Внимание!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    Form15.Show();
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                   "Ошибка подготовки к экспорту!",
                   "Ошибка!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox1.Text.Length != 0;
            button2.Enabled = textBox1.Text.Length != 0;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sostoianiegotovnostizakazaBindingSource.EndEdit();
            this.sostoianie_gotovnosti_zakazaTableAdapter.Update(this.typographyDataSet4.sostoianie_gotovnosti_zakaza);
            dataGridView1.Refresh();
        }
    }
}
