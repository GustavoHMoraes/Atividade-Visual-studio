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
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x, t, i;
            x = Convert.ToDouble(txtx.Text);
            i = 1;
            for (i = 0; i <= 10; i++)
            {
                t = x * i;
                txtr.Text = String.Concat(txtr.Text, "\r\n", x.ToString() + "x" + i.ToString() + "=" + t.ToString());
            }
        }

        private void btnw_Click(object sender, EventArgs e)
        {
            double x, t, i;
            x = Convert.ToDouble(txtx.Text);
            i = 1;
            while (i <= 10)
            {
                t = x * i;
                txtr.Text = String.Concat(txtr.Text, "\r\n", x.ToString() + "x" + i.ToString() + "=" + t.ToString());
                i++;
            }
    }

        private void btndw_Click(object sender, EventArgs e)
        {
            double x, t, i;
            x = Convert.ToDouble(txtx.Text);
            i = 1;
            do
            {
                t = x * i;
                txtr.Text = String.Concat(txtr.Text, "\r\n", x.ToString() + "x" + i.ToString() + "=" + t.ToString());
                i++;
            } while (i <= 10);
        }

        private void btnv_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu var = new frmmenu();
            var.Show();
        }

        private void btnl_Click(object sender, EventArgs e)
        {
            txtr.Clear();
            txtx.Clear();
            txtx.Focus();
        }
    }
    }
