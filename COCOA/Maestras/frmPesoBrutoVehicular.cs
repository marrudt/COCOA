using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Maestras
{
    public partial class frmPesoBrutoVehicular : Form
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

        public frmPesoBrutoVehicular()
        {
            InitializeComponent();
        }

        private void pesoBrutoVhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            this.Validate();
            this.pesoBrutoVhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
            DeshabilitarCampos();
        }

        private void DeshabilitarCampos()
        {
            descripcionPesoBrutoVhTextBox.ReadOnly = true;
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

        private bool ValidarCampos()
        {
            if (descripcionPesoBrutoVhTextBox.Text == "")
            {
                errorProvider1.SetError(descripcionPesoBrutoVhTextBox, "El campo descripción es obligatorio");
                descripcionPesoBrutoVhTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void frmPesoBrutoVehicular_Load(object sender, EventArgs e)
        {
            this.pesoBrutoVhTableAdapter.Fill(this.dSCOCOA.PesoBrutoVh);

        }

        private void bindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            descripcionPesoBrutoVhTextBox.ReadOnly = false;
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
            pesoBrutoVhBindingSource.AddNew();
            descripcionPesoBrutoVhTextBox.Focus();
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
            pesoBrutoVhBindingSource.RemoveAt(pesoBrutoVhBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            this.pesoBrutoVhBindingSource.CancelEdit();
            DeshabilitarCampos();
        }

        private void bindingNavigatorExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
