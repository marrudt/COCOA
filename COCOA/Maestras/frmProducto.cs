using COCOA.Busqueda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOA.Maestras
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
            DeshabilitarCampos();
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

            if (codigoTextBox.Text == "")
            {
                errorProvider1.SetError(codigoTextBox, "El campo código es obligatorio");
                codigoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (descripcionProductoTextBox.Text == "")
            {
                errorProvider1.SetError(codigoTextBox, "El campo descripción es obligatorio");
                codigoTextBox.Focus();
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

            return true;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSCOCOA.Impoconsumo' table. You can move, or remove it, as needed.
            this.impoconsumoTableAdapter.Fill(this.dSCOCOA.Impoconsumo);
            // TODO: This line of code loads data into the 'dSCOCOA.IVA' table. You can move, or remove it, as needed.
            this.iVATableAdapter.Fill(this.dSCOCOA.IVA);
            // TODO: This line of code loads data into the 'dSCOCOA.Clase' table. You can move, or remove it, as needed.
            this.claseTableAdapter.Fill(this.dSCOCOA.Clase);
            // TODO: This line of code loads data into the 'dSCOCOA.TipoProducto' table. You can move, or remove it, as needed.
            this.tipoProductoTableAdapter.Fill(this.dSCOCOA.TipoProducto);
            // TODO: This line of code loads data into the 'dSCOCOA.Productos' table. You can move, or remove it, as needed.
            this.productosTableAdapter.Fill(this.dSCOCOA.Productos);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            productosBindingSource.AddNew();
            idTipoProductoComboBox.Focus();
        }

        private void HabilitarCampos()
        {
            idTipoProductoComboBox.Enabled = true;
            codigoTextBox.ReadOnly = false;
            descripcionProductoTextBox.ReadOnly = false;
            idClaseComboBox.Enabled = true;
            precioTextBox.ReadOnly = false;
            idIVAComboBox.Enabled = true;
            idImpoconsumoComboBox.Enabled = true;
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
        

        private void codigoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            //if (DAL.ProveedorTieneCompras(Convert.ToInt32(iDProveedorTextBox.Text)))
            //{
            //    MessageBox.Show("No es posible borrar Proveedor, ya tiene movimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            productosBindingSource.RemoveAt(productosBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            this.productosBindingSource.CancelEdit();
            DeshabilitarCampos();
        }

        private void DeshabilitarCampos()
        {
            idTipoProductoComboBox.Enabled = false;
            codigoTextBox.ReadOnly = true;
            descripcionProductoTextBox.ReadOnly = true;
            idClaseComboBox.Enabled = false;
            precioTextBox.ReadOnly = true;
            idIVAComboBox.Enabled = false;
            idImpoconsumoComboBox.Enabled = false;
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
    }
}
