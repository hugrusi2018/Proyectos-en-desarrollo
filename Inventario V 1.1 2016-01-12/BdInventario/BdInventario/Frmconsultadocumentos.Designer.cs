namespace BdInventario
{
    partial class Frmconsultadocumentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmconsultadocumentos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tipodocumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdinventarioDataSetTipodocumentos = new BdInventario.bdinventarioDataSetTipodocumentos();
            this.tipo_documentosTableAdapter = new BdInventario.bdinventarioDataSetTipodocumentosTableAdapters.tipo_documentosTableAdapter();
            this.idDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iniciarDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetTipodocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Size = new System.Drawing.Size(649, 62);
            this.label1.Text = "CONSULTA DE DOCUMENTOS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDocDataGridViewTextBoxColumn,
            this.nombreDocumentoDataGridViewTextBoxColumn,
            this.transaccionDataGridViewTextBoxColumn,
            this.iniciarDocumentoDataGridViewTextBoxColumn,
            this.documentoActualDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tipodocumentosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(636, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // tipodocumentosBindingSource
            // 
            this.tipodocumentosBindingSource.DataMember = "tipo_documentos";
            this.tipodocumentosBindingSource.DataSource = this.bdinventarioDataSetTipodocumentos;
            // 
            // bdinventarioDataSetTipodocumentos
            // 
            this.bdinventarioDataSetTipodocumentos.DataSetName = "bdinventarioDataSetTipodocumentos";
            this.bdinventarioDataSetTipodocumentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipo_documentosTableAdapter
            // 
            this.tipo_documentosTableAdapter.ClearBeforeFill = true;
            // 
            // idDocDataGridViewTextBoxColumn
            // 
            this.idDocDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idDocDataGridViewTextBoxColumn.DataPropertyName = "IdDoc";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.idDocDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idDocDataGridViewTextBoxColumn.HeaderText = "IdDoc";
            this.idDocDataGridViewTextBoxColumn.Name = "idDocDataGridViewTextBoxColumn";
            this.idDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDocDataGridViewTextBoxColumn.Width = 77;
            // 
            // nombreDocumentoDataGridViewTextBoxColumn
            // 
            this.nombreDocumentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombreDocumentoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Documento";
            this.nombreDocumentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.nombreDocumentoDataGridViewTextBoxColumn.Name = "nombreDocumentoDataGridViewTextBoxColumn";
            this.nombreDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDocumentoDataGridViewTextBoxColumn.Width = 117;
            // 
            // transaccionDataGridViewTextBoxColumn
            // 
            this.transaccionDataGridViewTextBoxColumn.DataPropertyName = "Transaccion";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.transaccionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.transaccionDataGridViewTextBoxColumn.HeaderText = "Transacción";
            this.transaccionDataGridViewTextBoxColumn.Name = "transaccionDataGridViewTextBoxColumn";
            this.transaccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iniciarDocumentoDataGridViewTextBoxColumn
            // 
            this.iniciarDocumentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iniciarDocumentoDataGridViewTextBoxColumn.DataPropertyName = "Iniciar_Documento";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.iniciarDocumentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.iniciarDocumentoDataGridViewTextBoxColumn.HeaderText = "Doc. a Iniciar";
            this.iniciarDocumentoDataGridViewTextBoxColumn.Name = "iniciarDocumentoDataGridViewTextBoxColumn";
            this.iniciarDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iniciarDocumentoDataGridViewTextBoxColumn.Width = 126;
            // 
            // documentoActualDataGridViewTextBoxColumn
            // 
            this.documentoActualDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.documentoActualDataGridViewTextBoxColumn.DataPropertyName = "Documento_Actual";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.documentoActualDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.documentoActualDataGridViewTextBoxColumn.HeaderText = "Doc. Actual";
            this.documentoActualDataGridViewTextBoxColumn.Name = "documentoActualDataGridViewTextBoxColumn";
            this.documentoActualDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentoActualDataGridViewTextBoxColumn.Width = 116;
            // 
            // Frmconsultadocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 394);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frmconsultadocumentos";
            this.Text = "Consulta Documentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmconsultadocumentos_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetTipodocumentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bdinventarioDataSetTipodocumentos bdinventarioDataSetTipodocumentos;
        private System.Windows.Forms.BindingSource tipodocumentosBindingSource;
        private bdinventarioDataSetTipodocumentosTableAdapters.tipo_documentosTableAdapter tipo_documentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transaccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iniciarDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoActualDataGridViewTextBoxColumn;
        
    }
}