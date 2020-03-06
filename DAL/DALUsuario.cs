using DAL.DSCOCOATableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALUsuario
    {
        private static UsuariosTableAdapter adaptador = new UsuariosTableAdapter();

        public static bool ValidarUsuario(string IdUsuario, string Clave)
        {
            if (adaptador.ValidaUsuario(IdUsuario, Clave) == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
