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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet4.naimenovanie_prodykcii". При необходимости она может быть перемещена или удалена.
            this.naimenovanie_prodykciiTableAdapter.Fill(this.typographyDataSet4.naimenovanie_prodykcii);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet4.prodykcia". При необходимости она может быть перемещена или удалена.
            this.prodykciaTableAdapter.Fill(this.typographyDataSet4.prodykcia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet4.vid_oplat". При необходимости она может быть перемещена или удалена.
            this.vid_oplatTableAdapter.Fill(this.typographyDataSet4.vid_oplat);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet4.maket". При необходимости она может быть перемещена или удалена.
            this.maketTableAdapter.Fill(this.typographyDataSet4.maket);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet11.klienti". При необходимости она может быть перемещена или удалена.
            this.klientiTableAdapter.Fill(this.typographyDataSet11.klienti);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet12.zakazi". При необходимости она может быть перемещена или удалена.
            this.zakaziTableAdapter.Fill(this.typographyDataSet12.zakazi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                zakaziBindingSource.Filter = "data_zakaza = '" + textBox1.Text + "'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            zakaziBindingSource.Filter = "";
            textBox1.Text = null;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                zakaziBindingSource.Filter = "kolichestvo = \'" + textBox2.Text + "\'";
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
            zakaziBindingSource.Filter = "";
            textBox2.Text = null;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Form21 Form21 = new Form21();
                DialogResult result = MessageBox.Show(
                "Нажмите 'Да', если хотите перейти к экспорту данных. Нажмите 'Нет', чтобы вернуться к редактированию данных. После перехода к экспорту редактировать данные будет нельзя!",
                "Внимание!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    Form21.Show();
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

        private void button7_Click(object sender, EventArgs e)
        {
            Form26 form26 = new Form26();
            form26.Owner = this;
            button7.Enabled = false;
            form26.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            a = Int32.Parse(textBox3.Text);
            b = Int32.Parse(textBox4.Text);
            c = Int32.Parse(textBox5.Text);
            d = Int32.Parse(textBox8.Text);
            textBox6.Enabled = true;
            textBox6.Text = ((c * a - (c * a * b/100)) + d).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox6.Enabled = false;
            textBox6.Text = null;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            button9.Enabled = textBox6.Text.Length != 0;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBox6.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(
                   "Получите результат!",
                   "Ошибка!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                zakaziBindingSource.Filter = "stoimost = \'" + textBox7.Text + "\'";
            }
            catch (Exception)
            {
                MessageBox.Show(
                   "Ошибка! Проверьте правильность своих действий!",
                   "Ошибка!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
                textBox7.Text = null;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            zakaziBindingSource.Filter = "";
            textBox7.Text = null;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            button10.Enabled = textBox7.Text.Length != 0;
            button11.Enabled = textBox7.Text.Length != 0;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zakaziBindingSource.EndEdit();
            this.zakaziTableAdapter.Update(this.typographyDataSet12.zakazi);
            dataGridView1.Refresh();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Скидка предоставляется от количества заказанной продукции. \n\n От 100 до 149 шт. — 3% \n\n От 150 до 499 шт. — 5% \n\n От 500 до 999 шт. — 10% \n\n От 1000 и выше — 15% ",
            "Информация",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Form30 form30 = new Form30();
                form30._3KvitBindingSource.Filter = "Код_заказа = \'" + textBox9.Text + "\'";
                form30._3KvitTableAdapter.Fill(form30.TypographyDataSet9._3Kvit);
                form30.reportViewer1.RefreshReport();
                // Код_заказа
                form30.Show();
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
    }
}
