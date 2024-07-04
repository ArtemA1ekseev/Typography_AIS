// Библиотеки.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Кодовое название проекта.
namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        // Описание полей класса.
        Form1 f1 = new Form1();
        Agent agent = new Agent();

        // Инициализация формы.
        public Form2()
        {
            InitializeComponent();
        }

        // Процедура нажатия на "Кнопка 1".
        private void button1_Click(object sender, EventArgs e)
        {
            try // Проверка.
            {
                bool fl = false;
                for (int i = 0; i < agent.mas_agents.Length; i++) // цикл for.
                {
                    if (text_login.Text == agent.mas_agents[i, 0] && text_password.Text == agent.mas_agents[i, 1]) // условие если.
                    {
                        this.Hide();
                        f1.Show();
                        fl = true;
                        agent.Name = agent.mas_agents[i, 2];
                        break;
                    }

                }
                if (!fl) // условие если.
                {
                    MessageBox.Show(
                    "Неверно введены данные!",
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                    text_login.Clear();
                    text_password.Clear();

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

        // Класс "Агент"
        public class Agent
        {
            public string[,] mas_agents;
            public string agent_name;
            public string Name
            {
                get
                {
                    return agent_name;
                }
                set
                {
                    agent_name = value;
                }
            }

            public void agent_admin()
            {
                try // Проверка.
                {
                    mas_agents = new string[1, 3];
                    mas_agents[0, 0] = "admin";
                    mas_agents[0, 1] = "321";
                    mas_agents[0, 2] = "q3211";
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

            public void agent_men()
            {
                try // Проверка.
                {
                    mas_agents = new string[1, 3];
                    mas_agents[0, 0] = "men";
                    mas_agents[0, 1] = "1322";
                    mas_agents[0, 2] = "me321";
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

            public void agent_eco1()
            {
                try // Проверка.
                {
                    mas_agents = new string[1, 3];
                    mas_agents[0, 0] = "eco1";
                    mas_agents[0, 1] = "13ec312";
                    mas_agents[0, 2] = "12";
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

            public void agent_diza1()
            {
                try // Проверка.
                {
                    mas_agents = new string[1, 3];
                    mas_agents[0, 0] = "diza1";
                    mas_agents[0, 1] = "111234";
                    mas_agents[0, 2] = "gfeg2";
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

            public void agent_pechat()
            {
                try // Проверка.
                {
                    mas_agents = new string[1, 3];
                    mas_agents[0, 0] = "pechat";
                    mas_agents[0, 1] = "132w2w2";
                    mas_agents[0, 2] = "sdd2";
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

            public void agent_resize(int resize)
            {
                try // Проверка.
                {
                    mas_agents = new string[resize, 3];
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
            public void Fill_Agent(int i, string login, string password, string full_name)
            {
                try // Проверка.
                {
                    mas_agents[i - 1, 0] = login;
                    mas_agents[i - 1, 1] = password;
                    mas_agents[i - 1, 2] = full_name;
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
        }

        // Процедура нажатия на "Кнопка 2".
        private void button3_Click_1(object sender, EventArgs e)
        {
            try // Проверка.
            {
                add1();
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
        public void add1() // Добавление.
        {
            try // Проверка.
            {
                agent.agent_resize(1);
                if (text_login1.Text.Length == 0 || text_pass1.Text.Length == 0 || text_fio1.Text.Length == 0) // условие если.
                    MessageBox.Show(
                    "Введите все поля!",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                else // условие тогда.
                {
                    agent.Fill_Agent(1, text_login1.Text, text_pass1.Text, text_fio1.Text);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try // Проверка.
            {
                if (checkBox1.CheckState == CheckState.Checked) // условие если.
                {
                    button4.Visible = true;
                    button5.Visible = true;
                }
                else if (checkBox1.CheckState == CheckState.Unchecked) // условие тогда.
                {
                    button4.Visible = false;
                    button5.Visible = false;
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

        private void text_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsWhiteSpace(number))
            {
                MessageBox.Show(
                "Напишите логин без пробелов!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
        }

        private void text_password_KeyPress(object sender, KeyPressEventArgs e)
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

        private void text_login1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsWhiteSpace(number))
            {
                MessageBox.Show(
                "Напишите данные без пробелов!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
        }

        private void text_login_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = text_login.Text.Length != 0 && text_password.Text.Length != 0;
        }

        private void text_password_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = text_login.Text.Length != 0 && text_password.Text.Length != 0;
        }
        private void text_password_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void text_password_TextChanged_1(object sender, EventArgs e)
        {
            button1.Enabled = text_login.Text.Length != 0 && text_password.Text.Length != 0;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.close;
            text_password.PasswordChar = '*';
            text_password.UseSystemPasswordChar = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.open;
            text_password.PasswordChar = '\0';
            text_password.UseSystemPasswordChar = false;
        }

        private void text_login1_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = text_login1.Text.Length != 0 && text_pass1.Text.Length != 0 && text_fio1.Text.Length != 0;
        }

        private void text_pass1_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = text_login1.Text.Length != 0 && text_pass1.Text.Length != 0 && text_fio1.Text.Length != 0;
        }

        private void text_fio1_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = text_login1.Text.Length != 0 && text_pass1.Text.Length != 0 && text_fio1.Text.Length != 0;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.open;
            text_pass1.PasswordChar = '\0';
            text_pass1.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.close;
            text_pass1.PasswordChar = '*';
            text_pass1.UseSystemPasswordChar = true;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Form31 form31 = new Form31();
            form31.Owner = this;
            label3.Enabled = false;
            label3.ForeColor = Color.DarkBlue;
            form31.Show();
        }
    }
}
