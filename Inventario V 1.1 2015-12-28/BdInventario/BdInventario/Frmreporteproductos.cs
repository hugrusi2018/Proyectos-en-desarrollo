﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BdInventario
{
    public partial class Frmreporteproductos : Plantillareportes
    {
        public Frmreporteproductos()
        {
            InitializeComponent();
        }

        private void Frmreporteproductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetProductos.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.bdinventarioDataSetProductos.productos);

            this.reportViewer1.RefreshReport();
        }
    }
}
