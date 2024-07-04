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
    public partial class Form1 : Form
    {
        // Описание полей класса.

        public Form1()
        {
            InitializeComponent();
        }

            // Процедура нажатия на кнопку "Завершить программу".
            private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            {
                try // Проверка.
                {
                    if (MessageBox.Show("Вы уверены, что хотите закрыть программу?\n\nВнимание!\nЕсли вы выбрали 'Перезапуск ПО', то вне зависимости от выбора программа будет перезагружена!", "Закрыть", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No) // Проверка.
                        e.Cancel = true;
                    else // условие тогда.
                        e.Cancel = false;
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try // Проверка.
            {
                Application.Exit();
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

        private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msgtext = "test@gmail.com";
            if (MessageBox.Show("Нажмите «ОК» чтобы скопировать адрес и перейти на Gmail почту: " + msgtext + "." + " Нажмите «ОТМЕНА» для закрытия диалогового окна.", "Связаться с разработчиком", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            { Clipboard.SetText(msgtext); System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/#inbox?compose=new"); }
            }

        private void оНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Данная программа — совокупность программно-аппаратных средств, предназначенных для автоматизации деятельности, связанной с хранением, передачей и обработкой информации. Областью применения является компания ООО «PolyCraft». Отраслью деятельности, которой является полиграфия. Типография занимается производством карманных календарей, визиток, плакатов, буклетов разных цветов и размеров, разной плотности бумаги и видов печати. Программа разработана под 32/64 битную операционную систему Windows XP и может использоваться данной операционной системой или выше.\n\nДанное программное обеспечение разработал Алексеев Артем Александрович. \n\nНазвание:  АИС типографии ООО «PolyCraft». \n\nАвторские права: Copyright ©  2021. \n\nВерсия сборки: 1.0.0.7 \n\nИдентификатор GUID: 7bf94522-2ab6-4e2e-95ee-0d396a6680ae. \n\nНейтральный язык: Русский (Россия).",
            "Информация",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.Show();
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 Form5 = new Form5();
            Form5.Show();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.Show();
        }

        private void материалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 Form7 = new Form7();
            Form7.Show();
        }

        private void видПечатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.Show();
        }

        private void сосToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 Form9 = new Form9();
            Form9.Show();
        }
        private void видыЗаказчиковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 Form10 = new Form10();
            Form10.Show();
        }

        private void видыОплатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 Form11 = new Form11();
            Form11.Show();
        }

        private void реквизитыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
        }

        private void наименованияПродукцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 Form12 = new Form12();
            Form12.Show();
        }

        private void состояниеГотовностиЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 Form14 = new Form14();
            Form14.Show();
        }

        private void перезагрузкаПОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try // Проверка.
            {
                Application.Restart();
                Environment.Exit(0);
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

        private void продукцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 Form16 = new Form16();
            Form16.Show();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form18 Form18 = new Form18();
            Form18.Show();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form20 Form20 = new Form20();
            Form20.Show();
        }

        private void макетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form22 Form22 = new Form22();
            Form22.Show();
        }

        private void столбчатаяДиаграмма1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form23 Form23 = new Form23();
            Form23.Show();
        }

        private void столбчатаяДиаграмма2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form24 Form24 = new Form24();
            Form24.Show();
        }

        private void отчетОЗаказахВРазрезеКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form28 Form28 = new Form28();
            Form28.Show();
        }

        private void отчетОбУслугахВыполненныхЗаОдинДеньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form29 Form29 = new Form29();
            Form29.Show();
        }

        private void отчетОСостоянииКонкретногоЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form30 Form30 = new Form30();
            Form30.Show();
        }

        private void отчетОГотовыхЗаказахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Запускаем нужный файл
                System.Diagnostics.Process.Start("C:\\Users\\arste\\Desktop\\ДИПЛОМ (ПО)\\Моя программа\\Версия (1.0.0.7)\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\ДОГОВОР.dot");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
