using System.Drawing;
using System.Windows.Forms;

namespace ArriendoPrototipo.Interfaces
{
    partial class PaginaPrincipalTodos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipalTodos));
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlContenedorPublicaciones = new System.Windows.Forms.Panel();
            this.flpPubs = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLMenu = new System.Windows.Forms.TableLayoutPanel();
            this.MenuRegistroUsuario = new System.Windows.Forms.Label();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.lblQueSomos = new System.Windows.Forms.Label();
            this.pnlInicioSuperior = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pRegistro = new System.Windows.Forms.Panel();
            this.btn_RegistrarUsuarioMenu = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPBarraBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.customTextBox1 = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblUbicación = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblusuarioBuscar = new System.Windows.Forms.Label();
            this.customTextBox2 = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.pnlPrincipal.SuspendLayout();
            this.pnlContenedorPublicaciones.SuspendLayout();
            this.tableLMenu.SuspendLayout();
            this.pnlInicioSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.tableLayoutPBarraBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlContenedorPublicaciones);
            this.pnlPrincipal.Controls.Add(this.tableLMenu);
            this.pnlPrincipal.Controls.Add(this.pnlInicioSuperior);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1017, 609);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // pnlContenedorPublicaciones
            // 
            this.pnlContenedorPublicaciones.Controls.Add(this.flpPubs);
            this.pnlContenedorPublicaciones.Controls.Add(this.tableLayoutPBarraBusqueda);
            this.pnlContenedorPublicaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorPublicaciones.Location = new System.Drawing.Point(0, 225);
            this.pnlContenedorPublicaciones.Name = "pnlContenedorPublicaciones";
            this.pnlContenedorPublicaciones.Size = new System.Drawing.Size(1017, 384);
            this.pnlContenedorPublicaciones.TabIndex = 25;
            // 
            // flpPubs
            // 
            this.flpPubs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPubs.Location = new System.Drawing.Point(0, 50);
            this.flpPubs.Name = "flpPubs";
            this.flpPubs.Size = new System.Drawing.Size(1017, 334);
            this.flpPubs.TabIndex = 0;
            // 
            // tableLMenu
            // 
            this.tableLMenu.BackColor = System.Drawing.Color.PeachPuff;
            this.tableLMenu.ColumnCount = 4;
            this.tableLMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLMenu.Controls.Add(this.MenuRegistroUsuario, 0, 0);
            this.tableLMenu.Controls.Add(this.lblIniciarSesion, 3, 0);
            this.tableLMenu.Controls.Add(this.lblAyuda, 2, 0);
            this.tableLMenu.Controls.Add(this.lblQueSomos, 1, 0);
            this.tableLMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLMenu.Location = new System.Drawing.Point(0, 150);
            this.tableLMenu.Name = "tableLMenu";
            this.tableLMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLMenu.RowCount = 1;
            this.tableLMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLMenu.Size = new System.Drawing.Size(1017, 75);
            this.tableLMenu.TabIndex = 24;
            this.tableLMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // MenuRegistroUsuario
            // 
            this.MenuRegistroUsuario.AutoSize = true;
            this.MenuRegistroUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuRegistroUsuario.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuRegistroUsuario.ForeColor = System.Drawing.Color.LightCoral;
            this.MenuRegistroUsuario.Location = new System.Drawing.Point(3, 0);
            this.MenuRegistroUsuario.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.MenuRegistroUsuario.Name = "MenuRegistroUsuario";
            this.MenuRegistroUsuario.Size = new System.Drawing.Size(102, 75);
            this.MenuRegistroUsuario.TabIndex = 4;
            this.MenuRegistroUsuario.Text = "MENÚ";
            this.MenuRegistroUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIniciarSesion.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.ForeColor = System.Drawing.Color.LightCoral;
            this.lblIniciarSesion.Location = new System.Drawing.Point(818, 0);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(196, 75);
            this.lblIniciarSesion.TabIndex = 1;
            this.lblIniciarSesion.Text = "¿ Ya tienes cuenta?\r\nIniciar Sesión";
            this.lblIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIniciarSesion.Click += new System.EventHandler(this.lblIniciarSesion_Click_1);
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAyuda.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAyuda.Location = new System.Drawing.Point(289, 0);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(69, 75);
            this.lblAyuda.TabIndex = 3;
            this.lblAyuda.Text = "Ayuda";
            this.lblAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQueSomos
            // 
            this.lblQueSomos.AutoSize = true;
            this.lblQueSomos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQueSomos.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueSomos.ForeColor = System.Drawing.Color.LightCoral;
            this.lblQueSomos.Location = new System.Drawing.Point(128, 0);
            this.lblQueSomos.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.lblQueSomos.Name = "lblQueSomos";
            this.lblQueSomos.Size = new System.Drawing.Size(138, 75);
            this.lblQueSomos.TabIndex = 2;
            this.lblQueSomos.Text = "¿Qué somos?";
            this.lblQueSomos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInicioSuperior
            // 
            this.pnlInicioSuperior.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlInicioSuperior.Controls.Add(this.label2);
            this.pnlInicioSuperior.Controls.Add(this.pbLogo);
            this.pnlInicioSuperior.Controls.Add(this.pRegistro);
            this.pnlInicioSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInicioSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlInicioSuperior.Name = "pnlInicioSuperior";
            this.pnlInicioSuperior.Size = new System.Drawing.Size(1017, 150);
            this.pnlInicioSuperior.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(326, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 75);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alojamientos Pacho";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbLogo.BackColor = System.Drawing.Color.SkyBlue;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLogo.Image = global::Proyecto_arrendamiento.Properties.Resources.logoArrendamiento;
            this.pbLogo.Location = new System.Drawing.Point(450, 11);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(105, 75);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // pRegistro
            // 
            this.pRegistro.BackColor = System.Drawing.Color.Salmon;
            this.pRegistro.Controls.Add(this.btn_RegistrarUsuarioMenu);
            this.pRegistro.Controls.Add(this.pbxLogo);
            this.pRegistro.Dock = System.Windows.Forms.DockStyle.Right;
            this.pRegistro.Location = new System.Drawing.Point(822, 0);
            this.pRegistro.Name = "pRegistro";
            this.pRegistro.Size = new System.Drawing.Size(195, 150);
            this.pRegistro.TabIndex = 5;
            // 
            // btn_RegistrarUsuarioMenu
            // 
            this.btn_RegistrarUsuarioMenu.BackColor = System.Drawing.Color.Salmon;
            this.btn_RegistrarUsuarioMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_RegistrarUsuarioMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RegistrarUsuarioMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_RegistrarUsuarioMenu.FlatAppearance.BorderSize = 0;
            this.btn_RegistrarUsuarioMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrarUsuarioMenu.ForeColor = System.Drawing.Color.White;
            this.btn_RegistrarUsuarioMenu.Location = new System.Drawing.Point(0, 68);
            this.btn_RegistrarUsuarioMenu.Name = "btn_RegistrarUsuarioMenu";
            this.btn_RegistrarUsuarioMenu.Size = new System.Drawing.Size(195, 76);
            this.btn_RegistrarUsuarioMenu.TabIndex = 2;
            this.btn_RegistrarUsuarioMenu.Text = "¿ Con animo de \r\ntomar o arrendar\r\nuna casa?\r\n¡REGISTRATE!";
            this.btn_RegistrarUsuarioMenu.UseVisualStyleBackColor = false;
            this.btn_RegistrarUsuarioMenu.Click += new System.EventHandler(this.btn_RegistrarUsuarioMenu_Click_1);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxLogo.Image = global::Proyecto_arrendamiento.Properties.Resources.LogoUsuario;
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(195, 68);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // tableLayoutPBarraBusqueda
            // 
            this.tableLayoutPBarraBusqueda.ColumnCount = 9;
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPBarraBusqueda.Controls.Add(this.customTextBox1, 1, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.btnBuscar, 2, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.lblPrecio, 3, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.trackBar1, 4, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.lblUbicación, 5, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.comboBox1, 6, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.lblusuarioBuscar, 7, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.customTextBox2, 8, 0);
            this.tableLayoutPBarraBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPBarraBusqueda.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPBarraBusqueda.Name = "tableLayoutPBarraBusqueda";
            this.tableLayoutPBarraBusqueda.RowCount = 1;
            this.tableLayoutPBarraBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPBarraBusqueda.Size = new System.Drawing.Size(1017, 50);
            this.tableLayoutPBarraBusqueda.TabIndex = 2;
            // 
            // customTextBox1
            // 
            this.customTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox1.BorderRadius = 0;
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox1.Location = new System.Drawing.Point(53, 3);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.Size = new System.Drawing.Size(247, 29);
            this.customTextBox1.TabIndex = 0;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(306, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 41);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(372, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(38, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(425, 3);
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(181, 44);
            this.trackBar1.SmallChange = 2;
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickFrequency = 2;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 5;
            // 
            // lblUbicación
            // 
            this.lblUbicación.AutoSize = true;
            this.lblUbicación.Location = new System.Drawing.Point(612, 0);
            this.lblUbicación.Name = "lblUbicación";
            this.lblUbicación.Size = new System.Drawing.Size(58, 13);
            this.lblUbicación.TabIndex = 4;
            this.lblUbicación.Text = "Ubicación";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(679, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // lblusuarioBuscar
            // 
            this.lblusuarioBuscar.AutoSize = true;
            this.lblusuarioBuscar.Location = new System.Drawing.Point(805, 0);
            this.lblusuarioBuscar.Name = "lblusuarioBuscar";
            this.lblusuarioBuscar.Size = new System.Drawing.Size(47, 13);
            this.lblusuarioBuscar.TabIndex = 6;
            this.lblusuarioBuscar.Text = "Usuario";
            // 
            // customTextBox2
            // 
            this.customTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox2.BorderRadius = 0;
            this.customTextBox2.BorderSize = 2;
            this.customTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox2.Location = new System.Drawing.Point(915, 3);
            this.customTextBox2.Multiline = false;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.customTextBox2.PasswordChar = false;
            this.customTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox2.PlaceholderText = "";
            this.customTextBox2.Size = new System.Drawing.Size(99, 29);
            this.customTextBox2.TabIndex = 7;
            this.customTextBox2.Texts = "";
            this.customTextBox2.UnderlinedStyle = false;
            // 
            // PaginaPrincipalTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 609);
            this.Controls.Add(this.pnlPrincipal);
            this.MinimumSize = new System.Drawing.Size(750, 591);
            this.Name = "PaginaPrincipalTodos";
            this.Text = "Alojamientos Pacho home";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlContenedorPublicaciones.ResumeLayout(false);
            this.tableLMenu.ResumeLayout(false);
            this.tableLMenu.PerformLayout();
            this.pnlInicioSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pRegistro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.tableLayoutPBarraBusqueda.ResumeLayout(false);
            this.tableLayoutPBarraBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlPrincipal;
        private Panel pnlInicioSuperior;
        private PictureBox pbLogo;
        private Panel pRegistro;
        private Button btn_RegistrarUsuarioMenu;
        private PictureBox pbxLogo;
        private TableLayoutPanel tableLMenu;
        private Label label2;
        private Panel pnlContenedorPublicaciones;
        private FlowLayoutPanel flpPubs;
        private Label MenuRegistroUsuario;
        private Label lblIniciarSesion;
        private Label lblAyuda;
        private Label lblQueSomos;
        private TableLayoutPanel tableLayoutPBarraBusqueda;
        private Proyecto_arrendamiento.Apariencia.CustomTextBox customTextBox1;
        private Button btnBuscar;
        private Label lblPrecio;
        private TrackBar trackBar1;
        private Label lblUbicación;
        private ComboBox comboBox1;
        private Label lblusuarioBuscar;
        private Proyecto_arrendamiento.Apariencia.CustomTextBox customTextBox2;
    }
}