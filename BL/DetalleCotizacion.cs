using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DetalleCotizacion
    {
        public int NumeroItem { get; set; }
        public string DetalleNumeroItem { get; set; }        
        public int IdProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal Precio { get; set; }
        public float Cantidad { get; set; }
        public float PorcentajeIVA { get; set; }
        public float PorcentajeImpoconsumo { get; set; }         
        public decimal Descuento { get; set; }
        public float PorcentajeEstampillas { get; set; }
        public decimal ValorEstampillas { get; set; } //{ get { return Precio * (decimal)Estampillas / 100; } }
        public decimal Subtotal { get { return (Precio * (decimal)Cantidad) / (1 + ((decimal)PorcentajeIVA / 100 + (decimal)PorcentajeImpoconsumo / 100)); } }
        public decimal ValorIVA { get { return Subtotal * (decimal)PorcentajeIVA / 100; } }
        public decimal ValorImpoconsumo { get { return Subtotal * (decimal)PorcentajeImpoconsumo / 100; } }
        public decimal ValorNeto { get { return Subtotal + ValorEstampillas + ValorIVA + ValorImpoconsumo - Descuento; } }
    }
}
