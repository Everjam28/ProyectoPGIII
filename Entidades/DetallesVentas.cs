using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetallesVentas
    {
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Gravadas { get; set; }
        public decimal Totales { get; set; }
        public int Idventas { get; set; }
    }
}
