using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        int panelWidth;
        bool Hidden;
        public Form4()
        {
            InitializeComponent();
            panelWidth = panel1.Width;
            Hidden = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == "") || (textBox2.Text == ""))
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
                    sqlCommand1.Parameters["@login"].Value = textBox1.Text;
                    sqlCommand1.Parameters["@passwordl"].Value = textBox2.Text;
                    sqlConnection1.Open();
                    sqlCommand1.ExecuteNonQuery();
                    sqlConnection1.Close();
                    MessageBox.Show(
                    "Пользователь успешно добавлен!",
                    "Успешно!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBox.Show(
                    "Невозможно добавить пользователя!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show(
                    "Введите имя!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                }
                else
                {
                    sqlCommand2.Parameters["@login"].Value = textBox1.Text;
                    sqlConnection1.Open();
                    sqlCommand2.ExecuteNonQuery();
                    sqlConnection1.Close();
                    MessageBox.Show(
                    "Пользователь удален!",
                    "Успешно!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBox.Show(
                   "Невозможно удалить пользователя!",
                   "Ошибка!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection ThisConnection = new SqlConnection("Data Source=DESKTOP-TQRDNPR;Initial Catalog=Typography;Integrated Security=True");
                ThisConnection.Open();
                SqlCommand thisCommand = ThisConnection.CreateCommand();
                thisCommand.CommandText = "SELECT name FROM sys.database_principals where authentication_type_desc='INSTANCE' ";
                SqlDataReader thisReader = thisCommand.ExecuteReader();
                while (thisReader.Read())
                {
                    textBox3.Text += thisReader["name"].ToString() + "\r\n";
                }
                thisReader.Close();
                ThisConnection.Close();
                button4.Enabled = false;
                button5.Enabled = true;

            }
            catch
            {
                MessageBox.Show(
                   "Невозможно отобразить пользователя!",
                   "Ошибка!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            button5.Enabled = false;
            button4.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                button6.Text = "◀";
                panel1.Width = panel1.Width + 10;
                if (panel1.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                button6.Text = "▶";
                panel1.Width = panel1.Width - 10;
                if (panel1.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsWhiteSpace(number))
            {
                MessageBox.Show(
                "Напишите пароль без пробелов!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox1.Text.Length != 0 && textBox2.Text.Length != 0;
            button2.Enabled = textBox1.Text.Length != 0 || textBox2.Text.Length != 0;
            button3.Enabled = textBox1.Text.Length != 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = textBox1.Text.Length != 0 && textBox2.Text.Length != 0;
            button2.Enabled = textBox1.Text.Length != 0 || textBox2.Text.Length != 0;
            button3.Enabled = textBox1.Text.Length != 0;
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form5 main = this.Owner as Form5;
            if (main != null)
            {
                main.button1.Enabled = true;
            }
        }
    }
}
