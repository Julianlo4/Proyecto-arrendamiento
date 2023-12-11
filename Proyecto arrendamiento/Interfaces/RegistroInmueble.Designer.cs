using System.Drawing;
using System.Windows.Forms;

namespace ArriendoPrototipo.Interfaces
{
    partial class RegistroInmueble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroInmueble));
            this.lbnAnimales = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pContenidoRegistro = new System.Windows.Forms.Panel();
            this.pZonaImagen = new System.Windows.Forms.Panel();
            this.pbxImagenInm = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTextoImagen = new System.Windows.Forms.Label();
            this.btn_volverMenuPrincipal = new System.Windows.Forms.Button();
            this.tableLRegistroIn = new System.Windows.Forms.TableLayoutPanel();
            this.cbxUbicacion = new System.Windows.Forms.ComboBox();
            this.cbxAmoblado = new System.Windows.Forms.ComboBox();
            this.lbnTituloPublicacion = new System.Windows.Forms.Label();
            this.txtNombrePublicacion = new System.Windows.Forms.TextBox();
            this.cbxTipoVivienda = new System.Windows.Forms.ComboBox();
            this.lblTipoVivienda = new System.Windows.Forms.Label();
            this.cbxAnimales = new System.Windows.Forms.ComboBox();
            this.lblUbicacionInmue = new System.Windows.Forms.Label();
            this.lbnAmoblado = new System.Windows.Forms.Label();
            this.lbnDescripcionPublicacion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lbnParqueadero = new System.Windows.Forms.Label();
            this.cbxParqueadero = new System.Windows.Forms.ComboBox();
            this.lbnTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblServiciosInclu = new System.Windows.Forms.Label();
            this.rbTv = new System.Windows.Forms.CheckBox();
            this.rbLavadora = new System.Windows.Forms.CheckBox();
            this.rbWifi = new System.Windows.Forms.CheckBox();
            this.rbAgua = new System.Windows.Forms.CheckBox();
            this.rbLuz = new System.Windows.Forms.CheckBox();
            this.rbGas = new System.Windows.Forms.CheckBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lbnPrecio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarInmueble = new ArriendoPrototipo.Apariencia.CustomButton();
            this.tableLMenuLateral = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pRegistroPubli = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlInicioSuperior = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBienvenida = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.sfvImagenInmueble = new System.Windows.Forms.SaveFileDialog();
            this.pnlPrincipal.SuspendLayout();
            this.pContenidoRegistro.SuspendLayout();
            this.pZonaImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenInm)).BeginInit();
            this.tableLRegistroIn.SuspendLayout();
            this.tableLMenuLateral.SuspendLayout();
            this.pRegistroPubli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlInicioSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pBienvenida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbnAnimales
            // 
            this.lbnAnimales.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbnAnimales.AutoSize = true;
            this.lbnAnimales.Location = new System.Drawing.Point(465, 81);
            this.lbnAnimales.Name = "lbnAnimales";
            this.lbnAnimales.Size = new System.Drawing.Size(81, 38);
            this.lbnAnimales.TabIndex = 44;
            this.lbnAnimales.Text = "¿ Permite animales?";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.AutoSize = true;
            this.pnlPrincipal.Controls.Add(this.pContenidoRegistro);
            this.pnlPrincipal.Controls.Add(this.tableLMenuLateral);
            this.pnlPrincipal.Controls.Add(this.pRegistroPubli);
            this.pnlPrincipal.Controls.Add(this.pnlInicioSuperior);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1130, 710);
            this.pnlPrincipal.TabIndex = 3;
            // 
            // pContenidoRegistro
            // 
            this.pContenidoRegistro.Controls.Add(this.pZonaImagen);
            this.pContenidoRegistro.Controls.Add(this.btn_volverMenuPrincipal);
            this.pContenidoRegistro.Controls.Add(this.tableLRegistroIn);
            this.pContenidoRegistro.Controls.Add(this.label4);
            this.pContenidoRegistro.Controls.Add(this.btnGuardarInmueble);
            this.pContenidoRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContenidoRegistro.Location = new System.Drawing.Point(146, 192);
            this.pContenidoRegistro.Name = "pContenidoRegistro";
            this.pContenidoRegistro.Size = new System.Drawing.Size(984, 518);
            this.pContenidoRegistro.TabIndex = 65;
            // 
            // pZonaImagen
            // 
            this.pZonaImagen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pZonaImagen.Controls.Add(this.pbxImagenInm);
            this.pZonaImagen.Controls.Add(this.button1);
            this.pZonaImagen.Controls.Add(this.lblTextoImagen);
            this.pZonaImagen.Location = new System.Drawing.Point(8, 67);
            this.pZonaImagen.Name = "pZonaImagen";
            this.pZonaImagen.Size = new System.Drawing.Size(210, 357);
            this.pZonaImagen.TabIndex = 64;
            // 
            // pbxImagenInm
            // 
            this.pbxImagenInm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbxImagenInm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImagenInm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxImagenInm.Image = ((System.Drawing.Image)(resources.GetObject("pbxImagenInm.Image")));
            this.pbxImagenInm.Location = new System.Drawing.Point(0, 104);
            this.pbxImagenInm.Name = "pbxImagenInm";
            this.pbxImagenInm.Size = new System.Drawing.Size(210, 253);
            this.pbxImagenInm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenInm.TabIndex = 63;
            this.pbxImagenInm.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 58);
            this.button1.TabIndex = 62;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTextoImagen
            // 
            this.lblTextoImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTextoImagen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoImagen.Location = new System.Drawing.Point(0, 0);
            this.lblTextoImagen.Name = "lblTextoImagen";
            this.lblTextoImagen.Size = new System.Drawing.Size(210, 46);
            this.lblTextoImagen.TabIndex = 64;
            this.lblTextoImagen.Text = "Sube una foto de \r\ntu inmueble";
            this.lblTextoImagen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_volverMenuPrincipal
            // 
            this.btn_volverMenuPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_volverMenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btn_volverMenuPrincipal.BackgroundImage = global::Proyecto_arrendamiento.Properties.Resources.atras;
            this.btn_volverMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_volverMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volverMenuPrincipal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_volverMenuPrincipal.Location = new System.Drawing.Point(11, 457);
            this.btn_volverMenuPrincipal.Name = "btn_volverMenuPrincipal";
            this.btn_volverMenuPrincipal.Size = new System.Drawing.Size(49, 48);
            this.btn_volverMenuPrincipal.TabIndex = 53;
            this.btn_volverMenuPrincipal.UseVisualStyleBackColor = false;
            this.btn_volverMenuPrincipal.Click += new System.EventHandler(this.btn_volverMenuPrincipal_Click);
            // 
            // tableLRegistroIn
            // 
            this.tableLRegistroIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLRegistroIn.ColumnCount = 6;
            this.tableLRegistroIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLRegistroIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLRegistroIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLRegistroIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLRegistroIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLRegistroIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLRegistroIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLRegistroIn.Controls.Add(this.cbxUbicacion, 5, 2);
            this.tableLRegistroIn.Controls.Add(this.cbxAmoblado, 5, 3);
            this.tableLRegistroIn.Controls.Add(this.lbnTituloPublicacion, 0, 0);
            this.tableLRegistroIn.Controls.Add(this.txtNombrePublicacion, 1, 0);
            this.tableLRegistroIn.Controls.Add(this.cbxTipoVivienda, 5, 0);
            this.tableLRegistroIn.Controls.Add(this.lblTipoVivienda, 4, 0);
            this.tableLRegistroIn.Controls.Add(this.lbnAnimales, 4, 1);
            this.tableLRegistroIn.Controls.Add(this.cbxAnimales, 5, 1);
            this.tableLRegistroIn.Controls.Add(this.lblUbicacionInmue, 4, 2);
            this.tableLRegistroIn.Controls.Add(this.lbnAmoblado, 4, 3);
            this.tableLRegistroIn.Controls.Add(this.lbnDescripcionPublicacion, 0, 1);
            this.tableLRegistroIn.Controls.Add(this.txtDescripcion, 1, 1);
            this.tableLRegistroIn.Controls.Add(this.lblDireccion, 0, 2);
            this.tableLRegistroIn.Controls.Add(this.txtDireccion, 1, 2);
            this.tableLRegistroIn.Controls.Add(this.lbnParqueadero, 0, 3);
            this.tableLRegistroIn.Controls.Add(this.cbxParqueadero, 1, 3);
            this.tableLRegistroIn.Controls.Add(this.lbnTelefono, 4, 4);
            this.tableLRegistroIn.Controls.Add(this.txtTelefono, 5, 4);
            this.tableLRegistroIn.Controls.Add(this.lblServiciosInclu, 0, 4);
            this.tableLRegistroIn.Controls.Add(this.rbTv, 1, 4);
            this.tableLRegistroIn.Controls.Add(this.rbLavadora, 2, 4);
            this.tableLRegistroIn.Controls.Add(this.rbWifi, 3, 4);
            this.tableLRegistroIn.Controls.Add(this.rbAgua, 1, 5);
            this.tableLRegistroIn.Controls.Add(this.rbLuz, 2, 5);
            this.tableLRegistroIn.Controls.Add(this.rbGas, 3, 5);
            this.tableLRegistroIn.Controls.Add(this.txtPrecio, 4, 7);
            this.tableLRegistroIn.Controls.Add(this.lbnPrecio, 2, 7);
            this.tableLRegistroIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLRegistroIn.Location = new System.Drawing.Point(239, 76);
            this.tableLRegistroIn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.tableLRegistroIn.Name = "tableLRegistroIn";
            this.tableLRegistroIn.RowCount = 9;
            this.tableLRegistroIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.5071F));
            this.tableLRegistroIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.4929F));
            this.tableLRegistroIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLRegistroIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLRegistroIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLRegistroIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLRegistroIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLRegistroIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLRegistroIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLRegistroIn.Size = new System.Drawing.Size(733, 366);
            this.tableLRegistroIn.TabIndex = 62;
            // 
            // cbxUbicacion
            // 
            this.cbxUbicacion.FormattingEnabled = true;
            this.cbxUbicacion.Items.AddRange(new object[] {
            "Norte",
            "Sur",
            "Oriente",
            "Occidente"});
            this.cbxUbicacion.Location = new System.Drawing.Point(552, 136);
            this.cbxUbicacion.Name = "cbxUbicacion";
            this.cbxUbicacion.Size = new System.Drawing.Size(156, 27);
            this.cbxUbicacion.TabIndex = 31;
            // 
            // cbxAmoblado
            // 
            this.cbxAmoblado.FormattingEnabled = true;
            this.cbxAmoblado.Items.AddRange(new object[] {
            "No",
            "Si"});
            this.cbxAmoblado.Location = new System.Drawing.Point(552, 181);
            this.cbxAmoblado.Name = "cbxAmoblado";
            this.cbxAmoblado.Size = new System.Drawing.Size(156, 27);
            this.cbxAmoblado.TabIndex = 43;
            // 
            // lbnTituloPublicacion
            // 
            this.lbnTituloPublicacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbnTituloPublicacion.AutoSize = true;
            this.lbnTituloPublicacion.Location = new System.Drawing.Point(23, 24);
            this.lbnTituloPublicacion.Name = "lbnTituloPublicacion";
            this.lbnTituloPublicacion.Size = new System.Drawing.Size(148, 19);
            this.lbnTituloPublicacion.TabIndex = 26;
            this.lbnTituloPublicacion.Text = "* Titulo publicación";
            // 
            // txtNombrePublicacion
            // 
            this.tableLRegistroIn.SetColumnSpan(this.txtNombrePublicacion, 3);
            this.txtNombrePublicacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombrePublicacion.Location = new System.Drawing.Point(177, 3);
            this.txtNombrePublicacion.Name = "txtNombrePublicacion";
            this.txtNombrePublicacion.Size = new System.Drawing.Size(273, 27);
            this.txtNombrePublicacion.TabIndex = 27;
            // 
            // cbxTipoVivienda
            // 
            this.cbxTipoVivienda.FormattingEnabled = true;
            this.cbxTipoVivienda.Items.AddRange(new object[] {
            "Habitacion",
            "Apartamento",
            "Casa",
            "Apartaestudio",
            "Otro"});
            this.cbxTipoVivienda.Location = new System.Drawing.Point(552, 3);
            this.cbxTipoVivienda.Name = "cbxTipoVivienda";
            this.cbxTipoVivienda.Size = new System.Drawing.Size(156, 27);
            this.cbxTipoVivienda.TabIndex = 33;
            // 
            // lblTipoVivienda
            // 
            this.lblTipoVivienda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTipoVivienda.AutoSize = true;
            this.lblTipoVivienda.Location = new System.Drawing.Point(473, 14);
            this.lblTipoVivienda.Name = "lblTipoVivienda";
            this.lblTipoVivienda.Size = new System.Drawing.Size(73, 38);
            this.lblTipoVivienda.TabIndex = 32;
            this.lblTipoVivienda.Text = "*Tipo vivienda:";
            // 
            // cbxAnimales
            // 
            this.cbxAnimales.FormattingEnabled = true;
            this.cbxAnimales.Items.AddRange(new object[] {
            "No",
            "Si"});
            this.cbxAnimales.Location = new System.Drawing.Point(552, 70);
            this.cbxAnimales.Name = "cbxAnimales";
            this.cbxAnimales.Size = new System.Drawing.Size(156, 27);
            this.cbxAnimales.TabIndex = 45;
            // 
            // lblUbicacionInmue
            // 
            this.lblUbicacionInmue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUbicacionInmue.AutoSize = true;
            this.lblUbicacionInmue.Location = new System.Drawing.Point(460, 136);
            this.lblUbicacionInmue.Name = "lblUbicacionInmue";
            this.lblUbicacionInmue.Size = new System.Drawing.Size(86, 38);
            this.lblUbicacionInmue.TabIndex = 30;
            this.lblUbicacionInmue.Text = "*Ubicación:";
            // 
            // lbnAmoblado
            // 
            this.lbnAmoblado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbnAmoblado.AutoSize = true;
            this.lbnAmoblado.Location = new System.Drawing.Point(459, 179);
            this.lbnAmoblado.Name = "lbnAmoblado";
            this.lbnAmoblado.Size = new System.Drawing.Size(87, 38);
            this.lbnAmoblado.TabIndex = 42;
            this.lbnAmoblado.Text = "*¿ Es amoblado?";
            // 
            // lbnDescripcionPublicacion
            // 
            this.lbnDescripcionPublicacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbnDescripcionPublicacion.AutoSize = true;
            this.lbnDescripcionPublicacion.Location = new System.Drawing.Point(81, 90);
            this.lbnDescripcionPublicacion.Name = "lbnDescripcionPublicacion";
            this.lbnDescripcionPublicacion.Size = new System.Drawing.Size(90, 19);
            this.lbnDescripcionPublicacion.TabIndex = 28;
            this.lbnDescripcionPublicacion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.tableLRegistroIn.SetColumnSpan(this.txtDescripcion, 3);
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.Location = new System.Drawing.Point(177, 70);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(273, 60);
            this.txtDescripcion.TabIndex = 29;
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(83, 146);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(88, 19);
            this.lblDireccion.TabIndex = 60;
            this.lblDireccion.Text = "* Dirección";
            // 
            // txtDireccion
            // 
            this.tableLRegistroIn.SetColumnSpan(this.txtDireccion, 3);
            this.txtDireccion.Location = new System.Drawing.Point(177, 136);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(273, 27);
            this.txtDireccion.TabIndex = 59;
            // 
            // lbnParqueadero
            // 
            this.lbnParqueadero.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbnParqueadero.AutoSize = true;
            this.lbnParqueadero.Location = new System.Drawing.Point(4, 188);
            this.lbnParqueadero.Name = "lbnParqueadero";
            this.lbnParqueadero.Size = new System.Drawing.Size(167, 19);
            this.lbnParqueadero.TabIndex = 46;
            this.lbnParqueadero.Text = "*¿Tiene parqueadero?";
            // 
            // cbxParqueadero
            // 
            this.tableLRegistroIn.SetColumnSpan(this.cbxParqueadero, 3);
            this.cbxParqueadero.FormattingEnabled = true;
            this.cbxParqueadero.Items.AddRange(new object[] {
            "Parqueadero para carro",
            "Paqueadero para moto",
            "Parqueadero para carro y moto",
            "No tengo parqueadero"});
            this.cbxParqueadero.Location = new System.Drawing.Point(177, 181);
            this.cbxParqueadero.Name = "cbxParqueadero";
            this.cbxParqueadero.Size = new System.Drawing.Size(226, 27);
            this.cbxParqueadero.TabIndex = 47;
            // 
            // lbnTelefono
            // 
            this.lbnTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbnTelefono.AutoSize = true;
            this.lbnTelefono.Location = new System.Drawing.Point(456, 223);
            this.lbnTelefono.Name = "lbnTelefono";
            this.lbnTelefono.Size = new System.Drawing.Size(90, 38);
            this.lbnTelefono.TabIndex = 48;
            this.lbnTelefono.Text = "*Telefono de contacto";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTelefono.Location = new System.Drawing.Point(552, 229);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(156, 27);
            this.txtTelefono.TabIndex = 51;
            // 
            // lblServiciosInclu
            // 
            this.lblServiciosInclu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblServiciosInclu.AutoSize = true;
            this.lblServiciosInclu.Location = new System.Drawing.Point(16, 233);
            this.lblServiciosInclu.Name = "lblServiciosInclu";
            this.lblServiciosInclu.Size = new System.Drawing.Size(155, 19);
            this.lblServiciosInclu.TabIndex = 34;
            this.lblServiciosInclu.Text = "*Servicios Inlcuidos:";
            // 
            // rbTv
            // 
            this.rbTv.AutoSize = true;
            this.rbTv.Location = new System.Drawing.Point(177, 221);
            this.rbTv.Name = "rbTv";
            this.rbTv.Size = new System.Drawing.Size(46, 23);
            this.rbTv.TabIndex = 56;
            this.rbTv.Text = "Tv";
            this.rbTv.UseVisualStyleBackColor = true;
            // 
            // rbLavadora
            // 
            this.rbLavadora.AutoSize = true;
            this.rbLavadora.Location = new System.Drawing.Point(249, 221);
            this.rbLavadora.Name = "rbLavadora";
            this.rbLavadora.Size = new System.Drawing.Size(92, 23);
            this.rbLavadora.TabIndex = 57;
            this.rbLavadora.Text = "Lavadora";
            this.rbLavadora.UseVisualStyleBackColor = true;
            // 
            // rbWifi
            // 
            this.rbWifi.AutoSize = true;
            this.rbWifi.Location = new System.Drawing.Point(347, 221);
            this.rbWifi.Name = "rbWifi";
            this.rbWifi.Size = new System.Drawing.Size(55, 23);
            this.rbWifi.TabIndex = 55;
            this.rbWifi.Text = "Wifi";
            this.rbWifi.UseVisualStyleBackColor = true;
            // 
            // rbAgua
            // 
            this.rbAgua.AutoSize = true;
            this.rbAgua.Location = new System.Drawing.Point(177, 270);
            this.rbAgua.Name = "rbAgua";
            this.rbAgua.Size = new System.Drawing.Size(65, 23);
            this.rbAgua.TabIndex = 53;
            this.rbAgua.Text = "Agua";
            this.rbAgua.UseVisualStyleBackColor = true;
            // 
            // rbLuz
            // 
            this.rbLuz.AutoSize = true;
            this.rbLuz.Location = new System.Drawing.Point(249, 270);
            this.rbLuz.Name = "rbLuz";
            this.rbLuz.Size = new System.Drawing.Size(52, 23);
            this.rbLuz.TabIndex = 54;
            this.rbLuz.Text = "Luz";
            this.rbLuz.UseVisualStyleBackColor = true;
            // 
            // rbGas
            // 
            this.rbGas.AutoSize = true;
            this.rbGas.Location = new System.Drawing.Point(347, 270);
            this.rbGas.Name = "rbGas";
            this.rbGas.Size = new System.Drawing.Size(54, 23);
            this.rbGas.TabIndex = 58;
            this.rbGas.Text = "Gas";
            this.rbGas.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.tableLRegistroIn.SetColumnSpan(this.txtPrecio, 2);
            this.txtPrecio.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(456, 323);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(274, 33);
            this.txtPrecio.TabIndex = 49;
            // 
            // lbnPrecio
            // 
            this.lbnPrecio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbnPrecio.AutoSize = true;
            this.tableLRegistroIn.SetColumnSpan(this.lbnPrecio, 2);
            this.lbnPrecio.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnPrecio.Location = new System.Drawing.Point(299, 328);
            this.lbnPrecio.Name = "lbnPrecio";
            this.tableLRegistroIn.SetRowSpan(this.lbnPrecio, 2);
            this.lbnPrecio.Size = new System.Drawing.Size(151, 29);
            this.lbnPrecio.TabIndex = 50;
            this.lbnPrecio.Text = "* Precio     $";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(984, 54);
            this.label4.TabIndex = 25;
            this.label4.Text = "Llene los siguientes campos para crear una publicación sobre un inmueble.\r\nLos ca" +
    "mpos con * son obligatorios\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardarInmueble
            // 
            this.btnGuardarInmueble.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardarInmueble.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGuardarInmueble.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btnGuardarInmueble.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarInmueble.BorderRadius = 0;
            this.btnGuardarInmueble.BorderSize = 0;
            this.btnGuardarInmueble.FlatAppearance.BorderSize = 0;
            this.btnGuardarInmueble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarInmueble.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarInmueble.ForeColor = System.Drawing.Color.White;
            this.btnGuardarInmueble.Location = new System.Drawing.Point(516, 459);
            this.btnGuardarInmueble.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnGuardarInmueble.Name = "btnGuardarInmueble";
            this.btnGuardarInmueble.Size = new System.Drawing.Size(200, 40);
            this.btnGuardarInmueble.TabIndex = 52;
            this.btnGuardarInmueble.Text = "Publicar inmueble";
            this.btnGuardarInmueble.TextColor = System.Drawing.Color.White;
            this.btnGuardarInmueble.UseVisualStyleBackColor = false;
            this.btnGuardarInmueble.Click += new System.EventHandler(this.btnGuardarInmueble_Click);
            // 
            // tableLMenuLateral
            // 
            this.tableLMenuLateral.BackColor = System.Drawing.Color.PeachPuff;
            this.tableLMenuLateral.ColumnCount = 1;
            this.tableLMenuLateral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLMenuLateral.Controls.Add(this.label10, 0, 2);
            this.tableLMenuLateral.Controls.Add(this.label9, 0, 1);
            this.tableLMenuLateral.Controls.Add(this.label3, 0, 0);
            this.tableLMenuLateral.Controls.Add(this.label11, 0, 3);
            this.tableLMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLMenuLateral.Location = new System.Drawing.Point(0, 192);
            this.tableLMenuLateral.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tableLMenuLateral.Name = "tableLMenuLateral";
            this.tableLMenuLateral.RowCount = 5;
            this.tableLMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLMenuLateral.Size = new System.Drawing.Size(146, 518);
            this.tableLMenuLateral.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightCoral;
            this.label10.Location = new System.Drawing.Point(3, 88);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ayuda";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightCoral;
            this.label9.Location = new System.Drawing.Point(3, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 10, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "¿Qué somos?";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "MENÚ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightCoral;
            this.label11.Location = new System.Drawing.Point(3, 131);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 36);
            this.label11.TabIndex = 8;
            this.label11.Text = "Configuración de \r\ntu cuenta";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pRegistroPubli
            // 
            this.pRegistroPubli.BackColor = System.Drawing.Color.PeachPuff;
            this.pRegistroPubli.Controls.Add(this.label1);
            this.pRegistroPubli.Controls.Add(this.pictureBox2);
            this.pRegistroPubli.Dock = System.Windows.Forms.DockStyle.Top;
            this.pRegistroPubli.Location = new System.Drawing.Point(0, 120);
            this.pRegistroPubli.Name = "pRegistroPubli";
            this.pRegistroPubli.Size = new System.Drawing.Size(1130, 72);
            this.pRegistroPubli.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(401, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO PUBLICACIÓN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(662, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pnlInicioSuperior
            // 
            this.pnlInicioSuperior.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlInicioSuperior.Controls.Add(this.label2);
            this.pnlInicioSuperior.Controls.Add(this.pictureBox1);
            this.pnlInicioSuperior.Controls.Add(this.pBienvenida);
            this.pnlInicioSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInicioSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlInicioSuperior.Name = "pnlInicioSuperior";
            this.pnlInicioSuperior.Size = new System.Drawing.Size(1130, 120);
            this.pnlInicioSuperior.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(419, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alojamientos Pacho";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(507, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pBienvenida
            // 
            this.pBienvenida.BackColor = System.Drawing.Color.PaleGreen;
            this.pBienvenida.Controls.Add(this.lblNombreUsuario);
            this.pBienvenida.Controls.Add(this.lblBienvenido);
            this.pBienvenida.Controls.Add(this.pbxLogo);
            this.pBienvenida.Dock = System.Windows.Forms.DockStyle.Right;
            this.pBienvenida.Location = new System.Drawing.Point(973, 0);
            this.pBienvenida.Name = "pBienvenida";
            this.pBienvenida.Size = new System.Drawing.Size(157, 120);
            this.pBienvenida.TabIndex = 5;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(29, 95);
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
            this.lblBienvenido.Location = new System.Drawing.Point(20, 69);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(125, 26);
            this.lblBienvenido.TabIndex = 2;
            this.lblBienvenido.Text = "Bienvenid@";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.PaleGreen;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(157, 75);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // sfvImagenInmueble
            // 
            this.sfvImagenInmueble.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos (*.*)|*.*";
            this.sfvImagenInmueble.Title = "Seleccionar imágen";
            // 
            // RegistroInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 710);
            this.Controls.Add(this.pnlPrincipal);
            this.MinimumSize = new System.Drawing.Size(938, 591);
            this.Name = "RegistroInmueble";
            this.Text = "RegistroInmueble";
            this.pnlPrincipal.ResumeLayout(false);
            this.pContenidoRegistro.ResumeLayout(false);
            this.pZonaImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenInm)).EndInit();
            this.tableLRegistroIn.ResumeLayout(false);
            this.tableLRegistroIn.PerformLayout();
            this.tableLMenuLateral.ResumeLayout(false);
            this.tableLMenuLateral.PerformLayout();
            this.pRegistroPubli.ResumeLayout(false);
            this.pRegistroPubli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlInicioSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pBienvenida.ResumeLayout(false);
            this.pBienvenida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel pnlPrincipal;
        private TableLayoutPanel tableLMenuLateral;
        private Label label10;
        private Label label9;
        private Label label3;
        private Label label11;
        private TextBox txtDireccion;
        private Label lbnTituloPublicacion;
        private Label lbnPrecio;
        private TextBox txtNombrePublicacion;
        private TextBox txtPrecio;
        private CheckBox rbGas;
        private Label lbnTelefono;
        private Label lbnDescripcionPublicacion;
        private CheckBox rbLavadora;
        private TextBox txtDescripcion;
        private CheckBox rbTv;
        private ComboBox cbxParqueadero;
        private Label lblUbicacionInmue;
        private Label lbnParqueadero;
        private CheckBox rbWifi;
        private ComboBox cbxAnimales;
        private ComboBox cbxUbicacion;
        private CheckBox rbLuz;
        private ComboBox cbxAmoblado;
        private CheckBox rbAgua;
        private Label lbnAmoblado;
        private Label lblServiciosInclu;
        private ComboBox cbxTipoVivienda;
        private Label lblTipoVivienda;
        private Label lblDireccion;
        private TextBox txtTelefono;
        private Label label4;
        private Panel pnlInicioSuperior;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel pBienvenida;
        private Label lblNombreUsuario;
        private Label lblBienvenido;
        private PictureBox pbxLogo;
        private Apariencia.CustomButton btnGuardarInmueble;
        private Label label1;
        private PictureBox pictureBox2;
        private Button btn_volverMenuPrincipal;
        private Label lbnAnimales;
        private SaveFileDialog sfvImagenInmueble;
        private TableLayoutPanel tableLRegistroIn;
        private Button button1;
        private PictureBox pbxImagenInm;
        private Panel pRegistroPubli;
        private Panel pContenidoRegistro;
        private Panel pZonaImagen;
        private Label lblTextoImagen;
    }
}