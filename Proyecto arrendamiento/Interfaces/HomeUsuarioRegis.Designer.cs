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
            this.pnlContenedorPublicaciones = new System.Windows.Forms.Panel();
            this.tableLayoutPMenuLateral = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarArriendo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbnPreguntarArrendar = new System.Windows.Forms.Label();
            this.btnPublicaciones = new System.Windows.Forms.Button();
            this.lbnPublicaciones = new System.Windows.Forms.Label();
            this.tableLayoutPMenuTop = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbConfigurar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlInicioSuperior = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flpPubs = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSinCoinci = new System.Windows.Forms.Label();
            this.tableLayoutPBarraBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.buscarTitulo = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.lblPrecioMinimo = new System.Windows.Forms.Label();
            this.txtPrecioMinimo = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.lblPrecioMaximo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPropietario = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.lblusuarioBuscar = new System.Windows.Forms.Label();
            this.cbUbi = new System.Windows.Forms.ComboBox();
            this.lblUbicación = new System.Windows.Forms.Label();
            this.txtPrecioMaximo = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.lblTituloPubli = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.pnlContenedorPublicaciones.SuspendLayout();
            this.tableLayoutPMenuLateral.SuspendLayout();
            this.tableLayoutPMenuTop.SuspendLayout();
            this.pnlInicioSuperior.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPBarraBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.lblNombreUsuario);
            this.panel1.Controls.Add(this.lblBienvenido);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(802, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 141);
            this.panel1.TabIndex = 5;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(23, 113);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(101, 23);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "USUARIO";
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.White;
            this.lblBienvenido.Location = new System.Drawing.Point(23, 90);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(121, 23);
            this.lblBienvenido.TabIndex = 2;
            this.lblBienvenido.Text = "Bienvenid@";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBienvenido.Click += new System.EventHandler(this.lblBienvenido_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.PaleGreen;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(158, 76);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.pbxLogo_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.tableLayoutPBarraBusqueda);
            this.pnlPrincipal.Controls.Add(this.pnlContenedorPublicaciones);
            this.pnlPrincipal.Controls.Add(this.tableLayoutPMenuLateral);
            this.pnlPrincipal.Controls.Add(this.tableLayoutPMenuTop);
            this.pnlPrincipal.Controls.Add(this.pnlInicioSuperior);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(960, 665);
            this.pnlPrincipal.TabIndex = 4;
            // 
            // pnlContenedorPublicaciones
            // 
            this.pnlContenedorPublicaciones.Controls.Add(this.lblSinCoinci);
            this.pnlContenedorPublicaciones.Controls.Add(this.flpPubs);
            this.pnlContenedorPublicaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorPublicaciones.Location = new System.Drawing.Point(142, 177);
            this.pnlContenedorPublicaciones.Name = "pnlContenedorPublicaciones";
            this.pnlContenedorPublicaciones.Size = new System.Drawing.Size(818, 488);
            this.pnlContenedorPublicaciones.TabIndex = 25;
            // 
            // tableLayoutPMenuLateral
            // 
            this.tableLayoutPMenuLateral.BackColor = System.Drawing.Color.PeachPuff;
            this.tableLayoutPMenuLateral.ColumnCount = 1;
            this.tableLayoutPMenuLateral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPMenuLateral.Controls.Add(this.btnAgregarArriendo, 0, 1);
            this.tableLayoutPMenuLateral.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPMenuLateral.Controls.Add(this.lbnPreguntarArrendar, 0, 2);
            this.tableLayoutPMenuLateral.Controls.Add(this.btnPublicaciones, 0, 3);
            this.tableLayoutPMenuLateral.Controls.Add(this.lbnPublicaciones, 0, 4);
            this.tableLayoutPMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPMenuLateral.Location = new System.Drawing.Point(0, 177);
            this.tableLayoutPMenuLateral.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tableLayoutPMenuLateral.Name = "tableLayoutPMenuLateral";
            this.tableLayoutPMenuLateral.RowCount = 5;
            this.tableLayoutPMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPMenuLateral.Size = new System.Drawing.Size(142, 488);
            this.tableLayoutPMenuLateral.TabIndex = 25;
            // 
            // btnAgregarArriendo
            // 
            this.btnAgregarArriendo.AutoSize = true;
            this.btnAgregarArriendo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarArriendo.BackgroundImage")));
            this.btnAgregarArriendo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarArriendo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregarArriendo.Location = new System.Drawing.Point(3, 82);
            this.btnAgregarArriendo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnAgregarArriendo.Name = "btnAgregarArriendo";
            this.btnAgregarArriendo.Size = new System.Drawing.Size(116, 63);
            this.btnAgregarArriendo.TabIndex = 6;
            this.btnAgregarArriendo.UseVisualStyleBackColor = true;
            this.btnAgregarArriendo.Click += new System.EventHandler(this.btnAgregarArriendo_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 69);
            this.label3.TabIndex = 5;
            this.label3.Text = "FUNCIONES \r\nUNICAS \r\nPARA TI";
            // 
            // lbnPreguntarArrendar
            // 
            this.lbnPreguntarArrendar.AutoSize = true;
            this.lbnPreguntarArrendar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnPreguntarArrendar.ForeColor = System.Drawing.Color.LightCoral;
            this.lbnPreguntarArrendar.Location = new System.Drawing.Point(3, 155);
            this.lbnPreguntarArrendar.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lbnPreguntarArrendar.Name = "lbnPreguntarArrendar";
            this.lbnPreguntarArrendar.Size = new System.Drawing.Size(125, 138);
            this.lbnPreguntarArrendar.TabIndex = 7;
            this.lbnPreguntarArrendar.Text = "¿ Tienes un \r\ninmueble \r\npara \r\narrendar?\r\n¡dale al\r\nbotón¡";
            // 
            // btnPublicaciones
            // 
            this.btnPublicaciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPublicaciones.BackgroundImage")));
            this.btnPublicaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPublicaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublicaciones.Location = new System.Drawing.Point(2, 305);
            this.btnPublicaciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnPublicaciones.Name = "btnPublicaciones";
            this.btnPublicaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPublicaciones.Size = new System.Drawing.Size(117, 70);
            this.btnPublicaciones.TabIndex = 27;
            this.btnPublicaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPublicaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPublicaciones.UseVisualStyleBackColor = true;
            // 
            // lbnPublicaciones
            // 
            this.lbnPublicaciones.AutoSize = true;
            this.lbnPublicaciones.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnPublicaciones.Location = new System.Drawing.Point(2, 378);
            this.lbnPublicaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnPublicaciones.Name = "lbnPublicaciones";
            this.lbnPublicaciones.Size = new System.Drawing.Size(99, 34);
            this.lbnPublicaciones.TabIndex = 28;
            this.lbnPublicaciones.Text = "Mira tus\r\npublicaciones";
            this.lbnPublicaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPMenuTop
            // 
            this.tableLayoutPMenuTop.AutoSize = true;
            this.tableLayoutPMenuTop.BackColor = System.Drawing.Color.PeachPuff;
            this.tableLayoutPMenuTop.ColumnCount = 5;
            this.tableLayoutPMenuTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPMenuTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPMenuTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPMenuTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPMenuTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPMenuTop.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPMenuTop.Controls.Add(this.lbConfigurar, 4, 0);
            this.tableLayoutPMenuTop.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPMenuTop.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPMenuTop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableLayoutPMenuTop.Location = new System.Drawing.Point(0, 139);
            this.tableLayoutPMenuTop.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.tableLayoutPMenuTop.Name = "tableLayoutPMenuTop";
            this.tableLayoutPMenuTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPMenuTop.RowCount = 1;
            this.tableLayoutPMenuTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPMenuTop.Size = new System.Drawing.Size(960, 38);
            this.tableLayoutPMenuTop.TabIndex = 26;
            this.tableLayoutPMenuTop.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 40, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "MENÚ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbConfigurar
            // 
            this.lbConfigurar.AutoSize = true;
            this.lbConfigurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbConfigurar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbConfigurar.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfigurar.ForeColor = System.Drawing.Color.LightCoral;
            this.lbConfigurar.Location = new System.Drawing.Point(689, 0);
            this.lbConfigurar.Name = "lbConfigurar";
            this.lbConfigurar.Size = new System.Drawing.Size(268, 38);
            this.lbConfigurar.TabIndex = 1;
            this.lbConfigurar.Text = "Configuración de tu cuenta";
            this.lbConfigurar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbConfigurar.Click += new System.EventHandler(this.lbConfigurar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightCoral;
            this.label6.Location = new System.Drawing.Point(326, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 38);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ayuda";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightCoral;
            this.label7.Location = new System.Drawing.Point(148, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 38);
            this.label7.TabIndex = 2;
            this.label7.Text = "¿Qué somos?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInicioSuperior
            // 
            this.pnlInicioSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(204)))));
            this.pnlInicioSuperior.Controls.Add(this.panel2);
            this.pnlInicioSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInicioSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlInicioSuperior.Name = "pnlInicioSuperior";
            this.pnlInicioSuperior.Size = new System.Drawing.Size(960, 139);
            this.pnlInicioSuperior.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 141);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(457, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(335, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alojamientos Pacho";
            // 
            // flpPubs
            // 
            this.flpPubs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPubs.Location = new System.Drawing.Point(0, 0);
            this.flpPubs.Name = "flpPubs";
            this.flpPubs.Size = new System.Drawing.Size(818, 488);
            this.flpPubs.TabIndex = 0;
            this.flpPubs.Click += new System.EventHandler(this.flpPubs_Click);
            // 
            // lblSinCoinci
            // 
            this.lblSinCoinci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSinCoinci.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinCoinci.Location = new System.Drawing.Point(0, 0);
            this.lblSinCoinci.Name = "lblSinCoinci";
            this.lblSinCoinci.Size = new System.Drawing.Size(818, 488);
            this.lblSinCoinci.TabIndex = 1;
            this.lblSinCoinci.Text = "Sin coincidencias";
            this.lblSinCoinci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSinCoinci.Visible = false;
            // 
            // tableLayoutPBarraBusqueda
            // 
            this.tableLayoutPBarraBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPBarraBusqueda.ColumnCount = 11;
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
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
            this.tableLayoutPBarraBusqueda.Location = new System.Drawing.Point(142, 177);
            this.tableLayoutPBarraBusqueda.Name = "tableLayoutPBarraBusqueda";
            this.tableLayoutPBarraBusqueda.RowCount = 1;
            this.tableLayoutPBarraBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPBarraBusqueda.Size = new System.Drawing.Size(818, 50);
            this.tableLayoutPBarraBusqueda.TabIndex = 3;
            // 
            // buscarTitulo
            // 
            this.buscarTitulo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.buscarTitulo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.buscarTitulo.BorderRadius = 0;
            this.buscarTitulo.BorderSize = 2;
            this.buscarTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.buscarTitulo.Location = new System.Drawing.Point(77, 4);
            this.buscarTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.buscarTitulo.Multiline = false;
            this.buscarTitulo.Name = "buscarTitulo";
            this.buscarTitulo.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buscarTitulo.PasswordChar = false;
            this.buscarTitulo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.buscarTitulo.PlaceholderText = "";
            this.buscarTitulo.Size = new System.Drawing.Size(82, 29);
            this.buscarTitulo.TabIndex = 0;
            this.buscarTitulo.Texts = "";
            this.buscarTitulo.UnderlinedStyle = false;
            // 
            // lblPrecioMinimo
            // 
            this.lblPrecioMinimo.AutoSize = true;
            this.lblPrecioMinimo.Location = new System.Drawing.Point(185, 0);
            this.lblPrecioMinimo.Name = "lblPrecioMinimo";
            this.lblPrecioMinimo.Size = new System.Drawing.Size(45, 26);
            this.lblPrecioMinimo.TabIndex = 2;
            this.lblPrecioMinimo.Text = "Precio minimo";
            // 
            // txtPrecioMinimo
            // 
            this.txtPrecioMinimo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPrecioMinimo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPrecioMinimo.BorderRadius = 0;
            this.txtPrecioMinimo.BorderSize = 2;
            this.txtPrecioMinimo.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecioMinimo.Location = new System.Drawing.Point(237, 3);
            this.txtPrecioMinimo.Multiline = false;
            this.txtPrecioMinimo.Name = "txtPrecioMinimo";
            this.txtPrecioMinimo.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtPrecioMinimo.PasswordChar = false;
            this.txtPrecioMinimo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrecioMinimo.PlaceholderText = "";
            this.txtPrecioMinimo.Size = new System.Drawing.Size(93, 29);
            this.txtPrecioMinimo.TabIndex = 8;
            this.txtPrecioMinimo.Texts = "";
            this.txtPrecioMinimo.UnderlinedStyle = false;
            // 
            // lblPrecioMaximo
            // 
            this.lblPrecioMaximo.AutoSize = true;
            this.lblPrecioMaximo.Location = new System.Drawing.Point(349, 0);
            this.lblPrecioMaximo.Name = "lblPrecioMaximo";
            this.lblPrecioMaximo.Size = new System.Drawing.Size(47, 26);
            this.lblPrecioMaximo.TabIndex = 9;
            this.lblPrecioMaximo.Text = "Precio Maximo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(781, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(31, 41);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtPropietario
            // 
            this.txtPropietario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPropietario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPropietario.BorderRadius = 0;
            this.txtPropietario.BorderSize = 2;
            this.txtPropietario.ForeColor = System.Drawing.Color.DimGray;
            this.txtPropietario.Location = new System.Drawing.Point(699, 4);
            this.txtPropietario.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropietario.Multiline = false;
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtPropietario.PasswordChar = false;
            this.txtPropietario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPropietario.PlaceholderText = "";
            this.txtPropietario.Size = new System.Drawing.Size(75, 29);
            this.txtPropietario.TabIndex = 7;
            this.txtPropietario.Texts = "";
            this.txtPropietario.UnderlinedStyle = false;
            // 
            // lblusuarioBuscar
            // 
            this.lblusuarioBuscar.AutoSize = true;
            this.lblusuarioBuscar.Location = new System.Drawing.Point(642, 0);
            this.lblusuarioBuscar.Name = "lblusuarioBuscar";
            this.lblusuarioBuscar.Size = new System.Drawing.Size(50, 26);
            this.lblusuarioBuscar.TabIndex = 6;
            this.lblusuarioBuscar.Text = "Propietario";
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
            this.cbUbi.Location = new System.Drawing.Point(538, 3);
            this.cbUbi.Name = "cbUbi";
            this.cbUbi.Size = new System.Drawing.Size(98, 21);
            this.cbUbi.TabIndex = 5;
            // 
            // lblUbicación
            // 
            this.lblUbicación.AutoSize = true;
            this.lblUbicación.Location = new System.Drawing.Point(502, 0);
            this.lblUbicación.Name = "lblUbicación";
            this.lblUbicación.Size = new System.Drawing.Size(30, 39);
            this.lblUbicación.TabIndex = 4;
            this.lblUbicación.Text = "Ubicación";
            // 
            // txtPrecioMaximo
            // 
            this.txtPrecioMaximo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPrecioMaximo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPrecioMaximo.BorderRadius = 0;
            this.txtPrecioMaximo.BorderSize = 2;
            this.txtPrecioMaximo.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrecioMaximo.Location = new System.Drawing.Point(408, 3);
            this.txtPrecioMaximo.Multiline = false;
            this.txtPrecioMaximo.Name = "txtPrecioMaximo";
            this.txtPrecioMaximo.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtPrecioMaximo.PasswordChar = false;
            this.txtPrecioMaximo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrecioMaximo.PlaceholderText = "";
            this.txtPrecioMaximo.Size = new System.Drawing.Size(88, 29);
            this.txtPrecioMaximo.TabIndex = 10;
            this.txtPrecioMaximo.Texts = "";
            this.txtPrecioMaximo.UnderlinedStyle = false;
            // 
            // lblTituloPubli
            // 
            this.lblTituloPubli.AutoSize = true;
            this.lblTituloPubli.Location = new System.Drawing.Point(3, 0);
            this.lblTituloPubli.Name = "lblTituloPubli";
            this.lblTituloPubli.Size = new System.Drawing.Size(66, 26);
            this.lblTituloPubli.TabIndex = 11;
            this.lblTituloPubli.Text = "Titulo Publicacion";
            // 
            // HomeUsuarioRegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 665);
            this.Controls.Add(this.pnlPrincipal);
            this.MinimumSize = new System.Drawing.Size(762, 574);
            this.Name = "HomeUsuarioRegis";
            this.Text = "HomeUsuarioRegis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlContenedorPublicaciones.ResumeLayout(false);
            this.tableLayoutPMenuLateral.ResumeLayout(false);
            this.tableLayoutPMenuLateral.PerformLayout();
            this.tableLayoutPMenuTop.ResumeLayout(false);
            this.tableLayoutPMenuTop.PerformLayout();
            this.pnlInicioSuperior.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPBarraBusqueda.ResumeLayout(false);
            this.tableLayoutPBarraBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label lblNombreUsuario;
        private Label lblBienvenido;
        private PictureBox pbxLogo;
        private Panel pnlPrincipal;
        private Panel pnlInicioSuperior;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPMenuTop;
        private Label label4;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutPMenuLateral;
        private Button btnAgregarArriendo;
        private Label label3;
        private Label lbnPreguntarArrendar;
        private Button btnPublicaciones;
        private Label lbnPublicaciones;
        private Label lbConfigurar;
        private Panel pnlContenedorPublicaciones;
        private FlowLayoutPanel flpPubs;
        private Label lblSinCoinci;
        private TableLayoutPanel tableLayoutPBarraBusqueda;
        private Proyecto_arrendamiento.Apariencia.CustomTextBox buscarTitulo;
        private Label lblPrecioMinimo;
        private Proyecto_arrendamiento.Apariencia.CustomTextBox txtPrecioMinimo;
        private Label lblPrecioMaximo;
        private Button btnBuscar;
        private Proyecto_arrendamiento.Apariencia.CustomTextBox txtPropietario;
        private Label lblusuarioBuscar;
        private ComboBox cbUbi;
        private Label lblUbicación;
        private Proyecto_arrendamiento.Apariencia.CustomTextBox txtPrecioMaximo;
        private Label lblTituloPubli;
    }
}