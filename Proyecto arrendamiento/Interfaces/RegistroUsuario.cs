using ArriendoPrototipo.Interfaces;
using System.Globalization;
using ArriendoPrototipo.Logica;
using System;
using System.Windows.Forms;

namespace ArriendoPrototipo
{
    public partial class RegistroUsuario : Form
    {
        RegistroUsuarioLog nuevoReg = new RegistroUsuarioLog();
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSugerenciaRegistro_Click(object sender, EventArgs e)
        {

        }

        private void pbxLogo_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_volverMenuPrincipal_Click(object sender, EventArgs e)
        {
            PaginaPrincipalTodos paginaPrincipalTodos = new PaginaPrincipalTodos();
            this.Close();
            paginaPrincipalTodos.Show();

        }

        private void btn_RegistrarUsuario_Click(object sender, EventArgs e)
        {
            /*
            HomeUsuarioRegis homeUsuarioRegis = new HomeUsuarioRegis();
            this.Close();
            homeUsuarioRegis.Show();*/

          
        }

        private void btn_RegistrarUsuario_Click_1(object sender, EventArgs e)
        {

            string primerNombre, segundoNombre, primerApellido,
             segundoApellido, genero, telefono, correo,
              contrase�a, fechaNacimiento, nombreUsuario;
            int result;
            int identiificacion;

            primerNombre = txtPrimerNombre.Texts;
            segundoNombre = txtSegundoNombre.Texts;
            primerApellido = txtSegundoApellido.Texts;
            segundoApellido = txtSegundoApell.Texts;
            genero = cbxGenero.Text;
            telefono = txtTelefono.Texts;
            correo = txtCorreo.Texts;
            identiificacion = int.Parse(txtIdentificacion.Texts);
            contrase�a = txtContrase�a.Texts;
            fechaNacimiento = dtpFechaNac.Value.ToString("DD/MM/YYYY");
            nombreUsuario = txtNombreUsuario.Texts;

            result = nuevoReg.RegistroUsuarioPrms(primerNombre, segundoNombre, primerApellido,
            segundoApellido, genero, telefono, correo,
            identiificacion, contrase�a, fechaNacimiento, nombreUsuario);

            if (result > 0)
            {
                MessageBox.Show("La insercion ha sido correcta", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("La insercion ha sido fallida", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}