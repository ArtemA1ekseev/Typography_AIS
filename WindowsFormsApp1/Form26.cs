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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.prod2TableAdapter.Fill(this.typographyDataSet5.prod2, new System.Nullable<int>(((int)(System.Convert.ChangeType(bToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bToolStripTextBox.Text = "";
        }

        private void Form26_FormClosing(object sender, FormClosingEventArgs e)
        { 
            Form20 main = this.Owner as Form20;
            if (main != null)
            {
                main.button7.Enabled = true;
            }
        }
    }
}
