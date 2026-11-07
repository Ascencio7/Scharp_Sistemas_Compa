using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flavors_System.Controlador
{
    internal class ConstructorProductos
    {
        public int id_producto {  get; set; }
        public int id_tipo_producto { get; set; }
        public string nombre_producto { get; set; }
        public decimal precio_producto { get; set; }
        public string descripcion_producto { get; set; }
        public ConstructorProductos() { }
    }
}

