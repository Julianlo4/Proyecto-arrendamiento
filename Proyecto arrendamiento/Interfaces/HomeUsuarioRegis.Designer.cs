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
            this.flpPubs = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPBarraBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblUbicación = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblusuarioBuscar = new System.Windows.Forms.Label();
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
            this.customTextBox1 = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.customTextBox2 = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.pnlContenedorPublicaciones.SuspendLayout();
            this.flpPubs.SuspendLayout();
            this.tableLayoutPBarraBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tableLayoutPMenuLateral.SuspendLayout();
            this.tableLayoutPMenuTop.SuspendLayout();
            this.pnlInicioSuperior.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pbxLogo.Image = global::Proyecto_arrendamiento.Properties.Resources.LogoUsuario;
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
            this.pnlContenedorPublicaciones.Controls.Add(this.flpPubs);
            this.pnlContenedorPublicaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorPublicaciones.Location = new System.Drawing.Point(142, 177);
            this.pnlContenedorPublicaciones.Name = "pnlContenedorPublicaciones";
            this.pnlContenedorPublicaciones.Size = new System.Drawing.Size(818, 488);
            this.pnlContenedorPublicaciones.TabIndex = 27;
            // 
            // flpPubs
            // 
            this.flpPubs.Controls.Add(this.tableLayoutPBarraBusqueda);
            this.flpPubs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPubs.Location = new System.Drawing.Point(0, 0);
            this.flpPubs.Name = "flpPubs";
            this.flpPubs.Size = new System.Drawing.Size(818, 488);
            this.flpPubs.TabIndex = 0;
            // 
            // tableLayoutPBarraBusqueda
            // 
            this.tableLayoutPBarraBusqueda.AutoSize = true;
            this.tableLayoutPBarraBusqueda.ColumnCount = 9;
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.19608F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPBarraBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPBarraBusqueda.Controls.Add(this.customTextBox1, 1, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.btnBuscar, 2, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.lblPrecio, 3, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.trackBar1, 4, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.lblUbicación, 5, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.comboBox1, 6, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.lblusuarioBuscar, 7, 0);
            this.tableLayoutPBarraBusqueda.Controls.Add(this.customTextBox2, 8, 0);
            this.tableLayoutPBarraBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPBarraBusqueda.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPBarraBusqueda.Name = "tableLayoutPBarraBusqueda";
            this.tableLayoutPBarraBusqueda.RowCount = 1;
            this.tableLayoutPBarraBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPBarraBusqueda.Size = new System.Drawing.Size(812, 51);
            this.tableLayoutPBarraBusqueda.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(202, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(39, 41);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(247, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(38, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(309, 3);
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(87, 45);
            this.trackBar1.SmallChange = 2;
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickFrequency = 2;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 5;
            // 
            // lblUbicación
            // 
            this.lblUbicación.AutoSize = true;
            this.lblUbicación.Location = new System.Drawing.Point(402, 0);
            this.lblUbicación.Name = "lblUbicación";
            this.lblUbicación.Size = new System.Drawing.Size(58, 13);
            this.lblUbicación.TabIndex = 4;
            this.lblUbicación.Text = "Ubicación";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(469, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // lblusuarioBuscar
            // 
            this.lblusuarioBuscar.AutoSize = true;
            this.lblusuarioBuscar.Location = new System.Drawing.Point(595, 0);
            this.lblusuarioBuscar.Name = "lblusuarioBuscar";
            this.lblusuarioBuscar.Size = new System.Drawing.Size(47, 13);
            this.lblusuarioBuscar.TabIndex = 6;
            this.lblusuarioBuscar.Text = "Usuario";
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
            this.btnAgregarArriendo.BackgroundImage = global::Proyecto_arrendamiento.Properties.Resources.AgregarPublicacion;
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
            this.btnPublicaciones.BackgroundImage = global::Proyecto_arrendamiento.Properties.Resources.publicaciones;
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
            this.pictureBox1.Image = global::Proyecto_arrendamiento.Properties.Resources.logoArrendamiento;
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
            // customTextBox1
            // 
            this.customTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox1.BorderRadius = 0;
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox1.Location = new System.Drawing.Point(22, 3);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.Size = new System.Drawing.Size(174, 29);
            this.customTextBox1.TabIndex = 0;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // customTextBox2
            // 
            this.customTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox2.BorderRadius = 0;
            this.customTextBox2.BorderSize = 2;
            this.customTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBox2.Location = new System.Drawing.Point(705, 3);
            this.customTextBox2.Multiline = false;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.customTextBox2.PasswordChar = false;
            this.customTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox2.PlaceholderText = "";
            this.customTextBox2.Size = new System.Drawing.Size(99, 28);
            this.customTextBox2.TabIndex = 7;
            this.customTextBox2.Texts = "";
            this.customTextBox2.UnderlinedStyle = false;
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
            this.flpPubs.ResumeLayout(false);
            this.flpPubs.PerformLayout();
            this.tableLayoutPBarraBusqueda.ResumeLayout(false);
            this.tableLayoutPBarraBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tableLayoutPMenuLateral.ResumeLayout(false);
            this.tableLayoutPMenuLateral.PerformLayout();
            this.tableLayoutPMenuTop.ResumeLayout(false);
            this.tableLayoutPMenuTop.PerformLayout();
            this.pnlInicioSuperior.ResumeLayout(false);
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