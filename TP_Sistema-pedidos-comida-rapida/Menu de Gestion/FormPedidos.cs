using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Sistema_pedidos_comida_rapida.Models;
using TP_Sistema_pedidos_comida_rapida.Repository;

namespace Menu_de_Gestion
{
    public partial class FormPedidos : Form
    {
        public FormPedidos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //apartado para eliminar pedido
            string dniTexto = DniPedido.Text.Trim();

            if (string.IsNullOrEmpty(dniTexto))
            {
                MessageBox.Show("Ingrese el DNI del pedido a eliminar.");
                return;
            }

            // Verificar que el DNI sea un número entero
            if (!int.TryParse(dniTexto, out int dni))
            {
                MessageBox.Show("El DNI debe ser un número entero (sin letras ni símbolos).");
                return;
            }

            var pedido = PedidoRepository.ObtenerPedidos()
                .FirstOrDefault(p => p.DniCliente == dniTexto);

            if (pedido == null)
            {
                MessageBox.Show("No se encontró un pedido con ese DNI.");
                return;
            }

            var confirmacion = MessageBox.Show("¿Seguro que desea eliminar el pedido?",
                                               "Confirmación",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                PedidoRepository.EliminarPedido(pedido.Id);
                MessageBox.Show("Pedido eliminado correctamente.");

                // Limpiar campos
                DniPedido.Clear();
                DescripcionPedido.Clear();
                FechaPedido.Clear();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //apartado para agregar pedido
            string dniTexto = DniPedido.Text;
            if (string.IsNullOrEmpty(dniTexto))
            {
                MessageBox.Show("El campo DNI está vacío.");
                return;
            }
            if (!int.TryParse(dniTexto, out int dni))
            {
                MessageBox.Show("El DNI debe ser un número entero (sin letras ni símbolos).");
                return;
            }
            Pedido nuevoPedido = new Pedido()
            {
                DniCliente = dniTexto,
                Descripcion = DescripcionPedido.Text,
                Fecha = DateTime.Now,
                Estado = "Pendiente"
            };

            PedidoRepository.GuardarPedido(nuevoPedido);

            MessageBox.Show("Pedido guardado correctamente.");

            // Limpiar campos
            DniPedido.Clear();
            DescripcionPedido.Clear();
            FechaPedido.Clear();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // nada 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //apartado actualizar estado

            string dniTexto = DniPedido.Text.Trim();
            string nuevoEstado = comboEstado.Text;

            if (string.IsNullOrEmpty(dniTexto))
            {
                MessageBox.Show("Ingrese el DNI del pedido a actualizar.");
                return;
            }
            if (!int.TryParse(dniTexto, out int dni))
            {
                MessageBox.Show("El DNI debe ser un número entero (sin letras ni símbolos).");
                return;
            }
            if (string.IsNullOrEmpty(nuevoEstado))
            {
                MessageBox.Show("Seleccione un estado nuevo.");
                return;
            }

            var pedido = PedidoRepository.ObtenerPedidos()
                .FirstOrDefault(p => p.DniCliente == dniTexto);

            if (pedido == null)
            {
                MessageBox.Show("No se encontró un pedido con ese DNI.");
                return;
            }

            PedidoRepository.CambiarEstado(pedido.Id, nuevoEstado);
            MessageBox.Show("Estado del pedido actualizado correctamente.");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dniTexto = DniPedido.Text.Trim();

            if (string.IsNullOrEmpty(dniTexto))
            {
                MessageBox.Show("Ingrese un DNI para buscar.");
                return;
            }
            if (!int.TryParse(dniTexto, out int dni))
            {
                MessageBox.Show("El DNI debe ser un número entero (sin letras ni símbolos).");
                return;
            }
            var pedido = PedidoRepository.ObtenerPedidos()
                .FirstOrDefault(p => p.DniCliente == dniTexto);

            if (pedido == null)
            {
                MessageBox.Show("No se encontró un pedido con ese DNI.");
                return;
            }

            // Mostrar la info en los TextBox
            DescripcionPedido.Text = pedido.Descripcion;
            FechaPedido.Text = pedido.Fecha.ToString("dd/MM/yyyy");
            comboEstado.Text = pedido.Estado;

            MessageBox.Show("Pedido encontrado.");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //no es nada
        }
    }
}
