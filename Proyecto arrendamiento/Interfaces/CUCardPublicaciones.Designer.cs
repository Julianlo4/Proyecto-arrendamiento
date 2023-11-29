namespace Proyecto_arrendamiento.Interfaces
{
    partial class CUCardPublicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CUCardPublicaciones));
            this.lblubUbicacion = new System.Windows.Forms.Label();
            this.lblPrecioPub = new System.Windows.Forms.Label();
            this.lblPubTitulo = new System.Windows.Forms.Label();
            this.pnlContainerCardPub = new System.Windows.Forms.Panel();
            this.pbxPubImagen = new System.Windows.Forms.PictureBox();
            this.pnlContainerCardPub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPubImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblubUbicacion
            // 
            this.lblubUbicacion.AutoSize = true;
            this.lblubUbicacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblubUbicacion.Location = new System.Drawing.Point(3, 301);
            this.lblubUbicacion.Name = "lblubUbicacion";
            this.lblubUbicacion.Size = new System.Drawing.Size(0, 20);
            this.lblubUbicacion.TabIndex = 1;
            // 
            // lblPrecioPub
            // 
            this.lblPrecioPub.AutoSize = true;
            this.lblPrecioPub.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioPub.Location = new System.Drawing.Point(3, 331);
            this.lblPrecioPub.Name = "lblPrecioPub";
            this.lblPrecioPub.Size = new System.Drawing.Size(0, 19);
            this.lblPrecioPub.TabIndex = 2;
            this.lblPrecioPub.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPubTitulo
            // 
            this.lblPubTitulo.AutoSize = true;
            this.lblPubTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPubTitulo.Location = new System.Drawing.Point(3, 266);
            this.lblPubTitulo.Name = "lblPubTitulo";
            this.lblPubTitulo.Size = new System.Drawing.Size(0, 22);
            this.lblPubTitulo.TabIndex = 3;
            this.lblPubTitulo.Click += new System.EventHandler(this.lblPubTitulo_Click);
            // 
            // pnlContainerCardPub
            // 
            this.pnlContainerCardPub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlContainerCardPub.Controls.Add(this.lblPrecioPub);
            this.pnlContainerCardPub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainerCardPub.Location = new System.Drawing.Point(0, 0);
            this.pnlContainerCardPub.Name = "pnlContainerCardPub";
            this.pnlContainerCardPub.Size = new System.Drawing.Size(283, 371);
            this.pnlContainerCardPub.TabIndex = 4;
            this.pnlContainerCardPub.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainerCardPub_Paint);
            // 
            // pbxPubImagen
            // 
            this.pbxPubImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxPubImagen.Image = ((System.Drawing.Image)(resources.GetObject("pbxPubImagen.Image")));
            this.pbxPubImagen.Location = new System.Drawing.Point(0, 0);
            this.pbxPubImagen.Name = "pbxPubImagen";
            this.pbxPubImagen.Size = new System.Drawing.Size(283, 263);
            this.pbxPubImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPubImagen.TabIndex = 0;
            this.pbxPubImagen.TabStop = false;
            this.pbxPubImagen.Click += new System.EventHandler(this.pbxPubImagen_Click);
            // 
            // CUCardPublicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbxPubImagen);
            this.Controls.Add(this.lblPubTitulo);
            this.Controls.Add(this.lblubUbicacion);
            this.Controls.Add(this.pnlContainerCardPub);
            this.Name = "CUCardPublicaciones";
            this.Size = new System.Drawing.Size(283, 371);
            this.pnlContainerCardPub.ResumeLayout(false);
            this.pnlContainerCardPub.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPubImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbxPubImagen;
        public System.Windows.Forms.Label lblubUbicacion;
        public System.Windows.Forms.Label lblPrecioPub;
        public System.Windows.Forms.Label lblPubTitulo;
        private System.Windows.Forms.Panel pnlContainerCardPub;
    }
}
