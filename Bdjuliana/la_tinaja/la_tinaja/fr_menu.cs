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
    public partial class fr_menu : Form
    {
        public fr_menu()
        {
            InitializeComponent();
        }

        public string nomuser;
        
       
        private void fr_menu_Load(object sender, EventArgs e)
        {
            lb_user.Text = nomuser;

            ToolTip tool_menu = new ToolTip();


        }

        private void tm_hora_Tick(object sender, EventArgs e)


            //menu pedido
        {


            if (lb_menuped.Top > 78)   //para que suba la imagen
            {
                if (lb_menuped.Left <= 370)//distancia borde objeto y formulario
                {
                    lb_menuped.Top -= 1;
                }
            }

            if (lb_menuped.Top <= 78)
            {
                if (lb_menuped.Left <= 870)//para que vaya a la derecha
                {
                    lb_menuped.Left += 1;
                }
            }
            if (lb_menuped.Left >= 870) //para que vaya hacia abajo
            {
                if (lb_menuped.Top <= 559)
                {
                    lb_menuped.Top += 1;
                }
            }
            if (lb_menuped.Left > 370)  //para que vaya hacia la izquierda
            {
                if (lb_menuped.Top >= 559)
                {
                    lb_menuped.Left -= 1;
                }
            }

            //menu seguridad

            if (lb_menuseg.Top > 78)   //para que suba la imagen
            {
                if (lb_menuseg.Left <= 370)//distancia borde objeto y formulario
                {
                    lb_menuseg.Top -= 1;
                }
            }

            if (lb_menuseg.Top <= 78)
            {
                if (lb_menuseg.Left <= 870)//para que vaya a la derecha
                {
                    lb_menuseg.Left += 1;
                }
            }
            if (lb_menuseg.Left >= 870) //para que vaya hacia abajo
            {
                if (lb_menuseg.Top <= 559)
                {
                    lb_menuseg.Top += 1;
                }
            }
            if (lb_menuseg.Left > 370)  //para que vaya hacia la izquierda
            {
                if (lb_menuseg.Top >= 559)
                {
                    lb_menuseg.Left -= 1;
                }
            }


            //menu administracion

            if (lb_menuadmin.Top > 78)   //para que suba la imagen
            {
                if (lb_menuadmin.Left <= 370)//distancia borde objeto y formulario
                {
                    lb_menuadmin.Top -= 1;
                }
            }

            if (lb_menuadmin.Top <= 78)
            {
                if (lb_menuadmin.Left <= 870)//para que vaya a la derecha
                {
                    lb_menuadmin.Left += 1;
                }
            }
            if (lb_menuadmin.Left >= 870) //para que vaya hacia abajo
            {
                if (lb_menuadmin.Top <= 559)
                {
                    lb_menuadmin.Top += 1;
                }
            }
            if (lb_menuadmin.Left > 370)  //para que vaya hacia la izquierda
            {
                if (lb_menuadmin.Top >= 559)
                {
                    lb_menuadmin.Left -= 1;
                }
            }


            //menu parametros


            if (lb_menupara.Top > 78)   //para que suba la imagen
            {
                if (lb_menupara.Left <= 370)//distancia borde objeto y formulario
                {
                    lb_menupara.Top -= 1;
                }
            }

            if (lb_menupara.Top <= 78)
            {
                if (lb_menupara.Left <= 870)//para que vaya a la derecha
                {
                    lb_menupara.Left += 1;
                }
            }
            if (lb_menupara.Left >= 870) //para que vaya hacia abajo
            {
                if (lb_menupara.Top <= 559)
                {
                    lb_menupara.Top += 1;
                }
            }
            if (lb_menupara.Left > 370)  //para que vaya hacia la izquierda
            {
                if (lb_menupara.Top >= 559)
                {
                    lb_menupara.Left -= 1;
                }
            }




        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pt_pedido_DoubleClick(object sender, EventArgs e)
        {
            fr_pedido pedido = new fr_pedido();
            pedido.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        private void lb_menuped_MouseEnter(object sender, EventArgs e)   //darle stop a la imagen de pedidos
        {
            tm_movimiento.Enabled = false;
            lb_menuped.Size = new Size(lb_menuped.Width + 20, lb_menuped.Height + 20);

        }


        private void lb_menuped_MouseLeave(object sender, EventArgs e) //darle movimiento a la imagen de pedidos
        {
            tm_movimiento.Enabled = true;
            lb_menuped.Size = new Size(lb_menuped.Width - 20, lb_menuped.Height - 20);
        }

       

        private void tm_hora_Tick_1(object sender, EventArgs e)
        {

            lb_fecha.Text = Convert.ToString(DateTime.Now);
        }

        private void lb_menuadmin_MouseEnter(object sender, EventArgs e)  //darle stop a la imagen de admin
        {
            tm_movimiento.Enabled = false;
            lb_menuadmin.Size = new Size(lb_menuadmin.Width +20, lb_menuadmin.Height + 20);//para que la imagen sobresalga
        }

        private void lb_menuadmin_MouseLeave_1(object sender, EventArgs e)
        {
            tm_movimiento.Enabled = true;
            lb_menuadmin.Size = new Size(lb_menuadmin.Width - 20, lb_menuadmin.Height - 20);
        }

        private void lb_menuseg_MouseEnter_1(object sender, EventArgs e) //darle stop a la imagen de seguridad
        {
            tm_movimiento.Enabled = false;
            lb_menuseg.Size = new Size(lb_menuseg.Width + 20, lb_menuseg.Height + 20);

        }


        private void lb_menuseg_MouseLeave(object sender, EventArgs e)   //darle movimiento a la imagen de seguridad
        {
            tm_movimiento.Enabled = true;
            lb_menuseg.Size = new Size(lb_menuseg.Width - 20, lb_menuseg.Height - 20);//para que la imagen se esconda

        }

     
        private void lb_menupara_MouseEnter(object sender, EventArgs e)
        {
            tm_movimiento.Enabled = false;
            lb_menupara.Size = new Size(lb_menupara.Width + 20, lb_menupara.Height + 20);
        
        }


        private void lb_menupara_MouseLeave_1(object sender, EventArgs e)
        {
            tm_movimiento.Enabled = true;
            lb_menupara.Size = new Size(lb_menupara.Width - 20, lb_menupara.Height - 20);
        }

        private void lb_menuped_Click(object sender, EventArgs e)
        {
            fr_pedido fped = new fr_pedido();
            fped.nomuserr = nomuser;
            fped.Show();

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lb_menupara_Click(object sender, EventArgs e)
        {
            fr_parametros para = new fr_parametros();
            para.Show();

        }

    

    }
}
