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
            this.SizeChanged += new EventHandler(RegistroUsuario_SizeChanged);
            this.FormClosing += MiFormularioPrincipal_FormClosing;
        }

        private void RegistroUsuario_SizeChanged(object sender, EventArgs e)
        {
            // Obtén el tamaño del panel
            int formularioAncho = panel2.Width;
            int formularioAlto = panel2.ClientSize.Height;

            // Calcula las coordenadas X e Y para centrar el Label
            int labelX = (formularioAncho - label2.Width) / 2;
            int labelX3 = (formularioAncho - tableLayoutPanel2.Width) / 2;
            int labelY = (formularioAlto - label2.Height) / 2;

            int labelX1 = (formularioAncho - lblTextoSupInicio.Width) / 2;
            int labelY1 = (formularioAlto - lblTextoSupInicio.Height) / 2;
            // Calcula las coordenadas X e Y para centrar el logo

            // Establece la posición del Label
            label2.Location = new Point(labelX, labelY +30);
            lblTextoSupInicio.Location = new Point(labelX1, labelY1 + 80);
            pbxLogo.Location = new Point(labelX1 + 240, labelY1 + 60);

            // Calcula las coordenadas X e Y para centrar el logo
            int labelX2 = (formularioAncho - pictureBox1.Width) / 2;
            int labelY2 = (formularioAncho - pictureBox1.Height) / 2;

            // Establece la posición del logo
            pictureBox1.Location = new Point(labelX2, labelY2);
            btn_RegistrarUsuario.Location = new Point(labelX3, formularioAlto + 390);

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
                    this.Hide();
                }
                else { MessageBox.Show("La insercion ha sido fallida", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("La creación del usuario ha fallado debido a " + ex.Message, "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            { 
                 MessageBox.Show("La creación del usuario ha fallado debido a " + ex.Message, "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
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