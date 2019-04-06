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
    public partial class Frmalmacen : Plantiparam
    {
        public Frmalmacen()
        {
            InitializeComponent();
            txtidalmacen.Enabled = false;
            cmdgrabar.Enabled = false;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            txtalmacen.ReadOnly = true;
            cmbalmacen.Focus();

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

        private void Frmalmacen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetAlmacen.almacenes' Puede moverla o quitarla según sea necesario.
            this.almacenesTableAdapter.Fill(this.bdinventarioDataSetAlmacen.almacenes);
            autonumericoid();
        }

        void autonumericoid()
        {
            MySqlCommand comando = new MySqlCommand("select Max(IdAlmacen) from almacenes", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                try
                {
                    txtidalmacen.Text = Convert.ToString(leer.GetInt32(0) + 1);
                }
                catch
                {
                    txtidalmacen.Text = 1.ToString();
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
            txtalmacen.ReadOnly = false;
            txtalmacen.Text = "";
            txtalmacen.Focus();
            cmbalmacen.Enabled = false;
            autonumericoid();
        }

        void actualizar()
        {
            try
            {
                MySqlCommand actualizar = new MySqlCommand("update almacenes set nombre_almacen=@nombre where idalmacen=@id", miconexion);
                actualizar.Parameters.AddWithValue("id", txtidalmacen.Text);
                actualizar.Parameters.AddWithValue("nombre", txtalmacen.Text);
                miconexion.Open();
                actualizar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro actualizado!");
                this.almacenesTableAdapter.Fill(this.bdinventarioDataSetAlmacen.almacenes);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtalmacen.ReadOnly = true;
                cmbalmacen.Enabled = true;
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
                MySqlCommand comando = new MySqlCommand("select idalmacen from almacenes where idalmacen=" + txtidalmacen.Text, miconexion);
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

        void guardar()
        {
            try
            {
                MySqlCommand grabar = new MySqlCommand("Insert into almacenes(nombre_almacen)values(@nombre)", miconexion);
                grabar.Parameters.AddWithValue("nombre", txtalmacen.Text);
                miconexion.Open();
                grabar.ExecuteNonQuery();
                miconexion.Close();

                MessageBox.Show("Registro Exitoso!");
                this.almacenesTableAdapter.Fill(this.bdinventarioDataSetAlmacen.almacenes); 
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtalmacen.ReadOnly = true;
                cmbalmacen.Enabled = true;
                autonumericoid();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        void cargarnombrealmacen()
        {
            cmbalmacen.Items.Clear();
            MySqlCommand comando = new MySqlCommand("select * from almacenes", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(1);
                cmbalmacen.Items.Add(nombre);
            }
            miconexion.Close();
        }

        void cargadatos()
        {
            MySqlCommand comando = new MySqlCommand("select * from almacenes where nombre_almacen='" + cmbalmacen.Text + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtidalmacen.Text = leer.GetString(0);
                txtalmacen.Text = leer.GetString(1);
            }
            miconexion.Close();
        }

        private void cmdeliminar_Click(object sender, EventArgs e)
        {
            try
            {                
                MySqlCommand eliminar = new MySqlCommand("delete from almacenes where IdAlmacen=@id", miconexion);
                eliminar.Parameters.AddWithValue("id", txtidalmacen.Text);
                miconexion.Open();
                eliminar.ExecuteNonQuery();
                miconexion.Close();
                DialogResult resultado = MessageBox.Show("¿Desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                MessageBox.Show("Registro Eliminado!");
                this.almacenesTableAdapter.Fill(this.bdinventarioDataSetAlmacen.almacenes);
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
            txtalmacen.ReadOnly = false;
            cmdnuevo.Enabled = false;
            cmdeliminar.Enabled = false;
            cmbalmacen.Enabled = false;
            cmdgrabar.Enabled = true;     
        }        

        private void cmbalmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbalmacen.Text != "")
            {
                cargadatos();
            }
            cmdmodific.Enabled = true;
            cmdeliminar.Enabled = true;
            cargarnombrealmacen();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarnombrealmacen();
            cargadatos();
            timer1.Enabled = false;
        }
    }
}
