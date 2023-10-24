using System;
using System.Collections.Generic;
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
        public int RegistroUsuario(string primerNombre, string segundoNombre, string primerApellido,
        string segundoApellido, string genero, string telefono, string correo,
        string identificacion, string contraseña, DateTime fechaNacimiento, string nombreUsuario)
        {
            string query = "INSERT INTO registro (RegId, RegPrimerNom, RegSegundoNom, RegPrimerApe, RegSegundoApe, RegNombreU, RegFechaNac, RegGenero, RegTelefono, RegCorreo, RegAspArrendador, RegAspArrendatario, RegContrasenia) " +
                           "VALUES (:RegId, :RegPrimerNom, :RegSegundoNom, :RegPrimerApe, :RegSegundoApe, :RegNombreU, TO_DATE(:RegFechaNac, 'DD/MM/YYYY'), :RegGenero, :RegTelefono, :RegCorreo, 0, 0, :RegContrasenia)";

            // Llama al método de la otra clase para ejecutar la consulta.
            int resultado = Datos.Datos.ejecutarDMLParametros(query, identificacion, primerNombre, segundoNombre, primerApellido, segundoApellido, genero, telefono, correo, fechaNacimiento, nombreUsuario, contraseña);

            return resultado;
        }
    }
}
