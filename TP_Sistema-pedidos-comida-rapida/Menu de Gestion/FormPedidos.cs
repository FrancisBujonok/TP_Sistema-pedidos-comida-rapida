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
            string dni = DniPedido.Text;
            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("El campo DNI esta vacio.");
            }
            else
            {
                Pedido nuevoPedido = new Pedido()
                {
                    DniCliente = dni,
                    Descripcion = DescripcionPedido.Text,
                    Fecha = DateTime.Now,
                    Estado = "Pendiente"
                };
                PedidoRepository.GuardarPedido(nuevoPedido);
                MessageBox.Show("Pedido Guardado");


            }
        }
    }
}
