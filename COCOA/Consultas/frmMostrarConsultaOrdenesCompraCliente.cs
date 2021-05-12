using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOA.Consultas
{
    public partial class frmMostrarConsultaOrdenesCompraCliente : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }

        public frmMostrarConsultaOrdenesCompraCliente()
        {
            InitializeComponent();
        }

        public string Nit { get; set; }

        private void frmMostrarConsultaOrdenesCompraCliente_Load(object sender, EventArgs e)
        {
            this.ConsultaOrdenesCompraClienteTableAdapter.Fill(this.dsConsultas.ConsultaOrdenesCompraCliente,Nit);

            this.reportViewer1.RefreshReport();
        }
    }
}
