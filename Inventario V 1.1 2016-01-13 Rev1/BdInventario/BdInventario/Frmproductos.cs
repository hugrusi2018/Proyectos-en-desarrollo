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
    public partial class Frmproductos : Plantiparam
    {
        funciones funcion = new funciones();
        public Frmproductos()
        {
            InitializeComponent();
            cmdgrabar.Enabled = false;
            txtidalmacen.Enabled = false;
            txtcodigo.ReadOnly = true;
            txtproducto.ReadOnly = true;
            txtminstock.ReadOnly = true;
            txtminstock.ReadOnly = true;
            txtcosto.ReadOnly = true;
            txtreferencia.ReadOnly = true;
            txtobservacion.ReadOnly = true;
            lblexistencia.Enabled = false;
            lbltotal.Enabled = false;

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

        int idproveedor;
        int idsubgrupo;
        int idgrupo;
        int idimpuesto;
        int idunidad;
        public string recibir_tipousuario = "";
        public string recibir_usuario = "";

        void cargadatoinicial()
        {

            MySqlCommand comando = new MySqlCommand("Select cli.IdProducto, cli.Nombre_Producto, cli.Valor_Unitario, cli.Existencia, cli.Referencia, cli.IdAlmacen, cli.PtoMinStock, cli.PtoMaxStock, cli.Observacion, prov.Nombre_Proveedor, sub.Nombre_Subgrupo, gru.Nombre_Grupo, uni.Sigla, por.Porcentaje from productos cli, proveedores prov, subgrupo_productos sub, grupo_producto gru, unidades uni, impuestos por where 1 and cli.IdProveedor=prov.IdProveedor and cli.IdSubgrupo=sub.IdSubgrupo and cli.IdGruprod=gru.IdGruprod and cli.IdUnidad=uni.IdUnidad and cli.IdImpuesto=por.IdImpuesto", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();

            if (leer.Read())
            {
                try
                {

                    txtcodigo.Text = leer.GetString(0);
                    txtproducto.Text = leer.GetString(1);
                    txtcosto.Text = leer.GetString(2);
                    lblexistencia.Text = leer.GetString(3);
                    txtreferencia.Text = leer.GetString(4);
                    txtidalmacen.Text = leer.GetString(5);
                    txtminstock.Text = leer.GetString(6);
                    txtmaxstock.Text = leer.GetString(7);
                    txtobservacion.Text = leer.GetString(8);
                    cmbunidad.Text = leer.GetString(12);
                    cmbproveedor.Text = leer.GetString(9);
                    cmbgrupo.Text = leer.GetString(11);
                    cmbimpuesto.Text = leer.GetString(13);

                }
                catch
                {
                    
                }
            }

            miconexion.Close();
            valorexistencia();
        }

        //Consulta para cargar id de almacen
        void cargaridalmacen()
        {
            MySqlCommand comando = new MySqlCommand("select * from almacenes", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                txtidalmacen.Text = leer.GetString(0);
            }
            miconexion.Close();
        }

        //Consulta para cargar nombre de almacen
        void cargarnombrealmacen()
        {
            MySqlCommand comando = new MySqlCommand("select * from almacenes", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(1);
                cmbalmacen.Items.Add(nombre);
            }
            miconexion.Close();
        }

        //Consulta para cargar nombre de producto
        void cargarnombreproducto()
        {
            MySqlCommand comando = new MySqlCommand("select * from productos", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(2);
                cmbproducto.Items.Add(nombre);
            }
            miconexion.Close();
        }

        //Consulta para cargar sigla de unidad
        void cargarsiglaunidad()
        {
            MySqlCommand comando = new MySqlCommand("select * from unidades", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string sigla = leer.GetString(1);
                cmbunidad.Items.Add(sigla);
            }
            miconexion.Close();
        }

        void traeridunidad()
        {
            if (cmbunidad.Text != "")
            {
                MySqlCommand comando = new MySqlCommand("select idunidad from unidades where sigla='" + cmbunidad.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    idunidad = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        //Consulta para cargar nombre grupo producto
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

        //Consulta para cargar nombre subgrupo producto
        void cargarnombresubgrupo()
        {
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

        void traeridsubgrupo()
        {
            if (cmbsubgrupo.Text != "")
            {
                MySqlCommand comando = new MySqlCommand("select idsubgrupo from subgrupo_productos where nombre_subgrupo='" + cmbsubgrupo.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    idsubgrupo = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        //Consulta para cargar nombre proveedor
        void cargarnombreproveedor()
        {
            MySqlCommand comando = new MySqlCommand("select * from proveedores", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(3);
                cmbproveedor.Items.Add(nombre);
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

        //Consulta para cargar porcentaje impuesto
        void cargarporcentajeimpuesto()
        {
            MySqlCommand comando = new MySqlCommand("select * from impuestos", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string porc = leer.GetString(2);
                cmbimpuesto.Items.Add(porc);
            }
            miconexion.Close();
        }

        void traeridimpuesto()
        {
            if (cmbimpuesto.Text != "")
            {
                MySqlCommand comando = new MySqlCommand("select idimpuesto from impuestos where porcentaje='" + cmbimpuesto.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    idimpuesto = leer.GetInt32(0);
                }
                miconexion.Close();
            }
        }

        //Consulta para carga los datos del producto en el formulario  
        void cargadatos()
        {
            try
            {
                if (cmbproducto.Text != "")
                {
                    MySqlCommand comando = new MySqlCommand("Select cli.IdProducto, cli.Nombre_Producto, cli.Valor_Unitario, cli.Existencia, cli.Referencia, cli.IdAlmacen, cli.PtoMinStock, cli.PtoMaxStock, cli.Observacion, prov.Nombre_Proveedor, sub.Nombre_Subgrupo, gru.Nombre_Grupo, uni.Sigla, por.Porcentaje from productos cli, proveedores prov, subgrupo_productos sub, grupo_producto gru, unidades uni, impuestos por where cli.Nombre_Producto='" + cmbproducto.Text + "' and cli.IdProveedor=prov.IdProveedor and cli.IdSubgrupo=sub.IdSubgrupo and cli.IdGruprod=gru.IdGruprod and cli.IdUnidad=uni.IdUnidad and cli.IdImpuesto=por.IdImpuesto", miconexion);
                    miconexion.Open();
                    MySqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        txtcodigo.Text = leer.GetString(0);
                        txtproducto.Text = leer.GetString(1);
                        txtcosto.Text = leer.GetString(2);
                        lblexistencia.Text = leer.GetString(3);
                        txtreferencia.Text = leer.GetString(4);
                        txtidalmacen.Text = leer.GetString(5);
                        txtminstock.Text = leer.GetString(6);
                        txtmaxstock.Text = leer.GetString(7);
                        txtobservacion.Text = leer.GetString(8);
                        try
                        {
                            cmbunidad.Text = leer.GetString(12);
                        }
                        catch { }
                        try
                        {
                            cmbproveedor.Text = leer.GetString(9);
                        }
                        catch
                        {
                            cmbproveedor.Text = cmbproveedor.Text;
                        }
                        try
                        {
                            cmbsubgrupo.Text = leer.GetString(10);
                        }
                        catch
                        {
                            cmbsubgrupo.Text = cmbsubgrupo.Text;
                        }
                        try
                        {
                            cmbgrupo.Text = leer.GetString(11);
                        }
                        catch
                        {
                            cmbgrupo.Text = cmbgrupo.Text;
                        }
                        try
                        {
                            cmbimpuesto.Text = leer.GetString(13);
                        }
                        catch
                        {
                            cmbimpuesto.Text = cmbimpuesto.Text;
                        }
                    }
                    miconexion.Close();
                }
            }
            catch (Exception exec)
            {
                MessageBox.Show("Error al cargar datos: " + exec.Message);

            }
        }

        private void cmbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbproducto.Text != "")
            {
                cargadatos();
                valorexistencia();
                stockmin_max();
                cmdkardex.Enabled = true;
            }

        }

        void actualizar()
        {
            try
            {
                MySqlCommand grabar = new MySqlCommand("update productos set idproveedor=@idproveedor, nombre_producto=@nombre_producto, valor_unitario=@valor_unitario, existencia=@existencia, referencia=@referencia, idalmacen=@idalmacen, idsubgrupo=@idsubgrupo, idgruprod=@idgruprod, ptominstock=@ptominstock, ptomaxstock=@ptomaxstock, idimpuesto=@idimpuesto, idunidad=@idunidad, observacion=@observacion where idproducto=@idproducto", miconexion);
                grabar.Parameters.AddWithValue("idproveedor", idproveedor);
                grabar.Parameters.AddWithValue("idalmacen", txtidalmacen.Text);
                grabar.Parameters.AddWithValue("idproducto", txtcodigo.Text);
                grabar.Parameters.AddWithValue("nombre_producto", txtproducto.Text);
                grabar.Parameters.AddWithValue("valor_unitario", txtcosto.Text);
                grabar.Parameters.AddWithValue("existencia", lblexistencia.Text);
                grabar.Parameters.AddWithValue("referencia", txtreferencia.Text);
                grabar.Parameters.AddWithValue("idsubgrupo", idsubgrupo);
                grabar.Parameters.AddWithValue("idgruprod", idgrupo);
                grabar.Parameters.AddWithValue("ptominstock", txtminstock.Text);
                grabar.Parameters.AddWithValue("ptomaxstock", txtmaxstock.Text);
                grabar.Parameters.AddWithValue("idimpuesto", idimpuesto);
                grabar.Parameters.AddWithValue("idunidad", idunidad);
                grabar.Parameters.AddWithValue("observacion", txtobservacion.Text);

                miconexion.Open();
                grabar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro Actualizado!");
                cmdnuevo.Enabled = true;
                cmdmodific.Enabled = true;
                cmdgrabar.Enabled = false;
                cmbproducto.Enabled = true;
                cmbalmacen.Enabled = true;
                cmbproducto.Focus();
            }
            catch (Exception exec)
            {
                MessageBox.Show("Error al actualizar producto: " + exec.Message);
            }
        }

        //Insertar el producto en la Base de datos
        void grabar()
        {
            try
            {
                MySqlCommand grabar = new MySqlCommand("insert into productos(idproveedor, idproducto, nombre_producto, valor_unitario, existencia, referencia, idalmacen, idsubgrupo, idgruprod, ptominstock, ptomaxstock, idimpuesto, idunidad, observacion)values(@idproveedor, @idproducto, @nombre_producto, @valor_unitario, @existencia, @referencia, @idalmacen, @idsubgrupo, @idgruprod, @ptominstock, @ptomaxstock, @idimpuesto, @idunidad, @observacion)", miconexion);
                grabar.Parameters.AddWithValue("idproveedor", idproveedor);
                grabar.Parameters.AddWithValue("idalmacen", txtidalmacen.Text);
                grabar.Parameters.AddWithValue("idproducto", txtcodigo.Text);
                grabar.Parameters.AddWithValue("nombre_producto", txtproducto.Text);
                grabar.Parameters.AddWithValue("valor_unitario", txtcosto.Text);
                grabar.Parameters.AddWithValue("existencia", lblexistencia.Text);
                grabar.Parameters.AddWithValue("referencia", txtreferencia.Text);
                grabar.Parameters.AddWithValue("idsubgrupo", idsubgrupo);
                grabar.Parameters.AddWithValue("idgruprod", idgrupo);
                grabar.Parameters.AddWithValue("ptominstock", txtminstock.Text);
                grabar.Parameters.AddWithValue("ptomaxstock", txtmaxstock.Text);
                grabar.Parameters.AddWithValue("idimpuesto", idimpuesto);
                grabar.Parameters.AddWithValue("idunidad", idunidad);
                grabar.Parameters.AddWithValue("observacion", txtobservacion.Text);
                miconexion.Open();
                grabar.ExecuteNonQuery();
                miconexion.Close();
                MessageBox.Show("Registro Exitoso!");
                cmdnuevo.Enabled = true;
                cmdmodific.Enabled = true;
                cmdgrabar.Enabled = false;
                cmbproducto.Enabled = true;
                cmbalmacen.Enabled = true;
                cmbproducto.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar producto: " + ex.Message);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            cargadatoinicial();
            cargadatos();
            cargarnombrealmacen();
            cargarnombreproducto();
            cargarsiglaunidad();
            cargarnombregrupo();
            cargarnombresubgrupo();
            cargarnombreproveedor();
            cargarporcentajeimpuesto();
            timer1.Enabled = false;
        }

        private void cmdcerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            funcion.guardar_seguimiento("Sale de formulario Productos - Kardex", recibir_usuario);
        }

        private void cmbalmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdnuevo.Enabled = true;
            cargaridalmacen();
        }

        private void cmdgrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (recibir_tipousuario == "1" || recibir_tipousuario == "2")
                {
                    if (txtcodigo.Text == "")
                    {
                        MessageBox.Show("Digite un codigo para 'Producto'");
                        txtcodigo.Focus();
                        return;
                    }
                    if (txtproducto.Text == "")
                    {
                        MessageBox.Show("Digite el nombre del producto");
                        txtproducto.Focus();
                        return;
                    }
                    if (cmbunidad.Text == "")
                    {
                        MessageBox.Show("Seleccione unidad de medida!");
                        cmbunidad.Focus();
                        return;
                    }
                    if (txtcosto.Text == "")
                    {
                        MessageBox.Show("Ingrese el costo!");
                        txtcosto.Focus();
                        return;
                    }
                    if (cmbgrupo.Text == "")
                    {
                        MessageBox.Show("Seleccione grupo!");
                        cmbgrupo.Focus();
                        return;
                    }
                    if (cmbsubgrupo.Text == "")
                    {
                        MessageBox.Show("Seleccione subgrupo!");
                        cmbsubgrupo.Focus();
                        return;
                    }
                    if (cmbproveedor.Text == "")
                    {
                        MessageBox.Show("Seleccione proveedor!");
                        cmbproveedor.Focus();
                        return;
                    }
                    if (cmbimpuesto.Text == "")
                    {
                        MessageBox.Show("Seleccione IVA!");
                        cmbimpuesto.Focus();
                        return;
                    }
                    else
                    {
                        MySqlCommand comando = new MySqlCommand("select idproducto from productos where idproducto=" + txtcodigo.Text, miconexion);
                        miconexion.Open();
                        MySqlDataReader leer = comando.ExecuteReader();

                        if (leer.Read())
                        {
                            miconexion.Close();
                            actualizar();
                            funcion.guardar_seguimiento("Actualiza registro de Producto", recibir_usuario);
                        }
                        else
                        {
                            miconexion.Close();
                            grabar();
                            funcion.guardar_seguimiento("Registra Producto", recibir_usuario);
                        }
                    }
                    miconexion.Close();
                }
                else
                {
                    MessageBox.Show("Usuario no tiene permisos para registrar productos");
                }
            }
            catch (Exception exec)
            {
                MessageBox.Show("Error en comando grabar: " + exec.Message);
            }
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
                cmdgrabar.Enabled = true;
                cmdmodific.Enabled = false;
                cmdnuevo.Enabled = false;
                cmbalmacen.Enabled = false;
                cmbproducto.Enabled = false;
                txtidalmacen.Enabled = false;
                txtcodigo.ReadOnly = false;
                txtproducto.ReadOnly = false;
                txtminstock.ReadOnly = false;
                txtminstock.ReadOnly = false;
                txtcosto.ReadOnly = false;
                txtreferencia.ReadOnly = false;
                txtobservacion.ReadOnly = false;
                txtcodigo.Text = "";
                txtproducto.Text = "";
                txtminstock.Text = "";
                txtmaxstock.Text = "";
                txtcosto.Text = "";
                txtreferencia.Text = "";
                txtobservacion.Text = "";
                lblexistencia.Text = "";
                cmbunidad.Text = "";
                cmbgrupo.Text = "";
                cmbsubgrupo.Text = "";
                cmbproveedor.Text = "";
                cmbimpuesto.Text = "";
                lblexistencia.Text = "0";
                txtcodigo.Focus();
                funcion.guardar_seguimiento("Intenta registrar Producto", recibir_usuario);
            }
        }

        private void cmbsubgrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridsubgrupo();
        }

        private void cmbunidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridunidad();
        }

        private void cmbgrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridgrupo();
        }

        private void cmbproveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridproveedor();
        }

        private void cmbimpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            traeridimpuesto();
        }

        private void cmdmodific_Click(object sender, EventArgs e)
        {
            if (recibir_tipousuario == "1")
            {
                cmdmodific.Enabled = false;
                cmdnuevo.Enabled = false;
                cmbalmacen.Enabled = false;
                cmbproducto.Enabled = false;
                cmdgrabar.Enabled = true;
                txtidalmacen.Enabled = false;
                txtproducto.ReadOnly = false;
                txtminstock.ReadOnly = false;
                txtminstock.ReadOnly = false;
                txtcosto.ReadOnly = false;
                txtreferencia.ReadOnly = false;
                txtobservacion.ReadOnly = false;
                txtproducto.Focus();
                funcion.guardar_seguimiento("Intenta modificar registro de Producto", recibir_usuario);
            }
            else
            {
                MessageBox.Show("Usuario no tiene permisos para actualizar registro de productos");
            }
        }

        private void cmdlistado_Click(object sender, EventArgs e)
        {
            Frmconsultaproductos productos = new Frmconsultaproductos();
            productos.Show();
        }

        void cargadatagrid()
        {
            try
            {
                if (txtcodigo.Text != "")
                {
                    MySqlCommand comando = new MySqlCommand("select * from detalle_movimiento_product where idproducto='" + txtcodigo.Text + "'", miconexion);
                    miconexion.Open();
                    MySqlDataReader leer = comando.ExecuteReader();
                    int renglon = 0;
                    while (leer.Read())
                    {
                        renglon = dataGridView1.Rows.Add();
                        dataGridView1.Rows[renglon].Cells["ID"].Value = leer.GetString(0);
                        dataGridView1.Rows[renglon].Cells["Documento"].Value = leer.GetString(1);
                        dataGridView1.Rows[renglon].Cells["Nro_Documento"].Value = leer.GetString(2);
                        dataGridView1.Rows[renglon].Cells["Transaccion"].Value = leer.GetString(3);
                        dataGridView1.Rows[renglon].Cells["Nombre_Producto"].Value = leer.GetString(5);
                        dataGridView1.Rows[renglon].Cells["Unidad"].Value = leer.GetString(6);
                        dataGridView1.Rows[renglon].Cells["Cantidad"].Value = leer.GetString(7);
                        dataGridView1.Rows[renglon].Cells["Valor_Unitario"].Value = leer.GetString(8);
                        dataGridView1.Rows[renglon].Cells["Valor_Total"].Value = leer.GetString(9);
                        dataGridView1.Rows[renglon].Cells["Fecha"].Value = leer.GetString(12);
                    }
                    miconexion.Close();
                }
            }
            catch (Exception exec)
            {
                MessageBox.Show("Error al cargar datagrid: " + exec.Message);
            }
        }

        private void cmdkardex_Click(object sender, EventArgs e)
        {
            cargadatagrid();
            cmdkardex.Enabled = false;
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        void valorexistencia()
        {
            double costo, exist, total = 0;
            costo = Convert.ToInt32(txtcosto.Text);
            exist = Convert.ToInt32(lblexistencia.Text);
            total = exist * costo;
            lbltotal.Text = Convert.ToString(total);
        }

        //Muestra el contenido de la variable en la parte superior derecha del formulario.
        private void Frmproductos_Load(object sender, EventArgs e)
        {
            funcion.guardar_seguimiento("Entra a formulario Productos - Kardex", recibir_usuario);
        }
        public void stockmin_max()
        {
            try
            {
                if (Convert.ToInt32(lblexistencia.Text) > Convert.ToInt32(txtmaxstock.Text))
                {
                    MessageBox.Show("El producto ha superado el punto maximo de stock", "ALERTA");
                    cmbproducto.Focus();
                    return;
                }
                if (Convert.ToInt32(lblexistencia.Text) < Convert.ToInt32(txtminstock.Text))
                {
                    MessageBox.Show("El producto esta por debajo del punto minimo", "ALERTA");
                    cmbproducto.Focus();
                    return;
                }
                else
                {
                    return;
                }
            }
            catch (Exception exec)
            {
                MessageBox.Show("Error en control punto min y max: " + exec.Message);
            }
        }

        private void cmdconsolidado_Click(object sender, EventArgs e)
        {
            Frmconsultastock puntoreorden = new Frmconsultastock();
            puntoreorden.Show();
        }
    }
}


