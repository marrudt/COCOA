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
        public string IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string Clave { get; set; }
        public int IdRol { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }

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

        public static bool ExisteUsuario(string IdUsuario)
        {
            if (adaptador.ExisteUsuario(IdUsuario) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static DALUsuario GetUsuario(string IdUsuario)
        {
            DALUsuario miUsuario = null;
            DSCOCOA.UsuariosDataTable miTabla = adaptador.GetUsuario(IdUsuario);
            if (miTabla.Rows.Count == 0) return miUsuario;
            DSCOCOA.UsuariosRow miRegistro = (DSCOCOA.UsuariosRow)miTabla.Rows[0];
            miUsuario = new DALUsuario();
            miUsuario.IdUsuario = miRegistro.IdUsuario;
            miUsuario.Nombres = miRegistro.Nombres;
            miUsuario.Clave = miRegistro.Clave;
            miUsuario.IdRol = miRegistro.IdRol;
            miUsuario.Email = miRegistro.Email;
            miUsuario.Activo = miRegistro.Activo;
            return miUsuario;
        }

        public static void CambiarClave(string Clave, string IdUsuario)
        {
            adaptador.CambiarClave(Clave, IdUsuario);
        }
        
    }
}
