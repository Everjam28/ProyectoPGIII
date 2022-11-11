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
    public class D_Profesionales
    {
      

      
        public bool Agregar(Profesionales obj)
        {
            bool proceso = false;
            try
            {
                using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
                {
                    db.Profesionales.Add(obj);
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

        public bool Actualizar(Profesionales obj)
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
        public bool Eliminar(int idprofesional)
        {
            bool proceso = false;
            try
            {
                using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
                {
                    var profesional = (from a in db.Profesionales where a.idProfesional == idprofesional select a).Single();
                    db.Profesionales.Remove(profesional);
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


        public Profesionales BuscarRegistro(string textobuscar)
        {
            Profesionales obj = null;
            try
            {
                using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
                {
                    var query = from a in db.Profesionales where a.nombres == textobuscar select a;
                    var profesional = query.First();
                    obj = (Profesionales)profesional;
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
