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
    public partial class frmListadoResumenCotizaciones : Form
    {
        public frmListadoResumenCotizaciones()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            frmListadoCotizaciones ListadoCotizaciones = new frmListadoCotizaciones();
            ListadoCotizaciones.FechaInicial = fechaInicialTimePicker.Value;
            ListadoCotizaciones.FechaFinal = fechaFinalTimePicker.Value;

            ListadoCotizaciones.ShowDialog();
        }
    }
}
