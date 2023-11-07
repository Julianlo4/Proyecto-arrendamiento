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

            OracleConnection connection = new OracleConnection(connectionString);

            // Crea el comando de inserción con los parámetros adecuados

            OracleCommand command = new OracleCommand(query, connection);
            connection.Open();

            // Ejecuta el comando de inserción

            resultado = command.ExecuteNonQuery(); ;

            // Cierra la conexión
            connection.Close();


            return resultado;
        }

        public static int ejecutarDMLParametros(string query, params OracleParameter[] parametros)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            using (OracleCommand cmd = new OracleCommand(query, connection))
            {
                cmd.Parameters.AddRange(parametros);

                connection.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas;
            }
        }

        public static int ejecutarSelect(string query)
        {
            int regId = 0; // El valor predeterminado si no se encuentra el usuario.

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                using (OracleCommand cmd = new OracleCommand(query, connection))
                {

                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            regId = reader.GetInt32(0); // Asumiendo que RegId es de tipo INT en la base de datos.
                        }
                        
                    }
                }
                return regId;

            }

        }
    }
}
