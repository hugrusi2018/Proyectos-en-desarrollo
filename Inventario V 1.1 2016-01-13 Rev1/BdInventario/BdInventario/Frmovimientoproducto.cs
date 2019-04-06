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
    public partial class Frmovimientoproducto : Plantiparam
    {
        funciones funcion = new funciones();
        public Frmovimientoproducto()
        {
            InitializeComponent();
            cmbdocumento.Enabled = false;
            cmbalmacen.Enabled = false;
            cmbproveedor.Enabled = false;
            cmbproducto.Enabled = false;
            cmdgrabar.Enabled = false;
            cmdmodific.Visible = false;
            txtidmvto.Enabled = false;
            txtidproveedor.ReadOnly = true;
            txtidalmacen.ReadOnly = true;
            txtdoc.ReadOnly = true;
            txtidocumento.ReadOnly = true;
            txtfecha.ReadOnly = true;
            txtpedido.ReadOnly = true;
            txtransac.ReadOnly = true;
            txtobservacion.ReadOnly = true;
            txtotal.ReadOnly = true;
            txtfactura.ReadOnly = true;

            lblseleccione.Visible = false;
            cmbdocum.Visible = false;

            lbltotal.Visible = false;
            txtotal.Visible = false;

            lblcliente.Visible = false;
            cmbcliente.Visible = false;

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

        public string comando;
        int a = 0;
        int celda = 0;
        public string recibir_tipousuario = "";
        public string recibir_usuario = "";
        public string recibir_existencia = "";

        void traerexistencia()
        {
            MySqlCommand comando = new MySqlCommand("select existencia from productos where idproducto='" + Dtmvtoproducto.Rows[a].Cells["Codigo"].Value + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                recibir_existencia = leer.GetString(0);
            }
            miconexion.Close();
        }

        //consulta para cargar id movimiento de la tabla movimiento_productos
        void cargaridmovimiento()
        {
            MySqlCommand comando = new MySqlCommand("SELECT Nro_Documento FROM detalle_movimiento_product", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cmbdocum.Items.Add(leer.GetString(0));
            }
            miconexion.Close();
        }

        /// <summary>
        /// Devuelve la informacion correpondiente alNumero de Documento
        /// </summary>
        void cargardocumento()
        {
            string CabeceraMensaje = "", DetalleMensaje = "";
            int total = 0;
            MySqlCommand comando = new MySqlCommand("SELECT * FROM detalle_movimiento_product det, movimiento_productos move where det.Nro_Documento='" + cmbdocum.Text + "' and  move.idMvto=det.idMvto", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                CabeceraMensaje = leer.GetString(12) + "\n\n------Información Proveedor------\n\nCodigo Proveedor:   " + leer.GetString(13) + " Docuemento Proveedor:   " + leer.GetString(14) + "\n\n------Información Pedido------\n\nCodigo Pedido: " + leer.GetString(18) + " Codigo de Almacen: " + leer.GetString(19) + "\n";

            }

            while (leer.Read())
            {
                DetalleMensaje += "\n| Codigo: " + leer.GetString(0) + " | Tipo Documento: " + leer.GetString(1) + " | Numero Documento: " + leer.GetString(2) + " | Transaccion: " + leer.GetString(3) + " | Codigo Producto: " + leer.GetString(4) + " | Nombre Producto: " + leer.GetString(5) + " | Unidad: " + leer.GetString(6) + " | Cantidad: " + leer.GetString(7) + " | Valor Unitario: " + leer.GetString(8) + " | Valor Total: " + leer.GetString(9) + " |\n";

                total += leer.GetInt32(9);
            }

            MostrarMovimientos mostrar = new MostrarMovimientos();
            mostrar.lb_mostrar.Text = CabeceraMensaje + "\n" + DetalleMensaje + "\n\n Total Documento: " + total.ToString();
            mostrar.Show();

            miconexion.Close();
        }

        /// <summary>
        /// Consulta para cargar id de documento de la tabla tipo_documentos
        /// </summary>
        void cargaridocumento()
        {
            MySqlCommand comando = new MySqlCommand("select iddoc from tipo_documentos where nombre_documento='" + cmbdocumento.Text + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtidocumento.Text = Convert.ToString(leer.GetString(0));
            }
            miconexion.Close();
        }

        /// <summary>
        /// Consulta para cargar nombre del documento de la tabla tipo_documentos
        /// </summary>
        void cargarnombredocumento()
        {
            MySqlCommand comando = new MySqlCommand("select * from tipo_documentos", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(1);
                cmbdocumento.Items.Add(nombre);
            }
            miconexion.Close();
        }

        //Consulta para cargar la transaccion de la tabla tipo_documentos
        void cargardescripcionmovimiento()
        {
            MySqlCommand comando = new MySqlCommand("select Transaccion from tipo_documentos where IdDoc='" + txtidocumento.Text + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtransac.Text = leer.GetString(0);
            }
            miconexion.Close();
        }

        //Consulta para cargar id de la tabla almacenes
        public void cargarnombrealmacen()
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

        //Consulta para cargar el nombre del almacen segun el IdAlmacen seleccionado
        void cargaridalmacen()
        {
            MySqlCommand comando = new MySqlCommand("select idalmacen from almacenes where nombre_almacen='" + cmbalmacen.Text + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtidalmacen.Text = Convert.ToString(leer.GetString(0));
            }
            miconexion.Close();
        }

        //Consulta para cargar el id de proveedor de la tabla proveedores
        void cargaridproveedor()
        {
            MySqlCommand comando = new MySqlCommand("select idproveedor from proveedores where nombre_proveedor='" + cmbproveedor.Text + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtidproveedor.Text = Convert.ToString(leer.GetString(0));
            }
            miconexion.Close();
        }

        //Consulta para cargar el nombre de proveedor de la tabla proveedores
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

        //Consulta para cargar id de cliente de la tabla cliente
        void cargaridcliente()
        {
            MySqlCommand comando = new MySqlCommand("select idcliente from cliente where nombre_cliente='" + cmbcliente.Text + "'", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                txtidcliente.Text = Convert.ToString(leer.GetString(0));
            }
            miconexion.Close();
        }

        //Consulta para cargar el nombre de proveedor de la tabla proveedores
        void cargarnombrecliente()
        {
            MySqlCommand comando = new MySqlCommand("select * from cliente", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nombre = leer.GetString(3);
                cmbcliente.Items.Add(nombre);
            }
            miconexion.Close();
        }

        //Consulta para cargar id de la tabla productos
        void cargarnombreproducto()
        {
            MySqlCommand comando = new MySqlCommand("select * from productos", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                string nomb = Convert.ToString(leer.GetValue(2));
                cmbproducto.Items.Add(nomb);

            }
            miconexion.Close();
        }

        private void cmdcerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            funcion.guardar_seguimiento("Sale de formulario Movimiento de Productos", recibir_usuario);
        }

        private void cmbalmac_TextChanged(object sender, EventArgs e)
        {
            if (cmbalmacen.Text != "")
            {
                cargarnombrealmacen();
            }
        }

        //La informacion que carga el formulario al iniciar
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtfecha.Text = DateTime.Now.ToString("MMM-dd/yy");
            cargaridmovimiento();
            cargarnombredocumento();
            cargarnombreproducto();
            cargarnombreproveedor();
            cargarnombrecliente();
            autonumericoidmvto();
            txtdoc.Focus();
            timer1.Enabled = false;
        }

        private void cmdgrabar_Click(object sender, EventArgs e)
        {
            if (recibir_tipousuario == "1" || recibir_tipousuario == "2")
            {
                if (cmbdocumento.Text == "")
                {
                    MessageBox.Show("Selecione el documento que va a generar!");
                    cmbdocumento.Focus();
                    return;
                }
                if (cmbalmacen.Text == "")
                {
                    MessageBox.Show("Selecione almacén!");
                    cmbalmacen.Focus();
                    return;
                }
                if (cmbproducto.Text == "")
                {
                    MessageBox.Show("Selecione el producto!");
                    cmbproducto.Focus();
                    return;
                }
                if (Convert.ToInt32(Dtmvtoproducto.Rows[celda].Cells["Cantidad"].Value) <= 0)
                {
                    MessageBox.Show("La cantidad a procesar debe ser mayor que cero (0)!");
                    return;
                }
                for (int renglon = 0; renglon < Dtmvtoproducto.Rows.Count; renglon++)
                {
                    if (txtransac.Text == "CREDITO" && Convert.ToInt32(Dtmvtoproducto.Rows[renglon].Cells["Cantidad"].Value) > Convert.ToInt32(recibir_existencia))
                    {
                        MessageBox.Show("La cantidad a procesar es mayor que la existencia", "ALERTA");
                        cmdgrabar.Enabled = true;
                        return;
                    }
                }
                DialogResult resultado = MessageBox.Show("¿Desea grabar " + cmbdocumento.Text + '?', "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    return;
                }
                mensajexistencia();
                guarda_cabecera();
                guarda_detalle();
                cmbalmacen.Items.Clear();
                cmbdocum.Enabled = true;
                funcion.guardar_seguimiento("Registra Movimiento de Productos", recibir_usuario);
            }
            else
            {
                MessageBox.Show("Usuario no tiene permisos para registrar movimientos");
                return;
            }
        }

        void guarda_cabecera()
        {
            try
            {
                if (Convert.ToString(Dtmvtoproducto.Rows[a].Cells["Codigo"].Value) != "")
                {
                    MySqlCommand grabar = new MySqlCommand("Insert into movimiento_productos (idproveedor, doc_proveedor, fecha, iddoc, nro_pedido, idalmacen, idcliente, idmvto)values(@idproveedor, @doc_proveedor, @fecha, @iddoc, @nro_pedido, @idalmacen, @idcliente, @idmvto)", miconexion);
                    grabar.Parameters.AddWithValue("idproveedor", txtidproveedor.Text);
                    grabar.Parameters.AddWithValue("fecha", txtfecha.Text);
                    grabar.Parameters.AddWithValue("iddoc", txtidocumento.Text);
                    grabar.Parameters.AddWithValue("nro_pedido", txtpedido.Text);
                    grabar.Parameters.AddWithValue("idalmacen", txtidalmacen.Text);
                    grabar.Parameters.AddWithValue("doc_proveedor", txtfactura.Text);
                    grabar.Parameters.AddWithValue("idcliente", txtidcliente.Text);
                    grabar.Parameters.AddWithValue("idmvto", txtidmvto.Text);
                    miconexion.Open();
                    grabar.ExecuteNonQuery();
                    miconexion.Close();
                    cmdgrabar.Enabled = false;
                    cmdnuevo.Enabled = true;
                    actualizardoc_actual();
                }
                else
                {
                    MessageBox.Show("No ha seleccionado producto para registrar");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en movimiento_productos: " + ex.Message);
                return;
            }

        }
        void guarda_detalle()
        {
            try
            {
                for (int a = 0; a < Dtmvtoproducto.RowCount; a++)
                {
                    if (Dtmvtoproducto.Rows[a].IsNewRow) continue;
                    {
                        MySqlCommand grabar = new MySqlCommand("insert into detalle_movimiento_product(idmvto, documento, nro_documento, transaccion, idproducto, nombre_producto, unidad, cantidad, valor_unitario, valor_total, observacion, fecha)values(@idmvto, @documento, @nro_documento, @transaccion, @idproducto, @nombre_producto, @unidad, @cantidad, @valor_unitario, @valor_total, @observacion, @fecha)", miconexion);
                        grabar.Parameters.AddWithValue("idmvto", txtidmvto.Text);
                        grabar.Parameters.AddWithValue("documento", cmbdocumento.Text);
                        grabar.Parameters.AddWithValue("nro_documento", txtdoc.Text);
                        grabar.Parameters.AddWithValue("transaccion", txtransac.Text);
                        grabar.Parameters.AddWithValue("idproducto", Dtmvtoproducto.Rows[a].Cells["Codigo"].Value);
                        grabar.Parameters.AddWithValue("nombre_producto", Dtmvtoproducto.Rows[a].Cells["Producto"].Value);
                        grabar.Parameters.AddWithValue("unidad", Dtmvtoproducto.Rows[a].Cells["Unidad"].Value);
                        grabar.Parameters.AddWithValue("cantidad", Dtmvtoproducto.Rows[a].Cells["Cantidad"].Value);
                        grabar.Parameters.AddWithValue("valor_unitario", Dtmvtoproducto.Rows[a].Cells["Valor"].Value);
                        grabar.Parameters.AddWithValue("valor_total", Dtmvtoproducto.Rows[a].Cells["Valores"].Value);
                        grabar.Parameters.AddWithValue("observacion", txtobservacion.Text);
                        grabar.Parameters.AddWithValue("fecha", txtfecha.Text);
                        miconexion.Open();
                        grabar.ExecuteNonQuery();
                        miconexion.Close();
                    }
                }

                actualizaexistencia();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en detalle_movimiento_product: " + ex.Message);
                return;
            }
            MessageBox.Show("Movimiento Exitoso!");
            Dtmvtoproducto.Rows.Clear();
            cmbdocumento.Enabled = false;
            cmbalmacen.Enabled = false;
            cmbproveedor.Enabled = false;
            cmbproducto.Enabled = false;
            txtobservacion.ReadOnly = true;
            txtpedido.ReadOnly = true;
            txtfactura.ReadOnly = true;
            cmbproducto.Text = "";
        }

        //Actuliza el numero de documento actual en la tabla tipo_documentos
        void actualizardoc_actual()
        {
            try
            {
                MySqlCommand actualizar = new MySqlCommand("update tipo_documentos set documento_actual=@documento_actual where iddoc=@id", miconexion);
                actualizar.Parameters.AddWithValue("id", txtidocumento.Text);
                actualizar.Parameters.AddWithValue("documento_actual", txtdoc.Text);
                miconexion.Open();
                actualizar.ExecuteNonQuery();
                miconexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en documento_actual: " + ex.Message);
            }
        }

        //consulta para crear autonumerico y sumarle 1 al documento actual
        void documentoactual()
        {
            if (txtidocumento.Text != "")
            {
                MySqlCommand comando = new MySqlCommand("select documento_actual from tipo_documentos where nombre_documento='" + cmbdocumento.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    txtdoc.Text = Convert.ToString(leer.GetInt32(0) + 1);
                }
                miconexion.Close();
            }
        }

        //Actualiza existencia
        void actualizaexistencia()
        {
            try
            {
                if (txtransac.Text == "DEBITO")
                {
                    for (int fila = 0; fila < Dtmvtoproducto.RowCount; fila++)
                    {
                        if (Dtmvtoproducto.Rows[fila].IsNewRow) continue;
                        {
                            MySqlCommand actualizar = new MySqlCommand("update productos set existencia=existencia + " + Dtmvtoproducto.Rows[fila].Cells["Cantidad"].Value + " where idproducto='" + Dtmvtoproducto.Rows[fila].Cells["Codigo"].Value + "'", miconexion);
                            miconexion.Open();
                            actualizar.ExecuteNonQuery();
                            miconexion.Close();
                        }
                    }
                }
                else
                {
                    for (int fila = 0; fila < Dtmvtoproducto.RowCount; fila++)
                    {
                        if (Dtmvtoproducto.Rows[fila].IsNewRow) continue;
                        {
                            MySqlCommand actualizar = new MySqlCommand("update productos set existencia=existencia - " + Dtmvtoproducto.Rows[fila].Cells["Cantidad"].Value + " where idproducto='" + Dtmvtoproducto.Rows[fila].Cells["Codigo"].Value + "'", miconexion);
                            miconexion.Open();
                            actualizar.ExecuteNonQuery();
                            miconexion.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar existencias: " + ex.Message);
                return;
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
                cmdnuevo.Enabled = false;
                cmdmodific.Enabled = false;
                cmbdocum.Enabled = false;
                cmbdocumento.Enabled = true;
                cmbalmacen.Enabled = true;
                cmbproveedor.Enabled = true;
                txtobservacion.ReadOnly = false;
                txtpedido.ReadOnly = false;
                txtfactura.ReadOnly = false;
                cmbdocumento.Text = "";
                txtidocumento.Text = "";
                cmbalmacen.Text = "";
                txtidalmacen.Text = "";
                txtdoc.Text = "";
                txtransac.Text = "";
                cmbproveedor.Text = "";
                cmbproducto.Text = "";
                txtobservacion.Text = "";
                txtpedido.Text = "";
                txtfactura.Text = "";
                txtotal.Text = "";
                txtidproveedor.Text = "";
                txtidcliente.Text = "";
                autonumericoidmvto();
                cargarnombrealmacen();
                cmbdocumento.Focus();
                funcion.guardar_seguimiento("Intenta registrar Movimiento de Productos", recibir_usuario);
            }
        }

        void cargadatagrid()
        {
            try
            {
                MySqlCommand comando = new MySqlCommand("select * from productos where nombre_producto='" + cmbproducto.Text + "'", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                int renglon = Dtmvtoproducto.Rows.Add();
                while (leer.Read())
                {
                    Dtmvtoproducto.Rows[renglon].Cells["Codigo"].Value = leer.GetString(1);
                    Dtmvtoproducto.Rows[renglon].Cells["Producto"].Value = leer.GetString(2);
                    Dtmvtoproducto.Rows[renglon].Cells["Unidad"].Value = leer.GetString(11);
                    Dtmvtoproducto.Rows[renglon].Cells["Valor"].Value = leer.GetString(3);
                    Dtmvtoproducto.Rows[renglon].Cells["Cantidad"].Value = 0;
                    Dtmvtoproducto.Rows[renglon].Cells["Valores"].Value = Convert.ToInt32(Dtmvtoproducto.Rows[renglon].Cells["Valor"].Value) * Convert.ToInt32(Dtmvtoproducto.Rows[renglon].Cells["Cantidad"].Value);
                    Dtmvtoproducto.Rows[renglon].Cells["Existencia"].Value = leer.GetString(4);
                    Dtmvtoproducto.Rows[renglon].Cells["PtoMinStock"].Value = leer.GetString(9);
                    Dtmvtoproducto.Rows[renglon].Cells["PtoMaxStock"].Value = leer.GetString(10);
                }
                miconexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos en grilla de productos: " + ex.Message);
            }
        }

        void mensajexistencia()
        {
            for (int renglon = 0; renglon < Dtmvtoproducto.Rows.Count; renglon++)
            {
                int nuevaexistencia = 0;
                nuevaexistencia = Convert.ToInt32(Dtmvtoproducto.Rows[renglon].Cells["Existencia"].Value) + Convert.ToInt32(Dtmvtoproducto.Rows[renglon].Cells["Cantidad"].Value);
                if (Convert.ToInt32(Dtmvtoproducto.Rows[renglon].Cells["Valores"].Value) > 0)
                {
                    if (nuevaexistencia > Convert.ToInt32(Dtmvtoproducto.Rows[renglon].Cells["PtoMaxStock"].Value))
                    {
                        MessageBox.Show(Dtmvtoproducto.Rows[renglon].Cells["Producto"].Value + " Superará el punto maximo de stock", "ALERTA");
                    }
                    if (nuevaexistencia < Convert.ToInt32(Dtmvtoproducto.Rows[renglon].Cells["PtoMinStock"].Value))
                    {
                        MessageBox.Show(Dtmvtoproducto.Rows[renglon].Cells["Producto"].Value + " Quedará por debajo del punto minimo de stock", "ALERTA");
                    }
                }
            }
        }

        void multiplicar()
        {
            for (int i = 0; i < Dtmvtoproducto.Rows.Count; i++)
            {
                Dtmvtoproducto.Rows[i].Cells["Valores"].Value = Convert.ToInt32(Dtmvtoproducto.Rows[i].Cells["Valor"].Value) * Convert.ToInt32(Dtmvtoproducto.Rows[i].Cells["Cantidad"].Value);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            multiplicar();
        }

        void autonumericoidmvto()
        {
            MySqlCommand comando = new MySqlCommand("select max(idmvto) from movimiento_productos", miconexion);
            miconexion.Open();
            MySqlDataReader leer = comando.ExecuteReader();

            try
            {
                if (leer.Read())
                {
                    txtidmvto.Text = Convert.ToString(leer.GetInt32(0) + 1);
                }
            }
            catch
            {
                txtidmvto.Text = 1.ToString();
            }
            
            miconexion.Close();
        }

        private void cmbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargadatagrid();
            cmbdocumento.Enabled = false;
            cmbalmacen.Enabled = false;
            cmbproveedor.Enabled = false;
            cmdgrabar.Enabled = true;
            traerexistencia();
        }

        private void txtransac_TextChanged(object sender, EventArgs e)
        {
            if (txtransac.Text == "CREDITO")
            {
                txtfactura.Enabled = false;
                txtfactura.Text = "NO APLICA";
                lblproveedor.Visible = false;
                lblcliente.Visible = true;
                cmbproveedor.Visible = false;
                cmbcliente.Visible = true;
                txtidproveedor.Visible = false;
                txtidcliente.Visible = true;
            }
            else
            {
                txtfactura.Text = "";
                txtfactura.Enabled = true;
                lblproveedor.Visible = true;
                lblcliente.Visible = false;
                cmbproveedor.Visible = true;
                cmbcliente.Visible = false;
                txtidcliente.Visible = false;
                txtidproveedor.Visible = true;
            }
        }

        private void cmdkardex_Click(object sender, EventArgs e)
        {
            Frmproductos productos = new Frmproductos();
            productos.Show();
        }

        private void cmbproveedor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (txtransac.Text == "DEBITO")
            {
                cargaridproveedor();
            }
            else
            {
                cargaridcliente();
            }
            if (cmbdocumento.Text == "" || cmbalmacen.Text == "")
            {
                MessageBox.Show("No ha seleccionado Documento o Almacen!");
                cmbproveedor.Items.Clear();
                if (txtransac.Text == "DEBITO")
                {
                    cargarnombreproveedor();
                }
                else
                {
                    cargarnombrecliente();
                }
                txtidproveedor.Text = "";
                txtidcliente.Text = "";
                return;
            }
            if (txtpedido.Text == "" || txtfactura.Text == "")
            {
                MessageBox.Show("Digite numero de pedido y/o numero de factura, si no tiene digite cero (0) en ambos cambos!");
                cmbproveedor.Items.Clear();
                if (txtransac.Text == "DEBITO")
                {
                    cargarnombreproveedor();
                    txtfactura.Enabled = true;
                }
                else
                {
                    cargarnombrecliente();
                }
                txtidproveedor.Text = "";
                txtidcliente.Text = "";
                return;
            }
            else
            {
                cmbproducto.Enabled = true;
            }
        }

        private void cmbcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtransac.Text == "CREDITO")
            {
                cargaridcliente();
            }
            else
            {
                cargaridproveedor();
            }
            if (cmbdocumento.Text == "" || cmbalmacen.Text == "")
            {
                MessageBox.Show("No ha seleccionado Documento o Almacen!");
                cmbcliente.Items.Clear();
                if (txtransac.Text == "CREDITO")
                {
                    cargarnombrecliente();
                }
                else
                {
                    cargarnombreproveedor();
                }
                txtidproveedor.Text = "";
                txtidcliente.Text = "";
                return;
            }
            if (txtpedido.Text == "" || txtfactura.Text == "")
            {
                MessageBox.Show("Digite numero de pedido y/o numero de factura, si no tiene digite cero (0) en ambos cambos!");
                cmbcliente.Items.Clear();
                if (txtransac.Text == "CREDITO")
                {
                    cargarnombrecliente();
                    txtfactura.Enabled = true;
                }
                else
                {
                    cargarnombreproveedor();
                }
                txtidproveedor.Text = "";
                txtidcliente.Text = "";
                return;
            }
            else
            {
                cmbproducto.Enabled = true;
            }
        }

        private void cmbdocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbdocumento.Text != "")
            {
                cargaridocumento();
                documentoactual();
                cargardescripcionmovimiento();
            }
        }

        private void cmbalmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbalmacen.Text != "")
            {
                cargaridalmacen();
            }
        }

        private void cmdmodific_Click(object sender, EventArgs e)
        {
            if (recibir_tipousuario == "1")
            {
                cmdnuevo.Enabled = false;
                cmdmodific.Enabled = false;
                cmdgrabar.Enabled = true;
                cmbdocum.Enabled = false;
                cmbdocumento.Enabled = true;
                cmbalmacen.Enabled = true;
                cmbproveedor.Enabled = true;
                txtobservacion.ReadOnly = false;
                txtpedido.ReadOnly = false;
                txtfactura.ReadOnly = false;
                funcion.guardar_seguimiento("Intenta modificar registro de Movimiento de Productos", recibir_usuario);
            }
            else
            {
                MessageBox.Show("Usuario no tiene permisos para actualizar registro de movimientos");
                return;
            }
        }

        private void Frmovimientoproducto_Load(object sender, EventArgs e)
        {
            funcion.guardar_seguimiento("Entra a formulario Movimiento de Productos", recibir_usuario);
        }

        private void cmbidmvto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargardocumento();
        }
    }
}
