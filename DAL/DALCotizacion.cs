﻿using DAL.DSCOCOATableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCotizacion
    {
        private static CotizacionTableAdapter adaptador = new CotizacionTableAdapter();

        public static int InsertVenta(DateTime Fecha, int IdCliente, string Contacto, string FormaPago, string PlazoEntrega, string SitioEntrega)
        {
            return (int)adaptador.InsertVenta(Fecha, IdCliente, Contacto, FormaPago, PlazoEntrega, SitioEntrega);
        }
    }
}