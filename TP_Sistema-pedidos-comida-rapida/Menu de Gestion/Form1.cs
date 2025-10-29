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
            FormClientes form = new FormClientes(); //esto crea el form
            form.ShowDialog(); //esto lo muestra
            this.Hide(); //esto cierra el actual mientras se abre el otro
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormProductos form = new FormProductos();
            form.ShowDialog();
            this.Hide();
            //cuando el otro se cierra o minimiza, se debería volver a abrir este

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPedidos form = new FormPedidos();
            form.ShowDialog();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CargarReportes()
        {
            // Reporte 1: Ventas por día
            var ventasPorDia = TP_Sistema_pedidos_comida_rapida.Repository.ReporteRepository.ReportRepository.ObtenerVentasPorDia();
            dataGridVentasDia.DataSource = ventasPorDia;

            // Opcional: formato visual
            dataGridVentasDia.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridVentasDia.Columns["TotalVendido"].DefaultCellStyle.Format = "C2";

            // Reporte 2: Top 5 productos más vendidos
            var topProductos = TP_Sistema_pedidos_comida_rapida.Repository.ReporteRepository.ReportRepository.ObtenerTopProductos();
            dataGridTopProductos.DataSource = topProductos;

            dataGridTopProductos.Columns["MontoTotal"].DefaultCellStyle.Format = "C2";
        }

    }
}
