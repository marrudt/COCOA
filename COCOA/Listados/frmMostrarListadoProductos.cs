using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Listados
{
    public partial class frmMostrarListadoProductos : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }

        public frmMostrarListadoProductos()
        {
            InitializeComponent();
        }

        public string CodigoProducto { get; set; }
        public string DescripcionProducto { get; set; }

        private void frmMostrarListadoProductos_Load(object sender, EventArgs e)
        {
            this.ListadoProductosTableAdapter.Fill(this.DSListados.ListadoProductos,CodigoProducto,DescripcionProducto);

            this.reportViewer1.RefreshReport();
        }
    }
}
