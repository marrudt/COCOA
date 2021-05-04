using COCOA.Busqueda;
using COCOA.DSCOCOATableAdapters;
using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Listados
{
    public partial class frmListadoCotizaciones : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }
        
        public frmListadoCotizaciones()
        {
            InitializeComponent();
        }
        
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }

        private void frmListadoCotizaciones_Load(object sender, EventArgs e)
        {
            this.sp_listado_resumen_cotizacionesTableAdapter.Fill(this.DSListados.sp_listado_resumen_cotizaciones,FechaInicial,FechaFinal);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
