using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdInventario.Clases
{
    public class Data
    {
        #region Campos

        private string stringConnection = "Server=localhost; Database=BdInventario; Uid=root; pwd=;";

        #endregion

        #region Propiedades

        /// <summary>
        /// Devuelve el valor de la cadena de Conexión
        /// </summary>
        public string StringConnection
        {
            get { return stringConnection; }
        }

        #endregion
    }
}
