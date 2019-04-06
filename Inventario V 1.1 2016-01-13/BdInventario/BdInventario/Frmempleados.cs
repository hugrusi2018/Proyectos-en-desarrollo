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
    public partial class Frmempleados : Plantiterceros
    {
        funciones funcion = new funciones();
        public Frmempleados()
        {
            InitializeComponent();
            cmdgrabar.Enabled = false;
            txtcodigo.ReadOnly = true;
            txtnombre1.ReadOnly = true;
            txtnombre2.ReadOnly = true;
            txtapellido1.ReadOnly = true;
            txtapellido2.ReadOnly = true;
            txtdireccion.ReadOnly = true;
            msktelefono.ReadOnly = true;
            mskcelular.ReadOnly = true;         
            txtobservaciones.ReadOnly = true;
            txtcontacto1.ReadOnly = true;
            txtelefono2.ReadOnly = true;
            dtpnacimiento.Enabled = false;
            dtpingreso.Enabled = false;
            dtpretiro.Enabled = false;

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


        int idcargo;
        int idcontrato;
        int idproveedor;
        int ideps;
        int idarp;
        int idafp;
        int idgrupo;
        int idciudad;
        int idsangre;
        public string recibir_tipousuario = "";
        public string recibir_usuario = "";
       
        private void cmdcerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            funcion.guardar_seguimiento("Sale de formulario Empleados", recibir_usuario);
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
                cmbempleados.Enabled = false;
                cmdnuevo.Enabled = false;
                cmdeliminar.Enabled = false;
                cmdmodific.Enabled = false;
                cmdgrabar.Enabled = true;
                txtcodigo.ReadOnly = false;
                txtnombre1.ReadOnly = false;
                txtnombre2.ReadOnly = false;
                txtapellido1.ReadOnly = false;
                txtapellido2.ReadOnly = false;
                txtdireccion.ReadOnly = false;
                msktelefono.ReadOnly = false;
                mskcelular.ReadOnly = false;
                txtobservaciones.ReadOnly = false;
                txtcontacto1.ReadOnly = false;
                txtelefono2.ReadOnly = false;

                txtcodigo.Text = "";
                txtnombre1.Text = "";
                txtnombre2.Text = "";
                txtapellido1.Text = "";
                txtapellido2.Text = "";
                txtdireccion.Text = "";
                msktelefono.Text = "";
                mskcelular.Text = "";
                txtobservaciones.Text = "";
                txtcontacto1.Text = "";
                txtelefono2.Text = "";
                dtpnacimiento.Enabled = true;
                dtpingreso.Enabled = true;
                dtpretiro.Enabled = true;
                cmbcargo.Text = "";
                cmbcontrato.Text = "";
                cmbciudad.Text = "";
                cmbproveedor.Text = "";
                cmbgrupo.Text = "";
                cmbsangre.Text = "";
                cmbeps.Text = "";
                cmbarp.Text = "";
                cmbafp.Text = "";
                funcion.guardar_seguimiento("Intenta registrar Empleado", recibir_usuario);
            }            
        }

        private void cmdactualizar_Click(object sender, EventArgs e)
        {
            if (recibir_tipousuario == "1")
            {
                cmbempleados.Enabled = false;
                cmdmodific.Enabled = false;
                cmdnuevo.Enabled = false;
                cmdeliminar.Enabled = false;
                cmdgrabar.Enabled = true;
                txtnombre1.Focus();
                txtcodigo.ReadOnly = false;
                txtnombre1.ReadOnly = false;
                txtnombre2.ReadOnly = false;
                txtapellido1.ReadOnly = false;
                txtapellido2.ReadOnly = false;
                txtdireccion.ReadOnly = false;
                msktelefono.ReadOnly = false;
                mskcelular.ReadOnly = false;
                txtobservaciones.ReadOnly = false;
                txtcontacto1.ReadOnly = false;
                txtelefono2.ReadOnly = false;
                funcion.guardar_seguimiento("Intenta modificar registro de Empleado", recibir_usuario);
            }
            else
            {
                MessageBox.Show("Usuario actual no tiene permisos para actualizar registro de empleados");
            }
        }

        void nombrempleado()
        {
            MySqlCommand comando = new MySqlCommand("select primer_nombre from empleados", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cmbempleados.Items.Add(leer.GetString(0));
            }
            miconexion.Close();
            
        }

        void nombrecargo()
        {
            MySqlCommand comando = new MySqlCommand("select nombre_cargo from cargos",miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cmbcargo.Items.Add(leer.GetString(0));
            }
            miconexion.Close();
        }

        void traeridcargo()
        {
            if (cmbcargo.Text != "")
            {
                MySqlCommand comando = new MySqlCommand("select idcargo from cargos where nombre_cargo='" + cmbcargo.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    idcargo = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        void tipocontrato()
        {
            MySqlCommand comando = new MySqlCommand("select nombre_contrato from contratos", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cmbcontrato.Items.Add(leer.GetString(0));
            }
            miconexion.Close();
        }

        void traeridcontrato()
        {
            if (cmbcontrato.Text != "")
            {
                MySqlCommand comando = new MySqlCommand("select idcontrato from contratos where nombre_contrato='" + cmbcontrato.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    idcontrato = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        void nombreproveedor()
        {
            MySqlCommand comando = new MySqlCommand("select nombre_proveedor from proveedores", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cmbproveedor.Items.Add(leer.GetString(0));
            }
            miconexion.Close();
        }

        void traeridproveedor()
        {
            if (cmbproveedor.Text != "")
            {
                MySqlCommand comando = new MySqlCommand("select idproveedor from proveedores where nombre_proveedor='" + cmbproveedor.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    idproveedor = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        void nombreps()
        {
            MySqlCommand comando = new MySqlCommand("select nombre_eps from eps", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cmbeps.Items.Add(leer.GetString(0));
            }
            miconexion.Close();
        }

        void traerideps()
        {
            if (cmbeps.Text != "")
            {
                MySqlCommand comando = new MySqlCommand("select ideps from eps where nombre_eps='" + cmbeps.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    ideps = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        void nombrearp()
        {
            MySqlCommand comando = new MySqlCommand("select nombre_arp from arp", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cmbarp.Items.Add(leer.GetString(0));
            }
            miconexion.Close();
        }

        void traeridarp()
        {
            if (cmbarp.Text != "")
            {
                MySqlCommand comando = new MySqlCommand("select idarp from arp where nombre_arp='" + cmbarp.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    idarp = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        void nombreafp()
        {
            MySqlCommand comando = new MySqlCommand("select nombre_afp from afp", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cmbafp.Items.Add(leer.GetString(0));
            }
            miconexion.Close();
        }

        void traeridafp()
        {
            if (cmbafp.Text != "")
            {
                MySqlCommand comando = new MySqlCommand("select idafp from afp where nombre_afp='" + cmbafp.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    idafp = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        void nombregrupoempleados()
        {
            MySqlCommand comando = new MySqlCommand("select nombre_grupo from grupo_empleados", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cmbgrupo.Items.Add(leer.GetString(0));
            }
            miconexion.Close();
        }

        void traeridgrupoempleados()
        {
            if (cmbgrupo.Text != "")
            {
                MySqlCommand comando = new MySqlCommand("select idgrupo from grupo_empleados where nombre_grupo='" + cmbgrupo.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    idgrupo = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        void nombreciudad()
        {
            MySqlCommand comando = new MySqlCommand("select nombre_ciudad from ciudades", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cmbciudad.Items.Add(leer.GetString(0));
            }
            miconexion.Close();
        }

        void traeridciudad()
        {
            if (cmbciudad.Text != "")
            {
                MySqlCommand comando = new MySqlCommand("select idciudad from ciudades where nombre_ciudad='" + cmbciudad.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    idciudad = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        void nombresangre()
        {
            MySqlCommand comando = new MySqlCommand("select nombre_grupo_sanguineo from grupo_sanguineo", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cmbsangre.Items.Add(leer.GetString(0));
            }
            miconexion.Close();
        }

        void traeridsangre()
        {
            if (cmbsangre.Text != "")
            {
                MySqlCommand comando = new MySqlCommand("select idsangre from grupo_sanguineo where nombre_grupo_sanguineo='" + cmbsangre.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    idsangre = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        private void cmbcargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridcargo();
        }

        private void cmbciudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridciudad();
        }

        private void cmbcontrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridcontrato();
        }

        private void cmbempresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridproveedor();
        }

        private void cmbgrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridgrupoempleados();
        }

        private void cmbsangre_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridsangre();
        }

        private void cmbeps_SelectedIndexChanged(object sender, EventArgs e)
        {
            traerideps();
        }

        private void cmbarp_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridarp();
        }

        private void cmbafp_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridafp();
        }

        void cargardatoinicial()
        {
            try
            {                
                MySqlCommand comando = new MySqlCommand("Select cli.idempleado, cli.primer_nombre, cli.segundo_nombre, cli.primer_apellido, cli.segundo_apellido, cli.direccion, cli.telefono, cli.celular, cli.fecha_nacimiento, cli.observaciones, cli.fecha_ingreso, cli.fecha_retiro, cli.contacto_familiar, car.nombre_cargo, cont.nombre_contrato, prov.nombre_proveedor, eps.nombre_eps, arp.nombre_arp, afp.nombre_afp, grp.nombre_grupo, ciu.nombre_ciudad, gs.nombre_grupo_sanguineo from empleados cli, cargos car, contratos cont, proveedores prov, eps eps, arp arp, afp afp, grupo_empleados grp, ciudades ciu, grupo_sanguineo gs where 1 and cli.idcargo=car.idcargo and cli.idtipocontr=cont.idcontrato and cli.idproveedor=prov.idproveedor and cli.ideps=eps.ideps and cli.idarp=arp.idarp and cli.idafp=afp.idafp and cli.idgrupo=grp.idgrupo and cli.idciudad=ciu.idciudad and cli.idgrupo_sanguineo=gs.idsangre", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    txtcodigo.Text = leer.GetString(0);
                    txtnombre1.Text = leer.GetString(1);
                    txtnombre2.Text = leer.GetString(2);
                    txtapellido1.Text = leer.GetString(3);
                    txtapellido2.Text = leer.GetString(4);
                    txtdireccion.Text = leer.GetString(5);
                    msktelefono.Text = leer.GetString(6);
                    mskcelular.Text = leer.GetString(7);
                    dtpnacimiento.Text = leer.GetString(8);
                    txtobservaciones.Text = leer.GetString(9);
                    dtpingreso.Text = leer.GetString(10);
                    try
                    {
                        dtpretiro.Text = leer.GetString(11);
                    }
                    catch { }
                    txtcontacto1.Text = leer.GetString(12);
                    txtelefono2.Text = leer.GetString(13);
                    try
                    {
                        cmbcargo.Text = leer.GetString(14);
                    }
                    catch { }
                    try
                    {
                        cmbcontrato.Text = leer.GetString(15);
                    }
                    catch { }
                    try
                    {
                        cmbproveedor.Text = leer.GetString(16);
                    }
                    catch { }
                    try
                    {
                        cmbeps.Text = leer.GetString(17);
                    }
                    catch { }
                    try
                    {
                        cmbarp.Text = leer.GetString(18);
                    }
                    catch { }
                    try
                    {
                        cmbafp.Text = leer.GetString(19);
                    }
                    catch { }
                    try
                    {
                        cmbgrupo.Text = leer.GetString(20);
                    }
                    catch { }
                    try
                    {
                        cmbciudad.Text = leer.GetString(21);
                    }
                    catch { }
                    try
                    {
                        cmbsangre.Text = leer.GetString(22);
                    }
                    catch { }
                }
                miconexion.Close();                
            }
            catch (Exception exec)
            {
                MessageBox.Show("Error en carga inicial: " + exec.Message);
            }
        }

        void cargardatos()
        {
            try
            {
                if (cmbempleados.Text != "")
                {
                    MySqlCommand comando = new MySqlCommand("Select cli.idempleado, cli.primer_nombre, cli.segundo_nombre, cli.primer_apellido, cli.segundo_apellido, cli.direccion, cli.telefono, cli.celular, cli.fecha_nacimiento, cli.observaciones, cli.fecha_ingreso, cli.fecha_retiro, cli.contacto_familiar, car.nombre_cargo, cont.nombre_contrato, prov.nombre_proveedor, eps.nombre_eps, arp.nombre_arp, afp.nombre_afp, grp.nombre_grupo, ciu.nombre_ciudad, gs.nombre_grupo_sanguineo from empleados cli, cargos car, contratos cont, proveedores prov, eps eps, arp arp, afp afp, grupo_empleados grp, ciudades ciu, grupo_sanguineo gs where cli.primer_nombre='" + cmbempleados.Text + "' and cli.idcargo=car.idcargo and cli.idtipocontr=cont.idcontrato and cli.idproveedor=prov.idproveedor and cli.ideps=eps.ideps and cli.idarp=arp.idarp and cli.idafp=afp.idafp and cli.idgrupo=grp.idgrupo and cli.idciudad=ciu.idciudad and cli.idgrupo_sanguineo=gs.idsangre", miconexion);
                    miconexion.Open();
                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        txtcodigo.Text = leer.GetString(0);
                        txtnombre1.Text = leer.GetString(1);
                        txtnombre2.Text = leer.GetString(2);
                        txtapellido1.Text = leer.GetString(3);
                        txtapellido2.Text = leer.GetString(4);
                        txtdireccion.Text = leer.GetString(5);
                        msktelefono.Text = leer.GetString(6);
                        mskcelular.Text = leer.GetString(7);
                        dtpnacimiento.Text = leer.GetString(8);
                        txtobservaciones.Text = leer.GetString(9);
                        dtpingreso.Text = leer.GetString(10);
                        try
                        {
                            dtpretiro.Text = leer.GetString(11);
                        }
                        catch { }
                        txtcontacto1.Text = leer.GetString(12);
                        txtelefono2.Text = leer.GetString(13);
                        try
                        {
                            cmbcargo.Text = leer.GetString(14);
                        }
                        catch { }
                        try
                        {
                            cmbcontrato.Text = leer.GetString(15);
                        }
                        catch { }
                        try
                        {
                            cmbproveedor.Text = leer.GetString(16);
                        }
                        catch { }
                        try
                        {
                            cmbeps.Text = leer.GetString(17);
                        }
                        catch { }
                        try
                        {
                            cmbarp.Text = leer.GetString(18);
                        }
                        catch { }
                        try
                        {
                            cmbafp.Text = leer.GetString(19);
                        }
                        catch { }
                        try
                        {
                            cmbgrupo.Text = leer.GetString(20);
                        }
                        catch { }
                        try
                        {
                            cmbciudad.Text = leer.GetString(21);
                        }
                        catch { }
                        try
                        {
                            cmbsangre.Text = leer.GetString(22);
                        }
                        catch { }
                    }
                    miconexion.Close();
                }
            }
            catch (Exception exec)
            {
                MessageBox.Show("Error al cargar datos: " + exec.Message);
            }
        }
        void actualizar()
        {
            MySqlCommand comando = new MySqlCommand("update empleados set primer_nombre=@primer_nombre, segundo_nombre=@segundo_nombre, primer_apellido=@primer_apellido, segundo_apellido=@segundo_apellido, direccion=@direccion, telefono=@telefono, celular=@celular, idcargo=@idcargo, fecha_nacimiento=@fecha_nacimiento, observaciones=@observaciones, idtipocontr=@idtipocontr, idproveedor=@idproveedor, ideps=@ideps, idarp=@idarp, idafp=@idafp, fecha_ingreso=@fecha_ingreso, fecha_retiro=@fecha_retiro, idgrupo=@idgrupo, idciudad=@idciudad, idgrupo_sanguineo=@idgrupo_sanguineo, contacto_familiar=@contacto_familiar where idempleado=@idempleado", miconexion);
            comando.Parameters.AddWithValue("idempleado", txtcodigo.Text);
            comando.Parameters.AddWithValue("primer_nombre", txtnombre1.Text);
            comando.Parameters.AddWithValue("segundo_nombre", txtnombre2.Text);
            comando.Parameters.AddWithValue("primer_apellido", txtapellido1.Text);
            comando.Parameters.AddWithValue("segundo_apellido", txtapellido2.Text);
            comando.Parameters.AddWithValue("direccion", txtdireccion.Text);
            comando.Parameters.AddWithValue("telefono", msktelefono.Text);
            comando.Parameters.AddWithValue("celular", mskcelular.Text);
            comando.Parameters.AddWithValue("idcargo", idcargo);
            comando.Parameters.AddWithValue("fecha_nacimiento", dtpnacimiento.Text);
            comando.Parameters.AddWithValue("observaciones", txtobservaciones.Text);
            comando.Parameters.AddWithValue("idtipocontr", idcontrato);
            comando.Parameters.AddWithValue("idproveedor", idproveedor);
            comando.Parameters.AddWithValue("ideps", ideps);
            comando.Parameters.AddWithValue("idarp", idarp);
            comando.Parameters.AddWithValue("idafp", idafp);
            comando.Parameters.AddWithValue("fecha_ingreso", dtpingreso.Text);
            comando.Parameters.AddWithValue("fecha_retiro", dtpretiro.Text);
            comando.Parameters.AddWithValue("idgrupo", idgrupo);
            comando.Parameters.AddWithValue("idciudad", idciudad);
            comando.Parameters.AddWithValue("idgrupo_sanguineo", idsangre);
            comando.Parameters.AddWithValue("contacto_familiar", txtcontacto1.Text);
            miconexion.Open();
            comando.ExecuteNonQuery();            
            miconexion.Close();
            MessageBox.Show("Registro Exitoso!");
            cmdgrabar.Enabled = false;
            cmdnuevo.Enabled = true;
            cmdmodific.Enabled = true;
            cmdeliminar.Enabled = true;
            txtcodigo.ReadOnly = true;
            txtnombre1.ReadOnly = true;
            txtnombre2.ReadOnly = true;
            txtapellido1.ReadOnly = true;
            txtapellido2.ReadOnly = true;
            txtdireccion.ReadOnly = true;
            msktelefono.ReadOnly = true;
            mskcelular.ReadOnly = true;
            txtobservaciones.ReadOnly = true;
            txtcontacto1.ReadOnly = true;
            txtelefono2.ReadOnly = true;
            dtpingreso.Enabled = false;
            dtpnacimiento.Enabled = false;
            dtpretiro.Enabled = false;
        }

        void guardar()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand("insert into empleados(idempleado, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, direccion, telefono, celular, idcargo, fecha_nacimiento, observaciones, idtipocontr, idproveedor, ideps, idarp, idafp, fecha_ingreso, fecha_retiro, idgrupo, idciudad, idgrupo_sanguineo, contacto_familiar)values(@idempleado, @primer_nombre, @segundo_nombre, @primer_apellido, @segundo_apellido, @direccion, @telefono, @celular, @idcargo, @fecha_nacimiento, @observaciones, @idtipocontr, @idproveedor, @ideps, @idarp, @idafp, @fecha_ingreso, @fecha_retiro, @idgrupo, @idciudad, @idgrupo_sanguineo, @contacto_familiar)", miconexion);
                comando.Parameters.AddWithValue("idempleado", txtcodigo.Text);
                comando.Parameters.AddWithValue("primer_nombre", txtnombre1.Text);
                comando.Parameters.AddWithValue("segundo_nombre", txtnombre2.Text);
                comando.Parameters.AddWithValue("primer_apellido", txtapellido1.Text);
                comando.Parameters.AddWithValue("segundo_apellido", txtapellido2.Text);
                comando.Parameters.AddWithValue("direccion", txtdireccion.Text);
                comando.Parameters.AddWithValue("telefono", msktelefono.Text);
                comando.Parameters.AddWithValue("celular", mskcelular.Text);
                comando.Parameters.AddWithValue("idcargo", idcargo);
                comando.Parameters.AddWithValue("fecha_nacimiento", dtpnacimiento.Text);
                comando.Parameters.AddWithValue("observaciones", txtobservaciones.Text);
                comando.Parameters.AddWithValue("idtipocontr", idcontrato);
                comando.Parameters.AddWithValue("idproveedor", idproveedor);
                comando.Parameters.AddWithValue("ideps", ideps);
                comando.Parameters.AddWithValue("idarp", idarp);
                comando.Parameters.AddWithValue("idafp", idafp);
                comando.Parameters.AddWithValue("fecha_ingreso", dtpingreso.Text);
                comando.Parameters.AddWithValue("fecha_retiro", dtpretiro.Text);
                comando.Parameters.AddWithValue("idgrupo", idgrupo);
                comando.Parameters.AddWithValue("idciudad", idciudad);
                comando.Parameters.AddWithValue("idgrupo_sanguineo", idsangre);
                comando.Parameters.AddWithValue("contacto_familiar", txtcontacto1.Text);
                miconexion.Open();
                comando.ExecuteNonQuery();                
                miconexion.Close();
                MessageBox.Show("Registro Exitoso!");
                cmdgrabar.Enabled = false;
                cmdnuevo.Enabled = true;
                cmdmodific.Enabled = true;
                cmdeliminar.Enabled = true;
                txtcodigo.ReadOnly = true;
                txtnombre1.ReadOnly = true;
                txtnombre2.ReadOnly = true;
                txtapellido1.ReadOnly = true;
                txtapellido2.ReadOnly = true;
                txtdireccion.ReadOnly = true;
                msktelefono.ReadOnly = true;
                mskcelular.ReadOnly = true;
                txtobservaciones.ReadOnly = true;
                txtcontacto1.ReadOnly = true;
                txtelefono2.ReadOnly = true;
                dtpingreso.Enabled = false;
                dtpnacimiento.Enabled = false;
                dtpretiro.Enabled = false;
            }
            catch (SystemException exec)
            {
                MessageBox.Show("Error en procedimiento insert: " + exec.Message);
            }
        }

        private void cmdgrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (recibir_tipousuario == "1" || recibir_tipousuario == "2")
                {
                    if (txtcodigo.Text != "")
                    {
                        MessageBox.Show("Digite codigo para Empleado");
                        txtcodigo.Focus();
                        return;
                    }
                    if (txtnombre1.Text != "")
                    {
                        MessageBox.Show("Digite primer nombre");
                        txtnombre1.Focus();
                        return;
                    }
                    if (txtdireccion.Text != "")
                    {
                        MessageBox.Show("La dirección es importante, digitela!");
                        txtdireccion.Focus();
                        return;
                    }
                    if (msktelefono.Text != "")
                    {
                        MessageBox.Show("Ingrese el numero de telefono");
                        msktelefono.Focus();
                        return;
                    }
                    if (cmbciudad.Text != "")
                    {
                        MessageBox.Show("Seleccione la ciudad");
                        cmbciudad.Focus();
                        return;
                    }
                    if (cmbcontrato.Text != "")
                    {
                        MessageBox.Show("Asigne un tipo de contrato");
                        cmbcontrato.Focus();
                        return;
                    }
                    if (cmbproveedor.Text != "")
                    {
                        MessageBox.Show("Elija la empresa");
                        cmbproveedor.Focus();
                        return;
                    }
                    if (cmbgrupo.Text != "")
                    {
                        MessageBox.Show("Asigne un grupo");
                        cmbgrupo.Focus();
                        return;
                    }
                    if (cmbsangre.Text != "")
                    {
                        MessageBox.Show("Seleccione el tipo de sangre");
                        cmbsangre.Focus();
                        return;
                    }
                    if (dtpingreso.Text != "")
                    {
                        MessageBox.Show("Seleccione la fecha de ingreso");
                        dtpingreso.Focus();
                        return;
                    }
                    MySqlCommand comando = new MySqlCommand("select idempleado from empleados where idempleado='" + txtcodigo.Text + "'", miconexion);
                    miconexion.Open();
                    MySqlDataReader leer = comando.ExecuteReader();

                    if (leer.Read())
                    {
                        miconexion.Close();
                        actualizar();
                        funcion.guardar_seguimiento("Actualiza registro de Empleado", recibir_usuario);
                    }
                    else
                    {
                        miconexion.Close();
                        guardar();
                        funcion.guardar_seguimiento("Registra Empleado", recibir_usuario);
                    }
                    miconexion.Close();
                }
                else
                {
                    MessageBox.Show("Usuario no tiene permisos para registrar empleados");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en procedimiento grabar: "+ex.Message);
            }          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nombrempleado();
            nombrecargo();
            tipocontrato();
            nombreproveedor();
            nombreps();
            nombrearp();
            nombreafp();
            nombregrupoempleados();
            nombreciudad();
            nombresangre();
            cargardatoinicial();
            cargardatos();
            timer1.Enabled = false;
        }

        private void cmdempleado_Click(object sender, EventArgs e)
        {
            Frmconsultaempleados empleados = new Frmconsultaempleados();
            empleados.Show();
        }

        private void cmbempleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbempleados.Text != "")
            {
                cargardatos();
            }
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
                    MySqlCommand eliminar = new MySqlCommand("delete from empleados where idempleado=@id", miconexion);
                    eliminar.Parameters.AddWithValue("id", txtcodigo.Text);
                    miconexion.Open();
                    eliminar.ExecuteNonQuery();
                    miconexion.Close();
                    MessageBox.Show("Registro Eliminado!");
                    funcion.guardar_seguimiento("Elimina registro de Empleado", recibir_usuario);
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
            catch (Exception exec)
            {
                MessageBox.Show("Error en comando eliminar" + exec.Message);
            }
        }

        private void Frmempleados_Load(object sender, EventArgs e)
        {
            funcion.guardar_seguimiento("Entra a formulario Empleados", recibir_usuario);
        }       
    }
}
