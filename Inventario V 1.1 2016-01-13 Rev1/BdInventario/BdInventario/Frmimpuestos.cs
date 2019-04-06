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
    public partial class Frmimpuestos : Plantiparam
    {
        public Frmimpuestos()
        {
            InitializeComponent();
            txtidimpto.Enabled = false;
            txtporcentaje.ReadOnly = true;
            txtimpuesto.ReadOnly = true;
            cmdgrabar.Enabled = false;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;            
            cmbimpuesto.Focus();

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

        private void Frmimpuestos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetImpuestos.impuestos' Puede moverla o quitarla según sea necesario.
            this.impuestosTableAdapter.Fill(this.bdinventarioDataSetImpuestos.impuestos);
            autonumericoid();
        }
        void autonumericoid()
        {
            MySqlCommand comando = new MySqlCommand("select count(idimpuesto) from impuestos", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtidimpto.Text = Convert.ToString(leer.GetValue(0));
            }
            miconexion.Close();
        }

        private void cmdcerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmdnuevo_Click(object sender, EventArgs e)
        {
            txtporcentaje.ReadOnly = false;
            txtimpuesto.ReadOnly = false;
            txtporcentaje.Text = "";
            txtimpuesto.Text = "";
            txtimpuesto.Focus();
            cmdeliminar.Enabled = false;
            cmdnuevo.Enabled = false;
            cmdgrabar.Enabled = true;
            cmdmodific.Enabled = false;
            cmbimpuesto.Enabled = false;
        }

        private void cmdgrabar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtimpuesto.Text == "")
                {
                    MessageBox.Show("Describa el impuesto");
                    txtimpuesto.Focus();
                }

                if (txtporcentaje.Text == "")
                {
                    MessageBox.Show("Digite el valor (%) del impuesto que va a crear");
                    txtporcentaje.Focus();
                }
                else
                {
                    MySqlCommand grabar = new MySqlCommand("Insert into impuestos (nombre_impuesto, porcentaje)values(@nombre, @porcentaje)", miconexion);
                    grabar.Parameters.AddWithValue("nombre", txtimpuesto.Text);
                    grabar.Parameters.AddWithValue("porcentaje", txtporcentaje.Text);

                    miconexion.Open();
                    grabar.ExecuteNonQuery();
                    MessageBox.Show("Registro Exitoso!");
                    this.impuestosTableAdapter.Fill(this.bdinventarioDataSetImpuestos.impuestos);
                    miconexion.Close();
                    
                    cmdnuevo.Enabled = true;
                    cmdgrabar.Enabled = false;
                    txtimpuesto.ReadOnly = true;
                    txtporcentaje.ReadOnly = true;
                    cmbimpuesto.Enabled = true;
                    autonumericoid();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        void cargarnombreimpuesto()
        {
            cmbimpuesto.Items.Clear();
            MySqlCommand comando = new MySqlCommand("select * from impuestos", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(1);
                cmbimpuesto.Items.Add(nombre);
            }
            miconexion.Close();
        }

       void cargadatos()
        {
            MySqlCommand comando = new MySqlCommand("select * from impuestos where nombre_impuesto='" + cmbimpuesto.Text + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtidimpto.Text = leer.GetString(0);
                txtimpuesto.Text = leer.GetString(1);
                txtporcentaje.Text = leer.GetString(2);
            }
            miconexion.Close();
        }

        private void cmdeliminar_Click(object sender, EventArgs e)
        {
            try
            {                
                MySqlCommand eliminar = new MySqlCommand("delete from impuestos where IdImpuesto=@id", miconexion);
                eliminar.Parameters.AddWithValue("id", txtidimpto.Text);
                miconexion.Open();
                eliminar.ExecuteNonQuery();
                miconexion.Close();
                DialogResult resultado = MessageBox.Show("¿Desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                MessageBox.Show("Registro Eliminado!");
                this.impuestosTableAdapter.Fill(this.bdinventarioDataSetImpuestos.impuestos);

                cmdmodific.Enabled = false;
                txtidimpto.Text = "";
                txtidimpto.Enabled = false;
                txtporcentaje.Enabled = false;
                txtimpuesto.Enabled = false;
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
            cmdeliminar.Enabled = false;
            cmdnuevo.Enabled = false;
            cmdgrabar.Enabled = true;
            cmbimpuesto.Enabled = false;

            txtimpuesto.ReadOnly = false;
            txtporcentaje.ReadOnly = false;
            
        }
        
        private void cmbimpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbimpuesto.Text != "")
            {
                cargadatos();
            }
            cmdmodific.Enabled = true;
            cmdeliminar.Enabled = true;
            cargarnombreimpuesto();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarnombreimpuesto();
            cargadatos();
            timer1.Enabled = false;
        }       
    }
}
