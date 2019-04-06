namespace BdInventario
{
    partial class Frmclientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmclientes));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdgrabar = new System.Windows.Forms.Button();
            this.cmdnuevo = new System.Windows.Forms.Button();
            this.cmdmodific = new System.Windows.Forms.Button();
            this.cmbselecliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtrazon = new System.Windows.Forms.TextBox();
            this.txtrut = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.msktelefono = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtobserv = new System.Windows.Forms.TextBox();
            this.txtcredito = new System.Windows.Forms.TextBox();
            this.mskfax = new System.Windows.Forms.MaskedTextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.cmbregimen = new System.Windows.Forms.ComboBox();
            this.cmbciudad = new System.Windows.Forms.ComboBox();
            this.cmbpais = new System.Windows.Forms.ComboBox();
            this.cmbsector = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtweb = new System.Windows.Forms.TextBox();
            this.cmbformapago = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbdomrut = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtcondiciones = new System.Windows.Forms.TextBox();
            this.cmdlistacliente = new System.Windows.Forms.Button();
            this.txtcontacto1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtcontacto2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdeliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(5, 4);
            this.lbltitulo.Size = new System.Drawing.Size(1287, 62);
            this.lbltitulo.Text = "CONTROL DE CLIENTES";
            // 
            // cmdcerrar
            // 
            this.cmdcerrar.Location = new System.Drawing.Point(1300, 4);
            this.cmdcerrar.Size = new System.Drawing.Size(64, 62);
            this.toolTip1.SetToolTip(this.cmdcerrar, "Atras");
            this.cmdcerrar.Click += new System.EventHandler(this.cmdcerrar_Click);
            // 
            // lblcentral
            // 
            this.lblcentral.Location = new System.Drawing.Point(2, 71);
            this.lblcentral.Size = new System.Drawing.Size(1369, 479);
            // 
            // cmdgrabar
            // 
            this.cmdgrabar.BackColor = System.Drawing.SystemColors.Control;
            this.cmdgrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdgrabar.Location = new System.Drawing.Point(737, 75);
            this.cmdgrabar.Name = "cmdgrabar";
            this.cmdgrabar.Size = new System.Drawing.Size(91, 28);
            this.cmdgrabar.TabIndex = 17;
            this.cmdgrabar.Text = "&Grabar";
            this.cmdgrabar.UseVisualStyleBackColor = false;
            this.cmdgrabar.Click += new System.EventHandler(this.cmdgrabar_Click);
            // 
            // cmdnuevo
            // 
            this.cmdnuevo.Location = new System.Drawing.Point(644, 75);
            this.cmdnuevo.Name = "cmdnuevo";
            this.cmdnuevo.Size = new System.Drawing.Size(91, 28);
            this.cmdnuevo.TabIndex = 16;
            this.cmdnuevo.Text = "&Nuevo";
            this.cmdnuevo.UseVisualStyleBackColor = true;
            this.cmdnuevo.Click += new System.EventHandler(this.cmdnuevo_Click);
            // 
            // cmdmodific
            // 
            this.cmdmodific.Location = new System.Drawing.Point(830, 75);
            this.cmdmodific.Name = "cmdmodific";
            this.cmdmodific.Size = new System.Drawing.Size(91, 28);
            this.cmdmodific.TabIndex = 18;
            this.cmdmodific.Text = "&Actualizar";
            this.cmdmodific.UseVisualStyleBackColor = true;
            this.cmdmodific.Click += new System.EventHandler(this.cmdmodific_Click);
            // 
            // cmbselecliente
            // 
            this.cmbselecliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbselecliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbselecliente.BackColor = System.Drawing.SystemColors.Window;
            this.cmbselecliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbselecliente.FormattingEnabled = true;
            this.cmbselecliente.Location = new System.Drawing.Point(109, 75);
            this.cmbselecliente.Name = "cmbselecliente";
            this.cmbselecliente.Size = new System.Drawing.Size(375, 28);
            this.cmbselecliente.TabIndex = 19;
            this.cmbselecliente.SelectedIndexChanged += new System.EventHandler(this.cmbselecliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Seleccione.:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(276, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Teléfono.:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(978, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ciudad.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(723, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 28);
            this.label4.TabIndex = 24;
            this.label4.Text = "País.:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(276, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Dirección.:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(747, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nombre RUT.:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(276, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "Razón Social.:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(12, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 28);
            this.label8.TabIndex = 28;
            this.label8.Text = "Código.:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigo.Location = new System.Drawing.Point(96, 106);
            this.txtcodigo.Multiline = true;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(181, 28);
            this.txtcodigo.TabIndex = 29;
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // txtrazon
            // 
            this.txtrazon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtrazon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrazon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtrazon.Location = new System.Drawing.Point(389, 106);
            this.txtrazon.Multiline = true;
            this.txtrazon.Name = "txtrazon";
            this.txtrazon.Size = new System.Drawing.Size(359, 28);
            this.txtrazon.TabIndex = 30;
            // 
            // txtrut
            // 
            this.txtrut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtrut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtrut.Location = new System.Drawing.Point(859, 106);
            this.txtrut.Multiline = true;
            this.txtrut.Name = "txtrut";
            this.txtrut.Size = new System.Drawing.Size(381, 28);
            this.txtrut.TabIndex = 31;
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdireccion.Location = new System.Drawing.Point(360, 133);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(364, 28);
            this.txtdireccion.TabIndex = 32;
            // 
            // msktelefono
            // 
            this.msktelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.msktelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msktelefono.Location = new System.Drawing.Point(360, 160);
            this.msktelefono.Mask = "(999)000-0000";
            this.msktelefono.Name = "msktelefono";
            this.msktelefono.Size = new System.Drawing.Size(158, 26);
            this.msktelefono.TabIndex = 35;
            this.msktelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(360, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 28);
            this.label9.TabIndex = 36;
            this.label9.Text = "Pagina Web.:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(12, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 28);
            this.label10.TabIndex = 37;
            this.label10.Text = "E-mail.:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(12, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 28);
            this.label11.TabIndex = 38;
            this.label11.Text = "Sector.:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(12, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 28);
            this.label12.TabIndex = 39;
            this.label12.Text = "Régimen.:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(723, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 28);
            this.label13.TabIndex = 40;
            this.label13.Text = "Cupo Crédito.:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(517, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 28);
            this.label14.TabIndex = 41;
            this.label14.Text = "Fax.:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtobserv
            // 
            this.txtobserv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtobserv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtobserv.Location = new System.Drawing.Point(867, 187);
            this.txtobserv.Multiline = true;
            this.txtobserv.Name = "txtobserv";
            this.txtobserv.Size = new System.Drawing.Size(373, 28);
            this.txtobserv.TabIndex = 43;
            // 
            // txtcredito
            // 
            this.txtcredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtcredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcredito.Location = new System.Drawing.Point(840, 160);
            this.txtcredito.Multiline = true;
            this.txtcredito.Name = "txtcredito";
            this.txtcredito.Size = new System.Drawing.Size(139, 28);
            this.txtcredito.TabIndex = 46;
            this.txtcredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcredito_KeyPress);
            // 
            // mskfax
            // 
            this.mskfax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mskfax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskfax.Location = new System.Drawing.Point(576, 160);
            this.mskfax.Mask = "(999)000-0000";
            this.mskfax.Name = "mskfax";
            this.mskfax.Size = new System.Drawing.Size(148, 26);
            this.mskfax.TabIndex = 48;
            this.mskfax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.Location = new System.Drawing.Point(96, 187);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(265, 28);
            this.txtemail.TabIndex = 49;
            // 
            // cmbregimen
            // 
            this.cmbregimen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbregimen.FormattingEnabled = true;
            this.cmbregimen.Location = new System.Drawing.Point(97, 133);
            this.cmbregimen.Name = "cmbregimen";
            this.cmbregimen.Size = new System.Drawing.Size(179, 28);
            this.cmbregimen.TabIndex = 50;
            this.cmbregimen.TextChanged += new System.EventHandler(this.cmbregimen_TextChanged);
            // 
            // cmbciudad
            // 
            this.cmbciudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbciudad.FormattingEnabled = true;
            this.cmbciudad.Location = new System.Drawing.Point(1054, 133);
            this.cmbciudad.Name = "cmbciudad";
            this.cmbciudad.Size = new System.Drawing.Size(186, 28);
            this.cmbciudad.TabIndex = 51;
            this.cmbciudad.SelectedIndexChanged += new System.EventHandler(this.cmbciudad_SelectedIndexChanged);
            // 
            // cmbpais
            // 
            this.cmbpais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbpais.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbpais.FormattingEnabled = true;
            this.cmbpais.Location = new System.Drawing.Point(782, 133);
            this.cmbpais.Name = "cmbpais";
            this.cmbpais.Size = new System.Drawing.Size(196, 28);
            this.cmbpais.TabIndex = 52;
            this.cmbpais.SelectedIndexChanged += new System.EventHandler(this.cmbpais_SelectedIndexChanged);
            // 
            // cmbsector
            // 
            this.cmbsector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbsector.FormattingEnabled = true;
            this.cmbsector.Location = new System.Drawing.Point(97, 160);
            this.cmbsector.Name = "cmbsector";
            this.cmbsector.Size = new System.Drawing.Size(179, 28);
            this.cmbsector.TabIndex = 53;
            this.cmbsector.SelectedIndexChanged += new System.EventHandler(this.cmbsector_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(736, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 28);
            this.label15.TabIndex = 55;
            this.label15.Text = "Observaciones.:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtweb
            // 
            this.txtweb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtweb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtweb.Location = new System.Drawing.Point(471, 187);
            this.txtweb.Multiline = true;
            this.txtweb.Name = "txtweb";
            this.txtweb.Size = new System.Drawing.Size(266, 28);
            this.txtweb.TabIndex = 56;
            // 
            // cmbformapago
            // 
            this.cmbformapago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbformapago.FormattingEnabled = true;
            this.cmbformapago.Location = new System.Drawing.Point(151, 214);
            this.cmbformapago.Name = "cmbformapago";
            this.cmbformapago.Size = new System.Drawing.Size(280, 28);
            this.cmbformapago.TabIndex = 58;
            this.cmbformapago.SelectedIndexChanged += new System.EventHandler(this.cmbformapago_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(12, 214);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 28);
            this.label16.TabIndex = 57;
            this.label16.Text = "Forma de Pago.:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(12, 241);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(1365, 28);
            this.label18.TabIndex = 61;
            this.label18.Text = "CONDICIONES COMERCIALES";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1262, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Location = new System.Drawing.Point(978, 160);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 28);
            this.label20.TabIndex = 70;
            this.label20.Text = "Domicilio RUT.:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbdomrut
            // 
            this.cmbdomrut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbdomrut.FormattingEnabled = true;
            this.cmbdomrut.Location = new System.Drawing.Point(1097, 160);
            this.cmbdomrut.Name = "cmbdomrut";
            this.cmbdomrut.Size = new System.Drawing.Size(143, 28);
            this.cmbdomrut.TabIndex = 71;
            this.cmbdomrut.SelectedIndexChanged += new System.EventHandler(this.cmbdomrut_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtcondiciones
            // 
            this.txtcondiciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcondiciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtcondiciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcondiciones.Location = new System.Drawing.Point(12, 268);
            this.txtcondiciones.Multiline = true;
            this.txtcondiciones.Name = "txtcondiciones";
            this.txtcondiciones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtcondiciones.Size = new System.Drawing.Size(1365, 79);
            this.txtcondiciones.TabIndex = 72;
            // 
            // cmdlistacliente
            // 
            this.cmdlistacliente.Location = new System.Drawing.Point(1246, 75);
            this.cmdlistacliente.Name = "cmdlistacliente";
            this.cmdlistacliente.Size = new System.Drawing.Size(111, 28);
            this.cmdlistacliente.TabIndex = 73;
            this.cmdlistacliente.Text = "&Ver Clientes";
            this.cmdlistacliente.UseVisualStyleBackColor = true;
            this.cmdlistacliente.Click += new System.EventHandler(this.cmdlistacliente_Click);
            // 
            // txtcontacto1
            // 
            this.txtcontacto1.BackColor = System.Drawing.Color.White;
            this.txtcontacto1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcontacto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcontacto1.Location = new System.Drawing.Point(102, 33);
            this.txtcontacto1.Multiline = true;
            this.txtcontacto1.Name = "txtcontacto1";
            this.txtcontacto1.Size = new System.Drawing.Size(396, 28);
            this.txtcontacto1.TabIndex = 74;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(6, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 28);
            this.label17.TabIndex = 75;
            this.label17.Text = "Contacto 1.:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Location = new System.Drawing.Point(6, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 28);
            this.label19.TabIndex = 77;
            this.label19.Text = "Contacto 2.:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcontacto2
            // 
            this.txtcontacto2.BackColor = System.Drawing.Color.White;
            this.txtcontacto2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcontacto2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcontacto2.Location = new System.Drawing.Point(102, 66);
            this.txtcontacto2.Multiline = true;
            this.txtcontacto2.Name = "txtcontacto2";
            this.txtcontacto2.Size = new System.Drawing.Size(396, 28);
            this.txtcontacto2.TabIndex = 76;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtcontacto2);
            this.groupBox1.Controls.Add(this.txtcontacto1);
            this.groupBox1.Location = new System.Drawing.Point(360, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 126);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            // 
            // cmdeliminar
            // 
            this.cmdeliminar.Location = new System.Drawing.Point(923, 75);
            this.cmdeliminar.Name = "cmdeliminar";
            this.cmdeliminar.Size = new System.Drawing.Size(91, 28);
            this.cmdeliminar.TabIndex = 79;
            this.cmdeliminar.Text = "&Eliminar";
            this.cmdeliminar.UseVisualStyleBackColor = true;
            this.cmdeliminar.Click += new System.EventHandler(this.cmdeliminar_Click);
            // 
            // Frmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 623);
            this.Controls.Add(this.cmdeliminar);
            this.Controls.Add(this.cmdlistacliente);
            this.Controls.Add(this.txtcondiciones);
            this.Controls.Add(this.cmbdomrut);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cmbformapago);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtweb);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbsector);
            this.Controls.Add(this.cmbpais);
            this.Controls.Add(this.cmbciudad);
            this.Controls.Add(this.cmbregimen);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.mskfax);
            this.Controls.Add(this.txtcredito);
            this.Controls.Add(this.txtobserv);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.msktelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtrut);
            this.Controls.Add(this.txtrazon);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbselecliente);
            this.Controls.Add(this.cmdgrabar);
            this.Controls.Add(this.cmdnuevo);
            this.Controls.Add(this.cmdmodific);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Frmclientes";
            this.Text = "Control de Clientes Ver. 1.0";
            this.Load += new System.EventHandler(this.Frmclientes_Load);
            this.Controls.SetChildIndex(this.lblcentral, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.cmdmodific, 0);
            this.Controls.SetChildIndex(this.cmdnuevo, 0);
            this.Controls.SetChildIndex(this.cmdgrabar, 0);
            this.Controls.SetChildIndex(this.cmbselecliente, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtcodigo, 0);
            this.Controls.SetChildIndex(this.txtrazon, 0);
            this.Controls.SetChildIndex(this.txtrut, 0);
            this.Controls.SetChildIndex(this.txtdireccion, 0);
            this.Controls.SetChildIndex(this.msktelefono, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.txtobserv, 0);
            this.Controls.SetChildIndex(this.txtcredito, 0);
            this.Controls.SetChildIndex(this.mskfax, 0);
            this.Controls.SetChildIndex(this.txtemail, 0);
            this.Controls.SetChildIndex(this.cmbregimen, 0);
            this.Controls.SetChildIndex(this.cmbciudad, 0);
            this.Controls.SetChildIndex(this.cmbpais, 0);
            this.Controls.SetChildIndex(this.cmbsector, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.txtweb, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.cmbformapago, 0);
            this.Controls.SetChildIndex(this.lbltitulo, 0);
            this.Controls.SetChildIndex(this.cmdcerrar, 0);
            this.Controls.SetChildIndex(this.label18, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.cmbdomrut, 0);
            this.Controls.SetChildIndex(this.txtcondiciones, 0);
            this.Controls.SetChildIndex(this.cmdlistacliente, 0);
            this.Controls.SetChildIndex(this.cmdeliminar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cmdgrabar;
        private System.Windows.Forms.Button cmdnuevo;
        private System.Windows.Forms.Button cmdmodific;
        private System.Windows.Forms.ComboBox cmbselecliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtrazon;
        private System.Windows.Forms.TextBox txtrut;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.MaskedTextBox msktelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtobserv;
        private System.Windows.Forms.TextBox txtcredito;
        private System.Windows.Forms.MaskedTextBox mskfax;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.ComboBox cmbregimen;
        private System.Windows.Forms.ComboBox cmbciudad;
        private System.Windows.Forms.ComboBox cmbpais;
        private System.Windows.Forms.ComboBox cmbsector;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtweb;
        private System.Windows.Forms.ComboBox cmbformapago;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbdomrut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtcondiciones;
        private System.Windows.Forms.Button cmdlistacliente;
        private System.Windows.Forms.TextBox txtcontacto1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtcontacto2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdeliminar;
    }
}