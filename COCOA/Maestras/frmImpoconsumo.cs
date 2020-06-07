using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Maestras
{
    public partial class frmImpoconsumo : Form
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

        public frmImpoconsumo()
        {
            InitializeComponent();
        }

        private void impoconsumoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            this.Validate();
            this.impoconsumoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
            DeshabilitarCampos();

        }
        
        private bool ValidarCampos()
        {
            if (descripcionImpoconsumoTextBox.Text == "")
            {
                errorProvider1.SetError(descripcionImpoconsumoTextBox, "El campo descripción es obligatorio");
                descripcionImpoconsumoTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (tarifaTextBox.Text == "")
            {
                errorProvider1.SetError(tarifaTextBox, "El campo tarifa es obligatorio");
                tarifaTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void DeshabilitarCampos()
        {
            descripcionImpoconsumoTextBox.ReadOnly = true;
            tarifaTextBox.ReadOnly = true;
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


        private void frmImpoconsumo_Load(object sender, EventArgs e)
        {
            this.impoconsumoTableAdapter.Fill(this.dSCOCOA.Impoconsumo);

        }

        private void bindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            descripcionImpoconsumoTextBox.ReadOnly = false;
            tarifaTextBox.ReadOnly = false;
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
            impoconsumoBindingSource.AddNew();
            descripcionImpoconsumoTextBox.Focus();
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
            impoconsumoBindingSource.RemoveAt(impoconsumoBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            this.impoconsumoBindingSource.CancelEdit();
            DeshabilitarCampos();
        }

        private void bindingNavigatorExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
