using COCOA.Busqueda;
using COCOA.Listados;
using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Maestras
{
    public partial class frmProductos : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }

        //public DALUsuario UsuarioLogueado
        //{
        //    get => usuarioLogueado;
        //    set => usuarioLogueado = value;
        //}

        public frmProductos()
        {
            InitializeComponent();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            this.Validate();
            this.productosBindingSource.EndEdit();

            try
            {
                this.tableAdapterManager.UpdateAll(this.dSCOCOA);
            }
            catch (Exception)
            {
                errorProvider1.SetError(codigoProductoTextBox, "El Producto ya existe");
                codigoProductoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            DeshabilitarCampos();
            VerificaPermisos();
        }

        private void DeshabilitarCampos()
        {
            idTipoProductoComboBox.Enabled = false;
            codigoProductoTextBox.ReadOnly = true;
            descripcionProductoTextBox.ReadOnly = true;
            idClaseComboBox.Enabled = false;
            precioTextBox.ReadOnly = true;
            idIVAComboBox.Enabled = false;
            idImpoconsumoComboBox.Enabled = false;
            idSegmentoComboBox.Enabled = false;
            idCilindrajeComboBox.Enabled = false;
            idNumeroPasajerosComboBox.Enabled = false;
            idPesoBrutoVhComboBox.Enabled = false;
            idIntervaloPrecioComboBox.Enabled = false;
            modeloAnoTextBox.ReadOnly = true;
            detalleProductoTextBox.ReadOnly = true;
            notasTextBox.ReadOnly = true;
            activoCheckBox.Enabled = false;

            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorEdit.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorSaveItem.Enabled = false;
            bindingNavigatorCancel.Enabled = false;
            bindingNavigatorSearch.Enabled = true;
            bindingNavigatorCountItem.Enabled = true;
            bindingNavigatorExit.Enabled = true;
        }

        private bool ValidarCampos()
        {
            if (idTipoProductoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(idTipoProductoComboBox, "El campo tipo de producto es obligatorio");
                idTipoProductoComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (codigoProductoTextBox.Text == "")
            {
                errorProvider1.SetError(codigoProductoTextBox, "El campo código es obligatorio");
                codigoProductoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (descripcionProductoTextBox.Text == "")
            {
                errorProvider1.SetError(codigoProductoTextBox, "El campo descripción es obligatorio");
                codigoProductoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (idClaseComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(idClaseComboBox, "El campo clase de producto es obligatorio");
                idClaseComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (precioTextBox.Text == "")
            {
                errorProvider1.SetError(precioTextBox, "El campo precio es obligatorio");
                precioTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (idIVAComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(idIVAComboBox, "El campo IVA es obligatorio");
                idIVAComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (idImpoconsumoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(idImpoconsumoComboBox, "El campo Impoconsumo es obligatorio");
                idImpoconsumoComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (modeloAnoTextBox.Text == "")
            {
                errorProvider1.SetError(modeloAnoTextBox, "El campo Modelo Año es obligatorio, si no es vehículo el valor es 1");
                modeloAnoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (idSegmentoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(idSegmentoComboBox, "El campo Segmento es obligatorio");
                idSegmentoComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (idCilindrajeComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(idCilindrajeComboBox, "El campo Cilindraje es obligatorio");
                idCilindrajeComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (idNumeroPasajerosComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(idNumeroPasajerosComboBox, "El campo Número Pasajeros es obligatorio");
                idNumeroPasajerosComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (idPesoBrutoVhComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(idPesoBrutoVhComboBox, "El campo Peso Bruto Vh es obligatorio");
                idPesoBrutoVhComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (idIntervaloPrecioComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(idIntervaloPrecioComboBox, "El campo Intervalo de Precio es obligatorio");
                idIntervaloPrecioComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            this.cilindrajesTableAdapter.Fill(this.dSCOCOA.Cilindrajes);
            this.numeroPasajerosTableAdapter.Fill(this.dSCOCOA.NumeroPasajeros);
            this.intervaloPreciosTableAdapter.Fill(this.dSCOCOA.IntervaloPrecios);
            this.pesoBrutoVhTableAdapter.Fill(this.dSCOCOA.PesoBrutoVh);
            this.segmentosTableAdapter.Fill(this.dSCOCOA.Segmentos);
            this.impoconsumoTableAdapter.Fill(this.dSCOCOA.Impoconsumo);
            this.iVATableAdapter.Fill(this.dSCOCOA.IVA);
            this.claseTableAdapter.Fill(this.dSCOCOA.Clase);
            this.tipoProductoTableAdapter.Fill(this.dSCOCOA.TipoProducto);
            this.productosTableAdapter.FillBy(this.dSCOCOA.Productos);
            VerificaPermisos();
        }

        private void VerificaPermisos()
        {
            if (DALPermisoRol.PuedeEditar(usuarioLogueado.IdRol, 3))
            {
                bindingNavigatorAddNewItem.Enabled = true;
                bindingNavigatorEdit.Enabled = true;
                precioTextBox.Enabled = false;
            }
            else
            {
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorEdit.Enabled = false;
                precioTextBox.Enabled = true;
            }

            if (DALPermisoRol.PuedeEliminar(usuarioLogueado.IdRol, 3))
            {
                bindingNavigatorDeleteItem.Enabled = true;
            }
            else
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }

            if (DALPermisoRol.Especifico(usuarioLogueado.IdRol, 3))
            {
                precioTextBox.Enabled = true;
            }
            else
            {
                precioTextBox.Enabled = false;
            }
        }

        private void bindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            idTipoProductoComboBox.Enabled = true;
            codigoProductoTextBox.ReadOnly = false;
            descripcionProductoTextBox.ReadOnly = false;
            idClaseComboBox.Enabled = true;
            precioTextBox.ReadOnly = false;
            idIVAComboBox.Enabled = true;
            idImpoconsumoComboBox.Enabled = true;
            idSegmentoComboBox.Enabled = true;
            idCilindrajeComboBox.Enabled = true;
            idNumeroPasajerosComboBox.Enabled = true;
            idPesoBrutoVhComboBox.Enabled = true;
            idIntervaloPrecioComboBox.Enabled = true;
            modeloAnoTextBox.ReadOnly = false;
            detalleProductoTextBox.ReadOnly = false;
            notasTextBox.ReadOnly = false;
            activoCheckBox.Enabled = true;

            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;
            bindingNavigatorEdit.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorCancel.Enabled = true;
            bindingNavigatorSearch.Enabled = false;
            bindingNavigatorCountItem.Enabled = false;
            bindingNavigatorExit.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            productosBindingSource.AddNew();
            idTipoProductoComboBox.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Eliminar el registro?", "Confirmación",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            if (DALOrdenCompraDetalle.ProductoTieneMovimientoByIdProducto(Convert.ToInt32(idProductoTextBox.Text)))
            {
                MessageBox.Show("El Producto tiene movimientos", "No es posible eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else if (DALCotizacionDetalle.ProductoTieneMovimientoByIdProducto(Convert.ToInt32(idProductoTextBox.Text)))
            {
                MessageBox.Show("El Producto tiene movimientos", "No es posible eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            productosBindingSource.RemoveAt(productosBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            this.productosBindingSource.CancelEdit();
            DeshabilitarCampos();
            VerificaPermisos();
        }

        private void bindingNavigatorSearch_Click(object sender, EventArgs e)
        {
            frmBusquedaProducto miBusqueda = new frmBusquedaProducto();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDProducto == 0) return;
            int posicion = productosBindingSource.Find("IDProducto", miBusqueda.IDProducto);
            productosBindingSource.Position = posicion;
        }

        private void bindingNavigatorExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productosTableAdapter.FillBy(this.dSCOCOA.Productos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bindingNavigatorPrint_Click(object sender, EventArgs e)
        {
            frmListadoProductos miForm = new frmListadoProductos();
            miForm.ShowDialog();            
        }
    }
}
