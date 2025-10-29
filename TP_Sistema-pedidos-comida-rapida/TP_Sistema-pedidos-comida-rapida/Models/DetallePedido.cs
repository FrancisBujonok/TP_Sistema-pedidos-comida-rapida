using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Sistema_pedidos_comida_rapida.Models
{
    public class DetallePedido
    {
        [Key]
        public int ID { get; set; }
        public int Id_Pedido {  get; set; }
        public int Id_Producto {  get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal => PrecioUnitario * Cantidad;
    }
}
