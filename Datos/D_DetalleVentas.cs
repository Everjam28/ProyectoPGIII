using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using Entidades;
namespace Datos
{
    public class D_DetalleVentas
    {
        SqlConnection conectar = new SqlConnection("Data Source=.\\SQLEXPRESS;initial Catalog=dbSystem_Market;Integrated Security=true");

        
        public string AgregarDVentas(E_DetalleVentas detalleVenta, ref SqlTransaction transaction)
        {
            string respuesta;


            try
            {


                SqlCommand command = new SqlCommand("s_DetalleVentas", conectar)
                {
                    CommandType = CommandType.StoredProcedure,

                };
                command.Parameters.AddWithValue("@cantidad", detalleVenta.cantidad);
                command.Parameters.AddWithValue("@descripcion", detalleVenta.descripcion);
                command.Parameters.AddWithValue("@precio", detalleVenta.precio);
                command.Parameters.AddWithValue("@gravadas", detalleVenta.gravadas);
                command.Parameters.AddWithValue("@totales", detalleVenta.totales);
                command.Parameters.AddWithValue("@idventas", detalleVenta.idventas);


                respuesta = command.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el datalle de la venta";



            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            return respuesta;



        }


        //public bool AgregarDVentas(DetalleVenta objs)
        //{
        //    bool proceso = false;
        //    try
        //    {
        //        using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
        //        {
        //            db.DetalleVenta.Add(objs);
        //            db.SaveChanges();
        //            proceso = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    return proceso;
        //}


        //public bool AgregarDVentas(DetalleVenta obj, ref SqlTransaction transaction)
        //{
        //    bool proceso = false;
        //    try
        //    {
        //        using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
        //        {
        //            db.DetalleVenta .Add(obj);
        //            db.SaveChanges();
        //            proceso = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    return proceso;
        //}

    }
}
