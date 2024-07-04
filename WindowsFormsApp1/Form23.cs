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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void Form23_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet4.zakazi". При необходимости она может быть перемещена или удалена.
            this.zakaziTableAdapter.Fill(this.typographyDataSet4.zakazi);

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            zakaziTableAdapter.Fill(typographyDataSet4.zakazi);
            chart1.Series["Количество единиц продукции"].XValueMember = (typographyDataSet4.zakazi.Columns[3]).ToString();
            chart1.Series["Количество единиц продукции"].YValueMembers = (typographyDataSet4.zakazi.Columns[8]).ToString();
            chart1.DataBind();
        }
    }
}
