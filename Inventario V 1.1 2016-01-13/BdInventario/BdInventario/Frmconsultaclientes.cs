using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BdInventario
{
    public partial class Frmconsultaclientes : Planticonsultas
    {
        public Frmconsultaclientes()
        {
            InitializeComponent();
        }

        DataGridViewPrinter impresion;
        private void Consultaclientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdinventarioDataSetCliente.cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.bdinventarioDataSetCliente.cliente);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private bool SetupThePrinting()
        {
            PrintDialog MyPrintDialog = new PrintDialog();
            MyPrintDialog.AllowCurrentPage = false;
            MyPrintDialog.AllowPrintToFile = false;
            MyPrintDialog.AllowSelection = false;
            MyPrintDialog.AllowSomePages = false;
            MyPrintDialog.PrintToFile = false;
            MyPrintDialog.ShowHelp = false;
            MyPrintDialog.ShowNetwork = false;


            if (MyPrintDialog.ShowDialog() != DialogResult.OK)
                return false;

            pd_impresion.DocumentName = "Impresión";
            pd_impresion.PrinterSettings = MyPrintDialog.PrinterSettings;
            pd_impresion.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            pd_impresion.DefaultPageSettings.Margins = new Margins(50, 20, 20, 20);

            //imprimir consulta normal
            if (MessageBox.Show("Centrar el Contenido del informe", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                impresion = new DataGridViewPrinter(dataGridView1, pd_impresion, true, true, textBox1.Text, new Font("Microsoft Sans Serif", 6, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
            }
            else
            {
                impresion = new DataGridViewPrinter(dataGridView1, pd_impresion, false, true, textBox1.Text, new Font("Microsoft Sans Serif", 6, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
            }

            return true;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.FillBy(this.bdinventarioDataSetCliente.cliente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pd_impresion_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = impresion.DrawDataGridView(e.Graphics);
            if (more == true)
            {
                e.HasMorePages = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SetupThePrinting())
            {
                PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                MyPrintPreviewDialog.Document = pd_impresion;
                MyPrintPreviewDialog.WindowState = FormWindowState.Maximized;
                MyPrintPreviewDialog.StartPosition = FormStartPosition.CenterScreen;
                MyPrintPreviewDialog.ShowIcon = false;
                MyPrintPreviewDialog.ShowDialog();
            }
        }
    }
}
