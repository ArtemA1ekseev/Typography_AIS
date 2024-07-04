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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet4.material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.typographyDataSet4.material);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet4.vid_pechati". При необходимости она может быть перемещена или удалена.
            this.vid_pechatiTableAdapter.Fill(this.typographyDataSet4.vid_pechati);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet4.naimenovanie_prodykcii". При необходимости она может быть перемещена или удалена.
            this.naimenovanie_prodykciiTableAdapter.Fill(this.typographyDataSet4.naimenovanie_prodykcii);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet4.yslygi". При необходимости она может быть перемещена или удалена.
            this.yslygiTableAdapter.Fill(this.typographyDataSet4.yslygi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet4.prodykcia". При необходимости она может быть перемещена или удалена.
            this.prodykciaTableAdapter.Fill(this.typographyDataSet4.prodykcia);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                prodykciaBindingSource.Filter = "shirina = \'" + textBox1.Text + "\'";
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
            prodykciaBindingSource.Filter = "";
            textBox1.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                prodykciaBindingSource.Filter = "visota = \'" + textBox2.Text + "\'";
            }
            catch (Exception)
            {
                MessageBox.Show(
                   "Ошибка! Проверьте правильность своих действий!",
                   "Ошибка!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
                textBox2.Text = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prodykciaBindingSource.Filter = "";
            textBox2.Text = null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                prodykciaBindingSource.Filter = "stoimost = \'" + textBox3.Text + "\'";
            }
            catch (Exception)
            {
                MessageBox.Show(
                   "Ошибка! Проверьте правильность своих действий!",
                   "Ошибка!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
                textBox3.Text = null;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            prodykciaBindingSource.Filter = "";
            textBox3.Text = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Form17 Form17 = new Form17();
                DialogResult result = MessageBox.Show(
                "Нажмите 'Да', если хотите перейти к экспорту данных. Нажмите 'Нет', чтобы вернуться к редактированию данных. После перехода к экспорту редактировать данные будет нельзя!",
                "Внимание!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    Form17.Show();
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form25 form25 = new Form25();
            form25.Owner = this;
            button9.Enabled = false;
            form25.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox1.Text.Length != 0;
            button2.Enabled = textBox1.Text.Length != 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = textBox2.Text.Length != 0;
            button4.Enabled = textBox2.Text.Length != 0;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button7.Enabled = textBox3.Text.Length != 0;
            button8.Enabled = textBox3.Text.Length != 0;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prodykciaBindingSource.EndEdit();
            this.prodykciaTableAdapter.Update(this.typographyDataSet4.prodykcia);
            dataGridView1.Refresh();
        }
    }
}
