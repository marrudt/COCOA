using COCOA.DSCOCOATableAdapters;
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
    public partial class frmListadoCotizaciones : Form
    {
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
            this.clientesTableAdapter.FillBy3(this.dSCOCOA.Clientes);
            clienteComboBox.SelectedValue = -1;
        }        
    }
}
