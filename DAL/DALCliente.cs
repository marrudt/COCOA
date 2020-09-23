using DAL.DSCOCOATableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCliente
    {
        public int IdCliente { get; set; }
        public string Nit { get; set; }
        public string NombreCliente { get; set; }
        public string NombreContacto { get; set; }
        public string Direccion { get; set; }
        public int IdCiudad { get; set; }
        public string Celular { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Email { get; set; }
        public string Notas { get; set; }
        public bool Activo { get; set; }

        private static ClientesTableAdapter adaptador = new ClientesTableAdapter();

        public static DSCOCOA.ClientesDataTable GetData()
        {
            return adaptador.GetData();
        }

        public static void InsertCliente(string Nit, string NombreCliente, string NombreContacto, string Direccion, int IdCiudad, string Telefono1, string Telefono2, 
            string Celular, string Email, string Notas, bool Activo)
        {
            adaptador.InsertCliente(Nit, NombreCliente, NombreContacto, Direccion, IdCiudad, Telefono1, Telefono2, Celular, Email, Notas, Activo);
        }

        public static void UpdateCliente(string Nit, string NombreCliente, string NombreContacto, string Direccion, int IdCiudad, string Telefono1, string Telefono2, 
            string Celular, string Email, string Notas, bool Activo, int IdCliente)
        {
            adaptador.UpdateCliente(Nit, NombreCliente, NombreContacto, Direccion, IdCiudad, Telefono1, Telefono2, Celular, Email, Notas, Activo, IdCliente);
        }

        public static void DeleteCliente(int IdCliente)
        {
            adaptador.DeleteCliente(IdCliente);
        }

        public static DALCliente GetClienteByNit(string Nit)
        {
            DSCOCOA.ClientesDataTable miTabla = adaptador.GetClienteByNit(Nit);
            if(miTabla.Rows.Count == 0) return null;
            DSCOCOA.ClientesRow miRegistro = (DSCOCOA.ClientesRow)miTabla.Rows[0];
            DALCliente miCliente = new DALCliente();
            miCliente.IdCliente = miRegistro.IdCliente;
            miCliente.Nit = miRegistro.Nit;
            miCliente.NombreCliente = miRegistro.NombreCliente;
            miCliente.NombreContacto = miRegistro.NombreContacto;
            miCliente.Direccion = miRegistro.Direccion;
            miCliente.IdCiudad = miRegistro.IdCiudad;
            miCliente.Telefono1 = miRegistro.Telefono1;
            miCliente.Telefono2 = miRegistro.Telefono2;
            miCliente.Celular = miRegistro.Celular;
            miCliente.Email = miRegistro.Email;
            miCliente.Notas = miRegistro.Notas;
            miCliente.Activo = miRegistro.Activo;
            return miCliente;
        }
        
    }

}
