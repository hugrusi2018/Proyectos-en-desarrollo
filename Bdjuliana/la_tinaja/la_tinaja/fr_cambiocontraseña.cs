using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;


namespace la_tinaja
{
    public partial class fr_cambiocontraseña : Form
    {
        public fr_cambiocontraseña()
        {
            InitializeComponent();
        }
        SqlConnection tinajita = new SqlConnection("Data Source=Localhost\\lada; Initial Catalog=Latinaja;Integrated Security=SSPI");
        
        public string reciuser;
        bool altf4 = false;




        void recibirusuario()
        {
            lb_users.Text = reciuser;//cargar el usuario en el formulario de cambio de contraseña
            
        }

        void llamaruser()
        {
            tinajita.Open();
            SqlCommand llamar = new SqlCommand("select * from login where Usuario='" + reciuser + "'", tinajita);
            SqlDataReader eje = llamar.ExecuteReader();
            if (eje.Read())
            {
                txt_conan.Text = eje.GetString(1);
            }
            tinajita.Close();
        
        }

        void guardar_contraseña()
        {
            SqlCommand commando = new SqlCommand("update login set contraseña=@con where contraseña='" + txt_conan.Text + "'", tinajita);

            commando.Parameters.AddWithValue("con", txt_confir.Text);

            tinajita.Open();
            commando.ExecuteNonQuery();
            tinajita.Close();
                       
        }

        private void fr_cambiocontraseña_Load(object sender, EventArgs e)
        {
            recibirusuario();
            lb_users.Left = (pt_usuario.Left + (pt_usuario.Width / 2))-(lb_users.Width/2);
            llamaruser();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_contr.Checked == false)
            {
                txt_conan.PasswordChar = (Char)42;
                txt_conew.PasswordChar = (Char)42;
                txt_confir.PasswordChar = (Char)42;
            }
            else
            {
                txt_conan.PasswordChar = (Char)0;
                txt_conew.PasswordChar = (Char)0;
                txt_confir.PasswordChar = (Char)0;        
            }
        }

        private void bt_acep_Click(object sender, EventArgs e)
        {
            if (txt_conan.Text != "" && txt_conew.Text != "" && txt_confir.Text != "")
            {
                if (txt_conew.Text == txt_confir.Text)
                {
                    guardar_contraseña();
                    MessageBox.Show("La Contraseña se Guardo satisfactoriamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("La Informacion que se encuentra en los campos Nueva contraseña y Confirmar contraseña No coincide \nPor Favor verifique esta información ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {

                MessageBox.Show("REVISE SU INFORMACION, PUEDE QUE ALGUNOS DE LOS CAMPOS SE ENCUENTREN VACIOS", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txt_conan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_conan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {

                altf4 = true;

            } 
            if (e.KeyCode == Keys.Enter)
            {
                txt_conew.Focus();

            }
        }

        private void txt_conew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {

                altf4 = true;

            }
            if (e.KeyCode == Keys.Enter)
            {
                txt_confir.Focus();

            }
        }

        private void txt_confir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {

                altf4 = true;

            }
            if (e.KeyCode == Keys.Enter)
            {
            bt_acep.Focus();

            }
        }

        private void fr_cambiocontraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {

                altf4 = true;
            
            }
        }

        private void fr_cambiocontraseña_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (altf4 == true)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {

                    e.Cancel = true;
                    altf4 = false;

                }
            }
        }

        private void bt_canc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
