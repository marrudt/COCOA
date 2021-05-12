using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Listados
{
    public partial class frmMostrarListadoClientes : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }

        public string Nit { get; set; }

        public frmMostrarListadoClientes()
        {
            InitializeComponent();
        }

        private void frmMostrarListadoClientes_Load(object sender, EventArgs e)
        {
            this.ListadoClientesTableAdapter.Fill(this.DSListados.ListadoClientes,Nit);

            this.reportViewer1.RefreshReport();
        }
    }
}
