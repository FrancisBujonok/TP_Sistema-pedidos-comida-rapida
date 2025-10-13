using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Sistema_pedidos_comida_rapida.Models
{
    public class DetallePedido
    {
        public int Id_Cliente {  get; set; }
        public int Id_Producto {  get; set; }
        public int Cantidad {  get; set; }
        public double SubTotal {  get; set; }
    }
}
