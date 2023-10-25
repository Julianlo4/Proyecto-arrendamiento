using System.Drawing;
using System.Windows.Forms;

namespace ArriendoPrototipo.Interfaces
{
    partial class HomeUsuarioRegis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUsuarioRegis));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbnPreguntarArrendar = new System.Windows.Forms.Label();
            this.btnAgregarArriendo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInicioSuperior = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.lblQueSomos = new System.Windows.Forms.Label();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.MenuRegistroUsuario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlInicioSuperior.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblNombreUsuario);
            this.panel1.Controls.Add(this.lblBienvenido);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Location = new System.Drawing.Point(622, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 101);
            this.panel1.TabIndex = 5;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(18, 72);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(99, 26);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "USUARIO";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Franklin Gothic Heavy", 15.75F);
            this.lblBienvenido.ForeColor = System.Drawing.Color.White;
            this.lblBienvenido.Location = new System.Drawing.Point(3, 49);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(125, 26);
            this.lblBienvenido.TabIndex = 2;
            this.lblBienvenido.Text = "Bienvenid@";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(34, -7);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(57, 54);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.panel3);
            this.pnlPrincipal.Controls.Add(this.pnlInicioSuperior);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(746, 536);
            this.pnlPrincipal.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 387);
            this.panel3.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(204)))));
            this.panel4.Controls.Add(this.lbnPreguntarArrendar);
            this.panel4.Controls.Add(this.btnAgregarArriendo);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(106, 369);
            this.panel4.TabIndex = 24;
            // 
            // lbnPreguntarArrendar
            // 
            this.lbnPreguntarArrendar.AutoSize = true;
            this.lbnPreguntarArrendar.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F);
            this.lbnPreguntarArrendar.Location = new System.Drawing.Point(10, 192);
            this.lbnPreguntarArrendar.Name = "lbnPreguntarArrendar";
            this.lbnPreguntarArrendar.Size = new System.Drawing.Size(108, 156);
            this.lbnPreguntarArrendar.TabIndex = 7;
            this.lbnPreguntarArrendar.Text = "¿ Tienes un \r\ninmueble \r\npara \r\narrendar?\r\n¡ Registrarlo\r\naqui!";
            // 
            // btnAgregarArriendo
            // 
            this.btnAgregarArriendo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarArriendo.BackgroundImage")));
            this.btnAgregarArriendo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarArriendo.Location = new System.Drawing.Point(16, 109);
            this.btnAgregarArriendo.Name = "btnAgregarArriendo";
            this.btnAgregarArriendo.Size = new System.Drawing.Size(81, 63);
            this.btnAgregarArriendo.TabIndex = 6;
            this.btnAgregarArriendo.UseVisualStyleBackColor = true;
            this.btnAgregarArriendo.Click += new System.EventHandler(this.btnAgregarArriendo_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F);
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 72);
            this.label3.TabIndex = 5;
            this.label3.Text = "FUNCIONES \r\nUNICAS \r\nPARA TI";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(3, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(106, 9);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.label1.Location = new System.Drawing.Point(106, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 23;
            // 
            // pnlInicioSuperior
            // 
            this.pnlInicioSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(204)))));
            this.pnlInicioSuperior.Controls.Add(this.panel2);
            this.pnlInicioSuperior.Controls.Add(this.lblIniciarSesion);
            this.pnlInicioSuperior.Controls.Add(this.lblQueSomos);
            this.pnlInicioSuperior.Controls.Add(this.lblAyuda);
            this.pnlInicioSuperior.Controls.Add(this.MenuRegistroUsuario);
            this.pnlInicioSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlInicioSuperior.Name = "pnlInicioSuperior";
            this.pnlInicioSuperior.Size = new System.Drawing.Size(746, 153);
            this.pnlInicioSuperior.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 100);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(218, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alojamientos Pacho";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(309, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.lblIniciarSesion.Location = new System.Drawing.Point(331, 114);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(107, 20);
            this.lblIniciarSesion.TabIndex = 1;
            this.lblIniciarSesion.Text = "Configuracion";
            this.lblIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueSomos
            // 
            this.lblQueSomos.AutoSize = true;
            this.lblQueSomos.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblQueSomos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.lblQueSomos.Location = new System.Drawing.Point(136, 114);
            this.lblQueSomos.Name = "lblQueSomos";
            this.lblQueSomos.Size = new System.Drawing.Size(101, 20);
            this.lblQueSomos.TabIndex = 2;
            this.lblQueSomos.Text = "¿Qué somos?";
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.lblAyuda.Location = new System.Drawing.Point(262, 111);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(54, 20);
            this.lblAyuda.TabIndex = 3;
            this.lblAyuda.Text = "Ayuda";
            // 
            // MenuRegistroUsuario
            // 
            this.MenuRegistroUsuario.AutoSize = true;
            this.MenuRegistroUsuario.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 20.25F);
            this.MenuRegistroUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.MenuRegistroUsuario.Location = new System.Drawing.Point(13, 102);
            this.MenuRegistroUsuario.Name = "MenuRegistroUsuario";
            this.MenuRegistroUsuario.Size = new System.Drawing.Size(79, 34);
            this.MenuRegistroUsuario.TabIndex = 4;
            this.MenuRegistroUsuario.Text = "MENÚ";
            // 
            // HomeUsuarioRegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 536);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "HomeUsuarioRegis";
            this.Text = "HomeUsuarioRegis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlInicioSuperior.ResumeLayout(false);
            this.pnlInicioSuperior.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label lblNombreUsuario;
        private Label lblBienvenido;
        private PictureBox pbxLogo;
        private Panel pnlPrincipal;
        private Panel panel3;
        private Panel panel4;
        private Label label3;
        private Label lblQueSomos;
        private Label lblIniciarSesion;
        private Label lblAyuda;
        private Label MenuRegistroUsuario;
        private Panel panel5;
        private Label label1;
        private Panel pnlInicioSuperior;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lbnPreguntarArrendar;
        private Button btnAgregarArriendo;
    }
}