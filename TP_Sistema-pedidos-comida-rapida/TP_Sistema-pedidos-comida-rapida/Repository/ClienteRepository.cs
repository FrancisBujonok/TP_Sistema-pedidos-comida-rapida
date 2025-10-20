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
        public static void ModificarCliente(Cliente cliente)
        {
            //remplazar el cliente existente con el nuevo cliente, buscar por dni
            using var context = new AplicationDbContext();
            var clienteExistente = context.Clientes.FirstOrDefault(C => C.Dni == cliente.Dni);
            if (clienteExistente == null)
            {
                throw new Exception("El cliente no existe.");
            }
            else
            {
                clienteExistente.Nombre = cliente.Nombre;
                clienteExistente.Apellido = cliente.Apellido;
                clienteExistente.Direccion = cliente.Direccion;
                clienteExistente.Telefono = cliente.Telefono;
                context.SaveChanges();
            }
        }
        public static void ElminarCliente(string dni)
        {
            using var context = new AplicationDbContext();
            var clienteExistente = context.Clientes.FirstOrDefault(C => C.Dni == dni);
            if (clienteExistente == null)
            {
                throw new Exception("El cliente no existe.");
            }
            else
            {
                context.Clientes.Remove(clienteExistente);
                context.SaveChanges();
            }
        }
    }
}
