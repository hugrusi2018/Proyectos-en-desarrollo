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
    public partial class fr_pedido : Form
    {
        public fr_pedido()
        {
            InitializeComponent();
        }

        public string nomuserr;

        private void Menupedido_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
          
        }

        private void fr_pedido_Load(object sender, EventArgs e)
        {
            lb_user.Text = nomuserr;
                
                //determina el tamaño y la posicion del tabControl de pedidos "tc_pedidos"
            tc_pedidos.Width = this.Width - 35;
            tc_pedidos.Height = this.Height - 105;
            tc_pedidos.Location = new Point(10, 78);

         // determina el tamaño y la posicion del tab control de comidas "tc_comidas" dentro de "tc_pedidos"
            tc_comidas.Parent = tp_pedido; //determina el padre de salida de tc_comidas "Donde va a salir"
            tc_comidas.Location = new Point(700, 10);
            tc_comidas.Height =tc_pedidos.Height-55;
            tc_comidas.Width = tc_pedidos.Width-720;

            ToolTip print = new ToolTip();//determina la opcion de colocar una descripcion encima de una imagen
            print.ShowAlways = true;
            print.SetToolTip(this.pt_pedprint, "IMPRIMIR");
            print.SetToolTip(this.pt_atras, "Atras");
            print.SetToolTip(this.pt_primero, "Primero");
            print.SetToolTip(this.pt_siguiente, "Siguiente");
            print.SetToolTip(this.pt_ultimo, "Ultimo");
            print.SetToolTip(this.pt_aceptar, "Aceptar");
            print.SetToolTip(this.pt_cancel, "Cancelar");
            print.SetToolTip(this.pt_pedg, "GUARDAR");
            print.SetToolTip(this.pt_pdcan, "CANCELAR");



            
        }

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.Close();

                

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }
 
        public  void  bt_pedido_Click_1(object sender, EventArgs e)
        {
           
        }

        private void pn_centro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((string)cb_servicio.SelectedItem == "Almuerzo")
            {
                cb_comida.Items.Add("Sopas");
                cb_comida.Items.Add("Principios");
                cb_comida.Items.Add("Ensalada");
                cb_comida.Items.Add("Bebida");
                tm_servicio.Enabled = false;
            }

            if ((string)cb_servicio.SelectedItem == "Desayuno")
            {
                cb_comida.Items.Add("Fruta");
                cb_comida.Items.Add("Bebida");
                cb_comida.Items.Add("Ensalada");
                cb_comida.Items.Add("Bebida");
                tm_servicio.Enabled = false;
            }

            if ((string)cb_servicio.SelectedItem == "Cena")
            {
                cb_comida.Items.Add("Sopas");
                cb_comida.Items.Add("Entradas");
                cb_comida.Items.Add("Especiales");
                cb_comida.Items.Add("Plato fuerte");
                tm_servicio.Enabled = false;
            }

            if ((string)cb_servicio.SelectedItem == "Otros")
            {
                cb_comida.Items.Add("Sopas");
                cb_comida.Items.Add("Principios");
                cb_comida.Items.Add("Bebida");
                cb_comida.Items.Add("Fruta");
                cb_comida.Items.Add("Ensalada");
                tm_servicio.Enabled = false;
               
            }
            
        }

        private void bt_cliente_Click(object sender, EventArgs e)
        {
            
        }

        private void tp_combos_Click(object sender, EventArgs e)
        {

        }

        private void cb_servicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void tp_pedido_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void tp_clientes_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        
        private void txt_cedula_KeyDown(object sender, KeyEventArgs e)// ennter en texboox
        
        {
         
            if (e.KeyCode == Keys.Enter)

                {
                    MessageBox.Show("Buscar Este Cliente", "ADVERTENCIA");
                    bt_registrar.Focus();
                        
            }

        }

        private void txt_cedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_registrar_Click(object sender, EventArgs e)
        {
            DialogResult cte = MessageBox.Show("El Cliente No Existe, Desea Registrar Este Cliente","MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cte == DialogResult.No)
            {
                return;

            }

            cliente rcte = new cliente();
            rcte.ShowDialog();
            
        }

        private void pt_pedprint_Click(object sender, EventArgs e)
        {
            fr_factura fact = new fr_factura();
            fact.ShowDialog();

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
