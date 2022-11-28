using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class Conexion 
    {
        SqlConnection conectar = new SqlConnection("data source=DESKTOP-SAV8QF3\\SQLEXPRESS,Initial Catalogo=dbSystem_Market;Integrated Security=true");

        public bool conexion()
        {
            bool suceso = false;

            try
            {
                conectar.Open();
                suceso = true;
                Console.WriteLine("Connection Ok");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Connection failed: \n" + ex.Message);
            }
            finally
            {
                conectar.Close();
            }

            return suceso;

        }

    }
}
