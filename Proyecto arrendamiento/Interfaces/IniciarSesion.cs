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
            this.SizeChanged += new EventHandler(PaginaPrincipalTodos_SizeChanged);
            this.FormClosing += MiFormularioPrincipal_FormClosing;
            txbClaveUsuario.PasswordChar = '*';
        }

        private void PaginaPrincipalTodos_SizeChanged(object sender, EventArgs e)
        {
            // Obtén el tamaño del panel
            int formularioAncho = panel2.Width;
            int formularioAlto = panel2.ClientSize.Height;

            // Calcula las coordenadas X e Y para centrar el Label
            int labelX = (formularioAncho - label2.Width) / 2;
            int labelX3 = (formularioAncho - tableLayoutPanel1.Width) / 2;
            int labelY = (formularioAlto - label2.Height) / 2;

            int labelX1 = (formularioAncho - lblTextoSupIniciar.Width) / 2;
            int labelY1 = (formularioAlto - lblTextoSupIniciar.Height) / 2;
            // Calcula las coordenadas X e Y para centrar el logo

            // Establece la posición del Label
            label2.Location = new Point(labelX, labelY + 30);
            lblTextoSupIniciar.Location = new Point(labelX1, labelY1 + 80);
            pbxLogoIniciar.Location = new Point(labelX1 + 170, labelY1 + 60);

            // Calcula las coordenadas X e Y para centrar el logo
            int labelX2 = (formularioAncho - pbLogo.Width) / 2;
            int labelY2 = (formularioAncho - pbLogo.Height) / 2;

            // Establece la posición del logo
            pbLogo.Location = new Point(labelX2, labelY2);
            btn_RegistrarUsuario.Location = new Point(labelX3, formularioAlto+300);
      
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
