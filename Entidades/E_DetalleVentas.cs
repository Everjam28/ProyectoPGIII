using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_DetalleVentas
    {
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public decimal gravadas { get; set; }
        public decimal totales { get; set; }
        public int idventas { get; set; }

        //public virtual Ventas Ventas { get; set; }
    }
}
