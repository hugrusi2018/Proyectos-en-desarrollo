using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using BdInventario.Clases;

namespace BdInventario
{
    public partial class Frmenu : Form
    {
        funciones funcion = new funciones();

        public Frmenu()
        {
            InitializeComponent();
            tstusuario.Visible = true;
            tstusuarios.Visible = true;

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


        public string enviar_tipousuario;
        public string enviar_usuario;
        public string nombreusuario;
        public string recibir_usuario = "";

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar sesion?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == DialogResult.No)
            {
                return;
            }
            this.Hide();
            Fracceso acceso = new Fracceso();
            acceso.Show();
            funcion.guardar_seguimiento("Finaliza sesion en LS Inventario", tstusuarios.Text);
        }

        void traernombreusuario()
        {
            try
            {
                if (tstusuario.Text != "")
                {
                    MySqlCommand comando = new MySqlCommand("select * from usuarios where tipo_usuario_id='" + tstusuario.Text + "'", miconexion);
                    miconexion.Open();
                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read() == true)
                    {
                        nombreusuario = leer.GetString(1);
                    }
                    tstusuarios.Text = nombreusuario;
                    miconexion.Close();
                }
                nombreusuario = tstusuarios.Text;
            }
            catch (Exception exec)
            {
                MessageBox.Show("Error al cargar usuario: " + exec.Message);
                miconexion.Close();
                return;
            }
        }

        private void actividadComercialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmactividad activcomer = new Frmactividad();
            activcomer.Show();
        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmciudad ciudad = new Frmciudad();
            ciudad.Show();
        }

        private void aFPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmafp afp = new Frmafp();
            afp.Show();
        }

        private void ePSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmeps eps = new Frmeps();
            eps.Show();
        }

        private void aRPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmarp arp = new Frmarp();
            arp.Show();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frminfoempresa empresa = new Frminfoempresa();
            empresa.Show();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmcargos cargo = new Frmcargos();
            cargo.Show();
        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmpais pais = new Frmpais();
            pais.Show();
        }

        private void impuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmimpuestos impuesto = new Frmimpuestos();
            impuesto.Show();
        }

        private void formasDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmformapago pago = new Frmformapago();
            pago.Show();
        }

        private void almacenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmalmacen almacen = new Frmalmacen();
            almacen.Show();
        }

        private void tipoSangreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmtiposangre tipodesangre = new Frmtiposangre();
            tipodesangre.Show();
        }

        private void grupoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmgrupoproducto grupoproductos = new Frmgrupoproducto();
            grupoproductos.Show();
        }

        private void tipoMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmdocumentos movimentos = new Frmdocumentos();
            movimentos.Show();
        }

        private void subgrupoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmsubgrupoproductos subgrupoproductos = new Frmsubgrupoproductos();
            subgrupoproductos.Show();
        }

        private void tipoRegimenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmregimen regimen = new Frmregimen();
            regimen.Show();
        }

        private void grupoEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmgrupoempleados gempleados = new Frmgrupoempleados();
            gempleados.Show();
        }

        private void entradasAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmovimientoproducto movimientos = new Frmovimientoproducto();
            movimientos.recibir_tipousuario = tstusuario.Text;
            movimientos.recibir_usuario = tstusuarios.Text;
            movimientos.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmproductos productos = new Frmproductos();
            productos.Show();
        }

        private void productosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frmproductos productos = new Frmproductos();
            productos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmclientes clientes = new Frmclientes();
            clientes.recibir_tipousuario = tstusuario.Text;
            clientes.recibir_usuario = tstusuarios.Text;
            clientes.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmconsultaclientes cliente = new Frmconsultaclientes();
            cliente.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmproveedores proveedores = new Frmproveedores();
            proveedores.recibir_tipousuario = tstusuario.Text;
            proveedores.recibir_usuario = tstusuarios.Text;
            proveedores.Show();
        }

        private void kardexProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmproductos productos = new Frmproductos();
            productos.recibir_tipousuario = tstusuario.Text;
            productos.recibir_usuario = tstusuarios.Text;
            productos.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmempleados empleados = new Frmempleados();
            empleados.recibir_tipousuario = tstusuario.Text;
            empleados.recibir_usuario = tstusuarios.Text;
            empleados.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmusuarios usuarios = new Frmusuarios();
            usuarios.Show();
        }

        private void unidadesDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmunidades unidadmedida = new Frmunidades();
            unidadmedida.Show();
        }

        private void tipoDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmconsultadocumentos consultadocumento = new Frmconsultadocumentos();
            consultadocumento.Show();
        }

        private void productosToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Frmconsultaproductos productos = new Frmconsultaproductos();
            productos.Show();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmconsultaproveedores proveedores = new Frmconsultaproveedores();
            proveedores.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (tstusuario.Text == "1")
            {
                parametrosToolStripMenuItem1.Enabled = true;
            }
            traernombreusuario();
            funcion.guardar_seguimiento("Inicia sesion en LS Inventario", tstusuarios.Text);
            timer1.Enabled = false;
        }

        private void auditoriaAUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmauditoria auditoria = new Frmauditoria();
            auditoria.Show();
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frmreporteclientes reporteclientes = new Frmreporteclientes();
            reporteclientes.Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmconsultaempleados empleados = new Frmconsultaempleados();
            empleados.Show();
        }

        private void empleadosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frmreportempleados reportempleados = new Frmreportempleados();
            reportempleados.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmreporteproductos reporteproductos = new Frmreporteproductos();
            reporteproductos.Show();
        }

        private void proveedoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frmreporteproveedores reporteproveedores = new Frmreporteproveedores();
            reporteproveedores.Show();
        }

        private void tipoDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmreportedocumentos tipodocumentos = new Frmreportedocumentos();
            tipodocumentos.Show();
        }

        private void consolidadoComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmconsultastock consolidadocompras = new Frmconsultastock();
            consolidadocompras.Show();
        }

        private void Frmenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
