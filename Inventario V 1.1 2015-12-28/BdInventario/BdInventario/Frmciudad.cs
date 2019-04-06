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
    public partial class Frmciudad : Plantiparam
    {
        public Frmciudad()
        {
            InitializeComponent();
            txtidciudad.Enabled = false;
            cmdgrabar.Enabled = false;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            txtciudad.ReadOnly = true;
            cmbciudad.Focus();

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

        int idpais;

        private void Frmciudad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetCiudades.ciudades' Puede moverla o quitarla según sea necesario.
            this.ciudadesTableAdapter.Fill(this.bdinventarioDataSetCiudades.ciudades);
            autonumericoid();
        }

        void autonumericoid()
        {
            MySqlCommand comando = new MySqlCommand("select max(IdCiudad) from ciudades", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
               try
                {
                    txtidciudad.Text = Convert.ToString(leer.GetInt32(0) + 1);
                }
                catch
                {
                    txtidciudad.Text = 1.ToString();
                }
            }
            miconexion.Close();
        }

        private void cmdnuevo_Click(object sender, EventArgs e)
        {
            cmdnuevo.Enabled = false;
            cmdgrabar.Enabled = true;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            txtciudad.ReadOnly = false;
            txtciudad.Text = "";
            cmbpais.Text = "";
            txtciudad.Focus();
            cmbciudad.Enabled = false;
            autonumericoid();
        }

        private void cmdcerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();

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
                else
                {
                    MySqlCommand eliminar = new MySqlCommand("delete from ciudades where IdCiudad=@id", miconexion);
                    eliminar.Parameters.AddWithValue("id", txtidciudad.Text);
                    miconexion.Open();
                    eliminar.ExecuteNonQuery();
                    miconexion.Close();
                    MessageBox.Show("Registro Eliminado!");
                    this.ciudadesTableAdapter.Fill(this.bdinventarioDataSetCiudades.ciudades);
                    cmdmodific.Enabled = false;
                    cmdmodific.Enabled = false;
                    cmdeliminar.Enabled = false;
                    cmdnuevo.Enabled = true;
                    autonumericoid();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        void actualizar()
        {
            try
            {
                MySqlCommand actualizar = new MySqlCommand("update ciudades set nombre_ciudad=@nombre, idpais=@idpais where idciudad=@id", miconexion);
                actualizar.Parameters.AddWithValue("id", txtidciudad.Text);
                actualizar.Parameters.AddWithValue("nombre", txtciudad.Text);
                actualizar.Parameters.AddWithValue("idpais", idpais);
                miconexion.Open();
                actualizar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro actualizado!");
                this.ciudadesTableAdapter.Fill(this.bdinventarioDataSetCiudades.ciudades);  
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtciudad.ReadOnly = true;
                cmbciudad.Enabled = true;
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
                MySqlCommand grabar = new MySqlCommand("Insert into ciudades(nombre_ciudad, idpais)values(@nombre, @idpais)", miconexion);
                grabar.Parameters.AddWithValue("nombre", txtciudad.Text);
                grabar.Parameters.AddWithValue("idpais", idpais);
                miconexion.Open();
                grabar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro Exitoso!");
                this.ciudadesTableAdapter.Fill(this.bdinventarioDataSetCiudades.ciudades);  
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtciudad.ReadOnly = true;
                cmbciudad.Enabled = true;
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
                MySqlCommand comando = new MySqlCommand("select idciudad from ciudades where idciudad=" + txtidciudad.Text, miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();

                if (leer.Read())
                {                    
                    actualizar();
                }
                else
                {                    
                    guardar();
                }
                miconexion.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }    

        void cargarnombreciudad()
        {
            cmbciudad.Items.Clear();
            MySqlCommand comando = new MySqlCommand("select * from ciudades", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(1);
                cmbciudad.Items.Add(nombre);
            }
            miconexion.Close();
        }

        void cargarnombrepais()
        {
            cmbpais.Items.Clear();
            MySqlCommand comando = new MySqlCommand("select * from paises", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(1);
                cmbpais.Items.Add(nombre);
            }
            miconexion.Close();
        }

        void traeridpais()
        {
            if (cmbpais.Text != "")
            {
                MySqlCommand regimen = new MySqlCommand("select idpais from paises where nombre_pais='" + cmbpais.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = regimen.ExecuteReader();
                if (leer.Read())
                {
                    idpais = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        void cargadatos()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand("select cli.idciudad, cli.nombre_ciudad, pais.nombre_pais from ciudades cli, paises pais where nombre_ciudad='" + cmbciudad.Text + "'and cli.idpais=pais.idpais", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    txtidciudad.Text = leer.GetString(0);
                    txtciudad.Text = leer.GetString(1);
                    try
                    {
                        cmbpais.Text = leer.GetString(2);
                    }
                    catch
                    {
                        cmbpais.Text = cmbpais.Text;
                    }
                }
                miconexion.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar datos: "+ex.Message);
            }
        }

        void cargadatoinicial()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand("select cli.idciudad, cli.nombre_ciudad, pais.nombre_pais from ciudades cli, paises pais where 1 and cli.idpais=pais.idpais", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    txtidciudad.Text = leer.GetString(0);
                    txtciudad.Text = leer.GetString(1);
                    try
                    {
                        cmbpais.Text = leer.GetString(2);
                    }
                    catch
                    {
                        cmbpais.Text = cmbpais.Text;
                    }
                }
                miconexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void cmdmodific_Click(object sender, EventArgs e)
        {
            cmdmodific.Enabled = false;
            txtciudad.ReadOnly = false;
            cmdnuevo.Enabled = false;
            cmdeliminar.Enabled = false;
            cmbciudad.Enabled = false;
            cmdgrabar.Enabled = true; 
        }

        private void cmbciudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbciudad.Text != "")
            {
                cargadatos();
            }
            cmdmodific.Enabled = true;
            cmdeliminar.Enabled = true;
            cargarnombreciudad();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarnombreciudad();
            cargarnombrepais();
            cargadatos();
            cargadatoinicial();
            timer1.Enabled = false;
        }

        private void cmbpais_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridpais();
        }
    }
}
 