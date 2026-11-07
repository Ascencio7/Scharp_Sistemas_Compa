using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flavors_System.Controlador
{
    internal class ConstructorClientes
    {
        public int id_cliente { get; set; }
        public int id_estado_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public string correo {  get; set; }
        public string direccion { get; set;}
        public string telefono { get; set; }

        public ConstructorClientes() { }
    }
}
