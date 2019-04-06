namespace la_tinaja
{
    partial class fr_factura
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_pedidos = new System.Windows.Forms.DataGridView();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.lb_nomcliente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cm_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_sopas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_principios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_carnes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_ensaladas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_bebidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_postres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pt_factcan = new System.Windows.Forms.PictureBox();
            this.pt_factprint = new System.Windows.Forms.PictureBox();
            this.tm_horafac = new System.Windows.Forms.Timer(this.components);
            this.lb_fchfac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_factcan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_factprint)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(207, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURA DEL PEDIDO";
            // 
            // dtg_pedidos
            // 
            this.dtg_pedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_pedidos.BackgroundColor = System.Drawing.Color.Wheat;
            this.dtg_pedidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_pedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dtg_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cm_codigo,
            this.cantidad,
            this.combo,
            this.cm_sopas,
            this.cm_principios,
            this.cm_carnes,
            this.cm_ensaladas,
            this.cm_bebidas,
            this.cm_postres,
            this.otros});
            this.dtg_pedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtg_pedidos.Location = new System.Drawing.Point(3, 251);
            this.dtg_pedidos.Name = "dtg_pedidos";
            this.dtg_pedidos.Size = new System.Drawing.Size(602, 170);
            this.dtg_pedidos.TabIndex = 30;
            // 
            // txt_cliente
            // 
            this.txt_cliente.Enabled = false;
            this.txt_cliente.Location = new System.Drawing.Point(164, 46);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(51, 20);
            this.txt_cliente.TabIndex = 31;
            // 
            // lb_nomcliente
            // 
            this.lb_nomcliente.AutoSize = true;
            this.lb_nomcliente.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nomcliente.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_nomcliente.Location = new System.Drawing.Point(12, 46);
            this.lb_nomcliente.Name = "lb_nomcliente";
            this.lb_nomcliente.Size = new System.Drawing.Size(146, 18);
            this.lb_nomcliente.TabIndex = 32;
            this.lb_nomcliente.Text = "Número de Factura";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(20, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 33;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre y Apellidos del Cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(210, 441);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 18);
            this.textBox3.TabIndex = 37;
            this.textBox3.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(47, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "TOTAL A PAGAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 18);
            this.label3.TabIndex = 70;
            this.label3.Text = "DESCRIPCION DE COMIDAS";
            // 
            // Cm_codigo
            // 
            this.Cm_codigo.HeaderText = "Codigo";
            this.Cm_codigo.Name = "Cm_codigo";
            this.Cm_codigo.Width = 65;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 74;
            // 
            // combo
            // 
            this.combo.HeaderText = "Nombre Combo";
            this.combo.Name = "combo";
            this.combo.Width = 97;
            // 
            // cm_sopas
            // 
            this.cm_sopas.HeaderText = "Sopas";
            this.cm_sopas.Name = "cm_sopas";
            this.cm_sopas.Width = 62;
            // 
            // cm_principios
            // 
            this.cm_principios.HeaderText = "Principios";
            this.cm_principios.Name = "cm_principios";
            this.cm_principios.Width = 77;
            // 
            // cm_carnes
            // 
            this.cm_carnes.HeaderText = "Carnes";
            this.cm_carnes.Name = "cm_carnes";
            this.cm_carnes.Width = 65;
            // 
            // cm_ensaladas
            // 
            this.cm_ensaladas.HeaderText = "Ensaladas";
            this.cm_ensaladas.Name = "cm_ensaladas";
            this.cm_ensaladas.Width = 81;
            // 
            // cm_bebidas
            // 
            this.cm_bebidas.HeaderText = "Bebida";
            this.cm_bebidas.Name = "cm_bebidas";
            this.cm_bebidas.Width = 65;
            // 
            // cm_postres
            // 
            this.cm_postres.HeaderText = "Postres";
            this.cm_postres.Name = "cm_postres";
            this.cm_postres.Width = 67;
            // 
            // otros
            // 
            this.otros.HeaderText = "Otros";
            this.otros.Name = "otros";
            this.otros.Width = 57;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(93, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(101, 20);
            this.textBox2.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(18, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 72;
            this.label5.Text = "Cedula";
            // 
            // pt_factcan
            // 
            this.pt_factcan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pt_factcan.Image = global::la_tinaja.Properties.Resources._1338772558_gtk_cancel;
            this.pt_factcan.Location = new System.Drawing.Point(544, 441);
            this.pt_factcan.Name = "pt_factcan";
            this.pt_factcan.Size = new System.Drawing.Size(35, 27);
            this.pt_factcan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_factcan.TabIndex = 69;
            this.pt_factcan.TabStop = false;
            this.pt_factcan.Click += new System.EventHandler(this.pt_ccte_Click);
            // 
            // pt_factprint
            // 
            this.pt_factprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pt_factprint.Image = global::la_tinaja.Properties.Resources._1338759414_printer_64;
            this.pt_factprint.Location = new System.Drawing.Point(458, 436);
            this.pt_factprint.Name = "pt_factprint";
            this.pt_factprint.Size = new System.Drawing.Size(48, 32);
            this.pt_factprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_factprint.TabIndex = 39;
            this.pt_factprint.TabStop = false;
            // 
            // tm_horafac
            // 
            this.tm_horafac.Enabled = true;
            this.tm_horafac.Interval = 1;
            this.tm_horafac.Tick += new System.EventHandler(this.tm_horafac_Tick);
            // 
            // lb_fchfac
            // 
            this.lb_fchfac.AutoSize = true;
            this.lb_fchfac.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fchfac.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_fchfac.Location = new System.Drawing.Point(436, 49);
            this.lb_fchfac.Name = "lb_fchfac";
            this.lb_fchfac.Size = new System.Drawing.Size(0, 13);
            this.lb_fchfac.TabIndex = 75;
            this.lb_fchfac.Click += new System.EventHandler(this.lb_fchfac_Click);
            // 
            // fr_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(606, 483);
            this.ControlBox = false;
            this.Controls.Add(this.lb_fchfac);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pt_factcan);
            this.Controls.Add(this.pt_factprint);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.lb_nomcliente);
            this.Controls.Add(this.dtg_pedidos);
            this.Controls.Add(this.label1);
            this.Name = "fr_factura";
            this.Load += new System.EventHandler(this.fr_factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_factcan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_factprint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dtg_pedidos;
        private System.Windows.Forms.TextBox txt_cliente;
        public System.Windows.Forms.Label lb_nomcliente;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pt_factprint;
        private System.Windows.Forms.PictureBox pt_factcan;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cm_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn combo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_sopas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_principios;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_carnes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_ensaladas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_bebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cm_postres;
        private System.Windows.Forms.DataGridViewTextBoxColumn otros;
        private System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer tm_horafac;
        private System.Windows.Forms.Label lb_fchfac;
    }
}