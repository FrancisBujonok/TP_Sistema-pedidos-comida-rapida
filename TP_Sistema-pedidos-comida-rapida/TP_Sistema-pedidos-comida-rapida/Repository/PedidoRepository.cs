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
            using var context = new AplicationDbContext();

            context.Pedidos.Add(pedido);
            context.SaveChanges();
        }
        public static List<Pedido> ObtenerPedidos()
        {
            using var context = new AplicationDbContext();
            return context.Pedidos.ToList();
        }
        public static Pedido BuscarPorId(int id)
        {
            using var context = new AplicationDbContext();
            return context.Pedidos.FirstOrDefault(p => p.Id == id);
        }
        public static void CambiarEstado(int id, string nuevoEstado)
        {
            using var context = new AplicationDbContext();
            var pedido = context.Pedidos.FirstOrDefault(p => p.Id == id);
            if (pedido != null)
            {
                pedido.Estado = nuevoEstado;
                context.SaveChanges();
            }
        }

        public static void EliminarPedido(int id)
        {
            using var context = new AplicationDbContext();
            var pedido = context.Pedidos.FirstOrDefault(p => p.Id == id);
            if (pedido != null)
            {
                context.Pedidos.Remove(pedido);
                context.SaveChanges();
            }
        }
    }
}
