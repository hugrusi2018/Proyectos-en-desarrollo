namespace BdInventario
{
    partial class Frmtiposangre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmtiposangre));
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdeliminar = new System.Windows.Forms.Button();
            this.cmbsangre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdnuevo = new System.Windows.Forms.Button();
            this.cmdgrabar = new System.Windows.Forms.Button();
            this.cmdmodific = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsangre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidsangre = new System.Windows.Forms.TextBox();
            this.cmdcerrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gruposanguineoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdinventarioDataSetGruposanguineo = new BdInventario.bdinventarioDataSetGruposanguineo();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grupo_sanguineoTableAdapter = new BdInventario.bdinventarioDataSetGruposanguineoTableAdapters.grupo_sanguineoTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.idSangreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreGrupoSanguineoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposanguineoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetGruposanguineo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdeliminar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.cmdmodific);
            this.groupBox1.Controls.Add(this.cmdgrabar);
            this.groupBox1.Controls.Add(this.cmdnuevo);
            this.groupBox1.Location = new System.Drawing.Point(6, 68);
            this.groupBox1.Size = new System.Drawing.Size(516, 351);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Size = new System.Drawing.Size(462, 62);
            this.label1.Text = "CONTROL TIPO DE SANGRE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Lista tipo de sangre";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cmbsangre);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtsangre);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtidsangre);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 93);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // cmdeliminar
            // 
            this.cmdeliminar.BackColor = System.Drawing.Color.White;
            this.cmdeliminar.BackgroundImage = global::BdInventario.Properties.Resources.Delete;
            this.cmdeliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdeliminar.Location = new System.Drawing.Point(243, 283);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(61, 62);
            this.cmdeliminar.TabIndex = 15;
            this.toolTip1.SetToolTip(this.cmdeliminar, "Eliminar");
            this.cmdeliminar.UseVisualStyleBackColor = false;
            this.cmdeliminar.Click += new System.EventHandler(this.cmdeliminar_Click);
            // 
            // cmbsangre
            // 
            this.cmbsangre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbsangre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbsangre.FormattingEnabled = true;
            this.cmbsangre.Location = new System.Drawing.Point(109, 16);
            this.cmbsangre.Name = "cmbsangre";
            this.cmbsangre.Size = new System.Drawing.Size(158, 28);
            this.cmbsangre.TabIndex = 14;
            this.cmbsangre.SelectedIndexChanged += new System.EventHandler(this.cmbsangre_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Seleccione.:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdnuevo
            // 
            this.cmdnuevo.BackColor = System.Drawing.Color.White;
            this.cmdnuevo.BackgroundImage = global::BdInventario.Properties.Resources.New;
            this.cmdnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdnuevo.Location = new System.Drawing.Point(12, 283);
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
            this.cmdgrabar.Location = new System.Drawing.Point(89, 283);
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
            this.cmdmodific.Location = new System.Drawing.Point(164, 283);
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
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID.:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtsangre
            // 
            this.txtsangre.BackColor = System.Drawing.Color.White;
            this.txtsangre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsangre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsangre.Location = new System.Drawing.Point(212, 49);
            this.txtsangre.Multiline = true;
            this.txtsangre.Name = "txtsangre";
            this.txtsangre.Size = new System.Drawing.Size(175, 28);
            this.txtsangre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(109, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtidsangre
            // 
            this.txtidsangre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidsangre.Location = new System.Drawing.Point(45, 49);
            this.txtidsangre.Multiline = true;
            this.txtidsangre.Name = "txtidsangre";
            this.txtidsangre.Size = new System.Drawing.Size(65, 28);
            this.txtidsangre.TabIndex = 0;
            this.txtidsangre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdcerrar
            // 
            this.cmdcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdcerrar.BackgroundImage = global::BdInventario.Properties.Resources.Back;
            this.cmdcerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdcerrar.ForeColor = System.Drawing.Color.Red;
            this.cmdcerrar.Location = new System.Drawing.Point(464, 3);
            this.cmdcerrar.Name = "cmdcerrar";
            this.cmdcerrar.Size = new System.Drawing.Size(61, 62);
            this.cmdcerrar.TabIndex = 13;
            this.toolTip1.SetToolTip(this.cmdcerrar, "Atras");
            this.cmdcerrar.UseVisualStyleBackColor = true;
            this.cmdcerrar.Click += new System.EventHandler(this.cmdcerrar_Click);
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
            this.idSangreDataGridViewTextBoxColumn,
            this.nombreGrupoSanguineoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gruposanguineoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(492, 155);
            this.dataGridView1.TabIndex = 19;
            // 
            // gruposanguineoBindingSource
            // 
            this.gruposanguineoBindingSource.DataMember = "grupo_sanguineo";
            this.gruposanguineoBindingSource.DataSource = this.bdinventarioDataSetGruposanguineo;
            // 
            // bdinventarioDataSetGruposanguineo
            // 
            this.bdinventarioDataSetGruposanguineo.DataSetName = "bdinventarioDataSetGruposanguineo";
            this.bdinventarioDataSetGruposanguineo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(395, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // grupo_sanguineoTableAdapter
            // 
            this.grupo_sanguineoTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // idSangreDataGridViewTextBoxColumn
            // 
            this.idSangreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idSangreDataGridViewTextBoxColumn.DataPropertyName = "IdSangre";
            this.idSangreDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idSangreDataGridViewTextBoxColumn.Name = "idSangreDataGridViewTextBoxColumn";
            this.idSangreDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSangreDataGridViewTextBoxColumn.Width = 51;
            // 
            // nombreGrupoSanguineoDataGridViewTextBoxColumn
            // 
            this.nombreGrupoSanguineoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreGrupoSanguineoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Grupo_Sanguineo";
            this.nombreGrupoSanguineoDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.nombreGrupoSanguineoDataGridViewTextBoxColumn.Name = "nombreGrupoSanguineoDataGridViewTextBoxColumn";
            this.nombreGrupoSanguineoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Frmtiposangre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 427);
            this.Controls.Add(this.cmdcerrar);
            this.Name = "Frmtiposangre";
            this.Text = "Control tipo sangre";
            this.Load += new System.EventHandler(this.Frmtiposangre_Load);
            this.Controls.SetChildIndex(this.cmdcerrar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposanguineoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdinventarioDataSetGruposanguineo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdnuevo;
        private System.Windows.Forms.Button cmdgrabar;
        private System.Windows.Forms.Button cmdmodific;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsangre;
        private System.Windows.Forms.Button cmdcerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidsangre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbsangre;
        private bdinventarioDataSetGruposanguineo bdinventarioDataSetGruposanguineo;
        private System.Windows.Forms.BindingSource gruposanguineoBindingSource;
        private bdinventarioDataSetGruposanguineoTableAdapters.grupo_sanguineoTableAdapter grupo_sanguineoTableAdapter;
        private System.Windows.Forms.Button cmdeliminar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSangreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreGrupoSanguineoDataGridViewTextBoxColumn;
    }
}