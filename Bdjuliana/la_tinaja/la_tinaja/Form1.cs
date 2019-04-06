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
    public partial class fr_inicio : Form
    {
        public fr_inicio()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fr_acceso acceso = new fr_acceso();
            acceso.Show();
            this.Hide();
            tm_inicio.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
