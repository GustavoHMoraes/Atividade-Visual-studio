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
    }
}
