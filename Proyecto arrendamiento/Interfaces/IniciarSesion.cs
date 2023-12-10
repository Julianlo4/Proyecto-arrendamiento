using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArriendoPrototipo.Interfaces
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormClosing += MiFormularioPrincipal_FormClosing;
            txbClaveUsuario.PasswordChar = '*';
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
        private void lblPrimerNombre_Click(object sender, EventArgs e)
        {

        }

        private void btn_volverMenuPrincipal_Click(object sender, EventArgs e)
        {
            PaginaPrincipalTodos paginaPrincipalTodos = new PaginaPrincipalTodos();
            paginaPrincipalTodos.Show();
            this.Hide();
        }




        private void btn_volverMenuPrincipal_Click_1(object sender, EventArgs e)
        {
            PaginaPrincipalTodos paginaPrincipalTodos = new PaginaPrincipalTodos();
            paginaPrincipalTodos.Show();
            this.Hide();
        }

        private void btn_RegistrarUsuario_Click_1(object sender, EventArgs e)
        {
           
            String cadenaConexion = "Data Source=localhost;User ID=ProyectoArren;Password=123; Connection Timeout = 120";
            string consultaSql;
            consultaSql = "SELECT COUNT(*) FROM REGISTRO WHERE REGNOMBREU = :param1 AND RegContrasenia = :param2 AND RegEstado=1";

            using (OracleConnection conexion = new OracleConnection(cadenaConexion))
            {
                using (OracleCommand comando = new OracleCommand(consultaSql, conexion))
                {
                    
                    // Agregar los parámetros a la consulta
                    comando.Parameters.Add("param1", OracleDbType.Varchar2).Value = txbNombreUsuario.Text;
                    comando.Parameters.Add("param2", OracleDbType.Varchar2).Value = txbClaveUsuario.Text;

                    try
                    {
                        conexion.Open();
                        OracleDataReader lector = comando.ExecuteReader();
                        int verificar = Convert.ToInt32(comando.ExecuteScalar());

                        if (verificar > 0)
                        {
                            MessageBox.Show("Datos correctos", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HomeUsuarioRegis homeUsuarioRegis = new HomeUsuarioRegis(txbNombreUsuario.Text);
                            conexion.Close();
                            this.Hide();
                            homeUsuarioRegis.Show();
                        }
                        else
                        {
                            conexion.Close();
                            MessageBox.Show("Datos incorrectos", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

         

                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones
                        conexion.Close();
                        Console.WriteLine("Error: " + ex.Message);
                        MessageBox.Show("Datos incorrectos " + ex.Message, "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
