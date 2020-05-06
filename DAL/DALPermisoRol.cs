using DAL.DSCOCOATableAdapters;

namespace DAL
{
    public class DALPermisoRol
    {
        public static PermisoRolTableAdapter adaptador = new PermisoRolTableAdapter();

        public static bool PuedeVer(int IdRol, int IdFormulario)
        {
            if (adaptador.PuedeVer(IdRol, IdFormulario) == null)
                return false;
            return true;
        }

        public static bool PuedeEditar(int IdRol, int IdFormulario)
        {
            if (adaptador.PuedeEditar(IdRol, IdFormulario) == null)
                return false;
            return true;
        }

        public static bool PuedeEliminar(int IdRol, int IdFormulario)
        {
            if (adaptador.PuedeEliminar(IdRol, IdFormulario) == null)
                return false;
            return true;
        }

        public static bool Especifico(int IdRol, int IdFormulario)
        {
            if (adaptador.Especifico(IdRol, IdFormulario) == null)
                return false;
            return true;
        }


    }
}
