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
    public partial class Frmconsultaproveedores : Planticonsultas
    {
        public Frmconsultaproveedores()
        {
            InitializeComponent();
        }

        private void Frmconsultaproveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetProveedores.proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.bdinventarioDataSetProveedores.proveedores);

        }
    }
}
