namespace BdInventario
{
    partial class Frmproductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmproductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdcerrar = new System.Windows.Forms.Button();
            this.txtreferencia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbalmacen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.cmdgrabar = new System.Windows.Forms.Button();
            this.cmdnuevo = new System.Windows.Forms.Button();
            this.cmdmodific = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdconsolidado = new System.Windows.Forms.Button();
            this.cmdkardex = new System.Windows.Forms.Button();
            this.cmdlistado = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txtidalmacen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbproveedor = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbimpuesto = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtobservacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmaxstock = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtminstock = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbproducto = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbsubgrupo = new System.Windows.Forms.ComboBox();
            this.cmbgrupo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbunidad = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblexistencia = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(6, 73);
            this.groupBox1.Size = new System.Drawing.Size(1361, 556);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Size = new System.Drawing.Size(1295, 62);
            this.label1.Text = "CONTROL DE PRODUCTOS - KARDEX";
            // 
            // cmdcerrar
            // 
            this.cmdcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdcerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdcerrar.BackgroundImage")));
            this.cmdcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcerrar.ForeColor = System.Drawing.Color.Red;
            this.cmdcerrar.Location = new System.Drawing.Point(1301, 9);
            this.cmdcerrar.Name = "cmdcerrar";
            this.cmdcerrar.Size = new System.Drawing.Size(65, 62);
            this.cmdcerrar.TabIndex = 14;
            this.cmdcerrar.UseVisualStyleBackColor = true;
            this.cmdcerrar.Click += new System.EventHandler(this.cmdcerrar_Click);
            // 
            // txtreferencia
            // 
            this.txtreferencia.BackColor = System.Drawing.Color.White;
            this.txtreferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtreferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtreferencia.Location = new System.Drawing.Point(113, 124);
            this.txtreferencia.Multiline = true;
            this.txtreferencia.Name = "txtreferencia";
            this.txtreferencia.Size = new System.Drawing.Size(990, 27);
            this.txtreferencia.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(6, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 27);
            this.label11.TabIndex = 33;
            this.label11.Text = "Ref. Fabrica.:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(9, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 28);
            this.label8.TabIndex = 26;
            this.label8.Text = "Existencia.:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbalmacen
            // 
            this.cmbalmacen.FormattingEnabled = true;
            this.cmbalmacen.Location = new System.Drawing.Point(90, 15);
            this.cmbalmacen.MaxDropDownItems = 4;
            this.cmbalmacen.Name = "cmbalmacen";
            this.cmbalmacen.Size = new System.Drawing.Size(231, 28);
            this.cmbalmacen.Sorted = true;
            this.cmbalmacen.TabIndex = 1;
            this.cmbalmacen.SelectedIndexChanged += new System.EventHandler(this.cmbalmacen_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(6, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 27);
            this.label7.TabIndex = 24;
            this.label7.Text = "Almacén.:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(321, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Producto.:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.White;
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigo.Location = new System.Drawing.Point(201, 45);
            this.txtcodigo.Multiline = true;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(120, 27);
            this.txtcodigo.TabIndex = 16;
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // cmdgrabar
            // 
            this.cmdgrabar.BackColor = System.Drawing.Color.Red;
            this.cmdgrabar.Location = new System.Drawing.Point(942, 12);
            this.cmdgrabar.Name = "cmdgrabar";
            this.cmdgrabar.Size = new System.Drawing.Size(91, 32);
            this.cmdgrabar.TabIndex = 11;
            this.cmdgrabar.Text = "&Grabar";
            this.cmdgrabar.UseVisualStyleBackColor = false;
            this.cmdgrabar.Click += new System.EventHandler(this.cmdgrabar_Click);
            // 
            // cmdnuevo
            // 
            this.cmdnuevo.Location = new System.Drawing.Point(851, 12);
            this.cmdnuevo.Name = "cmdnuevo";
            this.cmdnuevo.Size = new System.Drawing.Size(91, 32);
            this.cmdnuevo.TabIndex = 10;
            this.cmdnuevo.Text = "&Nuevo";
            this.cmdnuevo.UseVisualStyleBackColor = true;
            this.cmdnuevo.Click += new System.EventHandler(this.cmdnuevo_Click);
            // 
            // cmdmodific
            // 
            this.cmdmodific.Location = new System.Drawing.Point(1034, 12);
            this.cmdmodific.Name = "cmdmodific";
            this.cmdmodific.Size = new System.Drawing.Size(92, 31);
            this.cmdmodific.TabIndex = 12;
            this.cmdmodific.Text = "&Actualizar";
            this.cmdmodific.UseVisualStyleBackColor = true;
            this.cmdmodific.Click += new System.EventHandler(this.cmdmodific_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unidad.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cmdconsolidado);
            this.groupBox3.Controls.Add(this.txtreferencia);
            this.groupBox3.Controls.Add(this.cmdkardex);
            this.groupBox3.Controls.Add(this.cmdlistado);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.txtcosto);
            this.groupBox3.Controls.Add(this.txtidalmacen);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.cmbimpuesto);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtobservacion);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtmaxstock);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtminstock);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtproducto);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.cmbproducto);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbsubgrupo);
            this.groupBox3.Controls.Add(this.cmbgrupo);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtcodigo);
            this.groupBox3.Controls.Add(this.cmdgrabar);
            this.groupBox3.Controls.Add(this.cmdnuevo);
            this.groupBox3.Controls.Add(this.cmdmodific);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbunidad);
            this.groupBox3.Controls.Add(this.cmbalmacen);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(0, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1361, 237);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // cmdconsolidado
            // 
            this.cmdconsolidado.ForeColor = System.Drawing.Color.Blue;
            this.cmdconsolidado.Location = new System.Drawing.Point(1186, 195);
            this.cmdconsolidado.Name = "cmdconsolidado";
            this.cmdconsolidado.Size = new System.Drawing.Size(158, 36);
            this.cmdconsolidado.TabIndex = 66;
            this.cmdconsolidado.Text = "&Punto de Reorden";
            this.cmdconsolidado.UseVisualStyleBackColor = true;
            this.cmdconsolidado.Click += new System.EventHandler(this.cmdconsolidado_Click);
            // 
            // cmdkardex
            // 
            this.cmdkardex.ForeColor = System.Drawing.Color.Blue;
            this.cmdkardex.Location = new System.Drawing.Point(1026, 196);
            this.cmdkardex.Name = "cmdkardex";
            this.cmdkardex.Size = new System.Drawing.Size(146, 36);
            this.cmdkardex.TabIndex = 61;
            this.cmdkardex.Text = "&Ver Mvto Kardex";
            this.cmdkardex.UseVisualStyleBackColor = true;
            this.cmdkardex.Click += new System.EventHandler(this.cmdkardex_Click);
            // 
            // cmdlistado
            // 
            this.cmdlistado.ForeColor = System.Drawing.Color.Blue;
            this.cmdlistado.Location = new System.Drawing.Point(1137, 12);
            this.cmdlistado.Name = "cmdlistado";
            this.cmdlistado.Size = new System.Drawing.Size(207, 31);
            this.cmdlistado.TabIndex = 62;
            this.cmdlistado.Text = "&Listado Gral. de Productos";
            this.cmdlistado.UseVisualStyleBackColor = true;
            this.cmdlistado.Click += new System.EventHandler(this.cmdlistado_Click);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Location = new System.Drawing.Point(6, 98);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 27);
            this.label19.TabIndex = 64;
            this.label19.Text = "Costo.:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1168, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // txtcosto
            // 
            this.txtcosto.BackColor = System.Drawing.Color.White;
            this.txtcosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcosto.Location = new System.Drawing.Point(80, 98);
            this.txtcosto.Multiline = true;
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(147, 27);
            this.txtcosto.TabIndex = 65;
            this.txtcosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtidalmacen
            // 
            this.txtidalmacen.BackColor = System.Drawing.Color.White;
            this.txtidalmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidalmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidalmacen.Location = new System.Drawing.Point(80, 45);
            this.txtidalmacen.Multiline = true;
            this.txtidalmacen.Name = "txtidalmacen";
            this.txtidalmacen.Size = new System.Drawing.Size(50, 27);
            this.txtidalmacen.TabIndex = 63;
            this.txtidalmacen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(6, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 27);
            this.label4.TabIndex = 62;
            this.label4.Text = "IDAlma.:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbproveedor);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Location = new System.Drawing.Point(6, 180);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(516, 51);
            this.groupBox4.TabIndex = 61;
            this.groupBox4.TabStop = false;
            // 
            // cmbproveedor
            // 
            this.cmbproveedor.DisplayMember = "IdProducto";
            this.cmbproveedor.FormattingEnabled = true;
            this.cmbproveedor.Location = new System.Drawing.Point(97, 15);
            this.cmbproveedor.MaxDropDownItems = 4;
            this.cmbproveedor.Name = "cmbproveedor";
            this.cmbproveedor.Size = new System.Drawing.Size(413, 28);
            this.cmbproveedor.Sorted = true;
            this.cmbproveedor.TabIndex = 62;
            this.cmbproveedor.SelectedIndexChanged += new System.EventHandler(this.cmbproveedor_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(6, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 27);
            this.label18.TabIndex = 57;
            this.label18.Text = "Proveedor.:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbimpuesto
            // 
            this.cmbimpuesto.DisplayMember = "IdProducto";
            this.cmbimpuesto.FormattingEnabled = true;
            this.cmbimpuesto.ItemHeight = 20;
            this.cmbimpuesto.Location = new System.Drawing.Point(273, 98);
            this.cmbimpuesto.Name = "cmbimpuesto";
            this.cmbimpuesto.Size = new System.Drawing.Size(59, 28);
            this.cmbimpuesto.TabIndex = 59;
            this.cmbimpuesto.SelectedIndexChanged += new System.EventHandler(this.cmbimpuesto_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(226, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 27);
            this.label17.TabIndex = 58;
            this.label17.Text = "IVA.:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtobservacion
            // 
            this.txtobservacion.BackColor = System.Drawing.Color.White;
            this.txtobservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtobservacion.Location = new System.Drawing.Point(113, 150);
            this.txtobservacion.Multiline = true;
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.Size = new System.Drawing.Size(990, 27);
            this.txtobservacion.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(6, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 27);
            this.label6.TabIndex = 56;
            this.label6.Text = "Observación.:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtmaxstock
            // 
            this.txtmaxstock.BackColor = System.Drawing.Color.White;
            this.txtmaxstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmaxstock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmaxstock.Location = new System.Drawing.Point(1026, 71);
            this.txtmaxstock.Multiline = true;
            this.txtmaxstock.Name = "txtmaxstock";
            this.txtmaxstock.Size = new System.Drawing.Size(77, 27);
            this.txtmaxstock.TabIndex = 51;
            this.txtmaxstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(908, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 27);
            this.label14.TabIndex = 50;
            this.label14.Text = "Máximo Stock.:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtminstock
            // 
            this.txtminstock.BackColor = System.Drawing.Color.White;
            this.txtminstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtminstock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtminstock.Location = new System.Drawing.Point(832, 71);
            this.txtminstock.Multiline = true;
            this.txtminstock.Name = "txtminstock";
            this.txtminstock.Size = new System.Drawing.Size(77, 27);
            this.txtminstock.TabIndex = 49;
            this.txtminstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(717, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 27);
            this.label13.TabIndex = 48;
            this.label13.Text = "Mínimo Stock.:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtproducto
            // 
            this.txtproducto.BackColor = System.Drawing.Color.White;
            this.txtproducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtproducto.Location = new System.Drawing.Point(422, 45);
            this.txtproducto.Multiline = true;
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(681, 27);
            this.txtproducto.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(320, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 27);
            this.label12.TabIndex = 46;
            this.label12.Text = "Descripción.:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbproducto
            // 
            this.cmbproducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbproducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbproducto.FormattingEnabled = true;
            this.cmbproducto.Location = new System.Drawing.Point(406, 15);
            this.cmbproducto.MaxDropDownItems = 4;
            this.cmbproducto.Name = "cmbproducto";
            this.cmbproducto.Size = new System.Drawing.Size(427, 28);
            this.cmbproducto.Sorted = true;
            this.cmbproducto.TabIndex = 43;
            this.cmbproducto.SelectedIndexChanged += new System.EventHandler(this.cmbproducto_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(425, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 28);
            this.label10.TabIndex = 38;
            this.label10.Text = "Subgrupo.:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(156, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 28);
            this.label9.TabIndex = 36;
            this.label9.Text = "Grupo.:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbsubgrupo
            // 
            this.cmbsubgrupo.DisplayMember = "IdProducto";
            this.cmbsubgrupo.FormattingEnabled = true;
            this.cmbsubgrupo.Location = new System.Drawing.Point(515, 71);
            this.cmbsubgrupo.Name = "cmbsubgrupo";
            this.cmbsubgrupo.Size = new System.Drawing.Size(203, 28);
            this.cmbsubgrupo.TabIndex = 39;
            this.cmbsubgrupo.SelectedIndexChanged += new System.EventHandler(this.cmbsubgrupo_SelectedIndexChanged);
            // 
            // cmbgrupo
            // 
            this.cmbgrupo.DisplayMember = "IdProducto";
            this.cmbgrupo.FormattingEnabled = true;
            this.cmbgrupo.Location = new System.Drawing.Point(226, 71);
            this.cmbgrupo.Name = "cmbgrupo";
            this.cmbgrupo.Size = new System.Drawing.Size(199, 28);
            this.cmbgrupo.TabIndex = 37;
            this.cmbgrupo.SelectedIndexChanged += new System.EventHandler(this.cmbgrupo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(129, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo.:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbunidad
            // 
            this.cmbunidad.FormattingEnabled = true;
            this.cmbunidad.Location = new System.Drawing.Point(80, 71);
            this.cmbunidad.Name = "cmbunidad";
            this.cmbunidad.Size = new System.Drawing.Size(77, 28);
            this.cmbunidad.TabIndex = 42;
            this.cmbunidad.SelectedIndexChanged += new System.EventHandler(this.cmbunidad_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblexistencia);
            this.groupBox2.Controls.Add(this.lbltotal);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(528, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 51);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            // 
            // lblexistencia
            // 
            this.lblexistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblexistencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblexistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexistencia.Location = new System.Drawing.Point(100, 16);
            this.lblexistencia.Name = "lblexistencia";
            this.lblexistencia.Size = new System.Drawing.Size(79, 28);
            this.lblexistencia.TabIndex = 38;
            this.lblexistencia.Text = "0";
            this.lblexistencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltotal
            // 
            this.lbltotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(310, 16);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(126, 28);
            this.lbltotal.TabIndex = 37;
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(178, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 28);
            this.label15.TabIndex = 36;
            this.label15.Text = "Valor Existencia.:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Fecha,
            this.Nro_Documento,
            this.Documento,
            this.Transaccion,
            this.Nombre_Producto,
            this.Unidad,
            this.Cantidad,
            this.Valor_Unitario,
            this.Valor_Total});
            this.dataGridView1.Location = new System.Drawing.Point(0, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1360, 313);
            this.dataGridView1.TabIndex = 23;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "IdMvto";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 82;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 79;
            // 
            // Nro_Documento
            // 
            this.Nro_Documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Nro_Documento.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nro_Documento.HeaderText = "Nro. Doc";
            this.Nro_Documento.Name = "Nro_Documento";
            this.Nro_Documento.ReadOnly = true;
            this.Nro_Documento.Width = 96;
            // 
            // Documento
            // 
            this.Documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Documento.DefaultCellStyle = dataGridViewCellStyle3;
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 117;
            // 
            // Transaccion
            // 
            this.Transaccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Transaccion.DefaultCellStyle = dataGridViewCellStyle4;
            this.Transaccion.HeaderText = "Transacción";
            this.Transaccion.Name = "Transaccion";
            this.Transaccion.ReadOnly = true;
            this.Transaccion.Width = 120;
            // 
            // Nombre_Producto
            // 
            this.Nombre_Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.Nombre_Producto.DefaultCellStyle = dataGridViewCellStyle5;
            this.Nombre_Producto.HeaderText = "Descripción";
            this.Nombre_Producto.Name = "Nombre_Producto";
            this.Nombre_Producto.ReadOnly = true;
            this.Nombre_Producto.Width = 117;
            // 
            // Unidad
            // 
            this.Unidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Unidad.DefaultCellStyle = dataGridViewCellStyle6;
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            this.Unidad.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle7;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 98;
            // 
            // Valor_Unitario
            // 
            this.Valor_Unitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle8.NullValue = null;
            this.Valor_Unitario.DefaultCellStyle = dataGridViewCellStyle8;
            this.Valor_Unitario.HeaderText = "Valor Unitario";
            this.Valor_Unitario.Name = "Valor_Unitario";
            this.Valor_Unitario.ReadOnly = true;
            this.Valor_Unitario.Width = 130;
            // 
            // Valor_Total
            // 
            this.Valor_Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle9.NullValue = null;
            this.Valor_Total.DefaultCellStyle = dataGridViewCellStyle9;
            this.Valor_Total.HeaderText = "Valor Total";
            this.Valor_Total.Name = "Valor_Total";
            this.Valor_Total.ReadOnly = true;
            this.Valor_Total.Width = 110;
            // 
            // Frmproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 633);
            this.Controls.Add(this.cmdcerrar);
            this.Name = "Frmproductos";
            this.Text = "Control de productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmproductos_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cmdcerrar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdcerrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtreferencia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbalmacen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button cmdgrabar;
        private System.Windows.Forms.Button cmdnuevo;
        private System.Windows.Forms.Button cmdmodific;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbsubgrupo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbgrupo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbunidad;
        private System.Windows.Forms.ComboBox cmbproducto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtobservacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbimpuesto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdlistado;
        private System.Windows.Forms.Button cmdkardex;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbproveedor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtidalmacen;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
        private System.Windows.Forms.Button cmdconsolidado;
        public System.Windows.Forms.Label lblexistencia;
        public System.Windows.Forms.TextBox txtmaxstock;
        public System.Windows.Forms.TextBox txtminstock;
    }
}