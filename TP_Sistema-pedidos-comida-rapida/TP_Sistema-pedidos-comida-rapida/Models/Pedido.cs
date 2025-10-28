using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Sistema_pedidos_comida_rapida.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado {  get; set; }
        public decimal Total {  get; set; }
        public List<DetallePedido> Detalles = new List<DetallePedido>();
    }
}
