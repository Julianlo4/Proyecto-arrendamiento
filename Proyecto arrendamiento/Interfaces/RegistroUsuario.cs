using ArriendoPrototipo.Interfaces;
using System.Globalization;
using ArriendoPrototipo.Logica;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace ArriendoPrototipo
{
    public partial class RegistroUsuario : Form
    {
        cliente nuevoReg = new cliente();
        Exception exception = new Exception();
        public RegistroUsuario()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormClosing += MiFormularioPrincipal_FormClosing;
        }

      

        private void MiFormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Pregunta al usuario si realmente desea cerrar la aplicaci�n
                DialogResult resultado = MessageBox.Show("�Est�s seguro de que deseas cerrar la aplicaci�n?", "Cerrar la aplicaci�n", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.No)
                {
                    // Cancela el cierre de la aplicaci�n si el usuario elige "No"
                    e.Cancel = true;
                }
                else
                {
                    // Cierra la aplicaci�n si el usuario elige "S�"
                    Application.Exit();
                }
            }
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
            contrase�a = txtContrase�a.Texts;
            fechaNacimiento = dtpFechaNac.Value.ToString("DD/MM/YYYY");
            nombreUsuario = txtNombreUsuario.Texts;

          result = nuevoReg.RegistroUsuarioPrms(primerNombre, segundoNombre, primerApellido,
          segundoApellido, genero, telefono, correo,
          identiificacion, contrase�a, fechaNacimiento, nombreUsuario);


                if (result > 0)
                {
                    MessageBox.Show("La insercion ha sido correcta", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HomeUsuarioRegis homeUsuarioRegis = new HomeUsuarioRegis(nombreUsuario);
                    homeUsuarioRegis.Show();
                    this.Hide();
                }
                else { MessageBox.Show("La insercion ha sido fallida", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("La creaci�n del usuario ha fallado debido a " + ex.Message, "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            { 
                 MessageBox.Show("La creaci�n del usuario ha fallado debido a " + ex.Message, "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }


          

        

        }

        private void btn_volverMenuPrincipal_Click_1(object sender, EventArgs e)
        {
            PaginaPrincipalTodos paginaPrincipalTodos = new PaginaPrincipalTodos();
            paginaPrincipalTodos.Show();
            this.Hide();
        }

        private void pnlPrincipal_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}