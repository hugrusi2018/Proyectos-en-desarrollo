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
    public partial class Frmauditoria : Planticonsultas
    {
        public Frmauditoria()
        {
            InitializeComponent();
        }

        private void Auditoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetAuditoria.auditoria' Puede moverla o quitarla según sea necesario.
            this.auditoriaTableAdapter.Fill(this.bdinventarioDataSetAuditoria.auditoria);

        }
    }
}
