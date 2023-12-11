using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            this.FormClosing += MiFormularioPrincipal_FormClosing;
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

        private byte[] ConvertirImagenAPBytes(Image imagen)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                imagen.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        private void btnGuardarInmueble_Click(object sender, EventArgs e)
        {
            string ubicacion, telefono, tipoVivienda, descripcion, tituloPub, InmPrecio ,
                  InmParqueadero, direccion;
            int result, InmSerAgua, InmSerLuz, InmSerWifi, InmSerTv, InmSerLavadora, InmSerGas,  InmAmoblado, InmAnimales;

            ubicacion = cbxUbicacion.Text;
            direccion = txtDireccion.Text;
            telefono = txtPrecio.Text;
            tipoVivienda = cbxTipoVivienda.Text;
            descripcion = txtDescripcion.Text;
            tituloPub = txtNombrePublicacion.Text;
            InmSerAgua = rbAgua.Checked ? 1 : 0;
            InmSerLuz = rbLuz.Checked ? 1 : 0;
            InmSerWifi = rbWifi.Checked ? 1 : 0;
            InmSerTv = rbTv.Checked ? 1 : 0;
            InmSerLavadora = rbLavadora.Checked ? 1 : 0;
            InmSerGas = rbGas.Checked ? 1 : 0;
            InmPrecio = txtTelefono.Text;
            InmAmoblado = cbxAmoblado.SelectedIndex;
            InmAnimales = cbxAnimales.SelectedIndex; 
            InmParqueadero = cbxParqueadero.Text;

            

            int regId = reg.consultarId(NombreUsuario);
            result = reg.insertarInmueble(regId,tituloPub, ubicacion, direccion, telefono, InmSerAgua ,InmSerLuz,InmSerWifi,InmSerTv,
                      InmSerLavadora , InmSerGas , InmPrecio , descripcion ,tipoVivienda, 
                      InmAmoblado,InmAnimales,InmParqueadero, ConvertirImagenAPBytes(pbxImagenInm.Image));


            if (result > 0)
            {
                MessageBox.Show("La insercion ha sido correcta", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomeUsuarioRegis homeUsuarioRegis = new HomeUsuarioRegis(lblNombreUsuario.Text);
                this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(sfvImagenInmueble.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = sfvImagenInmueble.FileName;

                // Cargar la imagen en el PictureBox
                pbxImagenInm.Image = Image.FromFile(rutaImagen);
            }
        }
    }
    
}
