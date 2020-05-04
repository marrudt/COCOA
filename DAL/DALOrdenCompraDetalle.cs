using DAL.DSCOCOATableAdapters;

namespace DAL
{
    public class DALOrdenCompraDetalle
    {
        private static OrdenCompraDetalleTableAdapter adaptador = new OrdenCompraDetalleTableAdapter();

        public static void InsertOrdenCompraDetalle(int IdOrdenCompra, int IdProducto, string DescripcionProducto, decimal Precio,
            float Cantidad, float IVA, float Impoconsumo)
        {
            adaptador.InsertOrdenCompraDetalle(IdOrdenCompra, IdProducto, DescripcionProducto, Precio, Cantidad, IVA, Impoconsumo);
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
