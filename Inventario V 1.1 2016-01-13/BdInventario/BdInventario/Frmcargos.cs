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
    public partial class Frmcargos : Plantiparam
    {
        public Frmcargos()
        {
            InitializeComponent();
            txtidcargo.Enabled = false;
            cmdgrabar.Enabled = false;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            txtcargo.ReadOnly = true;
            cmbcargo.Focus();

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

        private void Frmcargos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetCargos.cargos' Puede moverla o quitarla según sea necesario.
            this.cargosTableAdapter.Fill(this.bdinventarioDataSetCargos.cargos);
            autonumericoid();
        }

        void autonumericoid()
        {
            MySqlCommand comando = new MySqlCommand("select max(IdCargo) from cargos", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                try
                {
                    txtidcargo.Text = Convert.ToString(leer.GetInt32(0) + 1);
                }
                catch
                {
                    txtidcargo.Text = 1.ToString();
                }
            }
            miconexion.Close();
        }

        private void cmdcerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }        

        private void cmdnuevo_Click(object sender, EventArgs e)
        {
            cmdnuevo.Enabled = false;
            cmdgrabar.Enabled = true;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            txtcargo.ReadOnly = false;
            txtcargo.Text = "";
            txtcargo.Focus();
            cmbcargo.Enabled = false;
            autonumericoid();
        }

        void actualizar()
        {
            try
            {
                MySqlCommand actualizar = new MySqlCommand("update cargos set nombre_cargo=@nombre where idcargo=@id", miconexion);
                actualizar.Parameters.AddWithValue("id", txtidcargo.Text);
                actualizar.Parameters.AddWithValue("nombre", txtcargo.Text);
                miconexion.Open();
                actualizar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro actualizado!");
                this.cargosTableAdapter.Fill(this.bdinventarioDataSetCargos.cargos);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtcargo.ReadOnly = true;
                cmbcargo.Enabled = true;
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
                MySqlCommand grabar = new MySqlCommand("Insert into cargos(nombre_cargo)values(@nombre)", miconexion);
                grabar.Parameters.AddWithValue("nombre", txtcargo.Text);
                miconexion.Open();
                grabar.ExecuteNonQuery();
                miconexion.Close();

                MessageBox.Show("Registro Exitoso!");
                this.cargosTableAdapter.Fill(this.bdinventarioDataSetCargos.cargos);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtcargo.ReadOnly = true;
                cmbcargo.Enabled = true;
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
                MySqlCommand comando = new MySqlCommand("select idcargo from cargos where idcargo=" + txtidcargo.Text, miconexion);
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

        void cargarnombrecargo()
        {
            cmbcargo.Items.Clear();
            MySqlCommand comando = new MySqlCommand("select * from cargos", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(1);
                cmbcargo.Items.Add(nombre);
            }
            miconexion.Close();
        }

        void cargadatos()
        {
            MySqlCommand comando = new MySqlCommand("select * from cargos where nombre_cargo='" + cmbcargo.Text + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtidcargo.Text = leer.GetString(0);
                txtcargo.Text = leer.GetString(1);
            }
            miconexion.Close();
        }
        
        private void cmdeliminar_Click(object sender, EventArgs e)
        {
            try
            {                
                MySqlCommand eliminar = new MySqlCommand("delete from cargos where IdCargo=@id", miconexion);
                eliminar.Parameters.AddWithValue("id", txtidcargo.Text);
                miconexion.Open();
                eliminar.ExecuteNonQuery();
                miconexion.Close();
                DialogResult resultado = MessageBox.Show("¿Desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                MessageBox.Show("Registro Eliminado!");
                this.cargosTableAdapter.Fill(this.bdinventarioDataSetCargos.cargos);
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
            txtcargo.ReadOnly = false;
            cmdnuevo.Enabled = false;
            cmdeliminar.Enabled = false;
            cmbcargo.Enabled = false;
            cmdgrabar.Enabled = true;    
        }
        
        private void cmbcargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbcargo.Text != "")
            {
                cargadatos();
            }
            cmdmodific.Enabled = true;
            cmdeliminar.Enabled = true;
            cargarnombrecargo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarnombrecargo();
            cargadatos();
            timer1.Enabled = false;
        }
    }
}
