using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BdInventario
{
    public partial class Plantiparam : Form
    {
        public Plantiparam()
        {
            InitializeComponent();
        }

        private void Plantillaparametros_Load(object sender, EventArgs e)
        {
            this.Text = " ";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}