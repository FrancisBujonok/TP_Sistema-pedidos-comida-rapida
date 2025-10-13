using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Sistema_pedidos_comida_rapida.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int Id_Cliente {  get; set; }
        public int NumeroPedido {  get; set; }
        public DateTime Fecha { get; set; }
        public string Estado {  get; set; }
        public double Total {  get; set; }
        
    }
}
