using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gustavo_Rocillo_e_Carlos
{
    public partial class frm2 : Form
    {
        double c1 = 0, c2 = 0, c3 = 0, v, t, pc;

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu var = new frmmenu();
            var.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            c1 = 0;
            c2 = 0;
            c3 = 0;

            txtv.Clear();
            txtg.Clear();
            txtv.Focus();
        }

        private void btnacabar_Click(object sender, EventArgs e)
        {
            t = c1 + c2 + c3;

            if (c1 > c2 && c1 > c3)
            {
               pc = (100 * c1) / t;
                txtg.Text = "O ganhador é José da Silva com " + c1 + " votos. Total de votos: " + t + " .E com " + pc + "%";
            }
            if (c2 > c1 && c2 > c3)
            {
                pc = (100 * c2) / t;
                txtg.Text = "O ganhador é Maria Juruma com " + c2 + " votos. Total de voto: " + t + " .E com " + pc + "%";
            }
            if (c3 > c2 && c3 > c1)
            {
                pc = (100 * c3) / t;
                txtg.Text = "O ganhador é João da tapioca com " + c3 + " votos. Total de votos: " + t + " .E com " + pc + "%";
            }
        }

        public frm2()
        {
            InitializeComponent();

        }

        private void btnvotar_Click(object sender, EventArgs e)
        {
            v = Convert.ToDouble(txtv.Text);



            if (v == 1)
                c1++;
            if (v == 2)
                c2++;
            if (v == 3)
                c3++;
            txtv.Clear();
            txtv.Focus();

        }
    }
}
