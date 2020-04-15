﻿using DAL.DSCOCOATableAdapters;
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

        public static void InsertCotizacionDetalle(int IdCotizacion, int NumeroItem, string DetalleNumeroItem, string DescripcionItem, int IdProducto, 
            string DescripcionProducto, decimal Precio, float Cantidad, float PorcentajeIVA, float PorcentajeImpoconsumo, float Estampillas)
        {
            adaptador.InsertCotizacionDetalle(IdCotizacion, NumeroItem, DetalleNumeroItem, DescripcionItem, IdProducto, DescripcionProducto, Precio, 
                Cantidad, PorcentajeIVA, PorcentajeImpoconsumo, (decimal)Estampillas);
        }
    }
}