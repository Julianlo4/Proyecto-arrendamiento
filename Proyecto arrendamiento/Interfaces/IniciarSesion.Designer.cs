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
            this.MenuRegistroUsuario = new System.Windows.Forms.Label();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.lblQueSomos = new System.Windows.Forms.Label();
            this.pbxLogoIniciar = new System.Windows.Forms.PictureBox();
            this.lblTextoSupIniciar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPaginaPrincipal = new System.Windows.Forms.Label();
            this.btn_volverMenuPrincipal = new System.Windows.Forms.Button();
            this.btn_RegistrarUsuario = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txbNombreUsuario = new System.Windows.Forms.TextBox();
            this.txbClaveUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSugerenciaRegistro = new System.Windows.Forms.Label();
            this.pnlInicioSuperior = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoIniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlInicioSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuRegistroUsuario
            // 
            this.MenuRegistroUsuario.AutoSize = true;
            this.MenuRegistroUsuario.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuRegistroUsuario.ForeColor = System.Drawing.Color.LightCoral;
            this.MenuRegistroUsuario.Location = new System.Drawing.Point(3, 0);
            this.MenuRegistroUsuario.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.MenuRegistroUsuario.Name = "MenuRegistroUsuario";
            this.MenuRegistroUsuario.Size = new System.Drawing.Size(102, 35);
            this.MenuRegistroUsuario.TabIndex = 4;
            this.MenuRegistroUsuario.Text = "MENÚ";
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAyuda.Location = new System.Drawing.Point(3, 167);
            this.lblAyuda.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(69, 23);
            this.lblAyuda.TabIndex = 3;
            this.lblAyuda.Text = "Ayuda";
            // 
            // lblQueSomos
            // 
            this.lblQueSomos.AutoSize = true;
            this.lblQueSomos.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueSomos.ForeColor = System.Drawing.Color.LightCoral;
            this.lblQueSomos.Location = new System.Drawing.Point(3, 111);
            this.lblQueSomos.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblQueSomos.Name = "lblQueSomos";
            this.lblQueSomos.Size = new System.Drawing.Size(83, 46);
            this.lblQueSomos.TabIndex = 2;
            this.lblQueSomos.Text = "¿Qué somos?";
            // 
            // pbxLogoIniciar
            // 
            this.pbxLogoIniciar.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogoIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogoIniciar.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogoIniciar.Image")));
            this.pbxLogoIniciar.Location = new System.Drawing.Point(475, 96);
            this.pbxLogoIniciar.Name = "pbxLogoIniciar";
            this.pbxLogoIniciar.Size = new System.Drawing.Size(57, 54);
            this.pbxLogoIniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogoIniciar.TabIndex = 1;
            this.pbxLogoIniciar.TabStop = false;
            // 
            // lblTextoSupIniciar
            // 
            this.lblTextoSupIniciar.AutoSize = true;
            this.lblTextoSupIniciar.BackColor = System.Drawing.Color.Transparent;
            this.lblTextoSupIniciar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoSupIniciar.ForeColor = System.Drawing.Color.LightCoral;
            this.lblTextoSupIniciar.Location = new System.Drawing.Point(276, 113);
            this.lblTextoSupIniciar.Name = "lblTextoSupIniciar";
            this.lblTextoSupIniciar.Size = new System.Drawing.Size(173, 23);
            this.lblTextoSupIniciar.TabIndex = 0;
            this.lblTextoSupIniciar.Text = "INICIAR SESION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(218, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alojamientos Pacho";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.SkyBlue;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(694, 75);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pbLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 100);
            this.panel2.TabIndex = 2;
            // 
            // lblPaginaPrincipal
            // 
            this.lblPaginaPrincipal.AutoSize = true;
            this.lblPaginaPrincipal.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginaPrincipal.ForeColor = System.Drawing.Color.LightCoral;
            this.lblPaginaPrincipal.Location = new System.Drawing.Point(3, 55);
            this.lblPaginaPrincipal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblPaginaPrincipal.Name = "lblPaginaPrincipal";
            this.lblPaginaPrincipal.Size = new System.Drawing.Size(93, 46);
            this.lblPaginaPrincipal.TabIndex = 1;
            this.lblPaginaPrincipal.Text = "Página principal";
            // 
            // btn_volverMenuPrincipal
            // 
            this.btn_volverMenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btn_volverMenuPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_volverMenuPrincipal.BackgroundImage")));
            this.btn_volverMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_volverMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volverMenuPrincipal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_volverMenuPrincipal.Location = new System.Drawing.Point(136, 399);
            this.btn_volverMenuPrincipal.Name = "btn_volverMenuPrincipal";
            this.btn_volverMenuPrincipal.Size = new System.Drawing.Size(41, 36);
            this.btn_volverMenuPrincipal.TabIndex = 27;
            this.btn_volverMenuPrincipal.UseVisualStyleBackColor = false;
            this.btn_volverMenuPrincipal.Click += new System.EventHandler(this.btn_volverMenuPrincipal_Click_1);
            // 
            // btn_RegistrarUsuario
            // 
            this.btn_RegistrarUsuario.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_RegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RegistrarUsuario.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrarUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.btn_RegistrarUsuario.Location = new System.Drawing.Point(343, 390);
            this.btn_RegistrarUsuario.Name = "btn_RegistrarUsuario";
            this.btn_RegistrarUsuario.Size = new System.Drawing.Size(219, 34);
            this.btn_RegistrarUsuario.TabIndex = 26;
            this.btn_RegistrarUsuario.Text = "INICIAR SESION";
            this.btn_RegistrarUsuario.UseVisualStyleBackColor = false;
            this.btn_RegistrarUsuario.Click += new System.EventHandler(this.btn_RegistrarUsuario_Click_1);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.SkyBlue;
            this.panel5.Location = new System.Drawing.Point(121, 374);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(569, 10);
            this.panel5.TabIndex = 25;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.btn_RegistrarUsuario);
            this.pnlPrincipal.Controls.Add(this.tableLayoutPanel2);
            this.pnlPrincipal.Controls.Add(this.tableLayoutPanel1);
            this.pnlPrincipal.Controls.Add(this.btn_volverMenuPrincipal);
            this.pnlPrincipal.Controls.Add(this.panel5);
            this.pnlPrincipal.Controls.Add(this.lblSugerenciaRegistro);
            this.pnlPrincipal.Controls.Add(this.pnlInicioSuperior);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(694, 481);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.54448F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.45552F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txbNombreUsuario, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txbClaveUsuario, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblNombreUsuario, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblContrasenia, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(130, 153);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(564, 213);
            this.tableLayoutPanel2.TabIndex = 32;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(214, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(258, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // txbNombreUsuario
            // 
            this.txbNombreUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.txbNombreUsuario.Location = new System.Drawing.Point(214, 88);
            this.txbNombreUsuario.Name = "txbNombreUsuario";
            this.txbNombreUsuario.Size = new System.Drawing.Size(258, 33);
            this.txbNombreUsuario.TabIndex = 29;
            // 
            // txbClaveUsuario
            // 
            this.txbClaveUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.txbClaveUsuario.Location = new System.Drawing.Point(214, 151);
            this.txbClaveUsuario.Name = "txbClaveUsuario";
            this.txbClaveUsuario.Size = new System.Drawing.Size(258, 33);
            this.txbClaveUsuario.TabIndex = 30;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(10, 85);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(198, 25);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "Nombre de usuario:";
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.Location = new System.Drawing.Point(84, 148);
            this.lblContrasenia.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(124, 25);
            this.lblContrasenia.TabIndex = 5;
            this.lblContrasenia.Text = "Contraseña:";
            this.lblContrasenia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.PeachPuff;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.MenuRegistroUsuario, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQueSomos, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPaginaPrincipal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAyuda, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 153);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(130, 328);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // lblSugerenciaRegistro
            // 
            this.lblSugerenciaRegistro.AutoSize = true;
            this.lblSugerenciaRegistro.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.lblSugerenciaRegistro.Location = new System.Drawing.Point(110, 155);
            this.lblSugerenciaRegistro.Name = "lblSugerenciaRegistro";
            this.lblSugerenciaRegistro.Size = new System.Drawing.Size(0, 15);
            this.lblSugerenciaRegistro.TabIndex = 2;
            // 
            // pnlInicioSuperior
            // 
            this.pnlInicioSuperior.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlInicioSuperior.Controls.Add(this.panel2);
            this.pnlInicioSuperior.Controls.Add(this.pbxLogoIniciar);
            this.pnlInicioSuperior.Controls.Add(this.lblTextoSupIniciar);
            this.pnlInicioSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInicioSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlInicioSuperior.Name = "pnlInicioSuperior";
            this.pnlInicioSuperior.Size = new System.Drawing.Size(694, 153);
            this.pnlInicioSuperior.TabIndex = 1;
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 481);
            this.Controls.Add(this.pnlPrincipal);
            this.MinimumSize = new System.Drawing.Size(710, 520);
            this.Name = "IniciarSesion";
            this.Text = "IniciarSesion";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoIniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlInicioSuperior.ResumeLayout(false);
            this.pnlInicioSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label MenuRegistroUsuario;
        private Label lblAyuda;
        private Label lblQueSomos;
        private PictureBox pbxLogoIniciar;
        private Label lblTextoSupIniciar;
        private Label label2;
        private PictureBox pbLogo;
        private Panel panel2;
        private Label lblPaginaPrincipal;
        private Button btn_volverMenuPrincipal;
        private Button btn_RegistrarUsuario;
        private Panel panel5;
        private Panel pnlPrincipal;
        private Label lblContrasenia;
        private Label lblNombreUsuario;
        private Label lblSugerenciaRegistro;
        private Panel pnlInicioSuperior;
        private PictureBox pictureBox2;
        private TextBox txbClaveUsuario;
        private TextBox txbNombreUsuario;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}