namespace BdInventario
{
    partial class Frmempleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmempleados));
            this.cmdempleado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbcargo = new System.Windows.Forms.ComboBox();
            this.cmbciudad = new System.Windows.Forms.ComboBox();
            this.mskcelular = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.msktelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtnombre2 = new System.Windows.Forms.TextBox();
            this.txtnombre1 = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbempleados = new System.Windows.Forms.ComboBox();
            this.cmdgrabar = new System.Windows.Forms.Button();
            this.cmdnuevo = new System.Windows.Forms.Button();
            this.cmdmodific = new System.Windows.Forms.Button();
            this.txtapellido1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtapellido2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbcontrato = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbproveedor = new System.Windows.Forms.ComboBox();
            this.cmbgrupo = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbsangre = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbeps = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbarp = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbafp = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtobservaciones = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpnacimiento = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtcontacto1 = new System.Windows.Forms.TextBox();
            this.cmdeliminar = new System.Windows.Forms.Button();
            this.txtelefono2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtpingreso = new System.Windows.Forms.DateTimePicker();
            this.dtpretiro = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.BackColor = System.Drawing.Color.Aqua;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Size = new System.Drawing.Size(1288, 62);
            this.lbltitulo.Text = "CONTROL DE EMPLEADOS";
            // 
            // cmdcerrar
            // 
            this.cmdcerrar.Location = new System.Drawing.Point(1295, 9);
            this.toolTip1.SetToolTip(this.cmdcerrar, "Atras");
            this.cmdcerrar.Click += new System.EventHandler(this.cmdcerrar_Click);
            // 
            // lblcentral
            // 
            this.lblcentral.BackColor = System.Drawing.Color.Ivory;
            this.lblcentral.Size = new System.Drawing.Size(1355, 525);
            // 
            // cmdempleado
            // 
            this.cmdempleado.Location = new System.Drawing.Point(1228, 82);
            this.cmdempleado.Name = "cmdempleado";
            this.cmdempleado.Size = new System.Drawing.Size(129, 28);
            this.cmdempleado.TabIndex = 117;
            this.cmdempleado.Text = "&Ver Empleados";
            this.cmdempleado.UseVisualStyleBackColor = true;
            this.cmdempleado.Click += new System.EventHandler(this.cmdempleado_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1248, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // cmbcargo
            // 
            this.cmbcargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbcargo.FormattingEnabled = true;
            this.cmbcargo.Location = new System.Drawing.Point(75, 167);
            this.cmbcargo.Name = "cmbcargo";
            this.cmbcargo.Size = new System.Drawing.Size(179, 28);
            this.cmbcargo.TabIndex = 104;
            this.cmbcargo.SelectedIndexChanged += new System.EventHandler(this.cmbcargo_SelectedIndexChanged);
            // 
            // cmbciudad
            // 
            this.cmbciudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbciudad.FormattingEnabled = true;
            this.cmbciudad.Location = new System.Drawing.Point(330, 167);
            this.cmbciudad.Name = "cmbciudad";
            this.cmbciudad.Size = new System.Drawing.Size(186, 28);
            this.cmbciudad.TabIndex = 102;
            this.cmbciudad.SelectedIndexChanged += new System.EventHandler(this.cmbciudad_SelectedIndexChanged);
            // 
            // mskcelular
            // 
            this.mskcelular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mskcelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskcelular.Location = new System.Drawing.Point(740, 140);
            this.mskcelular.Mask = "(999)000-0000";
            this.mskcelular.Name = "mskcelular";
            this.mskcelular.Size = new System.Drawing.Size(148, 26);
            this.mskcelular.TabIndex = 99;
            this.mskcelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(12, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 28);
            this.label11.TabIndex = 94;
            this.label11.Text = "Cargo.:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(12, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 28);
            this.label10.TabIndex = 93;
            this.label10.Text = "Grupo.:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // msktelefono
            // 
            this.msktelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.msktelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msktelefono.Location = new System.Drawing.Point(514, 140);
            this.msktelefono.Mask = "(999)000-0000";
            this.msktelefono.Name = "msktelefono";
            this.msktelefono.Size = new System.Drawing.Size(158, 26);
            this.msktelefono.TabIndex = 91;
            this.msktelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdireccion.Location = new System.Drawing.Point(96, 140);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(335, 28);
            this.txtdireccion.TabIndex = 90;
            // 
            // txtnombre2
            // 
            this.txtnombre2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtnombre2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre2.Location = new System.Drawing.Point(667, 113);
            this.txtnombre2.Multiline = true;
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.Size = new System.Drawing.Size(142, 28);
            this.txtnombre2.TabIndex = 89;
            // 
            // txtnombre1
            // 
            this.txtnombre1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtnombre1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnombre1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre1.Location = new System.Drawing.Point(382, 113);
            this.txtnombre1.Multiline = true;
            this.txtnombre1.Name = "txtnombre1";
            this.txtnombre1.Size = new System.Drawing.Size(142, 28);
            this.txtnombre1.TabIndex = 88;
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigo.Location = new System.Drawing.Point(96, 113);
            this.txtcodigo.Multiline = true;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(161, 28);
            this.txtcodigo.TabIndex = 87;
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(12, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 28);
            this.label8.TabIndex = 86;
            this.label8.Text = "Código.:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(256, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 28);
            this.label7.TabIndex = 85;
            this.label7.Text = "Primer Nombre.:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(523, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 28);
            this.label6.TabIndex = 84;
            this.label6.Text = "Segundo Nombre.:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 28);
            this.label5.TabIndex = 83;
            this.label5.Text = "Dirección.:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(254, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 81;
            this.label3.Text = "Ciudad.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(430, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 80;
            this.label2.Text = "Teléfono.:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 78;
            this.label1.Text = "Seleccione.:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbempleados
            // 
            this.cmbempleados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbempleados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbempleados.BackColor = System.Drawing.SystemColors.Window;
            this.cmbempleados.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbempleados.FormattingEnabled = true;
            this.cmbempleados.Location = new System.Drawing.Point(109, 82);
            this.cmbempleados.Name = "cmbempleados";
            this.cmbempleados.Size = new System.Drawing.Size(375, 28);
            this.cmbempleados.TabIndex = 77;
            this.cmbempleados.SelectedIndexChanged += new System.EventHandler(this.cmbempleados_SelectedIndexChanged);
            // 
            // cmdgrabar
            // 
            this.cmdgrabar.BackColor = System.Drawing.SystemColors.Control;
            this.cmdgrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdgrabar.Location = new System.Drawing.Point(737, 82);
            this.cmdgrabar.Name = "cmdgrabar";
            this.cmdgrabar.Size = new System.Drawing.Size(91, 28);
            this.cmdgrabar.TabIndex = 75;
            this.cmdgrabar.Text = "&Grabar";
            this.cmdgrabar.UseVisualStyleBackColor = false;
            this.cmdgrabar.Click += new System.EventHandler(this.cmdgrabar_Click);
            // 
            // cmdnuevo
            // 
            this.cmdnuevo.Location = new System.Drawing.Point(644, 82);
            this.cmdnuevo.Name = "cmdnuevo";
            this.cmdnuevo.Size = new System.Drawing.Size(91, 28);
            this.cmdnuevo.TabIndex = 74;
            this.cmdnuevo.Text = "&Nuevo";
            this.cmdnuevo.UseVisualStyleBackColor = true;
            this.cmdnuevo.Click += new System.EventHandler(this.cmdnuevo_Click);
            // 
            // cmdmodific
            // 
            this.cmdmodific.Location = new System.Drawing.Point(830, 82);
            this.cmdmodific.Name = "cmdmodific";
            this.cmdmodific.Size = new System.Drawing.Size(91, 28);
            this.cmdmodific.TabIndex = 76;
            this.cmdmodific.Text = "&Actualizar";
            this.cmdmodific.UseVisualStyleBackColor = true;
            this.cmdmodific.Click += new System.EventHandler(this.cmdactualizar_Click);
            // 
            // txtapellido1
            // 
            this.txtapellido1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtapellido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtapellido1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtapellido1.Location = new System.Drawing.Point(932, 113);
            this.txtapellido1.Multiline = true;
            this.txtapellido1.Name = "txtapellido1";
            this.txtapellido1.Size = new System.Drawing.Size(142, 28);
            this.txtapellido1.TabIndex = 119;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(808, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 28);
            this.label14.TabIndex = 118;
            this.label14.Text = "Primer Apellido.:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtapellido2
            // 
            this.txtapellido2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtapellido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtapellido2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtapellido2.Location = new System.Drawing.Point(1215, 113);
            this.txtapellido2.Multiline = true;
            this.txtapellido2.Name = "txtapellido2";
            this.txtapellido2.Size = new System.Drawing.Size(142, 28);
            this.txtapellido2.TabIndex = 121;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Location = new System.Drawing.Point(1071, 113);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(145, 28);
            this.label19.TabIndex = 120;
            this.label19.Text = "Segundo Apellido.:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(671, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 28);
            this.label4.TabIndex = 122;
            this.label4.Text = "Celular.:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(887, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 28);
            this.label12.TabIndex = 123;
            this.label12.Text = "Fecha Nacimiento.:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(514, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 28);
            this.label9.TabIndex = 125;
            this.label9.Text = "Contrato.:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbcontrato
            // 
            this.cmbcontrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbcontrato.FormattingEnabled = true;
            this.cmbcontrato.Location = new System.Drawing.Point(596, 167);
            this.cmbcontrato.Name = "cmbcontrato";
            this.cmbcontrato.Size = new System.Drawing.Size(173, 28);
            this.cmbcontrato.TabIndex = 126;
            this.cmbcontrato.SelectedIndexChanged += new System.EventHandler(this.cmbcontrato_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(769, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 28);
            this.label13.TabIndex = 127;
            this.label13.Text = "Empresa.:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbproveedor
            // 
            this.cmbproveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbproveedor.FormattingEnabled = true;
            this.cmbproveedor.Location = new System.Drawing.Point(851, 167);
            this.cmbproveedor.Name = "cmbproveedor";
            this.cmbproveedor.Size = new System.Drawing.Size(389, 28);
            this.cmbproveedor.TabIndex = 128;
            this.cmbproveedor.SelectedIndexChanged += new System.EventHandler(this.cmbempresa_SelectedIndexChanged);
            // 
            // cmbgrupo
            // 
            this.cmbgrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbgrupo.FormattingEnabled = true;
            this.cmbgrupo.Location = new System.Drawing.Point(75, 194);
            this.cmbgrupo.Name = "cmbgrupo";
            this.cmbgrupo.Size = new System.Drawing.Size(179, 28);
            this.cmbgrupo.TabIndex = 129;
            this.cmbgrupo.SelectedIndexChanged += new System.EventHandler(this.cmbgrupo_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(254, 194);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 28);
            this.label16.TabIndex = 130;
            this.label16.Text = "Grupo Sanguíneo.:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbsangre
            // 
            this.cmbsangre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbsangre.FormattingEnabled = true;
            this.cmbsangre.Location = new System.Drawing.Point(399, 194);
            this.cmbsangre.Name = "cmbsangre";
            this.cmbsangre.Size = new System.Drawing.Size(179, 28);
            this.cmbsangre.TabIndex = 131;
            this.cmbsangre.SelectedIndexChanged += new System.EventHandler(this.cmbsangre_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Location = new System.Drawing.Point(578, 194);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 28);
            this.label20.TabIndex = 136;
            this.label20.Text = "EPS.:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbeps
            // 
            this.cmbeps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbeps.FormattingEnabled = true;
            this.cmbeps.Location = new System.Drawing.Point(629, 194);
            this.cmbeps.Name = "cmbeps";
            this.cmbeps.Size = new System.Drawing.Size(281, 28);
            this.cmbeps.TabIndex = 137;
            this.cmbeps.SelectedIndexChanged += new System.EventHandler(this.cmbeps_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Location = new System.Drawing.Point(909, 194);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 28);
            this.label21.TabIndex = 138;
            this.label21.Text = "ARP.:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbarp
            // 
            this.cmbarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbarp.FormattingEnabled = true;
            this.cmbarp.Location = new System.Drawing.Point(960, 194);
            this.cmbarp.Name = "cmbarp";
            this.cmbarp.Size = new System.Drawing.Size(280, 28);
            this.cmbarp.TabIndex = 139;
            this.cmbarp.SelectedIndexChanged += new System.EventHandler(this.cmbarp_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(12, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 27);
            this.label15.TabIndex = 140;
            this.label15.Text = "AFP.:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbafp
            // 
            this.cmbafp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbafp.FormattingEnabled = true;
            this.cmbafp.Location = new System.Drawing.Point(63, 221);
            this.cmbafp.Name = "cmbafp";
            this.cmbafp.Size = new System.Drawing.Size(280, 28);
            this.cmbafp.TabIndex = 141;
            this.cmbafp.SelectedIndexChanged += new System.EventHandler(this.cmbafp_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(340, 221);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 27);
            this.label17.TabIndex = 142;
            this.label17.Text = "Fecha Ingreso.:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Location = new System.Drawing.Point(595, 221);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(112, 26);
            this.label22.TabIndex = 144;
            this.label22.Text = "Fecha Retiro.:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Location = new System.Drawing.Point(7, 258);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(1352, 2);
            this.label23.TabIndex = 146;
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtobservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtobservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtobservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtobservaciones.Location = new System.Drawing.Point(6, 72);
            this.txtobservaciones.Multiline = true;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtobservaciones.Size = new System.Drawing.Size(1326, 79);
            this.txtobservaciones.TabIndex = 116;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Ivory;
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtobservaciones);
            this.groupBox1.Location = new System.Drawing.Point(12, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1338, 184);
            this.groupBox1.TabIndex = 147;
            this.groupBox1.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(2, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(162, 20);
            this.label18.TabIndex = 117;
            this.label18.Text = "OBSERVACIONES";
            this.label18.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpnacimiento
            // 
            this.dtpnacimiento.Checked = false;
            this.dtpnacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpnacimiento.Location = new System.Drawing.Point(1034, 141);
            this.dtpnacimiento.Name = "dtpnacimiento";
            this.dtpnacimiento.ShowCheckBox = true;
            this.dtpnacimiento.Size = new System.Drawing.Size(205, 26);
            this.dtpnacimiento.TabIndex = 156;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.Location = new System.Drawing.Point(514, 477);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(82, 28);
            this.label24.TabIndex = 152;
            this.label24.Text = "Teléfono.:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Location = new System.Drawing.Point(18, 477);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(144, 28);
            this.label25.TabIndex = 150;
            this.label25.Text = "Contacto Familiar.:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtcontacto1
            // 
            this.txtcontacto1.BackColor = System.Drawing.Color.White;
            this.txtcontacto1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcontacto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcontacto1.Location = new System.Drawing.Point(161, 477);
            this.txtcontacto1.Multiline = true;
            this.txtcontacto1.Name = "txtcontacto1";
            this.txtcontacto1.Size = new System.Drawing.Size(347, 28);
            this.txtcontacto1.TabIndex = 149;
            // 
            // cmdeliminar
            // 
            this.cmdeliminar.Location = new System.Drawing.Point(923, 82);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(91, 28);
            this.cmdeliminar.TabIndex = 153;
            this.cmdeliminar.Text = "&Eliminar";
            this.cmdeliminar.UseVisualStyleBackColor = true;
            this.cmdeliminar.Click += new System.EventHandler(this.cmdeliminar_Click);
            // 
            // txtelefono2
            // 
            this.txtelefono2.BackColor = System.Drawing.Color.White;
            this.txtelefono2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtelefono2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtelefono2.Location = new System.Drawing.Point(595, 477);
            this.txtelefono2.Multiline = true;
            this.txtelefono2.Name = "txtelefono2";
            this.txtelefono2.Size = new System.Drawing.Size(132, 28);
            this.txtelefono2.TabIndex = 151;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtpingreso
            // 
            this.dtpingreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpingreso.Location = new System.Drawing.Point(462, 221);
            this.dtpingreso.Name = "dtpingreso";
            this.dtpingreso.ShowCheckBox = true;
            this.dtpingreso.Size = new System.Drawing.Size(135, 26);
            this.dtpingreso.TabIndex = 157;
            // 
            // dtpretiro
            // 
            this.dtpretiro.Checked = false;
            this.dtpretiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpretiro.Location = new System.Drawing.Point(706, 222);
            this.dtpretiro.Name = "dtpretiro";
            this.dtpretiro.ShowCheckBox = true;
            this.dtpretiro.Size = new System.Drawing.Size(135, 26);
            this.dtpretiro.TabIndex = 158;
            // 
            // Frmempleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 623);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.dtpretiro);
            this.Controls.Add(this.dtpingreso);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpnacimiento);
            this.Controls.Add(this.cmdeliminar);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtelefono2);
            this.Controls.Add(this.txtcontacto1);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbafp);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cmbarp);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cmbeps);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbsangre);
            this.Controls.Add(this.cmbgrupo);
            this.Controls.Add(this.cmbproveedor);
            this.Controls.Add(this.cmbcontrato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbciudad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtapellido2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtapellido1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmdempleado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbcargo);
            this.Controls.Add(this.mskcelular);
            this.Controls.Add(this.msktelefono);
            this.Controls.Add(this.txtnombre2);
            this.Controls.Add(this.txtnombre1);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbempleados);
            this.Controls.Add(this.cmdgrabar);
            this.Controls.Add(this.cmdnuevo);
            this.Controls.Add(this.cmdmodific);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Frmempleados";
            this.Text = "Control de empleados";
            this.Load += new System.EventHandler(this.Frmempleados_Load);
            this.Controls.SetChildIndex(this.lblcentral, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cmdmodific, 0);
            this.Controls.SetChildIndex(this.cmdnuevo, 0);
            this.Controls.SetChildIndex(this.cmdgrabar, 0);
            this.Controls.SetChildIndex(this.cmbempleados, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtcodigo, 0);
            this.Controls.SetChildIndex(this.txtnombre1, 0);
            this.Controls.SetChildIndex(this.txtnombre2, 0);
            this.Controls.SetChildIndex(this.msktelefono, 0);
            this.Controls.SetChildIndex(this.mskcelular, 0);
            this.Controls.SetChildIndex(this.cmbcargo, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.cmdempleado, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.txtapellido1, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.txtapellido2, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.cmbciudad, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtdireccion, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmbcontrato, 0);
            this.Controls.SetChildIndex(this.cmbproveedor, 0);
            this.Controls.SetChildIndex(this.cmbgrupo, 0);
            this.Controls.SetChildIndex(this.cmbsangre, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cmbeps, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.cmbarp, 0);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.cmbafp, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.label23, 0);
            this.Controls.SetChildIndex(this.txtcontacto1, 0);
            this.Controls.SetChildIndex(this.txtelefono2, 0);
            this.Controls.SetChildIndex(this.label25, 0);
            this.Controls.SetChildIndex(this.label24, 0);
            this.Controls.SetChildIndex(this.cmdeliminar, 0);
            this.Controls.SetChildIndex(this.dtpnacimiento, 0);
            this.Controls.SetChildIndex(this.lbltitulo, 0);
            this.Controls.SetChildIndex(this.cmdcerrar, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.dtpingreso, 0);
            this.Controls.SetChildIndex(this.dtpretiro, 0);
            this.Controls.SetChildIndex(this.label22, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdempleado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbcargo;
        private System.Windows.Forms.ComboBox cmbciudad;
        private System.Windows.Forms.MaskedTextBox mskcelular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox msktelefono;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.TextBox txtnombre1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbempleados;
        private System.Windows.Forms.Button cmdgrabar;
        private System.Windows.Forms.Button cmdnuevo;
        private System.Windows.Forms.Button cmdmodific;
        private System.Windows.Forms.TextBox txtapellido1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtapellido2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbcontrato;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbproveedor;
        private System.Windows.Forms.ComboBox cmbgrupo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbsangre;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbeps;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbarp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbafp;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtobservaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtcontacto1;
        private System.Windows.Forms.Button cmdeliminar;
        private System.Windows.Forms.TextBox txtelefono2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtpnacimiento;
        private System.Windows.Forms.DateTimePicker dtpingreso;
        private System.Windows.Forms.DateTimePicker dtpretiro;
    }
}