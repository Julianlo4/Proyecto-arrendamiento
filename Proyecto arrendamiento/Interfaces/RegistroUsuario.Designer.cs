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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.btn_RegistrarUsuario = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MenuRegistroUsuario = new System.Windows.Forms.Label();
            this.lblQueSomos = new System.Windows.Forms.Label();
            this.lblPaginaPrincipal = new System.Windows.Forms.Label();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.txtContraseña = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtCorreo = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.txtPrimerNombre = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtSegundoApell = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtSegundoNombre = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.txtTelefono = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtIdentificacion = new Proyecto_arrendamiento.Apariencia.CustomTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblSugerenciaRegistro = new System.Windows.Forms.Label();
            this.pnlInicioSuperior = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTextoSupInicio = new System.Windows.Forms.Label();
            this.btn_volverMenuPrincipal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
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
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1107, 651);
            this.pnlPrincipal.TabIndex = 0;
            this.pnlPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPrincipal_Paint_1);
            // 
            // btn_RegistrarUsuario
            // 
            this.btn_RegistrarUsuario.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_RegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RegistrarUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_RegistrarUsuario.Location = new System.Drawing.Point(552, 591);
            this.btn_RegistrarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_RegistrarUsuario.Name = "btn_RegistrarUsuario";
            this.btn_RegistrarUsuario.Size = new System.Drawing.Size(196, 36);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 188);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(173, 463);
            this.tableLayoutPanel2.TabIndex = 39;
            // 
            // MenuRegistroUsuario
            // 
            this.MenuRegistroUsuario.AutoSize = true;
            this.MenuRegistroUsuario.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuRegistroUsuario.ForeColor = System.Drawing.Color.LightCoral;
            this.MenuRegistroUsuario.Location = new System.Drawing.Point(4, 0);
            this.MenuRegistroUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.MenuRegistroUsuario.Name = "MenuRegistroUsuario";
            this.MenuRegistroUsuario.Size = new System.Drawing.Size(132, 45);
            this.MenuRegistroUsuario.TabIndex = 4;
            this.MenuRegistroUsuario.Text = "MENÚ";
            // 
            // lblQueSomos
            // 
            this.lblQueSomos.AutoSize = true;
            this.lblQueSomos.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueSomos.ForeColor = System.Drawing.Color.LightCoral;
            this.lblQueSomos.Location = new System.Drawing.Point(4, 153);
            this.lblQueSomos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.lblQueSomos.Name = "lblQueSomos";
            this.lblQueSomos.Size = new System.Drawing.Size(104, 58);
            this.lblQueSomos.TabIndex = 2;
            this.lblQueSomos.Text = "¿Qué somos?";
            // 
            // lblPaginaPrincipal
            // 
            this.lblPaginaPrincipal.AutoSize = true;
            this.lblPaginaPrincipal.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginaPrincipal.ForeColor = System.Drawing.Color.LightCoral;
            this.lblPaginaPrincipal.Location = new System.Drawing.Point(4, 70);
            this.lblPaginaPrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.lblPaginaPrincipal.Name = "lblPaginaPrincipal";
            this.lblPaginaPrincipal.Size = new System.Drawing.Size(116, 58);
            this.lblPaginaPrincipal.TabIndex = 1;
            this.lblPaginaPrincipal.Text = "Página principal";
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAyuda.Location = new System.Drawing.Point(4, 236);
            this.lblAyuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(87, 29);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(181, 242);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(909, 310);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Location = new System.Drawing.Point(66, 15);
            this.lblPrimerNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(134, 21);
            this.lblPrimerNombre.TabIndex = 3;
            this.lblPrimerNombre.Text = "*Primer nombre:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderColor = System.Drawing.Color.Transparent;
            this.txtContraseña.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtContraseña.BorderRadius = 0;
            this.txtContraseña.BorderSize = 2;
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.Location = new System.Drawing.Point(685, 209);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(5);
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Padding = new System.Windows.Forms.Padding(9);
            this.txtContraseña.PasswordChar = false;
            this.txtContraseña.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtContraseña.PlaceholderText = "";
            this.txtContraseña.Size = new System.Drawing.Size(219, 35);
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
            this.txtCorreo.Location = new System.Drawing.Point(685, 158);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(5);
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Padding = new System.Windows.Forms.Padding(9);
            this.txtCorreo.PasswordChar = false;
            this.txtCorreo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCorreo.PlaceholderText = "";
            this.txtCorreo.Size = new System.Drawing.Size(219, 35);
            this.txtCorreo.TabIndex = 33;
            this.txtCorreo.Texts = "";
            this.txtCorreo.UnderlinedStyle = false;
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
            this.cbxGenero.Location = new System.Drawing.Point(684, 106);
            this.cbxGenero.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(220, 27);
            this.cbxGenero.TabIndex = 38;
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BorderColor = System.Drawing.Color.Transparent;
            this.txtPrimerNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPrimerNombre.BorderRadius = 0;
            this.txtPrimerNombre.BorderSize = 2;
            this.txtPrimerNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrimerNombre.Location = new System.Drawing.Point(209, 5);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrimerNombre.Multiline = false;
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Padding = new System.Windows.Forms.Padding(9);
            this.txtPrimerNombre.PasswordChar = false;
            this.txtPrimerNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrimerNombre.PlaceholderText = "";
            this.txtPrimerNombre.Size = new System.Drawing.Size(284, 35);
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
            this.txtSegundoApell.Location = new System.Drawing.Point(685, 56);
            this.txtSegundoApell.Margin = new System.Windows.Forms.Padding(5);
            this.txtSegundoApell.Multiline = false;
            this.txtSegundoApell.Name = "txtSegundoApell";
            this.txtSegundoApell.Padding = new System.Windows.Forms.Padding(9);
            this.txtSegundoApell.PasswordChar = false;
            this.txtSegundoApell.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSegundoApell.PlaceholderText = "";
            this.txtSegundoApell.Size = new System.Drawing.Size(219, 35);
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
            this.txtSegundoNombre.Location = new System.Drawing.Point(685, 5);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtSegundoNombre.Multiline = false;
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Padding = new System.Windows.Forms.Padding(9);
            this.txtSegundoNombre.PasswordChar = false;
            this.txtSegundoNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSegundoNombre.PlaceholderText = "";
            this.txtSegundoNombre.Size = new System.Drawing.Size(219, 35);
            this.txtSegundoNombre.TabIndex = 37;
            this.txtSegundoNombre.Texts = "";
            this.txtSegundoNombre.UnderlinedStyle = false;
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Location = new System.Drawing.Point(65, 66);
            this.lblPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(135, 21);
            this.lblPrimerApellido.TabIndex = 4;
            this.lblPrimerApellido.Text = "*Primer apellido:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(567, 219);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(109, 21);
            this.lblContraseña.TabIndex = 11;
            this.lblContraseña.Text = "*Contraseña:";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BorderColor = System.Drawing.Color.Transparent;
            this.txtSegundoApellido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSegundoApellido.BorderRadius = 0;
            this.txtSegundoApellido.BorderSize = 2;
            this.txtSegundoApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtSegundoApellido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtSegundoApellido.Location = new System.Drawing.Point(209, 56);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(5);
            this.txtSegundoApellido.Multiline = false;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Padding = new System.Windows.Forms.Padding(9);
            this.txtSegundoApellido.PasswordChar = false;
            this.txtSegundoApellido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSegundoApellido.PlaceholderText = "";
            this.txtSegundoApellido.Size = new System.Drawing.Size(284, 35);
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
            this.txtTelefono.Location = new System.Drawing.Point(209, 158);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(5);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(9);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.Size = new System.Drawing.Size(320, 35);
            this.txtTelefono.TabIndex = 34;
            this.txtTelefono.Texts = "";
            this.txtTelefono.UnderlinedStyle = false;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(579, 157);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(97, 42);
            this.lblCorreo.TabIndex = 12;
            this.lblCorreo.Text = "*Correo eléctronico:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BorderColor = System.Drawing.Color.Transparent;
            this.txtNombreUsuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombreUsuario.BorderRadius = 0;
            this.txtNombreUsuario.BorderSize = 2;
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreUsuario.Location = new System.Drawing.Point(209, 260);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombreUsuario.Multiline = false;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Padding = new System.Windows.Forms.Padding(9);
            this.txtNombreUsuario.PasswordChar = false;
            this.txtNombreUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombreUsuario.PlaceholderText = "";
            this.txtNombreUsuario.Size = new System.Drawing.Size(320, 35);
            this.txtNombreUsuario.TabIndex = 30;
            this.txtNombreUsuario.Texts = "";
            this.txtNombreUsuario.UnderlinedStyle = false;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(22, 117);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(178, 21);
            this.lblFechaNacimiento.TabIndex = 10;
            this.lblFechaNacimiento.Text = "*Fecha de nacimiento:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(50, 255);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(150, 55);
            this.lblNombreUsuario.TabIndex = 28;
            this.lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // lblGenero
            // 
            this.lblGenero.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(598, 117);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(78, 21);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "*Género:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(111, 168);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(89, 21);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "*Teléfono:";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(37, 219);
            this.lblIdentificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(163, 21);
            this.lblIdentificacion.TabIndex = 8;
            this.lblIdentificacion.Text = "*Identificación(C.C):";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Location = new System.Drawing.Point(598, 55);
            this.lblSegundoApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(78, 42);
            this.lblSegundoApellido.TabIndex = 6;
            this.lblSegundoApellido.Text = "Segundo apellido:";
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Location = new System.Drawing.Point(598, 4);
            this.lblSegundoNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(78, 42);
            this.lblSegundoNombre.TabIndex = 5;
            this.lblSegundoNombre.Text = "Segundo nombre:";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(208, 106);
            this.dtpFechaNac.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(335, 27);
            this.dtpFechaNac.TabIndex = 21;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdentificacion.BorderColor = System.Drawing.Color.Transparent;
            this.txtIdentificacion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIdentificacion.BorderRadius = 0;
            this.txtIdentificacion.BorderSize = 2;
            this.txtIdentificacion.ForeColor = System.Drawing.Color.DimGray;
            this.txtIdentificacion.Location = new System.Drawing.Point(209, 215);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdentificacion.Multiline = false;
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Padding = new System.Windows.Forms.Padding(9);
            this.txtIdentificacion.PasswordChar = false;
            this.txtIdentificacion.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIdentificacion.PlaceholderText = "";
            this.txtIdentificacion.Size = new System.Drawing.Size(320, 35);
            this.txtIdentificacion.TabIndex = 32;
            this.txtIdentificacion.Texts = "";
            this.txtIdentificacion.UnderlinedStyle = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.SkyBlue;
            this.panel5.Location = new System.Drawing.Point(140, 560);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(967, 23);
            this.panel5.TabIndex = 25;
            // 
            // lblSugerenciaRegistro
            // 
            this.lblSugerenciaRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSugerenciaRegistro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSugerenciaRegistro.Location = new System.Drawing.Point(181, 192);
            this.lblSugerenciaRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSugerenciaRegistro.Name = "lblSugerenciaRegistro";
            this.lblSugerenciaRegistro.Size = new System.Drawing.Size(919, 39);
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
            this.pnlInicioSuperior.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInicioSuperior.Name = "pnlInicioSuperior";
            this.pnlInicioSuperior.Size = new System.Drawing.Size(1107, 188);
            this.pnlInicioSuperior.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 123);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(367, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alojamientos Pacho";
            // 
            // lblTextoSupInicio
            // 
            this.lblTextoSupInicio.AutoSize = true;
            this.lblTextoSupInicio.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoSupInicio.ForeColor = System.Drawing.Color.LightCoral;
            this.lblTextoSupInicio.Location = new System.Drawing.Point(323, 139);
            this.lblTextoSupInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextoSupInicio.Name = "lblTextoSupInicio";
            this.lblTextoSupInicio.Size = new System.Drawing.Size(301, 29);
            this.lblTextoSupInicio.TabIndex = 0;
            this.lblTextoSupInicio.Text = "REGISTRO DE USUARIO";
            // 
            // btn_volverMenuPrincipal
            // 
            this.btn_volverMenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btn_volverMenuPrincipal.BackgroundImage = global::Proyecto_arrendamiento.Properties.Resources.atras;
            this.btn_volverMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_volverMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volverMenuPrincipal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_volverMenuPrincipal.Location = new System.Drawing.Point(181, 587);
            this.btn_volverMenuPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_volverMenuPrincipal.Name = "btn_volverMenuPrincipal";
            this.btn_volverMenuPrincipal.Size = new System.Drawing.Size(55, 44);
            this.btn_volverMenuPrincipal.TabIndex = 27;
            this.btn_volverMenuPrincipal.UseVisualStyleBackColor = false;
            this.btn_volverMenuPrincipal.Click += new System.EventHandler(this.btn_volverMenuPrincipal_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Proyecto_arrendamiento.Properties.Resources.logoArrendamiento;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1107, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogo.Image = global::Proyecto_arrendamiento.Properties.Resources.LogoUsuario;
            this.pbxLogo.Location = new System.Drawing.Point(657, 121);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(76, 66);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 651);
            this.Controls.Add(this.pnlPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1122, 688);
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