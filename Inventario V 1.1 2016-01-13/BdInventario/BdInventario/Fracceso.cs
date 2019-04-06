using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;//libreria mysql
using BdInventario.Clases;


namespace BdInventario
{
    public partial class Fracceso : Form
    {

        #region Constructores

        public Fracceso()
        {
            InitializeComponent();

            //Se inicializa la cadena de conexión
            miconexion = new MySqlConnection(AccesoDatos.StringConnection);
            txtusuario.Focus();
        }

        #endregion

        #region Eventos

        private void cmdaceptar_Click(object sender, EventArgs e)
        {
            acceso();
        }

        private void Fracceso_Load(object sender, EventArgs e)
        {            
            cmdaceptar.Parent = pictureBox1;
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            txtcontrasena.Parent = pictureBox1;
            txtusuario.Parent = pictureBox1;
            pictureBox1.Location = new Point((this.Width / 2) - (pictureBox1.Width / 2), (this.Height / 2) - (pictureBox1.Height / 2));
        }

        private void txtcontraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                acceso();
            }
        }

        private void Fracceso_FormClosed(object sender, FormClosedEventArgs e)
        {            
            Application.Exit();           
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Se abre la conexion y se conecta con la tabla usuarios
        /// </summary>
        public void acceso()
        {
            miconexion.Open();
            MySqlCommand consulusurio = new MySqlCommand("select * from usuarios where contrasena='" + txtcontrasena.Text + "' and Nombre_Usuario='" + txtusuario.Text + "'", miconexion);
            MySqlDataReader ejecuta = consulusurio.ExecuteReader();
            if (ejecuta.Read() == true)
            {
                this.Hide();
                Frmenu menu = new Frmenu();
                tipousuario = ejecuta.GetString(3);
                menu.enviar_tipousuario = tipousuario;
                menu.tstusuario.Text = tipousuario;
                menu.Show();
            }
            else
            {
                MessageBox.Show("Acceso denegado: el usuario y/o la contaseña ingresada no es correcta, intentelo nuevamente o contacte al administrador del sistema!");
                txtusuario.Clear();
                txtcontrasena.Clear();
                txtusuario.Focus();
            }
            miconexion.Close();
        }

        #endregion

        #region Campos

        public string tipousuario;
        public string usuario;

        #endregion

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

    }
}
