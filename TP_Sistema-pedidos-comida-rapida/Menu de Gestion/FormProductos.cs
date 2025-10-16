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
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

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

            decimal Precio;

            string precioTexto = textPrecio.Text;
            if(string.IsNullOrEmpty(precioTexto))
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
            
            
            
            string Categoria = categoria.Text;
            if (string.IsNullOrEmpty(Categoria))
            {
                datosVacio = true;
            }

            int Stock = stock.Text;
            if (int.IsNullOrEmpty(Stock))
            {
                datosVacio = true;
            }

            if (datosVacio == true)
            {
                MessageBox.Show("Algunos de los campos estan vacios.");
            }
            else
            {

                Producto nuevoProducto = new Producto()
                {
                    Nombre = nombreProducto,
                    Precio = Precio,
                    Categoria = Categoria,
                    Stock = Stock
                };

                ClienteRepository.GuardarUsuario(nuevoProducto);
                MessageBox.Show("Producto Guardado");
            }
        }
    }
}
