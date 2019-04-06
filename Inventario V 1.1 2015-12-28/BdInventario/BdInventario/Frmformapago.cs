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
    public partial class Frmformapago : Plantiparam
    {
        public Frmformapago()
        {
            InitializeComponent();
            txtidformapago.Enabled = false;
            cmdgrabar.Enabled = false;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            txtformapago.ReadOnly = true;
            cmbformapago.Focus();

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

        private void Frmformapago_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetFormapago.forma_pago' Puede moverla o quitarla según sea necesario.            
            this.forma_pagoTableAdapter.Fill(this.bdinventarioDataSetFormapago.forma_pago);
            autonumericoid();            
        }
        void autonumericoid()
        {
            MySqlCommand comando = new MySqlCommand("select max(IdFormPago) from forma_pago", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                try
                {
                    txtidformapago.Text = Convert.ToString(leer.GetInt32(0) + 1);
                }
                catch
                {
                    txtidformapago.Text = 1.ToString();
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
            txtformapago.ReadOnly = false;
            txtformapago.Text = "";
            txtformapago.Focus();
            cmbformapago.Enabled = false;
            autonumericoid();
        }

        void actualizar()
        {
            try
            {
                MySqlCommand actualizar = new MySqlCommand("update forma_pago set nombre_forma_pago=@nombre where idformpago=@id", miconexion);
                actualizar.Parameters.AddWithValue("id", txtidformapago.Text);
                actualizar.Parameters.AddWithValue("nombre", txtformapago.Text);
                miconexion.Open();
                actualizar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro actualizado!");
                this.forma_pagoTableAdapter.Fill(this.bdinventarioDataSetFormapago.forma_pago);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtformapago.ReadOnly = true;
                cmbformapago.Enabled = true;
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
                MySqlCommand grabar = new MySqlCommand("Insert into forma_pago(nombre_forma_pago)values(@nombre)", miconexion);
                grabar.Parameters.AddWithValue("nombre", txtformapago.Text);
                miconexion.Open();
                grabar.ExecuteNonQuery();
                miconexion.Close();

                MessageBox.Show("Registro Exitoso!");
                this.forma_pagoTableAdapter.Fill(this.bdinventarioDataSetFormapago.forma_pago);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtformapago.ReadOnly = true;
                cmbformapago.Enabled = true;
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
                MySqlCommand comando = new MySqlCommand("select idformpago from forma_pago where idformpago=" + txtidformapago.Text, miconexion);
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

        void cargarnombreformapago()
        {
            cmbformapago.Items.Clear();
            MySqlCommand comando = new MySqlCommand("select * from forma_pago", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(1);
                cmbformapago.Items.Add(nombre);
            }
            miconexion.Close();
        }

        void cargadatos()
        {
            MySqlCommand comando = new MySqlCommand("select * from forma_pago where nombre_forma_pago='" + cmbformapago.Text + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtidformapago.Text = leer.GetString(0);
                txtformapago.Text = leer.GetString(1);
            }
            miconexion.Close();
        }

        private void cmdeliminar_Click(object sender, EventArgs e)
        {
            try
            {                
                MySqlCommand eliminar = new MySqlCommand("delete from forma_pago where IdFormPago=@id", miconexion);
                eliminar.Parameters.AddWithValue("id", txtidformapago.Text);
                miconexion.Open();
                eliminar.ExecuteNonQuery();
                miconexion.Close();
                DialogResult resultado = MessageBox.Show("¿Desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                MessageBox.Show("Registro Eliminado!");
                this.forma_pagoTableAdapter.Fill(this.bdinventarioDataSetFormapago.forma_pago);
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
            txtformapago.ReadOnly = false;
            cmdnuevo.Enabled = false;
            cmdeliminar.Enabled = false;
            cmbformapago.Enabled = false;
            cmdgrabar.Enabled = true;
        }

        private void txtformapago_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbformapago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbformapago.Text != "")
            {
                cargadatos();
            }
            cmdmodific.Enabled = true;
            cmdeliminar.Enabled = true;
            cargarnombreformapago();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarnombreformapago();
            cargadatos();
            timer1.Enabled = false;
        }
    }
}
