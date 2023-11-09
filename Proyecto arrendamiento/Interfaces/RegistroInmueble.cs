using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_arrendamiento.Logica;

namespace ArriendoPrototipo.Interfaces
{
    public partial class RegistroInmueble : Form
    {
        private string NombreUsuario;
        RegistrarInmueble reg = new RegistrarInmueble();
        public RegistroInmueble(string nombreU)
        {
            InitializeComponent();
            this.NombreUsuario = nombreU;
            lblNombreUsuario.Text = nombreU;
            this.WindowState = FormWindowState.Maximized;
            this.SizeChanged += new EventHandler (RegistroInmueble_SizeChanged);
            this.FormClosing += MiFormularioPrincipal_FormClosing;
        }

        private void RegistroInmueble_SizeChanged(object sender, EventArgs e)
        {
            // Obtén el tamaño del formulario
            int formularioAncho = panel2.Width - panel1.Width;
            int formularioAlto = panel2.ClientSize.Height;

            // Calcula las coordenadas X e Y para centrar el Label
            int labelX = (formularioAncho - label2.Width) / 2;
            int labelY = (formularioAlto - label2.Height) / 2;
            // Calcula las coordenadas X e Y para centrar el logo

            // Establece la posición del Label
            label2.Location = new Point(labelX, labelY + 30);

            tableLayoutPanel1.Location = new Point((label4.Width/3)-40, 250);
            btnGuardarInmueble.Location = new Point(formularioAncho/2, 600);
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
        private void cbxDescripcionInmueble_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            HomeUsuarioRegis homeUsuarioRegis = new HomeUsuarioRegis("Usuario");
            this.Close();
            homeUsuarioRegis.Show();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            HomeUsuarioRegis homeUsuarioRegis = new HomeUsuarioRegis(lblNombreUsuario.Text);
            homeUsuarioRegis.Show();
            this.Hide();
        }

        private void btnGuardarInmueble_Click(object sender, EventArgs e)
        {
            string ubicacion, telefono, tipoVivienda, descripcion, tituloPub, InmPrecio ,
                  InmParqueadero, direccion;
            int result, InmSerAgua, InmSerLuz, InmSerWifi, InmSerTv, InmSerLavadora, InmSerGas,  InmAmoblado, InmAnimales;

            ubicacion = cbxUbicacion.Text;
            direccion = txtDireccion.Text;
            telefono = txtTelefono.Text;
            tipoVivienda = cbxTipoVivienda.Text;
            descripcion = txtDescripcion.Text;
            tituloPub = txtNombrePublicacion.Text;
            InmSerAgua = rbAgua.Checked ? 1 : 0;
            InmSerLuz = rbLuz.Checked ? 1 : 0;
            InmSerWifi = rbWifi.Checked ? 1 : 0;
            InmSerTv = rbTv.Checked ? 1 : 0;
            InmSerLavadora = rbLavadora.Checked ? 1 : 0;
            InmSerGas = rbGas.Checked ? 1 : 0;
            InmPrecio = txtPrecio.Text;
            InmAmoblado = cbxAmoblado.SelectedIndex;
            InmAnimales = cbxAnimales.SelectedIndex; 
            InmParqueadero = cbxParqueadero.Text;

            int regId = reg.consultarId(NombreUsuario);
            result = reg.insertarInmueble(regId,tituloPub, ubicacion, direccion, telefono, InmSerAgua ,InmSerLuz,InmSerWifi,InmSerTv,
                      InmSerLavadora , InmSerGas , InmPrecio , descripcion ,tipoVivienda, 
                      InmAmoblado,InmAnimales,InmParqueadero);


            if (result > 0)
            {
                MessageBox.Show("La insercion ha sido correcta", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomeUsuarioRegis homeUsuarioRegis = new HomeUsuarioRegis("Usuario");
                this.Close();
                homeUsuarioRegis.Show();

            }
            else { MessageBox.Show("La insercion ha sido fallida", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_volverMenuPrincipal_Click(object sender, EventArgs e)
        {
            HomeUsuarioRegis homeUsuarioRegis = new HomeUsuarioRegis(lblNombreUsuario.Text);
            homeUsuarioRegis.Show();
            this.Hide();
        }
    }
    
}
