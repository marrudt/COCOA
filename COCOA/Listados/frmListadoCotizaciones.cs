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
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmListadoCotizaciones()
        {
            InitializeComponent();
        }

        private void verReporteButton_Click(object sender, EventArgs e)
        {
            rptListadoCotizaciones miListado = new rptListadoCotizaciones();
            DSCOCOA miDS = new DSCOCOA();
            ListadoCotizacionesTableAdapter adapter = new ListadoCotizacionesTableAdapter();
            if (todosCheckBox.Checked)
            {
                adapter.Fill(miDS.ListadoCotizaciones);
            }
            else
            {
                adapter.FillBy(miDS.ListadoCotizaciones, (int)clienteComboBox.SelectedValue);
            }
            miListado.SetDataSource(miDS);
            crystalReportViewer1.ReportSource = miListado;
        }

        private void frmListadoCotizaciones_Load(object sender, EventArgs e)
        {
            this.clientesTableAdapter.FillBy(this.dSCOCOA.Clientes);
            clienteComboBox.SelectedValue = -1;
        }

        private void busquedaClienteButton_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente miBusqueda = new frmBusquedaCliente();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDCliente == 0) return;
            clienteComboBox.SelectedValue = miBusqueda.IDCliente;
        }
    }
}
