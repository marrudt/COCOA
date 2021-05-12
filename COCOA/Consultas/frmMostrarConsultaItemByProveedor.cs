using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Consultas
{
    public partial class frmMostrarConsultaItemByProveedor : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }

        public frmMostrarConsultaItemByProveedor()
        {
            InitializeComponent();
        }

        public string IdProducto { get; set; }
        public string NombreProveedor { get; set; }
        public string DescripcionProducto { get; set; }

        private void frmMostrarConsultaItemByProveedor_Load(object sender, EventArgs e)
        {
            this.ConsultaItemsByProveedorTableAdapter.Fill(this.dsConsultas.ConsultaItemsByProveedor,IdProducto,NombreProveedor,DescripcionProducto);

            this.reportViewer1.RefreshReport();
        }
    }
}
