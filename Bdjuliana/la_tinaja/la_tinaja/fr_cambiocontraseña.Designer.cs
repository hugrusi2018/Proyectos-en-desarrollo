namespace la_tinaja
{
    partial class fr_cambiocontraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_cambiocontraseña));
            this.txt_conew = new System.Windows.Forms.TextBox();
            this.txt_conan = new System.Windows.Forms.TextBox();
            this.lb_conew = new System.Windows.Forms.Label();
            this.lb_conan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_users = new System.Windows.Forms.Label();
            this.pt_usuario = new System.Windows.Forms.PictureBox();
            this.txt_confir = new System.Windows.Forms.TextBox();
            this.lb_confir = new System.Windows.Forms.Label();
            this.bt_canc = new System.Windows.Forms.Button();
            this.bt_acep = new System.Windows.Forms.Button();
            this.ch_contr = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pt_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_conew
            // 
            this.txt_conew.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_conew.Location = new System.Drawing.Point(168, 99);
            this.txt_conew.Name = "txt_conew";
            this.txt_conew.PasswordChar = '*';
            this.txt_conew.Size = new System.Drawing.Size(122, 21);
            this.txt_conew.TabIndex = 6;
            this.txt_conew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_conew_KeyDown);
            // 
            // txt_conan
            // 
            this.txt_conan.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_conan.Location = new System.Drawing.Point(168, 65);
            this.txt_conan.Name = "txt_conan";
            this.txt_conan.PasswordChar = '*';
            this.txt_conan.Size = new System.Drawing.Size(122, 21);
            this.txt_conan.TabIndex = 4;
            this.txt_conan.TextChanged += new System.EventHandler(this.txt_conan_TextChanged);
            this.txt_conan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_conan_KeyDown);
            // 
            // lb_conew
            // 
            this.lb_conew.AutoSize = true;
            this.lb_conew.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_conew.Location = new System.Drawing.Point(26, 103);
            this.lb_conew.Name = "lb_conew";
            this.lb_conew.Size = new System.Drawing.Size(114, 17);
            this.lb_conew.TabIndex = 7;
            this.lb_conew.Text = "Nueva Contraseña";
            // 
            // lb_conan
            // 
            this.lb_conan.AutoSize = true;
            this.lb_conan.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_conan.Location = new System.Drawing.Point(26, 65);
            this.lb_conan.Name = "lb_conan";
            this.lb_conan.Size = new System.Drawing.Size(120, 17);
            this.lb_conan.TabIndex = 5;
            this.lb_conan.Text = "Contraseña Antigua";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "ADMINISTRADOR DE CONTRASEÑAS";
            // 
            // lb_users
            // 
            this.lb_users.AutoSize = true;
            this.lb_users.BackColor = System.Drawing.Color.OldLace;
            this.lb_users.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_users.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_users.Location = new System.Drawing.Point(321, 149);
            this.lb_users.Name = "lb_users";
            this.lb_users.Size = new System.Drawing.Size(93, 17);
            this.lb_users.TabIndex = 34;
            this.lb_users.Text = "Tinajero.Rios";
            // 
            // pt_usuario
            // 
            this.pt_usuario.BackColor = System.Drawing.Color.OldLace;
            this.pt_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pt_usuario.Image = ((System.Drawing.Image)(resources.GetObject("pt_usuario.Image")));
            this.pt_usuario.Location = new System.Drawing.Point(315, 42);
            this.pt_usuario.Name = "pt_usuario";
            this.pt_usuario.Size = new System.Drawing.Size(109, 105);
            this.pt_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_usuario.TabIndex = 33;
            this.pt_usuario.TabStop = false;
            // 
            // txt_confir
            // 
            this.txt_confir.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confir.Location = new System.Drawing.Point(168, 136);
            this.txt_confir.Name = "txt_confir";
            this.txt_confir.PasswordChar = '*';
            this.txt_confir.Size = new System.Drawing.Size(122, 21);
            this.txt_confir.TabIndex = 35;
            this.txt_confir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_confir_KeyDown);
            // 
            // lb_confir
            // 
            this.lb_confir.AutoSize = true;
            this.lb_confir.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_confir.Location = new System.Drawing.Point(26, 140);
            this.lb_confir.Name = "lb_confir";
            this.lb_confir.Size = new System.Drawing.Size(137, 17);
            this.lb_confir.TabIndex = 36;
            this.lb_confir.Text = "Confirmar Contraseña";
            // 
            // bt_canc
            // 
            this.bt_canc.BackColor = System.Drawing.Color.Wheat;
            this.bt_canc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_canc.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_canc.Location = new System.Drawing.Point(224, 187);
            this.bt_canc.Name = "bt_canc";
            this.bt_canc.Size = new System.Drawing.Size(89, 27);
            this.bt_canc.TabIndex = 38;
            this.bt_canc.Text = "&Cancelar";
            this.bt_canc.UseVisualStyleBackColor = false;
            this.bt_canc.Click += new System.EventHandler(this.bt_canc_Click);
            // 
            // bt_acep
            // 
            this.bt_acep.BackColor = System.Drawing.Color.Wheat;
            this.bt_acep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_acep.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_acep.Location = new System.Drawing.Point(129, 187);
            this.bt_acep.Name = "bt_acep";
            this.bt_acep.Size = new System.Drawing.Size(89, 27);
            this.bt_acep.TabIndex = 37;
            this.bt_acep.Text = "&Aceptar";
            this.bt_acep.UseVisualStyleBackColor = false;
            this.bt_acep.Click += new System.EventHandler(this.bt_acep_Click);
            // 
            // ch_contr
            // 
            this.ch_contr.AutoSize = true;
            this.ch_contr.Font = new System.Drawing.Font("Garamond", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_contr.Location = new System.Drawing.Point(12, 193);
            this.ch_contr.Name = "ch_contr";
            this.ch_contr.Size = new System.Drawing.Size(95, 16);
            this.ch_contr.TabIndex = 39;
            this.ch_contr.Text = "Ver Contraseña";
            this.ch_contr.UseVisualStyleBackColor = true;
            this.ch_contr.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // fr_cambiocontraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(446, 232);
            this.ControlBox = false;
            this.Controls.Add(this.ch_contr);
            this.Controls.Add(this.bt_canc);
            this.Controls.Add(this.bt_acep);
            this.Controls.Add(this.txt_confir);
            this.Controls.Add(this.lb_confir);
            this.Controls.Add(this.lb_users);
            this.Controls.Add(this.pt_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_conew);
            this.Controls.Add(this.txt_conan);
            this.Controls.Add(this.lb_conew);
            this.Controls.Add(this.lb_conan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fr_cambiocontraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fr_cambiocontraseña_FormClosing);
            this.Load += new System.EventHandler(this.fr_cambiocontraseña_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fr_cambiocontraseña_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pt_usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_conew;
        private System.Windows.Forms.TextBox txt_conan;
        private System.Windows.Forms.Label lb_conew;
        private System.Windows.Forms.Label lb_conan;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lb_users;
        private System.Windows.Forms.PictureBox pt_usuario;
        private System.Windows.Forms.TextBox txt_confir;
        private System.Windows.Forms.Label lb_confir;
        private System.Windows.Forms.Button bt_canc;
        private System.Windows.Forms.Button bt_acep;
        private System.Windows.Forms.CheckBox ch_contr;
    }
}