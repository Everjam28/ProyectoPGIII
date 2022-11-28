using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Entidades;
//using System.Transactions;
namespace Datos
{
    public class D_Ventas
    {
        readonly D_DetalleVentas d_detalleVenta = new D_DetalleVentas();
        SqlConnection conectar = new SqlConnection("Data Source=.\\SQLEXPRESS;initial Catalog=dbSystem_Market;Integrated Security=true");

        //SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["dbSystem_MarketEntities"].ConnectionString);
        //string conexion = ConfigurationManager.ConnectionStrings["dbSystem_MarketEntities"].ConnectionString;





        public bool InsertarVentas(Ventas obj)
        {
            bool proceso = false;
            try
            {
                using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
                {

                    db.Ventas.Add(obj);
                    db.SaveChanges();
                    
                    proceso = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return proceso;
        }


        public DataTable MostrarRegistros()
        {
            DataTable DtResultado = new DataTable();
            SqlCommand command = new SqlCommand("s_Mostrar_Ventas", conectar)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(DtResultado);
            dataAdapter.Dispose();

            return DtResultado;
        }



        //public string InsertarVentas(Ventas ventas, List<E_DetalleVentas> detalleVentas)
        //{
        //    string respuesta;


        //    try
        //    {
        //        conectar.Open();
        //        SqlTransaction transaction = conectar.BeginTransaction();

        //        SqlCommand command = new SqlCommand
        //        {
        //            Connection = conectar,
        //            Transaction = transaction,
        //            CommandText = "s_insertar_ventas",
        //            CommandType = CommandType.StoredProcedure

        //        };

        //        SqlParameter ParIdventas = new SqlParameter
        //        {
        //            ParameterName = "@idVentas",
        //            SqlDbType = SqlDbType.Int,
        //            Direction = ParameterDirection.Output
        //        };

        //        command.Parameters.Add(ParIdventas);

        //        command.Parameters.AddWithValue("@numeroVentas", ventas.numeroVentas);
        //        command.Parameters.AddWithValue("@fecha", ventas.fecha);
        //        command.Parameters.AddWithValue("@estado", ventas.estado);
        //        command.Parameters.AddWithValue("@idClientes", ventas.idClientes);

        //        respuesta = command.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el registro";

        //        if (respuesta.Equals("OK"))
        //        {
        //            ventas.idVentas = Convert.ToInt32(command.Parameters["@idVentas"].Value);
        //            foreach (E_DetalleVentas det in detalleVentas)
        //            {
        //                det.idventas = ventas.idVentas;

        //                respuesta = Convert.ToString(d_detalleVenta.AgregarDVentas(det, ref transaction));//ref conectar, );
        //                if (!respuesta.Equals("OK"))
        //                {
        //                    break;
        //                }
        //            }
        //        }
        //        if (respuesta.Equals("OK"))
        //        {
        //            transaction.Commit();
        //        }
        //        else
        //        {
        //            transaction.Rollback();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        respuesta = ex.Message;
        //    }
        //    finally
        //    {
        //        if (conectar.State == ConnectionState.Open)
        //        {
        //            conectar.Close();
        //        }
        //    }


        //    return respuesta;
        //}



        public DataTable BuscarRegistro(string fechainicial, string fechafinal)
        {
            DataTable dtR = new DataTable();

            using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
            {
                SqlCommand command = new SqlCommand("s_Buscar_Ventas", conectar)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@fechainicial", fechainicial);
                command.Parameters.AddWithValue("@fechafinal", fechafinal);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dtR);
                dataAdapter.Dispose();
                return dtR;


            }



            //}

            //public DataTable MostrarRegistro()
            //{
            //    DataTable dtR = new DataTable();

            //    using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
            //    {
            //        SqlCommand command = new SqlCommand("s_Mostrar_Ventas",conectar)
            //        {
            //            CommandType = CommandType.StoredProcedure
            //        };


            //        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            //        dataAdapter.Fill(dtR);
            //        dataAdapter.Dispose();
            //        return dtR;


            //    }



            //}


            //public DataTable BuscarRegistro(string fechainicial, string fechafinal)
            //{
            //    DataTable dtR = new DataTable();

            //    using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
            //    {
            //        SqlCommand command = new SqlCommand("s_Buscar_Ventas", conectar)
            //        {
            //            CommandType = CommandType.StoredProcedure
            //        };

            //        command.Parameters.AddWithValue("@fechainicial", fechainicial);
            //        command.Parameters.AddWithValue("@fechafinal", fechafinal);

            //        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            //        dataAdapter.Fill(dtR);
            //        dataAdapter.Dispose();
            //        return dtR;


            //    }



            //}



            //public void Anulaomprobante(Ventas idventas)
            //{

            //    using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
            //    {
            //        SqlCommand command = new SqlCommand("s_Anular_Ventas")
            //        {
            //            CommandType = CommandType.StoredProcedure
            //        };

            //       // conectar.Open();

            //        command.Parameters.AddWithValue("@idVentas", idventas.idVentas);

            //        command.ExecuteNonQuery();

            //        //conectar.Close();

            //    }



            //}

            //public void AnularComprobante(Ventas idventas)
            //{

                
            //        SqlCommand command = new SqlCommand("s_Anular_Ventas", conectar)
            //        {
            //            CommandType = CommandType.StoredProcedure
            //        };

            //        conectar.Open();

            //        command.Parameters.AddWithValue("@idVentas", idventas.idVentas);

            //        command.ExecuteNonQuery();

            //        conectar.Close();

            //}


        }
    }
}
//metadata