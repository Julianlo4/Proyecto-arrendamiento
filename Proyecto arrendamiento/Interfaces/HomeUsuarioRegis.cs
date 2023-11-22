using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArriendoPrototipo.Logica;
using Proyecto_arrendamiento.Interfaces;
using Proyecto_arrendamiento.Logica;

namespace ArriendoPrototipo.Interfaces
{
    public partial class HomeUsuarioRegis : Form
    {
        private string nombreCliente;
        cliente cliente1 = new cliente();
        public HomeUsuarioRegis(string nombreCliente)
        {
            InitializeComponent();
            
            this.nombreCliente = nombreCliente;
            lblNombreUsuario.Text = nombreCliente;
            if (cliente1.verificarInmuebles(lblNombreUsuario.Text))
            {
                btnPublicaciones.Show();
                lbnPublicaciones.Show();
            }
            else
            {
                btnPublicaciones.Hide();
                lbnPublicaciones .Hide();
            }

            ContextMenuStrip  = new ContextMenuStrip();
            ToolStripMenuItem configurar = new ToolStripMenuItem("Configurar tu cuenta");
            ToolStripMenuItem salir = new ToolStripMenuItem("salir de tu cuenta");

            configurar.Click += configurar_Click;
            salir.Click += salir_Click;

            ContextMenuStrip.Items.Add(configurar);
            ContextMenuStrip.Items.Add(salir);

            lbConfigurar.ContextMenuStrip = ContextMenuStrip;

            this.WindowState = FormWindowState.Maximized;
            this.SizeChanged += new EventHandler(HomeUsuarioRegis_SizeChanged);
            this.FormClosing += MiFormularioPrincipal_FormClosing;
        }

        private void configurar_Click(object sender, EventArgs e)
        {
            ConfiguraciónCuentaUsuario modificar = new ConfiguraciónCuentaUsuario(lblNombreUsuario.Text);
            this.Hide();
            modificar.Show();
        }

        private void salir_Click(object sender,EventArgs e)
        {
            PaginaPrincipalTodos main = new PaginaPrincipalTodos();
            this.Hide();
            main.Show();
        }

        private void HomeUsuarioRegis_SizeChanged(object sender, EventArgs e)
        {
            // Obtén el tamaño del formulario
            int formularioAncho = panel2.Width;
            int formularioAlto = panel2.ClientSize.Height;

            // Calcula las coordenadas X e Y para centrar el Label
            int labelX = (formularioAncho - label2.Width) / 2;
            int labelY = (formularioAlto - label2.Height) / 2;
            // Calcula las coordenadas X e Y para centrar el logo

            // Establece la posición del Label
            label2.Location = new Point(labelX, labelY + 30);

            // Calcula las coordenadas X e Y para centrar el logo
            int labelX1 = (formularioAncho - pictureBox1.Width) / 2;
            int labelY1 = (formularioAncho - pictureBox1.Height) / 2;

            // Establece la posición del logo
            pictureBox1.Location = new Point(labelX1, labelY1);
        }

        private void MiFormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Pregunta al usuario si realmente desea cerrar la aplicación
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.No)
                {
                    // Cancela el cierre de la aplicación si el usuario elige "No"
                    e.Cancel = true;
                }
                else
                {
                    // Cierra la aplicación si el usuario elige "Sí"
                    Application.Exit();
                }
            }
        }
        private void btnAgregarPublicacion_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarArriendo_Click(object sender, EventArgs e)
        {
            RegistroInmueble registroInmueble = new RegistroInmueble(lblNombreUsuario.Text);
            this.Close();
            registroInmueble.Show();
        }

        private void btnAgregarArriendo_Click_1(object sender, EventArgs e)
        {
            RegistroInmueble registroInmueble = new RegistroInmueble(lblNombreUsuario.Text);
            registroInmueble.Show();
            this.Hide();
        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void pbxLogo_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbnCerrarSesion_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbConfigurar_Click(object sender, EventArgs e)
        {
            ContextMenuStrip.Show(lbConfigurar, lbConfigurar.PointToClient(Cursor.Position));
        }
    }
}
