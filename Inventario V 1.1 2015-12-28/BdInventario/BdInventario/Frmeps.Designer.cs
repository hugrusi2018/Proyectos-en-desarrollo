namespace BdInventario
{
    partial class Frmeps
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbeps = new System.Windows.Forms.ComboBox();
            this.cmdeliminar = new System.Windows.Forms.Button();
            this.txtideps = new System.Windows.Forms.TextBox();
            this.txteps = new System.Windows.Forms.TextBox();
            this.cmdgrabar = new System.Windows.Forms.Button();
            this.cmdnuevo = new System.Windows.Forms.Button();
            this.cmdmodific = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cdmsalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.epsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdinventarioDataSetEPS = new BdInventario.bdinventarioDataSetEPS();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.epsTableAdapter = new BdInventario.bdinventarioDataSetEPSTableAdapters.epsTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.idEPSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEPSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetEPS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 76);
            this.groupBox1.Size = new System.Drawing.Size(723, 309);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Size = new System.Drawing.Size(659, 62);
            this.label1.Text = "CONTROL DE ENTIDAD PROMOTORA DE SALUD (EPS)";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbeps);
            this.groupBox2.Controls.Add(this.cmdeliminar);
            this.groupBox2.Controls.Add(this.txtideps);
            this.groupBox2.Controls.Add(this.txteps);
            this.groupBox2.Controls.Add(this.cmdgrabar);
            this.groupBox2.Controls.Add(this.cmdnuevo);
            this.groupBox2.Controls.Add(this.cmdmodific);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(6, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 85);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Seleccione.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbeps
            // 
            this.cmbeps.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbeps.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbeps.FormattingEnabled = true;
            this.cmbeps.Location = new System.Drawing.Point(103, 18);
            this.cmbeps.Name = "cmbeps";
            this.cmbeps.Size = new System.Drawing.Size(363, 28);
            this.cmbeps.TabIndex = 19;
            this.cmbeps.SelectedIndexChanged += new System.EventHandler(this.cmbeps_SelectedIndexChanged);
            // 
            // cmdeliminar
            // 
            this.cmdeliminar.Location = new System.Drawing.Point(616, 46);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(92, 31);
            this.cmdeliminar.TabIndex = 17;
            this.cmdeliminar.Text = "&Eliminar";
            this.cmdeliminar.UseVisualStyleBackColor = true;
            this.cmdeliminar.Click += new System.EventHandler(this.cmdeliminar_Click);
            // 
            // txtideps
            // 
            this.txtideps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtideps.Location = new System.Drawing.Point(43, 50);
            this.txtideps.Multiline = true;
            this.txtideps.Name = "txtideps";
            this.txtideps.Size = new System.Drawing.Size(58, 25);
            this.txtideps.TabIndex = 16;
            this.txtideps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txteps
            // 
            this.txteps.BackColor = System.Drawing.Color.White;
            this.txteps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txteps.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txteps.Location = new System.Drawing.Point(201, 50);
            this.txteps.Multiline = true;
            this.txteps.Name = "txteps";
            this.txteps.Size = new System.Drawing.Size(318, 25);
            this.txteps.TabIndex = 15;
            // 
            // cmdgrabar
            // 
            this.cmdgrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdgrabar.Location = new System.Drawing.Point(617, 13);
            this.cmdgrabar.Name = "cmdgrabar";
            this.cmdgrabar.Size = new System.Drawing.Size(91, 32);
            this.cmdgrabar.TabIndex = 11;
            this.cmdgrabar.Text = "&Grabar";
            this.cmdgrabar.UseVisualStyleBackColor = false;
            this.cmdgrabar.Click += new System.EventHandler(this.cmdgrabar_Click);
            // 
            // cmdnuevo
            // 
            this.cmdnuevo.Location = new System.Drawing.Point(525, 13);
            this.cmdnuevo.Name = "cmdnuevo";
            this.cmdnuevo.Size = new System.Drawing.Size(91, 31);
            this.cmdnuevo.TabIndex = 10;
            this.cmdnuevo.Text = "&Nueva";
            this.cmdnuevo.UseVisualStyleBackColor = true;
            this.cmdnuevo.Click += new System.EventHandler(this.cmdnuevo_Click);
            // 
            // cmdmodific
            // 
            this.cmdmodific.Location = new System.Drawing.Point(525, 46);
            this.cmdmodific.Name = "cmdmodific";
            this.cmdmodific.Size = new System.Drawing.Size(91, 31);
            this.cmdmodific.TabIndex = 12;
            this.cmdmodific.Text = "&Actualizar";
            this.cmdmodific.UseVisualStyleBackColor = true;
            this.cmdmodific.Click += new System.EventHandler(this.cmdmodific_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID.:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(100, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Descripción.:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cdmsalir
            // 
            this.cdmsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cdmsalir.ForeColor = System.Drawing.Color.Red;
            this.cdmsalir.Image = global::BdInventario.Properties.Resources.anterior;
            this.cdmsalir.Location = new System.Drawing.Point(664, 9);
            this.cdmsalir.Name = "cdmsalir";
            this.cdmsalir.Size = new System.Drawing.Size(65, 62);
            this.cdmsalir.TabIndex = 13;
            this.cdmsalir.UseVisualStyleBackColor = true;
            this.cdmsalir.Click += new System.EventHandler(this.cdmsalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Lista eps";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BdInventario.Properties.Resources.EPS;
            this.pictureBox1.Location = new System.Drawing.Point(551, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
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
            this.idEPSDataGridViewTextBoxColumn,
            this.nombreEPSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.epsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(539, 197);
            this.dataGridView1.TabIndex = 21;
            // 
            // epsBindingSource
            // 
            this.epsBindingSource.DataMember = "eps";
            this.epsBindingSource.DataSource = this.bdinventarioDataSetEPS;
            // 
            // bdinventarioDataSetEPS
            // 
            this.bdinventarioDataSetEPS.DataSetName = "bdinventarioDataSetEPS";
            this.bdinventarioDataSetEPS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // epsTableAdapter
            // 
            this.epsTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // idEPSDataGridViewTextBoxColumn
            // 
            this.idEPSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idEPSDataGridViewTextBoxColumn.DataPropertyName = "IdEPS";
            this.idEPSDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idEPSDataGridViewTextBoxColumn.Name = "idEPSDataGridViewTextBoxColumn";
            this.idEPSDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEPSDataGridViewTextBoxColumn.Width = 51;
            // 
            // nombreEPSDataGridViewTextBoxColumn
            // 
            this.nombreEPSDataGridViewTextBoxColumn.DataPropertyName = "Nombre_EPS";
            this.nombreEPSDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.nombreEPSDataGridViewTextBoxColumn.Name = "nombreEPSDataGridViewTextBoxColumn";
            this.nombreEPSDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreEPSDataGridViewTextBoxColumn.Width = 445;
            // 
            // Frmeps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 392);
            this.Controls.Add(this.cdmsalir);
            this.Name = "Frmeps";
            this.Text = "Control de entidad promotora de salud";
            this.Load += new System.EventHandler(this.Frmeps_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cdmsalir, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetEPS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtideps;
        private System.Windows.Forms.TextBox txteps;
        private System.Windows.Forms.Button cmdgrabar;
        private System.Windows.Forms.Button cmdnuevo;
        private System.Windows.Forms.Button cmdmodific;
        private System.Windows.Forms.Button cdmsalir;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdeliminar;
        private System.Windows.Forms.ToolTip toolTip1;
        private bdinventarioDataSetEPS bdinventarioDataSetEPS;
        private System.Windows.Forms.BindingSource epsBindingSource;
        private bdinventarioDataSetEPSTableAdapters.epsTableAdapter epsTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbeps;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEPSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEPSDataGridViewTextBoxColumn;
    }
}