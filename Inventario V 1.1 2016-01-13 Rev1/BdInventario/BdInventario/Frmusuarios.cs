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
    public partial class Frmusuarios : Plantiparam
    {
        public Frmusuarios()
        {
            InitializeComponent();
            txtidusuario.Enabled = false;
            cmdgrabar.Enabled = false;
            cmdmodific.Enabled = false;
            cmdeliminar.Enabled = false;
            txtusuario.ReadOnly = true;
            txtcontrasena.ReadOnly = true;
            cmbusuario.Focus();

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

        int idtipousuario;        

        private void Frmusuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetTipo_Usuario.tipo_usuario' Puede moverla o quitarla según sea necesario.
            this.tipo_usuarioTableAdapter.Fill(this.bdinventarioDataSetTipo_Usuario.tipo_usuario);
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetUsuario.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.bdinventarioDataSetUsuario.usuarios);
            autonumericoid();         
        }

        void autonumericoid()
        {
            MySqlCommand comando = new MySqlCommand("select max(idusuario) from usuarios", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                try
                {
                    txtidusuario.Text = Convert.ToString(leer.GetInt32(0) + 1);
                }
                catch
                {
                    txtidusuario.Text = 1.ToString();
                }
            }
            miconexion.Close();
        }

        void cargadatoinicial()
        {
            try
            {                   
                MySqlCommand comando = new MySqlCommand("Select cli.IdUsuario, cli.Nombre_Usuario, cli.Contrasena, tpu.Nombre_Tipo_Usuario from usuarios cli, tipo_usuario tpu where 1 and cli.Tipo_Usuario_ID=tpu.ID", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    txtidusuario.Text = leer.GetString(0);
                    txtusuario.Text = leer.GetString(1);
                    txtcontrasena.Text = leer.GetString(2);
                    try
                    {
                        cmbtipousuario.Text = leer.GetString(3);
                    }
                    catch
                    {
                        cmbtipousuario.Text = cmbtipousuario.Text;
                    }
                }
                miconexion.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la carga de dato inicial: " + ex.Message);
            }
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
            txtusuario.ReadOnly = false;
            txtcontrasena.ReadOnly = false;            
            txtusuario.Text = "";
            txtcontrasena.Text = "";
            cmbtipousuario.Text = "";
            txtusuario.Focus();
            cmbusuario.Enabled = false;
            autonumericoid();
        }

        void actualizar()
        {
            try
            {
                MySqlCommand actualizar = new MySqlCommand("update usuarios set nombre_usuario=@nombre, contrasena=@contrasena tipo_usuario_id@tipo_usuario_id where idusuario=@id", miconexion);
                actualizar.Parameters.AddWithValue("id", txtidusuario.Text);
                actualizar.Parameters.AddWithValue("nombre", txtusuario.Text);
                actualizar.Parameters.AddWithValue("contrasena", txtcontrasena.Text);
                actualizar.Parameters.AddWithValue("tipo_usuario_id", idtipousuario);
                miconexion.Open();
                actualizar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro actualizado!");
                
                cmdnuevo.Enabled = true;
                cmdgrabar.Enabled = false;
                txtusuario.ReadOnly = true;
                txtcontrasena.ReadOnly = true;                
                cmbusuario.Enabled = true;
                autonumericoid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al actualizar: "+ex.Message);
            }
        }

        void guardar()
        {
            try
            {
                if (txtusuario.Text != "")
                {
                    validarusuario();
                }
                if (txtusuario.Text == "")
                {
                    MessageBox.Show("No ha insertado datos");
                    txtusuario.Focus();
                    return;
                }
                if (txtcontrasena.Text == "")
                {
                    MessageBox.Show("Digite una contraseña para el usuario");
                    txtcontrasena.Focus();
                    return;
                }
                if (cmbtipousuario.Text == "")
                {
                    MessageBox.Show("Seleccione el estatus!");
                    cmbtipousuario.Focus();
                    return;
                }
                else
                {
                    MySqlCommand grabar = new MySqlCommand("Insert into usuarios(nombre_usuario, contrasena, tipo_usuario_id)values(@nombre, @contrasena, @tipo_usuario_id)", miconexion);
                    grabar.Parameters.AddWithValue("nombre", txtusuario.Text);
                    grabar.Parameters.AddWithValue("contrasena", txtcontrasena.Text);
                    grabar.Parameters.AddWithValue("tipo_usuario_id", idtipousuario);
                    miconexion.Open();
                    grabar.ExecuteNonQuery();
                    miconexion.Close();
                    MessageBox.Show("Usuario creado con exito!");                    
                    cmdnuevo.Enabled = true;
                    cmdgrabar.Enabled = false;
                    txtusuario.ReadOnly = true;
                    txtcontrasena.ReadOnly = true;                    
                    cmbusuario.Enabled = true;
                    autonumericoid();                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al guardar en usuarios: "+ex.Message);
            }
        }

        private void cmdgrabar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand("select idusuario from usuarios where idusuario=" + txtidusuario.Text, miconexion);
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
            catch (Exception ex)
            {
                MessageBox.Show("Error en procedimiento grabar: " + ex.Message);
                miconexion.Close();
                return;
            }               
        }

        void validarusuario()
        {
            MySqlCommand comando = new MySqlCommand("select * from usuarios where nombre_usuario='"+txtusuario.Text+"'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                DialogResult resultado = MessageBox.Show("¿El usuario ya existe, desea crear otro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    txtusuario.Text = "";
                    txtcontrasena.Text = "";
                    cmbtipousuario.Text = "";
                    txtusuario.Focus();
                    this.Close();
                    return;
                }                
                else
                {
                    txtusuario.Text = "";
                    txtcontrasena.Text = "";
                    cmbtipousuario.Text = "";
                    txtusuario.Focus();
                    return;
                }                
            }
            miconexion.Close();
        }

        void cargarnombreusuario()
        {
            cmbusuario.Items.Clear();
            MySqlCommand comando = new MySqlCommand("select * from usuarios", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(1);
                cmbusuario.Items.Add(nombre);
            }
            miconexion.Close();
        }

        void cargarnombretipousuario()
        {
            MySqlCommand comando = new MySqlCommand("select nombre_tipo_usuario from tipo_usuario", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                 string tipousuario = leer.GetString(0);
                 cmbtipousuario.Items.Add(tipousuario);
            }
            miconexion.Close();
        }

        void cargaridtipousuario()
        {
            MySqlCommand comando = new MySqlCommand("select id from tipo_usuario where nombre_tipo_usuario='"+cmbtipousuario.Text+"'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                idtipousuario = leer.GetInt32(0);
            }
            miconexion.Close();
        }
                
        void cargadatos()
        {
            try
            {
                if (cmbusuario.Text != "")
                {
                    MySqlCommand comando = new MySqlCommand("Select cli.IdUsuario, cli.Nombre_Usuario, cli.Contrasena, tpu.Nombre_Tipo_Usuario from usuarios cli, tipo_usuario tpu where cli.Nombre_Usuario='" + cmbusuario.Text + "' and cli.Tipo_Usuario_ID=tpu.ID", miconexion);
                    miconexion.Open();
                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        txtidusuario.Text = leer.GetString(0);
                        txtusuario.Text = leer.GetString(1);
                        txtcontrasena.Text = leer.GetString(2);
                        try
                        {
                            cmbtipousuario.Text = leer.GetString(3);
                        }
                        catch
                        {
                            cmbtipousuario.Text = cmbtipousuario.Text;
                        }
                    }
                    miconexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: "+ex.Message);
            }
        }

        private void cmbusuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbusuario.Text != "")
            {
                cargadatos();                
            }
            cmdmodific.Enabled = true;
            cmdeliminar.Enabled = true;
            cargarnombreusuario();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cargadatoinicial();
            cargarnombreusuario();
            cargarnombretipousuario();
            cargadatos();
            timer1.Enabled = false;
        }

        private void cmdmodific_Click(object sender, EventArgs e)
        {
            cmdmodific.Enabled = false;
            txtusuario.ReadOnly = false;
            txtcontrasena.ReadOnly = false;            
            cmdnuevo.Enabled = false;
            cmdeliminar.Enabled = false;
            cmbusuario.Enabled = false;
            cmdgrabar.Enabled = true;
            txtusuario.Focus();
        }

        private void cmdeliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand eliminar = new MySqlCommand("delete from usuarios where nombre_usuario=@nombre", miconexion);
                eliminar.Parameters.AddWithValue("nombre", txtusuario.Text);
                miconexion.Open();
                eliminar.ExecuteNonQuery();
                miconexion.Close();
                DialogResult resultado = MessageBox.Show("¿Desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                MessageBox.Show("Registro Eliminado!");                
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

        private void cmdauditoria_Click(object sender, EventArgs e)
        {
            Frmauditoria auditoria = new Frmauditoria();
            auditoria.Show();
        }        

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }        

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.usuariosTableAdapter.FillBy(this.bdinventarioDataSetUsuario.usuarios);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }        
    }
}
