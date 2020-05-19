using COCOA.DSCOCOATableAdapters;
using COCOA.Maestras;
using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Listados
{
    public partial class frmListadoOrdenCompras : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmListadoOrdenCompras()
        {
            InitializeComponent();
        }

        private void busquedaProveedorButton_Click(object sender, EventArgs e)
        {
            frmBusquedaProveedor miBusqueda = new frmBusquedaProveedor();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDProveedor == 0) return;
            proveedorComboBox.SelectedValue = miBusqueda.IDProveedor;
        }

        private void verReporteButton_Click(object sender, EventArgs e)
        {
            rptListadoOrdenCompras miListado = new rptListadoOrdenCompras();
            DSCOCOA miDS = new DSCOCOA();
            ListadoOrdenComprasTableAdapter adapter = new ListadoOrdenComprasTableAdapter();
            if (todosCheckBox.Checked)
            {
                adapter.Fill(miDS.ListadoOrdenCompras);
            }
            else
            {
                adapter.FillBy(miDS.ListadoOrdenCompras, (int)proveedorComboBox.SelectedValue);
            }
            miListado.SetDataSource(miDS);
            crystalReportViewer1.ReportSource = miListado;
        }

        private void frmListadoOrdenCompras_Load(object sender, EventArgs e)
        {
            this.proveedoresTableAdapter.FillBy1(this.dSCOCOA.Proveedores);
            proveedorComboBox.SelectedValue = -1;
        }
    }
}
