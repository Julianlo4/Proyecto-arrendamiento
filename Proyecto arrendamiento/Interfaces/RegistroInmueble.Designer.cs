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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQueSomos = new System.Windows.Forms.Label();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.MenuRegistroUsuario = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bntRegistrarInmueble = new System.Windows.Forms.Button();
            this.cbxPrecio = new System.Windows.Forms.TextBox();
            this.lbnPrecio = new System.Windows.Forms.Label();
            this.cbxTelefono = new System.Windows.Forms.TextBox();
            this.lbnTelefono = new System.Windows.Forms.Label();
            this.cbxParqueadero = new System.Windows.Forms.ComboBox();
            this.lbnParqueadero = new System.Windows.Forms.Label();
            this.cbxAnimales = new System.Windows.Forms.ComboBox();
            this.cbxAmoblado = new System.Windows.Forms.ComboBox();
            this.lbnAmoblado = new System.Windows.Forms.Label();
            this.rbGas = new System.Windows.Forms.RadioButton();
            this.rbLavadora = new System.Windows.Forms.RadioButton();
            this.rbTv = new System.Windows.Forms.RadioButton();
            this.rbWifi = new System.Windows.Forms.RadioButton();
            this.rbLuz = new System.Windows.Forms.RadioButton();
            this.rbAgua = new System.Windows.Forms.RadioButton();
            this.lblServiciosInclu = new System.Windows.Forms.Label();
            this.cbxTipoVivienda = new System.Windows.Forms.ComboBox();
            this.lblTipoVivienda = new System.Windows.Forms.Label();
            this.cbxUbicacion = new System.Windows.Forms.ComboBox();
            this.lblUbicacionInmue = new System.Windows.Forms.Label();
            this.cbxDescripcionInmueble = new System.Windows.Forms.TextBox();
            this.lbnDescripcionPublicacion = new System.Windows.Forms.Label();
            this.cbxNombrePublicacion = new System.Windows.Forms.TextBox();
            this.lbnTituloPublicacion = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlInicioSuperior = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            lbnAnimales = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.pnlInicioSuperior.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbnAnimales
            // 
            lbnAnimales.AutoSize = true;
            lbnAnimales.Location = new System.Drawing.Point(375, 209);
            lbnAnimales.Name = "lbnAnimales";
            lbnAnimales.Size = new System.Drawing.Size(106, 13);
            lbnAnimales.TabIndex = 44;
            lbnAnimales.Text = "¿ Permite animales?";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(204)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lblQueSomos);
            this.panel4.Controls.Add(this.lblIniciarSesion);
            this.panel4.Controls.Add(this.lblAyuda);
            this.panel4.Controls.Add(this.MenuRegistroUsuario);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(106, 369);
            this.panel4.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Página principal";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // lblQueSomos
            // 
            this.lblQueSomos.AutoSize = true;
            this.lblQueSomos.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblQueSomos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.lblQueSomos.Location = new System.Drawing.Point(10, 75);
            this.lblQueSomos.Name = "lblQueSomos";
            this.lblQueSomos.Size = new System.Drawing.Size(101, 20);
            this.lblQueSomos.TabIndex = 2;
            this.lblQueSomos.Text = "¿Qué somos?";
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.lblIniciarSesion.Location = new System.Drawing.Point(10, 148);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(107, 20);
            this.lblIniciarSesion.TabIndex = 1;
            this.lblIniciarSesion.Text = "Configuracion";
            this.lblIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.lblAyuda.Location = new System.Drawing.Point(32, 110);
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
            this.MenuRegistroUsuario.Location = new System.Drawing.Point(29, -7);
            this.MenuRegistroUsuario.Name = "MenuRegistroUsuario";
            this.MenuRegistroUsuario.Size = new System.Drawing.Size(79, 34);
            this.MenuRegistroUsuario.TabIndex = 4;
            this.MenuRegistroUsuario.Text = "MENÚ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(3, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(106, 9);
            this.panel5.TabIndex = 1;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.bntRegistrarInmueble);
            this.panel3.Controls.Add(this.cbxPrecio);
            this.panel3.Controls.Add(this.lbnPrecio);
            this.panel3.Controls.Add(this.cbxTelefono);
            this.panel3.Controls.Add(this.lbnTelefono);
            this.panel3.Controls.Add(this.cbxParqueadero);
            this.panel3.Controls.Add(this.lbnParqueadero);
            this.panel3.Controls.Add(this.cbxAnimales);
            this.panel3.Controls.Add(lbnAnimales);
            this.panel3.Controls.Add(this.cbxAmoblado);
            this.panel3.Controls.Add(this.lbnAmoblado);
            this.panel3.Controls.Add(this.rbGas);
            this.panel3.Controls.Add(this.rbLavadora);
            this.panel3.Controls.Add(this.rbTv);
            this.panel3.Controls.Add(this.rbWifi);
            this.panel3.Controls.Add(this.rbLuz);
            this.panel3.Controls.Add(this.rbAgua);
            this.panel3.Controls.Add(this.lblServiciosInclu);
            this.panel3.Controls.Add(this.cbxTipoVivienda);
            this.panel3.Controls.Add(this.lblTipoVivienda);
            this.panel3.Controls.Add(this.cbxUbicacion);
            this.panel3.Controls.Add(this.lblUbicacionInmue);
            this.panel3.Controls.Add(this.cbxDescripcionInmueble);
            this.panel3.Controls.Add(this.lbnDescripcionPublicacion);
            this.panel3.Controls.Add(this.cbxNombrePublicacion);
            this.panel3.Controls.Add(this.lbnTituloPublicacion);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 372);
            this.panel3.TabIndex = 24;
            // 
            // bntRegistrarInmueble
            // 
            this.bntRegistrarInmueble.Location = new System.Drawing.Point(477, 335);
            this.bntRegistrarInmueble.Name = "bntRegistrarInmueble";
            this.bntRegistrarInmueble.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bntRegistrarInmueble.Size = new System.Drawing.Size(111, 20);
            this.bntRegistrarInmueble.TabIndex = 52;
            this.bntRegistrarInmueble.Text = "REGISTRAR INMUEBLE";
            this.bntRegistrarInmueble.UseVisualStyleBackColor = true;
            // 
            // cbxPrecio
            // 
            this.cbxPrecio.Location = new System.Drawing.Point(229, 318);
            this.cbxPrecio.Name = "cbxPrecio";
            this.cbxPrecio.Size = new System.Drawing.Size(86, 22);
            this.cbxPrecio.TabIndex = 51;
            // 
            // lbnPrecio
            // 
            this.lbnPrecio.AutoSize = true;
            this.lbnPrecio.Location = new System.Drawing.Point(153, 321);
            this.lbnPrecio.Name = "lbnPrecio";
            this.lbnPrecio.Size = new System.Drawing.Size(67, 13);
            this.lbnPrecio.TabIndex = 50;
            this.lbnPrecio.Text = "* Precio     $";
            // 
            // cbxTelefono
            // 
            this.cbxTelefono.Location = new System.Drawing.Point(255, 285);
            this.cbxTelefono.Name = "cbxTelefono";
            this.cbxTelefono.Size = new System.Drawing.Size(86, 22);
            this.cbxTelefono.TabIndex = 49;
            // 
            // lbnTelefono
            // 
            this.lbnTelefono.AutoSize = true;
            this.lbnTelefono.Location = new System.Drawing.Point(143, 288);
            this.lbnTelefono.Name = "lbnTelefono";
            this.lbnTelefono.Size = new System.Drawing.Size(124, 13);
            this.lbnTelefono.TabIndex = 48;
            this.lbnTelefono.Text = "* Telefono de contacto";
            // 
            // cbxParqueadero
            // 
            this.cbxParqueadero.FormattingEnabled = true;
            this.cbxParqueadero.Items.AddRange(new object[] {
            "Si",
            "No",
            "Solo motos"});
            this.cbxParqueadero.Location = new System.Drawing.Point(255, 243);
            this.cbxParqueadero.Name = "cbxParqueadero";
            this.cbxParqueadero.Size = new System.Drawing.Size(104, 21);
            this.cbxParqueadero.TabIndex = 47;
            // 
            // lbnParqueadero
            // 
            this.lbnParqueadero.AutoSize = true;
            this.lbnParqueadero.Location = new System.Drawing.Point(139, 245);
            this.lbnParqueadero.Name = "lbnParqueadero";
            this.lbnParqueadero.Size = new System.Drawing.Size(129, 13);
            this.lbnParqueadero.TabIndex = 46;
            this.lbnParqueadero.Text = "* ¿ Tiene parqueadero ?";
            // 
            // cbxAnimales
            // 
            this.cbxAnimales.FormattingEnabled = true;
            this.cbxAnimales.Items.AddRange(new object[] {
            "Si",
            "No",
            "Depende"});
            this.cbxAnimales.Location = new System.Drawing.Point(507, 209);
            this.cbxAnimales.Name = "cbxAnimales";
            this.cbxAnimales.Size = new System.Drawing.Size(104, 21);
            this.cbxAnimales.TabIndex = 45;
            // 
            // cbxAmoblado
            // 
            this.cbxAmoblado.FormattingEnabled = true;
            this.cbxAmoblado.Items.AddRange(new object[] {
            "Si",
            "No",
            "Parcialmente"});
            this.cbxAmoblado.Location = new System.Drawing.Point(237, 205);
            this.cbxAmoblado.Name = "cbxAmoblado";
            this.cbxAmoblado.Size = new System.Drawing.Size(104, 21);
            this.cbxAmoblado.TabIndex = 43;
            // 
            // lbnAmoblado
            // 
            this.lbnAmoblado.AutoSize = true;
            this.lbnAmoblado.Location = new System.Drawing.Point(139, 208);
            this.lbnAmoblado.Name = "lbnAmoblado";
            this.lbnAmoblado.Size = new System.Drawing.Size(94, 13);
            this.lbnAmoblado.TabIndex = 42;
            this.lbnAmoblado.Text = "* ¿ Es amoblado?";
            // 
            // rbGas
            // 
            this.rbGas.AutoSize = true;
            this.rbGas.Location = new System.Drawing.Point(626, 176);
            this.rbGas.Name = "rbGas";
            this.rbGas.Size = new System.Drawing.Size(44, 17);
            this.rbGas.TabIndex = 41;
            this.rbGas.TabStop = true;
            this.rbGas.Text = "Gas";
            this.rbGas.UseVisualStyleBackColor = true;
            // 
            // rbLavadora
            // 
            this.rbLavadora.AutoSize = true;
            this.rbLavadora.Location = new System.Drawing.Point(550, 174);
            this.rbLavadora.Name = "rbLavadora";
            this.rbLavadora.Size = new System.Drawing.Size(71, 17);
            this.rbLavadora.TabIndex = 40;
            this.rbLavadora.TabStop = true;
            this.rbLavadora.Text = "Lavadora";
            this.rbLavadora.UseVisualStyleBackColor = true;
            // 
            // rbTv
            // 
            this.rbTv.AutoSize = true;
            this.rbTv.Location = new System.Drawing.Point(490, 176);
            this.rbTv.Name = "rbTv";
            this.rbTv.Size = new System.Drawing.Size(35, 17);
            this.rbTv.TabIndex = 39;
            this.rbTv.TabStop = true;
            this.rbTv.Text = "Tv";
            this.rbTv.UseVisualStyleBackColor = true;
            // 
            // rbWifi
            // 
            this.rbWifi.AutoSize = true;
            this.rbWifi.Location = new System.Drawing.Point(428, 176);
            this.rbWifi.Name = "rbWifi";
            this.rbWifi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rbWifi.Size = new System.Drawing.Size(46, 17);
            this.rbWifi.TabIndex = 38;
            this.rbWifi.TabStop = true;
            this.rbWifi.Text = "Wifi";
            this.rbWifi.UseVisualStyleBackColor = true;
            // 
            // rbLuz
            // 
            this.rbLuz.AutoSize = true;
            this.rbLuz.Location = new System.Drawing.Point(361, 176);
            this.rbLuz.Name = "rbLuz";
            this.rbLuz.Size = new System.Drawing.Size(42, 17);
            this.rbLuz.TabIndex = 37;
            this.rbLuz.TabStop = true;
            this.rbLuz.Text = "Luz";
            this.rbLuz.UseVisualStyleBackColor = true;
            // 
            // rbAgua
            // 
            this.rbAgua.AutoSize = true;
            this.rbAgua.Location = new System.Drawing.Point(270, 176);
            this.rbAgua.Name = "rbAgua";
            this.rbAgua.Size = new System.Drawing.Size(52, 17);
            this.rbAgua.TabIndex = 36;
            this.rbAgua.TabStop = true;
            this.rbAgua.Text = "Agua";
            this.rbAgua.UseVisualStyleBackColor = true;
            // 
            // lblServiciosInclu
            // 
            this.lblServiciosInclu.AutoSize = true;
            this.lblServiciosInclu.Location = new System.Drawing.Point(126, 176);
            this.lblServiciosInclu.Name = "lblServiciosInclu";
            this.lblServiciosInclu.Size = new System.Drawing.Size(109, 13);
            this.lblServiciosInclu.TabIndex = 34;
            this.lblServiciosInclu.Text = "*Servicios Inlcuidos:";
            // 
            // cbxTipoVivienda
            // 
            this.cbxTipoVivienda.FormattingEnabled = true;
            this.cbxTipoVivienda.Items.AddRange(new object[] {
            "Apartamento",
            "ApartaEstudio",
            "Casa de estudiantes"});
            this.cbxTipoVivienda.Location = new System.Drawing.Point(585, 134);
            this.cbxTipoVivienda.Name = "cbxTipoVivienda";
            this.cbxTipoVivienda.Size = new System.Drawing.Size(104, 21);
            this.cbxTipoVivienda.TabIndex = 33;
            // 
            // lblTipoVivienda
            // 
            this.lblTipoVivienda.AutoSize = true;
            this.lblTipoVivienda.Location = new System.Drawing.Point(490, 140);
            this.lblTipoVivienda.Name = "lblTipoVivienda";
            this.lblTipoVivienda.Size = new System.Drawing.Size(86, 13);
            this.lblTipoVivienda.TabIndex = 32;
            this.lblTipoVivienda.Text = "* Tipo vivienda:";
            // 
            // cbxUbicacion
            // 
            this.cbxUbicacion.FormattingEnabled = true;
            this.cbxUbicacion.Items.AddRange(new object[] {
            "Norte",
            "Sur",
            "Oriente",
            "Occidente"});
            this.cbxUbicacion.Location = new System.Drawing.Point(211, 132);
            this.cbxUbicacion.Name = "cbxUbicacion";
            this.cbxUbicacion.Size = new System.Drawing.Size(104, 21);
            this.cbxUbicacion.TabIndex = 31;
            // 
            // lblUbicacionInmue
            // 
            this.lblUbicacionInmue.AutoSize = true;
            this.lblUbicacionInmue.Location = new System.Drawing.Point(126, 134);
            this.lblUbicacionInmue.Name = "lblUbicacionInmue";
            this.lblUbicacionInmue.Size = new System.Drawing.Size(69, 13);
            this.lblUbicacionInmue.TabIndex = 30;
            this.lblUbicacionInmue.Text = "* Ubicación:";
            // 
            // cbxDescripcionInmueble
            // 
            this.cbxDescripcionInmueble.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbxDescripcionInmueble.Location = new System.Drawing.Point(213, 94);
            this.cbxDescripcionInmueble.Name = "cbxDescripcionInmueble";
            this.cbxDescripcionInmueble.Size = new System.Drawing.Size(501, 22);
            this.cbxDescripcionInmueble.TabIndex = 29;
            // 
            // lbnDescripcionPublicacion
            // 
            this.lbnDescripcionPublicacion.AutoSize = true;
            this.lbnDescripcionPublicacion.Location = new System.Drawing.Point(126, 93);
            this.lbnDescripcionPublicacion.Name = "lbnDescripcionPublicacion";
            this.lbnDescripcionPublicacion.Size = new System.Drawing.Size(67, 13);
            this.lbnDescripcionPublicacion.TabIndex = 28;
            this.lbnDescripcionPublicacion.Text = "Descripción";
            // 
            // cbxNombrePublicacion
            // 
            this.cbxNombrePublicacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbxNombrePublicacion.Location = new System.Drawing.Point(211, 55);
            this.cbxNombrePublicacion.Name = "cbxNombrePublicacion";
            this.cbxNombrePublicacion.Size = new System.Drawing.Size(504, 22);
            this.cbxNombrePublicacion.TabIndex = 27;
            // 
            // lbnTituloPublicacion
            // 
            this.lbnTituloPublicacion.AutoSize = true;
            this.lbnTituloPublicacion.Location = new System.Drawing.Point(113, 58);
            this.lbnTituloPublicacion.Name = "lbnTituloPublicacion";
            this.lbnTituloPublicacion.Size = new System.Drawing.Size(108, 13);
            this.lbnTituloPublicacion.TabIndex = 26;
            this.lbnTituloPublicacion.Text = "* Titulo publicación";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Cyan;
            this.panel6.Location = new System.Drawing.Point(111, 30);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(630, 10);
            this.panel6.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(208, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(524, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Llene los siguientes campos para crear una publicación sobre un inmueble";
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
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.panel3);
            this.pnlPrincipal.Controls.Add(this.pnlInicioSuperior);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(737, 528);
            this.pnlPrincipal.TabIndex = 3;
            // 
            // pnlInicioSuperior
            // 
            this.pnlInicioSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(204)))));
            this.pnlInicioSuperior.Controls.Add(this.panel2);
            this.pnlInicioSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlInicioSuperior.Name = "pnlInicioSuperior";
            this.pnlInicioSuperior.Size = new System.Drawing.Size(735, 153);
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
            this.panel2.Size = new System.Drawing.Size(735, 100);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblNombreUsuario);
            this.panel1.Controls.Add(this.lblBienvenido);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Location = new System.Drawing.Point(622, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 101);
            this.panel1.TabIndex = 5;
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
            // RegistroInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 528);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "RegistroInmueble";
            this.Text = "RegistroInmueble";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlInicioSuperior.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel4;
        private Label label3;
        private Label lblQueSomos;
        private Label lblIniciarSesion;
        private Label lblAyuda;
        private Label MenuRegistroUsuario;
        private Panel panel5;
        private Label lblNombreUsuario;
        private Label lblBienvenido;
        private Panel panel3;
        private Label label4;
        private Label label1;
        private Panel pnlPrincipal;
        private Panel pnlInicioSuperior;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pbxLogo;
        private TextBox cbxDescripcionInmueble;
        private Label lbnDescripcionPublicacion;
        private TextBox cbxNombrePublicacion;
        private Label lbnTituloPublicacion;
        private Panel panel6;
        private Label lblServiciosInclu;
        private ComboBox cbxTipoVivienda;
        private Label lblTipoVivienda;
        private ComboBox cbxUbicacion;
        private Label lblUbicacionInmue;
        private Label lbnAmoblado;
        private RadioButton rbGas;
        private RadioButton rbLavadora;
        private RadioButton rbTv;
        private RadioButton rbWifi;
        private RadioButton rbLuz;
        private RadioButton rbAgua;
        private TextBox cbxTelefono;
        private Label lbnTelefono;
        private ComboBox cbxParqueadero;
        private Label lbnParqueadero;
        private ComboBox cbxAnimales;
        private ComboBox cbxAmoblado;
        private Button bntRegistrarInmueble;
        private TextBox cbxPrecio;
        private Label lbnPrecio;
    }
}