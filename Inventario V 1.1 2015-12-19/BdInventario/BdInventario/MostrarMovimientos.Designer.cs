namespace BdInventario
{
    partial class MostrarMovimientos
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
            this.lb_mostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_mostrar
            // 
            this.lb_mostrar.AutoSize = true;
            this.lb_mostrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mostrar.Location = new System.Drawing.Point(12, 9);
            this.lb_mostrar.Name = "lb_mostrar";
            this.lb_mostrar.Size = new System.Drawing.Size(53, 19);
            this.lb_mostrar.TabIndex = 0;
            this.lb_mostrar.Text = "label1";
            // 
            // MostrarMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 530);
            this.Controls.Add(this.lb_mostrar);
            this.Name = "MostrarMovimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_mostrar;

    }
}