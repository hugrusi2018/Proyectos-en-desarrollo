using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BdInventario
{
    public partial class Frmconsultaempleados : Planticonsultas
    {
        public Frmconsultaempleados()
        {
            InitializeComponent();
        }

        private void Frmconsultaempleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetEmpleados.empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.bdinventarioDataSetEmpleados.empleados);

        }
    }
}
