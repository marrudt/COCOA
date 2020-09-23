using DAL.DSCOCOATableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCapacidadCarga
    {
        private static PesoBrutoVhTableAdapter adaptador = new PesoBrutoVhTableAdapter();

        public static void Insert(string DescripcionPesoBrutoVh, bool Activo)
        {
            adaptador.Insert(DescripcionPesoBrutoVh, Activo);
        }
    }
}
