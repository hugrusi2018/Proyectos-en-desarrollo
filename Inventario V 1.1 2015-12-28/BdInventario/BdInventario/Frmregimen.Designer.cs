﻿namespace BdInventario
{
    partial class Frmregimen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmregimen));
            this.cmdnuevo = new System.Windows.Forms.Button();
            this.cmdgrabar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbregimen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdeliminar = new System.Windows.Forms.Button();
            this.cmdmodific = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtregimen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidregimen = new System.Windows.Forms.TextBox();
            this.cmdcerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idRegimenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreRegimenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regimenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdinventarioDataSetRegimen = new BdInventario.bdinventarioDataSetRegimen();
            this.label6 = new System.Windows.Forms.Label();
            this.regimenTableAdapter = new BdInventario.bdinventarioDataSetRegimenTableAdapters.regimenTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regimenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetRegimen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(6, 76);
            this.groupBox1.Size = new System.Drawing.Size(599, 309);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Size = new System.Drawing.Size(535, 62);
            this.label1.Text = "CONTROL DE RÉGIMEN";
            // 
            // cmdnuevo
            // 
            this.cmdnuevo.Location = new System.Drawing.Point(400, 12);
            this.cmdnuevo.Name = "cmdnuevo";
            this.cmdnuevo.Size = new System.Drawing.Size(92, 32);
            this.cmdnuevo.TabIndex = 10;
            this.cmdnuevo.Text = "&Nuevo";
            this.cmdnuevo.UseVisualStyleBackColor = true;
            this.cmdnuevo.Click += new System.EventHandler(this.cmdnuevo_Click);
            // 
            // cmdgrabar
            // 
            this.cmdgrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdgrabar.Location = new System.Drawing.Point(493, 12);
            this.cmdgrabar.Name = "cmdgrabar";
            this.cmdgrabar.Size = new System.Drawing.Size(91, 32);
            this.cmdgrabar.TabIndex = 11;
            this.cmdgrabar.Text = "&Grabar";
            this.cmdgrabar.UseVisualStyleBackColor = false;
            this.cmdgrabar.Click += new System.EventHandler(this.cmdgrabar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cmbregimen);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmdeliminar);
            this.groupBox3.Controls.Add(this.cmdnuevo);
            this.groupBox3.Controls.Add(this.cmdgrabar);
            this.groupBox3.Controls.Add(this.cmdmodific);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtregimen);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtidregimen);
            this.groupBox3.Location = new System.Drawing.Point(0, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(591, 77);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // cmbregimen
            // 
            this.cmbregimen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbregimen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbregimen.FormattingEnabled = true;
            this.cmbregimen.Location = new System.Drawing.Point(98, 16);
            this.cmbregimen.Name = "cmbregimen";
            this.cmbregimen.Size = new System.Drawing.Size(227, 28);
            this.cmbregimen.TabIndex = 15;
            this.cmbregimen.SelectedIndexChanged += new System.EventHandler(this.cmbregimen_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(0, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Seleccione.:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdeliminar
            // 
            this.cmdeliminar.Location = new System.Drawing.Point(493, 44);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(92, 31);
            this.cmdeliminar.TabIndex = 13;
            this.cmdeliminar.Text = "&Eliminar";
            this.cmdeliminar.UseVisualStyleBackColor = true;
            this.cmdeliminar.Click += new System.EventHandler(this.cmdeliminar_Click);
            // 
            // cmdmodific
            // 
            this.cmdmodific.Location = new System.Drawing.Point(400, 44);
            this.cmdmodific.Name = "cmdmodific";
            this.cmdmodific.Size = new System.Drawing.Size(92, 31);
            this.cmdmodific.TabIndex = 12;
            this.cmdmodific.Text = "&Actualizar";
            this.cmdmodific.UseVisualStyleBackColor = true;
            this.cmdmodific.Click += new System.EventHandler(this.cmdmodific_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(0, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID.:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtregimen
            // 
            this.txtregimen.BackColor = System.Drawing.Color.White;
            this.txtregimen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtregimen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtregimen.Location = new System.Drawing.Point(194, 48);
            this.txtregimen.Multiline = true;
            this.txtregimen.Name = "txtregimen";
            this.txtregimen.Size = new System.Drawing.Size(203, 25);
            this.txtregimen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(92, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtidregimen
            // 
            this.txtidregimen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidregimen.Location = new System.Drawing.Point(38, 48);
            this.txtidregimen.Multiline = true;
            this.txtidregimen.Name = "txtidregimen";
            this.txtidregimen.Size = new System.Drawing.Size(55, 25);
            this.txtidregimen.TabIndex = 0;
            this.txtidregimen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdcerrar
            // 
            this.cmdcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdcerrar.ForeColor = System.Drawing.Color.Red;
            this.cmdcerrar.Image = global::BdInventario.Properties.Resources.anterior;
            this.cmdcerrar.Location = new System.Drawing.Point(541, 9);
            this.cmdcerrar.Name = "cmdcerrar";
            this.cmdcerrar.Size = new System.Drawing.Size(65, 62);
            this.cmdcerrar.TabIndex = 13;
            this.toolTip1.SetToolTip(this.cmdcerrar, "Atras");
            this.cmdcerrar.UseVisualStyleBackColor = true;
            this.cmdcerrar.Click += new System.EventHandler(this.cmdcerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(427, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
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
            this.idRegimenDataGridViewTextBoxColumn,
            this.nombreRegimenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.regimenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(421, 188);
            this.dataGridView1.TabIndex = 27;
            // 
            // idRegimenDataGridViewTextBoxColumn
            // 
            this.idRegimenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idRegimenDataGridViewTextBoxColumn.DataPropertyName = "IdRegimen";
            this.idRegimenDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idRegimenDataGridViewTextBoxColumn.Name = "idRegimenDataGridViewTextBoxColumn";
            this.idRegimenDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRegimenDataGridViewTextBoxColumn.Width = 51;
            // 
            // nombreRegimenDataGridViewTextBoxColumn
            // 
            this.nombreRegimenDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Regimen";
            this.nombreRegimenDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.nombreRegimenDataGridViewTextBoxColumn.Name = "nombreRegimenDataGridViewTextBoxColumn";
            this.nombreRegimenDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreRegimenDataGridViewTextBoxColumn.Width = 330;
            // 
            // regimenBindingSource
            // 
            this.regimenBindingSource.DataMember = "regimen";
            this.regimenBindingSource.DataSource = this.bdinventarioDataSetRegimen;
            // 
            // bdinventarioDataSetRegimen
            // 
            this.bdinventarioDataSetRegimen.DataSetName = "bdinventarioDataSetRegimen";
            this.bdinventarioDataSetRegimen.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-4, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Lista Regimen";
            // 
            // regimenTableAdapter
            // 
            this.regimenTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frmregimen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 392);
            this.Controls.Add(this.cmdcerrar);
            this.Name = "Frmregimen";
            this.Text = "Control de régimen";
            this.Load += new System.EventHandler(this.Frmregimen_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cmdcerrar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regimenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetRegimen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdnuevo;
        private System.Windows.Forms.Button cmdgrabar;
        private System.Windows.Forms.Button cmdmodific;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtregimen;
        private System.Windows.Forms.Button cmdcerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidregimen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdeliminar;
        private bdinventarioDataSetRegimen bdinventarioDataSetRegimen;
        private System.Windows.Forms.BindingSource regimenBindingSource;
        private bdinventarioDataSetRegimenTableAdapters.regimenTableAdapter regimenTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbregimen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRegimenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRegimenDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;

    }
}