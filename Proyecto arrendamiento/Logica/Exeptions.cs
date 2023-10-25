using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_arrendamiento.Logica
{
    public class Exeptions : Exception
    {
        public Exeptions() { }

        public Exeptions(string message) : base("Los datos están mal") { }

        public Exeptions(string message, Exception innerException) : base("Verifique que los datos estén bien", innerException) { }
    }
}
