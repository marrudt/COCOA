using DAL.DSCOCOATableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCotizacionDetalle
    {
        private static CotizacionDetalleTableAdapter adaptador = new CotizacionDetalleTableAdapter();

        public static void InsertCotizacionDetalle(int IdCotizacion, int NumeroItem, string DetalleNumeroItem, int IdProducto, 
            string DescripcionProducto, decimal Precio, float Cantidad, float PorcentajeIVA, float PorcentajeImpoconsumo, float Estampillas)
        {
            adaptador.InsertCotizacionDetalle(IdCotizacion, NumeroItem, DetalleNumeroItem, IdProducto, DescripcionProducto, Precio, Cantidad, 
                PorcentajeIVA, PorcentajeImpoconsumo, (decimal)Estampillas);
        }

        public static bool ProductoTieneMovimientoByIdProducto(int IdProducto)
        {
            if (adaptador.ProductoTieneMovimientoByIdProducto(IdProducto) == null)
            {
                return false;
            }
            return true;
        }
    }
}
