using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_arrendamiento.Logica
{
    internal class InmuebleInfo
    {
        public string IdPub { get; set; }
        public string TitulPub { get; set; }
        public string UbicacionPub { get; set; }
        public string InmPrecio { get; set; }
        public Image Imagen { get; set; }
        public string InmTelefono { get; set; }
        public string InmAgua { get; set; }
        public string InmSerLuz { get; set; }
        public string InmSerWifi { get; set; }
        public string InmSerTv { get; set; }
        public string InmSerLavadora { get; set; }
        public string InmSerGas { get; set; }
        public string InmDescripcion { get; set; }
        public string InmTipoVivienda { get; set; }
        public string InmAmoblado { get; set; }
        public string InmAnimales { get; set; }
        public string InmParqueadero { get; set; }
    }
}
