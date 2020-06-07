using COCOA.Busqueda;
using COCOA.DSCOCOATableAdapters;
using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Reportes
{
    public partial class frmReporteCotizacion : Form
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

        private int idCotizacion;

        public int IDCotizacion
        {
          get { return idCotizacion; }
          set { idCotizacion = value; }
        }

        //public int IDCotizacion
        //{
        //    get => idCotizacion;
        //    set => idCotizacion = value;
        //}

        public frmReporteCotizacion()
        {
            InitializeComponent();
        }

        private void verReporteButton_Click(object sender, EventArgs e)
        {
            rptReporteCotizacion miListado = new rptReporteCotizacion();
            DSCOCOA miDS = new DSCOCOA();
            ReporteCotizacionTableAdapter adapter = new ReporteCotizacionTableAdapter();
            if (todosRadioButton.Checked)
            {
                adapter.Fill(miDS.ReporteCotizacion);
            }
            else if (clienteRadioButton.Checked)
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

        private void frmReporteCotizacion_Load(object sender, EventArgs e)
        {
            this.clientesTableAdapter.FillBy(this.dSCOCOA.Clientes);
            clienteComboBox.SelectedValue = -1;
            if (idCotizacion != 0)
            {
                rptReporteCotizacion miListado = new rptReporteCotizacion();
                DSCOCOA miDS = new DSCOCOA();
                ReporteCotizacionTableAdapter adapter = new ReporteCotizacionTableAdapter();
                adapter.FillByIdCotizacion(miDS.ReporteCotizacion, idCotizacion);
                miListado.SetDataSource(miDS);
                crystalReportViewer1.ReportSource = miListado;
            }
            
        }

        private void todosRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActualizaFiltro();
        }

        private void ActualizaFiltro()
        {
            if (todosRadioButton.Checked)
            {
                clienteComboBox.Visible = false;
                cotizacionNumericUpDown.Visible = false;
                busquedaClienteButton.Visible = false;
            }
            else if (clienteRadioButton.Checked)
            {
                clienteComboBox.Visible = true;
                busquedaClienteButton.Visible = true;
                cotizacionNumericUpDown.Visible = false;
            }
            else
            {
                clienteComboBox.Visible = false;
                busquedaClienteButton.Visible = false;
                cotizacionNumericUpDown.Visible = true;
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

        private void clienteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActualizaFiltro();
        }
        
    }
}
