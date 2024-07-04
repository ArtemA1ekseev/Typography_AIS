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
    public partial class Form31 : Form
    {
        int ttime;

        public Form31()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "12345")
            {
                tmrTimer.Stop();
                this.Close();
                try
                {
                    // Запускаем нужный файл
                    System.Diagnostics.Process.Start("C:\\Users\\arste\\Desktop\\ДИПЛОМ (ПО)\\Моя программа\\Версия (1.0.0.7)\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\Пользователи.dot");
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            else
            {
                MessageBox.Show("Введен неверный пароль. Повторите попытку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttime = 10;//даем еще одну попытку ввода пароля. Если Вам это не нужно, вместо этой строки напишите Application.Exit()
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tmrTimer.Stop();
            this.Close();
        }

        private void Form31_Load(object sender, EventArgs e)
        {
            ttime = 30;//обратный отсчет
        }

        private void tmrTimer_Tick_1(object sender, EventArgs e)
        {
            lblTimer.Text = "Автоматический выход через " + ttime.ToString() + " сек.";
            ttime = ttime - 1;
            if (ttime == 0)
            {
                tmrTimer.Stop();
                MessageBox.Show("Время набора пароля истекло.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Form31_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 main = this.Owner as Form2;
            if (main != null)
            {
                main.label3.Enabled = true;
                main.label3.ForeColor = Color.Blue;
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.open;
            txtPassword.PasswordChar = '\0';
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.close;
            txtPassword.PasswordChar = '*';
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
