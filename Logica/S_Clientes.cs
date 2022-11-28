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
    public class S_Clientes
    {

        D_Clientes accion = new D_Clientes();

        public IList ListadoClientes(string nom)
        {
            using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
            {
                IList consulta = (from pro in db.Clientes
                                  where pro.razonsocial.Contains(nom)

                                  select new { pro.idClientes, pro.ccoruc, pro.razonsocial, pro.direccion, pro.telefono, pro.correo, pro.idProfesional, pro.IdCiudades }).ToList();

                return consulta;
            }

        }

        public bool Agregar(Clientes obj)
        {
            return accion.Agregar(obj);
        }

        public bool Actualizar(Clientes obj)
        {
            return accion.Actualizar(obj);
        }

        public bool Eliminar(int idcliente)
        {
            return accion.Eliminar(idcliente);
        }

        public Clientes BuscarRegistro(string textobuscar)
        {
            return accion.BuscarRegistro(textobuscar);
        }

    }
}
