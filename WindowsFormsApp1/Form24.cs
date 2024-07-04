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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            pRODTableAdapter.Fill(typographyDataSet3.PROD);
            chart1.Series["Стоимость продукции (в рублях)"].XValueMember = (typographyDataSet3.PROD.Columns[2]).ToString();
            chart1.Series["Стоимость продукции (в рублях)"].YValueMembers = (typographyDataSet3.PROD.Columns[7]).ToString();
            chart1.DataBind();
        }

        private void Form24_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "typographyDataSet3.PROD". При необходимости она может быть перемещена или удалена.
            this.pRODTableAdapter.Fill(this.typographyDataSet3.PROD);

        }
    }
}
