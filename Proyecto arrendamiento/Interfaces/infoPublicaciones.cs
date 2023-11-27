using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_arrendamiento.Interfaces
{
    public partial class infoPublicaciones : Form
    {
        public infoPublicaciones()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //public void traerDatosU()
        //{
        //    conexion.Open();
        //    string select = "SELECT InmId,InmTitulo,InmUbicacion,InmTelefono,InmSerAgua, InmSerLuz, InmSerWifi,InmSerTv,InmSerLavadora, InmSerGas, InmPrecio,InmDescripcion,InmTipoVivienda, InmAmoblado, InmAnimales, InmParqueadero from Inmueble";
        //    OracleCommand cmd = new OracleCommand(select, conexion);
        //    cmd.CommandType = System.Data.CommandType.Text;

        //    OracleDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        CUCardPublicaciones card = new CUCardPublicaciones();
        //        string idPub = reader["InmId"].ToString();
        //        string titulPub = reader["InmTitulo"].ToString();
        //        string ubicacionPub = reader["InmUbicacion"].ToString();
        //        string InmTelefono = reader["InmTelefono"].ToString();
        //        string InmAgua = reader["InmSerAgua"].ToString();
        //        string InmSerLuz = reader["InmSerLuz"].ToString();
        //        string InmSerWifi = reader["InmSerWifi"].ToString();
        //        string InmSerTv = reader["InmSerTv"].ToString();
        //        string InmSerLavadora = reader["InmSerLavadora"].ToString();
        //        string InmSerGas = reader["InmSerGas"].ToString();
        //        string InmPrecio = reader["InmPrecio"].ToString();
        //        string InmDescripcion = reader["InmDescripcion"].ToString();
        //        string InmTipoVivienda = reader["InmTipoVivienda"].ToString();
        //        string InmAmoblado = reader["InmAmoblado"].ToString();
        //        string InmAnimales = reader["InmAnimales"].ToString();
        //        string InmParqueadero = reader["InmParqueadero"].ToString();


        //        card.lblPubTitulo.Text += titulPub;
        //        card.lblubUbicacion.Text += ubicacionPub;
        //        card.lblPrecioPub.Text += InmPrecio;
        //        flpPubs.Controls.Add(card);
        //    }
        //    conexion.Close();
        //}
    }
}
