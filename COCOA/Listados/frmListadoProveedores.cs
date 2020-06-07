using COCOA.DSCOCOATableAdapters;
using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Listados
{
    public partial class frmListadoProveedores : Form
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

        public frmListadoProveedores()
        {
            InitializeComponent();
        }

        private void verReporteButton_Click(object sender, EventArgs e)
        {
            rptListadoProveedores miListado = new rptListadoProveedores();
            DSCOCOA miDS = new DSCOCOA();
            ListadoProveedoresTableAdapter adapter = new ListadoProveedoresTableAdapter();
            //if (todosCheckBox.Checked)
            //{
            adapter.Fill(miDS.ListadoProveedores);
            //}
            //else
            //{
            //    adapter.FillBy(miDS.ListadoCotizaciones, (int)clienteComboBox.SelectedValue);
            //}
            miListado.SetDataSource(miDS);
            crystalReportViewer1.ReportSource = miListado;
        }

        private void frmListadoProveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
