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
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cliente_Load(object sender, EventArgs e)
        {
            ToolTip save = new ToolTip();
            save.BackColor = Color.SaddleBrown;
            
            save.ShowAlways = true;
            save.SetToolTip(this.pt_gcte,"GUARDAR");
            save.SetToolTip(this.pt_ccte, "CANCELAR");



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
