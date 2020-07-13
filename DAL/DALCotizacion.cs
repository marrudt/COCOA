using DAL.DSCOCOATableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCotizacion
    {
        private static CotizacionTableAdapter adaptador = new CotizacionTableAdapter();

        public static int InsertCotizacion(DateTime Fecha, string RemplazaCotizacion, int IdCliente, string Contacto, string FormaPago, string PlazoEntrega, string SitioEntrega)
        {
            return (int)adaptador.InsertCotizacion(Fecha, RemplazaCotizacion, IdCliente, Contacto, FormaPago, PlazoEntrega, SitioEntrega);
        }

        public static bool ClienteTieneCotizacion(int IdCliente)
        {
            if (adaptador.ClienteTieneCotizacion(IdCliente) == null)
            {
                return false;
            }
            return true;
        }

        public static bool CotizacionTieneRemplazo(string IdCotizacion)
        {
            if(adaptador.CotizacionTieneRemplazo(IdCotizacion) == null)
            {
                return false;
            }
            return true;
        }
    }
}
