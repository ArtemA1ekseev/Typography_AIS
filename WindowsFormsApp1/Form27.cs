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
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.prod3TableAdapter.Fill(this.typographyDataSet5.prod3, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(cToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cToolStripTextBox.Text = "";
            dToolStripTextBox.Text = "";
        }

        private void Form27_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form22 main = this.Owner as Form22;
            if (main != null)
            {
                main.button10.Enabled = true;
            }
        }
    }
}
