using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace la_tinaja
{
    public partial class fr_parametros : Form
    {
        public fr_parametros()
        {
            InitializeComponent();
        }

        private void fr_parametros_Load(object sender, EventArgs e)
        {
     


        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menupedido_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            fr_pacceso para = new fr_pacceso();
            para.Show();
        }
    }
}