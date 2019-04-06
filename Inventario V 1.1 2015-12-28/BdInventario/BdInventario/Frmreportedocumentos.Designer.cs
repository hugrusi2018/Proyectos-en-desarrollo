namespace BdInventario
{
    partial class Frmreportedocumentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tipo_documentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdinventarioDataSetTipodocumentos = new BdInventario.bdinventarioDataSetTipodocumentos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tipo_documentosTableAdapter = new BdInventario.bdinventarioDataSetTipodocumentosTableAdapters.tipo_documentosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_documentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetTipodocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(768, 57);
            this.label1.Text = "REPORTE DE DOCUMENTOS";
            // 
            // tipo_documentosBindingSource
            // 
            this.tipo_documentosBindingSource.DataMember = "tipo_documentos";
            this.tipo_documentosBindingSource.DataSource = this.bdinventarioDataSetTipodocumentos;
            // 
            // bdinventarioDataSetTipodocumentos
            // 
            this.bdinventarioDataSetTipodocumentos.DataSetName = "bdinventarioDataSetTipodocumentos";
            this.bdinventarioDataSetTipodocumentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tipo_documentosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BdInventario.Rptdocumentos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 88);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(768, 298);
            this.reportViewer1.TabIndex = 2;
            // 
            // tipo_documentosTableAdapter
            // 
            this.tipo_documentosTableAdapter.ClearBeforeFill = true;
            // 
            // Frmreportedocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 386);
            this.Controls.Add(this.reportViewer1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frmreportedocumentos";
            this.Text = "Frmreportedocumentos";
            this.Load += new System.EventHandler(this.Frmreportedocumentos_Load);
            this.Controls.SetChildIndex(this.reportViewer1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tipo_documentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetTipodocumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tipo_documentosBindingSource;
        private bdinventarioDataSetTipodocumentos bdinventarioDataSetTipodocumentos;
        private bdinventarioDataSetTipodocumentosTableAdapters.tipo_documentosTableAdapter tipo_documentosTableAdapter;

    }
}