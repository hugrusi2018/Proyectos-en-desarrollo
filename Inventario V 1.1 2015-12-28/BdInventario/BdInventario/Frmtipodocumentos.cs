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
    public partial class Frmtipodocumentos : Plantiparam
    {
        public Frmtipodocumentos()
        {
            InitializeComponent();
            txtidoc.Enabled = false;
            txtdocumento.ReadOnly = true;
            txtransaccion.ReadOnly = true;
            txtdocini.ReadOnly = true;
            txtdocactual.ReadOnly = true;
            cmdgrabar.Enabled = false;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            txtidoc.Focus();

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

        private void Frmtipomovimientos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetTipodocumentos.tipo_documentos' Puede moverla o quitarla según sea necesario.
            this.tipo_documentosTableAdapter.Fill(this.bdinventarioDataSetTipodocumentos.tipo_documentos);        
            autonumericoid();
        }
       
        void autonumericoid()
        {
            MySqlCommand comando = new MySqlCommand("select max(idDoc) from tipo_documentos", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                try
                {
                    txtidoc.Text = Convert.ToString(leer.GetInt32(0) + 1);
                }
                catch
                {
                    txtidoc.Text = 1.ToString();
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
            txtdocumento.Focus();
            txtdocumento.ReadOnly = false;
            txtransaccion.ReadOnly = false;
            txtdocini.ReadOnly = false;
            txtdocactual.ReadOnly = false;
            cmdnuevo.Enabled = false;
            cmdgrabar.Enabled = true;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            cmbdocumento.Enabled = false;
            autonumericoid();
            txtdocumento.Text = "";
            txtransaccion.Text = "";
            txtdocini.Text = "";
            txtdocactual.Text = "";
        }

        void actualizar()
        {
            try
            {
                MySqlCommand actualizar = new MySqlCommand("update tipo_documentos set nombre_documento=@nombre, transaccion=@transaccion, iniciar_documento=@iniciar, documento_actual=@actual where idDoc=@id", miconexion);
                actualizar.Parameters.AddWithValue("id", txtidoc.Text);
                actualizar.Parameters.AddWithValue("nombre", txtdocumento.Text);
                actualizar.Parameters.AddWithValue("transaccion", txtransaccion.Text);
                actualizar.Parameters.AddWithValue("iniciar", txtdocini.Text);
                actualizar.Parameters.AddWithValue("actual", txtdocactual.Text);
                miconexion.Open();
                actualizar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro actualizado!");
                this.tipo_documentosTableAdapter.Fill(this.bdinventarioDataSetTipodocumentos.tipo_documentos);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtdocumento.ReadOnly = true;
                txtransaccion.ReadOnly = true;
                txtdocini.ReadOnly = true;
                txtdocactual.ReadOnly = true;
                cmbdocumento.Enabled = true;
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

                if (txtdocumento.Text == "")
                {
                    MessageBox.Show("Describa el documento!");
                    txtdocumento.Focus();
                    return;
                }
                if (txtransaccion.Text == "")
                {
                    MessageBox.Show("Describa la transacción!");
                    txtransaccion.Focus();
                    return;
                }
                if (txtdocini.Text == "")
                {
                    MessageBox.Show("Digite el numero con el que desea iniciar este documento");
                    txtdocini.Focus();
                    return;
                }
                if (txtdocactual.Text == "")
                {
                    MessageBox.Show("Digite el numero inicial en el campo 'Doc. Actual' este controlará el incremento","ADVERTENCIA");
                    txtdocactual.Focus();
                    return;
                }
                else
                {
                    MySqlCommand grabar = new MySqlCommand("Insert into tipo_documentos(Nombre_Documento, Transaccion, Iniciar_Documento, documento_actual)values(@nombre, @transaccion, @iniciar, @actual)", miconexion);
                    grabar.Parameters.AddWithValue("nombre", txtdocumento.Text);
                    grabar.Parameters.AddWithValue("transaccion", txtransaccion.Text);
                    grabar.Parameters.AddWithValue("iniciar", txtdocini.Text);
                    grabar.Parameters.AddWithValue("actual", txtdocactual.Text);
                    miconexion.Open();
                    grabar.ExecuteNonQuery();
                    miconexion.Close();
                    MessageBox.Show("Registro Exitoso!");
                    this.tipo_documentosTableAdapter.Fill(this.bdinventarioDataSetTipodocumentos.tipo_documentos);
                    txtdocumento.ReadOnly = true;
                    txtransaccion.ReadOnly = true;
                    txtdocini.ReadOnly = true;
                    txtdocactual.ReadOnly = true;
                    cmdnuevo.Enabled = true;
                    cmdgrabar.Enabled = false;
                    cmbdocumento.Enabled = true;
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
                MySqlCommand comando = new MySqlCommand("select idDoc from tipo_documentos where idDoc=" + txtidoc.Text, miconexion);
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
            MySqlCommand eliminar = new MySqlCommand("delete from tipo_documentos where IdDoc=@id", miconexion);
            eliminar.Parameters.AddWithValue("id", txtidoc.Text);
            miconexion.Open();
            eliminar.ExecuteNonQuery();
            miconexion.Close();
            DialogResult resultado = MessageBox.Show("¿Desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.No)
            {
                return;
            }
            MessageBox.Show("Registro Eliminado!");
            this.tipo_documentosTableAdapter.Fill(this.bdinventarioDataSetTipodocumentos.tipo_documentos);
            txtidoc.ReadOnly = true;
            cmdmodific.Enabled = false;                    
            cmdeliminar.Enabled = false;
            cmdnuevo.Enabled = true;

            autonumericoid();  
        }

        void cargarnombredocumento()
        {
            MySqlCommand comando = new MySqlCommand("select * from tipo_documentos", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(1);
                cmbdocumento.Items.Add(nombre);
                this.tipo_documentosTableAdapter.Fill(this.bdinventarioDataSetTipodocumentos.tipo_documentos);
            }
            miconexion.Close();
        }

        void cargadatos()
        {
            MySqlCommand comando = new MySqlCommand("select * from tipo_documentos where nombre_documento='" + cmbdocumento.Text + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtidoc.Text = leer.GetString(0);
                txtdocumento.Text = leer.GetString(1);
                txtransaccion.Text = leer.GetString(2);
                txtdocini.Text = leer.GetString(3);
                txtdocactual.Text = leer.GetString(4);
            }
            miconexion.Close();
        }

        private void cmdmodific_Click(object sender, EventArgs e)
        {
            txtdocumento.ReadOnly = false;
            txtransaccion.ReadOnly = false;
            cmdmodific.Enabled = false;
            cmdnuevo.Enabled = false;
            cmdeliminar.Enabled = false;
            cmbdocumento.Enabled = false;
            cmdgrabar.Enabled = true; 
        }

        private void cmbdocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbdocumento.Text != "")
            {
                cargadatos();
            }
            cmdmodific.Enabled = true;
            cmdeliminar.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarnombredocumento();
            cargadatos();
            timer1.Enabled = false;
        }          
    }
}
