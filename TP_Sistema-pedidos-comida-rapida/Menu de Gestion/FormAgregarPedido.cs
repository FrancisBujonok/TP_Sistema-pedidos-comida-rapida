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
    public partial class FormAgregarPedido : Form
    {
        private Pedido _pedido;
        public FormAgregarPedido(Pedido pedido)
        {
            InitializeComponent();
            _pedido = pedido;
        }
        private void CargarComboProductos()
        {
            var productos = ProductoRepository.ObtenerProductos();
            ProductoDetalle.DataSource = productos;
            ProductoDetalle.DisplayMember = "Nombre";
            ProductoDetalle.ValueMember = "ID_Producto";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAgregarPedido_Load(object sender, EventArgs e)
        {
            CargarComboProductos();
            CargarGrillaPedido();
        }

        private void CargarGrillaPedido()
        {
            dgvDetallePedido.DataSource = null;
            dgvDetallePedido.DataSource = _pedido.Detalles;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = (Producto)ProductoDetalle.SelectedItem;

            int cantidad;
            if (!int.TryParse(CantidadDetalle.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            // Verificamos que el producto tenga stock suficiente
            if (cantidad > producto.Stock)
            {
                MessageBox.Show($"La cantidad ingresada supera al stock disponible ({producto.Stock}).");
                return;
            }

            // Si el producto ya está en el pedido, actualizamos su cantidad
            var detalleExistente = _pedido.Detalles.FirstOrDefault(d => d.Id_Producto == producto.ID_Producto);
            if (detalleExistente != null)
            {
                // Verificar que la nueva cantidad total no exceda el stock
                if (detalleExistente.Cantidad + cantidad > producto.Stock)
                {
                    MessageBox.Show($"No se puede agregar más de {producto.Stock} unidades en total.");
                    return;
                }

                detalleExistente.Cantidad += cantidad;
            }
            else
            {
                // Crear nuevo detalle
                DetallePedido detalle = new DetallePedido
                {
                    Id_Producto = producto.ID_Producto,
                    Id_Cliente = _pedido.ClienteId,
                    PrecioUnitario = producto.Precio,
                    Cantidad = cantidad
                };

                _pedido.Detalles.Add(detalle);
            }

            // Restar del stock (opcional, si querés reflejarlo en el combo)
            producto.Stock -= cantidad;

            // Actualizar el total del pedido
            _pedido.Total = _pedido.Detalles.Sum(d => d.SubTotal);
            TotalDetalle.Text = _pedido.Total.ToString("C");

            // Recargar la grilla
            CargarGrillaPedido();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Cancelar pedido volver al menu
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //no editable
            TotalDetalle.ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Guardamos el pedido en la base de datos
            if (_pedido.Detalles.Count == 0)
            {
                MessageBox.Show("El pedido no tiene detalles.");
                return;
            }
            else
            {
                //Guardamos el pedido en la base de datos.
                _pedido.Estado = "Completado";
                _pedido.Fecha = DateTime.Now;
                PedidoRepository.GuardarPedido(_pedido);
                MessageBox.Show("Pedido guardado con exito.");
                //cerramos el menu
                this.Close();
            }
        }
    }
}
