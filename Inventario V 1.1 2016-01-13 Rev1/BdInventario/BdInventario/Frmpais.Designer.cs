﻿namespace BdInventario
{
    partial class Frmpais
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
            this.cmbpais = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdeliminar = new System.Windows.Forms.Button();
            this.txtidpais = new System.Windows.Forms.TextBox();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.cmdgrabar = new System.Windows.Forms.Button();
            this.cmdnuevo = new System.Windows.Forms.Button();
            this.cmdmodific = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdcerrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdinventarioDataSetPais = new BdInventario.bdinventarioDataSetPais();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.paisesTableAdapter = new BdInventario.bdinventarioDataSetPaisTableAdapters.paisesTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.idPaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmdeliminar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.cmdnuevo);
            this.groupBox1.Controls.Add(this.cmdgrabar);
            this.groupBox1.Controls.Add(this.cmdmodific);
            this.groupBox1.Location = new System.Drawing.Point(6, 76);
            this.groupBox1.Size = new System.Drawing.Size(547, 359);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(483, 62);
            this.label1.Text = "CONTROL DE PAÍS";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(3, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Descripción.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cmbpais);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtidpais);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.txtpais);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(539, 116);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // cmbpais
            // 
            this.cmbpais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbpais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbpais.FormattingEnabled = true;
            this.cmbpais.Location = new System.Drawing.Point(107, 14);
            this.cmbpais.Name = "cmbpais";
            this.cmbpais.Size = new System.Drawing.Size(295, 28);
            this.cmbpais.TabIndex = 19;
            this.cmbpais.SelectedIndexChanged += new System.EventHandler(this.cmbpais_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 18;
            this.label4.Text = "Seleccione.:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdeliminar
            // 
            this.cmdeliminar.BackColor = System.Drawing.Color.White;
            this.cmdeliminar.BackgroundImage = global::BdInventario.Properties.Resources.Delete;
            this.cmdeliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdeliminar.Location = new System.Drawing.Point(243, 292);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(61, 62);
            this.cmdeliminar.TabIndex = 17;
            this.toolTip1.SetToolTip(this.cmdeliminar, "Eliminar");
            this.cmdeliminar.UseVisualStyleBackColor = false;
            this.cmdeliminar.Click += new System.EventHandler(this.cmdeliminar_Click);
            // 
            // txtidpais
            // 
            this.txtidpais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidpais.Location = new System.Drawing.Point(45, 51);
            this.txtidpais.Multiline = true;
            this.txtidpais.Name = "txtidpais";
            this.txtidpais.Size = new System.Drawing.Size(53, 29);
            this.txtidpais.TabIndex = 15;
            this.txtidpais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpais
            // 
            this.txtpais.BackColor = System.Drawing.Color.White;
            this.txtpais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpais.Location = new System.Drawing.Point(107, 79);
            this.txtpais.Multiline = true;
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(295, 28);
            this.txtpais.TabIndex = 14;
            // 
            // cmdgrabar
            // 
            this.cmdgrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdgrabar.BackgroundImage = global::BdInventario.Properties.Resources.Save;
            this.cmdgrabar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdgrabar.Location = new System.Drawing.Point(83, 291);
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
            this.cmdnuevo.Location = new System.Drawing.Point(6, 291);
            this.cmdnuevo.Name = "cmdnuevo";
            this.cmdnuevo.Size = new System.Drawing.Size(61, 62);
            this.cmdnuevo.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cmdnuevo, "Nuevo");
            this.cmdnuevo.UseVisualStyleBackColor = false;
            this.cmdnuevo.Click += new System.EventHandler(this.cmdnuevo_Click);
            // 
            // cmdmodific
            // 
            this.cmdmodific.BackColor = System.Drawing.Color.Cyan;
            this.cmdmodific.BackgroundImage = global::BdInventario.Properties.Resources.Editor;
            this.cmdmodific.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdmodific.Location = new System.Drawing.Point(161, 292);
            this.cmdmodific.Name = "cmdmodific";
            this.cmdmodific.Size = new System.Drawing.Size(61, 62);
            this.cmdmodific.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cmdmodific, "Actualizar");
            this.cmdmodific.UseVisualStyleBackColor = false;
            this.cmdmodific.Click += new System.EventHandler(this.cmdmodific_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID.:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdcerrar
            // 
            this.cmdcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdcerrar.BackgroundImage = global::BdInventario.Properties.Resources.Back;
            this.cmdcerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdcerrar.ForeColor = System.Drawing.Color.Red;
            this.cmdcerrar.Location = new System.Drawing.Point(489, 9);
            this.cmdcerrar.Name = "cmdcerrar";
            this.cmdcerrar.Size = new System.Drawing.Size(61, 62);
            this.cmdcerrar.TabIndex = 13;
            this.toolTip1.SetToolTip(this.cmdcerrar, "Atras");
            this.cmdcerrar.UseVisualStyleBackColor = true;
            this.cmdcerrar.Click += new System.EventHandler(this.cmdcerrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Lista Países";
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
            this.idPaisDataGridViewTextBoxColumn,
            this.nombrePaisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paisesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(533, 144);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // paisesBindingSource
            // 
            this.paisesBindingSource.DataMember = "paises";
            this.paisesBindingSource.DataSource = this.bdinventarioDataSetPais;
            // 
            // bdinventarioDataSetPais
            // 
            this.bdinventarioDataSetPais.DataSetName = "bdinventarioDataSetPais";
            this.bdinventarioDataSetPais.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BdInventario.Properties.Resources.pais;
            this.pictureBox1.Location = new System.Drawing.Point(409, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // paisesTableAdapter
            // 
            this.paisesTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // idPaisDataGridViewTextBoxColumn
            // 
            this.idPaisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idPaisDataGridViewTextBoxColumn.DataPropertyName = "IdPais";
            this.idPaisDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idPaisDataGridViewTextBoxColumn.Name = "idPaisDataGridViewTextBoxColumn";
            this.idPaisDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPaisDataGridViewTextBoxColumn.Width = 51;
            // 
            // nombrePaisDataGridViewTextBoxColumn
            // 
            this.nombrePaisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombrePaisDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Pais";
            this.nombrePaisDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.nombrePaisDataGridViewTextBoxColumn.Name = "nombrePaisDataGridViewTextBoxColumn";
            this.nombrePaisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Frmpais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 442);
            this.Controls.Add(this.cmdcerrar);
            this.Name = "Frmpais";
            this.Text = "Control país";
            this.Load += new System.EventHandler(this.Frmpais_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cmdcerrar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidpais;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.Button cmdgrabar;
        private System.Windows.Forms.Button cmdnuevo;
        private System.Windows.Forms.Button cmdmodific;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdeliminar;
        private System.Windows.Forms.ToolTip toolTip1;
        private bdinventarioDataSetPais bdinventarioDataSetPais;
        private System.Windows.Forms.BindingSource paisesBindingSource;
        private bdinventarioDataSetPaisTableAdapters.paisesTableAdapter paisesTableAdapter;
        private System.Windows.Forms.ComboBox cmbpais;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button cmdcerrar;
    }
}