using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Sistema_pedidos_comida_rapida.Repository;

namespace Menu_de_Gestion
{
    public partial class FormEliminarClientes : Form
    {
        public FormEliminarClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dniEliminar = DniEliminar.Text;
            if (string.IsNullOrEmpty(dniEliminar))
            {
                MessageBox.Show("El campo DNI está vacío.");
            }
            else
            {
                var cliente = ClienteRepository.ConsultarCliente(dniEliminar);
                if (cliente == null)
                {
                    MessageBox.Show("El cliente no está registrado.");
                }
                else
                {
                    //Mostrar mensaje de confirmacion
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el cliente?", "Confirmar eliminación", buttons);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        //Eliminar cliente
                        ClienteRepository.ElminarCliente(dniEliminar);
                        MessageBox.Show("Cliente eliminado correctamente.");
                    }

                }
            }
            //Limpiar campo
            DniEliminar.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.Show();
            this.Hide();

        }
    }
}
