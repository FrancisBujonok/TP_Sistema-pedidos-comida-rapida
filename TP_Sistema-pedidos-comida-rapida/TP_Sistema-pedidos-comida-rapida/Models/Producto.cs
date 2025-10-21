using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Sistema_pedidos_comida_rapida.Models
{
    public class Producto
    {
        [Key]
        public int ID_Producto { get; set; }
        public string Nombre {  get; set; } = string.Empty;
        public decimal Precio {  get; set; }
        public string Categoria { get; set; } = string.Empty;
        public int Stock { get; set; }
    }
}
