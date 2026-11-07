using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flavors_System.Controlador
{
    internal class ConstructorUsuarios
    {
        public static int id_usuario { get; set; }
        public int id_tipo_usuario { get; set; }
        public int id_estado_usuario { get; set; }
        public int id_empleado { get; set; }
        public string usuario { get; set; }
        public string contrasenia { get; set; }

        public ConstructorUsuarios() { }
   }
}
