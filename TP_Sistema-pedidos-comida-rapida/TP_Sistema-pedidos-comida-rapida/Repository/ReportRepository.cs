using Microsoft.EntityFrameworkCore;
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
        public static List<VentaPorDiaDto> ObtenerPedidosHoy()
        {
            using var ctx = new AplicationDbContext();

            var hoyInicio = DateTime.Today;         // 00:00:00 de hoy
            var hoyFin = hoyInicio.AddDays(1);      // 00:00:00 del día siguiente

            var pedidosHoy = ctx.Pedidos
                .Where(p => p.Fecha >= hoyInicio && p.Fecha < hoyFin)
                .Select(p => new VentaPorDiaDto
                {
                    Fecha = p.Fecha,
                    TotalVendido = p.Total
                })
                .ToList();

            return pedidosHoy;
        }
        public static List<TopProductoDto> ObtenerTopProductos()
        {
            using var ctx = new AplicationDbContext();

            var resultado = ctx.Detalle
                .Join(
                    ctx.Productos,
                    detalle => detalle.Id_Producto,
                    producto => producto.ID_Producto,
                    (detalle, producto) => new
                    {
                        detalle.Id_Producto,
                        producto.Nombre,
                        detalle.Cantidad,
                        detalle.PrecioUnitario
                    }
                )
                .GroupBy(x => new { x.Id_Producto, x.Nombre })
                .Select(g => new TopProductoDto
                {
                    ID_Producto = g.Key.Id_Producto,
                    Nombre = g.Key.Nombre,
                    CantidadVendida = g.Sum(x => x.Cantidad),
                    MontoTotal = g.Sum(x => x.Cantidad * x.PrecioUnitario)
                })
                .OrderByDescending(r => r.CantidadVendida)
                .Take(5)
                .ToList();

            return resultado;
        }
    }
}