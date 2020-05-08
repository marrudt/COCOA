using COCOA.Busqueda;
using COCOA.Clases;
using COCOA.Maestras;
using COCOA.Reportes;
using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Transacciones
{
    public partial class frmEdicionOrdenCompra : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmEdicionOrdenCompra()
        {
            InitializeComponent();
        }

        private void ordenCompraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordenCompraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
            DeshabilitarCampos();
            DeshabilitarCamposDetalle();
            VerificaPermisos();

            MessageBox.Show(string.Format("Orden de Compra editada y guardada exitosamente"), "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmReporteOrdenCompra miReporte = new frmReporteOrdenCompra();
            miReporte.IDOrdenCompra = Convert.ToInt32(idOrdenCompraTextBox.Text);
            miReporte.Show();

            //idOrdenCompraTextBox.Text = string.Empty;
            //idProveedorComboBox.SelectedIndex = -1;
            //idClienteComboBox.SelectedIndex = -1;
            //numeroCosteoTextBox.Text = string.Empty;
            //contratoTextBox.Text = string.Empty;
            //idProductoComboBox.SelectedIndex = -1;
            //ordenCompraDetalleDataGridView.DataSource = "";
            //plazoEntregaTextBox.Text = string.Empty;
            //formaPagoTextBox.Text = string.Empty;                       
        }

        private void frmEdicionOrdenCompra_Load(object sender, EventArgs e)
        {
            this.productosTableAdapter.FillBy5(this.dSCOCOA.Productos);
            this.clientesTableAdapter.FillBy2(this.dSCOCOA.Clientes);
            this.proveedoresTableAdapter.FillBy1(this.dSCOCOA.Proveedores);
            this.ordenCompraDetalleTableAdapter.Fill(this.dSCOCOA.OrdenCompraDetalle);
            this.ordenCompraTableAdapter.Fill(this.dSCOCOA.OrdenCompra);
            bindingNavigatorAddNewItemDetalle.Enabled = false;
            bindingNavigatorDeleteItemDetalle.Enabled = false;
            fechaDateTimePicker.Value = DateTime.Now;
            VerificaPermisos();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HabilitarCampos()
        {
            fechaDateTimePicker.Enabled = true;
            plazoEntregaTextBox.ReadOnly = false;
            formaPagoTextBox.ReadOnly = false;
            idProveedorComboBox.Enabled = true;
            numeroCosteoTextBox.ReadOnly = false;
            idClienteComboBox.Enabled = true;
            idProductoComboBox.Enabled = true;
            contratoTextBox.ReadOnly = false;

            busquedaProveedorButton.Enabled = true;
            BusquedaClienteButton.Enabled = true;
            BusquedaProductoButton.Enabled = true;
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

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            this.ordenCompraBindingSource.CancelEdit();
            DeshabilitarCampos();
            VerificaPermisos();
        }

        private void VerificaPermisos()
        {
            if (DALPermisoRol.PuedeEditar(usuarioLogueado.IdRol, 32))
            {
                //bindingNavigatorAddNewItemDetalle.Enabled = true;
                bindingNavigatorEdit.Enabled = true;
            }
            else
            {
                //bindingNavigatorAddNewItemDetalle.Enabled = false;
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
            //    precioTextBox.Enabled = true;
            //}
            //else
            //{
            //    precioTextBox.Enabled = false;
            //}
        }

        private void DeshabilitarCampos()
        {
            fechaDateTimePicker.Enabled = false;
            plazoEntregaTextBox.ReadOnly = true;
            formaPagoTextBox.ReadOnly = true;
            idProveedorComboBox.Enabled = false;
            numeroCosteoTextBox.ReadOnly = true;
            idClienteComboBox.Enabled = false;
            idProductoComboBox.Enabled = false;
            contratoTextBox.ReadOnly = true;

            busquedaProveedorButton.Enabled = false;
            BusquedaClienteButton.Enabled = false;
            BusquedaProductoButton.Enabled = false;
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

        private void bindingNavigatorCancelDetalle_Click(object sender, EventArgs e)
        {
            this.ordenCompraDetalleBindingSource.CancelEdit();
            DeshabilitarCamposDetalle();
            VerificaPermisos();
        }

        private void DeshabilitarCamposDetalle()
        {
            bindingNavigatorAddNewItemDetalle.Enabled = false;
            bindingNavigatorCancelDetalle.Enabled = false;
            bindingNavigatorDeleteItemDetalle.Enabled = false;
            ordenCompraDetalleDataGridView.Enabled = false;
            bindingNavigatorSaveItem.Enabled = false;
        }

        private void bindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
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
            ordenCompraDetalleDataGridView.Enabled = true;
            bindingNavigatorSaveItem.Enabled = true;
        }

        private void busquedaProveedorButton_Click(object sender, EventArgs e)
        {
            frmBusquedaProveedor miBusqueda = new frmBusquedaProveedor();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDProveedor == 0) return;
            idProveedorComboBox.SelectedValue = miBusqueda.IDProveedor;
        }

        private void BusquedaClienteButton_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente miBusqueda = new frmBusquedaCliente();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDCliente == 0) return;
            idClienteComboBox.SelectedValue = miBusqueda.IDCliente;
        }

        private void BusquedaProductoButton_Click(object sender, EventArgs e)
        {
            frmBusquedaProducto miBusqueda = new frmBusquedaProducto();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDProducto == 0) return;
            idProductoComboBox.SelectedValue = miBusqueda.IDProducto;
        }

        private void numeroCosteoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }
    }
}
