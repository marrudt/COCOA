using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Listados
{
    public partial class frmMostrarListadoOrdenesCompra : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }

        public frmMostrarListadoOrdenesCompra()
        {
            InitializeComponent();
        }

        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public string NitEntidad { get; set; }
        public string NitProveedor { get; set; }

        private void frmMostrarListadoOrdenesCompra_Load(object sender, EventArgs e)
        {
            this.ListadoOrdenesCompraTableAdapter.Fill(this.DSListados.ListadoOrdenesCompra,FechaInicial,FechaFinal,NitEntidad,NitProveedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
