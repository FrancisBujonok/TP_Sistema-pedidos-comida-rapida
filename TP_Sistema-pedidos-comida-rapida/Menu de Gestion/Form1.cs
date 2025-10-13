using TP_Sistema_pedidos_comida_rapida.Models;
using TP_Sistema_pedidos_comida_rapida.Repository;

namespace Menu_de_Gestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Prueba Creacion Usuario.
            Cliente nuevoCliente = new Cliente()
            {
                Nombre = "Juan",
                Apellido = "Perez",
                Direccion = "AV pepe Argento",
                Telefono = "3493 789234"

            };
            ClienteRepository.GuardarUsuario(nuevoCliente);
        }
    }
}
