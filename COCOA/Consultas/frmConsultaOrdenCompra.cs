using COCOA.DSCOCOATableAdapters;
using COCOA.Maestras;
using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Consultas
{
    public partial class frmConsultaOrdenCompra : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private int idOrdenCompra;

        public int IDOrdenCompra
        {
            get => idOrdenCompra;
            set => idOrdenCompra = value;
        }

        public frmConsultaOrdenCompra()
        {
            InitializeComponent();
        }

        private void verReporteButton_Click(object sender, EventArgs e)
        {
            rptConsultaOrdenCompra miListado = new rptConsultaOrdenCompra();
            DSCOCOA miDS = new DSCOCOA();
            ReporteOrdenCompraTableAdapter adapter = new ReporteOrdenCompraTableAdapter();
            if (ordenCompraRadioButton.Checked)
            {
                adapter.FillByIdOrdenCompra(miDS.ReporteOrdenCompra, (int)ordenCompraNumericUpDown.Value);
            }
            else
            {                
                adapter.FillByByIdProveedor(miDS.ReporteOrdenCompra, (int)proveedorComboBox.SelectedValue);
            }
            miListado.SetDataSource(miDS);
            crystalReportViewer1.ReportSource = miListado;
        }

        private void busquedaProveedorButton_Click(object sender, EventArgs e)
        {
            frmBusquedaProveedor miBusqueda = new frmBusquedaProveedor();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDProveedor == 0) return;
            proveedorComboBox.SelectedValue = miBusqueda.IDProveedor;
        }

        private void todosRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActualizaFiltro();
        }

        private void ActualizaFiltro()
        {
            if (proveedorRadioButton.Checked)
            {
                proveedorComboBox.Visible = true;
                busquedaProveedorButton.Visible = true;
                ordenCompraNumericUpDown.Visible = false;
                verReporteButton.Enabled = true;
            }
            else
            {
                proveedorComboBox.Visible = false;
                busquedaProveedorButton.Visible = false;
                ordenCompraNumericUpDown.Visible = true;
                verReporteButton.Enabled = true;
            }
        }

        private void proveedorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActualizaFiltro();
        }

        private void ordenCompraRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActualizaFiltro();
        }

        private void frmConsultaOrdenCompra_Load(object sender, EventArgs e)
        {
            this.proveedoresTableAdapter.FillBy1(this.dSCOCOA.Proveedores);
        }        
    }
}
