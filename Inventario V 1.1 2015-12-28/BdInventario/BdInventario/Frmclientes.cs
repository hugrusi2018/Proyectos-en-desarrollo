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
    public partial class Frmclientes : Plantiterceros
    {
        funciones funcion = new funciones();

        public Frmclientes()
        {
            InitializeComponent();
            bloqueoincial();
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
        int idpais;
        int idciudad;
        int idsector;
        int idomiciliorut;
        int idformapago;
        public string recibir_tipousuario="";
        public string recibir_usuario = "";


        void bloqueoincial()
        {
            cmbselecliente.Text = "";
            txtcodigo.ReadOnly = true;
            txtrazon.ReadOnly = true;
            txtrut.ReadOnly = true;
            cmbregimen.Text = "";
            txtdireccion.ReadOnly = true;
            cmbpais.Text = "";
            cmbciudad.Text = "";
            cmbsector.Text = "";
            msktelefono.Text = "";
            mskfax.Text = "";
            txtcredito.ReadOnly = true;
            cmbdomrut.Text = "";
            txtemail.ReadOnly = true;
            txtweb.ReadOnly = true;
            txtobserv.ReadOnly = true;
            cmbformapago.Text = "";
            txtcondiciones.ReadOnly = true;

            cmdgrabar.Enabled = false;
        }

        void cargadatoinicial()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand("Select cli.IdCliente, cli.Nombre_Cliente, cli.Nombre_RUT, cli.Direccion, cli.Telefono, cli.Fax, cli.Cupo_Credito, cli.Web, cli.Condiciones_Comerciales, cli.Observaciones, cli.Email, cli.Contacto1, cli.Contacto2, reg.Nombre_Regimen, sec.Nombre_Sector, pais.Nombre_Pais, ciu.Nombre_Ciudad, fmp.Nombre_Forma_Pago, ciu.Nombre_Ciudad from cliente cli, regimen reg, sector_comercial sec, paises pais, ciudades ciu, forma_pago fmp where 1 and cli.IdRegimen=reg.IdRegimen and cli.IdSector_Comercial=sec.IdSector and cli.IdCiudad=ciu.IdCiudad and cli.IdFormPago=fmp.IdFormPago and pais.IdPais=ciu.IdPais and cli.Domicilio_RUT=ciu.Idciudad", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    txtcodigo.Text = leer.GetString(0);
                    txtrazon.Text = leer.GetString(1);
                    txtrut.Text = leer.GetString(2);
                    txtdireccion.Text = leer.GetString(3);
                    msktelefono.Text = leer.GetString(4);
                    mskfax.Text = leer.GetString(5);
                    txtcredito.Text = leer.GetString(6);
                    txtweb.Text = leer.GetString(7);
                    txtcondiciones.Text = leer.GetString(8);
                    txtobserv.Text = leer.GetString(9);
                    txtemail.Text = leer.GetString(10);

                    try
                    {
                        txtcontacto1.Text = leer.GetString(11);
                    }
                    catch
                    {
                        txtcontacto1.Text = "";
                    }


                    try
                    {
                        txtcontacto2.Text = leer.GetString(12);
                    }
                    catch
                    {
                        txtcontacto2.Text = "";
                    }


                    cmbregimen.Text = leer.GetString(13);
                    cmbpais.Text = leer.GetString(15);
                    cmbsector.Text = leer.GetString(14);
                    cmbciudad.Text = leer.GetString(16);
                    cmbformapago.Text = leer.GetString(17);
                    cmbdomrut.Text = leer.GetString(18);
                }
                miconexion.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }   
        
        //Consulta para cargar nombre regimen de la tala regimen
        void regimen()
        {
            try
            {
                cmbregimen.Items.Clear();
                MySqlCommand regimen = new MySqlCommand("select Nombre_Regimen from regimen", miconexion);
                miconexion.Open();
                MySqlDataReader leer = regimen.ExecuteReader();
                while (leer.Read())
                {
                    cmbregimen.Items.Add(leer.GetString(0));
                }
                miconexion.Close();
            }
            catch
            {
                miconexion.Close();
                return;
            }
        }

        void pais()
        {
            try
            {
                cmbpais.Items.Clear();
                MySqlCommand comando = new MySqlCommand("select Nombre_Pais from paises", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    cmbpais.Items.Add(leer.GetString(0));
                }
                miconexion.Close();
            }
            catch
            {
                miconexion.Close();
                return;
            }
        }

        void ciudad()
        {
            try
            {
                cmbciudad.Items.Clear();
                MySqlCommand comando = new MySqlCommand("select Nombre_Ciudad from ciudades", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    cmbciudad.Items.Add(leer.GetString(0));
                    cmbdomrut.Items.Add(leer.GetString(0));
                }
                miconexion.Close();
            }
            catch
            {
                miconexion.Close();
                return;
            }
        }

        void sectorcomercial()
        {
            try
            {
                cmbsector.Items.Clear();
                MySqlCommand comando = new MySqlCommand("select Nombre_Sector from sector_comercial", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    cmbsector.Items.Add(leer.GetString(0));
                }
                miconexion.Close();
            }
            catch
            {
                miconexion.Close();
                return;
            }
        }

        void formapago()
        {
            try
            {
                cmbformapago.Items.Clear();
                MySqlCommand comando = new MySqlCommand("select Nombre_Forma_Pago from forma_pago", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    cmbformapago.Items.Add(leer.GetString(0));
                }
                miconexion.Close();
            }
            catch
            {
                miconexion.Close();
                return;
            }
        }


        //traer id´s
        void traeridregimen()
        {
            try
            {
                if (txtrazon.ReadOnly == false)
                {
                    if (cmbregimen.Text != "")
                    {
                        MySqlCommand regimen = new MySqlCommand("select IdRegimen from regimen where Nombre_Regimen='" + cmbregimen.Text + "'", miconexion);
                        miconexion.Open();
                        MySqlDataReader leer = regimen.ExecuteReader();
                        if (leer.Read())
                        {
                            idregimen = leer.GetInt32(0);
                        }
                        miconexion.Close();
                    }
                }
            }
            catch
            {
                miconexion.Close();
                return;
            }
        }

        void traeridpais()
        {
            try
            {
                if (txtrazon.ReadOnly == false)
                {
                    if (cmbpais.Text != "")
                    {
                        MySqlCommand pais = new MySqlCommand("select IdPais from paises where Nombre_Pais='" + cmbpais.Text + "'", miconexion);
                        miconexion.Open();
                        MySqlDataReader leer = pais.ExecuteReader();
                        if (leer.Read())
                        {
                            idpais = leer.GetInt32(0);
                        }
                        miconexion.Close();
                    }
                }
            }
            catch
            {
                miconexion.Close();
                return;
            }
        }

        void traeridciudad()
        {
            try
            {
                if (txtrazon.ReadOnly == false)
                {
                    if (cmbciudad.Text != "")
                    {
                        MySqlCommand ciudad = new MySqlCommand("select IdCiudad from ciudades where Nombre_Ciudad='" + cmbciudad.Text + "'", miconexion);
                        miconexion.Open();
                        MySqlDataReader leer = ciudad.ExecuteReader();
                        if (leer.Read())
                        {
                            idciudad = leer.GetInt32(0);
                        }
                        miconexion.Close();
                    }
                }
            }
            catch
            {
                miconexion.Close();
                return;
            }
        }

        void traeridsector()
        {
            try
            {
                if (txtrazon.ReadOnly == false)
                {
                    if (cmbsector.Text != "")
                    {
                        MySqlCommand regimen = new MySqlCommand("select IdSector from sector_comercial where Nombre_Sector='" + cmbsector.Text + "'", miconexion);
                        miconexion.Open();
                        MySqlDataReader leer = regimen.ExecuteReader();
                        if (leer.Read())
                        {
                            idsector = leer.GetInt32(0);
                        }
                        miconexion.Close();
                    }
                }
            }
            catch
            {
                miconexion.Close();
                return;
            }
        }

        void traeridomiciliorut()
        {
            try
            {
                if (txtrazon.ReadOnly == false)
                {
                    if (cmbdomrut.Text != "")
                    {
                        MySqlCommand domiciliorut = new MySqlCommand("select IdCiudad from ciudades where Nombre_Ciudad='" + cmbdomrut.Text + "'", miconexion);
                        miconexion.Open();
                        MySqlDataReader leer = domiciliorut.ExecuteReader();
                        if (leer.Read())
                        {
                            idomiciliorut = leer.GetInt32(0);
                        }
                        miconexion.Close();
                    }
                }
            }
            catch
            {
                miconexion.Close();
                return;
            }
        }

        void traeridformapago()
        {
            try
            {
                if (txtrazon.ReadOnly == false)
                {
                    if (cmbformapago.Text != "")
                    {
                        MySqlCommand formapago = new MySqlCommand("select IdFormpago from forma_pago where Nombre_Forma_Pago='" + cmbformapago.Text + "'", miconexion);
                        miconexion.Open();
                        MySqlDataReader leer = formapago.ExecuteReader();
                        if (leer.Read())
                        {
                            idformapago = leer.GetInt32(0);
                        }
                        miconexion.Close();
                    }
                }
            }
            catch
            {
                miconexion.Close();
                return;
            }
        }

        void grabar()
        {
            try
            {
                MySqlCommand grabar = new MySqlCommand("insert into cliente (IdCliente, Nombre_Cliente, Nombre_RUT, IdRegimen, Direccion, Telefono, Fax, IdCiudad, IdSector_Comercial, Cupo_Credito, Web, Domicilio_RUT, IdFormPago, Condiciones_Comerciales, Observaciones, Email, contacto1, contacto2)values(@IdCliente, @Nombre_Cliente, @Nombre_RUT, @IdRegimen, @Direccion, @Telefono, @Fax, @IdCiudad, @IdSector_Comercial, @Cupo_Credito, @Web, @Domicilio_RUT, @IdFormPago, @Condiciones_Comerciales, @Observaciones, @Email, @contacto1, @contacto2)", miconexion);
                grabar.Parameters.AddWithValue("IdCliente", txtcodigo.Text);
                grabar.Parameters.AddWithValue("Nombre_Cliente", txtrazon.Text);
                grabar.Parameters.AddWithValue("Nombre_RUT", txtrut.Text);
                grabar.Parameters.AddWithValue("IdRegimen", idregimen);
                grabar.Parameters.AddWithValue("Direccion", txtdireccion.Text);
                grabar.Parameters.AddWithValue("Telefono", msktelefono.Text);
                grabar.Parameters.AddWithValue("Fax", mskfax.Text);
                grabar.Parameters.AddWithValue("IdCiudad", idciudad);
                grabar.Parameters.AddWithValue("IdSector_Comercial", idsector);
                grabar.Parameters.AddWithValue("Cupo_Credito", txtcredito.Text);
                grabar.Parameters.AddWithValue("Web", txtweb.Text);
                grabar.Parameters.AddWithValue("Domicilio_RUT", idomiciliorut);
                grabar.Parameters.AddWithValue("IdFormPago", idformapago);
                grabar.Parameters.AddWithValue("Condiciones_Comerciales", txtcondiciones.Text);
                grabar.Parameters.AddWithValue("Observaciones", txtobserv.Text);
                grabar.Parameters.AddWithValue("Email", txtemail.Text);
                grabar.Parameters.AddWithValue("contacto1", txtcontacto1.Text);
                grabar.Parameters.AddWithValue("contacto2", txtcontacto2.Text);
                miconexion.Open();
                grabar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro Exitoso!");                
                cmdnuevo.Enabled = true;
                cmdmodific.Enabled = true;
                cmdeliminar.Enabled = true;
                cmdgrabar.Enabled = false;
                cmbselecliente.Enabled = true;                
                cmbselecliente.Focus();

                txtcodigo.ReadOnly = true;
                txtrazon.ReadOnly = true;
                txtrut.Enabled = true;
                txtdireccion.ReadOnly = true;
                msktelefono.ReadOnly = true;
                mskfax.ReadOnly = true;
                txtcredito.ReadOnly = true;
                txtemail.ReadOnly = true;
                txtweb.ReadOnly = true;
                txtobserv.ReadOnly = true;
                txtcondiciones.ReadOnly = true;
                txtcontacto1.ReadOnly = true;
                txtcontacto2.ReadOnly = true;
            }
            catch
            {
                miconexion.Close();
                return;
            }
        }


        void actualizar()
        {
            try
            {                
                MySqlCommand grabar = new MySqlCommand("update cliente set  Nombre_Cliente=@Nombre_Cliente, Nombre_RUT=@Nombre_RUT, IdRegimen=@IdRegimen, Direccion=@Direccion, Telefono=@Telefono, Fax=@Fax, IdCiudad=@IdCiudad, IdSector_Comercial=@IdCiudad, Cupo_Credito=@Cupo_Credito, Web=@Web, Domicilio_RUT=@Domicilio_RUT, IdFormPago=@IdFormPago, Condiciones_Comerciales=@Condiciones_Comerciales, Observaciones=@Observaciones, Email=@Email, contacto1=@contacto1, contacto2=@contacto2 where IdCliente=" + txtcodigo.Text, miconexion);
                grabar.Parameters.AddWithValue("Nombre_Cliente", txtrazon.Text);
                grabar.Parameters.AddWithValue("Nombre_RUT", txtrut.Text);
                grabar.Parameters.AddWithValue("IdRegimen", idregimen);
                grabar.Parameters.AddWithValue("Direccion", txtdireccion.Text);
                grabar.Parameters.AddWithValue("Telefono", msktelefono.Text);
                grabar.Parameters.AddWithValue("Fax", mskfax.Text);
                grabar.Parameters.AddWithValue("IdCiudad", idciudad);
                grabar.Parameters.AddWithValue("IdSector_Comercial", idsector);
                grabar.Parameters.AddWithValue("Cupo_Credito", txtcredito.Text);
                grabar.Parameters.AddWithValue("Web", txtweb.Text);
                grabar.Parameters.AddWithValue("Domicilio_RUT", idomiciliorut);
                grabar.Parameters.AddWithValue("IdFormPago", idformapago);
                grabar.Parameters.AddWithValue("Condiciones_Comerciales", txtcondiciones.Text);
                grabar.Parameters.AddWithValue("Observaciones", txtobserv.Text);
                grabar.Parameters.AddWithValue("Email", txtemail.Text);
                grabar.Parameters.AddWithValue("contacto1", txtcontacto1.Text);
                grabar.Parameters.AddWithValue("contacto2", txtcontacto2.Text);
                miconexion.Open();
                grabar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Actualizacion Exitosa!");                
                cmdnuevo.Enabled = true;
                cmdmodific.Enabled = true;
                cmdgrabar.Enabled = false;
                cmbselecliente.Enabled = true;
                cmbselecliente.Focus();

                txtcodigo.ReadOnly = true;
                txtrazon.ReadOnly = true;
                txtrut.Enabled = true;
                txtdireccion.ReadOnly = true;
                msktelefono.ReadOnly = true;
                mskfax.ReadOnly = true;
                txtcredito.ReadOnly = true;
                txtemail.ReadOnly = true;
                txtweb.ReadOnly = true;
                txtobserv.ReadOnly = true;
                txtcondiciones.ReadOnly = true;
                txtcontacto1.ReadOnly = true;
                txtcontacto2.ReadOnly = true;                
            }
            catch
            {
                miconexion.Close();
                return;
            }
        }

        private void cmdcerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            funcion.guardar_seguimiento("Sale de formulario Clientes",recibir_usuario);
        }
        private void cmbregimen_TextChanged(object sender, EventArgs e)
        {
            traeridregimen();
        }

        private void cmbpais_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridpais();
        }

        private void cmbciudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridciudad();
        }

        private void cmbsector_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridsector();
        }

        private void cmbdomrut_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridomiciliorut();
        }

        private void cmbformapago_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridformapago();
        }

        private void cmdgrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (recibir_tipousuario == "1" || recibir_tipousuario == "2")
                {
                    if (txtcodigo.Text == "")
                    {
                        MessageBox.Show("Digite codigo para 'Cliente'");
                        txtcodigo.Focus();
                        return;
                    }
                    if (txtrazon.Text == "")
                    {
                        MessageBox.Show("Digite el nombre o razon social");
                        txtrazon.Focus();
                        return;
                    }
                    if (cmbregimen.Text == "")
                    {
                        MessageBox.Show("Seleccione el régimen");
                        cmbregimen.Focus();
                        return;
                    }
                    if (cmbpais.Text == "")
                    {
                        MessageBox.Show("Seleccione pais");
                        cmbpais.Focus();
                        return;
                    }
                    if (cmbciudad.Text == "")
                    {
                        MessageBox.Show("Seleccione ciudad");
                        cmbciudad.Focus();
                        return;
                    }
                    if (cmbsector.Text == "")
                    {
                        MessageBox.Show("Seleccione sector");
                        cmbsector.Focus();
                        return;
                    }
                    if (cmbdomrut.Text == "")
                    {
                        MessageBox.Show("Seleccione domicilio del RUT");
                        cmbdomrut.Focus();
                        return;
                    }
                    if (cmbformapago.Text == "")
                    {
                        MessageBox.Show("Seleccione forma de pago");
                        cmbformapago.Focus();
                        return;
                    }
                    MySqlCommand comando = new MySqlCommand("select IdCliente from Cliente where IdCliente=" + txtcodigo.Text, miconexion);
                    miconexion.Open();
                    MySqlDataReader leer = comando.ExecuteReader();

                    if (leer.Read())
                    {
                        miconexion.Close();
                        actualizar();
                        funcion.guardar_seguimiento("Actualiza registro de Cliente", recibir_usuario);
                    }
                    else
                    {
                        miconexion.Close();
                        grabar();
                        funcion.guardar_seguimiento("Registra Cliente", recibir_usuario);
                    }
                    miconexion.Close();
                }
                else
                {
                    MessageBox.Show("Usuario no tiene permisos para registrar clientes");
                }
            }
            catch(Exception exec)
            {
                MessageBox.Show("Error al grabar cliente: "+exec.Message);
                miconexion.Close();
                return;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            cargadatoinicial();
            regimen();
            pais();
            ciudad();
            sectorcomercial();
            formapago();
            cargadatos();
            cargarnombrecliente();

            timer1.Enabled = false;
        }

        private void cmdnuevo_Click(object sender, EventArgs e)
        {
            if (recibir_tipousuario == "3")
            {
                MessageBox.Show("Usuario no tiene permisos para habilitar nuevo registro");
                return;
            }
            else
            {
                txtcodigo.Focus();
                txtcontacto1.Text = "";
                txtcontacto2.Text = "";
                cmbselecliente.Text = "";
                txtcodigo.Text = "";
                txtrazon.Text = "";
                txtrut.Text = "";
                cmbregimen.Text = "";
                txtdireccion.Text = "";
                cmbpais.Text = "";
                cmbciudad.Text = "";
                cmbsector.Text = "";
                msktelefono.Text = "";
                mskfax.Text = "";
                txtcredito.Text = "";
                cmbdomrut.Text = "";
                txtemail.Text = "";
                txtweb.Text = "";
                txtobserv.Text = "";
                cmbformapago.Text = "";
                txtcondiciones.Text = "";

                cmbselecliente.Enabled = false;
                cmdmodific.Enabled = false;
                cmdnuevo.Enabled = false;
                cmdeliminar.Enabled=false;
                cmdgrabar.Enabled = true;

                txtcodigo.ReadOnly = false;
                txtrazon.ReadOnly = false;
                txtrut.ReadOnly = false;
                txtdireccion.ReadOnly = false;
                msktelefono.ReadOnly = false;
                mskfax.ReadOnly = false;
                txtcredito.ReadOnly = false;
                txtemail.ReadOnly = false;
                txtweb.ReadOnly = false;
                txtobserv.ReadOnly = false;
                txtcondiciones.ReadOnly = false;
                txtcontacto1.ReadOnly = false;
                txtcontacto2.ReadOnly = false;
                funcion.guardar_seguimiento("Intenta registrar Cliente", recibir_usuario);
            }            
        }

        //Cargar Nombre Cliente
        void cargarnombrecliente()
        {
            cmbselecliente.Items.Clear();
            MySqlCommand comando = new MySqlCommand("select * from cliente", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(3);
                cmbselecliente.Items.Add(nombre);
            }
            miconexion.Close();
        }

        void cargadatos()
        {
            try
            {
                if (cmbselecliente.Text != "")
                {
                    MySqlCommand comando = new MySqlCommand("Select cli.IdCliente, cli.Nombre_Cliente, cli.Nombre_RUT, cli.Direccion, cli.Telefono, cli.Fax, cli.Cupo_Credito, cli.Web, cli.Condiciones_Comerciales, cli.Observaciones, cli.Email, cli.Contacto1, cli.Contacto2, reg.Nombre_Regimen, sec.Nombre_Sector, pais.Nombre_Pais, ciu.Nombre_Ciudad, fmp.Nombre_Forma_Pago, ciu.Nombre_Ciudad from cliente cli, regimen reg, sector_comercial sec, paises pais, ciudades ciu, forma_pago fmp where cli.Nombre_Cliente='" + cmbselecliente.Text + "' and cli.IdRegimen=reg.IdRegimen and cli.IdSector_Comercial=sec.IdSector and cli.IdCiudad=ciu.IdCiudad and cli.IdFormPago=fmp.IdFormPago and pais.IdPais=ciu.IdPais and cli.Domicilio_RUT=ciu.Idciudad", miconexion);
                    miconexion.Open();
                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        txtcodigo.Text = leer.GetString(0);
                        txtrazon.Text = leer.GetString(1);
                        txtrut.Text = leer.GetString(2);
                        txtdireccion.Text = leer.GetString(3);
                        msktelefono.Text = leer.GetString(4);
                        mskfax.Text = leer.GetString(5);
                        txtcredito.Text = leer.GetString(6);
                        txtweb.Text = leer.GetString(7);
                        txtcondiciones.Text = leer.GetString(8);
                        txtobserv.Text = leer.GetString(9);
                        txtemail.Text = leer.GetString(10);

                        try
                        {
                            txtcontacto1.Text = leer.GetString(11);
                        }
                        catch
                        {
                            txtcontacto1.Text = "";
                        }


                        try
                        {
                            txtcontacto2.Text = leer.GetString(12);
                        }
                        catch
                        {
                            txtcontacto2.Text = "";
                        }


                        cmbregimen.Text = leer.GetString(13);                        
                        cmbpais.Text = leer.GetString(15);
                        cmbsector.Text = leer.GetString(14);
                        cmbciudad.Text = leer.GetString(16);
                        cmbformapago.Text = leer.GetString(17);
                        cmbdomrut.Text = leer.GetString(18);
                    }
                    miconexion.Close();
                }
            }
            catch
            {
                miconexion.Close();
                return;
            }
            
        }   

        private void cmdlistacliente_Click(object sender, EventArgs e)
        {
            Frmconsultaclientes cliente = new Frmconsultaclientes();
            cliente.Show();
        }

        private void cmbselecliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbselecliente.Text != "")
            {
                cargadatos();                
            }
        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            funcion.guardar_seguimiento("Entra a formulario Clientes",recibir_usuario);
        }

        private void cmdeliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (recibir_tipousuario == "1")
                {
                    DialogResult resultado = MessageBox.Show("¿Desea eliminar el registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.No)
                    {
                        return;
                    }
                    MySqlCommand eliminar = new MySqlCommand("delete from cliente where idcliente=@id", miconexion);
                    eliminar.Parameters.AddWithValue("id", txtcodigo.Text);
                    miconexion.Open();
                    eliminar.ExecuteNonQuery();
                    miconexion.Close();
                    MessageBox.Show("Registro Eliminado!");
                    funcion.guardar_seguimiento("Elimina registro de Cliente", recibir_usuario);
                    cmdmodific.Enabled = false;
                    cmdeliminar.Enabled = false;
                    cmdnuevo.Enabled = true;
                    cmdgrabar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Usuario actual no tiene permisos para eliminar registro de clientes");
                }
            }
            catch(Exception exec)
            {
                MessageBox.Show("Error en comando eliminar"+exec.Message);
            }             
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtcredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmdmodific_Click(object sender, EventArgs e)
        {
            if (recibir_tipousuario == "1")
            {
                cmdnuevo.Enabled = false;
                cmdgrabar.Enabled = true;
                cmdeliminar.Enabled = false;
                cmdmodific.Enabled = false;
                txtrazon.Focus();
                txtcodigo.ReadOnly = false;
                txtrazon.ReadOnly = false;
                txtrut.Enabled = false;
                txtdireccion.ReadOnly = false;
                msktelefono.ReadOnly = false;
                mskfax.ReadOnly = false;
                txtcredito.ReadOnly = false;
                txtemail.ReadOnly = false;
                txtweb.ReadOnly = false;
                txtobserv.ReadOnly = false;
                txtcondiciones.ReadOnly = false;
                txtcontacto1.ReadOnly = false;
                txtcontacto2.ReadOnly = false;
                funcion.guardar_seguimiento("Intenta modificar registro de Cliente", recibir_usuario);
            }
            else
            {
                MessageBox.Show("Usuario no tiene permisos para actualizar registro de clientes");
            }
        }        
   }
}
