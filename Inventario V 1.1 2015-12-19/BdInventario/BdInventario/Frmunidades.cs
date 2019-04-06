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
    public partial class Frmunidades : Plantiparam
    {
        public Frmunidades()
        {
            InitializeComponent();
            txtidunidad.Enabled = false;
            txtsigla.ReadOnly = true;
            txtunidad.ReadOnly = true;
            cmdgrabar.Enabled = false;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            cmbunidad.Focus();

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

        private void Frmunidades_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetUnidad.unidades' Puede moverla o quitarla según sea necesario.
            this.unidadesTableAdapter.Fill(this.bdinventarioDataSetUnidad.unidades);
            autonumericoid();
        }
        void autonumericoid()
        {
            MySqlCommand comando = new MySqlCommand("select max(idunidad) from unidades", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                try
                {
                    txtidunidad.Text = Convert.ToString(leer.GetInt32(0) + 1);
                }
                catch
                {
                    txtidunidad.Text = 1.ToString();
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
            txtsigla.ReadOnly = false;
            txtunidad.ReadOnly = false;
            txtsigla.Text = "";
            txtunidad.Text = "";            
            txtsigla.Focus();
            cmdnuevo.Enabled = false;
            cmdeliminar.Enabled = false;
            cmdgrabar.Enabled = true;
            cmdmodific.Enabled = false;
            cmbunidad.Enabled = false;
            autonumericoid();
        }

        void actualizar()
        {
            try
            {
                MySqlCommand actualizar = new MySqlCommand("update unidades set sigla=@sigla, nombre_unidad=@nombre where idunidad=@id", miconexion);
                actualizar.Parameters.AddWithValue("id", txtidunidad.Text);
                actualizar.Parameters.AddWithValue("sigla", txtsigla.Text);
                actualizar.Parameters.AddWithValue("nombre", txtunidad.Text);
                miconexion.Open();
                actualizar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro actualizado!");
                this.unidadesTableAdapter.Fill(this.bdinventarioDataSetUnidad.unidades);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtsigla.ReadOnly = true;
                txtunidad.ReadOnly = true;
                cmbunidad.Enabled = true;
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
                if (txtsigla.Text == "")
                {
                    MessageBox.Show("Digite la sigla o abreviatura de la unidad de medida que va a crear");
                    txtsigla.Focus();
                    return;
                }
                if (txtunidad.Text == "")
                {
                    MessageBox.Show("Describa la unidad de medida");
                    txtunidad.Focus();
                    return;
                }
                else
                {
                    MySqlCommand grabar = new MySqlCommand("Insert into unidades(sigla, nombre_unidad)values(@sigla, @nombre)", miconexion);
                    grabar.Parameters.AddWithValue("sigla", txtsigla.Text);
                    grabar.Parameters.AddWithValue("nombre", txtunidad.Text);
                    miconexion.Open();
                    grabar.ExecuteNonQuery();
                    miconexion.Close();
                    MessageBox.Show("Registro Exitoso!");
                    this.unidadesTableAdapter.Fill(this.bdinventarioDataSetUnidad.unidades);
                    txtsigla.ReadOnly = true;
                    txtunidad.ReadOnly = true;
                    cmdnuevo.Enabled = true;
                    cmdgrabar.Enabled = false;
                    cmdmodific.Enabled = false;
                    cmbunidad.Enabled = true;
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
                MySqlCommand comando = new MySqlCommand("select idunidad from unidades where idunidad=" + txtidunidad.Text, miconexion);
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

        void cargarnombreunidad()
        {
            cmbunidad.Items.Clear();
            MySqlCommand comando = new MySqlCommand("select * from unidades", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(2);
                cmbunidad.Items.Add(nombre);
            }
            miconexion.Close();
        }

        void cargadatos()
        {
            MySqlCommand comando = new MySqlCommand("select * from unidades where nombre_unidad='" + cmbunidad.Text + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtidunidad.Text = leer.GetString(0);
                txtsigla.Text = leer.GetString(1);
                txtunidad.Text = leer.GetString(2);                
            }
            miconexion.Close();
        }

        private void cmdeliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand eliminar = new MySqlCommand("delete from unidades where idunidad=@id", miconexion);
                eliminar.Parameters.AddWithValue("id", txtidunidad.Text);
                miconexion.Open();
                eliminar.ExecuteNonQuery();
                miconexion.Close();
                DialogResult resultado = MessageBox.Show("¿Desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                MessageBox.Show("Registro Eliminado!");
                this.unidadesTableAdapter.Fill(this.bdinventarioDataSetUnidad.unidades);
                cmdmodific.Enabled = false;
                cmdeliminar.Enabled = false;
                cmdnuevo.Enabled = true;
                autonumericoid();
            }
            catch
            {
                MessageBox.Show("El 'Id' digitado no existe en la base de datos");
            }
        }

        private void cmbunidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbunidad.Text != "")
            {
                cargadatos();
            }
            cmdmodific.Enabled = true;
            cmdeliminar.Enabled = true;            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            cargarnombreunidad();
            cargadatos();

            timer1.Enabled = false;
        }

        private void cmdmodific_Click(object sender, EventArgs e)
        {
            txtsigla.ReadOnly = false;
            txtunidad.ReadOnly = false;
            cmdmodific.Enabled = false;
            cmdnuevo.Enabled = false;
            cmdeliminar.Enabled = false;
            cmdgrabar.Enabled = true;
        }                
    }
}
