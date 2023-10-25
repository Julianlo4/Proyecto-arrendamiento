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
            panel1 = new Panel();
            lblNombreUsuario = new Label();
            lblBienvenido = new Label();
            pbxLogo = new PictureBox();
            pnlPrincipal = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label3 = new Label();
            lblQueSomos = new Label();
            lblIniciarSesion = new Label();
            lblAyuda = new Label();
            MenuRegistroUsuario = new Label();
            panel5 = new Panel();
            label1 = new Label();
            pnlInicioSuperior = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnAgregarArriendo = new Button();
            lbnPreguntarArrendar = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            pnlPrincipal.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            pnlInicioSuperior.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(lblNombreUsuario);
            panel1.Controls.Add(lblBienvenido);
            panel1.Controls.Add(pbxLogo);
            panel1.Location = new Point(726, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(133, 116);
            panel1.TabIndex = 5;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Franklin Gothic Book", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreUsuario.ForeColor = Color.White;
            lblNombreUsuario.Location = new Point(21, 83);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(99, 26);
            lblNombreUsuario.TabIndex = 3;
            lblNombreUsuario.Text = "USUARIO";
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Franklin Gothic Heavy", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBienvenido.ForeColor = Color.White;
            lblBienvenido.Location = new Point(4, 57);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(125, 26);
            lblBienvenido.TabIndex = 2;
            lblBienvenido.Text = "Bienvenid@";
            lblBienvenido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbxLogo
            // 
            pbxLogo.BackColor = Color.FromArgb(192, 255, 192);
            pbxLogo.BackgroundImageLayout = ImageLayout.None;
            pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
            pbxLogo.Location = new Point(40, -8);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(67, 62);
            pbxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLogo.TabIndex = 1;
            pbxLogo.TabStop = false;
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Controls.Add(panel3);
            pnlPrincipal.Controls.Add(pnlInicioSuperior);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            pnlPrincipal.Location = new Point(0, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(854, 619);
            pnlPrincipal.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 168);
            panel3.Name = "panel3";
            panel3.Size = new Size(858, 429);
            panel3.TabIndex = 24;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(249, 243, 204);
            panel4.Controls.Add(lbnPreguntarArrendar);
            panel4.Controls.Add(btnAgregarArriendo);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(124, 426);
            panel4.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 11);
            label3.Name = "label3";
            label3.Size = new Size(99, 72);
            label3.TabIndex = 5;
            label3.Text = "FUNCIONES \r\nUNICAS \r\nPARA TI";
            // 
            // lblQueSomos
            // 
            lblQueSomos.AutoSize = true;
            lblQueSomos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblQueSomos.ForeColor = Color.FromArgb(254, 145, 147);
            lblQueSomos.Location = new Point(159, 132);
            lblQueSomos.Name = "lblQueSomos";
            lblQueSomos.Size = new Size(101, 20);
            lblQueSomos.TabIndex = 2;
            lblQueSomos.Text = "¿Qué somos?";
            // 
            // lblIniciarSesion
            // 
            lblIniciarSesion.AutoSize = true;
            lblIniciarSesion.Cursor = Cursors.Hand;
            lblIniciarSesion.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblIniciarSesion.ForeColor = Color.FromArgb(254, 145, 147);
            lblIniciarSesion.Location = new Point(386, 132);
            lblIniciarSesion.Name = "lblIniciarSesion";
            lblIniciarSesion.Size = new Size(107, 20);
            lblIniciarSesion.TabIndex = 1;
            lblIniciarSesion.Text = "Configuracion";
            lblIniciarSesion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAyuda
            // 
            lblAyuda.AutoSize = true;
            lblAyuda.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblAyuda.ForeColor = Color.FromArgb(254, 145, 147);
            lblAyuda.Location = new Point(306, 128);
            lblAyuda.Name = "lblAyuda";
            lblAyuda.Size = new Size(54, 20);
            lblAyuda.TabIndex = 3;
            lblAyuda.Text = "Ayuda";
            // 
            // MenuRegistroUsuario
            // 
            MenuRegistroUsuario.AutoSize = true;
            MenuRegistroUsuario.Font = new Font("Franklin Gothic Demi Cond", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            MenuRegistroUsuario.ForeColor = Color.FromArgb(254, 145, 147);
            MenuRegistroUsuario.Location = new Point(15, 118);
            MenuRegistroUsuario.Name = "MenuRegistroUsuario";
            MenuRegistroUsuario.Size = new Size(79, 34);
            MenuRegistroUsuario.TabIndex = 4;
            MenuRegistroUsuario.Text = "MENÚ";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(3, 86);
            panel5.Name = "panel5";
            panel5.Size = new Size(124, 10);
            panel5.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(124, 11);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 23;
            // 
            // pnlInicioSuperior
            // 
            pnlInicioSuperior.BackColor = Color.FromArgb(249, 243, 204);
            pnlInicioSuperior.Controls.Add(panel2);
            pnlInicioSuperior.Controls.Add(lblIniciarSesion);
            pnlInicioSuperior.Controls.Add(lblQueSomos);
            pnlInicioSuperior.Controls.Add(lblAyuda);
            pnlInicioSuperior.Controls.Add(MenuRegistroUsuario);
            pnlInicioSuperior.Location = new Point(0, 0);
            pnlInicioSuperior.Name = "pnlInicioSuperior";
            pnlInicioSuperior.Size = new Size(858, 176);
            pnlInicioSuperior.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 214, 215);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(858, 115);
            panel2.TabIndex = 2;
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
            // btnAgregarArriendo
            // 
            btnAgregarArriendo.BackgroundImage = (Image)resources.GetObject("btnAgregarArriendo.BackgroundImage");
            btnAgregarArriendo.BackgroundImageLayout = ImageLayout.Zoom;
            btnAgregarArriendo.Location = new Point(19, 126);
            btnAgregarArriendo.Name = "btnAgregarArriendo";
            btnAgregarArriendo.Size = new Size(94, 73);
            btnAgregarArriendo.TabIndex = 6;
            btnAgregarArriendo.UseVisualStyleBackColor = true;
            btnAgregarArriendo.Click += btnAgregarArriendo_Click;
            // 
            // lbnPreguntarArrendar
            // 
            lbnPreguntarArrendar.AutoSize = true;
            lbnPreguntarArrendar.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbnPreguntarArrendar.Location = new Point(12, 222);
            lbnPreguntarArrendar.Name = "lbnPreguntarArrendar";
            lbnPreguntarArrendar.Size = new Size(108, 156);
            lbnPreguntarArrendar.TabIndex = 7;
            lbnPreguntarArrendar.Text = "¿ Tienes un \r\ninmueble \r\npara \r\narrendar?\r\n¡ Registrarlo\r\naqui!";
            // 
            // HomeUsuarioRegis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 619);
            Controls.Add(pnlPrincipal);
            Name = "HomeUsuarioRegis";
            Text = "HomeUsuarioRegis";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            pnlPrincipal.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            pnlInicioSuperior.ResumeLayout(false);
            pnlInicioSuperior.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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