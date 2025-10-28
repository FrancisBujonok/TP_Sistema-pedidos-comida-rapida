using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Sistema_pedidos_comida_rapida.Data;
using TP_Sistema_pedidos_comida_rapida.Models;

namespace TP_Sistema_pedidos_comida_rapida.Repository
{
    public static class ReporteRepository
    {
        // Reporte 1: Ventas por día
        public static List<VentaPorDiaDto> ObtenerVentasPorDia()
        {
            using var ctx = new AplicationDbContext();

            var resultado = ctx.Pedidos
                .GroupBy(p => p.Fecha.Date)
                .Select(g => new VentaPorDiaDto
                {
                    Fecha = g.Key,
                    CantidadPedidos = g.Count(),
                    TotalVendido = g.Sum(p =>
                        ctx.DetallePedido
                           .Where(d => d.ID_Pedido == p.ID_Pedido)
                           .Sum(d => d.Subtotal))
                })
                .OrderBy(r => r.Fecha)
                .ToList();

            return resultado;
        }
        // Reporte 2: Top 5 productos más vendidos
        public static List<TopProductoDto> ObtenerTopProductos()
        {
            using var ctx = new AplicationDbContext();

            var resultado = ctx.DetallePedido
                .Include(d => d.Producto)
                .GroupBy(d => new { d.ID_Producto, d.Producto.Nombre })
                .Select(g => new TopProductoDto
                {
                    ID_Producto = g.Key.ID_Producto,
                    Nombre = g.Key.Nombre,
                    CantidadVendida = g.Sum(d => d.Cantidad),
                    MontoTotal = g.Sum(d => d.Subtotal)
                })
                .OrderByDescending(r => r.CantidadVendida)
                .Take(5)
                .ToList();
            return resultado;
        }
    }
}
