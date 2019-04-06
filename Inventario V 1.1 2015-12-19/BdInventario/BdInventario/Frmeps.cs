using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BdInventario.Clases;

namespace BdInventario
{
    public partial class Frmeps : Plantiparam
    {
        public Frmeps()
        {
            InitializeComponent();
            txtideps.Enabled = false;
            cmdgrabar.Enabled = false;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            txteps.ReadOnly = true;
            cmbeps.Focus();

            //Se inicializa la cadena de conexión
            miconexion = new MySqlConnection(AccesoDatos.StringConnection);
        }

        #region Objetos

        /// <summary>
        /// Se crea conexion con la base de datos
        /// </summary
        MySqlConnection miconexion;

        /// <summary>
        /// Objeto de administración de acceso a datos
        /// </summary>
        Data AccesoDatos = new Data();

        #endregion

        private void Frmeps_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetEPS.eps' Puede moverla o quitarla según sea necesario.
            this.epsTableAdapter.Fill(this.bdinventarioDataSetEPS.eps);
            autonumericoid();
        }
        void autonumericoid()
        {
            MySqlCommand comando = new MySqlCommand("select max(IdEPS) from eps", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                try
                {
                    txtideps.Text = Convert.ToString(leer.GetInt32(0) + 1);
                }
                catch
                {
                    txtideps.Text = 1.ToString();
                }
            }
            miconexion.Close();
        }
        
        private void cdmsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmdnuevo_Click(object sender, EventArgs e)
        {
            cmdnuevo.Enabled = false;
            cmdgrabar.Enabled = true;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            txteps.ReadOnly = false;
            txteps.Text = "";
            txteps.Focus();
            cmbeps.Enabled = false;
            autonumericoid();
        }

        void actualizar()
        {
            try
            {
                MySqlCommand actualizar = new MySqlCommand("update eps set nombre_eps=@nombre where ideps=@id", miconexion);
                actualizar.Parameters.AddWithValue("id", txtideps.Text);
                actualizar.Parameters.AddWithValue("nombre", txteps.Text);
                miconexion.Open();
                actualizar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro actualizado!");
                this.epsTableAdapter.Fill(this.bdinventarioDataSetEPS.eps);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txteps.ReadOnly = true;
                cmbeps.Enabled = true;
                autonumericoid();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        void guardar()
        {
            try
            {
                MySqlCommand grabar = new MySqlCommand("Insert into eps(nombre_eps)values(@nombre)", miconexion);
                grabar.Parameters.AddWithValue("nombre", txteps.Text);
                miconexion.Open();
                grabar.ExecuteNonQuery();
                miconexion.Close();

                MessageBox.Show("Registro Exitoso!");
                this.epsTableAdapter.Fill(this.bdinventarioDataSetEPS.eps);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txteps.ReadOnly = true;
                cmbeps.Enabled = true;
                autonumericoid();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void cmdgrabar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand("select ideps from eps where ideps=" + txtideps.Text, miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    miconexion.Close();
                    actualizar();
                }
                else
                {
                    miconexion.Close();
                    guardar();
                }
                miconexion.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }    

        void cargarnombreps()
        {
            cmbeps.Items.Clear();
            MySqlCommand comando = new MySqlCommand("select * from eps", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(1);
                cmbeps.Items.Add(nombre);
            }
            miconexion.Close();
        }

        void cargadatos()
        {
            MySqlCommand comando = new MySqlCommand("select * from eps where nombre_eps='" + cmbeps.Text + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtideps.Text = leer.GetString(0);
                txteps.Text = leer.GetString(1);
            }
            miconexion.Close();
        }

        private void cmdeliminar_Click(object sender, EventArgs e)
        {
            try
            { 
                MySqlCommand eliminar = new MySqlCommand("delete from eps where IdEPS=@id", miconexion);
                eliminar.Parameters.AddWithValue("id", txtideps.Text);
                miconexion.Open();
                eliminar.ExecuteNonQuery();
                miconexion.Close();
                DialogResult resultado = MessageBox.Show("¿Desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                MessageBox.Show("Registro Eliminado!");
                this.epsTableAdapter.Fill(this.bdinventarioDataSetEPS.eps);
                cmdmodific.Enabled = false;
                cmdeliminar.Enabled = false;
                cmdnuevo.Enabled = true;
                autonumericoid();                
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void cmdmodific_Click(object sender, EventArgs e)
        {
            cmdmodific.Enabled = false;
            txteps.ReadOnly = false;
            cmdnuevo.Enabled = false;
            cmdeliminar.Enabled = false;
            cmbeps.Enabled = false;
            cmdgrabar.Enabled = true;  
        }       

        private void cmbeps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbeps.Text != "")
            {
                cargadatos();
            }
            cmdmodific.Enabled = true;
            cmdeliminar.Enabled = true;
            cargarnombreps();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarnombreps();
            cargadatos();
            timer1.Enabled = false;
        }
    }
}
