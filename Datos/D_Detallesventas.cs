using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Entidades;
namespace Datos
{
    public class D_Detallesventas
    {
        public string AgregarDetalles_Ventas(DetallesVentas detallesV, ref SqlConnection connection, ref SqlTransaction transaction)
        {
            string resp;
            try
            {
                using (dbSystem_MarketEntities Db = new dbSystem_MarketEntities())
                {
                    SqlCommand command = new SqlCommand("s_DetalleVentas", connection)
                    {
                        CommandType = CommandType.StoredProcedure,
                        Transaction = transaction
                    };
                    command.Parameters.AddWithValue("@cantidad", detallesV.Cantidad);
                    command.Parameters.AddWithValue("@descripcion", detallesV.Descripcion);
                    command.Parameters.AddWithValue("@precio", detallesV.Precio);
                    command.Parameters.AddWithValue("@gravadas", detallesV.Gravadas);
                    command.Parameters.AddWithValue("@totales", detallesV.Totales);
                    command.Parameters.AddWithValue("@idventas", detallesV.Idventas);

                    resp = command.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Agregar el detalle";


                }



            }
            catch (Exception ex)
            {

                resp = ex.Message;
            }

            return resp;
        }



    }
}
