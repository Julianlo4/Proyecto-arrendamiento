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
            this.btn_RegistrarUsuario = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MenuRegistroUsuario = new System.Windows.Forms.Label();
            this.lblQueSomos = new System.Windows.Forms.Label();
            this.lblPaginaPrincipal = new System.Windows.Forms.Label();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.btn_volverMenuPrincipal = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblSugerenciaRegistro = new System.Windows.Forms.Label();
            this.pnlInicioSuperior = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.lblTextoSupInicio = new System.Windows.Forms.Label();
            this.txtContraseña = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtCorreo = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtPrimerNombre = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtSegundoApell = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtSegundoNombre = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtSegundoApellido = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtTelefono = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtNombreUsuario = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtIdentificacion = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.pnlPrincipal.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlInicioSuperior.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
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
            this.pnlPrincipal.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(830, 529);
            this.pnlPrincipal.TabIndex = 0;
            this.pnlPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPrincipal_Paint_1);
            // 
            // btn_RegistrarUsuario
            // 
            this.btn_RegistrarUsuario.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_RegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RegistrarUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_RegistrarUsuario.Location = new System.Drawing.Point(414, 480);
            this.btn_RegistrarUsuario.Name = "btn_RegistrarUsuario";
            this.btn_RegistrarUsuario.Size = new System.Drawing.Size(147, 29);
            this.btn_RegistrarUsuario.TabIndex = 26;
            this.btn_RegistrarUsuario.Text = "REGISTRARSE";
            this.btn_RegistrarUsuario.UseVisualStyleBackColor = false;
            this.btn_RegistrarUsuario.Click += new System.EventHandler(this.btn_RegistrarUsuario_Click_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.PeachPuff;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.MenuRegistroUsuario, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblQueSomos, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblPaginaPrincipal, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblAyuda, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 153);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(130, 376);
            this.tableLayoutPanel2.TabIndex = 39;
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
            // lblQueSomos
            // 
            this.lblQueSomos.AutoSize = true;
            this.lblQueSomos.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueSomos.ForeColor = System.Drawing.Color.LightCoral;
            this.lblQueSomos.Location = new System.Drawing.Point(3, 121);
            this.lblQueSomos.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblQueSomos.Name = "lblQueSomos";
            this.lblQueSomos.Size = new System.Drawing.Size(83, 46);
            this.lblQueSomos.TabIndex = 2;
            this.lblQueSomos.Text = "¿Qué somos?";
            // 
            // lblPaginaPrincipal
            // 
            this.lblPaginaPrincipal.AutoSize = true;
            this.lblPaginaPrincipal.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginaPrincipal.ForeColor = System.Drawing.Color.LightCoral;
            this.lblPaginaPrincipal.Location = new System.Drawing.Point(3, 55);
            this.lblPaginaPrincipal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblPaginaPrincipal.Name = "lblPaginaPrincipal";
            this.lblPaginaPrincipal.Size = new System.Drawing.Size(93, 46);
            this.lblPaginaPrincipal.TabIndex = 1;
            this.lblPaginaPrincipal.Text = "Página principal";
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAyuda.Location = new System.Drawing.Point(3, 187);
            this.lblAyuda.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(69, 23);
            this.lblAyuda.TabIndex = 3;
            this.lblAyuda.Text = "Ayuda";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.43402F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.82991F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.51613F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblPrimerNombre, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtContraseña, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCorreo, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbxGenero, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPrimerNombre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSegundoApell, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSegundoNombre, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPrimerApellido, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblContraseña, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSegundoApellido, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTelefono, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCorreo, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtNombreUsuario, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaNacimiento, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNombreUsuario, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblGenero, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTelefono, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblIdentificacion, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSegundoApellido, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSegundoNombre, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaNac, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtIdentificacion, 1, 4);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(136, 197);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 252);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Location = new System.Drawing.Point(44, 13);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(106, 16);
            this.lblPrimerNombre.TabIndex = 3;
            this.lblPrimerNombre.Text = "*Primer nombre:";
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
            this.cbxGenero.Location = new System.Drawing.Point(513, 87);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(166, 24);
            this.cbxGenero.TabIndex = 38;
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Location = new System.Drawing.Point(44, 55);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(106, 16);
            this.lblPrimerApellido.TabIndex = 4;
            this.lblPrimerApellido.Text = "*Primer apellido:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(422, 181);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(85, 16);
            this.lblContraseña.TabIndex = 11;
            this.lblContraseña.Text = "*Contraseña:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(433, 131);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(74, 32);
            this.lblCorreo.TabIndex = 12;
            this.lblCorreo.Text = "*Correo eléctronico:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(12, 97);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(138, 16);
            this.lblFechaNacimiento.TabIndex = 10;
            this.lblFechaNacimiento.Text = "*Fecha de nacimiento:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(34, 210);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(116, 42);
            this.lblNombreUsuario.TabIndex = 28;
            this.lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // lblGenero
            // 
            this.lblGenero.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(446, 97);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(61, 16);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "*Género:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(80, 139);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(70, 16);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "*Teléfono:";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(25, 181);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(125, 16);
            this.lblIdentificacion.TabIndex = 8;
            this.lblIdentificacion.Text = "*Identificación(C.C):";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Location = new System.Drawing.Point(446, 47);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(61, 32);
            this.lblSegundoApellido.TabIndex = 6;
            this.lblSegundoApellido.Text = "Segundo apellido:";
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Location = new System.Drawing.Point(446, 5);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(61, 32);
            this.lblSegundoNombre.TabIndex = 5;
            this.lblSegundoNombre.Text = "Segundo nombre:";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(156, 87);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(252, 23);
            this.dtpFechaNac.TabIndex = 21;
            // 
            // btn_volverMenuPrincipal
            // 
            this.btn_volverMenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btn_volverMenuPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_volverMenuPrincipal.BackgroundImage")));
            this.btn_volverMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_volverMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volverMenuPrincipal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_volverMenuPrincipal.Location = new System.Drawing.Point(136, 477);
            this.btn_volverMenuPrincipal.Name = "btn_volverMenuPrincipal";
            this.btn_volverMenuPrincipal.Size = new System.Drawing.Size(41, 36);
            this.btn_volverMenuPrincipal.TabIndex = 27;
            this.btn_volverMenuPrincipal.UseVisualStyleBackColor = false;
            this.btn_volverMenuPrincipal.Click += new System.EventHandler(this.btn_volverMenuPrincipal_Click_1);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.SkyBlue;
            this.panel5.Location = new System.Drawing.Point(105, 455);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(725, 19);
            this.panel5.TabIndex = 25;
            // 
            // lblSugerenciaRegistro
            // 
            this.lblSugerenciaRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSugerenciaRegistro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSugerenciaRegistro.Location = new System.Drawing.Point(136, 156);
            this.lblSugerenciaRegistro.Name = "lblSugerenciaRegistro";
            this.lblSugerenciaRegistro.Size = new System.Drawing.Size(689, 32);
            this.lblSugerenciaRegistro.TabIndex = 2;
            this.lblSugerenciaRegistro.Text = "Llene los siguientes campos para poder crear su cuena y acceder a todas las funci" +
    "ones que ofrece alojamientos pacho.\r\nLos campos con * son obligatorios\r\n";
            this.lblSugerenciaRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInicioSuperior
            // 
            this.pnlInicioSuperior.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlInicioSuperior.Controls.Add(this.panel2);
            this.pnlInicioSuperior.Controls.Add(this.pbxLogo);
            this.pnlInicioSuperior.Controls.Add(this.lblTextoSupInicio);
            this.pnlInicioSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInicioSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlInicioSuperior.Name = "pnlInicioSuperior";
            this.pnlInicioSuperior.Size = new System.Drawing.Size(830, 153);
            this.pnlInicioSuperior.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 100);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(275, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alojamientos Pacho";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
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
            this.lblTextoSupInicio.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoSupInicio.ForeColor = System.Drawing.Color.LightCoral;
            this.lblTextoSupInicio.Location = new System.Drawing.Point(242, 113);
            this.lblTextoSupInicio.Name = "lblTextoSupInicio";
            this.lblTextoSupInicio.Size = new System.Drawing.Size(241, 23);
            this.lblTextoSupInicio.TabIndex = 0;
            this.lblTextoSupInicio.Text = "REGISTRO DE USUARIO";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderColor = System.Drawing.Color.Transparent;
            this.txtContraseña.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtContraseña.BorderRadius = 0;
            this.txtContraseña.BorderSize = 2;
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.Location = new System.Drawing.Point(513, 171);
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtContraseña.PasswordChar = false;
            this.txtContraseña.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtContraseña.PlaceholderText = "";
            this.txtContraseña.Size = new System.Drawing.Size(166, 31);
            this.txtContraseña.TabIndex = 31;
            this.txtContraseña.Texts = "";
            this.txtContraseña.UnderlinedStyle = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderColor = System.Drawing.Color.Transparent;
            this.txtCorreo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCorreo.BorderRadius = 0;
            this.txtCorreo.BorderSize = 2;
            this.txtCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCorreo.Location = new System.Drawing.Point(513, 129);
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtCorreo.PasswordChar = false;
            this.txtCorreo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCorreo.PlaceholderText = "";
            this.txtCorreo.Size = new System.Drawing.Size(166, 31);
            this.txtCorreo.TabIndex = 33;
            this.txtCorreo.Texts = "";
            this.txtCorreo.UnderlinedStyle = false;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BorderColor = System.Drawing.Color.Transparent;
            this.txtPrimerNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPrimerNombre.BorderRadius = 0;
            this.txtPrimerNombre.BorderSize = 2;
            this.txtPrimerNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrimerNombre.Location = new System.Drawing.Point(156, 3);
            this.txtPrimerNombre.Multiline = false;
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtPrimerNombre.PasswordChar = false;
            this.txtPrimerNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrimerNombre.PlaceholderText = "";
            this.txtPrimerNombre.Size = new System.Drawing.Size(213, 31);
            this.txtPrimerNombre.TabIndex = 29;
            this.txtPrimerNombre.Texts = "";
            this.txtPrimerNombre.UnderlinedStyle = false;
            // 
            // txtSegundoApell
            // 
            this.txtSegundoApell.BorderColor = System.Drawing.Color.Transparent;
            this.txtSegundoApell.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSegundoApell.BorderRadius = 0;
            this.txtSegundoApell.BorderSize = 2;
            this.txtSegundoApell.ForeColor = System.Drawing.Color.DimGray;
            this.txtSegundoApell.Location = new System.Drawing.Point(513, 45);
            this.txtSegundoApell.Multiline = false;
            this.txtSegundoApell.Name = "txtSegundoApell";
            this.txtSegundoApell.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtSegundoApell.PasswordChar = false;
            this.txtSegundoApell.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSegundoApell.PlaceholderText = "";
            this.txtSegundoApell.Size = new System.Drawing.Size(166, 31);
            this.txtSegundoApell.TabIndex = 36;
            this.txtSegundoApell.Texts = "";
            this.txtSegundoApell.UnderlinedStyle = false;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.BorderColor = System.Drawing.Color.Transparent;
            this.txtSegundoNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSegundoNombre.BorderRadius = 0;
            this.txtSegundoNombre.BorderSize = 2;
            this.txtSegundoNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtSegundoNombre.Location = new System.Drawing.Point(513, 3);
            this.txtSegundoNombre.Multiline = false;
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtSegundoNombre.PasswordChar = false;
            this.txtSegundoNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSegundoNombre.PlaceholderText = "";
            this.txtSegundoNombre.Size = new System.Drawing.Size(166, 31);
            this.txtSegundoNombre.TabIndex = 37;
            this.txtSegundoNombre.Texts = "";
            this.txtSegundoNombre.UnderlinedStyle = false;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BorderColor = System.Drawing.Color.Transparent;
            this.txtSegundoApellido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSegundoApellido.BorderRadius = 0;
            this.txtSegundoApellido.BorderSize = 2;
            this.txtSegundoApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtSegundoApellido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSegundoApellido.Location = new System.Drawing.Point(156, 45);
            this.txtSegundoApellido.Multiline = false;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtSegundoApellido.PasswordChar = false;
            this.txtSegundoApellido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSegundoApellido.PlaceholderText = "";
            this.txtSegundoApellido.Size = new System.Drawing.Size(213, 31);
            this.txtSegundoApellido.TabIndex = 35;
            this.txtSegundoApellido.Texts = "";
            this.txtSegundoApellido.UnderlinedStyle = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderColor = System.Drawing.Color.Transparent;
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTelefono.BorderRadius = 0;
            this.txtTelefono.BorderSize = 2;
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(156, 129);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.Size = new System.Drawing.Size(240, 31);
            this.txtTelefono.TabIndex = 34;
            this.txtTelefono.Texts = "";
            this.txtTelefono.UnderlinedStyle = false;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BorderColor = System.Drawing.Color.Transparent;
            this.txtNombreUsuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombreUsuario.BorderRadius = 0;
            this.txtNombreUsuario.BorderSize = 2;
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreUsuario.Location = new System.Drawing.Point(156, 213);
            this.txtNombreUsuario.Multiline = false;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtNombreUsuario.PasswordChar = false;
            this.txtNombreUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreUsuario.PlaceholderText = "";
            this.txtNombreUsuario.Size = new System.Drawing.Size(240, 31);
            this.txtNombreUsuario.TabIndex = 30;
            this.txtNombreUsuario.Texts = "";
            this.txtNombreUsuario.UnderlinedStyle = false;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdentificacion.BorderColor = System.Drawing.Color.Transparent;
            this.txtIdentificacion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIdentificacion.BorderRadius = 0;
            this.txtIdentificacion.BorderSize = 2;
            this.txtIdentificacion.ForeColor = System.Drawing.Color.DimGray;
            this.txtIdentificacion.Location = new System.Drawing.Point(156, 176);
            this.txtIdentificacion.Multiline = false;
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtIdentificacion.PasswordChar = false;
            this.txtIdentificacion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdentificacion.PlaceholderText = "";
            this.txtIdentificacion.Size = new System.Drawing.Size(240, 31);
            this.txtIdentificacion.TabIndex = 32;
            this.txtIdentificacion.Texts = "";
            this.txtIdentificacion.UnderlinedStyle = false;
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 529);
            this.Controls.Add(this.pnlPrincipal);
            this.MinimumSize = new System.Drawing.Size(846, 568);
            this.Name = "RegistroUsuario";
            this.Text = "Registro Usuario";
            this.pnlPrincipal.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlInicioSuperior.ResumeLayout(false);
            this.pnlInicioSuperior.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlPrincipal;
        private Panel pnlInicioSuperior;
        private Label lblTextoSupInicio;
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
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
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
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label MenuRegistroUsuario;
        private Label lblQueSomos;
        private Label lblPaginaPrincipal;
        private Label lblAyuda;
    }
}