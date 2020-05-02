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

namespace COCOA.Listados
{
    public partial class frmListadoProductos : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmListadoProductos()
        {
            InitializeComponent();
        }
                
        private void frmListadoProductos_Load(object sender, EventArgs e)
        {
            this.tipoProductoTableAdapter.Fill(this.dSCOCOA.TipoProducto);
            tipoComboBox.SelectedValue = -1;
        }

        private void verReporteButton_Click(object sender, EventArgs e)
        {
            rptListadoProductos miListado = new rptListadoProductos();
            DSCOCOA miDS = new DSCOCOA();
            ListadoProductosTableAdapter adapter = new ListadoProductosTableAdapter();
            if (todosCheckBox.Checked)
            {
                adapter.Fill(miDS.ListadoProductos);
            }
            else
            {
                adapter.FillBy(miDS.ListadoProductos, (int)tipoComboBox.SelectedValue);
            }
            miListado.SetDataSource(miDS);
            crystalReportViewer1.ReportSource = miListado;
        }
    }
}
