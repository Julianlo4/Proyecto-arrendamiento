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
        Exception exception = new Exception();
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
                   contraseña, fechaNacimiento, nombreUsuario;
            int result;
            int identiificacion;
            if (string.IsNullOrEmpty(txtPrimerNombre.Text) && string.IsNullOrEmpty(txtSegundoApellido.Text)
                    && string.IsNullOrEmpty(dtpFechaNac.Text) && string.IsNullOrEmpty(cbxGenero.Text)
                    && string.IsNullOrEmpty(txtTelefono.Text) && string.IsNullOrEmpty(txtCorreo.Text)
                    && string.IsNullOrEmpty(txtContraseña.Text) && string.IsNullOrEmpty(txtIdentificacion.Text)
                    && string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                MessageBox.Show("Por favor complete los campos obligatorios antes de continuar", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try 
            {

               
                primerNombre = txtPrimerNombre.Texts;
                segundoNombre = txtSegundoNombre.Texts;
                primerApellido = txtSegundoApellido.Texts;
                segundoApellido = txtSegundoApell.Texts;
                genero = cbxGenero.Text;
                telefono = txtTelefono.Texts;
                correo = txtCorreo.Texts;
                identiificacion = int.Parse(txtIdentificacion.Texts);
                contraseña = txtContraseña.Texts;
                fechaNacimiento = dtpFechaNac.Value.ToString("DD/MM/YYYY");
                nombreUsuario = txtNombreUsuario.Texts;

             


                result = nuevoReg.RegistroUsuarioPrms(primerNombre, segundoNombre, primerApellido,
                                                      segundoApellido, genero, telefono, correo,
                                                      identiificacion, contraseña, fechaNacimiento, nombreUsuario);


                if (result > 0)
                {
                    MessageBox.Show("La insercion ha sido correcta", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HomeUsuarioRegis homeUsuarioRegis = new HomeUsuarioRegis(primerNombre);
                    homeUsuarioRegis.Show();
                    this.Close();
                }
                else { MessageBox.Show("La insercion ha sido fallida", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("La creación del usuario ha fallado debido a: " + ex.Message, "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            { 
                 MessageBox.Show("La creación del usuario ha fallado debido a: " + ex.Message, "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }


          

        

        }

        private void btn_volverMenuPrincipal_Click_1(object sender, EventArgs e)
        {
            PaginaPrincipalTodos paginaPrincipalTodos = new PaginaPrincipalTodos();
            paginaPrincipalTodos.Show();
            this.Close();
        }
    }
}