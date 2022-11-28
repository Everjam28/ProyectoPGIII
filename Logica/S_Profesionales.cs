using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Datos;
using Entidades;

namespace Logica
{
    public class S_Profesionales
    {

        D_Profesionales accion = new D_Profesionales();

        //public List<Profesionales> ListadoP()
        //{
        //    List<Profesionales> listado = null; 
        //    try
        //    {
        //        using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
        //        {
        //            db.s_mostrar_profesionales();
        //            //var query = from a in db.s_mostrar_Usuarios() select a;
        //            listado = db.Profesionales.ToList();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Write(ex.Message);
        //    }
        //    return listado;
        //}

        //public List<Profesionales> ListadoP()
        //{
        //    List<Profesionales> listado = null;
        //    try
        //    {
        //        using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
        //        {
        //            var query = from a in db.Profesionales select a;
        //            listado = query.ToList();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Write(ex.Message);
        //    }
        //    return listado;
        //}

        public IList ListadoP(string nom)
        {
            List < Profesionales > listado= null; 
            using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
            {
                IList consulta = (from pro in db.Profesionales
                                  where pro.nombres.Contains(nom)

                                  select new { pro.idProfesional, pro.ccProfesional, pro.nombres, pro.apellidos, pro.direccion, pro.telefono, pro.correo, pro.ciudades }).ToList();

                return consulta;
            }

        }
        public bool Agregar(Profesionales obj)
        {
            return accion.Agregar(obj);
        }

        public bool Actualizar(Profesionales obj)
        {
            return accion.Actualizar(obj);
        }

        public bool Eliminar(int idprofesional)
        {
            return accion.Eliminar(idprofesional);
        }

        public Profesionales BuscarRegistro(string textobuscar)
        {
            return accion.BuscarRegistro(textobuscar);
        }

    }
}
