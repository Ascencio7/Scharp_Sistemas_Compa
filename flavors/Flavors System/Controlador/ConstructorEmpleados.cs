using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flavors_System.Controlador
{
    internal class ConstructorEmpleados
    {
        public int id_empleado { get; set; }
        public string nombre_empleado { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string dui { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public ConstructorEmpleados() { }
    }
}
