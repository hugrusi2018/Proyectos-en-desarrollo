namespace BdInventario
{
    partial class Frmdocumentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmdocumentos));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidoc = new System.Windows.Forms.TextBox();
            this.cmdnuevo = new System.Windows.Forms.Button();
            this.cmdgrabar = new System.Windows.Forms.Button();
            this.cmdmodific = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdcerrar = new System.Windows.Forms.Button();
            this.cmdeliminar = new System.Windows.Forms.Button();
            this.cmbdocumento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtransaccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdocactual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdocini = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iniciarDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodocumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdinventarioDataSetTipodocumentos = new BdInventario.bdinventarioDataSetTipodocumentos();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.tipo_documentosTableAdapter = new BdInventario.bdinventarioDataSetTipodocumentosTableAdapters.tipo_documentosTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetTipodocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdocumento);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtdocini);
            this.groupBox1.Controls.Add(this.cmbdocumento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtdocactual);
            this.groupBox1.Controls.Add(this.cmdeliminar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmdmodific);
            this.groupBox1.Controls.Add(this.txtransaccion);
            this.groupBox1.Controls.Add(this.cmdnuevo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmdgrabar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtidoc);
            this.groupBox1.Location = new System.Drawing.Point(6, 76);
            this.groupBox1.Size = new System.Drawing.Size(570, 371);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Size = new System.Drawing.Size(514, 61);
            this.label1.Text = "CONTROL DOCUMENTOS";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID.:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(99, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Documento.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtidoc
            // 
            this.txtidoc.BackColor = System.Drawing.SystemColors.Window;
            this.txtidoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidoc.Location = new System.Drawing.Point(44, 48);
            this.txtidoc.Multiline = true;
            this.txtidoc.Name = "txtidoc";
            this.txtidoc.Size = new System.Drawing.Size(56, 25);
            this.txtidoc.TabIndex = 0;
            this.txtidoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdnuevo
            // 
            this.cmdnuevo.BackColor = System.Drawing.Color.White;
            this.cmdnuevo.BackgroundImage = global::BdInventario.Properties.Resources.New;
            this.cmdnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdnuevo.Location = new System.Drawing.Point(6, 303);
            this.cmdnuevo.Name = "cmdnuevo";
            this.cmdnuevo.Size = new System.Drawing.Size(61, 62);
            this.cmdnuevo.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cmdnuevo, "Nuevo");
            this.cmdnuevo.UseVisualStyleBackColor = false;
            this.cmdnuevo.Click += new System.EventHandler(this.cmdnuevo_Click);
            // 
            // cmdgrabar
            // 
            this.cmdgrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdgrabar.BackgroundImage = global::BdInventario.Properties.Resources.Save;
            this.cmdgrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdgrabar.Location = new System.Drawing.Point(83, 303);
            this.cmdgrabar.Name = "cmdgrabar";
            this.cmdgrabar.Size = new System.Drawing.Size(61, 62);
            this.cmdgrabar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.cmdgrabar, "Guardar");
            this.cmdgrabar.UseVisualStyleBackColor = false;
            this.cmdgrabar.Click += new System.EventHandler(this.cmdgrabar_Click);
            // 
            // cmdmodific
            // 
            this.cmdmodific.BackColor = System.Drawing.Color.Aqua;
            this.cmdmodific.BackgroundImage = global::BdInventario.Properties.Resources.Editor;
            this.cmdmodific.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdmodific.Location = new System.Drawing.Point(164, 303);
            this.cmdmodific.Name = "cmdmodific";
            this.cmdmodific.Size = new System.Drawing.Size(61, 62);
            this.cmdmodific.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cmdmodific, "Actualizar");
            this.cmdmodific.UseVisualStyleBackColor = false;
            this.cmdmodific.Click += new System.EventHandler(this.cmdmodific_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(432, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // cmdcerrar
            // 
            this.cmdcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdcerrar.BackgroundImage = global::BdInventario.Properties.Resources.Back;
            this.cmdcerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdcerrar.ForeColor = System.Drawing.Color.Red;
            this.cmdcerrar.Location = new System.Drawing.Point(515, 8);
            this.cmdcerrar.Name = "cmdcerrar";
            this.cmdcerrar.Size = new System.Drawing.Size(61, 62);
            this.cmdcerrar.TabIndex = 13;
            this.toolTip1.SetToolTip(this.cmdcerrar, "Atras");
            this.cmdcerrar.UseVisualStyleBackColor = true;
            this.cmdcerrar.Click += new System.EventHandler(this.cmdcerrar_Click);
            // 
            // cmdeliminar
            // 
            this.cmdeliminar.BackColor = System.Drawing.Color.White;
            this.cmdeliminar.BackgroundImage = global::BdInventario.Properties.Resources.Delete;
            this.cmdeliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdeliminar.Location = new System.Drawing.Point(244, 303);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(61, 62);
            this.cmdeliminar.TabIndex = 22;
            this.toolTip1.SetToolTip(this.cmdeliminar, "Eliminar");
            this.cmdeliminar.UseVisualStyleBackColor = false;
            this.cmdeliminar.Click += new System.EventHandler(this.cmdeliminar_Click);
            // 
            // cmbdocumento
            // 
            this.cmbdocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbdocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbdocumento.DisplayMember = "IdDoc";
            this.cmbdocumento.FormattingEnabled = true;
            this.cmbdocumento.Location = new System.Drawing.Point(112, 13);
            this.cmbdocumento.Name = "cmbdocumento";
            this.cmbdocumento.Size = new System.Drawing.Size(314, 28);
            this.cmbdocumento.TabIndex = 9;
            this.cmbdocumento.ValueMember = "IdDoc";
            this.cmbdocumento.SelectedIndexChanged += new System.EventHandler(this.cmbdocumento_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Transacción.:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtransaccion
            // 
            this.txtransaccion.BackColor = System.Drawing.Color.White;
            this.txtransaccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtransaccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtransaccion.Location = new System.Drawing.Point(112, 72);
            this.txtransaccion.Multiline = true;
            this.txtransaccion.Name = "txtransaccion";
            this.txtransaccion.Size = new System.Drawing.Size(115, 25);
            this.txtransaccion.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(224, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Doc. Actual.:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtdocactual
            // 
            this.txtdocactual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtdocactual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdocactual.Location = new System.Drawing.Point(326, 96);
            this.txtdocactual.Multiline = true;
            this.txtdocactual.Name = "txtdocactual";
            this.txtdocactual.Size = new System.Drawing.Size(100, 25);
            this.txtdocactual.TabIndex = 5;
            this.txtdocactual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(224, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Doc. Inicial.:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtdocini
            // 
            this.txtdocini.BackColor = System.Drawing.Color.White;
            this.txtdocini.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdocini.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdocini.Location = new System.Drawing.Point(326, 72);
            this.txtdocini.Multiline = true;
            this.txtdocini.Name = "txtdocini";
            this.txtdocini.Size = new System.Drawing.Size(100, 25);
            this.txtdocini.TabIndex = 7;
            this.txtdocini.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(6, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 28);
            this.label7.TabIndex = 23;
            this.label7.Text = "Seleccione.:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Lista de documentos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDocDataGridViewTextBoxColumn,
            this.nombreDocumentoDataGridViewTextBoxColumn,
            this.transaccionDataGridViewTextBoxColumn,
            this.iniciarDocumentoDataGridViewTextBoxColumn,
            this.documentoActualDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tipodocumentosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(558, 170);
            this.dataGridView1.TabIndex = 25;
            // 
            // idDocDataGridViewTextBoxColumn
            // 
            this.idDocDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idDocDataGridViewTextBoxColumn.DataPropertyName = "IdDoc";
            this.idDocDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDocDataGridViewTextBoxColumn.Name = "idDocDataGridViewTextBoxColumn";
            this.idDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDocDataGridViewTextBoxColumn.Width = 51;
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
            this.transaccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.transaccionDataGridViewTextBoxColumn.DataPropertyName = "Transaccion";
            this.transaccionDataGridViewTextBoxColumn.HeaderText = "Transacción";
            this.transaccionDataGridViewTextBoxColumn.Name = "transaccionDataGridViewTextBoxColumn";
            this.transaccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.transaccionDataGridViewTextBoxColumn.Width = 120;
            // 
            // iniciarDocumentoDataGridViewTextBoxColumn
            // 
            this.iniciarDocumentoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iniciarDocumentoDataGridViewTextBoxColumn.DataPropertyName = "Iniciar_Documento";
            this.iniciarDocumentoDataGridViewTextBoxColumn.HeaderText = "Doc. Inicial";
            this.iniciarDocumentoDataGridViewTextBoxColumn.Name = "iniciarDocumentoDataGridViewTextBoxColumn";
            this.iniciarDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iniciarDocumentoDataGridViewTextBoxColumn.Width = 111;
            // 
            // documentoActualDataGridViewTextBoxColumn
            // 
            this.documentoActualDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.documentoActualDataGridViewTextBoxColumn.DataPropertyName = "Documento_Actual";
            this.documentoActualDataGridViewTextBoxColumn.HeaderText = "Doc. Actual";
            this.documentoActualDataGridViewTextBoxColumn.Name = "documentoActualDataGridViewTextBoxColumn";
            this.documentoActualDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentoActualDataGridViewTextBoxColumn.Width = 116;
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtdocumento
            // 
            this.txtdocumento.BackColor = System.Drawing.Color.White;
            this.txtdocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdocumento.Location = new System.Drawing.Point(201, 48);
            this.txtdocumento.Multiline = true;
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(225, 25);
            this.txtdocumento.TabIndex = 26;
            // 
            // tipo_documentosTableAdapter
            // 
            this.tipo_documentosTableAdapter.ClearBeforeFill = true;
            // 
            // Frmdocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.cmdcerrar);
            this.Name = "Frmdocumentos";
            this.Text = "Control documentos";
            this.Load += new System.EventHandler(this.Frmtipomovimientos_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cmdcerrar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetTipodocumentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdnuevo;
        private System.Windows.Forms.Button cmdgrabar;
        private System.Windows.Forms.Button cmdmodific;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidoc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cmdeliminar;
        private System.Windows.Forms.ComboBox cmbdocumento;
        private System.Windows.Forms.TextBox txtdocini;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdocactual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtransaccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.Button cmdcerrar;
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