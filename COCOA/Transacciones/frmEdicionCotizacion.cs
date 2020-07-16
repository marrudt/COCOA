﻿using COCOA.Busqueda;
using COCOA.Clases;
using COCOA.Reportes;
using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Transacciones
{
    public partial class frmEdicionCotizacion : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }

        public frmEdicionCotizacion()
        {
            InitializeComponent();
        }

        private void cotizacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cotizacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
        }

        private void frmEdicionCotizacion_Load(object sender, EventArgs e)
        {
            this.clientesTableAdapter.FillBy(this.dSCOCOA.Clientes);
            this.cotizacionDetalleTableAdapter.Fill(this.dSCOCOA.CotizacionDetalle);
            this.cotizacionTableAdapter.Fill(this.dSCOCOA.Cotizacion);
            bindingNavigatorAddNewItemDetalle.Enabled = false;
            bindingNavigatorDeleteItemDetalle.Enabled = false;
            fechaDateTimePicker.Value = DateTime.Now;
            VerificaPermisos();            
        }
        
        private void bindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            if (DALCotizacion.CotizacionTieneRemplazo(idCotizacionTextBox.Text))
            {                
                MessageBox.Show("Esta cotización fue remplazada por una versión posterior", "No es posible editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HabilitarCampos();              
        }

        private void HabilitarCampos()
        {
            fechaDateTimePicker.Enabled = true;
            plazoEntregaTextBox.ReadOnly = false;
            formaPagoTextBox.ReadOnly = false;
            idClienteComboBox.Enabled = true;
            sitioEntregaTextBox.ReadOnly = false;
            idClienteComboBox.Enabled = true;
            contactoTextBox.ReadOnly = false;
            remplazaCotizacionTextBox.Enabled = true;

            busquedaClienteButton.Enabled = true;
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;
            bindingNavigatorEdit.Enabled = false;
            bindingNavigatorCountItem.Enabled = false;
            bindingNavigatorExit.Enabled = false;
            bindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorCancel.Enabled = true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cotizacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
            DeshabilitarCampos();
            DeshabilitarCamposDetalle();
            VerificaPermisos();

            MessageBox.Show(string.Format("Cotización editada y guardada exitosamente"), "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmReporteCotizacion miReporte = new frmReporteCotizacion();
            miReporte.IDCotizacion = Convert.ToInt32(idCotizacionTextBox.Text);
            miReporte.Show();
        }

        private void VerificaPermisos()
        {
            if (DALPermisoRol.PuedeEditar(usuarioLogueado.IdRol, 31))
            {
                bindingNavigatorEdit.Enabled = true;
            }
            else
            {
                bindingNavigatorEdit.Enabled = false;
            }

            //if (DALPermisoRol.PuedeEliminar(usuarioLogueado.IdRol, 32))
            //{
            //    bindingNavigatorDeleteItemDetalle.Enabled = true;
            //}
            //else
            //{
            //    bindingNavigatorDeleteItemDetalle.Enabled = false;
            //}

            //if (DALPermisoRol.Especifico(usuarioLogueado.IdRol, 32))
            //{
                
            //}
            //else
            //{
                
            //}
            
        }

        private void DeshabilitarCamposDetalle()
        {
            bindingNavigatorAddNewItemDetalle.Enabled = false;
            bindingNavigatorCancelDetalle.Enabled = false;
            bindingNavigatorDeleteItemDetalle.Enabled = false;
            cotizacionDetalleDataGridView.Enabled = false;
            bindingNavigatorSaveItem.Enabled = false;
        }

        private void DeshabilitarCampos()
        {
            fechaDateTimePicker.Enabled = false;
            plazoEntregaTextBox.ReadOnly = true;
            formaPagoTextBox.ReadOnly = true;
            idClienteComboBox.Enabled = false;
            sitioEntregaTextBox.ReadOnly = true;
            idClienteComboBox.Enabled = false;
            contactoTextBox.Enabled = false;
            remplazaCotizacionTextBox.Enabled = false;

            busquedaClienteButton.Enabled = false;
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorEdit.Enabled = true;
            bindingNavigatorCountItem.Enabled = true;
            bindingNavigatorExit.Enabled = true;
            bindingNavigatorSaveItem.Enabled = false;
            bindingNavigatorCancel.Enabled = false;
        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            this.cotizacionBindingSource.CancelEdit();
            DeshabilitarCampos();
            VerificaPermisos();
            errorProvider1.Clear();
            bindingNavigatorEditDetalles.Enabled = true;
        }

        private void bindingNavigatorExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorEditDetalles_Click(object sender, EventArgs e)
        {
            HabilitarCamposDetalle();
        }

        private void HabilitarCamposDetalle()
        {
            bindingNavigatorAddNewItemDetalle.Enabled = true;
            bindingNavigatorCancelDetalle.Enabled = true;
            bindingNavigatorDeleteItemDetalle.Enabled = true;
            cotizacionDetalleDataGridView.Enabled = true;
            bindingNavigatorSaveItem.Enabled = true;
        }

        private void bindingNavigatorCancelDetalle_Click(object sender, EventArgs e)
        {
            this.cotizacionDetalleBindingSource.CancelEdit();
            DeshabilitarCamposDetalle();
            VerificaPermisos();
        }

        private void busquedaClienteButton_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente miBusqueda = new frmBusquedaCliente();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDCliente == 0) return;
            idClienteComboBox.SelectedValue = miBusqueda.IDCliente;
        }

        private void bindingNavigatorSearch_Click(object sender, EventArgs e)
        {
            frmBusquedaProducto miBusqueda = new frmBusquedaProducto();
            miBusqueda.ShowDialog();
        }

        private void remplazaCotizacionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }

        private void activarStripButton_Click(object sender, EventArgs e)
        {
            bindingNavigatorEdit.Enabled = true;
            bindingNavigatorSearch.Enabled = true;
            bindingNavigatorEditDetalles.Enabled = true;
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bindingNavigatorEditDetalles.Enabled = true;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bindingNavigatorEditDetalles.Enabled = true;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bindingNavigatorEditDetalles.Enabled = true;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bindingNavigatorEditDetalles.Enabled = true;
        }
    }
}
