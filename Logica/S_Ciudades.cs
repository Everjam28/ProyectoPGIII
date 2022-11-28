using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace Logica
{
    public class S_Ciudades
    {

        D_Ciudades accion = new D_Ciudades();


        public List<ciudades> Listado()
        {
            List<ciudades> listado = null;
            try
            {
                using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
                {
                    var query = from a in db.ciudades select a;
                    listado = query.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return listado;
        }

        public bool Agregar(ciudades obj)
        {
            return accion.Agregar(obj);
        }

        public bool Actualizar(ciudades obj)
        {
            return accion.Actualizar(obj);
        }

        public bool Eliminar(int idciudad)
        {
            return accion.Eliminar(idciudad);
        }

        public ciudades BuscarId(int idciudad)
        {
            return accion.BuscarId(idciudad);
        }

    }
}
