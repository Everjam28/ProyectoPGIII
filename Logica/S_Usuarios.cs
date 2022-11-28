using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Entidades;
using Datos;
namespace Logica
{
    public class S_Usuarios
    {
        D_Usuarios accion = new D_Usuarios();
        public IList ListadoUsuario(string nom)
        {
            List<Usuarios> listado = null;
            using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
            {
                IList consulta = (from pro in db.s_mostrar_Usuarios()
                                  where pro.acceso.Contains(nom)

                                  select new { pro.idUsuarios, pro.usuario,  pro.contraseña, pro.acceso, pro.idProfesionales, pro.profesional}).ToList();

                return consulta;
            }

        }
       
        public bool Agregar(Usuarios obj)
        {
            return accion.Agregar(obj);
        }

        public bool Actualizar(Usuarios obj)
        {
            return accion.Actualizar(obj);
        }

        public bool Eliminar(int idusuarios)
        {
            return accion.Eliminar(idusuarios);
        }

       

    }
}
