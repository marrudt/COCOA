using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Listados
{
    public partial class frmMostrarListadoProveedores : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }

        public frmMostrarListadoProveedores()
        {
            InitializeComponent();
        }

        public string Nit { get; set; }

        private void frmMostrarListadoProveedores_Load(object sender, EventArgs e)
        {
            this.ListadoProveedoresTableAdapter.Fill(this.DSListados.ListadoProveedores,Nit);

            this.reportViewer1.RefreshReport();
        }
    }
}
