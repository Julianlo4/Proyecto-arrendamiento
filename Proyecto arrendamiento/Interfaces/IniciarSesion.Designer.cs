using System.Drawing;
using System.Windows.Forms;
using Proyecto_arrendamiento.Apariencia;

namespace ArriendoPrototipo.Interfaces
{
    partial class IniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
            panel3 = new Panel();
            MenuRegistroUsuario = new Label();
            lblAyuda = new Label();
            lblQueSomos = new Label();
            panel1 = new Panel();
            pbxLogo = new PictureBox();
            lblTextoSupIniciar = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblPaginaPrincipal = new Label();
            btn_volverMenuPrincipal = new Button();
            btn_RegistrarUsuario = new Button();
            panel5 = new Panel();
            panel4 = new Panel();
            pnlPrincipal = new Panel();
            pictureBox2 = new PictureBox();
            lblContrasenia = new Label();
            lblNombreUsuario = new Label();
            lblSugerenciaRegistro = new Label();
            pnlInicioSuperior = new Panel();
            pnlnicioDerecha = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlInicioSuperior.SuspendLayout();
            pnlnicioDerecha.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(0, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(127, 10);
            panel3.TabIndex = 5;
            // 
            // MenuRegistroUsuario
            // 
            MenuRegistroUsuario.AutoSize = true;
            MenuRegistroUsuario.Font = new Font("Franklin Gothic Demi Cond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            MenuRegistroUsuario.ForeColor = Color.LightCoral;
            MenuRegistroUsuario.Location = new Point(12, 13);
            MenuRegistroUsuario.Name = "MenuRegistroUsuario";
            MenuRegistroUsuario.Size = new Size(79, 34);
            MenuRegistroUsuario.TabIndex = 4;
            MenuRegistroUsuario.Text = "MENÚ";
            // 
            // lblAyuda
            // 
            lblAyuda.AutoSize = true;
            lblAyuda.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblAyuda.ForeColor = Color.FromArgb(254, 145, 147);
            lblAyuda.Location = new Point(28, 138);
            lblAyuda.Name = "lblAyuda";
            lblAyuda.Size = new Size(54, 20);
            lblAyuda.TabIndex = 3;
            lblAyuda.Text = "Ayuda";
            // 
            // lblQueSomos
            // 
            lblQueSomos.AutoSize = true;
            lblQueSomos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblQueSomos.ForeColor = Color.FromArgb(254, 145, 147);
            lblQueSomos.Location = new Point(12, 102);
            lblQueSomos.Name = "lblQueSomos";
            lblQueSomos.Size = new Size(101, 20);
            lblQueSomos.TabIndex = 2;
            lblQueSomos.Text = "¿Qué somos?";
            // 
            // panel1
            // 
            panel1.Location = new Point(123, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 332);
            panel1.TabIndex = 0;
            // 
            // pbxLogo
            // 
            pbxLogo.BackColor = Color.LightGoldenrodYellow;
            pbxLogo.BackgroundImageLayout = ImageLayout.None;
            pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
            pbxLogo.Location = new Point(520, 111);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(67, 62);
            pbxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogo.TabIndex = 1;
            pbxLogo.TabStop = false;
            // 
            // lblTextoSupIniciar
            // 
            lblTextoSupIniciar.AutoSize = true;
            lblTextoSupIniciar.Font = new Font("Bookman Old Style", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTextoSupIniciar.ForeColor = Color.FromArgb(254, 145, 147);
            lblTextoSupIniciar.Location = new Point(250, 129);
            lblTextoSupIniciar.Name = "lblTextoSupIniciar";
            lblTextoSupIniciar.Size = new Size(262, 35);
            lblTextoSupIniciar.TabIndex = 0;
            lblTextoSupIniciar.Text = "INICIAR SESION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(254, 73);
            label2.Name = "label2";
            label2.Size = new Size(314, 35);
            label2.TabIndex = 3;
            label2.Text = "Alojamientos Pacho";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(360, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 214, 215);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 115);
            panel2.TabIndex = 2;
            // 
            // lblPaginaPrincipal
            // 
            lblPaginaPrincipal.AutoSize = true;
            lblPaginaPrincipal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblPaginaPrincipal.ForeColor = Color.FromArgb(254, 145, 147);
            lblPaginaPrincipal.Location = new Point(2, 64);
            lblPaginaPrincipal.Name = "lblPaginaPrincipal";
            lblPaginaPrincipal.Size = new Size(120, 20);
            lblPaginaPrincipal.TabIndex = 1;
            lblPaginaPrincipal.Text = "Página principal";
            // 
            // btn_volverMenuPrincipal
            // 
            btn_volverMenuPrincipal.BackColor = Color.Transparent;
            //btn_volverMenuPrincipal.BackgroundImage = Resources.atras;
            btn_volverMenuPrincipal.BackgroundImageLayout = ImageLayout.Stretch;
            btn_volverMenuPrincipal.Cursor = Cursors.Hand;
            btn_volverMenuPrincipal.ImageAlign = ContentAlignment.TopCenter;
            btn_volverMenuPrincipal.Location = new Point(131, 482);
            btn_volverMenuPrincipal.Name = "btn_volverMenuPrincipal";
            btn_volverMenuPrincipal.Size = new Size(48, 42);
            btn_volverMenuPrincipal.TabIndex = 27;
            btn_volverMenuPrincipal.UseVisualStyleBackColor = false;
            btn_volverMenuPrincipal.Click += btn_volverMenuPrincipal_Click;
            // 
            // btn_RegistrarUsuario
            // 
            btn_RegistrarUsuario.BackColor = Color.Cyan;
            btn_RegistrarUsuario.Cursor = Cursors.Hand;
            btn_RegistrarUsuario.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btn_RegistrarUsuario.ForeColor = Color.Transparent;
            btn_RegistrarUsuario.Location = new Point(376, 461);
            btn_RegistrarUsuario.Name = "btn_RegistrarUsuario";
            btn_RegistrarUsuario.Size = new Size(190, 39);
            btn_RegistrarUsuario.TabIndex = 26;
            btn_RegistrarUsuario.Text = "REGISTRARSE";
            btn_RegistrarUsuario.UseVisualStyleBackColor = false;
            btn_RegistrarUsuario.Click += btn_RegistrarUsuario_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Cyan;
            panel5.Location = new Point(131, 431);
            panel5.Name = "panel5";
            panel5.Size = new Size(672, 10);
            panel5.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Cyan;
            panel4.Location = new Point(125, 184);
            panel4.Name = "panel4";
            panel4.Size = new Size(672, 10);
            panel4.TabIndex = 24;
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Controls.Add(pictureBox2);
            pnlPrincipal.Controls.Add(btn_volverMenuPrincipal);
            pnlPrincipal.Controls.Add(btn_RegistrarUsuario);
            pnlPrincipal.Controls.Add(panel5);
            pnlPrincipal.Controls.Add(panel4);
            pnlPrincipal.Controls.Add(lblContrasenia);
            pnlPrincipal.Controls.Add(lblNombreUsuario);
            pnlPrincipal.Controls.Add(lblSugerenciaRegistro);
            pnlPrincipal.Controls.Add(pnlInicioSuperior);
            pnlPrincipal.Controls.Add(pnlnicioDerecha);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            pnlPrincipal.Location = new Point(0, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(800, 545);
            pnlPrincipal.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(376, 200);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(183, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Font = new Font("Segoe UI", 15.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContrasenia.Location = new Point(276, 371);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(123, 30);
            lblContrasenia.TabIndex = 5;
            lblContrasenia.Text = "Contraseña:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuario.Location = new Point(223, 316);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(197, 30);
            lblNombreUsuario.TabIndex = 3;
            lblNombreUsuario.Text = "Nombre de usuario:";
            lblNombreUsuario.Click += lblPrimerNombre_Click;
            // 
            // lblSugerenciaRegistro
            // 
            lblSugerenciaRegistro.AutoSize = true;
            lblSugerenciaRegistro.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSugerenciaRegistro.Location = new Point(128, 179);
            lblSugerenciaRegistro.Name = "lblSugerenciaRegistro";
            lblSugerenciaRegistro.Size = new Size(0, 15);
            lblSugerenciaRegistro.TabIndex = 2;
            // 
            // pnlInicioSuperior
            // 
            pnlInicioSuperior.BackColor = Color.FromArgb(249, 243, 204);
            pnlInicioSuperior.Controls.Add(panel2);
            pnlInicioSuperior.Controls.Add(pbxLogo);
            pnlInicioSuperior.Controls.Add(lblTextoSupIniciar);
            pnlInicioSuperior.Dock = DockStyle.Top;
            pnlInicioSuperior.Location = new Point(0, 0);
            pnlInicioSuperior.Name = "pnlInicioSuperior";
            pnlInicioSuperior.Size = new Size(800, 176);
            pnlInicioSuperior.TabIndex = 1;
            // 
            // pnlnicioDerecha
            // 
            pnlnicioDerecha.BackColor = Color.FromArgb(249, 243, 204);
            pnlnicioDerecha.Controls.Add(panel3);
            pnlnicioDerecha.Controls.Add(MenuRegistroUsuario);
            pnlnicioDerecha.Controls.Add(lblAyuda);
            pnlnicioDerecha.Controls.Add(lblQueSomos);
            pnlnicioDerecha.Controls.Add(lblPaginaPrincipal);
            pnlnicioDerecha.Controls.Add(panel1);
            pnlnicioDerecha.Location = new Point(0, 168);
            pnlnicioDerecha.Name = "pnlnicioDerecha";
            pnlnicioDerecha.Size = new Size(125, 356);
            pnlnicioDerecha.TabIndex = 0;
            // 
            // IniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 545);
            Controls.Add(pnlPrincipal);
            Name = "IniciarSesion";
            Text = "IniciarSesion";
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlInicioSuperior.ResumeLayout(false);
            pnlInicioSuperior.PerformLayout();
            pnlnicioDerecha.ResumeLayout(false);
            pnlnicioDerecha.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label MenuRegistroUsuario;
        private Label lblAyuda;
        private Label lblQueSomos;
        private Panel panel1;
        private PictureBox pbxLogo;
        private Label lblTextoSupIniciar;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label lblPaginaPrincipal;
        private Button btn_volverMenuPrincipal;
        private Button btn_RegistrarUsuario;
        private Panel panel5;
        private Panel panel4;
        private Panel pnlPrincipal;
        private Label lblContrasenia;
        private Label lblNombreUsuario;
        private Label lblSugerenciaRegistro;
        private Panel pnlInicioSuperior;
        private Panel pnlnicioDerecha;
        private PictureBox pictureBox2;
    }
}