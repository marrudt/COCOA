﻿using COCOA.Busqueda;
using COCOA.DSCOCOATableAdapters;
using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Reportes
{
    public partial class frmReporteCotizacionAccesorios : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }

        private int IdCotizacion;

        public int IDCotizacion
        {
            get => IdCotizacion;
            set => IdCotizacion = value;
        }
        
        public frmReporteCotizacionAccesorios()
        {
            InitializeComponent();
        }

        private void busquedaClienteButton_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente miBusqueda = new frmBusquedaCliente();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDCliente == 0) return;
            clienteComboBox.SelectedValue = miBusqueda.IDCliente;
        }

        private void verReporteButton_Click(object sender, EventArgs e)
        {
            rptReporteCotizacionAccesorios miListado = new rptReporteCotizacionAccesorios();
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

        private void frmReporteCotizacionAccesorios_Load(object sender, EventArgs e)
        {
            this.clientesTableAdapter.FillBy(this.dSCOCOA.Clientes);
            clienteComboBox.SelectedValue = -1;
            if (IdCotizacion != 0)
            {
                rptReporteCotizacionAccesorios miListado = new rptReporteCotizacionAccesorios();
                DSCOCOA miDS = new DSCOCOA();
                ReporteCotizacionTableAdapter adapter = new ReporteCotizacionTableAdapter();
                adapter.FillByIdCotizacion(miDS.ReporteCotizacion, IdCotizacion);
                miListado.SetDataSource(miDS);
                crystalReportViewer1.ReportSource = miListado;
            }
        }

        private void cotizacionRadioButton_CheckedChanged(object sender, EventArgs e)
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
            }
            else
            {
                clienteComboBox.Visible = false;
                busquedaClienteButton.Visible = false;
                cotizacionNumericUpDown.Visible = true;
            }
        }

        private void clienteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ActualizaFiltro();
        }
    }
}