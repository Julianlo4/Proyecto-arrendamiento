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

namespace ArriendoPrototipo.Interfaces
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void lblPrimerNombre_Click(object sender, EventArgs e)
        {

        }

        private void btn_volverMenuPrincipal_Click(object sender, EventArgs e)
        {
            PaginaPrincipalTodos paginaPrincipalTodos = new PaginaPrincipalTodos();
            paginaPrincipalTodos.Show();
            this.Close();
        }




        private void btn_volverMenuPrincipal_Click_1(object sender, EventArgs e)
        {
            PaginaPrincipalTodos paginaPrincipalTodos = new PaginaPrincipalTodos();
            paginaPrincipalTodos.Show();
            this.Close();
        }

        private void btn_RegistrarUsuario_Click_1(object sender, EventArgs e)
        {
           
            String cadenaConexion = "Data Source=localhost;User ID=ProyectoArren;Password=123; Connection Timeout = 120";
            string consultaSql;
            consultaSql = "SELECT COUNT(*) FROM REGISTRO WHERE REGNOMBREU = :param1 AND RegContrasenia = :param2";

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
                            this.Close();
                            homeUsuarioRegis.Show();
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // Realiza acciones con los datos recuperados

                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones
                        Console.WriteLine("Error: " + ex.Message);
                        MessageBox.Show("Datos incorrectos " + ex.Message, "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
