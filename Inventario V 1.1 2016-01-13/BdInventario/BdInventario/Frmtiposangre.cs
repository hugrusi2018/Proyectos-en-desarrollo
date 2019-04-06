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
    public partial class Frmtiposangre : Plantiparam
    {
        public Frmtiposangre()
        {
            InitializeComponent();
            txtidsangre.Enabled = false;            
            cmdgrabar.Enabled = false;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            txtsangre.ReadOnly = true;
            cmbsangre.Focus();

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

        private void Frmtiposangre_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetGruposanguineo.grupo_sanguineo' Puede moverla o quitarla según sea necesario.
            this.grupo_sanguineoTableAdapter.Fill(this.bdinventarioDataSetGruposanguineo.grupo_sanguineo);
            autonumericoid();
        }
        void autonumericoid()
        {
            MySqlCommand comando = new MySqlCommand("select max(idsangre) from grupo_sanguineo", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                try
                {
                    txtidsangre.Text = Convert.ToString(leer.GetInt32(0) + 1);
                }
                catch
                {
                    txtidsangre.Text = 1.ToString();
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
            txtsangre.ReadOnly = false;
            txtsangre.Text = "";
            txtsangre.Focus();
            cmbsangre.Enabled = false;
            autonumericoid();
        }

        void actualizar()
        {
            try
            {
                MySqlCommand actualizar = new MySqlCommand("update grupo_sanguineo set nombre_grupo_sanguineo=@nombre where idsangre=@id", miconexion);
                actualizar.Parameters.AddWithValue("id", txtidsangre.Text);
                actualizar.Parameters.AddWithValue("nombre", txtsangre.Text);
                miconexion.Open();
                actualizar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro actualizado!");
                this.grupo_sanguineoTableAdapter.Fill(this.bdinventarioDataSetGruposanguineo.grupo_sanguineo);
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtsangre.ReadOnly = true;
                cmbsangre.Enabled = true;
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
                if (txtsangre.Text == "")
                {
                    MessageBox.Show("No ha insertado datos");
                    txtsangre.Focus();
                    return;
                }

                else
                {
                    MySqlCommand grabar = new MySqlCommand("Insert into grupo_sanguineo(nombre_grupo_sanguineo)values(@nombre)", miconexion);
                    grabar.Parameters.AddWithValue("nombre", txtsangre.Text);
                    miconexion.Open();
                    grabar.ExecuteNonQuery();
                    miconexion.Close();
                    MessageBox.Show("Registro Exitoso!");
                    this.grupo_sanguineoTableAdapter.Fill(this.bdinventarioDataSetGruposanguineo.grupo_sanguineo);
                    cmdnuevo.Enabled = true;
                    cmdgrabar.Enabled = false;
                    txtsangre.ReadOnly = true;
                    cmbsangre.Enabled = true;
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
                MySqlCommand comando = new MySqlCommand("select idsangre from grupo_sanguineo where idsangre=" + txtidsangre.Text, miconexion);
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
        
        void cargarnombresangre()
        {
            cmbsangre.Items.Clear();
            MySqlCommand comando = new MySqlCommand("select * from grupo_sanguineo", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(1);
                cmbsangre.Items.Add(nombre);
            }
            miconexion.Close();
        }

        void cargadatos()
        {
            MySqlCommand comando = new MySqlCommand("select * from grupo_sanguineo where nombre_grupo_sanguineo='" + cmbsangre.Text + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtidsangre.Text = leer.GetString(0);
                txtsangre.Text = leer.GetString(1);                
            }
            miconexion.Close();
        }

        private void cmbsangre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbsangre.Text != "")
            {
                cargadatos();
            }            
            cmdmodific.Enabled = true;
            cmdeliminar.Enabled = true;
            cargarnombresangre();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarnombresangre();
            cargadatos();
            timer1.Enabled = false;
        }

        private void cmdmodific_Click(object sender, EventArgs e)
        {           
            cmdmodific.Enabled = false;             
            txtsangre.ReadOnly=false;
            cmdnuevo.Enabled = false;
            cmdeliminar.Enabled = false;
            cmbsangre.Enabled = false;
            cmdgrabar.Enabled = true;              
       }

        private void cmdeliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand eliminar = new MySqlCommand("delete from grupo_sanguineo where idsangre=@id", miconexion);
                eliminar.Parameters.AddWithValue("id", txtidsangre.Text);
                miconexion.Open();
                eliminar.ExecuteNonQuery();
                miconexion.Close();
                DialogResult resultado = MessageBox.Show("¿Desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                MessageBox.Show("Registro Eliminado!");
                this.grupo_sanguineoTableAdapter.Fill(this.bdinventarioDataSetGruposanguineo.grupo_sanguineo);
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
    }
}
