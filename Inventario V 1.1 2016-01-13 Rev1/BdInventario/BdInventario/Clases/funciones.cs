using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using BdInventario.Clases;

namespace BdInventario
{
    class funciones
    {
        Data AccesoDatos = new Data();
        MySqlConnection bdconexion;

        public funciones()
        {
            bdconexion = new MySqlConnection(AccesoDatos.StringConnection);
        }

        public void guardar_movimientos(int idauditoria, string usuario, bool salida)
        {
            try
            {
                if (salida == false)
                {
                    MySqlCommand comando = new MySqlCommand("insert into Auditoria_Usuario (Id_Auditoria, Usuario, Fecha_Ingreso, Hora_Ingreso) values (@id, @usuario, @fecha, @hora)", bdconexion);
                    comando.Parameters.AddWithValue("id", idauditoria);
                    comando.Parameters.AddWithValue("usuario", usuario);
                    comando.Parameters.AddWithValue("fecha", DateTime.Today.Date);
                    DateTime x2 = new DateTime();
                    x2 = DateTime.Now;
                    string y = Convert.ToString(x2.Hour + ":" + x2.Minute + ":" + x2.Second);
                    comando.Parameters.AddWithValue("hora", y);

                    bdconexion.Open();
                    comando.ExecuteNonQuery();
                    bdconexion.Close();

                }
                else
                {
                    MySqlCommand comando = new MySqlCommand("update Auditoria_Usuario set Fecha_salida=@fecha, Hora_Salida=@hora where Id_Auditoria=" + idauditoria, bdconexion);
                    comando.Parameters.AddWithValue("fecha", DateTime.Today.Date);
                    DateTime x2 = new DateTime();
                    x2 = DateTime.Now;
                    string y = Convert.ToString(x2.Hour + ":" + x2.Minute + ":" + x2.Second);
                    comando.Parameters.AddWithValue("hora", y);

                    bdconexion.Open();
                    comando.ExecuteNonQuery();
                    bdconexion.Close();
                }
            }
            catch
            {
                bdconexion.Close();
                return;
            }
        }

        public void guardar_seguimiento(string accion, string detalle)
        {
            try
            {

                MySqlCommand comando = new MySqlCommand("insert into Auditoria (Accion, Fecha, Hora, usuario) values (@acc, @fecha, @hora, @usuario)", bdconexion);
                comando.Parameters.AddWithValue("acc", accion);
                comando.Parameters.AddWithValue("fecha", DateTime.Today.Date);
                DateTime x2 = new DateTime();
                x2 = DateTime.Now;
                string y = Convert.ToString(x2.Hour + ":" + x2.Minute + ":" + x2.Second);
                comando.Parameters.AddWithValue("hora", y);
                comando.Parameters.AddWithValue("usuario", detalle);

                bdconexion.Open();
                comando.ExecuteNonQuery();
                bdconexion.Close();
            }
            catch
            {
                bdconexion.Close();
                return;
            }
          
        }
    }
}
