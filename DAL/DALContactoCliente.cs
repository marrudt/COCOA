using DAL.DSCOCOATableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALContactosCliente
    {
        public int IdNumeroContacto { get; set; }
        public int IdCliente { get; set; }
        public string NombreContacto { get; set; }
        public string CargoContacto { get; set; }
        public string CorreoContacto { get; set; }
        public string CelularContacto { get; set; }
        public string Telefono1Contacto { get; set; }
        public string Ext1Contacto { get; set; }
        public string Telefono2Contacto { get; set; }
        public string Ext2Contacto { get; set; }
        public string Notas { get; set; }
        public bool Activo { get; set; }

        private static ContactosClienteTableAdapter adaptador = new ContactosClienteTableAdapter();

        public static DALContactosCliente GetContactoClienteByIdNumeroContactoAndIdCliente(int IdNumeroContacto, int IdCliente)
        {
            DALContactosCliente miContactoCliente = null;
            DSCOCOA.ContactosClienteDataTable miTabla = adaptador.GetContactoClienteByIdNumeroContactoAndIdCliente(IdNumeroContacto, IdCliente);

            if (miTabla.Rows.Count == 0) return miContactoCliente;

            DSCOCOA.ContactosClienteRow miRegistro = (DSCOCOA.ContactosClienteRow)miTabla.Rows[0];

            miContactoCliente = new DALContactosCliente();
            miContactoCliente.IdNumeroContacto = miRegistro.IdNumeroContacto;
            miContactoCliente.IdCliente = miRegistro.IdCliente;
            miContactoCliente.NombreContacto = miRegistro.NombreContacto;
            miContactoCliente.CargoContacto = miRegistro.CargoContacto;
            miContactoCliente.CorreoContacto = miRegistro.CorreoContacto;
            miContactoCliente.CelularContacto = miRegistro.CelularContacto;
            miContactoCliente.Telefono1Contacto = miRegistro.Telefono1Contacto;
            miContactoCliente.Ext1Contacto = miRegistro.Ext1Contacto;
            miContactoCliente.Telefono2Contacto = miRegistro.Telefono2Contacto;
            miContactoCliente.Ext2Contacto = miRegistro.Ext2Contacto;
            miContactoCliente.Notas = miRegistro.Notas;
            miContactoCliente.Activo = miRegistro.Activo;

            return miContactoCliente;
        }

        public static void UpdateContactoCliente(int IdNumeroContacto, int IdCliente, string NombreContacto, string CargoContacto, string CorreoContacto, string CelularContacto, string Telefono1Contacto,
            string Ext1Contacto, string Telefono2Contacto, string Ext2Contacto, string Notas, bool Activo)
        {
            try
            {
                adaptador.InsertContactoCliente(IdNumeroContacto, IdCliente, NombreContacto, CargoContacto, CorreoContacto, CelularContacto, Telefono1Contacto,
                    Ext1Contacto, Telefono2Contacto, Ext2Contacto, Notas, Activo);
            }
            catch (Exception)
            {
                adaptador.UpdateContactoCliente(NombreContacto, CargoContacto, CorreoContacto, CelularContacto, Telefono1Contacto, Ext1Contacto, Telefono2Contacto, Ext2Contacto,
                    Notas, Activo, IdCliente, IdNumeroContacto);
            }
        }

        public static void DeleteContactoCliente(int IdCliente)
        {
            adaptador.DeleteContactoClienteByIdCliente(IdCliente);
        }
    }
}
