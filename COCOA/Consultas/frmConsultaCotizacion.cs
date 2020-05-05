using COCOA.Busqueda;
using COCOA.DSCOCOATableAdapters;
using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Consultas
{
    public partial class frmConsultaCotizacion : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private int idCotizacion;

        public int IDCotizacion
        {
            get => idCotizacion;
            set => idCotizacion = value;
        }

        public frmConsultaCotizacion()
        {
            InitializeComponent();
        }

        private void verReporteButton_Click(object sender, EventArgs e)
        {
            rptConsultaCotizacion miListado = new rptConsultaCotizacion();
            DSCOCOA miDS = new DSCOCOA();
            ReporteCotizacionTableAdapter adapter = new ReporteCotizacionTableAdapter();
            if (clienteRadioButton.Checked)
            {
                adapter.FillByIdCliente(miDS.ReporteCotizacion, (int)clienteComboBox.SelectedValue);
            }
            else
            {
                adapter.FillByIdCotizacion(miDS.ReporteCotizacion, (int)cotizacionNumericUpDown.Value);
            }
            miListado.SetDataSource(miDS);
            crystalReportViewer1.ReportSource = miListado;
        }

        private void clienteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActualizaFiltro();
        }

        private void ActualizaFiltro()
        {
            if (clienteRadioButton.Checked)
            {
                clienteComboBox.Visible = true;
                busquedaClienteButton.Visible = true;
                cotizacionNumericUpDown.Visible = false;
                verReporteButton.Enabled = true;
            }
            else
            {
                clienteComboBox.Visible = false;
                busquedaClienteButton.Visible = false;
                cotizacionNumericUpDown.Visible = true;
                verReporteButton.Enabled = true;
            }
        }

        private void cotizacionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActualizaFiltro();
        }

        private void busquedaClienteButton_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente miBusqueda = new frmBusquedaCliente();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDCliente == 0) return;
            clienteComboBox.SelectedValue = miBusqueda.IDCliente;
        }

        private void frmConsultaCotizacion_Load(object sender, EventArgs e)
        {
            this.clientesTableAdapter.FillBy2(this.dSCOCOA.Clientes);
            clienteComboBox.SelectedValue = -1;
            if (idCotizacion != 0)
            {
                rptConsultaCotizacion miListado = new rptConsultaCotizacion();
                DSCOCOA miDS = new DSCOCOA();
                ReporteCotizacionTableAdapter adapter = new ReporteCotizacionTableAdapter();
                adapter.FillByIdCotizacion(miDS.ReporteCotizacion, idCotizacion);
                miListado.SetDataSource(miDS);
                crystalReportViewer1.ReportSource = miListado;
            }
        }
    }
}
