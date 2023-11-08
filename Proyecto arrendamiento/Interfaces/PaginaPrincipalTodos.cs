
using Proyecto_arrendamiento.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArriendoPrototipo.Interfaces
{
    public partial class PaginaPrincipalTodos : Form
    {
        public PaginaPrincipalTodos()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.SizeChanged += new EventHandler(PaginaPrincipalTodos_SizeChanged);
            this.FormClosing += MiFormularioPrincipal_FormClosing;
       
        }

        private void PaginaPrincipalTodos_SizeChanged(object sender, EventArgs e)
        {
            // Obtén el tamaño del formulario
            int formularioAncho = panel2.Width - panel1.Width;
            int formularioAlto = panel2.ClientSize.Height;

            // Calcula las coordenadas X e Y para centrar el Label
            int labelX = (formularioAncho - label2.Width) / 2;
            int labelY = (formularioAlto - label2.Height) / 2;
            // Calcula las coordenadas X e Y para centrar el logo

            // Establece la posición del Label
            label2.Location = new Point(labelX, labelY+30);


            
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


        private void lblTextoSupInicio_Click(object sender, EventArgs e)
        {

        }

        private void btn_RegistrarUsuarioMenu_Click(object sender, EventArgs e)
        {
            RegistroUsuario registro = new RegistroUsuario();
            registro.Show();

            this.Hide();
        }

        private void lblIniciarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion iniciarSesion = new IniciarSesion();
            iniciarSesion.Show();
            this.Hide();
        }

        private void lblIniciarSesion_Click_1(object sender, EventArgs e)
        {
            IniciarSesion iniciarSesion = new IniciarSesion();
            iniciarSesion.Show();
            this.Hide();
        }

        private void btn_RegistrarUsuarioMenu_Click_1(object sender, EventArgs e)
        {
            RegistroUsuario us = new RegistroUsuario();
            us.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
