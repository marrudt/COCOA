using DAL;

namespace COCOA.Clases
{
    public class DetalleOrdenCompra
    {
        public int IdProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal Precio { get; set; }
        public float Cantidad { get; set; }
        public float IVA { get; set; }
        public float Impoconsumo { get; set; }
        public decimal Subtotal { get { return (Precio * (decimal)Cantidad) / (1 + ((decimal)IVA / 100 + (decimal)Impoconsumo / 100)); } }
        public decimal ValorIVA { get { return Subtotal * (decimal)IVA / 100; } }
        public decimal ValorImpoconsumo { get { return Subtotal * (decimal)Impoconsumo / 100; } }
        public decimal ValorNeto { get { return Subtotal + ValorIVA + ValorImpoconsumo; } }
    }
}
