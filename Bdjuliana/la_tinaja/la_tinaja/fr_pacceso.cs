using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace la_tinaja
{
    public partial class fr_pacceso : Form
    {
        public fr_pacceso()
        {
            InitializeComponent();
        }


        //abrir conexion de la base de datos
        SqlConnection tinajita = new SqlConnection("Data Source=Localhost\\lada; Initial Catalog=Latinaja;Integrated Security=SSPI");


        void intentosdeingreso()
        {
            SqlCommand comando = new SqlCommand("select * from Pacceso", tinajita);
            tinajita.Open();

            SqlDataReader ejecutar = comando.ExecuteReader();

            if (ejecutar.Read())
            {
                txt_intentosing.Text = Convert.ToString(ejecutar.GetValue(1));
            
            }
            tinajita.Close();

        }

        void cargar_intentos()
        {
            SqlCommand comando =new SqlCommand ("Select numero from Cantidad",tinajita);

            tinajita.Open();

            SqlDataReader leer = comando.ExecuteReader();

            while (leer.Read())
            {
                cb_intentosing.Items.Add(leer.GetValue(leer.GetOrdinal("numero")));
            }
            tinajita.Close();
        }

        void estado()
        {
            SqlCommand comando = new SqlCommand("select * from Pacceso where estado=1", tinajita);
            tinajita.Open();

            SqlDataReader ejecutar = comando.ExecuteReader();

            if (ejecutar.Read())
            {
                txt_estado.Text = "Activado";

            }
            else 
            {
                txt_estado.Text = "Desactivado";
            }
            tinajita.Close();

        }

        void cargar_estado()
        {
            SqlCommand comando = new SqlCommand("Select Estado from Estados", tinajita);

            tinajita.Open();

            SqlDataReader leer = comando.ExecuteReader();

            while (leer.Read())
            {
                cb_estado.Items.Add(leer.GetString(leer.GetOrdinal("Estado")));
            }
            tinajita.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fr_pacceso_Load(object sender, EventArgs e)
        {
            intentosdeingreso();
            cargar_intentos();
            estado();
            cargar_estado();
        }

        private void bt_psalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
