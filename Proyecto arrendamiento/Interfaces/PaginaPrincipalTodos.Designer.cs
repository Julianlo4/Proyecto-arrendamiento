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
            this.tableLayoutPBarraBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrecioMinimo = new System.Windows.Forms.Label();
            this.lblUbicación = new System.Windows.Forms.Label();
            this.cbUbi = new System.Windows.Forms.ComboBox();
            this.lblusuarioBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tableLMenu = new System.Windows.Forms.TableLayoutPanel();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.pnlInicioSuperior = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pRegistro = new System.Windows.Forms.Panel();
            this.btn_RegistrarUsuarioMenu = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblSinCoinci = new System.Windows.Forms.Label();
            this.lblPrecioMaximo = new System.Windows.Forms.Label();
            this.lblTituloPubli = new System.Windows.Forms.Label();
            this.buscarTitulo = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtPrecioMinimo = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtPropietario = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtPrecioMaximo = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.pnlPrincipal.SuspendLayout();
            this.pnlContenedorPublicaciones.SuspendLayout();
            this.tableLayoutPBarraBusqueda.SuspendLayout();
            this.tableLMenu.SuspendLayout();
            this.pnlInicioSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
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
            this.pnlContenedorPublicaciones.Controls.Add(this.tableLayoutPBarraBusqueda);
            this.pnlContenedorPublicaciones.Controls.Add(this.lblSinCoinci);
            this.pnlContenedorPublicaciones.Controls.Add(this.flpPubs);
            this.pnlContenedorPublicaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorPublicaciones.Location = new System.Drawing.Point(0, 225);
            this.pnlContenedorPublicaciones.Name = "pnlContenedorPublicaciones";
            this.pnlContenedorPublicaciones.Size = new System.Drawing.Size(1017, 384);
            this.pnlContenedorPublicaciones.TabIndex = 25;
            // 
            // flpPubs
            // 
            this.flpPubs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPubs.Location = new System.Drawing.Point(0, 0);
            this.flpPubs.Name = "flpPubs";
            this.flpPubs.Size = new System.Drawing.Size(1017, 384);
            this.flpPubs.TabIndex = 0;
            this.flpPubs.Click += new System.EventHandler(this.flpPubs_Click);
            // 
            // tableLayoutPBarraBusqueda
            // 
            this.tableLayoutPBarraBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPBarraBusqueda.ColumnCount = 11;
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPBarraBusqueda.Controls.Add(this.buscarTitulo, 1, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.lblPrecioMinimo, 2, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.txtPrecioMinimo, 3, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.lblPrecioMaximo, 4, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.btnBuscar, 10, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.txtPropietario, 9, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.lblusuarioBuscar, 8, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.cbUbi, 7, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.lblUbicación, 6, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.txtPrecioMaximo, 5, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.lblTituloPubli, 0, 0);
            this.tableLayoutPBarraBusqueda.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPBarraBusqueda.Name = "tableLayoutPBarraBusqueda";
            this.tableLayoutPBarraBusqueda.RowCount = 1;
            this.tableLayoutPBarraBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPBarraBusqueda.Size = new System.Drawing.Size(1017, 50);
            this.tableLayoutPBarraBusqueda.TabIndex = 2;
            this.tableLayoutPBarraBusqueda.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPBarraBusqueda_Paint);
            // 
            // lblPrecioMinimo
            // 
            this.lblPrecioMinimo.AutoSize = true;
            this.lblPrecioMinimo.Location = new System.Drawing.Point(207, 0);
            this.lblPrecioMinimo.Name = "lblPrecioMinimo";
            this.lblPrecioMinimo.Size = new System.Drawing.Size(79, 13);
            this.lblPrecioMinimo.TabIndex = 2;
            this.lblPrecioMinimo.Text = "Precio minimo";
            // 
            // lblUbicación
            // 
            this.lblUbicación.AutoSize = true;
            this.lblUbicación.Location = new System.Drawing.Point(633, 0);
            this.lblUbicación.Name = "lblUbicación";
            this.lblUbicación.Size = new System.Drawing.Size(58, 13);
            this.lblUbicación.TabIndex = 4;
            this.lblUbicación.Text = "Ubicación";
            // 
            // cbUbi
            // 
            this.cbUbi.FormattingEnabled = true;
            this.cbUbi.Items.AddRange(new object[] {
            "Todo",
            "Centro",
            "Sur",
            "Norte",
            "Oriente",
            "Occidente"});
            this.cbUbi.Location = new System.Drawing.Point(702, 3);
            this.cbUbi.Name = "cbUbi";
            this.cbUbi.Size = new System.Drawing.Size(98, 21);
            this.cbUbi.TabIndex = 5;
            // 
            // lblusuarioBuscar
            // 
            this.lblusuarioBuscar.AutoSize = true;
            this.lblusuarioBuscar.Location = new System.Drawing.Point(806, 0);
            this.lblusuarioBuscar.Name = "lblusuarioBuscar";
            this.lblusuarioBuscar.Size = new System.Drawing.Size(64, 13);
            this.lblusuarioBuscar.TabIndex = 6;
            this.lblusuarioBuscar.Text = "Propietario";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(983, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(31, 41);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tableLMenu
            // 
            this.tableLMenu.BackColor = System.Drawing.Color.PeachPuff;
            this.tableLMenu.ColumnCount = 4;
            this.tableLMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLMenu.Controls.Add(this.lblIniciarSesion, 3, 0);
            this.tableLMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLMenu.Location = new System.Drawing.Point(0, 150);
            this.tableLMenu.Name = "tableLMenu";
            this.tableLMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLMenu.RowCount = 1;
            this.tableLMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLMenu.Size = new System.Drawing.Size(1017, 75);
            this.tableLMenu.TabIndex = 24;
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
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbLogo.BackColor = System.Drawing.Color.SkyBlue;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(450, 11);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(105, 75);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
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
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(195, 68);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // lblSinCoinci
            // 
            this.lblSinCoinci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSinCoinci.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinCoinci.Location = new System.Drawing.Point(0, 0);
            this.lblSinCoinci.Name = "lblSinCoinci";
            this.lblSinCoinci.Size = new System.Drawing.Size(1017, 384);
            this.lblSinCoinci.TabIndex = 0;
            this.lblSinCoinci.Text = "Sin coincidencias";
            this.lblSinCoinci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSinCoinci.Visible = false;
            // 
            // lblPrecioMaximo
            // 
            this.lblPrecioMaximo.AutoSize = true;
            this.lblPrecioMaximo.Location = new System.Drawing.Point(428, 0);
            this.lblPrecioMaximo.Name = "lblPrecioMaximo";
            this.lblPrecioMaximo.Size = new System.Drawing.Size(47, 26);
            this.lblPrecioMaximo.TabIndex = 9;
            this.lblPrecioMaximo.Text = "Precio Maximo";
            // 
            // lblTituloPubli
            // 
            this.lblTituloPubli.AutoSize = true;
            this.lblTituloPubli.Location = new System.Drawing.Point(3, 0);
            this.lblTituloPubli.Name = "lblTituloPubli";
            this.lblTituloPubli.Size = new System.Drawing.Size(27, 50);
            this.lblTituloPubli.TabIndex = 11;
            this.lblTituloPubli.Text = "Titulo Publicacion";
            // 
            // buscarTitulo
            // 
            this.buscarTitulo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buscarTitulo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.buscarTitulo.BorderRadius = 0;
            this.buscarTitulo.BorderSize = 2;
            this.buscarTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.buscarTitulo.Location = new System.Drawing.Point(38, 4);
            this.buscarTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.buscarTitulo.Multiline = false;
            this.buscarTitulo.Name = "buscarTitulo";
            this.buscarTitulo.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buscarTitulo.PasswordChar = false;
            this.buscarTitulo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.buscarTitulo.PlaceholderText = "";
            this.buscarTitulo.Size = new System.Drawing.Size(121, 28);
            this.buscarTitulo.TabIndex = 0;
            this.buscarTitulo.Texts = "";
            this.buscarTitulo.UnderlinedStyle = false;
            // 
            // txtPrecioMinimo
            // 
            this.txtPrecioMinimo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPrecioMinimo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPrecioMinimo.BorderRadius = 0;
            this.txtPrecioMinimo.BorderSize = 2;
            this.txtPrecioMinimo.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecioMinimo.Location = new System.Drawing.Point(297, 3);
            this.txtPrecioMinimo.Multiline = false;
            this.txtPrecioMinimo.Name = "txtPrecioMinimo";
            this.txtPrecioMinimo.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtPrecioMinimo.PasswordChar = false;
            this.txtPrecioMinimo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrecioMinimo.PlaceholderText = "";
            this.txtPrecioMinimo.Size = new System.Drawing.Size(93, 28);
            this.txtPrecioMinimo.TabIndex = 8;
            this.txtPrecioMinimo.Texts = "";
            this.txtPrecioMinimo.UnderlinedStyle = false;
            // 
            // txtPropietario
            // 
            this.txtPropietario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPropietario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPropietario.BorderRadius = 0;
            this.txtPropietario.BorderSize = 2;
            this.txtPropietario.ForeColor = System.Drawing.Color.DimGray;
            this.txtPropietario.Location = new System.Drawing.Point(880, 4);
            this.txtPropietario.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropietario.Multiline = false;
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtPropietario.PasswordChar = false;
            this.txtPropietario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPropietario.PlaceholderText = "";
            this.txtPropietario.Size = new System.Drawing.Size(77, 28);
            this.txtPropietario.TabIndex = 7;
            this.txtPropietario.Texts = "";
            this.txtPropietario.UnderlinedStyle = false;
            // 
            // txtPrecioMaximo
            // 
            this.txtPrecioMaximo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPrecioMaximo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPrecioMaximo.BorderRadius = 0;
            this.txtPrecioMaximo.BorderSize = 2;
            this.txtPrecioMaximo.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecioMaximo.Location = new System.Drawing.Point(482, 3);
            this.txtPrecioMaximo.Multiline = false;
            this.txtPrecioMaximo.Name = "txtPrecioMaximo";
            this.txtPrecioMaximo.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtPrecioMaximo.PasswordChar = false;
            this.txtPrecioMaximo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrecioMaximo.PlaceholderText = "";
            this.txtPrecioMaximo.Size = new System.Drawing.Size(104, 28);
            this.txtPrecioMaximo.TabIndex = 10;
            this.txtPrecioMaximo.Texts = "";
            this.txtPrecioMaximo.UnderlinedStyle = false;
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
            this.tableLayoutPBarraBusqueda.ResumeLayout(false);
            this.tableLayoutPBarraBusqueda.PerformLayout();
            this.tableLMenu.ResumeLayout(false);
            this.tableLMenu.PerformLayout();
            this.pnlInicioSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pRegistro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlPrincipal;
        private Panel pnlInicioSuperior;
        private PictureBox pbLogo;
        private Panel pRegistro;
        private Button btn_RegistrarUsuarioMenu;
        private PictureBox pbxLogo;
        private Label label2;
        private Panel pnlContenedorPublicaciones;
        private FlowLayoutPanel flpPubs;
        private TableLayoutPanel tableLayoutPBarraBusqueda;
        private Proyecto_arrendamiento.Apariencia.CustomTextBox buscarTitulo;
        private Button btnBuscar;
        private Label lblPrecioMinimo;
        private Label lblUbicación;
        private ComboBox cbUbi;
        private Label lblusuarioBuscar;
        private Proyecto_arrendamiento.Apariencia.CustomTextBox txtPropietario;
        private Label lblIniciarSesion;
        private TableLayoutPanel tableLMenu;
        private Label lblSinCoinci;
        private Proyecto_arrendamiento.Apariencia.CustomTextBox txtPrecioMinimo;
        private Label lblPrecioMaximo;
        private Proyecto_arrendamiento.Apariencia.CustomTextBox txtPrecioMaximo;
        private Label lblTituloPubli;
    }
}