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
            this.pnlInicioSuperior = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbnPreguntarArrendar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarArriendo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.pnlInicioSuperior.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(619, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 141);
            this.panel1.TabIndex = 5;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(14, 102);
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
            this.lblBienvenido.Location = new System.Drawing.Point(3, 79);
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
            this.pbxLogo.Size = new System.Drawing.Size(127, 76);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.Click += new System.EventHandler(this.pbxLogo_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.tableLayoutPanel2);
            this.pnlPrincipal.Controls.Add(this.tableLayoutPanel1);
            this.pnlPrincipal.Controls.Add(this.pnlInicioSuperior);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(746, 536);
            this.pnlPrincipal.TabIndex = 4;
            // 
            // pnlInicioSuperior
            // 
            this.pnlInicioSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(204)))));
            this.pnlInicioSuperior.Controls.Add(this.panel2);
            this.pnlInicioSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInicioSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlInicioSuperior.Name = "pnlInicioSuperior";
            this.pnlInicioSuperior.Size = new System.Drawing.Size(746, 139);
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
            this.panel2.Size = new System.Drawing.Size(746, 141);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(173, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 35);
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
            this.pictureBox1.Size = new System.Drawing.Size(619, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.PeachPuff;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 139);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(746, 38);
            this.tableLayoutPanel1.TabIndex = 26;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(475, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 38);
            this.label5.TabIndex = 1;
            this.label5.Text = "Configuración de tu cuenta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.PeachPuff;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnAgregarArriendo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbnPreguntarArrendar, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 177);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(141, 359);
            this.tableLayoutPanel2.TabIndex = 25;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 69);
            this.label3.TabIndex = 5;
            this.label3.Text = "FUNCIONES \r\nUNICAS \r\nPARA TI";
            // 
            // btnAgregarArriendo
            // 
            this.btnAgregarArriendo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarArriendo.BackgroundImage")));
            this.btnAgregarArriendo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarArriendo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarArriendo.Location = new System.Drawing.Point(3, 82);
            this.btnAgregarArriendo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnAgregarArriendo.Name = "btnAgregarArriendo";
            this.btnAgregarArriendo.Size = new System.Drawing.Size(135, 63);
            this.btnAgregarArriendo.TabIndex = 6;
            this.btnAgregarArriendo.UseVisualStyleBackColor = true;
            this.btnAgregarArriendo.Click += new System.EventHandler(this.btnAgregarArriendo_Click_1);
            // 
            // HomeUsuarioRegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 536);
            this.Controls.Add(this.pnlPrincipal);
            this.MinimumSize = new System.Drawing.Size(762, 575);
            this.Name = "HomeUsuarioRegis";
            this.Text = "HomeUsuarioRegis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.pnlInicioSuperior.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAgregarArriendo;
        private Label label3;
        private Label lbnPreguntarArrendar;
    }
}