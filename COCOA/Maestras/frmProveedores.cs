using COCOA.Clases;
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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void proveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            this.Validate();
            this.proveedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
            DeshabilitarCampos();

        }

        private bool ValidarCampos()
        {
            if (nitTextBox.Text == "") 
            {
                errorProvider1.SetError(nitTextBox, "El campo nit es obligatorio");
                nitTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (nombreProveedorTextBox.Text == "")
            {
                errorProvider1.SetError(nombreProveedorTextBox, "El campo nombre de proveedor es obligatorio");
                nombreProveedorTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (direccionTextBox.Text == "")
            {
                errorProvider1.SetError(direccionTextBox, "El campo dirección es oblitorio");
                direccionTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (emailTextBox.Text == "")
            {
                errorProvider1.SetError(emailTextBox, "El campo Email es obligatorio");
                nitTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            RegexUtilities regexUtilities = new RegexUtilities();
            if (!regexUtilities.IsValidEmail(emailTextBox.Text))
            {
                errorProvider1.SetError(emailTextBox, "El formato de Correo no es válido");
                emailTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (telefono1TextBox.Text == "")
            {
                errorProvider1.SetError(telefono1TextBox, "Debe ingresar mínimo un numero teléfonico");
                nitTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();            

            return true;            

        }

        private void DeshabilitarCampos()
        {
            nitTextBox.ReadOnly = true;
            nombreProveedorTextBox.ReadOnly = true;
            nombreContactoTextBox.ReadOnly = true;
            direccionTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            telefono1TextBox.ReadOnly = true;
            telefono2TextBox.ReadOnly = true;
            celularTextBox.ReadOnly = true;
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

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            this.proveedoresTableAdapter.Fill(this.dSCOCOA.Proveedores);

        }

        private void bindingNavigatorEdit_Click(object sender, EventArgs e) 
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            nitTextBox.ReadOnly = false;
            nombreProveedorTextBox.ReadOnly = false;
            nombreContactoTextBox.ReadOnly = false;
            direccionTextBox.ReadOnly = false;
            emailTextBox.ReadOnly = false;
            telefono1TextBox.ReadOnly = false;
            telefono2TextBox.ReadOnly = false;
            celularTextBox.ReadOnly = false;
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

        private void bindingNavigatorExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            this.proveedoresBindingSource.CancelEdit();
            DeshabilitarCampos();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            proveedoresBindingSource.AddNew();
            nitTextBox.Focus();
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
            proveedoresBindingSource.RemoveAt(proveedoresBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
        }

        private void bindingNavigatorSearch_Click(object sender, EventArgs e)
        {
            frmBusquedaProveedor miBusqueda = new frmBusquedaProveedor();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDProveedor == 0) return;
            int posicion = proveedoresBindingSource.Find("IDProveedor", miBusqueda.IDProveedor);
            proveedoresBindingSource.Position = posicion;
        }
    }
}
