using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TP_Sistema_pedidos_comida_rapida.Models;

namespace TP_Sistema_pedidos_comida_rapida.Data
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Producto> ID_Producto { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Producto> Stock { get; set; }
        public DbSet<DetallePedido> Detalle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.;Database=Sistema-Pedido-Comida;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {  
            modelBuilder.Entity<DetallePedido>()
                .HasKey(d => new { d.Id_Cliente, d.Id_Producto });

            // Forzar el nombre de tabla que existe en la BD
            modelBuilder.Entity<Producto>().ToTable("Productos");
        }
    }
}
