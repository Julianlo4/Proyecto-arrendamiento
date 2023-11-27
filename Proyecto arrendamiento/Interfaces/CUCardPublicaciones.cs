using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public CUCardPublicaciones()
        {
            InitializeComponent();
            LimpiarTarjeta();

            //pbxPubImagen.Image = Image.FromFile(rutaImagen);
            // Crear un PictureBox y un Panel

            // Ajustar el tamaño del PictureBox
            //pbxPubImagen.Image = new Bitmap(rutaImagen);

            //// Ajustar el tamaño y la apariencia del Panel (fondo redondeado)
            //pnlContainerCardPub.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlContainerCardPub.Width, pnlContainerCardPub.Height, 20, 20));

            //// Agregar el PictureBox al Panel
            //pnlContainerCardPub.Controls.Add(pbxPubImagen);

            //// Agregar el Panel al formulario
            //Controls.Add(pnlContainerCardPub);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pbxPubImagen_Click(object sender, EventArgs e)
        {
           infoPublicaciones info = new infoPublicaciones();
           info.Show();
        }

        private void pnlContainerCardPub_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPubTitulo_Click(object sender, EventArgs e)
        {
            infoPublicaciones info = new infoPublicaciones();
            info.Show();
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


    }

}
