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
    public partial class Frmconsultastock : Planticonsultas
    {
        public Frmconsultastock()
        {
            InitializeComponent();

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

        void cargadatagrid()
        {
            try
            { 
                MySqlCommand comando = new MySqlCommand("select * from productos", miconexion);
                miconexion.Open();
                MySqlDataReader leer = comando.ExecuteReader();
                int renglon = 0;                
                while (leer.Read())
                {
                    renglon = dataGridView1.Rows.Add();
                    dataGridView1.Rows[renglon].Cells["IdAlmacen"].Value = leer.GetString(6);
                    dataGridView1.Rows[renglon].Cells["IdProducto"].Value = leer.GetString(1);
                    dataGridView1.Rows[renglon].Cells["Nombre_Producto"].Value = leer.GetString(2);
                    dataGridView1.Rows[renglon].Cells["Valor_Unitario"].Value = leer.GetString(3);
                    dataGridView1.Rows[renglon].Cells["Existencia"].Value = leer.GetString(4);
                    dataGridView1.Rows[renglon].Cells["PtoMinStock"].Value = leer.GetString(9);
                    dataGridView1.Rows[renglon].Cells["PtoMaxStock"].Value = leer.GetString(10);                  
                }
                mincompra();
                maxcompra();
                miconexion.Close();
            }
            catch (Exception exec)
            {
                MessageBox.Show("Error al cargar datagrid: " + exec.Message);
            }
        }

        void mincompra()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["Min_Comprar"].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells["PtoMinStock"].Value) - Convert.ToInt32(dataGridView1.Rows[i].Cells["Existencia"].Value);
            }
        }

        void maxcompra()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells["Max_Comprar"].Value = Convert.ToInt32(dataGridView1.Rows[i].Cells["PtoMaxStock"].Value) - Convert.ToInt32(dataGridView1.Rows[i].Cells["Existencia"].Value);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            timer1.Enabled = false;
        }

        private void Frmconsultastock_Load(object sender, EventArgs e)
        {
            cargadatagrid();
        }
    }
}
