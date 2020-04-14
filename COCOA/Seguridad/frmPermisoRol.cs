using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Seguridad
{
    public partial class frmPermisoRol : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmPermisoRol()
        {
            InitializeComponent();
        }

        private void permisoRolBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            this.Validate();
            this.permisoRolBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.dSCOCOA);
            }
            catch (Exception)
            {
                errorProvider1.SetError(idRolComboBox,"Permiso ya creado") ;
                idRolComboBox.Focus();
                return;
            }
            errorProvider1.Clear();
            DeshabilitarCampos();
        }

        private void DeshabilitarCampos()
        {
            idRolComboBox.Enabled = false;
            idFormularioComboBox.Enabled = false;
            puedeEditarCheckBox.Enabled = false;
            puedeEliminarCheckBox.Enabled = false;
            puedeVerCheckBox.Enabled = false;

            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorEdit.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorSaveItem.Enabled = false;
            bindingNavigatorCancel.Enabled = false;
            bindingNavigatorCountItem.Enabled = true;
            bindingNavigatorExit.Enabled = true;
        }

        private bool ValidarCampos()
        {
            if (idRolComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(idRolComboBox, "El campo Rol es obligatorio");
                idRolComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (idFormularioComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(idFormularioComboBox, "El campo Formulario es obligatorio");
                idFormularioComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void frmPermisoRol_Load(object sender, EventArgs e)
        {
            this.formularioTableAdapter.Fill(this.dSCOCOA.Formulario);
            this.rolTableAdapter.Fill(this.dSCOCOA.Rol);
            this.permisoRolTableAdapter.Fill(this.dSCOCOA.PermisoRol);

        }

        private void bindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            idRolComboBox.Enabled = true;
            idFormularioComboBox.Enabled = true;
            puedeEditarCheckBox.Enabled = true;
            puedeEliminarCheckBox.Enabled = true;
            puedeVerCheckBox.Enabled = true;

            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;
            bindingNavigatorEdit.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorCancel.Enabled = true;
            bindingNavigatorCountItem.Enabled = false;
            bindingNavigatorExit.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            permisoRolBindingSource.AddNew();
            idRolComboBox.Focus();
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
            permisoRolBindingSource.RemoveAt(permisoRolBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            this.rolBindingSource.CancelEdit();
            DeshabilitarCampos();
        }

        private void bindingNavigatorExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
