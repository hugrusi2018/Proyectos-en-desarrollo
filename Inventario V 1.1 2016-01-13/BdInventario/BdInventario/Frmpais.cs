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
    public partial class Frmpais : Plantiparam
    {
        public Frmpais()
        {
            InitializeComponent();
            txtidpais.Enabled = false;
            cmdgrabar.Enabled = false;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            txtpais.ReadOnly = true;
            cmbpais.Focus();

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

        private void Frmpais_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetPais.paises' Puede moverla o quitarla según sea necesario.
            this.paisesTableAdapter.Fill(this.bdinventarioDataSetPais.paises);
            autonumericoid();
        }

        void autonumericoid()
        {
            MySqlCommand comando = new MySqlCommand("select max(IdPais) from paises", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                try
                {
                    txtidpais.Text = Convert.ToString(leer.GetInt32(0) + 1);
                }
                catch
                {
                    txtidpais.Text = 1.ToString();
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
            txtpais.ReadOnly = false;
            txtpais.Text = "";
            txtpais.Focus();
            cmbpais.Enabled = false;
            autonumericoid();
        }

        void actualizar()
        {
            try
            {
                MySqlCommand actualizar = new MySqlCommand("update paises set nombre_pais=@nombre where idpais=@id", miconexion);
                actualizar.Parameters.AddWithValue("id", txtidpais.Text);                
                actualizar.Parameters.AddWithValue("nombre", txtpais.Text);
                miconexion.Open();
                actualizar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro actualizado!");
                this.paisesTableAdapter.Fill(this.bdinventarioDataSetPais.paises);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;                
                txtpais.ReadOnly = true;
                cmbpais.Enabled = true;
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
                MySqlCommand grabar = new MySqlCommand("Insert into paises(nombre_pais)values(@nombre)", miconexion);
                grabar.Parameters.AddWithValue("nombre", txtpais.Text);
                miconexion.Open();
                grabar.ExecuteNonQuery();
                miconexion.Close();

                MessageBox.Show("Registro Exitoso!");
                this.paisesTableAdapter.Fill(this.bdinventarioDataSetPais.paises);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;                
                txtpais.ReadOnly = true;
                cmbpais.Enabled = true;
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
                MySqlCommand comando = new MySqlCommand("select idpais from paises where idpais=" + txtidpais.Text, miconexion);
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

        void cargadatos()
        {
            MySqlCommand comando = new MySqlCommand("select * from paises where nombre_pais='" + cmbpais.Text + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtidpais.Text = leer.GetString(0);
                txtpais.Text = leer.GetString(1);
            }
            miconexion.Close();
        }

        private void cmdeliminar_Click(object sender, EventArgs e)
        {
            try
            {                
                MySqlCommand eliminar = new MySqlCommand("delete from paises where IdPais=@id", miconexion);
                eliminar.Parameters.AddWithValue("id", txtidpais.Text);
                miconexion.Open();
                eliminar.ExecuteNonQuery();
                miconexion.Close();
                DialogResult resultado = MessageBox.Show("¿Desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                MessageBox.Show("Registro Eliminado!");
                this.paisesTableAdapter.Fill(this.bdinventarioDataSetPais.paises);
                cmdmodific.Enabled = false;
                txtpais.Text = "";
                txtidpais.Enabled = false;
                txtpais.Enabled = false;
                cmdnuevo.Enabled = true;
                cmdeliminar.Enabled = false;

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
            txtpais.ReadOnly = false;
            cmdnuevo.Enabled = false;
            cmdeliminar.Enabled = false;
            cmbpais.Enabled = false;
            cmdgrabar.Enabled = true;  
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cmdmodific.Enabled = true;
            txtidpais.Enabled = true;
            txtidpais.Text = "";
            txtpais.Enabled = true;
            cmdnuevo.Enabled = false;
            cmdgrabar.Enabled = false;
            cmdeliminar.Enabled = true;
            txtidpais.Focus();
        }

        private void cmbpais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbpais.Text != "")
            {
                cargadatos();
            }
            cmdmodific.Enabled = true;
            cmdeliminar.Enabled = true;
            cargarnombrepais();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarnombrepais();
            cargadatos();
            timer1.Enabled = false;
        }
    }
}
