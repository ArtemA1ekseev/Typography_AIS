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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //
            textBox1.Text = Properties.Settings.Default.textBox;
            textBox1.ReadOnly = true;
            //
            maskedTextBox2.Text = Properties.Settings.Default.maskedTextBox;
            maskedTextBox2.ReadOnly = true;
            //
            maskedTextBox3.Text = Properties.Settings.Default.maskedTextBox1;
            maskedTextBox3.ReadOnly = true;
            //
            textBox4.Text = Properties.Settings.Default.textBox1;
            textBox4.ReadOnly = true;
            //
            maskedTextBox4.Text = Properties.Settings.Default.maskedTextBox2;
            maskedTextBox4.ReadOnly = true;
            //
            textBox6.Text = Properties.Settings.Default.textBox2;
            textBox6.ReadOnly = true;
            //
            textBox7.Text = Properties.Settings.Default.textBox3;
            textBox7.ReadOnly = true;
            //
            textBox8.Text = Properties.Settings.Default.textBox4;
            textBox8.ReadOnly = true;
            //
            maskedTextBox5.Text = Properties.Settings.Default.maskedTextBox3;
            maskedTextBox5.ReadOnly = true;
            //
            maskedTextBox6.Text = Properties.Settings.Default.maskedTextBox4;
            maskedTextBox6.ReadOnly = true;
            //
            maskedTextBox7.Text = Properties.Settings.Default.maskedTextBox5;
            maskedTextBox7.ReadOnly = true;
            //
            textBox12.Text = Properties.Settings.Default.textBox5;
            textBox12.ReadOnly = true;
            //
            textBox13.Text = Properties.Settings.Default.textBox6;
            textBox13.ReadOnly = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try // Проверка.
            {
                if (checkBox1.CheckState == CheckState.Checked) // условие если.
                {
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    button5.Visible = true;
                    button6.Visible = true;
                    button7.Visible = true;
                    button8.Visible = true;
                    button9.Visible = true;
                    button10.Visible = true;
                    button11.Visible = true;
                    button12.Visible = true;
                    button13.Visible = true;
                }
                else if (checkBox1.CheckState == CheckState.Unchecked) // условие тогда.
                {
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    button10.Visible = false;
                    button11.Visible = false;
                    button12.Visible = false;
                    button13.Visible = false;
                }
            }
            catch // обработчик ошибок.
            {
                MessageBox.Show(
                "Проверьте правильность своих действий и повторите попытку!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Редактировать информацию нужно аккуратно! Включите подсказки и проверьте каким цветом загорается знак вопроса напротив поля ввода данных. Если значок подсказки загорается КРАСНЫМ цветом — это значит, что к редактированию информации нужно подходить с особой осторожностью. Нажимая ОК, вы берете всю ответственность на себя!",
                "Предупреждение!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            //
            checkBox1.Checked = true;
            //
            button15.Enabled = false;
            button17.Visible = true;
            button18.Visible = true;
            groupBox4.Visible = true;
            // Отмена на запрет "ReadOnly".
            textBox1.ReadOnly = false;
            maskedTextBox2.ReadOnly = false;
            maskedTextBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            maskedTextBox4.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = false;
            textBox8.ReadOnly = false;
            maskedTextBox5.ReadOnly = false;
            maskedTextBox6.ReadOnly = false;
            maskedTextBox7.ReadOnly = false;
            textBox12.ReadOnly = false;
            textBox13.ReadOnly = false;
            //
            button1.FlatAppearance.BorderColor = Color.Green;
            button2.FlatAppearance.BorderColor = Color.Red;
            button3.FlatAppearance.BorderColor = Color.Red;
            button4.FlatAppearance.BorderColor = Color.Green;
            button5.FlatAppearance.BorderColor = Color.Red;
            button6.FlatAppearance.BorderColor = Color.Green;
            button7.FlatAppearance.BorderColor = Color.Green;
            button8.FlatAppearance.BorderColor = Color.Green;
            button9.FlatAppearance.BorderColor = Color.Red;
            button10.FlatAppearance.BorderColor = Color.Red;
            button11.FlatAppearance.BorderColor = Color.Red;
            button12.FlatAppearance.BorderColor = Color.Green;
            button13.FlatAppearance.BorderColor = Color.Green;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Owner = this;
            button17.Enabled = false;
            button18.Enabled = false;
            form13.Show();
            //
            textBox1.ReadOnly = true;
            maskedTextBox2.ReadOnly = true;
            maskedTextBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            maskedTextBox4.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            maskedTextBox5.ReadOnly = true;
            maskedTextBox6.ReadOnly = true;
            maskedTextBox7.ReadOnly = true;
            textBox12.ReadOnly = true;
            textBox13.ReadOnly = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Form13 Form13 = new Form13();
            Form13.Close();
            //
            checkBox1.Checked = false;
            //
            button1.FlatAppearance.BorderColor = Color.DarkGray;
            button2.FlatAppearance.BorderColor = Color.DarkGray;
            button3.FlatAppearance.BorderColor = Color.DarkGray;
            button4.FlatAppearance.BorderColor = Color.DarkGray;
            button5.FlatAppearance.BorderColor = Color.DarkGray;
            button6.FlatAppearance.BorderColor = Color.DarkGray;
            button7.FlatAppearance.BorderColor = Color.DarkGray;
            button8.FlatAppearance.BorderColor = Color.DarkGray;
            button9.FlatAppearance.BorderColor = Color.DarkGray;
            button10.FlatAppearance.BorderColor = Color.DarkGray;
            button11.FlatAppearance.BorderColor = Color.DarkGray;
            button12.FlatAppearance.BorderColor = Color.DarkGray;
            button13.FlatAppearance.BorderColor = Color.DarkGray;
            //
            button15.Enabled = true;
            button17.Visible = false;
            button18.Visible = false;
            groupBox4.Visible = false;
            //
            textBox1.ReadOnly = true;
            maskedTextBox2.ReadOnly = true;
            maskedTextBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            maskedTextBox4.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            maskedTextBox5.ReadOnly = true;
            maskedTextBox6.ReadOnly = true;
            maskedTextBox7.ReadOnly = true;
            textBox12.ReadOnly = true;
            textBox13.ReadOnly = true;
            //
            button17.Enabled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsWhiteSpace(number))
            {
                MessageBox.Show(
                "Напишите ИНН без пробелов, используя только цифры!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsWhiteSpace(number))
            {
                MessageBox.Show(
                "Напишите КПП без пробелов, используя только цифры!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsWhiteSpace(number))
            {
                MessageBox.Show(
                "Напишите Бик без пробелов, используя только цифры!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsWhiteSpace(number))
            {
                MessageBox.Show(
                "Укажите сайт без пробелов, используя только цифры!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsWhiteSpace(number))
            {
                MessageBox.Show(
               "Укажите почту без пробелов, используя только цифры!",
               "Ошибка!",
               MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation,
               MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsWhiteSpace(number))
            {
                MessageBox.Show(
               "Напишите к/с без пробелов, используя только цифры!",
               "Ошибка!",
               MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation,
               MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsWhiteSpace(number))
            {
                MessageBox.Show(
               "Напишите р/с без пробелов, используя только цифры!",
               "Ошибка!",
               MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation,
               MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.textBox = textBox1.Text;
            Properties.Settings.Default.Save();
            //
            Properties.Settings.Default.maskedTextBox = maskedTextBox2.Text;
            Properties.Settings.Default.Save();
            //
            Properties.Settings.Default.maskedTextBox1 = maskedTextBox3.Text;
            Properties.Settings.Default.Save();
            //
            Properties.Settings.Default.textBox1 = textBox4.Text;
            Properties.Settings.Default.Save();
            //
            Properties.Settings.Default.maskedTextBox2 = maskedTextBox4.Text;
            Properties.Settings.Default.Save();
            //
            Properties.Settings.Default.textBox2 = textBox6.Text;
            Properties.Settings.Default.Save();
            //
            Properties.Settings.Default.textBox3 = textBox7.Text;
            Properties.Settings.Default.Save();
            //
            Properties.Settings.Default.textBox4 = textBox8.Text;
            Properties.Settings.Default.Save();
            //
            Properties.Settings.Default.maskedTextBox3 = maskedTextBox5.Text;
            Properties.Settings.Default.Save();
            //
            Properties.Settings.Default.maskedTextBox4 = maskedTextBox6.Text;
            Properties.Settings.Default.Save();
            //
            Properties.Settings.Default.maskedTextBox5 = maskedTextBox7.Text;
            Properties.Settings.Default.Save();
            //
            Properties.Settings.Default.textBox5 = textBox12.Text;
            Properties.Settings.Default.Save();
            //
            Properties.Settings.Default.textBox6 = textBox13.Text;
            Properties.Settings.Default.Save();
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }
    }
}
