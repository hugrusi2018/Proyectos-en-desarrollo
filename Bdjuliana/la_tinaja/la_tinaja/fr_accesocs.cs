using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace la_tinaja
{
    public partial class fr_acceso : Form
    {
        public fr_acceso()
        {
            InitializeComponent();

        }
        int carg;//carga intentos
        int load;//
        bool trufal=false; // para bloquear usuario
        bool est=false;// activacion del user
        bool desp = false;//para el desplazamiento form
        bool recupera = false;//recuperar contraseña
        



        //abrir conexion de la base de datos
        SqlConnection tinajita = new SqlConnection("Data Source=Localhost\\lada; Initial Catalog=Latinaja;Integrated Security=SSPI");

        void actin()

        {
            SqlCommand actvo = new SqlCommand("select * from login where Usuario='" + txt_user.Text + "' and Estado=0", tinajita);
            tinajita.Open();
            SqlDataReader Execut = actvo.ExecuteReader();

            if (Execut.Read())
            {
                MessageBox.Show("EL USUARIO SE ENCUENTRA BLOQUEADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                est = true;

            
            }
            tinajita.Close();
        }
        void cargar()// cargar intentos para validar usuarios
        {
            SqlCommand acceso = new SqlCommand("select * from Pacceso",tinajita);

            tinajita.Open();
            SqlDataReader ejecute = acceso.ExecuteReader();
            if (ejecute.Read()) 
            {
                carg = Convert.ToInt32(ejecute.GetValue(1));
                load = Convert.ToInt32(ejecute.GetValue(1));
            }
            tinajita.Close();

        }

        void usuario()//valida el usuario
        { 
            
         
                SqlCommand validar = new SqlCommand("select * from login where Usuario='" + txt_user.Text + "'", tinajita);
                tinajita.Open();
                SqlDataReader ejecute = validar.ExecuteReader();

                    

                    if (ejecute.Read() == true)
                    {
                        txt_pasw.Enabled = true;
                        txt_pasw.Focus();
                        tinajita.Close();
                    }
                    else
                    {
                        carg -= 1;
                        MessageBox.Show("USUARIO NO VÁLIDO", "INTENTO " + carg + " DE " + load);
                        txt_user.Focus();
                        txt_user.Text = "";

                        if (carg == 0)
                        {
                            MessageBox.Show("GOOD BYE !", "INTENTOS AGOTADOS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            Application.Exit();
                        }

                    }
                
            tinajita.Close();
        } 

        void contraseña()//valida usuario y contraseño y el bloqueo
        {
            tinajita.Open();//abrir conexion
            //abrir comando
            SqlCommand acceso = new SqlCommand("select * from login where Usuario='" + txt_user.Text + "'and Contraseña='" + txt_pasw.Text + "'", tinajita);
            //ejecutar comando
            SqlDataReader ejecute = acceso.ExecuteReader();



            //validar el comando
            if (ejecute.Read() == true)
            {
                fr_menu menu = new fr_menu();
                string envuser = txt_user.Text;//agregr nombre useer
                menu.nomuser = envuser; // llamar usuario
                MessageBox.Show("WELCOME");
                
                menu.Show();
                this.Hide();
            }
            else
            {

                //que me cuente los intentos 
                carg -= 1;
                MessageBox.Show("ACCESO DENEGADO", "INTENTO: " + carg + " DE " + load);

                txt_pasw.Focus();

                txt_pasw.Text = "";



                if (carg == 0) //que me valide cuantos intentos son
                {
                    trufal = true;
                                                
                }

            }
            tinajita.Close();
        
        
        
        }

        void bloqueo()//blopquea los usuarios
        {
            tinajita.Open();
            SqlCommand bloq = new SqlCommand("update login set Estado =@EST where Usuario='" + txt_user.Text + "'", tinajita);
            bloq.Parameters.AddWithValue("EST", 0);//agregar el valor al campo
            bloq.ExecuteNonQuery();//ejecutar
            tinajita.Close();

            MessageBox.Show("EL USUARIO QUE DIGITO HA SIDO BLOQUEADO","ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);

            Application.Exit();


        }


        void cargarpreg()//carga el combo box de la preguntas

        {
            SqlCommand preg = new SqlCommand("select upper(Pregunta) as Pregunta from preguntas", tinajita);
            tinajita.Open();
            SqlDataReader ejecute = preg.ExecuteReader();

            while (ejecute.Read())
            {
                cb_preg.Items.Add(ejecute.GetString(ejecute.GetOrdinal("Pregunta")));

            }
            tinajita.Close();


                  
        }


        void recuperarcontra()//valida que el usuario este activo para recuperar la contraseña

           {
            SqlCommand recupe=new SqlCommand("select * from login where Usuario='" + txt_user.Text +"' and Estado=1 ",tinajita);
            tinajita.Open();

            SqlDataReader exec = recupe.ExecuteReader();
            if (exec.Read())
            {
                recupera = true;


            }
            else
            
            {
                if (txt_user.Text == "")
                {
                    MessageBox.Show("DEBE INGRESAR EL USUARIO EN EL CAMPO DE USUARIO", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_user.Focus();
                }
                else
                {
                    MessageBox.Show("EL USUARIO SE ENCUENTRA BLOQUEADO O NO EXISTE", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_user.Focus();
                    txt_user.Clear();

                }
            }
            tinajita.Close();
            }


        void validarcontra()//valida usuário pregunta y respuesta para cargar el formulario de cambio de contraseña
        {
            SqlCommand valid = new SqlCommand("select * from login where Usuario='" + txt_user.Text + "' and Pregunta='" + cb_preg.Text + "' and Respuesta='" + txt_resp.Text + "'", tinajita);
            tinajita.Open();
            SqlDataReader ejecutar = valid.ExecuteReader();

            if (ejecutar.Read())
            {
                cb_preg.Items.Clear();
                cb_preg.Text = null;
                txt_resp.Clear();
                this.Height -= 130;
                desp = false;
                bt_acep.Enabled = true;
                bt_canc.Enabled = true;
                fr_cambiocontraseña form = new fr_cambiocontraseña();
                string enuser = txt_user.Text;
                form.reciuser = enuser;
                form.ShowDialog();

            }
            else
            {
                carg -= 1;
                MessageBox.Show("ACCESO DENEGADO", "INTENTO: " + carg + " DE " + load);
                if (carg != 0)
                {
                    MessageBox.Show("VERIFIQUE LA INFORMACION REGISTRADA", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (carg == 0) //que me valide cuantos intentos son
                {
                    trufal = true;


                }
                
            }
            tinajita.Close();

                   
        }


        void bloqueoform()
        {
            SqlCommand valid = new SqlCommand("select estado from Pacceso where estado=0", tinajita);
            tinajita.Open();
            SqlDataReader ejecutar = valid.ExecuteReader();

            if (ejecutar.Read())
            {
                MessageBox.Show("EL ADMINISTRADOR HA SUSPENDIDO EL ACCESO AL SISTEMA \n POR FAVOR INTENTE MAS TARDE", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_user.Enabled = false;
                txt_pasw.Enabled = false;
                pt_opt.Enabled = false;
                bt_acep.Enabled = false;
                bt_canc.Enabled=false;

               
            }
            tinajita.Close();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();//cerrar la aplicacion

        }
         
   

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

      

        private void txt_user_KeyDown(object sender, KeyEventArgs e)
        {



            if (e.KeyCode == Keys.Enter)
            {
                
                actin();
                if (est == true)
                {

                    usuario();
                    est = false;

                }
                

            }
        }

        private void fr_acceso_Load(object sender, EventArgs e)
        {
          
            bt_salir.Text = "&X";
            bloqueoform();
            lb_tit.Location = new Point((this.Width/2)-(lb_tit.Width/2),10);

            cargar();//intentos
            ToolTip opt = new ToolTip();
            opt.ShowAlways = true;
            opt.SetToolTip(this.pt_opt, "OPCIONES");
            opt.SetToolTip(this.pt_aceptar, "ACEPTAR");
            opt.SetToolTip(this.pt_canc, "CANCELAR");

            pt_opt.Cursor = Cursors.Hand;
           
        }

        private void txt_pasw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                contraseña();

                if (trufal == true) //activacion del usuario
                {
                    bloqueo();
                    trufal = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_pasw.Enabled == true)
            {
                contraseña();
            }
            else
            {
                MessageBox.Show("VALIDE PRIMERO SU USUARIO", "INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);            
            }
        }

        private void txt_user_KeyPress(object sender, KeyPressEventArgs e)//validar las teclas
        {
                            //numeros                           mayusculas                            minusculas                            enter            simbolo de punto   guion bajo         borrar               suprimir
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 13) || (e.KeyChar == 46) || (e.KeyChar == 95) || (e.KeyChar == 8) || (e.KeyChar == 127))

            {
                e.Handled = false; 

            }
            else
            {
            
                e.Handled=true;
            }
        }

        private void txt_pasw_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pasw_KeyPress(object sender, KeyPressEventArgs e)
        {   
                                 //numeros                           mayusculas                            minusculas                            enter                 borrar               suprimir
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 13)  || (e.KeyChar == 8) || (e.KeyChar == 127))
            {
                e.Handled = false;

            }
            else
            {

                e.Handled = true;
            }
        }

        private void pt_opt_Click(object sender, EventArgs e)// valida si el ususario es correcto o esta activo para darle la opcion de recuperar la contraseña
        {
            recuperarcontra();
            if (recupera == true)
            {

                if (desp == false)
                {

                    DialogResult respu = MessageBox.Show("DESEA RECUPERAR SU CONTRASEÑA", "INFORMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respu == DialogResult.Yes)
                    {

                        if (desp == false)
                        {

                            this.Height += 130;
         
                            desp = true;
                            MessageBox.Show(" 1. SELECCIONE UNA DE LAS PREGUNTAS DEL CAMPO PREGUNTA \n 2. ESCRIBE TU RESPUESTA \n 3. PRESIONA EL BOTON ACEPTAR", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bt_acep.Enabled = false;
                            bt_canc.Enabled = false;
                            cargarpreg();

                        }

                    }
                }
                else
                {
                    cb_preg.Items.Clear();
                    cb_preg.Text = null;
                    txt_resp.Clear();
                    this.Height -= 130;
                    desp = false;
                    bt_acep.Enabled = true;
                    bt_canc.Enabled = true;
            
                }
            }
            recupera = false;
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txt_user.Text != "" && cb_preg.Text != "" && txt_resp.Text != "")
            {

                validarcontra();// valida el usuario y los intentos
                if (trufal == true)
                {

                    bloqueo();
                    trufal = false;

                }
                    

            }
            else 
            {

                MessageBox.Show("VERIFIQUE LOS CAMPOS USUARIO, PREGUNTA Y RESPUESTA", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void pt_canc_Click(object sender, EventArgs e)
        {
            cb_preg.Items.Clear();
            cb_preg.Text = null;
            txt_resp.Clear();
            this.Height -= 130;
            desp = false;
            bt_acep.Enabled = true;
            bt_canc.Enabled = true;
            
        }

        private void txt_resp_TextChanged(object sender, EventArgs e)
        {
            txt_resp.Text = txt_resp.Text.ToUpper();
            txt_resp.SelectionStart = txt_resp.Text.Length;

        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_resp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //numeros                           mayusculas                            minusculas                            enter                 borrar               suprimir
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 13) || (e.KeyChar == 8) || (e.KeyChar == 127))
            {
                e.Handled = false;

            }
            else
            {

                e.Handled = true;
            }
        }

      
       
       
    }
}
