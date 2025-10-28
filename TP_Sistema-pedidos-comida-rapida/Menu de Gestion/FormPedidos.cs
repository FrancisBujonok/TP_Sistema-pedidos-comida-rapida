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



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //apartado para agregar pedido


        }

        private void label1_Click(object sender, EventArgs e)
        {
            // nada 
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //no es nada
        }

        private void buttonVolverAtras_Click(object sender, EventArgs e)
        {
            Form1 formMenu = new Form1();
            formMenu.Show();
            this.Close();
        }

        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Buscar cliente en la base de datos

            string dniTexto = DniPedido.Text.Trim();
            if (string.IsNullOrEmpty(dniTexto))
            {
                MessageBox.Show("Ingrese un DNI para buscar.");
                return;
            }
            else
            {
                var cliente = ClienteRepository.ConsultarCliente(dniTexto);
                if (cliente == null)
                {
                    MessageBox.Show("No se encontró un cliente con ese DNI.");
                    return;
                }
                else
                {
                    MessageBox.Show($"Cliente encontrado.");
                    NombreDetalleP.Text = cliente.Nombre;
                    ApellidoDetalleP.Text = cliente.Apellido;
                    AgregarPedido.Enabled = true;
                    return;
                }

            }
        }

        private void NombreDetalleP_TextChanged(object sender, EventArgs e)
        {
            NombreDetalleP.ReadOnly = true;
        }

        private void ApellidoDetalleP_TextChanged(object sender, EventArgs e)
        {
            ApellidoDetalleP.ReadOnly = true;
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            //no hace nada
        }

        private void AgregarPedido_Click(object sender, EventArgs e)
        {
            var cliente = ClienteRepository.ConsultarCliente(DniPedido.Text.Trim());
            if (cliente == null)
            {
                MessageBox.Show("No se encontró un cliente con ese DNI.");
                return;
            }
            else
            {
                Pedido NuevoPedido = new Pedido()
                {
                    ClienteId = cliente.ID,
                    Fecha = DateTime.Now,
                    Estado = "Pendiente",
                    Detalles = new List<DetallePedido>()
                };
                FormAgregarPedido formAgregarPedido = new FormAgregarPedido(NuevoPedido);
                formAgregarPedido.ShowDialog();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Volver al menu
            Form1 formMenu = new Form1();
            formMenu.Show();
            this.Close();
        }
    }
}
