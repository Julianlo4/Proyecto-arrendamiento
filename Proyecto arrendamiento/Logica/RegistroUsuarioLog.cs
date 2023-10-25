using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArriendoPrototipo.Logica
{
    class RegistroUsuarioLog
    {
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
            string query = "INSERT INTO registro (RegId, RegPrimerNom, RegSegundoNom, RegPrimerApe, RegSegundoApe, RegNombreU, RegFechaNac, RegGenero, RegTelefono, RegCorreo, RegAspArrendador, RegAspArrendatario, RegContrasenia) " +
                           "VALUES (:RegId, :RegPrimerNom, :RegSegundoNom, :RegPrimerApe, :RegSegundoApe, :RegNombreU, TO_DATE(:RegFechaNac, 'DD/MM/YYYY'), :RegGenero, :RegTelefono, :RegCorreo, 0, 0, :RegContrasenia)";

            OracleParameter[] parametros = new OracleParameter[]
            {
        new OracleParameter("RegId", OracleDbType.Int32, identificacion, System.Data.ParameterDirection.Input),
        new OracleParameter("RegPrimerNom", OracleDbType.Varchar2, primerNombre, System.Data.ParameterDirection.Input),
        new OracleParameter("RegSegundoNom", OracleDbType.Varchar2, segundoNombre, System.Data.ParameterDirection.Input),
        new OracleParameter("RegPrimerApe", OracleDbType.Varchar2, primerApellido, System.Data.ParameterDirection.Input),
        new OracleParameter("RegSegundoApe", OracleDbType.Varchar2, segundoApellido, System.Data.ParameterDirection.Input),
        new OracleParameter("RegNombreU", OracleDbType.Varchar2, nombreUsuario, System.Data.ParameterDirection.Input),
        new OracleParameter("RegFechaNac", OracleDbType.Date, DateTime.ParseExact(fechaNacimiento, "DD/MM/YYYY", CultureInfo.InvariantCulture), System.Data.ParameterDirection.Input),
        new OracleParameter("RegGenero", OracleDbType.Varchar2, genero, System.Data.ParameterDirection.Input),
        new OracleParameter("RegTelefono", OracleDbType.Varchar2, telefono, System.Data.ParameterDirection.Input),
        new OracleParameter("RegCorreo", OracleDbType.Varchar2, correo, System.Data.ParameterDirection.Input),
        new OracleParameter("RegContrasenia", OracleDbType.Varchar2, contraseña, System.Data.ParameterDirection.Input),
            };

            // Llama al método de la otra clase para ejecutar la consulta.
            int resultado = Datos.Datos.ejecutarDMLParametros(query, parametros);

            return resultado;
        }

    }
}
