using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Sistema_pedidos_comida_rapida.Data;
using TP_Sistema_pedidos_comida_rapida.Models;
using TP_Sistema_pedidos_comida_rapida.Repository;

namespace Menu_de_Gestion
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            CargarProductosEnGrilla();
        }
        private void CargarProductosEnGrilla()
        {
            var lista = ProductoRepository.ObtenerProductos();
            dataGridView1.DataSource = lista;
        }

        private void LimpiarCampos()
        {
            textNombre.Clear();
            textPrecio.Clear();
            textCategoria.Clear();
            textStock.Clear();
            //_productoSeleccionadoId = null;
            //dataGridViewProductos.ClearSelection();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre.");
                textNombre.Focus();
                return false;
            }

            if (!decimal.TryParse(textPrecio.Text.Trim(), out decimal precio) || precio < 0)
            {
                MessageBox.Show("Ingrese un precio válido.");
                textPrecio.Focus();
                return false;
            }

            if (!int.TryParse(textStock.Text.Trim(), out int stock) || stock < 0)
            {
                MessageBox.Show("Ingrese un stock válido.");
                textStock.Focus();
                return false;
            }

            return true;
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {
            //agregar nombre label

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            bool datosVacio = false;
            string nombreProducto = textNombre.Text;
            if (string.IsNullOrEmpty(nombreProducto))
            {
                datosVacio = true;
            }

            decimal Precio = 0;

            string precioTexto = textPrecio.Text;
            if (string.IsNullOrEmpty(precioTexto))
            {
                datosVacio = true;

            }
            else
            {
                if (decimal.TryParse(precioTexto, out Precio))
                {
                    if (Precio < 0)
                    {
                        datosVacio = true;
                        MessageBox.Show("El precio no puede ser negativo.");
                    }
                }
            }

            string Categoria = textCategoria.Text;
            if (string.IsNullOrEmpty(Categoria))
            {
                datosVacio = true;
            }
            string stockTexto = textStock.Text;
            int Stock;
            if (string.IsNullOrEmpty(stockTexto))
            {
                datosVacio = true;
            }

            if (datosVacio == true)
            {
                MessageBox.Show("Algunos de los campos estan vacios.");
            }
            else
            {
                if (!int.TryParse(stockTexto, out Stock) || Stock < 0)
                {
                    MessageBox.Show("Ingrese un stock válido.");
                    return;
                }
                else
                {
                    Producto nuevoProducto = new Producto()
                    {
                        Nombre = nombreProducto,
                        Precio = Precio,
                        Categoria = Categoria,
                        Stock = Stock,

                    };
                    ProductoRepository.GuardarProducto(nuevoProducto);
                    MessageBox.Show("Producto Guardado");
                }
                LimpiarCampos();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Producto productoSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Producto;
                if (productoSeleccionado != null)
                {
                    textNombre.Text = productoSeleccionado.Nombre;
                    textPrecio.Text = productoSeleccionado.Precio.ToString();
                    textCategoria.Text = productoSeleccionado.Categoria;
                    textStock.Text = productoSeleccionado.Stock.ToString();
                }
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto para modificar.");
                return;
            }

            Producto productoSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Producto;
            if (productoSeleccionado == null)
            {
                MessageBox.Show("No se pudo obtener el producto seleccionado.");
                return;
            }
            // Validar campos igual que en Agregar
            if (string.IsNullOrWhiteSpace(textNombre.Text) ||
                string.IsNullOrWhiteSpace(textPrecio.Text) ||
                string.IsNullOrWhiteSpace(textCategoria.Text) ||
                string.IsNullOrWhiteSpace(textStock.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (!decimal.TryParse(textPrecio.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("Ingrese un precio válido.");
                return;
            }

            if (!int.TryParse(textStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Ingrese un stock válido.");
                return;
            }

            // se actualizan datos del producto
            productoSeleccionado.Nombre = textNombre.Text.Trim();
            productoSeleccionado.Precio = precio;
            productoSeleccionado.Categoria = textCategoria.Text.Trim();
            productoSeleccionado.Stock = stock;

            try
            {
                ProductoRepository.ModificarProducto(productoSeleccionado);
                MessageBox.Show("Producto modificado correctamente.");
                CargarProductosEnGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto: " + ex.Message);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
                return;
            }

            Producto productoSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Producto;
            if (productoSeleccionado == null)
            {
                MessageBox.Show("No se pudo obtener el producto seleccionado.");
                return;
            }

            using var context = new AplicationDbContext();
            var producto = context.Productos.FirstOrDefault(p => p.ID_Producto == productoSeleccionado.ID_Producto);
            if (producto != null)
            {
                context.Productos.Remove(producto);
                context.SaveChanges();
            }

            var confirmacion = MessageBox.Show(
                "¿Está seguro que desea eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    ProductoRepository.EliminarProducto(productoSeleccionado.ID_Producto);
                    MessageBox.Show("Producto eliminado correctamente.");
                    CargarProductosEnGrilla();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }
        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            Form1 formMenu = new Form1();
            formMenu.Show();
            this.Close();
        }
    }
}
