using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Sistema_pedidos_comida_rapida.Data;
using TP_Sistema_pedidos_comida_rapida.Models;

namespace TP_Sistema_pedidos_comida_rapida.Repository
{
    public static class ProductoRepository
    {
        public static void GuardarProducto(Producto producto)
        {
            using var context = new AplicationDbContext();
            context.Productos.Add(producto);
            context.SaveChanges();
        }

        public static List<Producto> ObtenerProductos()
        {
            using var context = new AplicationDbContext();
            return context.Productos.ToList();
        }

        public static Producto ObtenerPorNombre(string nombre)
        {
            using var context = new AplicationDbContext();
            return context.Productos.FirstOrDefault(p => p.Nombre == nombre);
        }
        public static void ModificarProducto(Producto producto)
        {
            using var context = new AplicationDbContext();
            context.Productos.Update(producto);
            context.SaveChanges();
        }
        public static void EliminarProducto(int id)
        {
            using var context = new AplicationDbContext();
            var producto = context.Productos.FirstOrDefault(p => p.ID_Producto == id);
            if (producto != null)
            {
                context.Productos.Remove(producto);
                context.SaveChanges();
            }
        }
        public static void ActualizarStock(Pedido pedido)
        {
            using var context = new AplicationDbContext();

            foreach (var detalle in pedido.Detalles)
            {
                var producto = context.Productos.FirstOrDefault(p => p.ID_Producto == detalle.Id_Producto);
                if (producto != null)
                {
                    producto.Stock -= detalle.Cantidad;
                    context.Productos.Update(producto);
                }
            }
            context.SaveChanges();
        }
    }
}