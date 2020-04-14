using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COCOA.Clases
{
    public class DetalleCotizacion
    {
        public int NumeroItem { get; set; }
        public string DetalleNumeroItem { get; set; }
        public string DescripcionItem { get; set; }
        public int IdProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal Precio { get; set; }
        public float Cantidad { get; set; }
        public float PorcentajeIVA { get; set; }
        public float PorcentajeImpoconsumo { get; set; }
        public float Estampillas { get; set; }
        public int IdSegmento { get; set; }
        public int IdCilindraje { get; set; }
        public int IdNumeroPasajeros { get; set; }
        public int IdPesoBrutoVh { get; set; }
        public int IdIntervaloPrecio { get; set; }
        public decimal ValorEstampillas { get { return Precio * (decimal)Estampillas / 100; } }
        public decimal Subtotal { get { return (Precio * (decimal)Cantidad) / (1 + ((decimal)PorcentajeIVA / 100 + (decimal)PorcentajeImpoconsumo / 100)); } }
        public decimal ValorIVA { get { return Subtotal * (decimal)PorcentajeIVA / 100; } }
        public decimal ValorImpoconsumo { get { return Subtotal * (decimal)PorcentajeImpoconsumo / 100; } }
        public decimal ValorNeto { get { return Subtotal + ValorIVA + ValorImpoconsumo; } }
    }
}
