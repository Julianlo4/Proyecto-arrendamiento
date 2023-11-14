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
            System.Windows.Forms.Label lbnAnimales;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroInmueble));
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btn_volverMenuPrincipal = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lbnTituloPublicacion = new System.Windows.Forms.Label();
            this.lbnPrecio = new System.Windows.Forms.Label();
            this.txtNombrePublicacion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.rbGas = new System.Windows.Forms.CheckBox();
            this.lbnTelefono = new System.Windows.Forms.Label();
            this.lbnDescripcionPublicacion = new System.Windows.Forms.Label();
            this.rbLavadora = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.rbTv = new System.Windows.Forms.CheckBox();
            this.cbxParqueadero = new System.Windows.Forms.ComboBox();
            this.lblUbicacionInmue = new System.Windows.Forms.Label();
            this.lbnParqueadero = new System.Windows.Forms.Label();
            this.rbWifi = new System.Windows.Forms.CheckBox();
            this.cbxAnimales = new System.Windows.Forms.ComboBox();
            this.cbxUbicacion = new System.Windows.Forms.ComboBox();
            this.rbLuz = new System.Windows.Forms.CheckBox();
            this.cbxAmoblado = new System.Windows.Forms.ComboBox();
            this.rbAgua = new System.Windows.Forms.CheckBox();
            this.lbnAmoblado = new System.Windows.Forms.Label();
            this.lblServiciosInclu = new System.Windows.Forms.Label();
            this.cbxTipoVivienda = new System.Windows.Forms.ComboBox();
            this.lblTipoVivienda = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarInmueble = new ArriendoPrototipo.Apariencia.CustomButton();
            this.pnlInicioSuperior = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            lbnAnimales = new System.Windows.Forms.Label();
            this.pnlPrincipal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlInicioSuperior.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbnAnimales
            // 
            lbnAnimales.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lbnAnimales.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(lbnAnimales, 2);
            lbnAnimales.Location = new System.Drawing.Point(334, 161);
            lbnAnimales.Name = "lbnAnimales";
            lbnAnimales.Size = new System.Drawing.Size(151, 19);
            lbnAnimales.TabIndex = 44;
            lbnAnimales.Text = "¿ Permite animales?";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.AutoSize = true;
            this.pnlPrincipal.Controls.Add(this.btn_volverMenuPrincipal);
            this.pnlPrincipal.Controls.Add(this.tableLayoutPanel1);
            this.pnlPrincipal.Controls.Add(this.tableLayoutPanel2);
            this.pnlPrincipal.Controls.Add(this.panel6);
            this.pnlPrincipal.Controls.Add(this.tableLayoutPanel3);
            this.pnlPrincipal.Controls.Add(this.label4);
            this.pnlPrincipal.Controls.Add(this.btnGuardarInmueble);
            this.pnlPrincipal.Controls.Add(this.pnlInicioSuperior);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(923, 641);
            this.pnlPrincipal.TabIndex = 3;
            // 
            // btn_volverMenuPrincipal
            // 
            this.btn_volverMenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btn_volverMenuPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_volverMenuPrincipal.BackgroundImage")));
            this.btn_volverMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_volverMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volverMenuPrincipal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_volverMenuPrincipal.Location = new System.Drawing.Point(192, 580);
            this.btn_volverMenuPrincipal.Name = "btn_volverMenuPrincipal";
            this.btn_volverMenuPrincipal.Size = new System.Drawing.Size(41, 36);
            this.btn_volverMenuPrincipal.TabIndex = 53;
            this.btn_volverMenuPrincipal.UseVisualStyleBackColor = false;
            this.btn_volverMenuPrincipal.Click += new System.EventHandler(this.btn_volverMenuPrincipal_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtDireccion, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbnTituloPublicacion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbnPrecio, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtNombrePublicacion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTelefono, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.rbGas, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbnTelefono, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbnDescripcionPublicacion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbLavadora, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbTv, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxParqueadero, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblUbicacionInmue, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbnParqueadero, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.rbWifi, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxAnimales, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbxUbicacion, 1, 2);
            this.tableLayoutPanel1.Controls.Add(lbnAnimales, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.rbLuz, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxAmoblado, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.rbAgua, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbnAmoblado, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblServiciosInclu, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxTipoVivienda, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTipoVivienda, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDireccion, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtPrecio, 1, 7);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(188, 253);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(725, 305);
            this.tableLayoutPanel1.TabIndex = 25;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtDireccion
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDireccion, 2);
            this.txtDireccion.Location = new System.Drawing.Point(491, 190);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(230, 27);
            this.txtDireccion.TabIndex = 59;
            // 
            // lbnTituloPublicacion
            // 
            this.lbnTituloPublicacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbnTituloPublicacion.AutoSize = true;
            this.lbnTituloPublicacion.Location = new System.Drawing.Point(37, 7);
            this.lbnTituloPublicacion.Name = "lbnTituloPublicacion";
            this.lbnTituloPublicacion.Size = new System.Drawing.Size(148, 19);
            this.lbnTituloPublicacion.TabIndex = 26;
            this.lbnTituloPublicacion.Text = "* Titulo publicación";
            // 
            // lbnPrecio
            // 
            this.lbnPrecio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbnPrecio.AutoSize = true;
            this.lbnPrecio.Location = new System.Drawing.Point(85, 269);
            this.lbnPrecio.Name = "lbnPrecio";
            this.lbnPrecio.Size = new System.Drawing.Size(100, 19);
            this.lbnPrecio.TabIndex = 50;
            this.lbnPrecio.Text = "* Precio     $";
            // 
            // txtNombrePublicacion
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtNombrePublicacion, 6);
            this.txtNombrePublicacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombrePublicacion.Location = new System.Drawing.Point(191, 3);
            this.txtNombrePublicacion.Name = "txtNombrePublicacion";
            this.txtNombrePublicacion.Size = new System.Drawing.Size(516, 27);
            this.txtNombrePublicacion.TabIndex = 27;
            // 
            // txtTelefono
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtTelefono, 3);
            this.txtTelefono.Location = new System.Drawing.Point(191, 223);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(184, 27);
            this.txtTelefono.TabIndex = 49;
            // 
            // rbGas
            // 
            this.rbGas.AutoSize = true;
            this.rbGas.Location = new System.Drawing.Point(589, 128);
            this.rbGas.Name = "rbGas";
            this.rbGas.Size = new System.Drawing.Size(54, 23);
            this.rbGas.TabIndex = 58;
            this.rbGas.Text = "Gas";
            this.rbGas.UseVisualStyleBackColor = true;
            // 
            // lbnTelefono
            // 
            this.lbnTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbnTelefono.AutoSize = true;
            this.lbnTelefono.Location = new System.Drawing.Point(14, 227);
            this.lbnTelefono.Name = "lbnTelefono";
            this.lbnTelefono.Size = new System.Drawing.Size(171, 19);
            this.lbnTelefono.TabIndex = 48;
            this.lbnTelefono.Text = "* Telefono de contacto";
            // 
            // lbnDescripcionPublicacion
            // 
            this.lbnDescripcionPublicacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbnDescripcionPublicacion.AutoSize = true;
            this.lbnDescripcionPublicacion.Location = new System.Drawing.Point(95, 53);
            this.lbnDescripcionPublicacion.Name = "lbnDescripcionPublicacion";
            this.lbnDescripcionPublicacion.Size = new System.Drawing.Size(90, 19);
            this.lbnDescripcionPublicacion.TabIndex = 28;
            this.lbnDescripcionPublicacion.Text = "Descripción";
            // 
            // rbLavadora
            // 
            this.rbLavadora.AutoSize = true;
            this.rbLavadora.Location = new System.Drawing.Point(491, 128);
            this.rbLavadora.Name = "rbLavadora";
            this.rbLavadora.Size = new System.Drawing.Size(92, 23);
            this.rbLavadora.TabIndex = 57;
            this.rbLavadora.Text = "Lavadora";
            this.rbLavadora.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescripcion, 6);
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.Location = new System.Drawing.Point(191, 36);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(516, 53);
            this.txtDescripcion.TabIndex = 29;
            // 
            // rbTv
            // 
            this.rbTv.AutoSize = true;
            this.rbTv.Location = new System.Drawing.Point(395, 128);
            this.rbTv.Name = "rbTv";
            this.rbTv.Size = new System.Drawing.Size(46, 23);
            this.rbTv.TabIndex = 56;
            this.rbTv.Text = "Tv";
            this.rbTv.UseVisualStyleBackColor = true;
            // 
            // cbxParqueadero
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbxParqueadero, 2);
            this.cbxParqueadero.FormattingEnabled = true;
            this.cbxParqueadero.Items.AddRange(new object[] {
            "Parqueadero para carro",
            "Paqueadero para moto",
            "Parqueadero para carro y moto",
            "No tengo parqueadero"});
            this.cbxParqueadero.Location = new System.Drawing.Point(191, 190);
            this.cbxParqueadero.Name = "cbxParqueadero";
            this.cbxParqueadero.Size = new System.Drawing.Size(137, 27);
            this.cbxParqueadero.TabIndex = 47;
            // 
            // lblUbicacionInmue
            // 
            this.lblUbicacionInmue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUbicacionInmue.AutoSize = true;
            this.lblUbicacionInmue.Location = new System.Drawing.Point(88, 99);
            this.lblUbicacionInmue.Name = "lblUbicacionInmue";
            this.lblUbicacionInmue.Size = new System.Drawing.Size(97, 19);
            this.lblUbicacionInmue.TabIndex = 30;
            this.lblUbicacionInmue.Text = "* Ubicación:";
            // 
            // lbnParqueadero
            // 
            this.lbnParqueadero.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbnParqueadero.AutoSize = true;
            this.lbnParqueadero.Location = new System.Drawing.Point(3, 194);
            this.lbnParqueadero.Name = "lbnParqueadero";
            this.lbnParqueadero.Size = new System.Drawing.Size(182, 19);
            this.lbnParqueadero.TabIndex = 46;
            this.lbnParqueadero.Text = "* ¿ Tiene parqueadero ?";
            // 
            // rbWifi
            // 
            this.rbWifi.AutoSize = true;
            this.rbWifi.Location = new System.Drawing.Point(334, 128);
            this.rbWifi.Name = "rbWifi";
            this.rbWifi.Size = new System.Drawing.Size(55, 23);
            this.rbWifi.TabIndex = 55;
            this.rbWifi.Text = "Wifi";
            this.rbWifi.UseVisualStyleBackColor = true;
            // 
            // cbxAnimales
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbxAnimales, 2);
            this.cbxAnimales.FormattingEnabled = true;
            this.cbxAnimales.Items.AddRange(new object[] {
            "No",
            "Si"});
            this.cbxAnimales.Location = new System.Drawing.Point(491, 157);
            this.cbxAnimales.Name = "cbxAnimales";
            this.cbxAnimales.Size = new System.Drawing.Size(230, 27);
            this.cbxAnimales.TabIndex = 45;
            // 
            // cbxUbicacion
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbxUbicacion, 2);
            this.cbxUbicacion.FormattingEnabled = true;
            this.cbxUbicacion.Items.AddRange(new object[] {
            "Norte",
            "Sur",
            "Oriente",
            "Occidente"});
            this.cbxUbicacion.Location = new System.Drawing.Point(191, 95);
            this.cbxUbicacion.Name = "cbxUbicacion";
            this.cbxUbicacion.Size = new System.Drawing.Size(110, 27);
            this.cbxUbicacion.TabIndex = 31;
            // 
            // rbLuz
            // 
            this.rbLuz.AutoSize = true;
            this.rbLuz.Location = new System.Drawing.Point(262, 128);
            this.rbLuz.Name = "rbLuz";
            this.rbLuz.Size = new System.Drawing.Size(52, 23);
            this.rbLuz.TabIndex = 54;
            this.rbLuz.Text = "Luz";
            this.rbLuz.UseVisualStyleBackColor = true;
            // 
            // cbxAmoblado
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbxAmoblado, 2);
            this.cbxAmoblado.FormattingEnabled = true;
            this.cbxAmoblado.Items.AddRange(new object[] {
            "No",
            "Si"});
            this.cbxAmoblado.Location = new System.Drawing.Point(191, 157);
            this.cbxAmoblado.Name = "cbxAmoblado";
            this.cbxAmoblado.Size = new System.Drawing.Size(110, 27);
            this.cbxAmoblado.TabIndex = 43;
            // 
            // rbAgua
            // 
            this.rbAgua.AutoSize = true;
            this.rbAgua.Location = new System.Drawing.Point(191, 128);
            this.rbAgua.Name = "rbAgua";
            this.rbAgua.Size = new System.Drawing.Size(65, 23);
            this.rbAgua.TabIndex = 53;
            this.rbAgua.Text = "Agua";
            this.rbAgua.UseVisualStyleBackColor = true;
            // 
            // lbnAmoblado
            // 
            this.lbnAmoblado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbnAmoblado.AutoSize = true;
            this.lbnAmoblado.Location = new System.Drawing.Point(50, 161);
            this.lbnAmoblado.Name = "lbnAmoblado";
            this.lbnAmoblado.Size = new System.Drawing.Size(135, 19);
            this.lbnAmoblado.TabIndex = 42;
            this.lbnAmoblado.Text = "* ¿ Es amoblado?";
            // 
            // lblServiciosInclu
            // 
            this.lblServiciosInclu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblServiciosInclu.AutoSize = true;
            this.lblServiciosInclu.Location = new System.Drawing.Point(30, 130);
            this.lblServiciosInclu.Name = "lblServiciosInclu";
            this.lblServiciosInclu.Size = new System.Drawing.Size(155, 19);
            this.lblServiciosInclu.TabIndex = 34;
            this.lblServiciosInclu.Text = "*Servicios Inlcuidos:";
            // 
            // cbxTipoVivienda
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbxTipoVivienda, 2);
            this.cbxTipoVivienda.FormattingEnabled = true;
            this.cbxTipoVivienda.Items.AddRange(new object[] {
            "Habitacion",
            "Apartamento",
            "Casa",
            "Apartaestudio",
            "Otro"});
            this.cbxTipoVivienda.Location = new System.Drawing.Point(491, 95);
            this.cbxTipoVivienda.Name = "cbxTipoVivienda";
            this.cbxTipoVivienda.Size = new System.Drawing.Size(230, 27);
            this.cbxTipoVivienda.TabIndex = 33;
            // 
            // lblTipoVivienda
            // 
            this.lblTipoVivienda.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTipoVivienda.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTipoVivienda, 2);
            this.lblTipoVivienda.Location = new System.Drawing.Point(361, 99);
            this.lblTipoVivienda.Name = "lblTipoVivienda";
            this.lblTipoVivienda.Size = new System.Drawing.Size(124, 19);
            this.lblTipoVivienda.TabIndex = 32;
            this.lblTipoVivienda.Text = "* Tipo vivienda:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDireccion.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblDireccion, 2);
            this.lblDireccion.Location = new System.Drawing.Point(397, 194);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(88, 19);
            this.lblDireccion.TabIndex = 60;
            this.lblDireccion.Text = "* Dirección";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtPrecio, 3);
            this.txtPrecio.Location = new System.Drawing.Point(191, 265);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(184, 27);
            this.txtPrecio.TabIndex = 51;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.PeachPuff;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 175);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(182, 466);
            this.tableLayoutPanel2.TabIndex = 27;
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
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightCoral;
            this.label11.Location = new System.Drawing.Point(3, 131);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 46);
            this.label11.TabIndex = 8;
            this.label11.Text = "Configuración de \r\ntu cuenta";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.SkyBlue;
            this.panel6.Location = new System.Drawing.Point(181, 564);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(742, 10);
            this.panel6.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.PeachPuff;
            this.tableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.61322F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.38678F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 123);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(923, 52);
            this.tableLayoutPanel3.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(283, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO PUBLICACIÓN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(544, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(725, 38);
            this.label4.TabIndex = 25;
            this.label4.Text = "Llene los siguientes campos para crear una publicación sobre un inmueble.\r\nLos ca" +
    "mpos con * son obligatorios\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardarInmueble
            // 
            this.btnGuardarInmueble.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarInmueble.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGuardarInmueble.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.btnGuardarInmueble.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarInmueble.BorderRadius = 0;
            this.btnGuardarInmueble.BorderSize = 0;
            this.btnGuardarInmueble.FlatAppearance.BorderSize = 0;
            this.btnGuardarInmueble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarInmueble.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarInmueble.ForeColor = System.Drawing.Color.White;
            this.btnGuardarInmueble.Location = new System.Drawing.Point(478, 587);
            this.btnGuardarInmueble.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnGuardarInmueble.Name = "btnGuardarInmueble";
            this.btnGuardarInmueble.Size = new System.Drawing.Size(200, 40);
            this.btnGuardarInmueble.TabIndex = 52;
            this.btnGuardarInmueble.Text = "Publicar inmueble";
            this.btnGuardarInmueble.TextColor = System.Drawing.Color.White;
            this.btnGuardarInmueble.UseVisualStyleBackColor = false;
            this.btnGuardarInmueble.Click += new System.EventHandler(this.btnGuardarInmueble_Click);
            // 
            // pnlInicioSuperior
            // 
            this.pnlInicioSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(204)))));
            this.pnlInicioSuperior.Controls.Add(this.panel2);
            this.pnlInicioSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInicioSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlInicioSuperior.Name = "pnlInicioSuperior";
            this.pnlInicioSuperior.Size = new System.Drawing.Size(923, 123);
            this.pnlInicioSuperior.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 123);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(263, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alojamientos Pacho";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(766, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.lblNombreUsuario);
            this.panel1.Controls.Add(this.lblBienvenido);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(766, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 123);
            this.panel1.TabIndex = 5;
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
            // RegistroInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 641);
            this.Controls.Add(this.pnlPrincipal);
            this.MinimumSize = new System.Drawing.Size(939, 680);
            this.Name = "RegistroInmueble";
            this.Text = "RegistroInmueble";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlInicioSuperior.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel pnlPrincipal;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label10;
        private Label label9;
        private Label label3;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtDireccion;
        private Label lbnTituloPublicacion;
        private Label lbnPrecio;
        private TextBox txtNombrePublicacion;
        private TextBox txtTelefono;
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
        private TextBox txtPrecio;
        private Panel panel6;
        private Label label4;
        private Panel pnlInicioSuperior;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblNombreUsuario;
        private Label lblBienvenido;
        private PictureBox pbxLogo;
        private TableLayoutPanel tableLayoutPanel3;
        private Apariencia.CustomButton btnGuardarInmueble;
        private Label label1;
        private PictureBox pictureBox2;
        private Button btn_volverMenuPrincipal;
    }
}