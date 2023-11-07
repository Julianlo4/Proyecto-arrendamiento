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
            this.Close();
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
                this.Close();
            }
            else { MessageBox.Show("La insercion ha sido fallida", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    }
    
}
