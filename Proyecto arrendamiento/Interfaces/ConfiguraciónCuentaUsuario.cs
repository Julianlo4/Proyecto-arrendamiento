using ArriendoPrototipo.Interfaces;
using ArriendoPrototipo.Logica;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_arrendamiento.Interfaces
{
    public partial class ConfiguraciónCuentaUsuario : Form
    {
        cliente cliente = new cliente();
        static String  cadenaConexion = "Data Source=localhost;User ID=ProyectoArren;Password=123; Connection Timeout = 120";
        OracleConnection conexion = new OracleConnection(cadenaConexion);
        String nombreUsuario1;
        public ConfiguraciónCuentaUsuario(String nombreUsuario)
        {
            nombreUsuario1 = nombreUsuario;
            
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormClosing += MiFormularioPrincipal_FormClosing;
            traerDatosU(nombreUsuario1);
        }

        public void traerDatosU(string usuario)
        {
            conexion.Open();
            string select = "SELECT REGPRIMERNOM,REGSEGUNDONOM,REGPRIMERAPE,REGSEGUNDOAPE,REGTELEFONO,REGCORREO FROM REGISTRO WHERE REGNOMBREU = :usuario";
            OracleCommand cmd = new OracleCommand(select, conexion);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@usuario", usuario);

            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string REGPRIMERNOM = reader["REGPRIMERNOM"].ToString();
                string REGSEGUNDONOM = reader["REGSEGUNDONOM"].ToString();
                string REGPRIMERAPE = reader["REGPRIMERAPE"].ToString();
                string REGSEGUNDOAPE = reader["REGSEGUNDOAPE"].ToString();
                string REGTELEFONO = reader["REGTELEFONO"].ToString();
                string REGCORREO = reader["REGCORREO"].ToString();
                conexion.Close();

                txtPrimerNombreU.Text += REGPRIMERNOM;
                txtSegundoNombre1.Texts += REGSEGUNDONOM;
                txtPrimerApellido1.Texts += REGPRIMERAPE;
                txtSegundoApell1.Texts += REGSEGUNDOAPE;
                txtTelefono1.Texts += REGTELEFONO;
                txtCorreo1.Texts += REGCORREO;
                
            }
            else
            {
                MessageBox.Show("error mi perrito");
                conexion.Close();
        
            }
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

        private void lblTextoModificar_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pnlPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_volverMenuPrincipal_Click(object sender, EventArgs e)
        {
            HomeUsuarioRegis home = new HomeUsuarioRegis(nombreUsuario1);
            home.Show();
            this.Hide();
        }

        private void btnActualizarInfoU_Click(object sender, EventArgs e)
        {
            string primerN, segundoN, primerA, segundoA, tel, correo, usuario, clave;

            primerN = txtPrimerNombreU.Text;
            segundoN = txtSegundoNombre1.Texts;
            primerA = txtPrimerApellido1.Texts;
            segundoA = txtSegundoApell1.Texts;
            tel = txtTelefono1.Texts;
            correo = txtCorreo1.Texts;
            usuario = nombreUsuario1;
            clave = txtContraseña.Texts;

            bool verifcar =cliente.modificarCliente(primerN, segundoN, primerA, segundoA, tel, correo, usuario, clave);
            
            if (verifcar)
            {
                MessageBox.Show("Datos actualizados corrrectamente");
            }
            else
            {
                MessageBox.Show("Error al actualizar datos");
            }
        }

        private void bntActualizarClave_Click(object sender, EventArgs e)
        {
            string claveActual, claveNueva;

            claveActual = txbClaveActual1.Text;
            claveNueva = txbClaveNueva1.Text;

            MessageBox.Show("clave anterior:" + claveActual + "claveNueva:" + claveNueva);
            bool verificar = cliente.modificarClave(nombreUsuario1,claveActual,claveNueva );

            if (verificar)
            {
                MessageBox.Show("Clave modificada correctamente");
            }
            else{
                MessageBox.Show("Error al modicar clave");
            }
        }

        private void txbClave1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            

            DialogResult confirmar = MessageBox.Show("¿Esta seguro de que desea borrar su cuenta? No hay paso para revertir esto","confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (confirmar == DialogResult.Yes) 
            {
                string clave1, clave2;
                clave1 = txbClave1.Text;
                clave2 = txbClave2.Text;
                bool verificar = cliente.desactivarCliente(nombreUsuario1, clave1, clave2);

                if (verificar)
                {
                    MessageBox.Show("Su cuenta ha sido borrada correctamente");
                    PaginaPrincipalTodos main = new PaginaPrincipalTodos();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Error al tratar de eliminar su cuenta");
                }
            }
        }
    }
}
