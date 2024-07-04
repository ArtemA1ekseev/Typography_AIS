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
    public partial class Form13 : Form
    {
        Rekvz z = new Rekvz();
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet7.rekvizity". При необходимости она может быть перемещена или удалена.
            this.rekvizityTableAdapter.Fill(this.typographyDataSet7.rekvizity);
            this.ActiveControl = label1;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try // Проверка.
            {
                z.Naz_org = textBox2.Text;
                z.Inn = maskedTextBox2.Text;
                z.Kpp = maskedTextBox3.Text;
                z.Adres = textBox4.Text;
                z.Telephone = maskedTextBox4.Text;
                z.Sait = textBox6.Text;
                z.Elec = textBox7.Text;
                //
                z.Bank = textBox8.Text;
                z.Bik = maskedTextBox5.Text;
                z.Kc = maskedTextBox6.Text;
                z.Rc = maskedTextBox7.Text;
                z.Fio_ruk = textBox12.Text;
                z.Fio_eco = textBox13.Text;
                //
                Rek_box.Text = z.ToString();
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

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maskedTextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public class Rekvz
        {
            DateTime now = DateTime.Today;
            public string naz_org;
            public string inn;
            public string kpp;
            public string adres;
            public string telephone;
            public string sait;
            public string elec;
            //
            public string bank;
            public string bik;
            public string kc;
            public string rc;
            public string fio_ruk;
            public string fio_eco;

            public string Naz_org
            {
                get
                {
                    return naz_org;
                }
                set
                {
                    naz_org = value;
                }
            }

            public string Inn
            {
                get
                {
                    return inn;
                }
                set
                {
                    inn = value;
                }
            }

            public string Kpp
            {
                get
                {
                    return kpp;
                }
                set
                {
                    kpp = value;
                }
            }

            public string Adres
            {
                get
                {
                    return adres;
                }
                set
                {
                    adres = value;
                }
            }

            public string Telephone
            {
                get
                {
                    return telephone;
                }
                set
                {
                    telephone = value;
                }
            }

            public string Sait
            {
                get
                {
                    return sait;
                }
                set
                {
                    sait = value;
                }
            }

            public string Elec
            {
                get
                {
                    return elec;
                }
                set
                {
                    elec = value;
                }
            }

            public string Bank
            {
                get
                {
                    return bank;
                }
                set
                {
                    bank = value;
                }
            }

            public string Bik
            {
                get
                {
                    return bik;
                }
                set
                {
                    bik = value;
                }
            }

            public string Kc
            {
                get
                {
                    return kc;
                }
                set
                {
                    kc = value;
                }
            }

            public string Rc
            {
                get
                {
                    return rc;
                }
                set
                {
                    rc = value;
                }
            }

            public string Fio_ruk
            {
                get
                {
                    return fio_ruk;
                }
                set
                {
                    fio_ruk = value;
                }
            }

            public string Fio_eco
            {
                get
                {
                    return fio_eco;
                }
                set
                {
                    fio_eco = value;
                }
            }

            // вывод в "Полис"
            public override string ToString()
            {

                string info = "Карточка предприятия\tДата: " + now.ToShortDateString() + "\n\nНазвание организации: " + Naz_org + "\nИНН: " + Inn + "\nКПП: " + Kpp + "\nАдрес: " + Adres + "\nТелефон: " + Telephone + "\nСайт организации: " + Sait + "\nЭлектронная почта: " + Elec + "\nБанк: " + Bank + "\nБик: " + Bik + "\nк/с: " + Kc + "\nр/с: " + Rc + "\nФИО руководителя: " + Fio_ruk + "\nФИО экономиста: " + Fio_eco;
                return info;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try // Проверка.
            {
                FontDialog fn = new FontDialog();
                if (fn.ShowDialog() == DialogResult.OK)
                {
                    Rek_box.Font = fn.Font;
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

        private void button2_Click(object sender, EventArgs e)
        {
            try // Проверка.
            {
                Rek_box.Clear();
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

        private void button3_Click(object sender, EventArgs e)
        {
            try // Проверка.
            {
                saveFileDialog1.DefaultExt = "*.rtf";
                saveFileDialog1.Filter = "RTF Files|*.rtf";

                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && // условие если.
                        saveFileDialog1.FileName.Length > 0)
                {
                    Rek_box.SaveFile(saveFileDialog1.FileName);
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

        private void Rek_box_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = Rek_box.Text.Length != 0;
            button2.Enabled = Rek_box.Text.Length != 0;
            button3.Enabled = Rek_box.Text.Length != 0;
            button5.Enabled = Rek_box.Text.Length == 0;
            textBox2.Enabled = Rek_box.Text.Length == 0;
            maskedTextBox2.Enabled = Rek_box.Text.Length == 0;
            maskedTextBox3.Enabled = Rek_box.Text.Length == 0;
            textBox4.Enabled = Rek_box.Text.Length == 0;
            maskedTextBox4.Enabled = Rek_box.Text.Length == 0;
            textBox6.Enabled = Rek_box.Text.Length == 0;
            textBox7.Enabled = Rek_box.Text.Length == 0;
            textBox8.Enabled = Rek_box.Text.Length == 0;
            maskedTextBox5.Enabled = Rek_box.Text.Length == 0;
            maskedTextBox6.Enabled = Rek_box.Text.Length == 0;
            maskedTextBox7.Enabled = Rek_box.Text.Length == 0;
            textBox12.Enabled = Rek_box.Text.Length == 0;
            textBox13.Enabled = Rek_box.Text.Length == 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rekvizityBindingSource.EndEdit();
            this.rekvizityTableAdapter.Update(this.typographyDataSet7.rekvizity);
            dataGridView1.Refresh();
        }

        private void Form13_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form3 main = this.Owner as Form3;
            if (main != null)
            {
                main.button17.Enabled = true;
                main.button18.Enabled = true;
            }

        }
    }
}

