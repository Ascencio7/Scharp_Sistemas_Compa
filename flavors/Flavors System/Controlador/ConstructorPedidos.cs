using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flavors_System.Controlador
{
    internal class ConstructorPedidos
    {
        //tbPedidos
        public int id_pedido {  get; set; }
        public int id_mesa {  get; set; }
        public int id_usuario { get; set; }
        public int id_cliente { get; set; }
        public int id_tipo_pedido { get; set; }
        public DateTime fechahora {  get; set; }
        public decimal total { get; set; }
        public ConstructorPedidos() { }
    }
}
