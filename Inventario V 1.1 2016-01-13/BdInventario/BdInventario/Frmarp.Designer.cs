namespace BdInventario
{
    partial class Frmarp
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
            this.txtidarp = new System.Windows.Forms.TextBox();
            this.txtarp = new System.Windows.Forms.TextBox();
            this.cmdgrabar = new System.Windows.Forms.Button();
            this.cmdnuevo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.arpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdinventarioDataSetARP = new BdInventario.bdinventarioDataSetARP();
            this.cmdmodific = new System.Windows.Forms.Button();
            this.cdmsalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbarp = new System.Windows.Forms.ComboBox();
            this.cmdeliminar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.arpTableAdapter = new BdInventario.bdinventarioDataSetARPTableAdapters.arpTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.idARPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreARPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetARP)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdeliminar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.cmdmodific);
            this.groupBox1.Controls.Add(this.cmdgrabar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmdnuevo);
            this.groupBox1.Location = new System.Drawing.Point(6, 76);
            this.groupBox1.Size = new System.Drawing.Size(623, 340);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Size = new System.Drawing.Size(569, 62);
            this.label1.Text = "CONTROL RIESGOS LABORALES";
            // 
            // txtidarp
            // 
            this.txtidarp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidarp.Location = new System.Drawing.Point(51, 48);
            this.txtidarp.Multiline = true;
            this.txtidarp.Name = "txtidarp";
            this.txtidarp.Size = new System.Drawing.Size(53, 29);
            this.txtidarp.TabIndex = 16;
            this.txtidarp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            // 
            // txtarp
            // 
            this.txtarp.BackColor = System.Drawing.Color.White;
            this.txtarp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtarp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtarp.Location = new System.Drawing.Point(103, 72);
            this.txtarp.Multiline = true;
            this.txtarp.Name = "txtarp";
            this.txtarp.Size = new System.Drawing.Size(410, 28);
            this.txtarp.TabIndex = 15;
            
            // 
            // cmdgrabar
            // 
            this.cmdgrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdgrabar.BackgroundImage = global::BdInventario.Properties.Resources.Save;
            this.cmdgrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdgrabar.Location = new System.Drawing.Point(87, 273);
            this.cmdgrabar.Name = "cmdgrabar";
            this.cmdgrabar.Size = new System.Drawing.Size(61, 62);
            this.cmdgrabar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.cmdgrabar, "Guardar");
            this.cmdgrabar.UseVisualStyleBackColor = false;
            this.cmdgrabar.Click += new System.EventHandler(this.cmdgrabar_Click);
            // 
            // cmdnuevo
            // 
            this.cmdnuevo.BackColor = System.Drawing.Color.White;
            this.cmdnuevo.BackgroundImage = global::BdInventario.Properties.Resources.New;
            this.cmdnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdnuevo.Location = new System.Drawing.Point(7, 273);
            this.cmdnuevo.Name = "cmdnuevo";
            this.cmdnuevo.Size = new System.Drawing.Size(61, 62);
            this.cmdnuevo.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cmdnuevo, "Nueva");
            this.cmdnuevo.UseVisualStyleBackColor = false;
            this.cmdnuevo.Click += new System.EventHandler(this.cmdnuevo_Click);
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
            this.idARPDataGridViewTextBoxColumn,
            this.nombreARPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.arpBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(615, 130);
            this.dataGridView1.TabIndex = 24;
            
            // 
            // arpBindingSource
            // 
            this.arpBindingSource.DataMember = "arp";
            this.arpBindingSource.DataSource = this.bdinventarioDataSetARP;
            // 
            // bdinventarioDataSetARP
            // 
            this.bdinventarioDataSetARP.DataSetName = "bdinventarioDataSetARP";
            this.bdinventarioDataSetARP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmdmodific
            // 
            this.cmdmodific.BackColor = System.Drawing.Color.Aqua;
            this.cmdmodific.BackgroundImage = global::BdInventario.Properties.Resources.Editor;
            this.cmdmodific.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdmodific.Location = new System.Drawing.Point(166, 273);
            this.cmdmodific.Name = "cmdmodific";
            this.cmdmodific.Size = new System.Drawing.Size(61, 62);
            this.cmdmodific.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cmdmodific, "Actualizar");
            this.cmdmodific.UseVisualStyleBackColor = false;
            this.cmdmodific.Click += new System.EventHandler(this.cmdmodificar_Click);
            // 
            // cdmsalir
            // 
            this.cdmsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cdmsalir.BackgroundImage = global::BdInventario.Properties.Resources.Back;
            this.cdmsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cdmsalir.ForeColor = System.Drawing.Color.Red;
            this.cdmsalir.Location = new System.Drawing.Point(571, 8);
            this.cdmsalir.Name = "cdmsalir";
            this.cdmsalir.Size = new System.Drawing.Size(61, 62);
            this.cdmsalir.TabIndex = 13;
            this.toolTip1.SetToolTip(this.cdmsalir, "Atras");
            this.cdmsalir.UseVisualStyleBackColor = true;
            this.cdmsalir.Click += new System.EventHandler(this.cdmsalir_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(4, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID.:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtarp);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbarp);
            this.groupBox2.Controls.Add(this.txtidarp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 105);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(4, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Seleccione.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbarp
            // 
            this.cmbarp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbarp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbarp.FormattingEnabled = true;
            this.cmbarp.Location = new System.Drawing.Point(103, 14);
            this.cmbarp.Name = "cmbarp";
            this.cmbarp.Size = new System.Drawing.Size(410, 28);
            this.cmbarp.TabIndex = 18;
            this.cmbarp.SelectedIndexChanged += new System.EventHandler(this.cmbarp_SelectedIndexChanged);
            // 
            // cmdeliminar
            // 
            this.cmdeliminar.BackColor = System.Drawing.Color.White;
            this.cmdeliminar.BackgroundImage = global::BdInventario.Properties.Resources.Delete;
            this.cmdeliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdeliminar.Location = new System.Drawing.Point(247, 273);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(61, 62);
            this.cmdeliminar.TabIndex = 17;
            this.toolTip1.SetToolTip(this.cmdeliminar, "Eliminar");
            this.cmdeliminar.UseVisualStyleBackColor = false;
            this.cmdeliminar.Click += new System.EventHandler(this.cmdeliminar_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(4, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 28);
            this.label9.TabIndex = 2;
            this.label9.Text = "Descrpción.:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Lista ARL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BdInventario.Properties.Resources.ARP;
            this.pictureBox1.Location = new System.Drawing.Point(518, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            
            // 
            // arpTableAdapter
            // 
            this.arpTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // idARPDataGridViewTextBoxColumn
            // 
            this.idARPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idARPDataGridViewTextBoxColumn.DataPropertyName = "IdARP";
            this.idARPDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idARPDataGridViewTextBoxColumn.Name = "idARPDataGridViewTextBoxColumn";
            this.idARPDataGridViewTextBoxColumn.ReadOnly = true;
            this.idARPDataGridViewTextBoxColumn.Width = 51;
            // 
            // nombreARPDataGridViewTextBoxColumn
            // 
            this.nombreARPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreARPDataGridViewTextBoxColumn.DataPropertyName = "Nombre_ARP";
            this.nombreARPDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.nombreARPDataGridViewTextBoxColumn.Name = "nombreARPDataGridViewTextBoxColumn";
            this.nombreARPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Frmarp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 423);
            this.Controls.Add(this.cdmsalir);
            this.Name = "Frmarp";
            this.Text = "Control riesgo laboral";
            this.Load += new System.EventHandler(this.Frmarp_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cdmsalir, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetARP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtidarp;
        private System.Windows.Forms.TextBox txtarp;
        private System.Windows.Forms.Button cmdgrabar;
        private System.Windows.Forms.Button cmdnuevo;
        private System.Windows.Forms.Button cmdmodific;
        private System.Windows.Forms.Button cdmsalir;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdeliminar;
        private System.Windows.Forms.ToolTip toolTip1;
        private bdinventarioDataSetARP bdinventarioDataSetARP;
        private System.Windows.Forms.BindingSource arpBindingSource;
        private bdinventarioDataSetARPTableAdapters.arpTableAdapter arpTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbarp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idARPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreARPDataGridViewTextBoxColumn;
    }
}