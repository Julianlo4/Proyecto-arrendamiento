
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
    }
}
