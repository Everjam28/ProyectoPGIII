using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Entidades;
using Datos;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Logica
{
    public class S_Ventas
    {
         D_Ventas accion = new D_Ventas();
       // D_Ventas ObjVentas = new D_Ventas();
        //public IList ListadoVentas(string nom)
        //{
        //    List<Ventas> listado = null;
        //    using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
        //    {
        //        IList consulta = (from pro in db.s_Mostrar_Ventas()
        //                          where pro.numeroVentas.Contains(nom)

        //                          select new { pro.idVentas, pro.numeroVentas, pro.fecha, pro.estado, pro.idClientes, pro.ccoruc, pro.razonsocial }).ToList();

        //        return consulta;
        //    }

        //}

        public DataTable MostrarRegistro()
        {
            return new D_Ventas().MostrarRegistros();
        }

        public DataTable BuscarRe(string fechainicial, string fechafinal)
        {
            return new D_Ventas().BuscarRegistro(fechainicial, fechafinal);
        }

        //public string InsertarVentas(Ventas ventas, DataTable DTdestalleventa)
        //{

        //    List<E_DetalleVentas> detalles = new List<E_DetalleVentas>();
        //    foreach (DataRow row in DTdestalleventa.Rows)
        //    {
        //        E_DetalleVentas detalleVenta = new E_DetalleVentas
        //        {

        //            cantidad = Convert.ToInt32(row["cantidad"].ToString()),
        //            descripcion = row["descripcion"].ToString(),
        //            precio = Convert.ToDecimal(row["precio"].ToString()),
        //            gravadas = Convert.ToDecimal(row["gravadas"].ToString()),
        //            totales = Convert.ToDecimal(row["totales"].ToString())

        //        };
        //        detalles.Add(detalleVenta);

        //    }
        //    return ObjVentas.InsertarVentas(ventas, detalles);
        //}

        public bool InsertarVentas(Ventas obj)
        {
            return accion.InsertarVentas(obj);
        }
        //public void AnularComprobantes(Ventas idventas)
        //{
        //    ObjVentas.Anulaomprobante(idventas);
        //}

    }
}
