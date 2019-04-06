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
    public partial class Frmsubgrupoproductos : Plantiparam
    {
        public Frmsubgrupoproductos()
        {
            InitializeComponent();
            txtidsubgrupo.Enabled = false;
            txtsigla.ReadOnly = true;
            txtsubgrupo.ReadOnly = true;
            cmdgrabar.Enabled = false;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;

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

        int idgrupo;

        private void Frmsubgrupoproductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetSubgrupo.subgrupo_productos' Puede moverla o quitarla según sea necesario.
            this.subgrupo_productosTableAdapter.Fill(this.bdinventarioDataSetSubgrupo.subgrupo_productos);
            autonumericoid();
        }
        void autonumericoid()
        {
            MySqlCommand comando = new MySqlCommand("select max(IdSubgrupo) from subgrupo_productos", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtidsubgrupo.Text = Convert.ToString(leer.GetInt32(0) + 1);
            }
            miconexion.Close();
        }

        private void cmdcerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmdnuevo_Click(object sender, EventArgs e)
        {
            txtsigla.ReadOnly = false;           
            txtsubgrupo.ReadOnly = false;
            txtsigla.Text = "";
            txtsubgrupo.Text = "";
            cmbgrupo.Text = "";
            txtsigla.Focus();            
            cmdnuevo.Enabled = false;
            cmdeliminar.Enabled = false;
            cmdgrabar.Enabled = true;
            cmdmodific.Enabled = false;            
            cmbsubgrupo.Enabled = false;
            autonumericoid();
        }

        void actualizar()
        {
            try
            {
                MySqlCommand actualizar = new MySqlCommand("update subgrupo_productos set sigla=@sigla, nombre_subgrupo=@nombre, idgruprod=@idgrupo where idsubgrupo=@id", miconexion);
                actualizar.Parameters.AddWithValue("id", txtidsubgrupo.Text);
                actualizar.Parameters.AddWithValue("sigla", txtsigla.Text);
                actualizar.Parameters.AddWithValue("nombre", txtsubgrupo.Text);
                actualizar.Parameters.AddWithValue("idgrupo", cmbgrupo.Text);
                miconexion.Open();
                actualizar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro actualizado!");
                this.subgrupo_productosTableAdapter.Fill(this.bdinventarioDataSetSubgrupo.subgrupo_productos);  
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtsigla.ReadOnly = true;
                txtsubgrupo.ReadOnly = true;
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
                if (txtsigla.Text == "")
                {
                    MessageBox.Show("Digite la sigla o abreviatura del subgrupo que va a crear");
                    txtsigla.Focus();
                    return;
                }
                if (txtsubgrupo.Text == "")
                {
                    MessageBox.Show("Describa el subgrupo!");
                    txtsubgrupo.Focus();
                    return;
                }
                if (cmbgrupo.Text == "")
                {
                    MessageBox.Show("Seleccione un grupo!");
                    cmbgrupo.Focus();
                    return;
                }
                else
                {
                    MySqlCommand grabar = new MySqlCommand("Insert into subgrupo_productos(Sigla, Nombre_Subgrupo, IdGruprod)values(@sigla, @nombre, @idgrupo)", miconexion);
                    grabar.Parameters.AddWithValue("sigla", txtsigla.Text);
                    grabar.Parameters.AddWithValue("nombre", txtsubgrupo.Text);
                    grabar.Parameters.AddWithValue("idgrupo", idgrupo);
                    miconexion.Open();
                    grabar.ExecuteNonQuery();
                    miconexion.Close();
                    MessageBox.Show("Registro Exitoso!");
                    this.subgrupo_productosTableAdapter.Fill(this.bdinventarioDataSetSubgrupo.subgrupo_productos);  
                    txtsigla.ReadOnly = true;
                    txtsubgrupo.ReadOnly = true;
                    cmbsubgrupo.Enabled = true;
                    cmdnuevo.Enabled = true;
                    cmdgrabar.Enabled = false;
                    cmdmodific.Enabled = false;
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
                MySqlCommand comando = new MySqlCommand("select idsubgrupo from subgrupo_productos where idsubgrupo=" + txtidsubgrupo.Text, miconexion);
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

        void cargarnombresubgrupo()
        {
            cmbsubgrupo.Items.Clear();
            MySqlCommand comando = new MySqlCommand("select * from subgrupo_productos", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(2);
                cmbsubgrupo.Items.Add(nombre);
            }
            miconexion.Close();
        }

        void cargarnombregrupo()
        {            
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

        void traeridgrupo()
        {
            if (cmbgrupo.Text != "")
            {
                MySqlCommand comando = new MySqlCommand("select idgruprod from grupo_producto where nombre_grupo='" + cmbgrupo.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    idgrupo = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        void cargadatos()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand("select cli.idsubgrupo, cli.sigla, cli.nombre_subgrupo, gru.nombre_grupo from subgrupo_productos cli, grupo_producto gru where nombre_subgrupo='" + cmbsubgrupo.Text + "' and cli.idgruprod=gru.idgruprod", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    txtidsubgrupo.Text = leer.GetString(0);
                    txtsigla.Text = leer.GetString(1);
                    txtsubgrupo.Text = leer.GetString(2);
                    try
                    {
                        cmbgrupo.Text = leer.GetString(3);
                    }
                    catch
                    {
                        cmbgrupo.Text = cmbgrupo.Text;
                    }
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
                MySqlCommand eliminar = new MySqlCommand("delete from subgrupo_productos where IdSubGrupo=@id", miconexion);
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
                this.subgrupo_productosTableAdapter.Fill(this.bdinventarioDataSetSubgrupo.subgrupo_productos);  
                cmdmodific.Enabled = false;
                cmdeliminar.Enabled = false;
                cmdnuevo.Enabled = true; 
                autonumericoid();                
            }
            catch
            {
                MessageBox.Show("El 'Id' digitado no existe en la base de datos");
            }
        }             

        private void cmbsubgrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbsubgrupo.Text != "")
            {
                cargadatos();
            }
            cmdmodific.Enabled = true;
            cmdeliminar.Enabled = true;
            cargarnombresubgrupo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargarnombresubgrupo();
            cargarnombregrupo();
            cargadatos();

            timer1.Enabled = false;
        }

        private void cmdmodific_Click(object sender, EventArgs e)
        {
            txtsigla.ReadOnly = false;
            txtsubgrupo.ReadOnly = false;
            cmdmodific.Enabled = false;
            cmdnuevo.Enabled = false;
            cmdeliminar.Enabled = false;            
            cmdgrabar.Enabled = true; 
        }

        private void cmbgrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridgrupo();
        }

        private void Frmsubgrupoproductos_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetSubgrupo.subgrupo_productos' Puede moverla o quitarla según sea necesario.
            this.subgrupo_productosTableAdapter.Fill(this.bdinventarioDataSetSubgrupo.subgrupo_productos);
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetSubgrupo.subgrupo_productos' Puede moverla o quitarla según sea necesario.
            this.subgrupo_productosTableAdapter.Fill(this.bdinventarioDataSetSubgrupo.subgrupo_productos);

        }            
    }
}
