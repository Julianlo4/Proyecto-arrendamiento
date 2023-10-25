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
        public HomeUsuarioRegis()
        {
            InitializeComponent();
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
    }
}
