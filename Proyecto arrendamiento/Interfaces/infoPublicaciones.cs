using ArriendoPrototipo.Interfaces;
using Oracle.ManagedDataAccess.Client;
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

namespace Proyecto_arrendamiento.Interfaces
{

    public partial class infoPublicaciones : Form
    {
        static String cadenaConexion = "Data Source=localhost;User ID=ProyectoArren;Password=123;";
        OracleConnection conexion = new OracleConnection(cadenaConexion);
        public infoPublicaciones()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
    }
}
