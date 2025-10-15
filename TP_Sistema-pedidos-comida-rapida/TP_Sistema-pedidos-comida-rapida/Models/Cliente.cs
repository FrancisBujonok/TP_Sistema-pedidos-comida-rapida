using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Sistema_pedidos_comida_rapida.Models
{
    public class Cliente
    {
        public int ID {  get; set; }
        public string Nombre {  get; set; }
        public string Apellido {  get; set; }
        public string Dni {  get; set; }
        public string Direccion {  get; set; }
        public string Telefono {  get; set; }
    }
}
