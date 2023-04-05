using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gustavo_Rocillo_e_Carlos
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double l, t;
            string c;


            l = Convert.ToDouble(txtl.Text);
            c = Convert.ToString(txtc.Text);

            if (c == "G")
            {
                if (l <= 20)
                {
                    t = l * 5.28;
                    txtt.Text = "R$" + t;
                }
                else
                {
                    t = l * 5.17;
                    txtt.Text = "R$" + t;
                }

            }
            if (c == "A")
            {
                if (l <= 20)
                {
                    t = l * 4.753;
                    txtt.Text = "R$" + t;
                }
                else
                {
                    t = l * 4.655;
                    txtt.Text = "R$" + t;
                }
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu var = new frmmenu();
            var.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtc.Clear();
            txtl.Clear();  
            txtt.Clear();
            txtc.Focus();
        }

        private void txtc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
