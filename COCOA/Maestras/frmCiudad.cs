using COCOA.Busqueda;
using COCOA.Clases;
using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Maestras
{
    public partial class frmCiudad : Form
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

        public frmCiudad()
        {
            InitializeComponent();
        }

        private void ciudadesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;            
            this.Validate();
            this.ciudadesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
            DeshabilitarCampos();
        }

        private void DeshabilitarCampos()
        {
            codigoCiudadTextBox.ReadOnly = true;
            descripcionCiudadTextBox.ReadOnly = true;
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
            if (codigoCiudadTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(codigoCiudadTextBox, "El campo Código es obligatorio");
                codigoCiudadTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (descripcionCiudadTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(descripcionCiudadTextBox, "El campo Descripción es obligatorio");
                descripcionCiudadTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void frmCiudad_Load(object sender, EventArgs e)
        {
            this.ciudadesTableAdapter.Fill(this.dSCOCOA.Ciudades);
        }

        private void bindingNavigatorExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            codigoCiudadTextBox.ReadOnly = false;
            descripcionCiudadTextBox.ReadOnly = false;
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
            ciudadesBindingSource.AddNew();
            codigoCiudadTextBox.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;            
            ciudadesBindingSource.RemoveAt(ciudadesBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
        }

        private void codigoCiudadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            this.ciudadesBindingSource.CancelEdit();
            DeshabilitarCampos();
        }

        private void bindingNavigatorSearch_Click(object sender, EventArgs e)
        {
            frmBusquedaCiudad miBusqueda = new frmBusquedaCiudad();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDCiudad == 0) return;
            int posicion = ciudadesBindingSource.Find("IDCiudad", miBusqueda.IDCiudad);
            ciudadesBindingSource.Position = posicion;
        }
    }
}
