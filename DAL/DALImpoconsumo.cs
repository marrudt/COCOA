using DAL.DSCOCOATableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALImpoconsumo
    {
        public int IdImpoconsumo { get; set; }
        public string DescripcionImpoconsumo { get; set; }
        public float Tarifa { get; set; }
        public bool Activo { get; set; }

        private static ImpoconsumoTableAdapter adaptador = new ImpoconsumoTableAdapter();

        public static DALImpoconsumo GetImpoconsumo(int IdImpoconsumo)
        {
            DALImpoconsumo miImpoconsumo = null;
            DSCOCOA.ImpoconsumoDataTable miTabla = adaptador.GetImpoconsumo(IdImpoconsumo);
            if (miTabla.Rows.Count == 0) return miImpoconsumo;
            DSCOCOA.ImpoconsumoRow miRegistro = (DSCOCOA.ImpoconsumoRow)miTabla.Rows[0];
            miImpoconsumo = new DALImpoconsumo();
            miImpoconsumo.IdImpoconsumo = miRegistro.IdImpoconsumo;
            miImpoconsumo.DescripcionImpoconsumo = miRegistro.DescripcionImpoconsumo;
            miImpoconsumo.Tarifa = (float)miRegistro.Tarifa;
            miImpoconsumo.Activo = miRegistro.Activo;
            return miImpoconsumo;
        }
    }
}
