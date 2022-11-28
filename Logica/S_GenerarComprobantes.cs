using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using Datos;

namespace Logica
{
    public class S_GenerarComprobantes
    {
        public List<s_Generar_Comprobantes_Result> generarComprobante { get; private set; }

        public void GenerarComprobantes(int idventas)
        {
            var comprobantes = new D_GenerarComprobante();
            var resultado = comprobantes.GenerarComprobantes(idventas);

            generarComprobante = new List<s_Generar_Comprobantes_Result>();

            foreach (DataRow fila in resultado.Rows)
            {
                var detalleComprobante = new s_Generar_Comprobantes_Result()
                {
                    idVentas = Convert.ToInt32(fila[0]),
                    numeroVentas = fila[1].ToString(),
                    fecha = Convert.ToDateTime(fila[2]),
                    ccoruc = fila[3].ToString(),
                    razonsocial = fila[4].ToString(),
                    direccion = fila[5].ToString(),
                    telefono = fila[6].ToString(),
                    cantidad = Convert.ToInt32(fila[7]),
                    descripcion = fila[8].ToString(),
                    precio = Convert.ToDecimal(fila[9]),
                    gravadas = Convert.ToDecimal(fila[10]),
                    totales = Convert.ToDecimal(fila[11]),
                };
                generarComprobante.Add(detalleComprobante);
            }
        }


    }
}
