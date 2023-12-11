using ArriendoPrototipo.Interfaces;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_arrendamiento.Interfaces
{
    public partial class CUCardPublicaciones : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private string rutaImagen = "Resources/casas.jpg";
        static String cadenaConexion = "Data Source=localhost;User ID=ProyectoArren;Password=123; Connection Timeout = 120";
        OracleConnection conexion = new OracleConnection(cadenaConexion);

        public int inmuebleId = 0; 
        private int ClickedId = 0;
        public CUCardPublicaciones()
        {
            
            InitializeComponent();
            LimpiarTarjeta();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void pbxPubImagen_Click(object sender, EventArgs e)
        {
            traerDatosU(this.inmuebleId);
            //MessageBox.Show(inmuebleId.ToString());
        }

        private void pnlContainerCardPub_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPubTitulo_Click(object sender, EventArgs e)
        {
            traerDatosU(this.inmuebleId);
        }
        public void LimpiarTarjeta()
        {
            lblPubTitulo.Text = string.Empty;
            lblubUbicacion.Text = string.Empty;
            lblPrecioPub.Text = string.Empty;
            // Limpiar otros controles según sea necesario
        }

        public void ActualizarTarjeta(string titulo, string ubicacion, string precio)
        {
            lblPubTitulo.Text = titulo;
            lblubUbicacion.Text = ubicacion;
            lblPrecioPub.Text = precio;
            // Actualiza otros controles según sea necesario
        }

        public void traerDatosU(int id)
        {
            conexion.Open();

            string select = "SELECT * FROM Inmueble Join Registro ON InmId =" + id;

            using (OracleCommand cmd = new OracleCommand(select, conexion))
            {

                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                       infoPublicaciones info = new infoPublicaciones();

                        string idPub = reader["InmId"].ToString();
                        string titulPub = reader["InmTitulo"].ToString();
                        string ubicacionPub = reader["InmUbicacion"].ToString();
                        string InmPrecio = reader["InmPrecio"].ToString();
                        byte[] imagenBytes = (byte[])reader["InmImagen"];
                        string InmTelefono = reader["InmTelefono"].ToString();
                        string InmAgua = reader["InmSerAgua"].ToString();
                        string InmSerLuz = reader["InmSerLuz"].ToString();
                        string InmSerWifi = reader["InmSerWifi"].ToString();
                        string InmSerTv = reader["InmSerTv"].ToString();
                        string InmSerLavadora = reader["InmSerLavadora"].ToString();
                        string InmSerGas = reader["InmSerGas"].ToString();
                        string InmDescripcion = reader["InmDescripcion"].ToString();
                        string InmTipoVivienda = reader["InmTipoVivienda"].ToString();
                        string InmAmoblado = reader["InmAmoblado"].ToString();
                        string InmAnimales = reader["InmAnimales"].ToString();
                        string InmParqueadero = reader["InmParqueadero"].ToString();
                        string primerNombre = reader["RegPrimerNom"].ToString();
                        string primerApellido = reader["RegPrimerApe"].ToString();


                        if (imagenBytes != null && imagenBytes.Length > 0)
                        {
                            Image imagen = ConvertirBytesAImagen(imagenBytes);
                            info.pbxImageInm.Image = imagen;
                            info.lblPubTitulo.Text = titulPub;
                            info.lblubUbicacion.Text = ubicacionPub;
                            info.lblPrecio.Text = InmPrecio;
                            info.lblAgua.Text = InmAgua == "1" ? "Si" : "No";
                            info.lblLuz.Text = InmSerLuz == "1" ? "Si" : "No";
                            info.lblWifi.Text = InmSerWifi== "1" ? "Si" : "No";
                            info.lblTv.Text = InmSerTv == "1" ? "Si" : "No";
                            info.lblLavadora.Text = InmSerLavadora == "1" ? "Si" : "No";
                            info.lblGas.Text = InmSerGas == "1" ? "Si" : "No";
                            info.lblDescripcion.Text = InmDescripcion;
                            info.lblTipoCasa.Text = InmTipoVivienda;
                            info.lblAmoblado.Text = InmAmoblado == "1" ? "Si" : "No";
                            info.lblAnimales.Text = InmAmoblado == "1" ? "Si" : "No";
                            info.lblTelefono.Text = InmTelefono;
                            info.lblNombreArrendatario.Text = primerNombre +" "+ primerApellido;
                            info.Show();
                             
                        }
                    }

                    conexion.Close();
                }
            }
        }

        private Image ConvertirBytesAImagen(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        public void setClickedId(int id)
        {
            this.ClickedId = id;
        }
        public int getIdInmueble()
        {
            return inmuebleId;
        }
    }

}
