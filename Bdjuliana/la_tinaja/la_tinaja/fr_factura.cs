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
    public partial class fr_factura : Form
    {
        public fr_factura()
        {
            InitializeComponent();
        }

        private void fr_factura_Load(object sender, EventArgs e)
        {
            ToolTip printe = new ToolTip();
            printe.ShowAlways = true;
            printe.SetToolTip(this.pt_factprint, "IMPRIMIR");
            printe.SetToolTip(this.pt_factcan, "SALIR");
        }

        private void pt_ccte_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lb_fchfac_Click(object sender, EventArgs e)
        {

        }

        private void tm_horafac_Tick(object sender, EventArgs e)
        {
            lb_fchfac.Text =Convert.ToString(DateTime.Now);
        }
    }
}
