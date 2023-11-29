using ArriendoPrototipo.Datos;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_arrendamiento.Logica
{
    internal class RegistrarInmueble
    {
        public int  insertarInmueble(int regId,string tituloPub, string ubicacion, string direccion, string telefono, int InmSerAgua , int InmSerLuz, int InmSerWifi, int InmSerTv,
                     int  InmSerLavadora ,int  InmSerGas , string InmPrecio , string descripcion , string tipoVivienda,
                      int InmAmoblado, int InmAnimales, string InmParqueadero, byte[]InmImagen)
        {
            
            string query = "INSERT INTO inmueble (RegId, InmTitulo, InmUbicacion, InmDireccion, InmTelefono, " +
            "InmSerAgua, InmSerLuz, InmSerWifi, InmSerTv, InmSerLavadora, InmSerGas, InmPrecio, " +
            "InmDescripcion, InmTipoVivienda, InmAmoblado, InmAnimales, InmParqueadero, InmImagen) " +
            "VALUES (:InmId, :InmTitulo, :InmUbicacion, :InmDireccion, :InmTelefono, " +
            ":InmSerAgua, :InmSerLuz, :InmSerWifi, :InmSerTv, :InmSerLavadora, :InmSerGas, :InmPrecio, " +
            ":InmDescripcion, :InmTipoVivienda, :InmAmoblado, :InmAnimales, :InmParqueadero, :InmImagen)";


            OracleParameter[] parametros = new OracleParameter[]
            {
                new OracleParameter("RegID", OracleDbType.Int32, regId, System.Data.ParameterDirection.Input ),
                 new OracleParameter("InmTitulo", OracleDbType.Varchar2, tituloPub, System.Data.ParameterDirection.Input),
                 new OracleParameter("InmUbicacion", OracleDbType.Varchar2, ubicacion, System.Data.ParameterDirection.Input),
                 new OracleParameter("InmDireccion", OracleDbType.Varchar2, direccion, System.Data.ParameterDirection.Input),
                 new OracleParameter("InmTelefono", OracleDbType.Varchar2, telefono, System.Data.ParameterDirection.Input),
                 new OracleParameter("InmSerAgua", OracleDbType.Int32, InmSerAgua, System.Data.ParameterDirection.Input),
                new OracleParameter("InmSerLuz", OracleDbType.Int32, InmSerLuz, System.Data.ParameterDirection.Input),
                new OracleParameter("InmSerWifi", OracleDbType.Int32, InmSerWifi, System.Data.ParameterDirection.Input),
                 new OracleParameter("InmSerTv", OracleDbType.Int32, InmSerTv, System.Data.ParameterDirection.Input),
                new OracleParameter("InmSerLavadora", OracleDbType.Int32, InmSerLavadora, System.Data.ParameterDirection.Input),
                new OracleParameter("InmSerGas", OracleDbType.Int32, InmSerGas, System.Data.ParameterDirection.Input),
                new OracleParameter("InmPrecio", OracleDbType.Decimal, InmPrecio, System.Data.ParameterDirection.Input),
                new OracleParameter("InmDescripcion", OracleDbType.Varchar2, descripcion, System.Data.ParameterDirection.Input),
                new OracleParameter("InmTipoVivienda", OracleDbType.Varchar2, tipoVivienda, System.Data.ParameterDirection.Input),
                 new OracleParameter("InmAmoblado", OracleDbType.Int32, InmAmoblado, System.Data.ParameterDirection.Input),
                new OracleParameter("InmAnimales", OracleDbType.Int32, InmAnimales, System.Data.ParameterDirection.Input),
                new OracleParameter("InmParqueadero", OracleDbType.Varchar2, InmParqueadero, System.Data.ParameterDirection.Input),
                new OracleParameter("InmImagen", OracleDbType.Blob, InmImagen, System.Data.ParameterDirection.Input),
        };
            // Llama al método de la otra clase para ejecutar la consulta con parámetros.
            int resultado = Datos.ejecutarDMLParametros(query, parametros);
            return resultado;
        }

        public int consultarId(string nombreU)
        {
            String query;
            query = "Select regId " +
                "from REGISTRO " +
                "WHERE REGNOMBREU =" +"'"+nombreU+"'";
            return Datos.ejecutarSelect(query);
        }


    }
}
