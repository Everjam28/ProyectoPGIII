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
    public class D_Login
    {
        SqlConnection conectar = new SqlConnection("Data Source=.\\SQLEXPRESS;initial Catalog=dbSystem_Market;Integrated Security=true");

        //public bool InicioSesion(string nom)
        //{
        //    List<Usuarios> listado = null;
        //    using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
        //    {
        //        consulta = (from pro in db.spiniciarsesion()
        //                          where pro.acceso.Contains(nom)

        //                          select new { pro.idUsuarios, pro.usuario, pro.contraseña, pro.acceso, pro.idProfesionales, pro.profesional }).ToList();

        //        return consulta;
        //    }

        //}

        public bool InicioSesion(string usuario, string contraseña)
        {

            using (SqlConnection conect = new SqlConnection())
            {

                SqlCommand cmd = new SqlCommand("spiniciarsesion", conectar)
                {
                    CommandType = CommandType.StoredProcedure

                };




                
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);

                try
                {
                    conectar.Open();

                    SqlDataReader leerFilas = cmd.ExecuteReader();

                    if (leerFilas.Read())
                    {
                        while (leerFilas.Read())
                        {

                            Login.idUsuarios = leerFilas.GetInt32(0);
                            Login.usuario = leerFilas.GetString(1);
                            Login.contraseña = leerFilas.GetString(2);
                            Login.acceso = leerFilas.GetString(3);
                            Login.idProfesionales = leerFilas.GetInt32(4);
                            Login.Profesional = leerFilas.GetString(5);

                        }
                        conectar.Close();
                        return true;
                        ///*conectar*/.Close();

                    }
                    else
                    {
                        return false;
                        //conectar.Close();

                    }
                }
                catch(Exception)
                {
                    conectar.Close();
                }

                return false;



            }




        }


        //public bool InicioSesion(string usuario, string contraseña)
        //{
        //    string conexion = ConfigurationManager.ConnectionStrings["conectar"].ConnectionString;

        //    using (SqlConnection connection = new SqlConnection(conexion))
        //    {
        //        SqlCommand Sqlcmd = new SqlCommand("spiniciarsesion", conectar)
        //        {
        //            CommandType = CommandType.StoredProcedure
        //        };

        //       // dbSystem_Market

        //        Sqlcmd.Parameters.AddWithValue("@usuario", usuario);
        //        Sqlcmd.Parameters.AddWithValue("@contraseña", contraseña);

        //        SqlDataReader leerFilas = Sqlcmd.ExecuteReader();

        //        if (leerFilas.HasRows)
        //        {
        //            while (leerFilas.Read())
        //            {
        //                Login.idUsuarios = leerFilas.GetInt32(0);
        //                Login.usuario = leerFilas.GetString(1);
        //                Login.contraseña = leerFilas.GetString(2);
        //                Login.acceso = leerFilas.GetString(3);
        //                Login.idProfesionales = leerFilas.GetInt32(4);
        //                Login.Profesional = leerFilas.GetString(5);
        //            }

        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }


        //    }



        //}

    }


}
    
