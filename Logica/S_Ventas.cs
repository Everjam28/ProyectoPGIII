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
    public class S_Ventas
    {
        public List<Ventas> ListadoVentas()
        {
            using (dbSystem_MarketEntities db = new dbSystem_MarketEntities())
            {

                return db.Ventas.ToList();
            }

        }

     
    }


    //public void Agregar(Ventas obj)
    //{
        
    //}


}
