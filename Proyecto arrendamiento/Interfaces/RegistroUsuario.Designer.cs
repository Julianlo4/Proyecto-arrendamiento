using System.Drawing;
using System.Windows.Forms;

namespace ArriendoPrototipo
{
    partial class RegistroUsuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuario));
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.txtSegundoNombre = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtSegundoApell = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtSegundoApellido = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtTelefono = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtCorreo = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtIdentificacion = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtContraseña = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtNombreUsuario = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtPrimerNombre = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btn_volverMenuPrincipal = new System.Windows.Forms.Button();
            this.btn_RegistrarUsuario = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.lblSugerenciaRegistro = new System.Windows.Forms.Label();
            this.pnlInicioSuperior = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblTextoSupInicio = new System.Windows.Forms.Label();
            this.pnlnicioDerecha = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MenuRegistroUsuario = new System.Windows.Forms.Label();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.lblQueSomos = new System.Windows.Forms.Label();
            this.lblPaginaPrincipal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.pnlPrincipal.SuspendLayout();
            this.pnlInicioSuperior.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlnicioDerecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.cbxGenero);
            this.pnlPrincipal.Controls.Add(this.txtSegundoNombre);
            this.pnlPrincipal.Controls.Add(this.txtSegundoApell);
            this.pnlPrincipal.Controls.Add(this.txtSegundoApellido);
            this.pnlPrincipal.Controls.Add(this.txtTelefono);
            this.pnlPrincipal.Controls.Add(this.txtCorreo);
            this.pnlPrincipal.Controls.Add(this.txtIdentificacion);
            this.pnlPrincipal.Controls.Add(this.txtContraseña);
            this.pnlPrincipal.Controls.Add(this.txtNombreUsuario);
            this.pnlPrincipal.Controls.Add(this.txtPrimerNombre);
            this.pnlPrincipal.Controls.Add(this.lblNombreUsuario);
            this.pnlPrincipal.Controls.Add(this.btn_volverMenuPrincipal);
            this.pnlPrincipal.Controls.Add(this.btn_RegistrarUsuario);
            this.pnlPrincipal.Controls.Add(this.panel5);
            this.pnlPrincipal.Controls.Add(this.panel4);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Controls.Add(this.dtpFechaNac);
            this.pnlPrincipal.Controls.Add(this.lblCorreo);
            this.pnlPrincipal.Controls.Add(this.lblContraseña);
            this.pnlPrincipal.Controls.Add(this.lblFechaNacimiento);
            this.pnlPrincipal.Controls.Add(this.lblTelefono);
            this.pnlPrincipal.Controls.Add(this.lblIdentificacion);
            this.pnlPrincipal.Controls.Add(this.lblGenero);
            this.pnlPrincipal.Controls.Add(this.lblSegundoApellido);
            this.pnlPrincipal.Controls.Add(this.lblSegundoNombre);
            this.pnlPrincipal.Controls.Add(this.lblPrimerApellido);
            this.pnlPrincipal.Controls.Add(this.lblPrimerNombre);
            this.pnlPrincipal.Controls.Add(this.lblSugerenciaRegistro);
            this.pnlPrincipal.Controls.Add(this.pnlInicioSuperior);
            this.pnlPrincipal.Controls.Add(this.pnlnicioDerecha);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(686, 529);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSegundoNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSegundoNombre.BorderRadius = 0;
            this.txtSegundoNombre.BorderSize = 2;
            this.txtSegundoNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtSegundoNombre.Location = new System.Drawing.Point(515, 201);
            this.txtSegundoNombre.Multiline = false;
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Padding = new System.Windows.Forms.Padding(7);
            this.txtSegundoNombre.PasswordChar = false;
            this.txtSegundoNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSegundoNombre.PlaceholderText = "";
            this.txtSegundoNombre.Size = new System.Drawing.Size(151, 29);
            this.txtSegundoNombre.TabIndex = 37;
            this.txtSegundoNombre.Texts = "";
            this.txtSegundoNombre.UnderlinedStyle = false;
            // 
            // txtSegundoApell
            // 
            this.txtSegundoApell.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSegundoApell.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSegundoApell.BorderRadius = 0;
            this.txtSegundoApell.BorderSize = 2;
            this.txtSegundoApell.ForeColor = System.Drawing.Color.DimGray;
            this.txtSegundoApell.Location = new System.Drawing.Point(515, 240);
            this.txtSegundoApell.Multiline = false;
            this.txtSegundoApell.Name = "txtSegundoApell";
            this.txtSegundoApell.Padding = new System.Windows.Forms.Padding(7);
            this.txtSegundoApell.PasswordChar = false;
            this.txtSegundoApell.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSegundoApell.PlaceholderText = "";
            this.txtSegundoApell.Size = new System.Drawing.Size(151, 29);
            this.txtSegundoApell.TabIndex = 36;
            this.txtSegundoApell.Texts = "";
            this.txtSegundoApell.UnderlinedStyle = false;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSegundoApellido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSegundoApellido.BorderRadius = 0;
            this.txtSegundoApellido.BorderSize = 2;
            this.txtSegundoApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtSegundoApellido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSegundoApellido.Location = new System.Drawing.Point(217, 240);
            this.txtSegundoApellido.Multiline = false;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Padding = new System.Windows.Forms.Padding(7);
            this.txtSegundoApellido.PasswordChar = false;
            this.txtSegundoApellido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSegundoApellido.PlaceholderText = "";
            this.txtSegundoApellido.Size = new System.Drawing.Size(151, 29);
            this.txtSegundoApellido.TabIndex = 35;
            this.txtSegundoApellido.Texts = "";
            this.txtSegundoApellido.UnderlinedStyle = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTelefono.BorderRadius = 0;
            this.txtTelefono.BorderSize = 2;
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(187, 330);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.Size = new System.Drawing.Size(151, 29);
            this.txtTelefono.TabIndex = 34;
            this.txtTelefono.Texts = "";
            this.txtTelefono.UnderlinedStyle = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCorreo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCorreo.BorderRadius = 0;
            this.txtCorreo.BorderSize = 2;
            this.txtCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCorreo.Location = new System.Drawing.Point(525, 330);
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Padding = new System.Windows.Forms.Padding(7);
            this.txtCorreo.PasswordChar = false;
            this.txtCorreo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCorreo.PlaceholderText = "";
            this.txtCorreo.Size = new System.Drawing.Size(151, 29);
            this.txtCorreo.TabIndex = 33;
            this.txtCorreo.Texts = "";
            this.txtCorreo.UnderlinedStyle = false;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtIdentificacion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIdentificacion.BorderRadius = 0;
            this.txtIdentificacion.BorderSize = 2;
            this.txtIdentificacion.ForeColor = System.Drawing.Color.DimGray;
            this.txtIdentificacion.Location = new System.Drawing.Point(230, 378);
            this.txtIdentificacion.Multiline = false;
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Padding = new System.Windows.Forms.Padding(7);
            this.txtIdentificacion.PasswordChar = false;
            this.txtIdentificacion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdentificacion.PlaceholderText = "";
            this.txtIdentificacion.Size = new System.Drawing.Size(151, 29);
            this.txtIdentificacion.TabIndex = 32;
            this.txtIdentificacion.Texts = "";
            this.txtIdentificacion.UnderlinedStyle = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtContraseña.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtContraseña.BorderRadius = 0;
            this.txtContraseña.BorderSize = 2;
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.Location = new System.Drawing.Point(495, 378);
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Padding = new System.Windows.Forms.Padding(7);
            this.txtContraseña.PasswordChar = false;
            this.txtContraseña.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtContraseña.PlaceholderText = "";
            this.txtContraseña.Size = new System.Drawing.Size(151, 29);
            this.txtContraseña.TabIndex = 31;
            this.txtContraseña.Texts = "";
            this.txtContraseña.UnderlinedStyle = false;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNombreUsuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombreUsuario.BorderRadius = 0;
            this.txtNombreUsuario.BorderSize = 2;
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreUsuario.Location = new System.Drawing.Point(224, 420);
            this.txtNombreUsuario.Multiline = false;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Padding = new System.Windows.Forms.Padding(7);
            this.txtNombreUsuario.PasswordChar = false;
            this.txtNombreUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreUsuario.PlaceholderText = "";
            this.txtNombreUsuario.Size = new System.Drawing.Size(151, 29);
            this.txtNombreUsuario.TabIndex = 30;
            this.txtNombreUsuario.Texts = "";
            this.txtNombreUsuario.UnderlinedStyle = false;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPrimerNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPrimerNombre.BorderRadius = 0;
            this.txtPrimerNombre.BorderSize = 2;
            this.txtPrimerNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrimerNombre.Location = new System.Drawing.Point(217, 201);
            this.txtPrimerNombre.Multiline = false;
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Padding = new System.Windows.Forms.Padding(7);
            this.txtPrimerNombre.PasswordChar = false;
            this.txtPrimerNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrimerNombre.PlaceholderText = "";
            this.txtPrimerNombre.Size = new System.Drawing.Size(151, 29);
            this.txtPrimerNombre.TabIndex = 29;
            this.txtPrimerNombre.Texts = "";
            this.txtPrimerNombre.UnderlinedStyle = false;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(121, 420);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(106, 13);
            this.lblNombreUsuario.TabIndex = 28;
            this.lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // btn_volverMenuPrincipal
            // 
            this.btn_volverMenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btn_volverMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_volverMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volverMenuPrincipal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_volverMenuPrincipal.Location = new System.Drawing.Point(110, 477);
            this.btn_volverMenuPrincipal.Name = "btn_volverMenuPrincipal";
            this.btn_volverMenuPrincipal.Size = new System.Drawing.Size(41, 36);
            this.btn_volverMenuPrincipal.TabIndex = 27;
            this.btn_volverMenuPrincipal.UseVisualStyleBackColor = false;
            // 
            // btn_RegistrarUsuario
            // 
            this.btn_RegistrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_RegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RegistrarUsuario.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Italic);
            this.btn_RegistrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_RegistrarUsuario.Location = new System.Drawing.Point(340, 480);
            this.btn_RegistrarUsuario.Name = "btn_RegistrarUsuario";
            this.btn_RegistrarUsuario.Size = new System.Drawing.Size(147, 29);
            this.btn_RegistrarUsuario.TabIndex = 26;
            this.btn_RegistrarUsuario.Text = "REGISTRARSE";
            this.btn_RegistrarUsuario.UseVisualStyleBackColor = false;
            this.btn_RegistrarUsuario.Click += new System.EventHandler(this.btn_RegistrarUsuario_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Cyan;
            this.panel5.Location = new System.Drawing.Point(105, 455);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(581, 16);
            this.panel5.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Cyan;
            this.panel4.Location = new System.Drawing.Point(110, 186);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(576, 9);
            this.panel4.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.label1.Location = new System.Drawing.Point(112, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Los campos con * son obligatorios.";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(237, 286);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(172, 22);
            this.dtpFechaNac.TabIndex = 21;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(409, 330);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(110, 13);
            this.lblCorreo.TabIndex = 12;
            this.lblCorreo.Text = "*Correo eléctronico:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(415, 378);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(74, 13);
            this.lblContraseña.TabIndex = 11;
            this.lblContraseña.Text = "*Contraseña:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(112, 286);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(121, 13);
            this.lblFechaNacimiento.TabIndex = 10;
            this.lblFechaNacimiento.Text = "*Fecha de nacimiento:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(121, 330);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(60, 13);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "*Teléfono:";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(121, 378);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(108, 13);
            this.lblIdentificacion.TabIndex = 8;
            this.lblIdentificacion.Text = "*Identificación(C.C):";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(415, 286);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(53, 13);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "*Género:";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Location = new System.Drawing.Point(409, 240);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(102, 13);
            this.lblSegundoApellido.TabIndex = 6;
            this.lblSegundoApellido.Text = "Segundo apellido:";
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Location = new System.Drawing.Point(409, 201);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(100, 13);
            this.lblSegundoNombre.TabIndex = 5;
            this.lblSegundoNombre.Text = "Segundo nombre:";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Location = new System.Drawing.Point(112, 240);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(92, 13);
            this.lblPrimerApellido.TabIndex = 4;
            this.lblPrimerApellido.Text = "*Primer apellido:";
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Location = new System.Drawing.Point(113, 201);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(90, 13);
            this.lblPrimerNombre.TabIndex = 3;
            this.lblPrimerNombre.Text = "*Primer nombre:";
            // 
            // lblSugerenciaRegistro
            // 
            this.lblSugerenciaRegistro.AutoSize = true;
            this.lblSugerenciaRegistro.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.lblSugerenciaRegistro.Location = new System.Drawing.Point(110, 155);
            this.lblSugerenciaRegistro.Name = "lblSugerenciaRegistro";
            this.lblSugerenciaRegistro.Size = new System.Drawing.Size(628, 15);
            this.lblSugerenciaRegistro.TabIndex = 2;
            this.lblSugerenciaRegistro.Text = "Llene los siguientes campos para poder crear su cuena y acceder a todas las funci" +
    "ones que ofrece alojamientos pacho.";
            // 
            // pnlInicioSuperior
            // 
            this.pnlInicioSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(204)))));
            this.pnlInicioSuperior.Controls.Add(this.panel2);
            this.pnlInicioSuperior.Controls.Add(this.pbxLogo);
            this.pnlInicioSuperior.Controls.Add(this.lblTextoSupInicio);
            this.pnlInicioSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInicioSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlInicioSuperior.Name = "pnlInicioSuperior";
            this.pnlInicioSuperior.Size = new System.Drawing.Size(686, 153);
            this.pnlInicioSuperior.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(214)))), ((int)(((byte)(215)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 100);
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
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(493, 98);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(57, 54);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // lblTextoSupInicio
            // 
            this.lblTextoSupInicio.AutoSize = true;
            this.lblTextoSupInicio.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblTextoSupInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.lblTextoSupInicio.Location = new System.Drawing.Point(177, 102);
            this.lblTextoSupInicio.Name = "lblTextoSupInicio";
            this.lblTextoSupInicio.Size = new System.Drawing.Size(310, 35);
            this.lblTextoSupInicio.TabIndex = 0;
            this.lblTextoSupInicio.Text = "Registro de Usuario";
            // 
            // pnlnicioDerecha
            // 
            this.pnlnicioDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(204)))));
            this.pnlnicioDerecha.Controls.Add(this.panel3);
            this.pnlnicioDerecha.Controls.Add(this.MenuRegistroUsuario);
            this.pnlnicioDerecha.Controls.Add(this.lblAyuda);
            this.pnlnicioDerecha.Controls.Add(this.lblQueSomos);
            this.pnlnicioDerecha.Controls.Add(this.lblPaginaPrincipal);
            this.pnlnicioDerecha.Controls.Add(this.panel1);
            this.pnlnicioDerecha.Location = new System.Drawing.Point(0, 146);
            this.pnlnicioDerecha.Name = "pnlnicioDerecha";
            this.pnlnicioDerecha.Size = new System.Drawing.Size(107, 325);
            this.pnlnicioDerecha.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 9);
            this.panel3.TabIndex = 5;
            // 
            // MenuRegistroUsuario
            // 
            this.MenuRegistroUsuario.AutoSize = true;
            this.MenuRegistroUsuario.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 20.25F);
            this.MenuRegistroUsuario.ForeColor = System.Drawing.Color.LightCoral;
            this.MenuRegistroUsuario.Location = new System.Drawing.Point(10, 11);
            this.MenuRegistroUsuario.Name = "MenuRegistroUsuario";
            this.MenuRegistroUsuario.Size = new System.Drawing.Size(79, 34);
            this.MenuRegistroUsuario.TabIndex = 4;
            this.MenuRegistroUsuario.Text = "MENÚ";
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.lblAyuda.Location = new System.Drawing.Point(24, 120);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(54, 20);
            this.lblAyuda.TabIndex = 3;
            this.lblAyuda.Text = "Ayuda";
            // 
            // lblQueSomos
            // 
            this.lblQueSomos.AutoSize = true;
            this.lblQueSomos.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblQueSomos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.lblQueSomos.Location = new System.Drawing.Point(10, 88);
            this.lblQueSomos.Name = "lblQueSomos";
            this.lblQueSomos.Size = new System.Drawing.Size(101, 20);
            this.lblQueSomos.TabIndex = 2;
            this.lblQueSomos.Text = "¿Qué somos?";
            // 
            // lblPaginaPrincipal
            // 
            this.lblPaginaPrincipal.AutoSize = true;
            this.lblPaginaPrincipal.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblPaginaPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(145)))), ((int)(((byte)(147)))));
            this.lblPaginaPrincipal.Location = new System.Drawing.Point(2, 55);
            this.lblPaginaPrincipal.Name = "lblPaginaPrincipal";
            this.lblPaginaPrincipal.Size = new System.Drawing.Size(120, 20);
            this.lblPaginaPrincipal.TabIndex = 1;
            this.lblPaginaPrincipal.Text = "Página principal";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(105, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 288);
            this.panel1.TabIndex = 0;
            // 
            // cbxGenero
            // 
            this.cbxGenero.AutoCompleteCustomSource.AddRange(new string[] {
            "Maculino",
            "Femenino"});
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbxGenero.Location = new System.Drawing.Point(493, 286);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(146, 21);
            this.cbxGenero.TabIndex = 38;
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 529);
            this.Controls.Add(this.pnlPrincipal);
            this.Name = "RegistroUsuario";
            this.Text = "Form1";
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlInicioSuperior.ResumeLayout(false);
            this.pnlInicioSuperior.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlnicioDerecha.ResumeLayout(false);
            this.pnlnicioDerecha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlPrincipal;
        private Panel pnlnicioDerecha;
        private Panel pnlInicioSuperior;
        private Panel panel1;
        private Label lblTextoSupInicio;
        private Label lblPaginaPrincipal;
        private Label lblAyuda;
        private Label lblQueSomos;
        private Label lblSugerenciaRegistro;
        private PictureBox pbxLogo;
        private Label lblPrimerNombre;
        private Label lblCorreo;
        private Label lblContraseña;
        private Label lblFechaNacimiento;
        private Label lblTelefono;
        private Label lblIdentificacion;
        private Label lblGenero;
        private Label lblSegundoApellido;
        private Label lblSegundoNombre;
        private Label lblPrimerApellido;
        private DateTimePicker dtpFechaNac;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label MenuRegistroUsuario;
        private Panel panel3;
        private Panel panel4;
        private Button btn_RegistrarUsuario;
        private Panel panel5;
        private Button btn_volverMenuPrincipal;
        private Label lblNombreUsuario;
        private Proyecto_arrendamiento.Apariencia.CustomTextBox txtPrimerNombre;
        private Proyecto_arrendamiento.Apariencia.CustomTextBox txtSegundoNombre;
        private Proyecto_arrendamiento.Apariencia.CustomTextBox txtSegundoApell;
        private Proyecto_arrendamiento.Apariencia.CustomTextBox txtSegundoApellido;
        private Proyecto_arrendamiento.Apariencia.CustomTextBox txtTelefono;
        private Proyecto_arrendamiento.Apariencia.CustomTextBox txtCorreo;
        private Proyecto_arrendamiento.Apariencia.CustomTextBox txtIdentificacion;
        private Proyecto_arrendamiento.Apariencia.CustomTextBox txtContraseña;
        private Proyecto_arrendamiento.Apariencia.CustomTextBox txtNombreUsuario;
        private ComboBox cbxGenero;
    }
}