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
    public partial class RegistroInmueble : Form
    {
        public RegistroInmueble()
        {
            InitializeComponent();
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
    }
}
