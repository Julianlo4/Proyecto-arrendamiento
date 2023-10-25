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
    public partial class HomeUsuarioRegis : Form
    {
        private string nombreCliente;
        public HomeUsuarioRegis(string nombreCliente)
        {
            InitializeComponent();
            this.nombreCliente = nombreCliente;
            lblNombreUsuario.Text = nombreCliente;

        }

        private void btnAgregarPublicacion_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarArriendo_Click(object sender, EventArgs e)
        {
            RegistroInmueble registroInmueble = new RegistroInmueble();
            this.Close();
            registroInmueble.Show();
        }

        private void btnAgregarArriendo_Click_1(object sender, EventArgs e)
        {
            RegistroInmueble registroInmueble = new RegistroInmueble();
            registroInmueble.Show();
            this.Close();
        }
    }
}
