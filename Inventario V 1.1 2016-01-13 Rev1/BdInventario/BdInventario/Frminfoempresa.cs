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
    public partial class Frminfoempresa : Plantiparam
    {
        public Frminfoempresa()
        {
            InitializeComponent();
            txtidempresa.ReadOnly = true;
            txtrazonsoc.ReadOnly = true;
            cmbciudad.Enabled = false;
            txtdireccion.ReadOnly = true;
            txtelefono.ReadOnly = true;
            cmbregimen.Enabled = false;
            txtobservacion.ReadOnly = true;
            ptrlogo.Enabled = false;
            ptrimagen.Enabled = false;
            cmdgrabar.Enabled = false;            
            cmdeliminar.Enabled = false;
            cmdlogo.Enabled = false;
            cmdimagen.Enabled = false;

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

        int idregimen;
        int idciudad;

        private void cdmsalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmdmodific_Click(object sender, EventArgs e)
        {
            txtidempresa.ReadOnly = false;
            txtrazonsoc.ReadOnly = false;
            cmbciudad.Enabled = true;
            txtdireccion.ReadOnly = false;
            txtelefono.ReadOnly = false;
            cmbregimen.Enabled = true;
            txtobservacion.ReadOnly = false;
            ptrlogo.Enabled = true;
            ptrimagen.Enabled = true;
            cmdgrabar.Enabled = true;
            cmdeliminar.Enabled = true;
            cmdmodific.Enabled = false;
            cmdlogo.Enabled = true;
            cmdimagen.Enabled = true;
            txtidempresa.Focus();
        }

        //Consulta para cargar nombre de ciudad
        void cargarnombreciudad()
        {
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

        void traeridciudad()
        {
            if (cmbciudad.Text != "")
            {
                MySqlCommand comando = new MySqlCommand("select IdCiudad from ciudades where Nombre_Ciudad='" + cmbciudad.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    idciudad = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        //Consulta para cargar nombre regimen de la tala regimen
        void cargarnombreregimen()
        {
            MySqlCommand comando = new MySqlCommand("select * from regimen", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(1);
                cmbregimen.Items.Add(nombre);
            }
            miconexion.Close();
        }

        void traeridregimen()
        {
            if (cmbregimen.Text != "")
            {
                MySqlCommand comando = new MySqlCommand("select IdRegimen from regimen where Nombre_Regimen='" + cmbregimen.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    idregimen = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        private void cmdgrabar_Click(object sender, EventArgs e)
        {
            if (txtidempresa.Text == "")
            {
                MessageBox.Show("Digite identificación para la empresa!");
                txtidempresa.Focus();                
                return;                
            }
            if (txtrazonsoc.Text == "")
            {
                MessageBox.Show("Digite el nombre de la empresa!");
                txtrazonsoc.Focus();
                return;                
            }
            if (cmbciudad.Text == "")
            {
                MessageBox.Show("Seleccione ciudad!");
                cmbciudad.Focus();
                return;                
            }
            if (cmbregimen.Text == "")
            {
                MessageBox.Show("Seleccione régimen!");
                cmbregimen.Focus();
                return;               
            }            
           
            else
            {
                MySqlCommand grabar = new MySqlCommand("Insert into info_empresa(idempresa, nombre_empresa, idciudad, direccion, telefono, idregimen, observacion, logo, imagen_principal)values(@idempresa, @nombre_empresa, @idciudad, @direccion, @telefono, @idregimen, @observacion, @logo, @imagen_principal)", miconexion);
                grabar.Parameters.AddWithValue("idempresa", txtidempresa.Text);
                grabar.Parameters.AddWithValue("nombre_empresa", txtrazonsoc.Text);
                grabar.Parameters.AddWithValue("idciudad", idciudad);
                grabar.Parameters.AddWithValue("direccion", txtdireccion.Text);
                grabar.Parameters.AddWithValue("telefono", txtelefono.Text);
                grabar.Parameters.AddWithValue("idregimen", idregimen);
                grabar.Parameters.AddWithValue("observacion", txtobservacion.Text);
                grabar.Parameters.AddWithValue("logo", ptrlogo.Text);
                grabar.Parameters.AddWithValue("imagen_principal", ptrimagen.Text);

                miconexion.Open();
                grabar.ExecuteNonQuery();
                miconexion.Close();

                MessageBox.Show("Se ha registrado la Empresa!");              
                cmdgrabar.Enabled = false;
                cmdgrabar.Enabled = false;
                cmdmodific.Enabled = true;
                txtidempresa.ReadOnly = true;
                txtrazonsoc.ReadOnly = true;
                cmbciudad.Enabled = false;
                txtdireccion.ReadOnly = true;
                txtelefono.ReadOnly = true;
                cmbregimen.Enabled = false;
                txtobservacion.ReadOnly = true;
                cmdlogo.Enabled = false;
                cmdimagen.Enabled = false;               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarnombreciudad();
            cargarnombreregimen();
            timer1.Enabled = false;
        }

        private void cmdlogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos JPEG(*.jpg)|*.jpg";
            abrir.InitialDirectory="C:/";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                string dir = abrir.FileName;
                ptrlogo.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap picture = new Bitmap(dir);
                ptrlogo.Image = (Image)picture;
            }
        }

        private void cmdimagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Archivos JPEG(*.jpg)|*.jpg";
            abrir.InitialDirectory = "C:/";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                string dir = abrir.FileName;
                ptrimagen.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap picture = new Bitmap(dir);
                ptrimagen.Image = (Image)picture;
            }
        }

        private void cmdeliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand eliminar = new MySqlCommand("delete from info_empresa where idempresa=@id", miconexion);
                eliminar.Parameters.AddWithValue("id", txtidempresa.Text);
                miconexion.Open();
                eliminar.ExecuteNonQuery();
                miconexion.Close();
                if (txtidempresa.Text == "")
                {
                    MessageBox.Show("No existe codigo para eliminar!", "AVISO");
                    return;
                }
                DialogResult resultado = MessageBox.Show("¿Desea eliminar la empresa?", "ADVERTENCIA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                MessageBox.Show("Empresa Eliminada!");                
                cmdmodific.Enabled = true;
                cmdeliminar.Enabled = false;
                cmdgrabar.Enabled = false;           
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }     
    }
}
