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
        public static class ReportRepository
        {
            // REPORTE 1: Ventas por día
            public static List<VentaPorDiaDto> ObtenerVentasPorDia()
            {
                using var ctx = new AplicationDbContext();

                // Agrupamos los pedidos por fecha
                var resultado = ctx.Pedidos
                    .GroupBy(p => p.Fecha.Date)
                    .Select(g => new VentaPorDiaDto
                    {
                        Fecha = g.Key,
                        CantidadPedidos = g.Count(),
                        TotalVendido = ctx.Detalle
                            .Where(d => g.Select(p => p.Id)
                                         .Contains(d.Id_Producto))
                            .Sum(d => d.SubTotal)
                    })
                    .OrderBy(r => r.Fecha)
                    .ToList();

                return resultado;
            }
            // REPORTE 2: Top 5 productos más vendidos
            public static List<TopProductoDto> ObtenerTopProductos()
            {
                using var ctx = new AplicationDbContext();

                var resultado = ctx.Detalle
                    .Include(d => d.Producto) // incluye datos del producto
                    .GroupBy(d => new { d.Id_Producto, d.Producto.Nombre })
                    .Select(g => new TopProductoDto
                    {
                        ID_Producto = g.Key.Id_Producto,
                        Nombre = g.Key.Nombre,
                        CantidadVendida = g.Sum(d => d.Cantidad),
                        MontoTotal = g.Sum(d => d.SubTotal)
                    })
                    .OrderByDescending(r => r.CantidadVendida)
                    .Take(5)
                    .ToList();

                return resultado;
            }
        }
    }