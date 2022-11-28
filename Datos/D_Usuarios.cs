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
    public class D_Usuarios
    {
        public bool Agregar(Usuarios obj)
        {
            bool proceso = false;
            try
            {
                using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
                {
                    db.Usuarios.Add(obj);
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

        public bool Actualizar(Usuarios obj)
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
        public bool Eliminar(int idusuarios)
        {
            bool proceso = false;
            try
            {
                using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
                {
                    var usuarios = (from a in db.Usuarios where a.idUsuarios == idusuarios select a).Single();
                    db.Usuarios.Remove(usuarios);
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


        
    }
}
