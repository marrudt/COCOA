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

        public static int InsertOrdenCompra(DateTime Fecha, int IdProveedor, string PlazoEntrega)
        {
            return (int)adaptador.InsertOrdenCompra(Fecha, IdProveedor, PlazoEntrega);
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
