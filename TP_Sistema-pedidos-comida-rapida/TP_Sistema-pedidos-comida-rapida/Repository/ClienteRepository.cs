using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Sistema_pedidos_comida_rapida.Data;
using TP_Sistema_pedidos_comida_rapida.Models;

namespace TP_Sistema_pedidos_comida_rapida.Repository
{
    public static class ClienteRepository
    {
        public static void GuardarUsuario(Cliente cliente)
        {
            using var context = new AplicationDbContext();
            //un comentario
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }

        public static Cliente ConsultarCliente(string dni)
        {
            using var context = new AplicationDbContext();
            var cliente = context.Clientes.FirstOrDefault(C => C.Dni == dni);
            return cliente;
        }
    }
}
