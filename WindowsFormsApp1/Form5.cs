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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show(
                    "Заполните все поля!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                try
                {
                    sqlCommand1.Parameters["@textl"].Value = "GRANT " + comboBox1.Text + " ON " + comboBox2.Text + " TO " + textBox3.Text;
                    sqlConnection1.Open();
                    sqlCommand1.ExecuteNonQuery();
                    sqlConnection1.Close();
                    MessageBox.Show(
                    "Разрешение добавлено!",
                    "Успешно!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                }
                catch
                {
                    MessageBox.Show(
                    "Невозможно добавление разрешения!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show(
                    "Заполните все поля!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                try
                {
                    sqlCommand1.Parameters["@textl"].Value = "REVOKE " + comboBox1.Text + " ON " + comboBox2.Text + " TO " + textBox3.Text;
                    sqlConnection1.Open();
                    sqlCommand1.ExecuteNonQuery();
                    sqlConnection1.Close();
                    MessageBox.Show(
                    "Разрешение удалено!",
                    "Успешно!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                }
                catch
                {
                    MessageBox.Show(
                    "Невозможно удалить разрешение!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Owner = this;
            button1.Enabled = false;
            form4.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button4.Enabled = textBox3.Text.Length != 0;
            button5.Enabled = textBox3.Text.Length != 0;
            button6.Enabled = textBox3.Text.Length != 0;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsWhiteSpace(number))
            {
                MessageBox.Show(
                "Напишите имя без пробелов!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
        }
    }
}
