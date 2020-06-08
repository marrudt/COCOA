using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Maestras
{
    public partial class frmCilindraje : Form
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

        public frmCilindraje()
        {
            InitializeComponent();
        }

        private void cilindrajesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            this.Validate();
            this.cilindrajesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
            DeshabilitarCampos();
        }

        private bool ValidarCampos()
        {
            if (descripcionCilindrajeTextBox.Text == "")
            {
                errorProvider1.SetError(descripcionCilindrajeTextBox, "El campo Descripción es obligatorio");
                descripcionCilindrajeTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void frmCilindraje_Load(object sender, EventArgs e)
        {
            this.cilindrajesTableAdapter.Fill(this.dSCOCOA.Cilindrajes);

        }

        private void bindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            descripcionCilindrajeTextBox.ReadOnly = false;
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
            bindingNavigatorCountItem.Enabled = false;
            bindingNavigatorExit.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            cilindrajesBindingSource.AddNew();
            descripcionCilindrajeTextBox.Focus();
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
            cilindrajesBindingSource.RemoveAt(cilindrajesBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            this.cilindrajesBindingSource.CancelEdit();
            DeshabilitarCampos();
        }

        private void DeshabilitarCampos()
        {
            descripcionCilindrajeTextBox.ReadOnly = true;
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
            bindingNavigatorCountItem.Enabled = true;
            bindingNavigatorExit.Enabled = true;
        }

        private void bindingNavigatorExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
