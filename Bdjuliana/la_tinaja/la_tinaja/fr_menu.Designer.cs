namespace la_tinaja
{
    partial class fr_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_menu));
            this.tm_movimiento = new System.Windows.Forms.Timer(this.components);
            this.lb_fecha = new System.Windows.Forms.Label();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuinicio = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tm_hora = new System.Windows.Forms.Timer(this.components);
            this.lb_user = new System.Windows.Forms.Label();
            this.pt_usuario = new System.Windows.Forms.PictureBox();
            this.pt_menu = new System.Windows.Forms.PictureBox();
            this.lb_menupara = new System.Windows.Forms.Label();
            this.lb_menuseg = new System.Windows.Forms.Label();
            this.lb_menuadmin = new System.Windows.Forms.Label();
            this.lb_menuped = new System.Windows.Forms.Label();
            this.menuinicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // tm_movimiento
            // 
            this.tm_movimiento.Enabled = true;
            this.tm_movimiento.Interval = 1;
            this.tm_movimiento.Tick += new System.EventHandler(this.tm_hora_Tick);
            // 
            // lb_fecha
            // 
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_fecha.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fecha.ForeColor = System.Drawing.Color.Orange;
            this.lb_fecha.Location = new System.Drawing.Point(0, 732);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(0, 18);
            this.lb_fecha.TabIndex = 2;
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.Wheat;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(531, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "MENU TINAJERO";
            // 
            // menuinicio
            // 
            this.menuinicio.BackColor = System.Drawing.Color.Wheat;
            this.menuinicio.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuinicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuinicio.Location = new System.Drawing.Point(0, 0);
            this.menuinicio.Name = "menuinicio";
            this.menuinicio.Size = new System.Drawing.Size(1306, 70);
            this.menuinicio.TabIndex = 0;
            this.menuinicio.Text = "menuStrip1";
            this.menuinicio.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.inicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicioToolStripMenuItem.Image")));
            this.inicioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(72, 66);
            this.inicioToolStripMenuItem.Text = "&Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.BackColor = System.Drawing.Color.Wheat;
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.salirToolStripMenuItem1.Text = "&Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // tm_hora
            // 
            this.tm_hora.Enabled = true;
            this.tm_hora.Interval = 1;
            this.tm_hora.Tick += new System.EventHandler(this.tm_hora_Tick_1);
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.BackColor = System.Drawing.Color.Wheat;
            this.lb_user.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_user.Location = new System.Drawing.Point(1176, 30);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(93, 17);
            this.lb_user.TabIndex = 32;
            this.lb_user.Text = "Tinajero.Rios";
            // 
            // pt_usuario
            // 
            this.pt_usuario.BackColor = System.Drawing.Color.Wheat;
            this.pt_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pt_usuario.Image = global::la_tinaja.Properties.Resources.user_basic_yellow;
            this.pt_usuario.Location = new System.Drawing.Point(1138, 21);
            this.pt_usuario.Name = "pt_usuario";
            this.pt_usuario.Size = new System.Drawing.Size(23, 26);
            this.pt_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_usuario.TabIndex = 31;
            this.pt_usuario.TabStop = false;
            // 
            // pt_menu
            // 
            this.pt_menu.Image = global::la_tinaja.Properties.Resources.la_tinaja1;
            this.pt_menu.Location = new System.Drawing.Point(523, 170);
            this.pt_menu.Name = "pt_menu";
            this.pt_menu.Size = new System.Drawing.Size(321, 402);
            this.pt_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_menu.TabIndex = 7;
            this.pt_menu.TabStop = false;
            // 
            // lb_menupara
            // 
            this.lb_menupara.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_menupara.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_menupara.Image = global::la_tinaja.Properties.Resources.Plato2;
            this.lb_menupara.Location = new System.Drawing.Point(369, 308);
            this.lb_menupara.Name = "lb_menupara";
            this.lb_menupara.Size = new System.Drawing.Size(161, 73);
            this.lb_menupara.TabIndex = 11;
            this.lb_menupara.Text = "PARAMETROS";
            this.lb_menupara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_menupara.Click += new System.EventHandler(this.lb_menupara_Click);
            this.lb_menupara.MouseEnter += new System.EventHandler(this.lb_menupara_MouseEnter);
            this.lb_menupara.MouseLeave += new System.EventHandler(this.lb_menupara_MouseLeave_1);
            // 
            // lb_menuseg
            // 
            this.lb_menuseg.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_menuseg.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_menuseg.Image = global::la_tinaja.Properties.Resources.Plato2;
            this.lb_menuseg.Location = new System.Drawing.Point(620, 559);
            this.lb_menuseg.Name = "lb_menuseg";
            this.lb_menuseg.Size = new System.Drawing.Size(161, 73);
            this.lb_menuseg.TabIndex = 10;
            this.lb_menuseg.Text = "SEGURIDAD";
            this.lb_menuseg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_menuseg.MouseEnter += new System.EventHandler(this.lb_menuseg_MouseEnter_1);
            this.lb_menuseg.MouseLeave += new System.EventHandler(this.lb_menuseg_MouseLeave);
            // 
            // lb_menuadmin
            // 
            this.lb_menuadmin.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_menuadmin.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_menuadmin.Image = global::la_tinaja.Properties.Resources.Plato2;
            this.lb_menuadmin.Location = new System.Drawing.Point(872, 308);
            this.lb_menuadmin.Name = "lb_menuadmin";
            this.lb_menuadmin.Size = new System.Drawing.Size(161, 73);
            this.lb_menuadmin.TabIndex = 9;
            this.lb_menuadmin.Text = "ADMINISTRACION";
            this.lb_menuadmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_menuadmin.Click += new System.EventHandler(this.label3_Click_1);
            this.lb_menuadmin.MouseEnter += new System.EventHandler(this.lb_menuadmin_MouseEnter);
            this.lb_menuadmin.MouseLeave += new System.EventHandler(this.lb_menuadmin_MouseLeave_1);
            // 
            // lb_menuped
            // 
            this.lb_menuped.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_menuped.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_menuped.Image = global::la_tinaja.Properties.Resources.Plato2;
            this.lb_menuped.Location = new System.Drawing.Point(619, 78);
            this.lb_menuped.Name = "lb_menuped";
            this.lb_menuped.Size = new System.Drawing.Size(161, 73);
            this.lb_menuped.TabIndex = 8;
            this.lb_menuped.Text = "PEDIDOS";
            this.lb_menuped.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_menuped.Click += new System.EventHandler(this.lb_menuped_Click);
            this.lb_menuped.MouseEnter += new System.EventHandler(this.lb_menuped_MouseEnter);
            this.lb_menuped.MouseLeave += new System.EventHandler(this.lb_menuped_MouseLeave);
            // 
            // fr_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1306, 750);
            this.ControlBox = false;
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.pt_usuario);
            this.Controls.Add(this.pt_menu);
            this.Controls.Add(this.lb_menupara);
            this.Controls.Add(this.lb_menuseg);
            this.Controls.Add(this.lb_menuadmin);
            this.Controls.Add(this.lb_menuped);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_fecha);
            this.Controls.Add(this.menuinicio);
            this.MainMenuStrip = this.menuinicio;
            this.Name = "fr_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fr_menu_Load);
            this.menuinicio.ResumeLayout(false);
            this.menuinicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt_menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tm_movimiento;
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pt_menu;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuinicio;
        private System.Windows.Forms.Label lb_menuped;
        private System.Windows.Forms.Label lb_menuadmin;
        private System.Windows.Forms.Label lb_menuseg;
        private System.Windows.Forms.Label lb_menupara;
        private System.Windows.Forms.Timer tm_hora;
        public System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.PictureBox pt_usuario;
    }
}