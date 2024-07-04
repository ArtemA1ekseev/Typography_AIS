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
    public partial class Form30 : Form
    {
        public Form30()
        {
            InitializeComponent();
        }

        private void Form30_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "TypographyDataSet9._3Kvit". При необходимости она может быть перемещена или удалена.
            this._3KvitTableAdapter.Fill(this.TypographyDataSet9._3Kvit);
            this.reportViewer1.RefreshReport();
        }
    }
}
