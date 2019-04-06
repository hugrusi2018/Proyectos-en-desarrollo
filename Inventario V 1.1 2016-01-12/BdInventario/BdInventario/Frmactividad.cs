using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using BdInventario.Clases;

namespace BdInventario
{
    public partial class Frmactividad : Plantiparam
    {
        public Frmactividad()
        {
            InitializeComponent();
            txtidactiv.Enabled = false;
            cmdgrabar.Enabled = false;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            txtactividad.ReadOnly = true;
            cmbactividad.Focus();
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
        private void Frmactividad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetActividad.actividad_comercial' Puede moverla o quitarla según sea necesario.
            this.actividad_comercialTableAdapter.Fill(this.bdinventarioDataSetActividad.actividad_comercial);
            autonumericoid();
        }
        //Consulta el ultimo consecutivo
        void autonumericoid()
        {
            MySqlCommand comando = new MySqlCommand("select Max(IdActividad) from actividad_comercial", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();

            if (leer.Read())
            {
                try
                {
                    txtidactiv.Text = Convert.ToString(leer.GetInt32(0) + 1);
                }
                catch
                {
                    txtidactiv.Text =  1.ToString();
                }
            }
            miconexion.Close();
        }

        void cargarnombreactividad()
        {
            cmbactividad.Items.Clear();
            MySqlCommand comando = new MySqlCommand("select * from actividad_comercial", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(1);
                cmbactividad.Items.Add(nombre);
            }
            miconexion.Close();
        }

        void cargadatos()
        {
            MySqlCommand comando = new MySqlCommand("select * from actividad_comercial where actividad='" + cmbactividad.Text + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtidactiv.Text = leer.GetString(0);
                txtactividad.Text = leer.GetString(1);
            }
            miconexion.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarnombreactividad();
            cargadatos();
            timer1.Enabled = false;
        }

        private void cmdnuevo_Click(object sender, EventArgs e)
        {
            cmdnuevo.Enabled = false;
            cmdgrabar.Enabled = true;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            txtactividad.ReadOnly = false;
            txtactividad.Text = "";
            txtactividad.Focus();
            cmbactividad.Enabled = false;
            autonumericoid();
        }

        private void cmdcerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        void actualizar()
        {
            try
            {
                MySqlCommand actualizar = new MySqlCommand("update actividad_comercial set actividad=@actividad where idactividad=@id", miconexion);
                actualizar.Parameters.AddWithValue("id", txtidactiv.Text);
                actualizar.Parameters.AddWithValue("actividad", txtactividad.Text);
                miconexion.Open();
                actualizar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro actualizado!");
                this.actividad_comercialTableAdapter.Fill(this.bdinventarioDataSetActividad.actividad_comercial);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtactividad.ReadOnly = true;
                cmbactividad.Enabled = true;
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
                if (txtactividad.Text == "")
                {
                    MessageBox.Show("Describa la actividad");
                    txtactividad.Focus();
                    return;
                }
                else
                {
                    MySqlCommand grabar = new MySqlCommand("Insert into actividad_comercial(Actividad)values(@nombre)", miconexion);
                    grabar.Parameters.AddWithValue("nombre", txtactividad.Text);
                    miconexion.Open();
                    grabar.ExecuteNonQuery();
                    miconexion.Close();
                    MessageBox.Show("Registro Exitoso!");
                    this.actividad_comercialTableAdapter.Fill(this.bdinventarioDataSetActividad.actividad_comercial);
                    cmdnuevo.Enabled = true;
                    cmdgrabar.Enabled = false;
                    txtactividad.ReadOnly = true;
                    cmbactividad.Enabled = true;
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
                MySqlCommand comando = new MySqlCommand("select IdActividad from actividad_comercial where IdActividad=" + txtidactiv.Text, miconexion);
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

        private void cmdeliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("¿Desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                MySqlCommand eliminar = new MySqlCommand("delete from actividad_comercial where IdActividad=@id", miconexion);
                eliminar.Parameters.AddWithValue("id", txtidactiv.Text);
                miconexion.Open();
                eliminar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro Eliminado!");
                this.actividad_comercialTableAdapter.Fill(this.bdinventarioDataSetActividad.actividad_comercial);
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
            txtactividad.ReadOnly = false;
            cmdnuevo.Enabled = false;
            cmdeliminar.Enabled = false;
            cmbactividad.Enabled = false;
            cmdgrabar.Enabled = true;
        }

        private void cmbactividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbactividad.Text != "")
            {
                cargadatos();
            }
            cmdmodific.Enabled = true;
            cmdeliminar.Enabled = true;
            cargarnombreactividad();
        }       
    }
}

