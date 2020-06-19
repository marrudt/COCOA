using DAL.DSCOCOATableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALOrdenCompra
    {
        private static OrdenCompraTableAdapter adaptador = new OrdenCompraTableAdapter();

        public static int InsertOrdenCompra(DateTime Fecha, int IdProveedor, string PlazoEntrega, string FormaPago, string TerminosGarantia, int IdCliente, string NumeroCosteo, string Contrato,
            int IdProducto)
        {
            return (int)adaptador.InsertOrdenCompra(Fecha, IdProveedor, PlazoEntrega, FormaPago, TerminosGarantia, IdCliente, NumeroCosteo, Contrato, IdProducto);
        } 
        
        public static bool ProveedorTieneOrdenCompra(int IdProveedor)
        {
            if (adaptador.ProveedorTieneOrdenCompra(IdProveedor) == null)
            {
                return false;
            }
            return true;
        }
       
    }

}
