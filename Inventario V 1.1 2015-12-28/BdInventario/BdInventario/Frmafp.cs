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
    public partial class Frmafp :Plantiparam
    {
        public Frmafp()
        {
            InitializeComponent();
            txtidafp.Enabled = false;
            cmdgrabar.Enabled = false;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            txtafp.ReadOnly = true;
            cmbafp.Focus();
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
        private void Frmafp_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetAFP.afp' Puede moverla o quitarla según sea necesario.
            this.afpTableAdapter.Fill(this.bdinventarioDataSetAFP.afp);
            autonumericoid();
        }

        void autonumericoid()
        {
            MySqlCommand comando = new MySqlCommand("select Max(IdAfp) from afp", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();

            if (leer.Read())
            {
                try
                {
                    txtidafp.Text = Convert.ToString(leer.GetInt32(0) + 1);
                }
                catch
                {
                    txtidafp.Text = 1.ToString();
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
            txtafp.ReadOnly = false;
            txtafp.Text = "";
            txtafp.Focus();
            cmbafp.Enabled = false;
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
                MySqlCommand actualizar = new MySqlCommand("update afp set nombre_afp=@nombre where idafp=@id", miconexion);
                actualizar.Parameters.AddWithValue("id", txtidafp.Text);
                actualizar.Parameters.AddWithValue("nombre", txtafp.Text);
                miconexion.Open();
                actualizar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro actualizado!");
                this.afpTableAdapter.Fill(this.bdinventarioDataSetAFP.afp);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtafp.ReadOnly = true;
                cmbafp.Enabled = true;
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
                MySqlCommand grabar = new MySqlCommand("Insert into afp(nombre_afp)values(@nombre)", miconexion);
                grabar.Parameters.AddWithValue("nombre", txtafp.Text);
                miconexion.Open();
                grabar.ExecuteNonQuery();
                miconexion.Close();

                MessageBox.Show("Registro Exitoso!");
                this.afpTableAdapter.Fill(this.bdinventarioDataSetAFP.afp);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtafp.ReadOnly = true;
                cmbafp.Enabled = true;
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
                MySqlCommand comando = new MySqlCommand("select idafp from afp where idafp=" + txtidafp.Text, miconexion);
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

        void cargarnombreafp()
        {
            cmbafp.Items.Clear();
            MySqlCommand comando = new MySqlCommand("select * from afp", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(1);
                cmbafp.Items.Add(nombre);
            }
            miconexion.Close();
        }

        void cargadatos()
        {
            MySqlCommand comando = new MySqlCommand("select * from afp where nombre_afp='" + cmbafp.Text + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtidafp.Text = leer.GetString(0);
                txtafp.Text = leer.GetString(1);
            }
            miconexion.Close();
        }

        private void cmdmodific_Click(object sender, EventArgs e)
        {
            cmdmodific.Enabled = false;
            txtafp.ReadOnly = false;
            cmdnuevo.Enabled = false;
            cmdeliminar.Enabled = false;
            cmbafp.Enabled = false;
            cmdgrabar.Enabled = true; 
        }

        private void cmdeliminar_Click(object sender, EventArgs e)
        {
            try
            {               
                MySqlCommand eliminar = new MySqlCommand("delete from afp where IdAFP=@id", miconexion);
                eliminar.Parameters.AddWithValue("id", txtidafp.Text);
                miconexion.Open();
                eliminar.ExecuteNonQuery();
                miconexion.Close();
                DialogResult resultado = MessageBox.Show("¿Desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                MessageBox.Show("Registro Eliminado!");
                this.afpTableAdapter.Fill(this.bdinventarioDataSetAFP.afp);
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

        private void cmbafp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbafp.Text != "")
            {
                cargadatos();
            }
            cmdmodific.Enabled = true;
            cmdeliminar.Enabled = true;
            cargarnombreafp();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarnombreafp();
            cargadatos();
            timer1.Enabled = false;
        }
    }
}
 