﻿namespace BdInventario
{
    partial class Frmgrupoempleados
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbgrupo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsigla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgrupo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidgrupo = new System.Windows.Forms.TextBox();
            this.cmdeliminar = new System.Windows.Forms.Button();
            this.cmdnuevo = new System.Windows.Forms.Button();
            this.cmdgrabar = new System.Windows.Forms.Button();
            this.cmdmodific = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grupoempleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdinventarioDataSetGrupoEmpl = new BdInventario.bdinventarioDataSetGrupoEmpl();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdcerrar = new System.Windows.Forms.Button();
            this.grupo_empleadosTableAdapter = new BdInventario.bdinventarioDataSetGrupoEmplTableAdapters.grupo_empleadosTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idGrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siglaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreGrupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoempleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetGrupoEmpl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmdeliminar);
            this.groupBox1.Controls.Add(this.cmdnuevo);
            this.groupBox1.Controls.Add(this.cmdmodific);
            this.groupBox1.Controls.Add(this.cmdgrabar);
            this.groupBox1.Location = new System.Drawing.Point(6, 76);
            this.groupBox1.Size = new System.Drawing.Size(570, 343);
           
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Size = new System.Drawing.Size(515, 62);
            this.label1.Text = "CONTROL GRUPO DE EMPLEADOS";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtgrupo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.cmbgrupo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtsigla);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtidgrupo);
            this.groupBox3.Location = new System.Drawing.Point(4, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 111);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // cmbgrupo
            // 
            this.cmbgrupo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbgrupo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbgrupo.FormattingEnabled = true;
            this.cmbgrupo.Location = new System.Drawing.Point(113, 14);
            this.cmbgrupo.Name = "cmbgrupo";
            this.cmbgrupo.Size = new System.Drawing.Size(304, 28);
            this.cmbgrupo.TabIndex = 17;
            this.cmbgrupo.SelectedIndexChanged += new System.EventHandler(this.cmbgrupo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Descripción.:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtsigla
            // 
            this.txtsigla.BackColor = System.Drawing.Color.White;
            this.txtsigla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsigla.Location = new System.Drawing.Point(152, 46);
            this.txtsigla.Multiline = true;
            this.txtsigla.Name = "txtsigla";
            this.txtsigla.Size = new System.Drawing.Size(66, 28);
            this.txtsigla.TabIndex = 14;
            this.txtsigla.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(99, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sigla.:";
            
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID.:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            
            // 
            // txtgrupo
            // 
            this.txtgrupo.BackColor = System.Drawing.Color.White;
            this.txtgrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgrupo.Location = new System.Drawing.Point(113, 73);
            this.txtgrupo.Multiline = true;
            this.txtgrupo.Name = "txtgrupo";
            this.txtgrupo.Size = new System.Drawing.Size(304, 28);
            this.txtgrupo.TabIndex = 1;
            
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            
            // 
            // txtidgrupo
            // 
            this.txtidgrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidgrupo.Location = new System.Drawing.Point(43, 46);
            this.txtidgrupo.Multiline = true;
            this.txtidgrupo.Name = "txtidgrupo";
            this.txtidgrupo.Size = new System.Drawing.Size(58, 28);
            this.txtidgrupo.TabIndex = 0;
            this.txtidgrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdeliminar
            // 
            this.cmdeliminar.BackColor = System.Drawing.Color.White;
            this.cmdeliminar.BackgroundImage = global::BdInventario.Properties.Resources.Delete;
            this.cmdeliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdeliminar.Location = new System.Drawing.Point(253, 276);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(61, 62);
            this.cmdeliminar.TabIndex = 13;
            this.toolTip1.SetToolTip(this.cmdeliminar, "Eliminar");
            this.cmdeliminar.UseVisualStyleBackColor = false;
            this.cmdeliminar.Click += new System.EventHandler(this.cmdeliminar_Click);
            // 
            // cmdnuevo
            // 
            this.cmdnuevo.BackColor = System.Drawing.Color.White;
            this.cmdnuevo.BackgroundImage = global::BdInventario.Properties.Resources.New;
            this.cmdnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdnuevo.Location = new System.Drawing.Point(10, 275);
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
            this.cmdgrabar.Location = new System.Drawing.Point(88, 275);
            this.cmdgrabar.Name = "cmdgrabar";
            this.cmdgrabar.Size = new System.Drawing.Size(61, 62);
            this.cmdgrabar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.cmdgrabar, "Guardar");
            this.cmdgrabar.UseVisualStyleBackColor = false;
            this.cmdgrabar.Click += new System.EventHandler(this.cmdgrabar_Click);
            // 
            // cmdmodific
            // 
            this.cmdmodific.BackColor = System.Drawing.Color.Cyan;
            this.cmdmodific.BackgroundImage = global::BdInventario.Properties.Resources.Editor;
            this.cmdmodific.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdmodific.Location = new System.Drawing.Point(170, 276);
            this.cmdmodific.Name = "cmdmodific";
            this.cmdmodific.Size = new System.Drawing.Size(61, 62);
            this.cmdmodific.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cmdmodific, "Actualizar");
            this.cmdmodific.UseVisualStyleBackColor = false;
            this.cmdmodific.Click += new System.EventHandler(this.cmdmodific_Click);
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
            this.idGrupoDataGridViewTextBoxColumn,
            this.siglaDataGridViewTextBoxColumn,
            this.nombreGrupoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.grupoempleadosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(554, 133);
            this.dataGridView1.TabIndex = 35;
            // 
            // grupoempleadosBindingSource
            // 
            this.grupoempleadosBindingSource.DataMember = "grupo_empleados";
            this.grupoempleadosBindingSource.DataSource = this.bdinventarioDataSetGrupoEmpl;
            // 
            // bdinventarioDataSetGrupoEmpl
            // 
            this.bdinventarioDataSetGrupoEmpl.DataSetName = "bdinventarioDataSetGrupoEmpl";
            this.bdinventarioDataSetGrupoEmpl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Lista Grupo Empleados";
            // 
            // cmdcerrar
            // 
            this.cmdcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdcerrar.BackgroundImage = global::BdInventario.Properties.Resources.Back;
            this.cmdcerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdcerrar.ForeColor = System.Drawing.Color.Red;
            this.cmdcerrar.Location = new System.Drawing.Point(518, 9);
            this.cmdcerrar.Name = "cmdcerrar";
            this.cmdcerrar.Size = new System.Drawing.Size(61, 62);
            this.cmdcerrar.TabIndex = 13;
            this.toolTip1.SetToolTip(this.cmdcerrar, "Atras");
            this.cmdcerrar.UseVisualStyleBackColor = true;
            this.cmdcerrar.Click += new System.EventHandler(this.cmdcerrar_Click);
            // 
            // grupo_empleadosTableAdapter
            // 
            this.grupo_empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BdInventario.Properties.Resources.grupo_empleados;
            this.pictureBox1.Location = new System.Drawing.Point(425, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // idGrupoDataGridViewTextBoxColumn
            // 
            this.idGrupoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idGrupoDataGridViewTextBoxColumn.DataPropertyName = "IdGrupo";
            this.idGrupoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idGrupoDataGridViewTextBoxColumn.Name = "idGrupoDataGridViewTextBoxColumn";
            this.idGrupoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idGrupoDataGridViewTextBoxColumn.Width = 51;
            // 
            // siglaDataGridViewTextBoxColumn
            // 
            this.siglaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.siglaDataGridViewTextBoxColumn.DataPropertyName = "Sigla";
            this.siglaDataGridViewTextBoxColumn.HeaderText = "Sigla";
            this.siglaDataGridViewTextBoxColumn.Name = "siglaDataGridViewTextBoxColumn";
            this.siglaDataGridViewTextBoxColumn.ReadOnly = true;
            this.siglaDataGridViewTextBoxColumn.Width = 69;
            // 
            // nombreGrupoDataGridViewTextBoxColumn
            // 
            this.nombreGrupoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreGrupoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Grupo";
            this.nombreGrupoDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.nombreGrupoDataGridViewTextBoxColumn.Name = "nombreGrupoDataGridViewTextBoxColumn";
            this.nombreGrupoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Frmgrupoempleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 426);
            this.Controls.Add(this.cmdcerrar);
            this.Name = "Frmgrupoempleados";
            this.Text = "Control de grupo de empleados";
            this.Load += new System.EventHandler(this.Frmgrupoempleados_Load_1);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cmdcerrar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoempleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetGrupoEmpl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdnuevo;
        private System.Windows.Forms.Button cmdgrabar;
        private System.Windows.Forms.Button cmdmodific;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgrupo;
        private System.Windows.Forms.Button cmdcerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidgrupo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdeliminar;
        private System.Windows.Forms.TextBox txtsigla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private bdinventarioDataSetGrupoEmpl bdinventarioDataSetGrupoEmpl;
        private System.Windows.Forms.BindingSource grupoempleadosBindingSource;
        private bdinventarioDataSetGrupoEmplTableAdapters.grupo_empleadosTableAdapter grupo_empleadosTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbgrupo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siglaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreGrupoDataGridViewTextBoxColumn;
    }
}