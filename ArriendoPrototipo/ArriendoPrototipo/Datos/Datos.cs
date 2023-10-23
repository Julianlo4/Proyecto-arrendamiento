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
        private static string connectionString = @"Data Source=localhost;User ID=ProtectoArren;Password=123";

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
    }
    

}
