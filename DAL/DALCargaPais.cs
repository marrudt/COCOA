using DAL.DSCOCOATableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCargaPais
    {
        public int IdPais { get; set; }
        public string CodigoPais { get; set; }
        public string DescripcionPais { get; set; }

        private static PaisesTableAdapter adaptador = new PaisesTableAdapter();

        public static DALCargaPais GetPais (int IdPais)
        {
            DALCargaPais miPais = null;
            DSCOCOA.PaisesDataTable miTabla = adaptador.GetPais(IdPais);
            if (miTabla.Rows.Count == 0) return miPais;
            DSCOCOA.PaisesRow miRegistro = (DSCOCOA.PaisesRow)miTabla.Rows[0];
            miPais = new DALCargaPais();
            miPais.IdPais = miRegistro.IdPais;
            miPais.CodigoPais = miRegistro.CodigoPais;
            miPais.DescripcionPais = miRegistro.DescripcionPais;

            return miPais;
        }        
    }
}
