using DAL.DSCOCOATableAdapters;

namespace DAL
{
    public class DALProducto
    {
        public int IdProducto { get; set; }
        public int IdTipoProducto { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoGM { get; set; }
        public string DescripcionProducto { get; set; }
        public string DetalleProducto { get; set; }
        public int IdClase { get; set; }
        public string ModeloAno { get; set; }
        public decimal Precio { get; set; }
        public int IdIVA { get; set; }
        public int IdImpoconsumo { get; set; }
        public int IdSegmento { get; set; }
        public int IdCilindraje { get; set; }
        public int IdNumeroPasajeros { get; set; }
        public int IdPesoBrutoVh { get; set; }
        public int IdIntervaloPrecio { get; set; }
        public string Notas { get; set; }
        public bool Activo{ get; set; }


        private static ProductosTableAdapter adaptador = new ProductosTableAdapter();

        public static DALProducto GetProductoByIdProducto(int IdProducto)
        {
            DALProducto miProducto = null;
            DSCOCOA.ProductosDataTable miTabla = adaptador.GetProductoByIdProducto(IdProducto);
            if (miTabla.Rows.Count == 0) return miProducto;
            DSCOCOA.ProductosRow miRegistro = (DSCOCOA.ProductosRow)miTabla.Rows[0];
            miProducto = new DALProducto();
            miProducto.IdProducto = miRegistro.IdProducto;
            miProducto.IdTipoProducto = miRegistro.IdTipoProducto;
            miProducto.CodigoProducto = miRegistro.CodigoProducto;
            miProducto.DescripcionProducto = miRegistro.DescripcionProducto;
            miProducto.DetalleProducto = miRegistro.DetalleProducto;
            miProducto.IdClase = miRegistro.IdClase;
            miProducto.ModeloAno = miRegistro.ModeloAno;
            miProducto.Precio = miRegistro.Precio;
            miProducto.IdIVA = miRegistro.IdIVA;
            miProducto.IdImpoconsumo = miRegistro.IdImpoconsumo;
            miProducto.IdSegmento = miRegistro.IdSegmento;
            miProducto.IdCilindraje = miRegistro.IdCilindraje;
            miProducto.IdNumeroPasajeros = miRegistro.IdNumeroPasajeros;
            miProducto.IdPesoBrutoVh = miRegistro.IdPesoBrutoVh;
            miProducto.IdIntervaloPrecio = miRegistro.IdIntervaloPrecio;
            miProducto.Notas = miRegistro.Notas;
            miProducto.Activo = miRegistro.Activo;
            return miProducto;
        }        
    }
}
