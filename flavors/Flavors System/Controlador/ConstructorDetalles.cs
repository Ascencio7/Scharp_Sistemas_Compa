using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flavors_System.Controlador
{
    internal class ConstructorDetalles
    {
        public int id_detalle_pedido { get; set; }
        public int id_pedido { get; set; }
        public int id_producto { get; set; }
        public int cantidad { get; set; }
        public decimal subtotal { get; set; }
        public decimal precio { get; set; }
        public ConstructorDetalles() { }
    }
}
