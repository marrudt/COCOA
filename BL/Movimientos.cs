using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Movimientos
    {
        public static int GrabarOrdenCompra(DateTime fecha, int IdProveedor, string plazoEntrega, string formaPago, string terminosGarantia, int IdCliente, string numeroCosteo,
            string contrato, int IdProducto, string Notas, BindingList<DetalleOrdenCompra> misDetalles)
        {
            //Guarda encabezado            
            int IdOrdenCompra = DALOrdenCompra.InsertOrdenCompra(fecha, IdProveedor, plazoEntrega, formaPago, terminosGarantia, IdCliente, numeroCosteo, contrato, IdProducto, Notas);

            //Guarda detalle           
            foreach (DetalleOrdenCompra miDetalle in misDetalles)
            {
                DALOrdenCompraDetalle.InsertOrdenCompraDetalle(IdOrdenCompra, miDetalle.IdProducto, miDetalle.DescripcionProducto, miDetalle.Precio,
                    miDetalle.Cantidad, miDetalle.Descuento, miDetalle.IVA, miDetalle.Impoconsumo);
            }
            return IdOrdenCompra;
        }

        public static int GrabarCotizacion(DateTime fecha, string remplazaCotizacion, int IdCliente, string contacto, string formaPago, string plazoEntrega, string sitioEntrega, 
            List<DetalleCotizacion> misDetalles)
        {
            //Guarda encabezado            
            int IdCotizacion = DALCotizacion.InsertCotizacion(fecha, remplazaCotizacion, IdCliente, contacto, formaPago, plazoEntrega, sitioEntrega);

            //Guarda detalle           
            foreach (DetalleCotizacion miDetalle in misDetalles)
            {
                DALCotizacionDetalle.InsertCotizacionDetalle(IdCotizacion, miDetalle.NumeroItem, miDetalle.DetalleNumeroItem, miDetalle.IdProducto,
                    miDetalle.DescripcionProducto, miDetalle.Precio, miDetalle.Cantidad, miDetalle.PorcentajeIVA, miDetalle.PorcentajeImpoconsumo,
                    miDetalle.PorcentajeEstampillas, miDetalle.ValorEstampillas, miDetalle.Descuento);

            }
            return IdCotizacion;
        }
    }
}
