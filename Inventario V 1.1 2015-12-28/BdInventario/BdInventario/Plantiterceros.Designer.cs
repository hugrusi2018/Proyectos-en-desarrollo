namespace BdInventario
{
    partial class Plantiterceros
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.cmdcerrar = new System.Windows.Forms.Button();
            this.lblcentral = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltitulo.BackColor = System.Drawing.Color.Yellow;
            this.lbltitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltitulo.Location = new System.Drawing.Point(5, 9);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(507, 62);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Texto aquí";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdcerrar
            // 
            this.cmdcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdcerrar.ForeColor = System.Drawing.Color.Red;
            this.cmdcerrar.Image = global::BdInventario.Properties.Resources.anterior;
            this.cmdcerrar.Location = new System.Drawing.Point(513, 9);
            this.cmdcerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdcerrar.Name = "cmdcerrar";
            this.cmdcerrar.Size = new System.Drawing.Size(65, 62);
            this.cmdcerrar.TabIndex = 14;
            this.toolTip1.SetToolTip(this.cmdcerrar, "Atras");
            this.cmdcerrar.UseVisualStyleBackColor = true;
            // 
            // lblcentral
            // 
            this.lblcentral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblcentral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcentral.Location = new System.Drawing.Point(5, 76);
            this.lblcentral.Name = "lblcentral";
            this.lblcentral.Size = new System.Drawing.Size(573, 319);
            this.lblcentral.TabIndex = 15;
            this.lblcentral.Click += new System.EventHandler(this.lblcentral_Click);
            // 
            // Plantiterceros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(582, 400);
            this.ControlBox = false;
            this.Controls.Add(this.lblcentral);
            this.Controls.Add(this.cmdcerrar);
            this.Controls.Add(this.lbltitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Plantiterceros";
            this.Text = "Plantiterceros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Plantiterceros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lbltitulo;
        protected System.Windows.Forms.Button cmdcerrar;
        protected System.Windows.Forms.Label lblcentral;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}