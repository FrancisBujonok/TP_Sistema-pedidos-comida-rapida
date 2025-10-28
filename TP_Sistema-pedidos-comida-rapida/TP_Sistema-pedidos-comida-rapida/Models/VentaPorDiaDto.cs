using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Sistema_pedidos_comida_rapida.Models
{
    public class VentaPorDiaDto
    {
        public DateTime Fecha { get; set; }
        public int CantidadPedidos { get; set; }
        public decimal TotalVendido { get; set; }
    }
}
