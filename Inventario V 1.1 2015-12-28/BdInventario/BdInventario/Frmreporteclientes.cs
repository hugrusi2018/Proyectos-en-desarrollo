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
    public partial class Frmreporteclientes : Plantillareportes
    {
        public Frmreporteclientes()
        {
            InitializeComponent();
        }

        private void Frmreporteclientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetCliente.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.bdinventarioDataSetCliente.cliente);
            this.reportViewer1.RefreshReport();
        }        
    }
}
