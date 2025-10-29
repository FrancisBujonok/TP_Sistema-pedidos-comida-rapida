using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Sistema_pedidos_comida_rapida.Data;
using TP_Sistema_pedidos_comida_rapida.Models;

namespace TP_Sistema_pedidos_comida_rapida.Repository
{
    public static class DetallePedidoRepository
    {
        public static void GuardarTodosDetalles(Pedido pedido)
        {
            using var context = new AplicationDbContext();
            foreach (var item in pedido.Detalles)
            {
                context.Detalle.Add(item);
            }
            context.SaveChanges();
        }
        
    }
}
