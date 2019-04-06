namespace BdInventario
{
    partial class Frmovimientoproducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmovimientoproducto));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtobservacion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtransac = new System.Windows.Forms.TextBox();
            this.txtdoc = new System.Windows.Forms.TextBox();
            this.lblcliente = new System.Windows.Forms.Label();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtidalmacen = new System.Windows.Forms.TextBox();
            this.txtidproveedor = new System.Windows.Forms.TextBox();
            this.txtidocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfactura = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblproveedor = new System.Windows.Forms.Label();
            this.cmdkardex = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbdocumento = new System.Windows.Forms.ComboBox();
            this.txtpedido = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbproducto = new System.Windows.Forms.ComboBox();
            this.cmbalmacen = new System.Windows.Forms.ComboBox();
            this.cmdgrabar = new System.Windows.Forms.Button();
            this.cmdnuevo = new System.Windows.Forms.Button();
            this.cmdmodific = new System.Windows.Forms.Button();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbproveedor = new System.Windows.Forms.ComboBox();
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.txtotal = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.Dtmvtoproducto = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PtoMinStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PtoMaxStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdcerrar = new System.Windows.Forms.Button();
            this.cmbdocum = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblseleccione = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtidmvto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtmvtoproducto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtidmvto);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbdocum);
            this.groupBox1.Controls.Add(this.lblseleccione);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.Dtmvtoproducto);
            this.groupBox1.Controls.Add(this.lbltotal);
            this.groupBox1.Controls.Add(this.txtotal);
            this.groupBox1.Location = new System.Drawing.Point(6, 76);
            this.groupBox1.Size = new System.Drawing.Size(1360, 552);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(1360, 61);
            this.label1.Text = "MOVIMIENTOS DE ALMACÉN";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtobservacion);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtransac);
            this.groupBox3.Controls.Add(this.txtdoc);
            this.groupBox3.Controls.Add(this.lblcliente);
            this.groupBox3.Controls.Add(this.txtidcliente);
            this.groupBox3.Controls.Add(this.txtidalmacen);
            this.groupBox3.Controls.Add(this.txtidproveedor);
            this.groupBox3.Controls.Add(this.txtidocumento);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtfactura);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.lblproveedor);
            this.groupBox3.Controls.Add(this.cmdkardex);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmbdocumento);
            this.groupBox3.Controls.Add(this.txtpedido);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cmbproducto);
            this.groupBox3.Controls.Add(this.cmbalmacen);
            this.groupBox3.Controls.Add(this.cmdgrabar);
            this.groupBox3.Controls.Add(this.cmdnuevo);
            this.groupBox3.Controls.Add(this.cmdmodific);
            this.groupBox3.Controls.Add(this.txtfecha);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbproveedor);
            this.groupBox3.Controls.Add(this.cmbcliente);
            this.groupBox3.Location = new System.Drawing.Point(6, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1348, 131);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // txtobservacion
            // 
            this.txtobservacion.BackColor = System.Drawing.Color.White;
            this.txtobservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtobservacion.Location = new System.Drawing.Point(111, 97);
            this.txtobservacion.Multiline = true;
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.Size = new System.Drawing.Size(845, 27);
            this.txtobservacion.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(6, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 27);
            this.label12.TabIndex = 49;
            this.label12.Text = "Observación.:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtransac
            // 
            this.txtransac.BackColor = System.Drawing.Color.White;
            this.txtransac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtransac.Location = new System.Drawing.Point(281, 44);
            this.txtransac.Multiline = true;
            this.txtransac.Name = "txtransac";
            this.txtransac.ReadOnly = true;
            this.txtransac.Size = new System.Drawing.Size(98, 27);
            this.txtransac.TabIndex = 23;
            this.txtransac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtransac.TextChanged += new System.EventHandler(this.txtransac_TextChanged);
            // 
            // txtdoc
            // 
            this.txtdoc.BackColor = System.Drawing.Color.White;
            this.txtdoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdoc.Location = new System.Drawing.Point(87, 44);
            this.txtdoc.Multiline = true;
            this.txtdoc.Name = "txtdoc";
            this.txtdoc.ReadOnly = true;
            this.txtdoc.Size = new System.Drawing.Size(91, 27);
            this.txtdoc.TabIndex = 15;
            this.txtdoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblcliente
            // 
            this.lblcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcliente.Location = new System.Drawing.Point(6, 70);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(82, 28);
            this.lblcliente.TabIndex = 57;
            this.lblcliente.Text = "Cliente.:";
            this.lblcliente.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtidcliente
            // 
            this.txtidcliente.BackColor = System.Drawing.Color.White;
            this.txtidcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidcliente.Location = new System.Drawing.Point(416, 70);
            this.txtidcliente.Multiline = true;
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(118, 28);
            this.txtidcliente.TabIndex = 56;
            this.txtidcliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtidalmacen
            // 
            this.txtidalmacen.BackColor = System.Drawing.Color.White;
            this.txtidalmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidalmacen.Location = new System.Drawing.Point(918, 16);
            this.txtidalmacen.Multiline = true;
            this.txtidalmacen.Name = "txtidalmacen";
            this.txtidalmacen.ReadOnly = true;
            this.txtidalmacen.Size = new System.Drawing.Size(38, 28);
            this.txtidalmacen.TabIndex = 18;
            this.txtidalmacen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtidproveedor
            // 
            this.txtidproveedor.BackColor = System.Drawing.Color.White;
            this.txtidproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidproveedor.Location = new System.Drawing.Point(416, 70);
            this.txtidproveedor.Multiline = true;
            this.txtidproveedor.Name = "txtidproveedor";
            this.txtidproveedor.Size = new System.Drawing.Size(118, 28);
            this.txtidproveedor.TabIndex = 50;
            this.txtidproveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtidocumento
            // 
            this.txtidocumento.BackColor = System.Drawing.Color.White;
            this.txtidocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidocumento.Location = new System.Drawing.Point(483, 16);
            this.txtidocumento.Multiline = true;
            this.txtidocumento.Name = "txtidocumento";
            this.txtidocumento.ReadOnly = true;
            this.txtidocumento.Size = new System.Drawing.Size(38, 29);
            this.txtidocumento.TabIndex = 55;
            this.txtidocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(177, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Documento.:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(533, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 28);
            this.label7.TabIndex = 24;
            this.label7.Text = "Producto.:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtfactura
            // 
            this.txtfactura.BackColor = System.Drawing.Color.White;
            this.txtfactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfactura.Location = new System.Drawing.Point(653, 44);
            this.txtfactura.Multiline = true;
            this.txtfactura.Name = "txtfactura";
            this.txtfactura.Size = new System.Drawing.Size(98, 27);
            this.txtfactura.TabIndex = 52;
            this.txtfactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(573, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 27);
            this.label13.TabIndex = 51;
            this.label13.Text = "Factura.:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblproveedor
            // 
            this.lblproveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblproveedor.Location = new System.Drawing.Point(6, 70);
            this.lblproveedor.Name = "lblproveedor";
            this.lblproveedor.Size = new System.Drawing.Size(91, 28);
            this.lblproveedor.TabIndex = 26;
            this.lblproveedor.Text = "Proveedor.:";
            this.lblproveedor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdkardex
            // 
            this.cmdkardex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdkardex.ForeColor = System.Drawing.Color.Blue;
            this.cmdkardex.Location = new System.Drawing.Point(1058, 52);
            this.cmdkardex.Name = "cmdkardex";
            this.cmdkardex.Size = new System.Drawing.Size(91, 40);
            this.cmdkardex.TabIndex = 48;
            this.cmdkardex.Text = "&Productos - Kardex";
            this.cmdkardex.UseVisualStyleBackColor = true;
            this.cmdkardex.Click += new System.EventHandler(this.cmdkardex_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(177, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 27);
            this.label6.TabIndex = 22;
            this.label6.Text = "Transaccion.:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(520, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Almacen.:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbdocumento
            // 
            this.cmbdocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbdocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbdocumento.BackColor = System.Drawing.Color.White;
            this.cmbdocumento.FormattingEnabled = true;
            this.cmbdocumento.Location = new System.Drawing.Point(281, 16);
            this.cmbdocumento.MaxDropDownItems = 4;
            this.cmbdocumento.Name = "cmbdocumento";
            this.cmbdocumento.Size = new System.Drawing.Size(203, 28);
            this.cmbdocumento.Sorted = true;
            this.cmbdocumento.TabIndex = 35;
            this.cmbdocumento.SelectedIndexChanged += new System.EventHandler(this.cmbdocumento_SelectedIndexChanged);
            // 
            // txtpedido
            // 
            this.txtpedido.BackColor = System.Drawing.Color.White;
            this.txtpedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpedido.Location = new System.Drawing.Point(483, 44);
            this.txtpedido.Multiline = true;
            this.txtpedido.Name = "txtpedido";
            this.txtpedido.Size = new System.Drawing.Size(91, 27);
            this.txtpedido.TabIndex = 34;
            this.txtpedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(378, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 27);
            this.label11.TabIndex = 33;
            this.label11.Text = "Nro. Pedido.:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbproducto
            // 
            this.cmbproducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbproducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbproducto.DisplayMember = "Nombre_Producto";
            this.cmbproducto.FormattingEnabled = true;
            this.cmbproducto.Location = new System.Drawing.Point(616, 70);
            this.cmbproducto.MaxDropDownItems = 4;
            this.cmbproducto.Name = "cmbproducto";
            this.cmbproducto.Size = new System.Drawing.Size(340, 28);
            this.cmbproducto.Sorted = true;
            this.cmbproducto.TabIndex = 25;
            this.cmbproducto.ValueMember = "Nombre_Producto";
            this.cmbproducto.SelectedIndexChanged += new System.EventHandler(this.cmbproducto_SelectedIndexChanged);
            // 
            // cmbalmacen
            // 
            this.cmbalmacen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbalmacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbalmacen.FormattingEnabled = true;
            this.cmbalmacen.Location = new System.Drawing.Point(607, 16);
            this.cmbalmacen.MaxDropDownItems = 4;
            this.cmbalmacen.Name = "cmbalmacen";
            this.cmbalmacen.Size = new System.Drawing.Size(312, 28);
            this.cmbalmacen.Sorted = true;
            this.cmbalmacen.TabIndex = 21;
            this.cmbalmacen.SelectedIndexChanged += new System.EventHandler(this.cmbalmacen_SelectedIndexChanged);
            this.cmbalmacen.TextChanged += new System.EventHandler(this.cmbalmac_TextChanged);
            // 
            // cmdgrabar
            // 
            this.cmdgrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmdgrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdgrabar.Location = new System.Drawing.Point(1058, 16);
            this.cmdgrabar.Name = "cmdgrabar";
            this.cmdgrabar.Size = new System.Drawing.Size(91, 32);
            this.cmdgrabar.TabIndex = 11;
            this.cmdgrabar.Text = "&Grabar";
            this.cmdgrabar.UseVisualStyleBackColor = false;
            this.cmdgrabar.Click += new System.EventHandler(this.cmdgrabar_Click);
            // 
            // cmdnuevo
            // 
            this.cmdnuevo.Location = new System.Drawing.Point(962, 16);
            this.cmdnuevo.Name = "cmdnuevo";
            this.cmdnuevo.Size = new System.Drawing.Size(95, 32);
            this.cmdnuevo.TabIndex = 10;
            this.cmdnuevo.Text = "&Nuevo Doc";
            this.cmdnuevo.UseVisualStyleBackColor = true;
            this.cmdnuevo.Click += new System.EventHandler(this.cmdnuevo_Click);
            // 
            // cmdmodific
            // 
            this.cmdmodific.Location = new System.Drawing.Point(1150, 16);
            this.cmdmodific.Name = "cmdmodific";
            this.cmdmodific.Size = new System.Drawing.Size(92, 31);
            this.cmdmodific.TabIndex = 12;
            this.cmdmodific.Text = "&Actualizar";
            this.cmdmodific.UseVisualStyleBackColor = true;
            this.cmdmodific.Click += new System.EventHandler(this.cmdmodific_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.BackColor = System.Drawing.Color.White;
            this.txtfecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfecha.Location = new System.Drawing.Point(69, 16);
            this.txtfecha.Multiline = true;
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.ReadOnly = true;
            this.txtfecha.Size = new System.Drawing.Size(109, 29);
            this.txtfecha.TabIndex = 5;
            this.txtfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha.:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nro. Doc.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbproveedor
            // 
            this.cmbproveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbproveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbproveedor.FormattingEnabled = true;
            this.cmbproveedor.Location = new System.Drawing.Point(94, 70);
            this.cmbproveedor.MaxDropDownItems = 4;
            this.cmbproveedor.Name = "cmbproveedor";
            this.cmbproveedor.Size = new System.Drawing.Size(323, 28);
            this.cmbproveedor.Sorted = true;
            this.cmbproveedor.TabIndex = 42;
            this.cmbproveedor.SelectedIndexChanged += new System.EventHandler(this.cmbproveedor_SelectedIndexChanged_1);
            // 
            // cmbcliente
            // 
            this.cmbcliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbcliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(87, 70);
            this.cmbcliente.MaxDropDownItems = 4;
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(330, 28);
            this.cmbcliente.Sorted = true;
            this.cmbcliente.TabIndex = 58;
            this.cmbcliente.SelectedIndexChanged += new System.EventHandler(this.cmbcliente_SelectedIndexChanged);
            // 
            // txtotal
            // 
            this.txtotal.BackColor = System.Drawing.Color.White;
            this.txtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtotal.Location = new System.Drawing.Point(164, 521);
            this.txtotal.Multiline = true;
            this.txtotal.Name = "txtotal";
            this.txtotal.Size = new System.Drawing.Size(182, 27);
            this.txtotal.TabIndex = 54;
            this.txtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbltotal
            // 
            this.lbltotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(6, 521);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(159, 27);
            this.lbltotal.TabIndex = 53;
            this.lbltotal.Text = "Total Documento.:";
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Dtmvtoproducto
            // 
            this.Dtmvtoproducto.AllowUserToAddRows = false;
            this.Dtmvtoproducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtmvtoproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtmvtoproducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Unidad,
            this.Cantidad,
            this.Valor,
            this.Valores,
            this.Existencia,
            this.PtoMinStock,
            this.PtoMaxStock});
            this.Dtmvtoproducto.Location = new System.Drawing.Point(6, 176);
            this.Dtmvtoproducto.Name = "Dtmvtoproducto";
            this.Dtmvtoproducto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dtmvtoproducto.Size = new System.Drawing.Size(1348, 342);
            this.Dtmvtoproducto.TabIndex = 19;
            this.Dtmvtoproducto.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Codigo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Producto.HeaderText = "Descripción";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Producto.Width = 117;
            // 
            // Unidad
            // 
            this.Unidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Unidad.HeaderText = "Unid";
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            this.Unidad.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cantidad.HeaderText = "Cant";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 68;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.Valor.HeaderText = "Valor Unitario";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 130;
            // 
            // Valores
            // 
            this.Valores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Valores.DefaultCellStyle = dataGridViewCellStyle4;
            this.Valores.HeaderText = "Valor Total";
            this.Valores.Name = "Valores";
            this.Valores.ReadOnly = true;
            this.Valores.Width = 110;
            // 
            // Existencia
            // 
            this.Existencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Existencia.DefaultCellStyle = dataGridViewCellStyle5;
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            this.Existencia.Width = 106;
            // 
            // PtoMinStock
            // 
            this.PtoMinStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.PtoMinStock.DefaultCellStyle = dataGridViewCellStyle6;
            this.PtoMinStock.HeaderText = "MinStock";
            this.PtoMinStock.Name = "PtoMinStock";
            // 
            // PtoMaxStock
            // 
            this.PtoMaxStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.PtoMaxStock.DefaultCellStyle = dataGridViewCellStyle7;
            this.PtoMaxStock.HeaderText = "MaxStock";
            this.PtoMaxStock.Name = "PtoMaxStock";
            this.PtoMaxStock.Width = 104;
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // cmdcerrar
            // 
            this.cmdcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdcerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdcerrar.BackgroundImage")));
            this.cmdcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcerrar.ForeColor = System.Drawing.Color.Red;
            this.cmdcerrar.Location = new System.Drawing.Point(1301, 9);
            this.cmdcerrar.Name = "cmdcerrar";
            this.cmdcerrar.Size = new System.Drawing.Size(65, 61);
            this.cmdcerrar.TabIndex = 13;
            this.toolTip1.SetToolTip(this.cmdcerrar, "Atras");
            this.cmdcerrar.UseVisualStyleBackColor = true;
            this.cmdcerrar.Click += new System.EventHandler(this.cmdcerrar_Click);
            // 
            // cmbdocum
            // 
            this.cmbdocum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbdocum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbdocum.DisplayMember = "Fecha";
            this.cmbdocum.FormattingEnabled = true;
            this.cmbdocum.Location = new System.Drawing.Point(1234, 16);
            this.cmbdocum.Name = "cmbdocum";
            this.cmbdocum.Size = new System.Drawing.Size(119, 28);
            this.cmbdocum.Sorted = true;
            this.cmbdocum.TabIndex = 1;
            this.cmbdocum.ValueMember = "Fecha";
            this.cmbdocum.SelectedIndexChanged += new System.EventHandler(this.cmbidmvto_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblseleccione
            // 
            this.lblseleccione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblseleccione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblseleccione.Location = new System.Drawing.Point(1136, 16);
            this.lblseleccione.Name = "lblseleccione";
            this.lblseleccione.Size = new System.Drawing.Size(98, 28);
            this.lblseleccione.TabIndex = 21;
            this.lblseleccione.Text = "Seleccione.:";
            this.lblseleccione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(7, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 29);
            this.label9.TabIndex = 51;
            this.label9.Text = "IDMvto.:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtidmvto
            // 
            this.txtidmvto.BackColor = System.Drawing.Color.White;
            this.txtidmvto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidmvto.Location = new System.Drawing.Point(80, 15);
            this.txtidmvto.Multiline = true;
            this.txtidmvto.Name = "txtidmvto";
            this.txtidmvto.Size = new System.Drawing.Size(90, 29);
            this.txtidmvto.TabIndex = 52;
            this.txtidmvto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frmovimientoproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 633);
            this.Controls.Add(this.cmdcerrar);
            this.Name = "Frmovimientoproducto";
            this.Text = "Control de movimientos de almacén";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmovimientoproducto_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cmdcerrar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtmvtoproducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtdoc;
        private System.Windows.Forms.Button cmdgrabar;
        private System.Windows.Forms.Button cmdnuevo;
        private System.Windows.Forms.Button cmdmodific;
        private System.Windows.Forms.Button cmdcerrar;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Dtmvtoproducto;
        private System.Windows.Forms.ComboBox cmbalmacen;
        private System.Windows.Forms.TextBox txtidalmacen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtransac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbproducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblproveedor;
        private System.Windows.Forms.TextBox txtpedido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbdocumento;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbproveedor;
        private System.Windows.Forms.Button cmdkardex;
        private System.Windows.Forms.ComboBox cmbdocum;
        protected System.Windows.Forms.Label lblseleccione;
        private System.Windows.Forms.TextBox txtfactura;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtobservacion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtotal;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtidocumento;
        private System.Windows.Forms.TextBox txtidproveedor;
        private System.Windows.Forms.TextBox txtidmvto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.ComboBox cmbcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn PtoMinStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PtoMaxStock;
       
    }
}