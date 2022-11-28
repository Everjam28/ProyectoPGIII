using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using static System.Configuration.ConfigurationManager;
using Entidades;


namespace Datos
{
    public class D_GenerarComprobante
    {
        //private readonly  dbSystem_MarketEntities db;
        ////SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["dbSystem_Market"].ConnectionString);
        SqlConnection conectar = new SqlConnection("Data Source=.\\SQLEXPRESS;initial Catalog=dbSystem_Market;Integrated Security=true");



        void AbrirConexion()
        {
            if (conectar.State == System.Data.ConnectionState.Closed) conectar.Open();
        }

        void CerrarConexion()
        {
            if (conectar.State == System.Data.ConnectionState.Open) conectar.Close();
        }


        public DataTable GenerarComprobantes(int idVentas)
        {
            
            AbrirConexion();
            

                using (var command = new SqlCommand())
                {

                    //using(var db = new dbSystem_MarketEntities())
                    //{

                        
                        command.Connection = conectar;
                        command.CommandText = "s_Generar_Comprobantes";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("idVentas", idVentas);

                        var reader = command.ExecuteReader();
                        var tabla = new DataTable();
                        tabla.Load(reader);

                        return tabla;

                    //}
                    

                }
            
            

        }
    }
}



    

            

              







