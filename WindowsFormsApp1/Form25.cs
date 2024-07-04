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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.prod1TableAdapter.Fill(this.typographyDataSet5.prod1, aToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            aToolStripTextBox.Text = "";
        }

        private void Form25_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form16 main = this.Owner as Form16;
            if (main != null)
            {
                main.button9.Enabled = true;
            }
        }
    }
} 
