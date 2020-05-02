using COCOA.Clases;
using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Maestras
{
    public partial class frmProveedores : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmProveedores()
        {
            InitializeComponent();
        }

        private void proveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            this.Validate();
            this.proveedoresBindingSource.EndEdit();

            try
            {
                this.tableAdapterManager.UpdateAll(this.dSCOCOA);
            }
            catch (Exception)
            {
                errorProvider1.SetError(nitTextBox, "El Nit ya existe");
                nitTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            DeshabilitarCampos();
            VerificaPermisos();
        }

        private void VerificaPermisos()
        {
            if (DALPermisoRol.PuedeEditar(usuarioLogueado.IdRol, 1))
            {
                bindingNavigatorAddNewItem.Enabled = true;
                bindingNavigatorEdit.Enabled = true;
            }
            else
            {
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorEdit.Enabled = false;
            }

            if (DALPermisoRol.PuedeEliminar(usuarioLogueado.IdRol, 1))
            {
                bindingNavigatorDeleteItem.Enabled = true;
            }
            else
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private bool ValidarCampos()
        {
            if (nitTextBox.Text == "")
            {
                errorProvider1.SetError(nitTextBox, "El campo Nit es obligatorio");
                nitTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (nombreProveedorTextBox.Text == "")
            {
                errorProvider1.SetError(nombreProveedorTextBox, "El campo Nombre de Proveedor es obligatorio");
                nombreProveedorTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (direccionTextBox.Text == "")
            {
                errorProvider1.SetError(direccionTextBox, "El campo Dirección es oblitorio");
                direccionTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (ciudadTextBox.Text == "")
            {
                errorProvider1.SetError(ciudadTextBox, "El campo Ciudad es oblitorio");
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
            ciudadTextBox.ReadOnly = true;
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
            VerificaPermisos();
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
            ciudadTextBox.ReadOnly = false;
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
            if (DALOrdenCompra.ProveedorTieneOrdenCompra(Convert.ToInt32(idProveedorTextBox.Text)))
            {
                MessageBox.Show("El Proveedor tiene transacciones", "No es posible eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            proveedoresBindingSource.RemoveAt(proveedoresBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            this.proveedoresBindingSource.CancelEdit();
            DeshabilitarCampos();
            VerificaPermisos();
        }

        private void bindingNavigatorSearch_Click(object sender, EventArgs e)
        {
            frmBusquedaProveedor miBusqueda = new frmBusquedaProveedor();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDProveedor == 0) return;
            int posicion = proveedoresBindingSource.Find("IDProveedor", miBusqueda.IDProveedor);
            proveedoresBindingSource.Position = posicion;
        }

        private void bindingNavigatorExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }

        private void telefono1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }

        private void telefono2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }

        private void celularTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }
    }
}
