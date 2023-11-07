using ArriendoPrototipo.Interfaces;
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
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
            pnlPrincipal = new Panel();
            pnlPrincipal.Dock = DockStyle.Fill;
            this.Controls.Add(pnlPrincipal);

            

        }
        private Form formularioCargado = null;

        public void CargarFormularioSecundario(Form formularioSecundario)
        {
            // Si ya hay un formulario cargado en el contenedor, límpialo.
            if (formularioCargado != null)
            {
                formularioCargado.Dispose(); // Libera recursos del formulario cargado anteriormente
                pnlPrincipal.Controls.Clear(); // Limpia el contenedor
            }

            // Asigna el nuevo formulario al campo formularioCargado.
            formularioCargado = formularioSecundario;

            // Añade el nuevo formulario al contenedor y ajústalo.
            formularioSecundario.TopLevel = false;
            formularioSecundario.FormBorderStyle = FormBorderStyle.None;
            formularioSecundario.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(formularioSecundario);
            formularioSecundario.Show();
            
        }
    }
}
