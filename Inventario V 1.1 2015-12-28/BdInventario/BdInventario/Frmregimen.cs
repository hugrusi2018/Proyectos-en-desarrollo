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
    public partial class Frmregimen : Plantiparam
    {
        public Frmregimen()
        {
            InitializeComponent();
            txtidregimen.Enabled = false;
            txtregimen.ReadOnly = true;
            cmdgrabar.Enabled = false;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;            
            cmbregimen.Focus();

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
       
        private void Frmregimen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetRegimen.regimen' Puede moverla o quitarla según sea necesario.
            this.regimenTableAdapter.Fill(this.bdinventarioDataSetRegimen.regimen);
            autonumericoid();
        }
        void autonumericoid()
        {
            MySqlCommand comando = new MySqlCommand("select max(IdRegimen) from regimen", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                try
                {
                    txtidregimen.Text = Convert.ToString(leer.GetInt32(0) + 1);
                }
                catch
                {
                    txtidregimen.Text = 1.ToString();
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
            txtregimen.ReadOnly = false;
            txtregimen.Text = "";
            txtregimen.Focus();
            cmbregimen.Enabled = false;
            autonumericoid();
        }

        void actualizar()
        {
            try
            {
                MySqlCommand actualizar = new MySqlCommand("update regimen set nombre_regimen=@nombre where idregimen=@id", miconexion);
                actualizar.Parameters.AddWithValue("id", txtidregimen.Text);
                actualizar.Parameters.AddWithValue("nombre", txtregimen.Text);
                miconexion.Open();
                actualizar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro actualizado!");
                this.regimenTableAdapter.Fill(this.bdinventarioDataSetRegimen.regimen);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtregimen.ReadOnly = true;
                cmbregimen.Enabled = true;
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
                if (txtregimen.Text == "")
                {
                    MessageBox.Show("No ha insertado datos");
                    txtregimen.Focus();
                    return;
                }
                else
                {
                    MySqlCommand grabar = new MySqlCommand("Insert into regimen(Nombre_Regimen)values(@nombre)", miconexion);
                    grabar.Parameters.AddWithValue("nombre", txtregimen.Text);
                    miconexion.Open();
                    grabar.ExecuteNonQuery();
                    miconexion.Close();
                    MessageBox.Show("Registro Exitoso!");
                    this.regimenTableAdapter.Fill(this.bdinventarioDataSetRegimen.regimen);
                    cmdnuevo.Enabled = true;
                    cmdgrabar.Enabled = false;
                    txtregimen.ReadOnly = true;
                    cmbregimen.Enabled = true;
                    autonumericoid();
                }
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
                MySqlCommand comando = new MySqlCommand("select idregimen from regimen where idregimen=" + txtidregimen.Text, miconexion);
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

        void cargarnombregimen()
        {
            cmbregimen.Items.Clear();
            MySqlCommand comando = new MySqlCommand("select * from regimen", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(1);
                cmbregimen.Items.Add(nombre);
            }
            miconexion.Close();
        }

        void cargadatos()
        {
            MySqlCommand comando = new MySqlCommand("select * from regimen where nombre_regimen='" + cmbregimen.Text + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtidregimen.Text = leer.GetString(0);
                txtregimen.Text = leer.GetString(1);
            }
            miconexion.Close();
        }


        private void cmdeliminar_Click(object sender, EventArgs e)
        {            
            MySqlCommand eliminar = new MySqlCommand("delete from regimen where Idregimen=@id", miconexion);
            eliminar.Parameters.AddWithValue("id", txtidregimen.Text);
            miconexion.Open();
            eliminar.ExecuteNonQuery();
            miconexion.Close();
            DialogResult resultado = MessageBox.Show("¿Desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.No)
            {
                return;
            }
            MessageBox.Show("Registro Eliminado!");
            this.regimenTableAdapter.Fill(this.bdinventarioDataSetRegimen.regimen);
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            cmdnuevo.Enabled = true;

            autonumericoid();               
        }

        private void cmdmodific_Click(object sender, EventArgs e)
        {
            cmdmodific.Enabled = false;
            txtregimen.ReadOnly = false;
            cmdnuevo.Enabled = false;
            cmdeliminar.Enabled = false;
            cmbregimen.Enabled = false;
            cmdgrabar.Enabled = true; 
        }       

        private void cmbregimen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbregimen.Text != "")
            {
                cargadatos();
            }
            cmdmodific.Enabled = true;
            cmdeliminar.Enabled = true;
            cargarnombregimen();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarnombregimen();
            cargadatos();

            timer1.Enabled = false;
        }
    }
}
