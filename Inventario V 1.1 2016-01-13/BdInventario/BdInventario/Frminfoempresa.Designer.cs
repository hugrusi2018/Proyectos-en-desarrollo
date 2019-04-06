namespace BdInventario
{
    partial class Frminfoempresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frminfoempresa));
            this.txtidempresa = new System.Windows.Forms.TextBox();
            this.txtrazonsoc = new System.Windows.Forms.TextBox();
            this.cmdgrabar = new System.Windows.Forms.Button();
            this.cmdmodific = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdeliminar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbregimen = new System.Windows.Forms.ComboBox();
            this.cmbciudad = new System.Windows.Forms.ComboBox();
            this.txtobservacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdimagen = new System.Windows.Forms.Button();
            this.cmdlogo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cdmsalir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ptrimagen = new System.Windows.Forms.PictureBox();
            this.ptrlogo = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrimagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptrimagen);
            this.groupBox1.Controls.Add(this.ptrlogo);
            this.groupBox1.Controls.Add(this.cmdeliminar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmdimagen);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmdgrabar);
            this.groupBox1.Controls.Add(this.cmdlogo);
            this.groupBox1.Controls.Add(this.cmdmodific);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(6, 76);
            this.groupBox1.Size = new System.Drawing.Size(944, 322);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(879, 62);
            this.label1.Text = "INFORMACIÓN DE LA EMPRESA";
            // 
            // txtidempresa
            // 
            this.txtidempresa.BackColor = System.Drawing.Color.White;
            this.txtidempresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidempresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtidempresa.Location = new System.Drawing.Point(119, 20);
            this.txtidempresa.Multiline = true;
            this.txtidempresa.Name = "txtidempresa";
            this.txtidempresa.Size = new System.Drawing.Size(167, 25);
            this.txtidempresa.TabIndex = 16;
            this.txtidempresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtrazonsoc
            // 
            this.txtrazonsoc.BackColor = System.Drawing.Color.White;
            this.txtrazonsoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrazonsoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtrazonsoc.Location = new System.Drawing.Point(119, 44);
            this.txtrazonsoc.Multiline = true;
            this.txtrazonsoc.Name = "txtrazonsoc";
            this.txtrazonsoc.Size = new System.Drawing.Size(350, 25);
            this.txtrazonsoc.TabIndex = 15;
            // 
            // cmdgrabar
            // 
            this.cmdgrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdgrabar.Location = new System.Drawing.Point(844, 13);
            this.cmdgrabar.Name = "cmdgrabar";
            this.cmdgrabar.Size = new System.Drawing.Size(91, 32);
            this.cmdgrabar.TabIndex = 11;
            this.cmdgrabar.Text = "&Grabar";
            this.cmdgrabar.UseVisualStyleBackColor = false;
            this.cmdgrabar.Click += new System.EventHandler(this.cmdgrabar_Click);
            // 
            // cmdmodific
            // 
            this.cmdmodific.Location = new System.Drawing.Point(752, 13);
            this.cmdmodific.Name = "cmdmodific";
            this.cmdmodific.Size = new System.Drawing.Size(92, 32);
            this.cmdmodific.TabIndex = 12;
            this.cmdmodific.Text = "&Actualizar";
            this.cmdmodific.UseVisualStyleBackColor = true;
            this.cmdmodific.Click += new System.EventHandler(this.cmdmodific_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "IdEmpresa.:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdeliminar
            // 
            this.cmdeliminar.Location = new System.Drawing.Point(787, 51);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(92, 31);
            this.cmdeliminar.TabIndex = 17;
            this.cmdeliminar.Text = "&Eliminar";
            this.cmdeliminar.UseVisualStyleBackColor = true;
            this.cmdeliminar.Click += new System.EventHandler(this.cmdeliminar_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(6, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Razón Social.:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cmbregimen);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cmbciudad);
            this.groupBox3.Controls.Add(this.txtidempresa);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtobservacion);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtelefono);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtdireccion);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtrazonsoc);
            this.groupBox3.Location = new System.Drawing.Point(6, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 286);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(6, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Observación.:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(6, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 28);
            this.label10.TabIndex = 22;
            this.label10.Text = "Régimen.:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbregimen
            // 
            this.cmbregimen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbregimen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbregimen.FormattingEnabled = true;
            this.cmbregimen.Location = new System.Drawing.Point(91, 144);
            this.cmbregimen.Name = "cmbregimen";
            this.cmbregimen.Size = new System.Drawing.Size(256, 28);
            this.cmbregimen.TabIndex = 27;
            // 
            // cmbciudad
            // 
            this.cmbciudad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbciudad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbciudad.FormattingEnabled = true;
            this.cmbciudad.Location = new System.Drawing.Point(76, 68);
            this.cmbciudad.Name = "cmbciudad";
            this.cmbciudad.Size = new System.Drawing.Size(254, 28);
            this.cmbciudad.TabIndex = 26;
            // 
            // txtobservacion
            // 
            this.txtobservacion.BackColor = System.Drawing.Color.White;
            this.txtobservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtobservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtobservacion.Location = new System.Drawing.Point(6, 195);
            this.txtobservacion.Multiline = true;
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.Size = new System.Drawing.Size(463, 85);
            this.txtobservacion.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Teléfono.:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtelefono
            // 
            this.txtelefono.BackColor = System.Drawing.Color.White;
            this.txtelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtelefono.Location = new System.Drawing.Point(91, 120);
            this.txtelefono.Multiline = true;
            this.txtelefono.Name = "txtelefono";
            this.txtelefono.Size = new System.Drawing.Size(195, 25);
            this.txtelefono.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Dirección.:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.White;
            this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdireccion.Location = new System.Drawing.Point(91, 96);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(378, 25);
            this.txtdireccion.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ciudad.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdimagen
            // 
            this.cmdimagen.Location = new System.Drawing.Point(488, 223);
            this.cmdimagen.Name = "cmdimagen";
            this.cmdimagen.Size = new System.Drawing.Size(91, 31);
            this.cmdimagen.TabIndex = 32;
            this.cmdimagen.Text = "&Buscar";
            this.cmdimagen.UseVisualStyleBackColor = true;
            this.cmdimagen.Click += new System.EventHandler(this.cmdimagen_Click);
            // 
            // cmdlogo
            // 
            this.cmdlogo.Location = new System.Drawing.Point(488, 88);
            this.cmdlogo.Name = "cmdlogo";
            this.cmdlogo.Size = new System.Drawing.Size(91, 31);
            this.cmdlogo.TabIndex = 34;
            this.cmdlogo.Text = "&Buscar";
            this.cmdlogo.UseVisualStyleBackColor = true;
            this.cmdlogo.Click += new System.EventHandler(this.cmdlogo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(516, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Imagen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(534, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Logo";
            // 
            // cdmsalir
            // 
            this.cdmsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cdmsalir.ForeColor = System.Drawing.Color.Red;
            this.cdmsalir.Image = global::BdInventario.Properties.Resources.anterior;
            this.cdmsalir.Location = new System.Drawing.Point(885, 8);
            this.cdmsalir.Name = "cdmsalir";
            this.cdmsalir.Size = new System.Drawing.Size(65, 62);
            this.cdmsalir.TabIndex = 13;
            this.toolTip1.SetToolTip(this.cdmsalir, "Atras");
            this.cdmsalir.UseVisualStyleBackColor = true;
            this.cdmsalir.Click += new System.EventHandler(this.cdmsalir_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ptrimagen
            // 
            this.ptrimagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ptrimagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptrimagen.Location = new System.Drawing.Point(585, 165);
            this.ptrimagen.Name = "ptrimagen";
            this.ptrimagen.Size = new System.Drawing.Size(161, 126);
            this.ptrimagen.TabIndex = 38;
            this.ptrimagen.TabStop = false;
            // 
            // ptrlogo
            // 
            this.ptrlogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ptrlogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptrlogo.Location = new System.Drawing.Point(585, 25);
            this.ptrlogo.Name = "ptrlogo";
            this.ptrlogo.Size = new System.Drawing.Size(161, 126);
            this.ptrlogo.TabIndex = 37;
            this.ptrlogo.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Frminfoempresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 405);
            this.ControlBox = true;
            this.Controls.Add(this.cdmsalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frminfoempresa";
            this.Text = "Información de la empresa";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cdmsalir, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrimagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrlogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtrazonsoc;
        private System.Windows.Forms.TextBox txtidempresa;
        private System.Windows.Forms.Button cmdgrabar;
        private System.Windows.Forms.Button cmdmodific;
        private System.Windows.Forms.Button cdmsalir;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtobservacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdeliminar;
        private System.Windows.Forms.Button cmdlogo;
        private System.Windows.Forms.Button cmdimagen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbregimen;
        private System.Windows.Forms.ComboBox cmbciudad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ptrimagen;
        private System.Windows.Forms.PictureBox ptrlogo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}