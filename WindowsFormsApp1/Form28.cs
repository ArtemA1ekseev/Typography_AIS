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
    public partial class Form28 : Form
    {
        public Form28()
        {
            InitializeComponent();
        }

        private void Form28_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "TypographyDataSet6.Otch1". При необходимости она может быть перемещена или удалена.
            this.Otch1TableAdapter.Fill(this.TypographyDataSet6.Otch1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "TypographyDataSet10._1Rek". При необходимости она может быть перемещена или удалена.
            this._1RekTableAdapter.Fill(this.TypographyDataSet10._1Rek);
            this.reportViewer1.RefreshReport();
        }
    }
}
