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
    public partial class Frmgrupoproducto : Plantiparam
    {
        public Frmgrupoproducto()
        {
            InitializeComponent();
            txtidgrupo.Enabled = false;
            txtsigla.ReadOnly = true;
            txtgrupo.ReadOnly = true;
            cmdgrabar.Enabled = false;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;            
            cmbgrupo.Focus();

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

        private void Frmgrupoproducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetGruprod.grupo_producto' Puede moverla o quitarla según sea necesario.
            this.grupo_productoTableAdapter.Fill(this.bdinventarioDataSetGruprod.grupo_producto);
            autonumericoid();
        }
        void autonumericoid()
        {
            MySqlCommand comando = new MySqlCommand("select max(IdGruprod) from grupo_producto", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                try
                {
                    txtidgrupo.Text = Convert.ToString(leer.GetInt32(0) + 1);
                }
                catch
                {
                    txtidgrupo.Text = 1.ToString();
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
            txtsigla.ReadOnly = false;
            txtgrupo.ReadOnly = false;
            txtsigla.Text = "";
            txtgrupo.Text = "";
            txtsigla.Focus();
            cmbgrupo.Enabled = false;
            autonumericoid();
        }

        void actualizar()
        {
            try
            {
                MySqlCommand actualizar = new MySqlCommand("update grupo_producto set sigla=@sigla, nombre_grupo=@nombre where idgruprod=@id", miconexion);
                actualizar.Parameters.AddWithValue("id", txtidgrupo.Text);
                actualizar.Parameters.AddWithValue("sigla", txtsigla.Text);
                actualizar.Parameters.AddWithValue("nombre", txtgrupo.Text);
                miconexion.Open();
                actualizar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro actualizado!");
                this.grupo_productoTableAdapter.Fill(this.bdinventarioDataSetGruprod.grupo_producto);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtsigla.ReadOnly = true;
                txtgrupo.ReadOnly = true;
                cmbgrupo.Enabled = true;
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
                MySqlCommand grabar = new MySqlCommand("Insert into grupo_producto(sigla, nombre_grupo)values(@sigla, @nombre)", miconexion);
                grabar.Parameters.AddWithValue("sigla", txtsigla.Text);
                grabar.Parameters.AddWithValue("nombre", txtgrupo.Text);
                miconexion.Open();
                grabar.ExecuteNonQuery();
                miconexion.Close();

                MessageBox.Show("Registro Exitoso!");
                this.grupo_productoTableAdapter.Fill(this.bdinventarioDataSetGruprod.grupo_producto);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtsigla.ReadOnly = true;
                txtgrupo.ReadOnly = true;
                cmbgrupo.Enabled = true;
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
                MySqlCommand comando = new MySqlCommand("select idgruprod from grupo_producto where idgruprod=" + txtidgrupo.Text, miconexion);
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
                MySqlCommand eliminar = new MySqlCommand("delete from grupo_producto where IdGruprod=@id", miconexion);
                eliminar.Parameters.AddWithValue("id", txtsigla.Text);
                miconexion.Open();
                eliminar.ExecuteNonQuery();
                miconexion.Close();
                DialogResult resultado = MessageBox.Show("¿Desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                MessageBox.Show("Registro Eliminado!");
                this.grupo_productoTableAdapter.Fill(this.bdinventarioDataSetGruprod.grupo_producto);
                cmdmodific.Enabled = false;
                txtidgrupo.Text = "";
                txtgrupo.Text = "";
                txtsigla.Enabled = false;
                txtgrupo.Enabled = false;
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
            txtsigla.ReadOnly = false;
            txtgrupo.ReadOnly = false;
            txtsigla.Focus();  
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            cmdnuevo.Enabled = false;
            cmbgrupo.Enabled = false;
            cmdgrabar.Enabled = true;                                 
        }

        void cargarnombregrupo()
        {
            cmbgrupo.Items.Clear();
            MySqlCommand comando = new MySqlCommand("select * from grupo_producto", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(2);
                cmbgrupo.Items.Add(nombre);
            }
            miconexion.Close();
        }

        void cargadatos()
        {
            MySqlCommand comando = new MySqlCommand("select * from grupo_producto where nombre_grupo='" + cmbgrupo.Text + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtidgrupo.Text = leer.GetString(0);
                txtsigla.Text = leer.GetString(1);
                txtgrupo.Text = leer.GetString(2);
            }
            miconexion.Close();
        }

        private void cmbgrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbgrupo.Text != "")
            {
                cargadatos();
            }
            cmdmodific.Enabled = true;
            cmdeliminar.Enabled = true;
            cargarnombregrupo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarnombregrupo();
            cargadatos();
            timer1.Enabled = false;
        }
    }
}
