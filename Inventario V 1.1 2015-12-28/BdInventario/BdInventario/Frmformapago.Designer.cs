namespace BdInventario
{
    partial class Frmformapago
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbformapago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdeliminar = new System.Windows.Forms.Button();
            this.txtidformapago = new System.Windows.Forms.TextBox();
            this.txtformapago = new System.Windows.Forms.TextBox();
            this.cmdgrabar = new System.Windows.Forms.Button();
            this.cmdnuevo = new System.Windows.Forms.Button();
            this.cmdmodific = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdcerrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idFormPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Forma_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formapagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdinventarioDataSetFormapago = new BdInventario.bdinventarioDataSetFormapago();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.forma_pagoTableAdapter = new BdInventario.bdinventarioDataSetFormapagoTableAdapters.forma_pagoTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formapagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetFormapago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 76);
            this.groupBox1.Size = new System.Drawing.Size(694, 309);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Size = new System.Drawing.Size(630, 62);
            this.label1.Text = "CONTROL FORMA DE PAGO";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(101, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descripción.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cmbformapago);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmdeliminar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtidformapago);
            this.groupBox3.Controls.Add(this.txtformapago);
            this.groupBox3.Controls.Add(this.cmdgrabar);
            this.groupBox3.Controls.Add(this.cmdnuevo);
            this.groupBox3.Controls.Add(this.cmdmodific);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(2, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(686, 82);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // cmbformapago
            // 
            this.cmbformapago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbformapago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbformapago.FormattingEnabled = true;
            this.cmbformapago.Location = new System.Drawing.Point(104, 15);
            this.cmbformapago.Name = "cmbformapago";
            this.cmbformapago.Size = new System.Drawing.Size(299, 28);
            this.cmbformapago.TabIndex = 19;
            this.cmbformapago.SelectedIndexChanged += new System.EventHandler(this.cmbformapago_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Seleccione.:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdeliminar
            // 
            this.cmdeliminar.Location = new System.Drawing.Point(589, 47);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(92, 31);
            this.cmdeliminar.TabIndex = 17;
            this.cmdeliminar.Text = "&Eliminar";
            this.cmdeliminar.UseVisualStyleBackColor = true;
            this.cmdeliminar.Click += new System.EventHandler(this.cmdeliminar_Click);
            // 
            // txtidformapago
            // 
            this.txtidformapago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidformapago.Location = new System.Drawing.Point(43, 47);
            this.txtidformapago.Multiline = true;
            this.txtidformapago.Name = "txtidformapago";
            this.txtidformapago.Size = new System.Drawing.Size(59, 25);
            this.txtidformapago.TabIndex = 15;
            this.txtidformapago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtformapago
            // 
            this.txtformapago.BackColor = System.Drawing.Color.White;
            this.txtformapago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtformapago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtformapago.Location = new System.Drawing.Point(203, 47);
            this.txtformapago.Multiline = true;
            this.txtformapago.Name = "txtformapago";
            this.txtformapago.Size = new System.Drawing.Size(287, 25);
            this.txtformapago.TabIndex = 14;
            this.txtformapago.TextChanged += new System.EventHandler(this.txtformapago_TextChanged);
            // 
            // cmdgrabar
            // 
            this.cmdgrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdgrabar.Location = new System.Drawing.Point(589, 14);
            this.cmdgrabar.Name = "cmdgrabar";
            this.cmdgrabar.Size = new System.Drawing.Size(91, 32);
            this.cmdgrabar.TabIndex = 11;
            this.cmdgrabar.Text = "&Grabar";
            this.cmdgrabar.UseVisualStyleBackColor = false;
            this.cmdgrabar.Click += new System.EventHandler(this.cmdgrabar_Click);
            // 
            // cmdnuevo
            // 
            this.cmdnuevo.Location = new System.Drawing.Point(497, 14);
            this.cmdnuevo.Name = "cmdnuevo";
            this.cmdnuevo.Size = new System.Drawing.Size(91, 31);
            this.cmdnuevo.TabIndex = 10;
            this.cmdnuevo.Text = "&Nueva";
            this.cmdnuevo.UseVisualStyleBackColor = true;
            this.cmdnuevo.Click += new System.EventHandler(this.cmdnuevo_Click);
            // 
            // cmdmodific
            // 
            this.cmdmodific.Location = new System.Drawing.Point(496, 46);
            this.cmdmodific.Name = "cmdmodific";
            this.cmdmodific.Size = new System.Drawing.Size(92, 32);
            this.cmdmodific.TabIndex = 12;
            this.cmdmodific.Text = "&Actualizar";
            this.cmdmodific.UseVisualStyleBackColor = true;
            this.cmdmodific.Click += new System.EventHandler(this.cmdmodific_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID.:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdcerrar
            // 
            this.cmdcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdcerrar.ForeColor = System.Drawing.Color.Red;
            this.cmdcerrar.Image = global::BdInventario.Properties.Resources.anterior;
            this.cmdcerrar.Location = new System.Drawing.Point(636, 9);
            this.cmdcerrar.Name = "cmdcerrar";
            this.cmdcerrar.Size = new System.Drawing.Size(65, 62);
            this.cmdcerrar.TabIndex = 13;
            this.toolTip1.SetToolTip(this.cmdcerrar, "Atras");
            this.cmdcerrar.UseVisualStyleBackColor = true;
            this.cmdcerrar.Click += new System.EventHandler(this.cmdcerrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-2, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Lista forma de pago";
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
            this.idFormPagoDataGridViewTextBoxColumn,
            this.Nombre_Forma_Pago});
            this.dataGridView1.DataSource = this.formapagoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(516, 194);
            this.dataGridView1.TabIndex = 31;
            // 
            // idFormPagoDataGridViewTextBoxColumn
            // 
            this.idFormPagoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idFormPagoDataGridViewTextBoxColumn.DataPropertyName = "IdFormPago";
            this.idFormPagoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idFormPagoDataGridViewTextBoxColumn.Name = "idFormPagoDataGridViewTextBoxColumn";
            this.idFormPagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFormPagoDataGridViewTextBoxColumn.Width = 51;
            // 
            // Nombre_Forma_Pago
            // 
            this.Nombre_Forma_Pago.DataPropertyName = "Nombre_Forma_Pago";
            this.Nombre_Forma_Pago.HeaderText = "Descripción";
            this.Nombre_Forma_Pago.Name = "Nombre_Forma_Pago";
            this.Nombre_Forma_Pago.ReadOnly = true;
            this.Nombre_Forma_Pago.Width = 423;
            // 
            // formapagoBindingSource
            // 
            this.formapagoBindingSource.DataMember = "forma_pago";
            this.formapagoBindingSource.DataSource = this.bdinventarioDataSetFormapago;
            // 
            // bdinventarioDataSetFormapago
            // 
            this.bdinventarioDataSetFormapago.DataSetName = "bdinventarioDataSetFormapago";
            this.bdinventarioDataSetFormapago.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BdInventario.Properties.Resources.Forma_pago;
            this.pictureBox1.Location = new System.Drawing.Point(524, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // forma_pagoTableAdapter
            // 
            this.forma_pagoTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frmformapago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 392);
            this.Controls.Add(this.cmdcerrar);
            this.Name = "Frmformapago";
            this.Text = "Control de forma de pago";
            this.Load += new System.EventHandler(this.Frmformapago_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cmdcerrar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formapagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetFormapago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidformapago;
        private System.Windows.Forms.TextBox txtformapago;
        private System.Windows.Forms.Button cmdgrabar;
        private System.Windows.Forms.Button cmdnuevo;
        private System.Windows.Forms.Button cmdmodific;
        private System.Windows.Forms.Button cmdcerrar;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdeliminar;
        private bdinventarioDataSetFormapago bdinventarioDataSetFormapago;
        private System.Windows.Forms.BindingSource formapagoBindingSource;
        private bdinventarioDataSetFormapagoTableAdapters.forma_pagoTableAdapter forma_pagoTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbformapago;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFormPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Forma_Pago;
    }
}