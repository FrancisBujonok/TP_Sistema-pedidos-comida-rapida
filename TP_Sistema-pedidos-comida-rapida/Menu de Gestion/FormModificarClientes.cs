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
    public partial class FormModificarClientes : Form
    {
        public FormModificarClientes()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //no hace nada

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //no hace nada
        }

        private void NombreModificar_TextChanged(object sender, EventArgs e)
        {
            //no hace nada
        }

        private void DniModificar_TextChanged(object sender, EventArgs e)
        {
            //no hace nada
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DniMod = DniModificar.Text;
            if (string.IsNullOrEmpty(DniMod))
            {
                MessageBox.Show("Los campos estan Vacios.");
            }
            else
            {
                var cliente = ClienteRepository.ConsultarCliente(DniMod);
                if (cliente == null)
                {
                    MessageBox.Show("El cliente no esta registrado");
                }
                else
                {
                    NombreModificar.Text = cliente.Nombre;
                    ApellidoModificar.Text = cliente.Apellido;
                    DireccionModificar.Text = cliente.Direccion;
                    TelefonoModificar.Text = cliente.Telefono;
                }
            }
            //Limpiar los campos
            DataBindings.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dniCliente = DniModificar.Text;
            string nombreCliente = NombreModificar.Text;
            string apellidoCliente = ApellidoModificar.Text;
            string direccion = DireccionModificar.Text;
            string telefonoCliente = TelefonoModificar.Text;


            if (string.IsNullOrEmpty(nombreCliente) || string.IsNullOrEmpty(apellidoCliente) ||
                string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(telefonoCliente))
            {
                MessageBox.Show("Los campos estan Vacios.");
            }
            else
            {
                Cliente clienteModificado = new Cliente()
                {
                    Dni = dniCliente,
                    Nombre = nombreCliente,
                    Apellido = apellidoCliente,
                    Direccion = direccion,
                    Telefono = telefonoCliente
                };
                ClienteRepository.ModificarCliente(clienteModificado);
                MessageBox.Show("Cliente modificado con exito.");
            }

            //Limpiar los campos
            DniModificar.Text = "";
            NombreModificar.Text = "";
            ApellidoModificar.Text = "";
            DireccionModificar.Text = "";
            TelefonoModificar.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.Show();
            this.Hide();

        }
    }
}
