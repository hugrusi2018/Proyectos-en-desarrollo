namespace la_tinaja
{
    partial class fr_acceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_acceso));
            this.lb_tit = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.lb_cont = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pasw = new System.Windows.Forms.TextBox();
            this.bt_acep = new System.Windows.Forms.Button();
            this.bt_canc = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.cb_preg = new System.Windows.Forms.ComboBox();
            this.lb_preg = new System.Windows.Forms.Label();
            this.txt_resp = new System.Windows.Forms.TextBox();
            this.lb_resp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pt_canc = new System.Windows.Forms.PictureBox();
            this.pt_aceptar = new System.Windows.Forms.PictureBox();
            this.pt_opt = new System.Windows.Forms.PictureBox();
            this.pt_tina = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_canc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_aceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_opt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_tina)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_tit
            // 
            this.lb_tit.AutoSize = true;
            this.lb_tit.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tit.Location = new System.Drawing.Point(222, 15);
            this.lb_tit.Name = "lb_tit";
            this.lb_tit.Size = new System.Drawing.Size(99, 18);
            this.lb_tit.TabIndex = 1;
            this.lb_tit.Text = "TINAJEROS";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.Location = new System.Drawing.Point(164, 54);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(73, 17);
            this.lb_user.TabIndex = 2;
            this.lb_user.Text = "USUARIO";
            // 
            // lb_cont
            // 
            this.lb_cont.AutoSize = true;
            this.lb_cont.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cont.Location = new System.Drawing.Point(164, 96);
            this.lb_cont.Name = "lb_cont";
            this.lb_cont.Size = new System.Drawing.Size(109, 17);
            this.lb_cont.TabIndex = 3;
            this.lb_cont.Text = "CONTRASEÑA";
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(284, 50);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(133, 21);
            this.txt_user.TabIndex = 1;
            this.txt_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
            this.txt_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_user_KeyDown);
            this.txt_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_KeyPress);
            // 
            // txt_pasw
            // 
            this.txt_pasw.Enabled = false;
            this.txt_pasw.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pasw.Location = new System.Drawing.Point(284, 92);
            this.txt_pasw.Name = "txt_pasw";
            this.txt_pasw.PasswordChar = '*';
            this.txt_pasw.Size = new System.Drawing.Size(133, 21);
            this.txt_pasw.TabIndex = 2;
            this.txt_pasw.TextChanged += new System.EventHandler(this.txt_pasw_TextChanged);
            this.txt_pasw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pasw_KeyDown);
            this.txt_pasw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pasw_KeyPress);
            // 
            // bt_acep
            // 
            this.bt_acep.BackColor = System.Drawing.Color.Wheat;
            this.bt_acep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_acep.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_acep.Location = new System.Drawing.Point(188, 132);
            this.bt_acep.Name = "bt_acep";
            this.bt_acep.Size = new System.Drawing.Size(89, 27);
            this.bt_acep.TabIndex = 3;
            this.bt_acep.Text = "&Aceptar";
            this.bt_acep.UseVisualStyleBackColor = false;
            this.bt_acep.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_canc
            // 
            this.bt_canc.BackColor = System.Drawing.Color.Wheat;
            this.bt_canc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_canc.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_canc.Location = new System.Drawing.Point(312, 132);
            this.bt_canc.Name = "bt_canc";
            this.bt_canc.Size = new System.Drawing.Size(89, 27);
            this.bt_canc.TabIndex = 4;
            this.bt_canc.Text = "&Cancelar";
            this.bt_canc.UseVisualStyleBackColor = false;
            this.bt_canc.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_salir
            // 
            this.bt_salir.BackColor = System.Drawing.Color.Wheat;
            this.bt_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_salir.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salir.Location = new System.Drawing.Point(432, 6);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(23, 27);
            this.bt_salir.TabIndex = 8;
            this.bt_salir.Text = "&X";
            this.bt_salir.UseVisualStyleBackColor = false;
            this.bt_salir.Click += new System.EventHandler(this.button3_Click);
            // 
            // cb_preg
            // 
            this.cb_preg.FormattingEnabled = true;
            this.cb_preg.Location = new System.Drawing.Point(17, 35);
            this.cb_preg.Name = "cb_preg";
            this.cb_preg.Size = new System.Drawing.Size(279, 21);
            this.cb_preg.TabIndex = 10;
            // 
            // lb_preg
            // 
            this.lb_preg.AutoSize = true;
            this.lb_preg.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_preg.Location = new System.Drawing.Point(14, 15);
            this.lb_preg.Name = "lb_preg";
            this.lb_preg.Size = new System.Drawing.Size(211, 17);
            this.lb_preg.TabIndex = 11;
            this.lb_preg.Text = "SELECCIONE LA PREGUNTA";
            // 
            // txt_resp
            // 
            this.txt_resp.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resp.Location = new System.Drawing.Point(17, 79);
            this.txt_resp.Name = "txt_resp";
            this.txt_resp.Size = new System.Drawing.Size(276, 21);
            this.txt_resp.TabIndex = 13;
            this.txt_resp.TextChanged += new System.EventHandler(this.txt_resp_TextChanged);
            this.txt_resp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_resp_KeyPress);
            // 
            // lb_resp
            // 
            this.lb_resp.AutoSize = true;
            this.lb_resp.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resp.Location = new System.Drawing.Point(14, 59);
            this.lb_resp.Name = "lb_resp";
            this.lb_resp.Size = new System.Drawing.Size(89, 17);
            this.lb_resp.TabIndex = 14;
            this.lb_resp.Text = "RESPUESTA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.txt_resp);
            this.panel1.Controls.Add(this.lb_resp);
            this.panel1.Controls.Add(this.pt_canc);
            this.panel1.Controls.Add(this.pt_aceptar);
            this.panel1.Controls.Add(this.cb_preg);
            this.panel1.Controls.Add(this.lb_preg);
            this.panel1.Location = new System.Drawing.Point(12, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 115);
            this.panel1.TabIndex = 17;
            // 
            // pt_canc
            // 
            this.pt_canc.Image = ((System.Drawing.Image)(resources.GetObject("pt_canc.Image")));
            this.pt_canc.Location = new System.Drawing.Point(395, 71);
            this.pt_canc.Name = "pt_canc";
            this.pt_canc.Size = new System.Drawing.Size(24, 24);
            this.pt_canc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_canc.TabIndex = 16;
            this.pt_canc.TabStop = false;
            this.pt_canc.Click += new System.EventHandler(this.pt_canc_Click);
            // 
            // pt_aceptar
            // 
            this.pt_aceptar.Image = ((System.Drawing.Image)(resources.GetObject("pt_aceptar.Image")));
            this.pt_aceptar.Location = new System.Drawing.Point(353, 71);
            this.pt_aceptar.Name = "pt_aceptar";
            this.pt_aceptar.Size = new System.Drawing.Size(24, 24);
            this.pt_aceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pt_aceptar.TabIndex = 15;
            this.pt_aceptar.TabStop = false;
            this.pt_aceptar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pt_opt
            // 
            this.pt_opt.Image = ((System.Drawing.Image)(resources.GetObject("pt_opt.Image")));
            this.pt_opt.Location = new System.Drawing.Point(422, 159);
            this.pt_opt.Name = "pt_opt";
            this.pt_opt.Size = new System.Drawing.Size(33, 30);
            this.pt_opt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_opt.TabIndex = 9;
            this.pt_opt.TabStop = false;
            this.pt_opt.Click += new System.EventHandler(this.pt_opt_Click);
            // 
            // pt_tina
            // 
            this.pt_tina.Image = global::la_tinaja.Properties.Resources.la_tinaja1_2;
            this.pt_tina.Location = new System.Drawing.Point(12, 20);
            this.pt_tina.Name = "pt_tina";
            this.pt_tina.Size = new System.Drawing.Size(131, 139);
            this.pt_tina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_tina.TabIndex = 0;
            this.pt_tina.TabStop = false;
            // 
            // fr_acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(461, 202);
            this.ControlBox = false;
            this.Controls.Add(this.pt_opt);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_canc);
            this.Controls.Add(this.bt_acep);
            this.Controls.Add(this.txt_pasw);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lb_cont);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.lb_tit);
            this.Controls.Add(this.pt_tina);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fr_acceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.fr_acceso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_canc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_aceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_opt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_tina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pt_tina;
        private System.Windows.Forms.Label lb_tit;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_cont;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pasw;
        private System.Windows.Forms.Button bt_acep;
        private System.Windows.Forms.Button bt_canc;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.PictureBox pt_opt;
        private System.Windows.Forms.ComboBox cb_preg;
        private System.Windows.Forms.Label lb_preg;
        private System.Windows.Forms.TextBox txt_resp;
        private System.Windows.Forms.Label lb_resp;
        private System.Windows.Forms.PictureBox pt_aceptar;
        private System.Windows.Forms.PictureBox pt_canc;
        private System.Windows.Forms.Panel panel1;
    }
}