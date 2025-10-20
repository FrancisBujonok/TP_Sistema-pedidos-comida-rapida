using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Sistema_pedidos_comida_rapida.Data;
using TP_Sistema_pedidos_comida_rapida.Models;

namespace TP_Sistema_pedidos_comida_rapida.Repository
{
    public static class PedidoRepository
    {
        public static void GuardarPedido(Pedido pedido)
        {
            using var contwext = new AplicationDbContext();

            contwext.Pedidos.Add(pedido);
        }
    }
}
