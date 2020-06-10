using COCOA.DSCOCOATableAdapters;
using COCOA.Maestras;
using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Reportes
{
    public partial class frmReporteOrdenCompra : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }

        private int idOrdenCompra;

        public int IDOrdenCompra
        {
          get { return idOrdenCompra; }
          set { idOrdenCompra = value; }
        }        

        public frmReporteOrdenCompra()
        {
            InitializeComponent();
        }

        private void verReporteButton_Click(object sender, EventArgs e)
        {
            rptReporteOrdenCompra miListado = new rptReporteOrdenCompra();
            DSCOCOA miDS = new DSCOCOA();
            ReporteOrdenCompraTableAdapter adapter = new ReporteOrdenCompraTableAdapter();
            if (todosRadioButton.Checked)
            {
                adapter.Fill(miDS.ReporteOrdenCompra);
            }
            else if (proveedorRadioButton.Checked)
            {
                adapter.FillByByIdProveedor(miDS.ReporteOrdenCompra, (int)proveedorComboBox.SelectedValue);
            }
            else
            {
                adapter.FillByIdOrdenCompra(miDS.ReporteOrdenCompra, (int)ordenCompraNumericUpDown.Value);
            }
            miListado.SetDataSource(miDS);
            crystalReportViewer1.ReportSource = miListado;
        }

        private void frmReporteOrdenCompra_Load(object sender, EventArgs e)
        {
            this.proveedoresTableAdapter.FillBy1(this.dSCOCOA.Proveedores);
            proveedorComboBox.SelectedValue = -1;
            if (idOrdenCompra != 0)
            {
                rptReporteOrdenCompra miListado = new rptReporteOrdenCompra();
                DSCOCOA miDS = new DSCOCOA();
                ReporteOrdenCompraTableAdapter adapter = new ReporteOrdenCompraTableAdapter();
                adapter.FillByIdOrdenCompra(miDS.ReporteOrdenCompra, idOrdenCompra);
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
                proveedorComboBox.Visible = false;
                ordenCompraNumericUpDown.Visible = false;
                busquedaProveedorButton.Visible = false;
            }
            else if (proveedorRadioButton.Checked)
            {
                proveedorComboBox.Visible = true;
                busquedaProveedorButton.Visible = true;
                ordenCompraNumericUpDown.Visible = false;
            }
            else
            {
                proveedorComboBox.Visible = false;
                busquedaProveedorButton.Visible = false;
                ordenCompraNumericUpDown.Visible = true;
            }
        }

        private void busquedaProveedorButton_Click(object sender, EventArgs e)
        {
            frmBusquedaProveedor miBusqueda = new frmBusquedaProveedor();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDProveedor == 0) return;
            proveedorComboBox.SelectedValue = miBusqueda.IDProveedor;
        }

        private void ordenCompraRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActualizaFiltro();
        }

        private void proveedorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActualizaFiltro();
        }
    }
}
