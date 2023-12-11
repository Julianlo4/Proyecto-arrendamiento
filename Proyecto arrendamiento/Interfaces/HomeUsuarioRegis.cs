using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArriendoPrototipo.Logica;
using Oracle.ManagedDataAccess.Client;
using Proyecto_arrendamiento.Interfaces;
using Proyecto_arrendamiento.Logica;

namespace ArriendoPrototipo.Interfaces
{
    public partial class HomeUsuarioRegis : Form
    {

        static String cadenaConexion = "Data Source=localhost;User ID=ProyectoArren;Password=123;";
        OracleConnection conexion = new OracleConnection(cadenaConexion);
        private string nombreCliente;
        cliente cliente1 = new cliente();
        public HomeUsuarioRegis(string nombreCliente)
        {
            InitializeComponent();
            
            this.nombreCliente = nombreCliente;
            lblNombreUsuario.Text = nombreCliente;
            if (cliente1.verificarInmuebles(lblNombreUsuario.Text))
            {
                btnPublicaciones.Show();
                lbnPublicaciones.Show();
            }
            else
            {
                btnPublicaciones.Hide();
                lbnPublicaciones .Hide();
            }
            traerDatosU();
            ContextMenuStrip  = new ContextMenuStrip();
            ToolStripMenuItem configurar = new ToolStripMenuItem("Configurar tu cuenta");
            ToolStripMenuItem salir = new ToolStripMenuItem("salir de tu cuenta");

            configurar.Click += configurar_Click;
            salir.Click += salir_Click;

            ContextMenuStrip.Items.Add(configurar);
            ContextMenuStrip.Items.Add(salir);

            lbConfigurar.ContextMenuStrip = ContextMenuStrip;

            this.WindowState = FormWindowState.Maximized;
            this.FormClosing += MiFormularioPrincipal_FormClosing;
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

        private void configurar_Click(object sender, EventArgs e)
        {
            ConfiguraciónCuentaUsuario modificar = new ConfiguraciónCuentaUsuario(lblNombreUsuario.Text);
            this.Hide();
            modificar.Show();
        }

        private void salir_Click(object sender,EventArgs e)
        {
            PaginaPrincipalTodos main = new PaginaPrincipalTodos();
            this.Hide();
            main.Show();
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



        private void btnAgregarPublicacion_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarArriendo_Click(object sender, EventArgs e)
        {
            RegistroInmueble registroInmueble = new RegistroInmueble(lblNombreUsuario.Text);
            this.Close();
            registroInmueble.Show();
        }

        private void btnAgregarArriendo_Click_1(object sender, EventArgs e)
        {
            RegistroInmueble registroInmueble = new RegistroInmueble(lblNombreUsuario.Text);
            registroInmueble.Show();
            this.Hide();
        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {

        }

        private void pbxLogo_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbnCerrarSesion_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbConfigurar_Click(object sender, EventArgs e)
        {
            ContextMenuStrip.Show(lbConfigurar, lbConfigurar.PointToClient(Cursor.Position));
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblSinCoinci.Visible = false;
            flpPubs.Controls.Clear();
            conexion.Open();
            string titulo = buscarTitulo.Texts;
            string select = "SELECT * FROM INMUEBLE WHERE UPPER(INMTITULO) LIKE UPPER('%" + titulo + "%')";
            using (OracleCommand cmd = new OracleCommand(select, conexion))
            {
                cmd.CommandType = System.Data.CommandType.Text;


                using (OracleDataReader reader = cmd.ExecuteReader())
                {

                    if (!reader.HasRows)
                    {
                        lblSinCoinci.Text = "sin coincidencias para \"" + buscarTitulo.Texts + "\"";
                        lblSinCoinci.Visible = true;
                    }
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

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            lblSinCoinci.Visible = false;
            flpPubs.Controls.Clear();
            conexion.Open();
            bool and = false;

            string select = "SELECT * FROM INMUEBLE NATURAL JOIN REGISTRO";

            if (buscarTitulo.Texts != string.Empty)
            {
                select += " WHERE UPPER(INMTITULO) LIKE UPPER('%" + buscarTitulo.Texts + "%')";
                and = true;
            }

            if (txtPrecioMinimo.Texts != string.Empty)
            {
                if (and) select += " AND ";
                else select += " WHERE ";

                select += "  INMPRECIO > " + txtPrecioMinimo.Texts;
                and = true;


            }


            if (txtPrecioMaximo.Texts != string.Empty)
            {
                if (and) select += " AND ";
                else select += " WHERE ";

                select += "  INMPRECIO < " + txtPrecioMaximo.Texts;
                and = true;
            }

            if (cbUbi.SelectedIndex > 0)
            {
                if (and) select += " AND ";
                else select += " WHERE ";

                select += "  UPPER(INMUBICACION) = UPPER('" + cbUbi.SelectedItem.ToString() + "')";
                and = true;
            }

            if (txtPropietario.Texts != string.Empty)
            {
                if (and) select += " AND ";
                else select += " WHERE ";

                select += "  UPPER(REGNOMBREU) = UPPER('" + txtPropietario.Texts + "')";
            }

            using (OracleCommand cmd = new OracleCommand(select, conexion))
            {
                cmd.CommandType = System.Data.CommandType.Text;


                using (OracleDataReader reader = cmd.ExecuteReader())
                {

                    if (!reader.HasRows)
                    {
                        lblSinCoinci.Text = "sin coincidencias";
                        lblSinCoinci.Visible = true;
                    }
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
    }
}
