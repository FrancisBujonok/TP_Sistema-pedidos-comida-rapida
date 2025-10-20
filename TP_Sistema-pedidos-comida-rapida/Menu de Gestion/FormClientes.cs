using Microsoft.IdentityModel.Tokens;
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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //no hace nada
        }

        private void GuardarCliente_Click(object sender, EventArgs e)
        {
            //El usuario crear un cliente
            bool datosVacio = false;
            string nombreCliente = NombreCliente.Text;
            if (string.IsNullOrEmpty(nombreCliente))
            {
                datosVacio = true;
            }

            string apellidoCliente = ApellidoCliente.Text;
            if (string.IsNullOrEmpty(apellidoCliente))
            {
                datosVacio = true;
            }
            string dniCliente = DniCliente.Text;
            if (string.IsNullOrEmpty(dniCliente))
            {
                datosVacio = true;
            }

            string direccion = DireccionCliente.Text;
            if (string.IsNullOrEmpty(direccion))
            {
                datosVacio = true;
            }
            string telefonoCliente = TelefonoCliente.Text;
            if (string.IsNullOrEmpty(telefonoCliente))
            {
                datosVacio = true;
            }

            if (datosVacio == true)
            {
                MessageBox.Show("Algunos de los campos estan vacios.");
            }
            else
            {
                var usuarioExistente = ClienteRepository.ConsultarCliente(dniCliente);
                if (usuarioExistente != null)
                {
                    MessageBox.Show("Ya existe un cliente con ese DNI.");
                    return;
                }
                else
                {
                    Cliente nuevoCliente = new Cliente()
                    {
                        Nombre = nombreCliente,
                        Apellido = apellidoCliente,
                        Dni = dniCliente,
                        Direccion = direccion,
                        Telefono = telefonoCliente
                    };

                    ClienteRepository.GuardarUsuario(nuevoCliente);
                    MessageBox.Show("Cliente Guardado");
                }

            }
            //limpiar los campos
            NombreCliente.Clear();
            ApellidoCliente.Clear();
            DniCliente.Clear();
            DireccionCliente.Clear();
            TelefonoCliente.Clear();

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            //Dni no hace nada.
        }

        private void Modificar_Cliente_Click(object sender, EventArgs e)
        {
            //apartado boton modificar cliente
            FormModificarClientes form = new FormModificarClientes();
            form.ShowDialog();
            this.Hide();

        }

        private void Eliminar_Cliente_Click(object sender, EventArgs e)
        {
            //apartado boton eliminar cliente
            FormEliminarClientes form = new FormEliminarClientes();
            form.ShowDialog();
            this.Hide();


        }

        private void DniCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 formPrincipal = new Form1();
            formPrincipal.Show();
            this.Hide();

        }
    }
}
