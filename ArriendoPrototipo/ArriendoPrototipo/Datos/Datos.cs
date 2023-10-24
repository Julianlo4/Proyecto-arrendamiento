using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArriendoPrototipo.Datos
{
    internal class Datos
    {
        private static string connectionString = @"Data Source=localhost;User ID=ProyectoArren;Password=123; Connection Timeout = 120";

        public static int ejecutarDMl(string query)
        {
            int resultado;

            Oracle.ManagedDataAccess.Client.OracleConnection connection = new Oracle.ManagedDataAccess.Client.OracleConnection(connectionString);

            // Crea el comando de inserción con los parámetros adecuados

            Oracle.ManagedDataAccess.Client.OracleCommand command = new Oracle.ManagedDataAccess.Client.OracleCommand(query, connection);
            connection.Open();

            // Ejecuta el comando de inserción

            resultado = command.ExecuteNonQuery(); ;

            // Cierra la conexión
            connection.Close();


            return resultado;
        }

        public static int ejecutarDMLParametros(string query, string identificacion, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string genero, string telefono, string correo, DateTime fechaNacimiento, string nombreUsuario, string contraseña)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            using (OracleCommand cmd = new OracleCommand(query, connection))
            {
                cmd.Parameters.Add("RegId", OracleDbType.Varchar2).Value = identificacion;
                cmd.Parameters.Add("RegPrimerNom", OracleDbType.Varchar2).Value = primerNombre;
                cmd.Parameters.Add("RegSegundoNom", OracleDbType.Varchar2).Value = segundoNombre;
                cmd.Parameters.Add("RegPrimerApe", OracleDbType.Varchar2).Value = primerApellido;
                cmd.Parameters.Add("RegSegundoApe", OracleDbType.Varchar2).Value = segundoApellido;
                cmd.Parameters.Add("RegNombreU", OracleDbType.Varchar2).Value = nombreUsuario;
                cmd.Parameters.Add("RegFechaNac", OracleDbType.Date).Value = fechaNacimiento;
                cmd.Parameters.Add("RegGenero", OracleDbType.Varchar2).Value = genero;
                cmd.Parameters.Add("RegTelefono", OracleDbType.Varchar2).Value = telefono;
                cmd.Parameters.Add("RegCorreo", OracleDbType.Varchar2).Value = correo;
                cmd.Parameters.Add("RegContrasenia", OracleDbType.Varchar2).Value = contraseña;

                connection.Open();
                return cmd.ExecuteNonQuery();
            }
        }

    }
}
