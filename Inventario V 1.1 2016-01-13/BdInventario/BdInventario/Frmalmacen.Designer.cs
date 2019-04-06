namespace BdInventario
{
    partial class Frmalmacen
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtidalmacen = new System.Windows.Forms.TextBox();
            this.txtalmacen = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbalmacen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idAlmacenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAlmacenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almacenesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdinventarioDataSetAlmacen = new BdInventario.bdinventarioDataSetAlmacen();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdcerrar = new System.Windows.Forms.Button();
            this.cmdeliminar = new System.Windows.Forms.Button();
            this.cmdnuevo = new System.Windows.Forms.Button();
            this.cmdgrabar = new System.Windows.Forms.Button();
            this.cmdmodific = new System.Windows.Forms.Button();
            this.almacenesTableAdapter = new BdInventario.bdinventarioDataSetAlmacenTableAdapters.almacenesTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmdeliminar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.cmdnuevo);
            this.groupBox1.Controls.Add(this.cmdgrabar);
            this.groupBox1.Controls.Add(this.cmdmodific);
            this.groupBox1.Location = new System.Drawing.Point(6, 76);
            this.groupBox1.Size = new System.Drawing.Size(602, 365);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Size = new System.Drawing.Size(545, 62);
            this.label1.Text = "CONTROL DE ALMACEN";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(0, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descripción.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtidalmacen
            // 
            this.txtidalmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidalmacen.Location = new System.Drawing.Point(43, 48);
            this.txtidalmacen.Multiline = true;
            this.txtidalmacen.Name = "txtidalmacen";
            this.txtidalmacen.Size = new System.Drawing.Size(60, 28);
            this.txtidalmacen.TabIndex = 15;
            this.txtidalmacen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtalmacen
            // 
            this.txtalmacen.BackColor = System.Drawing.Color.White;
            this.txtalmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtalmacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtalmacen.Location = new System.Drawing.Point(102, 74);
            this.txtalmacen.Multiline = true;
            this.txtalmacen.Name = "txtalmacen";
            this.txtalmacen.Size = new System.Drawing.Size(381, 28);
            this.txtalmacen.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbalmacen);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtidalmacen);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.txtalmacen);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(6, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(591, 110);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // cmbalmacen
            // 
            this.cmbalmacen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbalmacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbalmacen.FormattingEnabled = true;
            this.cmbalmacen.Location = new System.Drawing.Point(102, 16);
            this.cmbalmacen.Name = "cmbalmacen";
            this.cmbalmacen.Size = new System.Drawing.Size(381, 28);
            this.cmbalmacen.TabIndex = 19;
            this.cmbalmacen.SelectedIndexChanged += new System.EventHandler(this.cmbalmacen_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(0, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Seleccione.:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::BdInventario.Properties.Resources.almacen;
            this.pictureBox1.Location = new System.Drawing.Point(489, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(0, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID.:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Lista Almacenes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlmacenDataGridViewTextBoxColumn,
            this.nombreAlmacenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.almacenesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(591, 145);
            this.dataGridView1.TabIndex = 35;
            // 
            // idAlmacenDataGridViewTextBoxColumn
            // 
            this.idAlmacenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idAlmacenDataGridViewTextBoxColumn.DataPropertyName = "IdAlmacen";
            this.idAlmacenDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idAlmacenDataGridViewTextBoxColumn.Name = "idAlmacenDataGridViewTextBoxColumn";
            this.idAlmacenDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAlmacenDataGridViewTextBoxColumn.Width = 51;
            // 
            // nombreAlmacenDataGridViewTextBoxColumn
            // 
            this.nombreAlmacenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreAlmacenDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Almacen";
            this.nombreAlmacenDataGridViewTextBoxColumn.HeaderText = "Descrpción";
            this.nombreAlmacenDataGridViewTextBoxColumn.Name = "nombreAlmacenDataGridViewTextBoxColumn";
            this.nombreAlmacenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // almacenesBindingSource
            // 
            this.almacenesBindingSource.DataMember = "almacenes";
            this.almacenesBindingSource.DataSource = this.bdinventarioDataSetAlmacen;
            // 
            // bdinventarioDataSetAlmacen
            // 
            this.bdinventarioDataSetAlmacen.DataSetName = "bdinventarioDataSetAlmacen";
            this.bdinventarioDataSetAlmacen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmdcerrar
            // 
            this.cmdcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdcerrar.BackgroundImage = global::BdInventario.Properties.Resources.Back;
            this.cmdcerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdcerrar.ForeColor = System.Drawing.Color.Red;
            this.cmdcerrar.Location = new System.Drawing.Point(547, 8);
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
            this.cmdeliminar.Location = new System.Drawing.Point(244, 297);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(61, 62);
            this.cmdeliminar.TabIndex = 17;
            this.toolTip1.SetToolTip(this.cmdeliminar, "Eliminar");
            this.cmdeliminar.UseVisualStyleBackColor = false;
            this.cmdeliminar.Click += new System.EventHandler(this.cmdeliminar_Click);
            // 
            // cmdnuevo
            // 
            this.cmdnuevo.BackColor = System.Drawing.Color.White;
            this.cmdnuevo.BackgroundImage = global::BdInventario.Properties.Resources.New;
            this.cmdnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdnuevo.Location = new System.Drawing.Point(6, 297);
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
            this.cmdgrabar.Location = new System.Drawing.Point(83, 297);
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
            this.cmdmodific.Location = new System.Drawing.Point(163, 297);
            this.cmdmodific.Name = "cmdmodific";
            this.cmdmodific.Size = new System.Drawing.Size(61, 62);
            this.cmdmodific.TabIndex = 12;
            this.cmdmodific.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.cmdmodific, "Actualizar");
            this.cmdmodific.UseVisualStyleBackColor = false;
            this.cmdmodific.Click += new System.EventHandler(this.cmdmodific_Click);
            // 
            // almacenesTableAdapter
            // 
            this.almacenesTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frmalmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 448);
            this.Controls.Add(this.cmdcerrar);
            this.Name = "Frmalmacen";
            this.Text = "Control de almacén";
            this.Load += new System.EventHandler(this.Frmalmacen_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cmdcerrar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetAlmacen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidalmacen;
        private System.Windows.Forms.TextBox txtalmacen;
        private System.Windows.Forms.Button cmdgrabar;
        private System.Windows.Forms.Button cmdnuevo;
        private System.Windows.Forms.Button cmdmodific;
        private System.Windows.Forms.Button cmdcerrar;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cmdeliminar;
        private bdinventarioDataSetAlmacen bdinventarioDataSetAlmacen;
        private System.Windows.Forms.BindingSource almacenesBindingSource;
        private bdinventarioDataSetAlmacenTableAdapters.almacenesTableAdapter almacenesTableAdapter;
        private System.Windows.Forms.ComboBox cmbalmacen;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlmacenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAlmacenDataGridViewTextBoxColumn;
    }
}