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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void algoritmo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm1 var = new frm1();
            var.Show();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void algoritmo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm2 var = new frm2();
            var.Show();
        }

        private void algoritmo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm3 var = new frm3();
            var.Show();
        }
    }
}
