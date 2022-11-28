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
    public class D_Clientes
    {
       

       

        public bool Agregar(Clientes obj)
        {
            bool proceso = false;
            try
            {
                using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
                {
                    db.Clientes.Add(obj);
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

        public bool Actualizar(Clientes obj)
        {
            bool proceso = false;
            try
            {
                using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
                {
                    db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
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
        public bool Eliminar(int idclientes)
        {
            bool proceso = false;
            try
            {
                using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
                {
                    var clientes = (from a in db.Clientes where a.idClientes == idclientes select a).Single();
                    db.Clientes.Remove(clientes);
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


        public Clientes BuscarRegistro(string textobuscar)
        {
            Clientes obj = null;
            try
            {
                using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
                {
                    var query = from a in db.Clientes where a.razonsocial == textobuscar select a;
                    var cliente = query.First();
                    obj = (Clientes)cliente;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return obj;
        }
    }
}
