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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet4.vid_zakazchika". При необходимости она может быть перемещена или удалена.
            this.vid_zakazchikaTableAdapter.Fill(this.typographyDataSet4.vid_zakazchika);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet11.klienti". При необходимости она может быть перемещена или удалена.
            this.klientiTableAdapter.Fill(this.typographyDataSet11.klienti);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Form19 Form19 = new Form19();
                DialogResult result = MessageBox.Show(
                "Нажмите 'Да', если хотите перейти к экспорту данных. Нажмите 'Нет', чтобы вернуться к редактированию данных. После перехода к экспорту редактировать данные будет нельзя!",
                "Внимание!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);

                if (result == DialogResult.Yes)
                {
                    Form19.Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == klientiBindingSource)
            {
                klientiBindingSource.Filter = "[fio] LIKE'" + textBox1.Text + "%'";
                this.dataGridView1.DataSource = klientiBindingSource;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klientiBindingSource.EndEdit();
            this.klientiTableAdapter.Update(this.typographyDataSet11.klienti);
            dataGridView1.Refresh();
        }
    }
}
