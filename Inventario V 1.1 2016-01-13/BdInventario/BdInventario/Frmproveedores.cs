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
    public partial class Frmproveedores : Plantiterceros
    {
        funciones funcion = new funciones();
        public Frmproveedores()
        {
            InitializeComponent();
            txtcodigo.ReadOnly = true;
            txtrazon.ReadOnly = true;
            txtrut.ReadOnly = true;
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
            cmdgrabar.Enabled = false;

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
        int idactividad;
        int idomiciliorut;
        int idformapago;
        public string recibir_tipousuario = "";
        public string recibir_usuario = "";

        void cargadatoinicial()
        {
            try
            {                
                MySqlCommand comando = new MySqlCommand("Select cli.Nombre_Proveedor, cli.Nombre_RUT, cli.Direccion, cli.Telefono, cli.Fax, cli.Cupo_Credito, cli.Web_Site, cli.Condiciones_Comerciales, cli.Observaciones, cli.Email, cli.IdProveedor, cli.Contacto1, cli.Contacto2, reg.Nombre_Regimen, fmp.Nombre_Forma_Pago, act.Actividad, ciu.Nombre_Ciudad, ciu.Nombre_Ciudad, pais.Nombre_Pais from proveedores cli, regimen reg, forma_pago fmp, actividad_comercial act, ciudades ciu, paises pais where 1 and cli.IdRegimen=reg.IdRegimen and cli.IdFormPago=fmp.IdFormPago and cli.IdActivComer=act.IdActividad and cli.IdCiudad=ciu.IdCiudad and cli.Domicilio_RUT=ciu.Idciudad and  pais.IdPais=ciu.IdPais", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    txtrazon.Text = leer.GetString(0);
                    txtrut.Text = leer.GetString(1);
                    txtdireccion.Text = leer.GetString(2);
                    msktelefono.Text = leer.GetString(3);
                    mskfax.Text = leer.GetString(4);
                    txtcredito.Text = leer.GetString(5);
                    txtweb.Text = leer.GetString(6);
                    txtcondiciones.Text = leer.GetString(7);
                    txtobserv.Text = leer.GetString(8);
                    txtemail.Text = leer.GetString(9);
                    txtcodigo.Text = leer.GetString(10);
                    txtcontacto1.Text = leer.GetString(11);
                    txtcontacto2.Text = leer.GetString(12);
                    try
                    {
                        cmbregimen.Text = leer.GetString(13);
                    }
                    catch
                    {
                        cmbregimen.Text = cmbregimen.Text;
                    }
                    try
                    {
                        cmbformapago.Text = leer.GetString(14);
                    }
                    catch
                    {
                        cmbformapago.Text = cmbformapago.Text;
                    }
                    try
                    {
                        cmbactividad.Text = leer.GetString(15);
                    }
                    catch
                    {
                        cmbactividad.Text = cmbactividad.Text;
                    }
                    try
                    {
                        cmbciudad.Text = leer.GetString(16);
                    }
                    catch
                    {
                        cmbciudad.Text = cmbciudad.Text;
                    }
                    try
                    {
                        cmbdomrut.Text = leer.GetString(17);
                    }
                    catch
                    {
                        cmbdomrut.Text = cmbdomrut.Text;
                    }
                    try
                    {
                        cmbpais.Text = leer.GetString(18);
                    }
                    catch
                    {
                        cmbpais.Text = cmbpais.Text;
                    }
                }
                miconexion.Close();                
            }
            catch (SystemException exec)
            {
                MessageBox.Show("Error de carga inicial: " + exec.Message);
            }
        }     

        //Consulta para cargar nombre regimen de la tala regimen
        void regimen()
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

        void pais()
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

        void ciudad()
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

        void actividadcomercial()
        {
            cmbactividad.Items.Clear();
            MySqlCommand comando = new MySqlCommand("select Actividad from actividad_comercial", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cmbactividad.Items.Add(leer.GetString(0));
            }
            miconexion.Close();
        }

        void formapago()
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

        //Cargar Nombre Cliente
        void cargarnombreproveedor()
        {
            MySqlCommand comando = new MySqlCommand("select nombre_proveedor from proveedores", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(0);
                cmbproveedores.Items.Add(nombre);
            }
            miconexion.Close();
        }
        
        private void cmbselecliente_TextChanged(object sender, EventArgs e)
        {
            if (cmbproveedores.Text != "")
            {
                cargadatos();
            }
        }

        void traeridregimen()
        {
            if (cmbregimen.Text != "")
            {
                MySqlCommand regimen = new MySqlCommand("select idregimen from regimen where Nombre_Regimen='" + cmbregimen.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = regimen.ExecuteReader();
                if (leer.Read())
                {
                    idregimen = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        void traeridpais()
        {
            if (cmbpais.Text != "")
            {
                MySqlCommand regimen = new MySqlCommand("select IdPais from paises where Nombre_Pais='" + cmbpais.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = regimen.ExecuteReader();
                if (leer.Read())
                {
                    idpais = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        void traeridciudad()
        {
            if (cmbciudad.Text != "")
            {
                MySqlCommand regimen = new MySqlCommand("select IdCiudad from ciudades where Nombre_Ciudad='" + cmbciudad.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = regimen.ExecuteReader();
                if (leer.Read())
                {
                    idciudad = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        void traeridactividad()
        {
            if (cmbactividad.Text != "")
            {
                MySqlCommand comando = new MySqlCommand("select idactividad from actividad_comercial where actividad='" + cmbactividad.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    idactividad = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        void traeridomiciliorut()
        {
            if (cmbdomrut.Text != "")
            {
                MySqlCommand comando = new MySqlCommand("select IdCiudad from ciudades where Nombre_Ciudad='" + cmbdomrut.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    idomiciliorut = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        void traeridformapago()
        {
            if (cmbformapago.Text != "")
            {
                MySqlCommand comando = new MySqlCommand("select IdFormpago from forma_pago where Nombre_Forma_Pago='" + cmbformapago.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    idformapago = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        private void cmbformapago_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            traeridformapago();
        }

        private void cmbregimen_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridregimen();
        }

        private void cmbpais_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            traeridpais();
        }

        private void cmbciudad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            traeridciudad();
        }

        private void cmbdomrut_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            traeridciudad();
        }

        private void cmbactividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridactividad();
        }         

        void actualizar()
        {
            try
            {
                MySqlCommand grabar = new MySqlCommand("update proveedores set  Nombre_Cliente=@Nombre_Proveedor, Nombre_RUT=@Nombre_RUT, IdRegimen=@IdRegimen, Direccion=@Direccion, Telefono=@Telefono, Fax=@Fax, IdCiudad=@IdCiudad, IdActivComer=@IdActivComer, Cupo_Credito=@Cupo_Credito, Web=@Web, Domicilio_RUT=@Domicilio_RUT, IdFormPago=@IdFormPago, Condiciones_Comerciales=@Condiciones_Comerciales, Observaciones=@Observaciones, Email=@Email, idpais=@Idpais, contacto1=@contacto1, contacto2=@contacto2 where IdProveedor='" + txtcodigo.Text + "'", miconexion);
                grabar.Parameters.AddWithValue("Nombre_Proveedor", txtrazon.Text);
                grabar.Parameters.AddWithValue("Nombre_RUT", txtrut.Text);
                grabar.Parameters.AddWithValue("IdRegimen", idregimen);
                grabar.Parameters.AddWithValue("Direccion", txtdireccion.Text);
                grabar.Parameters.AddWithValue("Telefono", msktelefono.Text);
                grabar.Parameters.AddWithValue("Fax", mskfax.Text);
                grabar.Parameters.AddWithValue("IdCiudad", idciudad);
                grabar.Parameters.AddWithValue("IdActivComer", idactividad);
                grabar.Parameters.AddWithValue("Cupo_Credito", txtcredito.Text);
                grabar.Parameters.AddWithValue("Web", txtweb.Text);
                grabar.Parameters.AddWithValue("Domicilio_RUT", idomiciliorut);
                grabar.Parameters.AddWithValue("IdFormPago", idformapago);
                grabar.Parameters.AddWithValue("Condiciones_Comerciales", txtcondiciones.Text);
                grabar.Parameters.AddWithValue("Observaciones", txtobserv.Text);
                grabar.Parameters.AddWithValue("Email", txtemail.Text);
                grabar.Parameters.AddWithValue("idpais", idpais);
                grabar.Parameters.AddWithValue("contacto1", txtcontacto1.Text);
                grabar.Parameters.AddWithValue("contacto2", txtcontacto2.Text);                
                miconexion.Open();
                grabar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Actualizacion Exitosa!");                
                cmdnuevo.Enabled = true;
                cmdmodific.Enabled = true;
                cmdgrabar.Enabled = false;
                cmdeliminar.Enabled = true;
                cmbproveedores.Enabled = true;
                cmbproveedores.Focus();

                txtcodigo.ReadOnly = true;
                txtrazon.ReadOnly = true;
                txtrut.ReadOnly = true;
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

        void grabar()
        {
            try
            {
                MySqlCommand grabar = new MySqlCommand("insert into proveedores (IdProveedor, Nombre_Proveedor, Nombre_RUT, IdRegimen, Direccion, Telefono, Fax, IdCiudad, IdActivComer, Cupo_Credito, Web_Site, Email, Domicilio_RUT, IdFormPago, Condiciones_Comerciales, Observaciones, idpais, contacto1, contacto2)values(@IdProveedor, @Nombre_Proveedor, @Nombre_RUT, @IdRegimen, @Direccion, @Telefono, @Fax, @IdCiudad, @IdActivComer, @Cupo_Credito, @Web_Site, @Email, @Domicilio_RUT, @IdFormPago, @Condiciones_Comerciales, @Observaciones, @idpais, @contacto1, @contacto2)", miconexion);
                grabar.Parameters.AddWithValue("IdProveedor", txtcodigo.Text);
                grabar.Parameters.AddWithValue("Nombre_Proveedor", txtrazon.Text);
                grabar.Parameters.AddWithValue("Nombre_RUT", txtrut.Text);
                grabar.Parameters.AddWithValue("IdRegimen", idregimen);
                grabar.Parameters.AddWithValue("Direccion", txtdireccion.Text);
                grabar.Parameters.AddWithValue("Telefono", msktelefono.Text);
                grabar.Parameters.AddWithValue("Fax", mskfax.Text);
                grabar.Parameters.AddWithValue("IdCiudad", idciudad);
                grabar.Parameters.AddWithValue("IdActivComer", idactividad);
                grabar.Parameters.AddWithValue("Cupo_Credito", txtcredito.Text);
                grabar.Parameters.AddWithValue("Web_Site", txtweb.Text);
                grabar.Parameters.AddWithValue("Email", txtemail.Text);
                grabar.Parameters.AddWithValue("Domicilio_RUT", idciudad);
                grabar.Parameters.AddWithValue("IdFormPago", idformapago);
                grabar.Parameters.AddWithValue("Condiciones_Comerciales", txtcondiciones.Text);
                grabar.Parameters.AddWithValue("Observaciones", txtobserv.Text);
                grabar.Parameters.AddWithValue("idpais", idpais);
                grabar.Parameters.AddWithValue("contacto1", txtcontacto1.Text);
                grabar.Parameters.AddWithValue("contacto2", txtcontacto2.Text);
                miconexion.Open();
                grabar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro Exitoso!");
                cmdnuevo.Enabled = true;
                cmdmodific.Enabled = true;
                cmdgrabar.Enabled = false;
                cmdeliminar.Enabled = true;
                cmbproveedores.Focus();
                cmbproveedores.Enabled = true;
            }
            catch (SystemException exec)
            {
                MessageBox.Show("Error en insert: " + exec.Message);
            }
        }         

        void cargadatos()
        {
           try
            {
                if (cmbproveedores.Text != "")
                {
                    MySqlCommand comando = new MySqlCommand("Select cli.Nombre_Proveedor, cli.Nombre_RUT, cli.Direccion, cli.Telefono, cli.Fax, cli.Cupo_Credito, cli.Web_Site, cli.Condiciones_Comerciales, cli.Observaciones, cli.Email, cli.IdProveedor, cli.Contacto1, cli.Contacto2, reg.Nombre_Regimen, fmp.Nombre_Forma_Pago, act.Actividad, ciu.Nombre_Ciudad, ciu.Nombre_Ciudad, pais.Nombre_Pais from proveedores cli, regimen reg, forma_pago fmp, actividad_comercial act, ciudades ciu, paises pais where cli.Nombre_Proveedor='" + cmbproveedores.Text + "' and cli.IdRegimen=reg.IdRegimen and cli.IdFormPago=fmp.IdFormPago and cli.IdActivComer=act.IdActividad and cli.IdCiudad=ciu.IdCiudad and cli.Domicilio_RUT=ciu.Idciudad and  pais.IdPais=ciu.IdPais", miconexion);
                    miconexion.Open();
                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {                        
                        txtrazon.Text = leer.GetString(0);
                        txtrut.Text = leer.GetString(1);
                        txtdireccion.Text = leer.GetString(2);
                        msktelefono.Text = leer.GetString(3);
                        mskfax.Text = leer.GetString(4);
                        txtcredito.Text = leer.GetString(5);                        
                        txtweb.Text = leer.GetString(6);
                        txtcondiciones.Text = leer.GetString(7);
                        txtobserv.Text = leer.GetString(8);
                        txtemail.Text = leer.GetString(9);
                        txtcodigo.Text = leer.GetString(10);                       
                        txtcontacto1.Text = leer.GetString(11);                    
                        txtcontacto2.Text = leer.GetString(12);
                        try
                        {
                            cmbregimen.Text = leer.GetString(13);
                        }
                        catch
                        {
                            cmbregimen.Text = cmbregimen.Text;
                        }
                        try
                        {
                            cmbformapago.Text = leer.GetString(14);
                        }
                        catch
                        {
                            cmbformapago.Text = cmbformapago.Text;
                        }
                        try
                        {
                            cmbactividad.Text = leer.GetString(15);
                        }
                        catch
                        {
                            cmbactividad.Text = cmbactividad.Text;
                        }
                        try
                        {
                            cmbciudad.Text = leer.GetString(16);
                        }
                        catch
                        {
                            cmbciudad.Text = cmbciudad.Text;
                        }
                        try
                        {
                            cmbdomrut.Text = leer.GetString(17);
                        }
                        catch
                        {
                            cmbdomrut.Text = cmbdomrut.Text;
                        }
                        try
                        {
                            cmbpais.Text = leer.GetString(18);
                        }
                        catch
                        {
                            cmbpais.Text = cmbpais.Text;
                        }
                    }
                    miconexion.Close();
                }             
            }
            catch(SystemException exec)
            {
                MessageBox.Show("Error al cargar datos de proveedor: " + exec.Message);                
            }
        }

        private void cmdgrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (recibir_tipousuario == "1" || recibir_tipousuario == "2")
                {
                    if (txtcodigo.Text == "")
                    {
                        MessageBox.Show("Digite un codigo para proveedor");
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
                        MessageBox.Show("Seleccione el país");
                        cmbpais.Focus();
                        return;
                    }
                    if (cmbciudad.Text == "")
                    {
                        MessageBox.Show("Seleccione la ciudad");
                        cmbciudad.Focus();
                        return;
                    }
                    if (cmbactividad.Text == "")
                    {
                        MessageBox.Show("Seleccione la actividad");
                        cmbactividad.Focus();
                        return;
                    }
                    if (cmbdomrut.Text == "")
                    {
                        MessageBox.Show("Seleccione el domicilio del RUT");
                        cmbdomrut.Focus();
                        return;
                    }
                    if (cmbformapago.Text == "")
                    {
                        MessageBox.Show("Seleccione la forma de pago");
                        cmbformapago.Focus();
                        return;
                    }
                    MySqlCommand comando = new MySqlCommand("select IdProveedor from Proveedores where IdProveedor='" + txtcodigo.Text + "'", miconexion);
                    miconexion.Open();
                    MySqlDataReader leer = comando.ExecuteReader();

                    if (leer.Read())
                    {
                        miconexion.Close();
                        actualizar();
                        funcion.guardar_seguimiento("Actualiza registro de Proveedor", recibir_usuario);
                    }
                    else
                    {
                        miconexion.Close();
                        grabar();
                        funcion.guardar_seguimiento("Registra Proveedor", recibir_usuario);
                    }
                    miconexion.Close();
                }
                else
                {
                    MessageBox.Show("Usuario no tiene permisos para registrar proveedores");
                }
            }
            catch(SyntaxErrorException exec)
            {
                MessageBox.Show("Error al guardar registro" + exec.Message);
                miconexion.Close();
                return;
            }
        }

        private void cmdcerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            funcion.guardar_seguimiento("Sale de formulario Proveedores", recibir_usuario);
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
                txtcodigo.Text = "";
                txtrazon.Text = "";
                txtrut.Text = "";
                txtdireccion.Text = "";
                msktelefono.Text = "";
                mskfax.Text = "";
                txtcredito.Text = "";
                txtemail.Text = "";
                txtweb.Text = "";
                txtobserv.Text = "";
                txtcondiciones.Text = "";
                txtcontacto1.Text = "";
                txtcontacto2.Text = "";
                cmbregimen.Text = "";
                cmbpais.Text = "";
                cmbciudad.Text = "";
                cmbactividad.Text = "";
                cmbdomrut.Text = "";
                cmbformapago.Text = "";

                cmbproveedores.Enabled = false;
                cmdmodific.Enabled = false;
                cmdnuevo.Enabled = false;
                cmdmodific.Enabled = false;
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
                funcion.guardar_seguimiento("Intenta registrar Proveedor", recibir_usuario);
            }            
        }       

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            cargadatoinicial();
            regimen();
            pais();
            ciudad();
            actividadcomercial();
            formapago();            
            cargadatos();
            cargarnombreproveedor();
            timer1.Enabled = false;
        }        

        private void cmbproveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbproveedores.Text != "")
            {
                cargadatos();
                cmdmodific.Enabled = true;                
            }
        }

        private void cmdlistaproveedor_Click(object sender, EventArgs e)
        {
            Frmconsultaproveedores proveedores = new Frmconsultaproveedores();
            proveedores.Show();
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
                    MySqlCommand eliminar = new MySqlCommand("delete from proveedores where idproveedor=@id", miconexion);
                    eliminar.Parameters.AddWithValue("id", txtcodigo.Text);
                    miconexion.Open();
                    eliminar.ExecuteNonQuery();
                    miconexion.Close();
                    MessageBox.Show("Registro Eliminado!");
                    funcion.guardar_seguimiento("Elimina registro de Proveedor", recibir_usuario);
                    cmdmodific.Enabled = false;
                    cmdeliminar.Enabled = false;
                    cmdnuevo.Enabled = true;
                    cmdgrabar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Usuario actual no tiene permisos para eliminar proveedores");
                }
            }
            catch (Exception exec)
            {
                MessageBox.Show("Error en comando eliminar" + exec.Message);
            }
        }

        private void cmdmodific_Click(object sender, EventArgs e)
        {
            if (recibir_tipousuario == "1")
            {
                txtrazon.Focus();                
                cmdmodific.Enabled = false;
                cmdnuevo.Enabled = false;
                cmdgrabar.Enabled = true;
                cmdeliminar.Enabled = false;
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
                funcion.guardar_seguimiento("Intenta modificar registro de Proveedor", recibir_usuario);
            }
            else
            {
                MessageBox.Show("Usuario actual no tiene permisos para actualizar registro de proveedores");
            }
        }

        private void Frmproveedores_Load(object sender, EventArgs e)
        {
            funcion.guardar_seguimiento("Entra a formulario Proveedores", recibir_usuario);
        }        
    }
}
