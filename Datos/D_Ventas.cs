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
    public class D_Ventas
    {
        D_Detallesventas d_detallesventas = new D_Detallesventas();


        //public DataTable MostrarRegistro(SqlConnection connection)
        //{
        //    using (dbSystem_MarketEntities Db = new dbSystem_MarketEntities())
        //    {
        //        DataTable dtRespuesta = new DataTable();
        //        SqlCommand command = new SqlCommand("S_Mostrar_ventas", connection)
        //        {
        //            CommandType = CommandType.StoredProcedure
        //        };

        //        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
        //        dataAdapter.Fill(dtRespuesta);
        //        dataAdapter.Dispose();


        //        return dtRespuesta;
        //    }


        //}

       





        public void Agregar(Ventas ventas, List<DetallesVentas> detalleventas)
        {


            string resp;
            using (var db = new dbSystem_MarketEntities())
            {


                SqlCommand command = new SqlCommand
                {

                    CommandText = "s_Insertar_Ventas",
                    CommandType = CommandType.StoredProcedure
                };

                SqlParameter P_idVentas = new SqlParameter
                {
                    ParameterName = "@idVentas",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(P_idVentas);

                command.Parameters.AddWithValue("@numeroVentas", ventas.numeroVentas);
                command.Parameters.AddWithValue("@fecha", ventas.fecha);
                command.Parameters.AddWithValue("@estado", ventas.estado);
                command.Parameters.AddWithValue("@idclientes", ventas.idClientes);

                resp = command.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el registro";

                if (resp.Equals("OK"))
                {
                    ventas.idClientes = Convert.ToInt32(command.Parameters["idVentas"].Value);
                    foreach (DetallesVentas det in detalleventas)
                    {
                        det.Idventas = ventas.idVentas;



                    }


                }
            }
        }

        public Ventas BuscarRegistro(string fechainicial, string fechafinal)
        {
            DataTable dtResultado = new DataTable();
            using (var db = new dbSystem_MarketEntities())
            {
                var buscarPro = db.Database.SqlQuery<Ventas>("s_Buscar_Ventas  @fechaInicial @fechafinal",
                    new SqlParameter(fechainicial,fechafinal)).FirstOrDefault();
                return buscarPro;
            }



        }



    }

}
