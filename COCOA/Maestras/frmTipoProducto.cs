using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Maestras
{
    public partial class frmTipoProducto : Form
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

        public frmTipoProducto()
        {
            InitializeComponent();
        }

        private void tipoProductoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            this.Validate();
            this.tipoProductoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
            DeshabilitarCampos();
        }

        private bool ValidarCampos()
        {
            if (codigoTipoProductoTextBox.Text == "")
            {
                errorProvider1.SetError(codigoTipoProductoTextBox, "El campo Código es obligatorio");
                codigoTipoProductoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (descripcionTipoProductoTextBox.Text == "")
            {
                errorProvider1.SetError(descripcionTipoProductoTextBox, "El campo Descripción es obligatorio");
                descripcionTipoProductoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void frmTipoProducto_Load(object sender, EventArgs e)
        {
            this.tipoProductoTableAdapter.Fill(this.dSCOCOA.TipoProducto);
        }

        private void bindingNavigatorExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            this.tipoProductoBindingSource.CancelEdit();
            DeshabilitarCampos();
        }

        private void DeshabilitarCampos()
        {
            codigoTipoProductoTextBox.ReadOnly = true;
            descripcionTipoProductoTextBox.ReadOnly = true;

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

        private void bindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            codigoTipoProductoTextBox.ReadOnly = false;
            descripcionTipoProductoTextBox.ReadOnly = false;

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
            tipoProductoBindingSource.AddNew();
            codigoTipoProductoTextBox.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;            
            tipoProductoBindingSource.RemoveAt(tipoProductoBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
        }
    }
}
