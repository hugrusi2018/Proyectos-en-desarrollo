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
    public partial class Frmconsultadocumentos : Planticonsultas
    {
        public Frmconsultadocumentos()
        {
            InitializeComponent();
        }

        private void Frmconsultadocumentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetTipodocumentos.tipo_documentos' Puede moverla o quitarla según sea necesario.
            this.tipo_documentosTableAdapter.Fill(this.bdinventarioDataSetTipodocumentos.tipo_documentos);

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmdcerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
