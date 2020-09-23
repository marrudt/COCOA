using DAL.DSCOCOATableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALProveedor
    {
        public int IdProveedor { get; set; }
        public string Nit { get; set; }
        public string NombreProveedor { get; set; }
        public string NombreContacto { get; set; }
        public string Direccion { get; set; }
        public int IdCiudad { get; set; }
        public string Celular { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Email { get; set; }
        public string Notas { get; set; }
        public bool Activo { get; set; }

        private static ProveedoresTableAdapter adaptador = new ProveedoresTableAdapter();

        public static DSCOCOA.ProveedoresDataTable GetData()
        {
            return adaptador.GetData();
        }

        public static void InsertProveedor(string Nit, string NombreProveedor, string NombreContacto, string Direccion, int IdCiudad, string Telefono1, string Telefono2, 
            string Celular, string Email, string Notas, bool Activo)
        {
            adaptador.InsertProveedor(Nit, NombreProveedor, NombreContacto, Direccion, IdCiudad, Telefono1, Telefono2, Celular, Email, Notas, Activo);
        }

        public static void UpdateProveedor(string  Nit, string NombreProveedor, string NombreContacto, string Direccion, int IdCiudad, string Telefono1, string Telefono2, 
            string Celular, string Email, string Notas, bool Activo, int IdProveedor)
        {
            adaptador.UpdateProveedor(Nit, NombreProveedor, NombreContacto, Direccion, IdCiudad, Telefono1, Telefono2, Celular, Email, Notas, Activo, IdProveedor);
        }

        public static void DeleteProveedor(int IdProveedor)
        {
            adaptador.DeleteProveedor(IdProveedor);
        }

        public static DALProveedor GetProveedorByNit(string Nit)
        {
            DSCOCOA.ProveedoresDataTable miTabla = adaptador.GetProveedorByNit(Nit);
            if(miTabla.Rows.Count == 0) return null;
            DSCOCOA.ProveedoresRow miRegistro = (DSCOCOA.ProveedoresRow)miTabla.Rows[0];
            DALProveedor miProveedor = new DALProveedor();
            miProveedor.IdProveedor = miRegistro.IdProveedor;
            miProveedor.Nit = miRegistro.Nit;
            miProveedor.NombreProveedor = miRegistro.NombreProveedor;
            miProveedor.NombreContacto = miRegistro.NombreContacto;
            miProveedor.Direccion = miRegistro.Direccion;
            miProveedor.IdCiudad = miRegistro.IdCiudad;
            miProveedor.Telefono1 = miRegistro.Telefono1;
            miProveedor.Telefono2 = miRegistro.Telefono2;
            miProveedor.Celular = miRegistro.Celular;
            miProveedor.Email = miRegistro.Email;
            miProveedor.Notas = miRegistro.Notas;
            miProveedor.Activo = miRegistro.Activo;
            return miProveedor;
        }
    }
}
