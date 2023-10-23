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
            query = "INSERT INTO registro (RegId, RegPrimerNom, RegSegundoNom, RegPrimerApe, RegSegundoApe,   RegNombreU, RegFechaNac, RegGenero,  RegTelefono, RegCorreo,  RegAspArrendador, RegAspArrendatario, RegContrasenia)" +
                " values(" + identiificacion + ", '" + primerNombre + ", '" + segundoNombre + ", '" + primerApellido + ", '" + segundoApellido + ", '" + nombreUsuario + ", '" + fechaNacimiento + ", '" + genero + ", '" + telefono + ", '" + correo + ", '" + " 0 " + ", '" + "0" + ", '" + contraseña + "')" ;
            return  Datos.Datos.ejecutarDMl(query);

        }
    }
}
