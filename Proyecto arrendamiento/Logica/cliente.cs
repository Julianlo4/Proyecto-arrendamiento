using ArriendoPrototipo.Interfaces;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArriendoPrototipo.Logica
{
    class cliente
    {
        static String cadenaConexion = "Data Source=localhost;User ID=ProyectoArren;Password=123; Connection Timeout = 120";
        OracleConnection conexion = new OracleConnection(cadenaConexion);
        public int registroDeUsuario(string primerNombre, string segundoNombre, string primerApellido,
                string segundoApellido, string genero, string telefono, string correo,
                string identiificacion, string contraseña , DateTime fechaNacimiento, string nombreUsuario)
        {
            string query;
            query = "INSERT INTO registro (RegId, RegPrimerNom, RegSegundoNom, RegPrimerApe, RegSegundoApe, RegNombreU, RegFechaNac, RegGenero, RegTelefono, RegCorreo, RegAspArrendador, RegAspArrendatario, RegContrasenia)" +
                    " values(" + identiificacion + ", '" + primerNombre + "', '" + segundoNombre + "', '" + primerApellido + "', '" + segundoApellido + "', '" + nombreUsuario + "', TO_DATE('" + fechaNacimiento + "', 'DD/MM/YYYY'), '" + genero + "', '" + telefono + "', '" + correo + 0 + "," + 0 + contraseña + "')";


            return Datos.Datos.ejecutarDMl(query);

        }
        public int RegistroUsuarioPrms(string primerNombre, string segundoNombre, string primerApellido,
     string segundoApellido, string genero, string telefono, string correo,
     int identificacion, string contraseña, string fechaNacimiento, string nombreUsuario)
        {
            string query = "INSERT INTO registro (RegId, RegPrimerNom, RegSegundoNom, RegPrimerApe, RegSegundoApe, RegFechaNac, RegGenero, RegTelefono, RegCorreo, RegAspArrendador, RegAspArrendatario, RegNombreU, RegContrasenia,RegEstado) " +
                           "VALUES (:RegId, :RegPrimerNom, :RegSegundoNom, :RegPrimerApe, :RegSegundoApe, TO_DATE(:RegFechaNac, 'DD/MM/YYYY'), :RegGenero, :RegTelefono, :RegCorreo, 0, 0,:RegNombreU,:RegContrasenia,1)";

            OracleParameter[] parametros = new OracleParameter[]
            {

        new OracleParameter("RegId", OracleDbType.Int32, identificacion, System.Data.ParameterDirection.Input),
        new OracleParameter("RegPrimerNom", OracleDbType.Varchar2, primerNombre, System.Data.ParameterDirection.Input),
        new OracleParameter("RegSegundoNom", OracleDbType.Varchar2, segundoNombre, System.Data.ParameterDirection.Input),
        new OracleParameter("RegPrimerApe", OracleDbType.Varchar2, primerApellido, System.Data.ParameterDirection.Input),
        new OracleParameter("RegSegundoApe", OracleDbType.Varchar2, segundoApellido, System.Data.ParameterDirection.Input),
        new OracleParameter("RegFechaNac", OracleDbType.Date, DateTime.ParseExact(fechaNacimiento, "DD/MM/YYYY", CultureInfo.InvariantCulture), System.Data.ParameterDirection.Input),
        new OracleParameter("RegGenero", OracleDbType.Varchar2, genero, System.Data.ParameterDirection.Input),
        new OracleParameter("RegTelefono", OracleDbType.Varchar2, telefono, System.Data.ParameterDirection.Input),
        new OracleParameter("RegCorreo", OracleDbType.Varchar2, correo, System.Data.ParameterDirection.Input),
        new OracleParameter("RegNombreU", OracleDbType.Varchar2, nombreUsuario, System.Data.ParameterDirection.Input),
        new OracleParameter("RegContrasenia", OracleDbType.Varchar2, contraseña, System.Data.ParameterDirection.Input),
            };

            // Llama al método de la otra clase para ejecutar la consulta.
            int resultado = Datos.Datos.ejecutarDMLParametros(query, parametros);

            return resultado;
        }

        public bool verificarInmuebles(string nombreUsuario)
        {
            
            string query = "SELECT COUNT(*) FROM INMUEBLE JOIN REGISTRO ON INMUEBLE.REGID = REGISTRO.REGID WHERE REGNOMBREU = :nombreUsuario";
            //int numInmuebles = Datos.Datos.ejecutarDMl(query);
            using (OracleConnection conexion = new OracleConnection(cadenaConexion))
            {
                using (OracleCommand comando = new OracleCommand(query, conexion))
                {

                    // Agregar los parámetros a la consulta
                    comando.Parameters.Add("nombreUsuario", OracleDbType.Varchar2).Value = nombreUsuario;

                    try
                    {
                        conexion.Open();
                        OracleDataReader lector = comando.ExecuteReader();
                        int verificar = Convert.ToInt32(comando.ExecuteScalar());

                        if (verificar > 0)
                        {
                            conexion.Close();
                            return true;
                        }
                        else
                        {
                            conexion.Close();
                            return false;
                        }

                        // Realiza acciones con los datos recuperados

                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones
                        conexion.Close();
                        Console.WriteLine("Error: " + ex.Message);
                        MessageBox.Show("Datos incorrectos " + ex.Message, "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

        public bool modificarCliente(string primerN,string segundoN,string primerA,string segundoA,string tel,string correo,string usuario,string clave)
        {
            conexion.Open();
            string Update = "UPDATE REGISTRO SET RegPrimerNom = :primerN,RegSegundoNom = :segundoN,RegPrimerApe = :primerA,RegSegundoApe = :segundoA,RegTelefono = :tel,RegCorreo = :correo WHERE regNombreU = :usuario AND RegContrasenia = :clave";
            OracleCommand cmd = new OracleCommand(Update,conexion);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@primerN", primerN);
            cmd.Parameters.Add("@segundoN", segundoN);
            cmd.Parameters.Add("@primerA", primerA);
            cmd.Parameters.Add("@segundoA", segundoA);
            cmd.Parameters.Add("@tel", tel);
            cmd.Parameters.Add("@correo", correo);
            cmd.Parameters.Add("@usuario", usuario);
            cmd.Parameters.Add("@clave", clave);

            try
            {
                cmd.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.ToString());
                conexion.Close();
                return false;
            }

        }

        public bool modificarClave (string usuario, string claveActual, string claveNueva)
        {
            conexion.Open();
            string Update = "UPDATE REGISTRO SET RegContrasenia = :claveNueva WHERE RegNombreU = :usuario AND RegContrasenia = :claveActual";
            OracleCommand cmd = new OracleCommand(Update,conexion);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@claveNueva", claveNueva);
            cmd.Parameters.Add("@usuario", usuario);
            cmd.Parameters.Add("@claveActual", claveActual);
            

            try
            {
                cmd.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message); conexion.Close();
                return false;
            }
        }

        public bool desactivarCliente(string usuario, string claveConfir1, string claveConfir2)
        {
            if (claveConfir1  != claveConfir2)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return false;
            }
            else
            {
                conexion.Open();
                string Update = "UPDATE REGISTRO SET RegEstado = 0 WHERE RegNombreU = :usuario";
                OracleCommand cmd = new OracleCommand(Update, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add("@usuario", usuario);
           
                try
                {
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message); conexion.Close();
                    return false;
                }
            }

            
        }
    }


   
}
