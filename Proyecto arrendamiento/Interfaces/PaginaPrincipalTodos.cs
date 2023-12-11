
using DevExpress.Data.Filtering.Helpers;
using Oracle.ManagedDataAccess.Client;
using Proyecto_arrendamiento.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArriendoPrototipo.Interfaces
{
    public partial class PaginaPrincipalTodos : Form
    {

        static String cadenaConexion = "Data Source=localhost;User ID=ProyectoArren;Password=123;";
        OracleConnection conexion = new OracleConnection(cadenaConexion);
        private int id  = 0;
        public PaginaPrincipalTodos()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormClosing += MiFormularioPrincipal_FormClosing;
            traerDatosU();

            //AgregarTarjetaAlPanel(new CUCardPublicaciones());
            //AgregarTarjetaAlPanel(new UserControl1());

        }
        public void AgregarTarjetaAlPanel(UserControl tarjeta)
        {
            flpPubs.FlowDirection = FlowDirection.LeftToRight;
            flpPubs.WrapContents = true;
            flpPubs.Controls.Add(tarjeta);
        }
        private void CargarControlUsuario(UserControl controlUsuario)
        {
            // Limpiar el panel antes de agregar el nuevo control de usuario
            pnlContenedorPublicaciones.Controls.Clear();

            // Ajustar el tamaño del control de usuario al tamaño del panel
            controlUsuario.Dock = DockStyle.Left;

            // Agregar el control de usuario al panel
            pnlContenedorPublicaciones.Controls.Add(controlUsuario);
        }

        private void MiFormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Pregunta al usuario si realmente desea cerrar la aplicación
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Cerrar la aplicación", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.No)
                {
                    // Cancela el cierre de la aplicación si el usuario elige "No"
                    e.Cancel = true;
                }
                else
                {
                    // Cierra la aplicación si el usuario elige "Sí"
                    Application.Exit();
                }
            }
        }


        private void lblTextoSupInicio_Click(object sender, EventArgs e)
        {

        }

        private void btn_RegistrarUsuarioMenu_Click(object sender, EventArgs e)
        {
            RegistroUsuario registro = new RegistroUsuario();
            registro.Show();
            this.Hide();
        }

        private void lblIniciarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion iniciarSesion = new IniciarSesion();
            iniciarSesion.Show();
            this.Hide();
        }

        private void lblIniciarSesion_Click_1(object sender, EventArgs e)
        {
            IniciarSesion iniciarSesion = new IniciarSesion();
            iniciarSesion.Show();
            this.Hide();
        }

        private void btn_RegistrarUsuarioMenu_Click_1(object sender, EventArgs e)
        {
            RegistroUsuario us = new RegistroUsuario();
            us.Show();
            this.Hide();
        }

        public void traerDatosU()
        {
            flpPubs.Controls.Clear();
            conexion.Open();
            string select = "SELECT * from Inmueble";
            using (OracleCommand cmd = new OracleCommand(select, conexion))
            {
                cmd.CommandType = System.Data.CommandType.Text;


                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CUCardPublicaciones card = new CUCardPublicaciones();
                        
                        string idPub = reader["InmId"].ToString();
                        string titulPub = reader["InmTitulo"].ToString();
                        string ubicacionPub = reader["InmUbicacion"].ToString();
                        string InmPrecio = reader["InmPrecio"].ToString();
                        byte[] imagenBytes = (byte[])reader["InmImagen"];


                        if (imagenBytes != null && imagenBytes.Length > 0)
                        {
                            Image imagen = ConvertirBytesAImagen(imagenBytes);


                            
                            card.lblPubTitulo.Text += titulPub;
                            card.lblubUbicacion.Text += ubicacionPub;
                            card.lblPrecioPub.Text += InmPrecio;
                            card.pbxPubImagen.Image = imagen;
                            card.inmuebleId = Int32.Parse(idPub);
                           
                            flpPubs.Controls.Add(card);
                        }
                        else
                        {
                            card.lblPubTitulo.Text += titulPub;
                            card.lblubUbicacion.Text += ubicacionPub;
                            card.lblPrecioPub.Text += InmPrecio;
                        }
                        flpPubs.Refresh();


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


        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            flpPubs.VerticalScroll.Value = e.NewValue;
        }
        private void flpPubs_SizeChanged(object sender, EventArgs e)
        {
            // Ajusta el valor máximo de la barra de desplazamiento según el tamaño del FlowLayoutPanel
            //vScrollBar1.Maximum = flpPubs.VerticalScroll.Maximum;
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            flpPubs.VerticalScroll.Value = e.NewValue;
        }

        private void flpPubs_Click(object sender, EventArgs e)
        {
            Point mousePosition = flpPubs.PointToClient(MousePosition);

            // Buscar el control en la posición del ratón
            Control controlClicked = flpPubs.GetChildAtPoint(mousePosition);

            if (controlClicked is CUCardPublicaciones)
            {
                // Si el control clicado es una CUCardPublicaciones, manejar el evento de clic
                CUCardPublicaciones clickedCard = (CUCardPublicaciones)controlClicked;
                //clickedCard.setClickedId(clickedCard.getIdInmueble());                  
                //MostrarDetallesInmueble(inmuebleId);
            }
        }

        public int  getId()
        { return id; }
    }
}
