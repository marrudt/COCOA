using DAL.DSCOCOATableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALIVA
    {
        public int IdIVA { get; set; }
        public string DescripcionIVA { get; set; }
        public float Tarifa { get; set; }
        public bool Activo { get; set; }

        private static IVATableAdapter adaptador = new IVATableAdapter();

        public static DALIVA GetIVA(int IdIVA)
        {
            DALIVA miIVA = null;
            DSCOCOA.IVADataTable miTabla = adaptador.GetIVA(IdIVA);
            if (miTabla.Rows.Count == 0) return miIVA;
            DSCOCOA.IVARow miRegistro = (DSCOCOA.IVARow)miTabla.Rows[0];
            miIVA = new DALIVA();
            miIVA.IdIVA = miRegistro.IdIVA;
            miIVA.DescripcionIVA = miRegistro.DescripcionIVA;
            miIVA.Tarifa = (float)miRegistro.Tarifa;
            miIVA.Activo = miRegistro.Activo;
            return miIVA;
        }
    }
}
