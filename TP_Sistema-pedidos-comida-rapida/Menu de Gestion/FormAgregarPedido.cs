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
        private List<Producto> _listaProductos = new List<Producto>();
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
            TotalDetalle.ReadOnly = true;
            CargarComboProductos();
            CargarGrillaPedido();
            _listaProductos = ProductoRepository.ObtenerProductos();
        }

        private void CargarGrillaPedido()
        {
            var datos = _pedido.Detalles.Select(d => new
            {
                Id_Pedido = d.Id_Pedido,
                Id_Producto = d.Id_Producto,
                Cantidad = d.Cantidad,
                PrecioUnitario = d.PrecioUnitario,
                SubTotal = d.SubTotal

            }).ToList();

            dgvDetallePedido.DataSource = datos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto productoSeleccionado = (Producto)ProductoDetalle.SelectedItem;

            int cantidad = (int)CantidadDetalle.Value;

            var producto = _listaProductos.FirstOrDefault(p => p.ID_Producto == productoSeleccionado.ID_Producto);
            if(producto != null)
            {
                if (cantidad > producto.Stock)
                {
                    MessageBox.Show($"No hay suficiente stock del producto seleccionado.stock: {producto.Stock}");
                    return;
                }
                else
                {
                    //verifico si el producto ya esta en la grilla.
                    var detalleExistente = _pedido.Detalles.FirstOrDefault(d => d.Id_Producto == productoSeleccionado.ID_Producto);
                    if (detalleExistente == null)
                    {
                        //Agrego nuevo detalle
                        DetallePedido nuevodetalle = new DetallePedido
                        {
                            Id_Pedido = _pedido.Id,
                            Id_Producto = productoSeleccionado.ID_Producto,
                            Cantidad = cantidad,
                            PrecioUnitario = productoSeleccionado.Precio,
                        };
                        _listaProductos.FirstOrDefault(p => p.ID_Producto == productoSeleccionado.ID_Producto).Stock -= cantidad;
                        _pedido.Detalles.Add(nuevodetalle);
                        _pedido.Total += nuevodetalle.SubTotal;
                        TotalDetalle.Text = _pedido.Total.ToString("C");

                        CargarGrillaPedido();
                    }
                    else
                    {
                        //Actualizar la grilla.
                        detalleExistente.Cantidad += cantidad;
                        _listaProductos.FirstOrDefault(p => p.ID_Producto == productoSeleccionado.ID_Producto).Stock -= cantidad;
                        _pedido.Total += detalleExistente.PrecioUnitario * cantidad;
                        TotalDetalle.Text = _pedido.Total.ToString("C");
                        CargarGrillaPedido();
                    }
                }
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Cancelar pedido volver al menu
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //no editable
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
                DetallePedidoRepository.GuardarTodosDetalles(_pedido);
                ProductoRepository.ActualizarStock(_pedido);
                MessageBox.Show("Pedido guardado con exito.");
                //cerramos el menu
                this.Close();
            }
        }
    }
}
