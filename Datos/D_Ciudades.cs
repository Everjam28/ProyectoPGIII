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
    public class D_Ciudades
    {
        public bool Agregar(ciudades obj)
        {
            bool proceso = false;
            try
            {
                using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
                {
                    db.ciudades.Add(obj);
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

        public bool Actualizar(ciudades obj)
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

        public bool Eliminar(int idciudad)
        {
            bool proceso = false;
            try
            {
                using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
                {
                    var ciudad = (from a in db.ciudades where a.IdCiudades == idciudad select a).Single();
                    db.ciudades.Remove(ciudad);
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

        public ciudades BuscarId(int idciudad)
        {
            ciudades obj = null;
            try
            {
                using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
                {
                    var query = from a in db.ciudades where a.IdCiudades == idciudad select a;
                    var ciudad = query.First();
                    obj = (ciudades)ciudad;
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
