using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Sistema_pedidos_comida_rapida.Models
{
    public class Producto
    {
        public int ID{  get; set; }
        public string Nombre {  get; set; }
        public double Precio {  get; set; }
        public string Categoria {  get; set; }
    }
}
