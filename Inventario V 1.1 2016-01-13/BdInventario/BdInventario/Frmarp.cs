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
    public partial class Frmarp : Plantiparam
    {
        public Frmarp()
        {
            InitializeComponent();
            txtidarp.Enabled = false;
            cmdgrabar.Enabled = false;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            txtarp.ReadOnly = true;
            cmbarp.Focus();

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

        private void Frmarp_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetARP.arp' Puede moverla o quitarla según sea necesario.
            this.arpTableAdapter.Fill(this.bdinventarioDataSetARP.arp);
            autonumericoid();
        }

        void autonumericoid()
        {
            MySqlCommand comando = new MySqlCommand("select Max(IdARP) from arp", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                try
                {
                    txtidarp.Text = Convert.ToString(leer.GetInt32(0) + 1);
                }
                catch
                {
                    txtidarp.Text = 1.ToString();
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
            txtarp.ReadOnly = false;
            txtarp.Text = "";
            txtarp.Focus();
            cmbarp.Enabled = false;
            autonumericoid();
        }

        private void cmdmodificar_Click(object sender, EventArgs e)
        {
            cmdmodific.Enabled = false;
            txtarp.ReadOnly = false;
            cmdnuevo.Enabled = false;
            cmdeliminar.Enabled = false;
            cmbarp.Enabled = false;
            cmdgrabar.Enabled = true;  
        }

        void actualizar()
        {
            try
            {
                MySqlCommand actualizar = new MySqlCommand("update arp set nombre_arp=@nombre where idarp=@id", miconexion);
                actualizar.Parameters.AddWithValue("id", txtidarp.Text);
                actualizar.Parameters.AddWithValue("nombre", txtarp.Text);
                miconexion.Open();
                actualizar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro actualizado!");
                this.arpTableAdapter.Fill(this.bdinventarioDataSetARP.arp);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtarp.ReadOnly = true;
                cmbarp.Enabled = true;
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
                MySqlCommand grabar = new MySqlCommand("Insert into arp(nombre_arp)values(@nombre)", miconexion);
                grabar.Parameters.AddWithValue("nombre", txtarp.Text);
                miconexion.Open();
                grabar.ExecuteNonQuery();
                miconexion.Close();

                MessageBox.Show("Registro Exitoso!");
                this.arpTableAdapter.Fill(this.bdinventarioDataSetARP.arp);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtarp.ReadOnly = true;
                cmbarp.Enabled = true;
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
                MySqlCommand comando = new MySqlCommand("select idarp from arp where idarp=" + txtidarp.Text, miconexion);
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

        void cargarnombrearp()
        {
            cmbarp.Items.Clear();
            MySqlCommand comando = new MySqlCommand("select * from arp", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(1);
                cmbarp.Items.Add(nombre);
            }
            miconexion.Close();
        }

        void cargadatos()
        {
            MySqlCommand comando = new MySqlCommand("select * from arp where nombre_arp='" + cmbarp.Text + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtidarp.Text = leer.GetString(0);
                txtarp.Text = leer.GetString(1);
            }
            miconexion.Close();
        }



        private void cmdeliminar_Click(object sender, EventArgs e)
        {
            try
            {                
                MySqlCommand eliminar = new MySqlCommand("delete from arp where IdARP=@id", miconexion);
                eliminar.Parameters.AddWithValue("id", txtidarp.Text);
                miconexion.Open();
                eliminar.ExecuteNonQuery();
                miconexion.Close();
                DialogResult resultado = MessageBox.Show("¿Desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                MessageBox.Show("Registro Eliminado!");
                this.arpTableAdapter.Fill(this.bdinventarioDataSetARP.arp);
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

        private void cmbarp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbarp.Text != "")
            {
                cargadatos();
            }
            cmdmodific.Enabled = true;
            cmdeliminar.Enabled = true;
            cargarnombrearp();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarnombrearp();
            cargadatos();
            timer1.Enabled = false;
        }       
    }
}
