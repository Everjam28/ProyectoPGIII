using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Logica
{
    public class S_Login
    {
        D_Login accion = new D_Login();

        public bool InicioSesion(string usuario, string contraseña)
        {
            return accion.InicioSesion(usuario, contraseña);
        }
    }
}
