namespace Proyecto_arrendamiento.Interfaces
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.lblPubTitulo = new System.Windows.Forms.Label();
            this.lblubUbicacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxPubImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPubImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPubTitulo
            // 
            this.lblPubTitulo.AutoSize = true;
            this.lblPubTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPubTitulo.Location = new System.Drawing.Point(3, 266);
            this.lblPubTitulo.Name = "lblPubTitulo";
            this.lblPubTitulo.Size = new System.Drawing.Size(185, 22);
            this.lblPubTitulo.TabIndex = 7;
            this.lblPubTitulo.Text = "Hermosa casa 2 pisos";
            // 
            // lblubUbicacion
            // 
            this.lblubUbicacion.AutoSize = true;
            this.lblubUbicacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblubUbicacion.Location = new System.Drawing.Point(3, 301);
            this.lblubUbicacion.Name = "lblubUbicacion";
            this.lblubUbicacion.Size = new System.Drawing.Size(131, 20);
            this.lblubUbicacion.TabIndex = 5;
            this.lblubUbicacion.Text = "Norte, Popayán1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "$500mil-Mensual";
            // 
            // pbxPubImagen
            // 
            this.pbxPubImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPubImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxPubImagen.Image = ((System.Drawing.Image)(resources.GetObject("pbxPubImagen.Image")));
            this.pbxPubImagen.Location = new System.Drawing.Point(0, 0);
            this.pbxPubImagen.Name = "pbxPubImagen";
            this.pbxPubImagen.Size = new System.Drawing.Size(283, 263);
            this.pbxPubImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPubImagen.TabIndex = 4;
            this.pbxPubImagen.TabStop = false;
            this.pbxPubImagen.Click += new System.EventHandler(this.pbxPubImagen_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPubTitulo);
            this.Controls.Add(this.lblubUbicacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxPubImagen);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(283, 371);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPubImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPubImagen;
        private System.Windows.Forms.Label lblPubTitulo;
        private System.Windows.Forms.Label lblubUbicacion;
        private System.Windows.Forms.Label label1;
    }
}
