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
        // Método para guardar un nuevo producto
        public static void GuardarProducto(Producto producto)
        {
            using var context = new AplicationDbContext();
            context.Productos.Add(producto);
            context.SaveChanges();
        }

        // Método para obtener todos los productos
        public static List<Producto> ObtenerProductos()
        {
            using var context = new AplicationDbContext();
            return context.Productos.ToList();
        }

        // Método para buscar un producto por su ID
        public static Producto ObtenerPorId(int id)
        {
            using var context = new AplicationDbContext();
            return context.Productos.FirstOrDefault(p => p.ID == id);
        }

        // Método para modificar un producto existente
        public static void ModificarProducto(Producto producto)
        {
            using var context = new AplicationDbContext();
            context.Productos.Update(producto);
            context.SaveChanges();
        }
        public static void EliminarProducto(int id)
        {
            using var context = new AplicationDbContext();
            var producto = context.Productos.FirstOrDefault(p => p.ID == id);
            if (producto != null)
            {
                context.Productos.Remove(producto);
                context.SaveChanges();
            }
        }
    }
}