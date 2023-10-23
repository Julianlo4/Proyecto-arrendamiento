using ArriendoPrototipo.Interfaces;
using System.Globalization;
using ArriendoPrototipo.Logica;

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
            HomeUsuarioRegis homeUsuarioRegis = new HomeUsuarioRegis();
            this.Close();
            homeUsuarioRegis.Show();

            string primerNombre, segundoNombre, primerApellido,
               segundoApellido, genero, telefono, correo,
               identiificacion, contraseña, fechaNacimiento, nombreUsuario;
            DateTime fechaNacimientoP;
            int result;


            primerNombre = txtPrimerNombre.Text;
            segundoNombre = txtSegundoNombre.Text;
            primerApellido = txtPrimerApellido.Text;
            segundoApellido = txtSegundoApellido.Text;
            genero = cbxGenero.Texts;
            telefono = txtTelefono.Text;
            correo = txtCorreo.Text;
            identiificacion = txtIdentificacion.Text;
            contraseña = txtContraseña.Text;
            fechaNacimiento = dtpFechaNac.Value.ToString("dd-MM-yyyy");
            fechaNacimientoP = DateTime.ParseExact(fechaNacimiento, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            nombreUsuario = txtNombreUsuario.Text;

            result = nuevoReg.registroDeUsuario(primerNombre, segundoNombre, primerApellido,
            segundoApellido, genero, telefono, correo,
            identiificacion, contraseña, fechaNacimientoP, nombreUsuario);

            if (result > 0)
            {
                MessageBox.Show("La insercion ha sido correcta", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("La insercion ha sido fallida", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}