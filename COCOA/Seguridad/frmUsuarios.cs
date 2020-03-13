using COCOA.Clases;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOA.Seguridad
{
    public partial class frmUsuarios : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private bool nuevo = false;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
            DeshabilitarCampos();
        }

        private bool ValidarCampos()
        {
            if(nuevo)
            {
                if (idUsuarioTextBox.Text == string.Empty)
                {
                    errorProvider1.SetError(idUsuarioTextBox, "El campo Usuario es obligatorio");
                    idUsuarioTextBox.Focus();
                    return false;
                }
                errorProvider1.Clear();

                if (DALUsuario.ExisteUsuario(idUsuarioTextBox.Text))
                {
                    errorProvider1.SetError(idUsuarioTextBox, "El Usuario ya existe");
                    idUsuarioTextBox.Focus();
                    return false;
                }
            }

            if(idRolComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(idRolComboBox, "El campo Rol es obligatorio");
                idUsuarioTextBox.Focus();
                return false;
            }

            if (nombresTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombresTextBox, "El campo Nombres es obligatorio");
                nombresTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (claveTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(claveTextBox, "El campo Clave es obligatorio");
                nombresTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (confirmacionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(confirmacionTextBox, "El campo Confirmación es obligatorio");
                confirmacionTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (claveTextBox.Text != confirmacionTextBox.Text)
            {
                errorProvider1.SetError(confirmacionTextBox, "Las claves no coinciden");
                errorProvider1.SetError(claveTextBox, "Las claves no coinciden");
                claveTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (emailTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(emailTextBox, "El campo Email es obligatorio");
                emailTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            RegexUtilities regexUtilities = new RegexUtilities();
            if (!regexUtilities.IsValidEmail(emailTextBox.Text))
            {
                errorProvider1.SetError(emailTextBox, "El formato del Email no es válido");
                emailTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;            
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            this.rolTableAdapter.Fill(this.dSCOCOA.Rol);
            this.usuariosTableAdapter.Fill(this.dSCOCOA.Usuarios);
            confirmacionTextBox.Text = claveTextBox.Text;
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            confirmacionTextBox.Text = claveTextBox.Text;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            confirmacionTextBox.Text = claveTextBox.Text;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            confirmacionTextBox.Text = claveTextBox.Text;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            confirmacionTextBox.Text = claveTextBox.Text;
        }

        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            confirmacionTextBox.Text = claveTextBox.Text;
        }

        private void bindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            nuevo = false;
        }

        private void HabilitarCampos()
        {
            idUsuarioTextBox.ReadOnly = true;
            nombresTextBox.ReadOnly = false;
            claveTextBox.ReadOnly = false;
            confirmacionTextBox.ReadOnly = false;
            emailTextBox.ReadOnly = false;
            idRolComboBox.Enabled = true;
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
            //bindingNavigatorSearch.Enabled = false;
            bindingNavigatorCountItem.Enabled = false;
            bindingNavigatorExit.Enabled = false;
        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.CancelEdit();            
            confirmacionTextBox.Text = claveTextBox.Text;
            DeshabilitarCampos();
        }

        private void DeshabilitarCampos()
        {
            idUsuarioTextBox.ReadOnly = true;
            nombresTextBox.ReadOnly = true;
            claveTextBox.ReadOnly = true;
            confirmacionTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            idRolComboBox.Enabled = false;
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
            //bindingNavigatorSearch.Enabled = true;
            bindingNavigatorCountItem.Enabled = true;
            bindingNavigatorExit.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            usuariosBindingSource.AddNew();
            idUsuarioTextBox.Focus();
            idUsuarioTextBox.ReadOnly = false;
            confirmacionTextBox.Clear();
            nuevo = true;
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
            usuariosBindingSource.RemoveAt(usuariosBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
        }

        private void bindingNavigatorExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
