using COCOA.DSCOCOATableAdapters;
using COCOA.Maestras;
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

namespace COCOA.Reportes
{
    public partial class frmReporteOrdenCompraEdgarSierra : Form
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

        public frmReporteOrdenCompraEdgarSierra()
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
            rptReporteOrdenCompraEdgarSierra miListado = new rptReporteOrdenCompraEdgarSierra();
            DSCOCOA miDS = new DSCOCOA();
            ReporteOrdenCompraTableAdapter adapter = new ReporteOrdenCompraTableAdapter();
            if (proveedorRadioButton.Checked)
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

        private void frmReporteOrdenCompraEdgarSierra_Load(object sender, EventArgs e)
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

        private void proveedorRadioButton_CheckedChanged(object sender, EventArgs e)
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
            }
            else
            {
                proveedorComboBox.Visible = false;
                busquedaProveedorButton.Visible = false;
                ordenCompraNumericUpDown.Visible = true;
            }
        }

        private void ordenCompraRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActualizaFiltro();
        }
    }
}
