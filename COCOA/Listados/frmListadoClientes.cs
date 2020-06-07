using COCOA.DSCOCOATableAdapters;
using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Listados
{
    public partial class frmListadoClientes : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }

        //public DALUsuario UsuarioLogueado
        //{
        //    get => usuarioLogueado;
        //    set => usuarioLogueado = value;
        //}

        public frmListadoClientes()
        {
            InitializeComponent();
        }

        private void verReporteButton_Click(object sender, EventArgs e)
        {
            rptListadoClientes miListado = new rptListadoClientes();
            DSCOCOA miDS = new DSCOCOA();
            ListadoClientesTableAdapter adapter = new ListadoClientesTableAdapter();
            //if (todosCheckBox.Checked)
            //{
            adapter.Fill(miDS.ListadoClientes);
            //}
            //else
            //{
            //    adapter.FillBy(miDS.ListadoCotizaciones, (int)clienteComboBox.SelectedValue);
            //}
            miListado.SetDataSource(miDS);
            crystalReportViewer1.ReportSource = miListado;
        }

        private void frmListadoClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
