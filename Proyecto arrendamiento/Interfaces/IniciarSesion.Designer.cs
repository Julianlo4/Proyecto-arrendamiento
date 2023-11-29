using System.Drawing;
using System.Windows.Forms;
using Proyecto_arrendamiento.Apariencia;

namespace ArriendoPrototipo.Interfaces
{
    partial class IniciarSesion
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
            this.MenuRegistroUsuario = new System.Windows.Forms.Label();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.lblQueSomos = new System.Windows.Forms.Label();
            this.lblTextoSupIniciar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pTituloIniciarSesion = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblPaginaPrincipal = new System.Windows.Forms.Label();
            this.btn_RegistrarUsuario = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txbNombreUsuario = new System.Windows.Forms.TextBox();
            this.txbClaveUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.tableLMenuLateral = new System.Windows.Forms.TableLayoutPanel();
            this.btn_volverMenuPrincipal = new System.Windows.Forms.Button();
            this.pbxLogoIniciar = new System.Windows.Forms.PictureBox();
            this.pSuperiorIniciarSesion = new System.Windows.Forms.Panel();
            this.pcontenidoIniciar = new System.Windows.Forms.Panel();
            this.pTituloIniciarSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoIniciar)).BeginInit();
            this.pSuperiorIniciarSesion.SuspendLayout();
            this.pcontenidoIniciar.SuspendLayout();
            this.SuspendLayout();
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
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAyuda.Location = new System.Drawing.Point(3, 167);
            this.lblAyuda.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(69, 23);
            this.lblAyuda.TabIndex = 3;
            this.lblAyuda.Text = "Ayuda";
            // 
            // lblQueSomos
            // 
            this.lblQueSomos.AutoSize = true;
            this.lblQueSomos.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueSomos.ForeColor = System.Drawing.Color.LightCoral;
            this.lblQueSomos.Location = new System.Drawing.Point(3, 111);
            this.lblQueSomos.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblQueSomos.Name = "lblQueSomos";
            this.lblQueSomos.Size = new System.Drawing.Size(83, 46);
            this.lblQueSomos.TabIndex = 2;
            this.lblQueSomos.Text = "¿Qué somos?";
            // 
            // lblTextoSupIniciar
            // 
            this.lblTextoSupIniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTextoSupIniciar.AutoSize = true;
            this.lblTextoSupIniciar.BackColor = System.Drawing.Color.Transparent;
            this.lblTextoSupIniciar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoSupIniciar.ForeColor = System.Drawing.Color.LightCoral;
            this.lblTextoSupIniciar.Location = new System.Drawing.Point(296, 17);
            this.lblTextoSupIniciar.Name = "lblTextoSupIniciar";
            this.lblTextoSupIniciar.Size = new System.Drawing.Size(173, 23);
            this.lblTextoSupIniciar.TabIndex = 0;
            this.lblTextoSupIniciar.Text = "INICIAR SESION";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(841, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alojamientos Pacho";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pTituloIniciarSesion
            // 
            this.pTituloIniciarSesion.BackColor = System.Drawing.Color.SkyBlue;
            this.pTituloIniciarSesion.Controls.Add(this.label2);
            this.pTituloIniciarSesion.Controls.Add(this.pbLogo);
            this.pTituloIniciarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTituloIniciarSesion.Location = new System.Drawing.Point(0, 0);
            this.pTituloIniciarSesion.Name = "pTituloIniciarSesion";
            this.pTituloIniciarSesion.Size = new System.Drawing.Size(841, 103);
            this.pTituloIniciarSesion.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.SkyBlue;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::Proyecto_arrendamiento.Properties.Resources.logoArrendamiento;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(841, 56);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // lblPaginaPrincipal
            // 
            this.lblPaginaPrincipal.AutoSize = true;
            this.lblPaginaPrincipal.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginaPrincipal.ForeColor = System.Drawing.Color.LightCoral;
            this.lblPaginaPrincipal.Location = new System.Drawing.Point(3, 55);
            this.lblPaginaPrincipal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblPaginaPrincipal.Name = "lblPaginaPrincipal";
            this.lblPaginaPrincipal.Size = new System.Drawing.Size(93, 46);
            this.lblPaginaPrincipal.TabIndex = 1;
            this.lblPaginaPrincipal.Text = "Página principal";
            // 
            // btn_RegistrarUsuario
            // 
            this.btn_RegistrarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_RegistrarUsuario.AutoSize = true;
            this.btn_RegistrarUsuario.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_RegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RegistrarUsuario.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrarUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.btn_RegistrarUsuario.Location = new System.Drawing.Point(269, 312);
            this.btn_RegistrarUsuario.Name = "btn_RegistrarUsuario";
            this.btn_RegistrarUsuario.Size = new System.Drawing.Size(349, 34);
            this.btn_RegistrarUsuario.TabIndex = 26;
            this.btn_RegistrarUsuario.Text = "INICIAR SESION";
            this.btn_RegistrarUsuario.UseVisualStyleBackColor = false;
            this.btn_RegistrarUsuario.Click += new System.EventHandler(this.btn_RegistrarUsuario_Click_1);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pcontenidoIniciar);
            this.pnlPrincipal.Controls.Add(this.tableLMenuLateral);
            this.pnlPrincipal.Controls.Add(this.pSuperiorIniciarSesion);
            this.pnlPrincipal.Controls.Add(this.pTituloIniciarSesion);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(841, 538);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.54448F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.45552F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txbClaveUsuario, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblNombreUsuario, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblContrasenia, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txbNombreUsuario, 1, 1);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(711, 300);
            this.tableLayoutPanel2.TabIndex = 32;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::Proyecto_arrendamiento.Properties.Resources.usrs;
            this.pictureBox2.Location = new System.Drawing.Point(269, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(258, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // txbNombreUsuario
            // 
            this.txbNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbNombreUsuario.Location = new System.Drawing.Point(269, 145);
            this.txbNombreUsuario.Name = "txbNombreUsuario";
            this.txbNombreUsuario.Size = new System.Drawing.Size(349, 40);
            this.txbNombreUsuario.TabIndex = 29;
            // 
            // txbClaveUsuario
            // 
            this.txbClaveUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbClaveUsuario.Location = new System.Drawing.Point(269, 235);
            this.txbClaveUsuario.Name = "txbClaveUsuario";
            this.txbClaveUsuario.Size = new System.Drawing.Size(349, 40);
            this.txbClaveUsuario.TabIndex = 30;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(11, 148);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(252, 33);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "Nombre de usuario:";
            this.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.Location = new System.Drawing.Point(104, 238);
            this.lblContrasenia.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(159, 33);
            this.lblContrasenia.TabIndex = 5;
            this.lblContrasenia.Text = "Contraseña:";
            this.lblContrasenia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLMenuLateral
            // 
            this.tableLMenuLateral.BackColor = System.Drawing.Color.PeachPuff;
            this.tableLMenuLateral.ColumnCount = 1;
            this.tableLMenuLateral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLMenuLateral.Controls.Add(this.MenuRegistroUsuario, 0, 0);
            this.tableLMenuLateral.Controls.Add(this.lblQueSomos, 0, 2);
            this.tableLMenuLateral.Controls.Add(this.lblPaginaPrincipal, 0, 1);
            this.tableLMenuLateral.Controls.Add(this.lblAyuda, 0, 3);
            this.tableLMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLMenuLateral.Location = new System.Drawing.Point(0, 170);
            this.tableLMenuLateral.Name = "tableLMenuLateral";
            this.tableLMenuLateral.RowCount = 4;
            this.tableLMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLMenuLateral.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLMenuLateral.Size = new System.Drawing.Size(130, 368);
            this.tableLMenuLateral.TabIndex = 31;
            // 
            // btn_volverMenuPrincipal
            // 
            this.btn_volverMenuPrincipal.AutoSize = true;
            this.btn_volverMenuPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btn_volverMenuPrincipal.BackgroundImage = global::Proyecto_arrendamiento.Properties.Resources.atras;
            this.btn_volverMenuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_volverMenuPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volverMenuPrincipal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_volverMenuPrincipal.Location = new System.Drawing.Point(6, 329);
            this.btn_volverMenuPrincipal.Name = "btn_volverMenuPrincipal";
            this.btn_volverMenuPrincipal.Size = new System.Drawing.Size(41, 36);
            this.btn_volverMenuPrincipal.TabIndex = 27;
            this.btn_volverMenuPrincipal.UseVisualStyleBackColor = false;
            this.btn_volverMenuPrincipal.Click += new System.EventHandler(this.btn_volverMenuPrincipal_Click_1);
            // 
            // pbxLogoIniciar
            // 
            this.pbxLogoIniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxLogoIniciar.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogoIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogoIniciar.Image = global::Proyecto_arrendamiento.Properties.Resources.LogoUsuario;
            this.pbxLogoIniciar.Location = new System.Drawing.Point(475, 0);
            this.pbxLogoIniciar.Name = "pbxLogoIniciar";
            this.pbxLogoIniciar.Size = new System.Drawing.Size(57, 54);
            this.pbxLogoIniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogoIniciar.TabIndex = 1;
            this.pbxLogoIniciar.TabStop = false;
            // 
            // pSuperiorIniciarSesion
            // 
            this.pSuperiorIniciarSesion.BackColor = System.Drawing.Color.PeachPuff;
            this.pSuperiorIniciarSesion.Controls.Add(this.lblTextoSupIniciar);
            this.pSuperiorIniciarSesion.Controls.Add(this.pbxLogoIniciar);
            this.pSuperiorIniciarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSuperiorIniciarSesion.Location = new System.Drawing.Point(0, 103);
            this.pSuperiorIniciarSesion.Name = "pSuperiorIniciarSesion";
            this.pSuperiorIniciarSesion.Size = new System.Drawing.Size(841, 67);
            this.pSuperiorIniciarSesion.TabIndex = 3;
            // 
            // pcontenidoIniciar
            // 
            this.pcontenidoIniciar.Controls.Add(this.btn_RegistrarUsuario);
            this.pcontenidoIniciar.Controls.Add(this.tableLayoutPanel2);
            this.pcontenidoIniciar.Controls.Add(this.btn_volverMenuPrincipal);
            this.pcontenidoIniciar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcontenidoIniciar.Location = new System.Drawing.Point(130, 170);
            this.pcontenidoIniciar.Name = "pcontenidoIniciar";
            this.pcontenidoIniciar.Size = new System.Drawing.Size(711, 368);
            this.pcontenidoIniciar.TabIndex = 33;
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 538);
            this.Controls.Add(this.pnlPrincipal);
            this.MinimumSize = new System.Drawing.Size(710, 518);
            this.Name = "IniciarSesion";
            this.Text = "IniciarSesion";
            this.pTituloIniciarSesion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLMenuLateral.ResumeLayout(false);
            this.tableLMenuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoIniciar)).EndInit();
            this.pSuperiorIniciarSesion.ResumeLayout(false);
            this.pSuperiorIniciarSesion.PerformLayout();
            this.pcontenidoIniciar.ResumeLayout(false);
            this.pcontenidoIniciar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label MenuRegistroUsuario;
        private Label lblAyuda;
        private Label lblQueSomos;
        private PictureBox pbxLogoIniciar;
        private Label lblTextoSupIniciar;
        private Label label2;
        private PictureBox pbLogo;
        private Panel pTituloIniciarSesion;
        private Label lblPaginaPrincipal;
        private Button btn_volverMenuPrincipal;
        private Panel pnlPrincipal;
        private Label lblContrasenia;
        private Label lblNombreUsuario;
        private PictureBox pictureBox2;
        private TextBox txbClaveUsuario;
        private TextBox txbNombreUsuario;
        private TableLayoutPanel tableLMenuLateral;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel pSuperiorIniciarSesion;
        private Panel pcontenidoIniciar;
        private Button btn_RegistrarUsuario;
    }
}