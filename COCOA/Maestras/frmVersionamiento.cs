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

namespace COCOA.Maestras
{
    public partial class frmVersionamiento : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }

        public frmVersionamiento()
        {
            InitializeComponent();
        }

        private void versionamientoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.versionamientoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);

        }        

        private void versionamientoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            this.Validate();
            this.versionamientoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
            DeshabilitarCampos();
        }

        private void DeshabilitarCampos()
        {
            fechaDateTimePicker.Enabled = false;
            versionTextBox.ReadOnly = true;
            notasTextBox.ReadOnly = true;
            cambioTextBox.ReadOnly = true;

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
            if (versionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(versionTextBox, "El campo Versión es obligatorio");
                versionTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (cambioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(cambioTextBox, "El campo Cambio es obligatorio");
                cambioTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void frmVersionamiento_Load(object sender, EventArgs e)
        {
            this.versionamientoTableAdapter.Fill(this.dSCOCOA.Versionamiento);
            AlternarColorFilas();
        }

        private void AlternarColorFilas()
        {
            versionamientoDataGridView.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            versionamientoDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
        }

        private void bindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            fechaDateTimePicker.Enabled = true;
            versionTextBox.ReadOnly = false;
            notasTextBox.ReadOnly = false;
            cambioTextBox.ReadOnly = false;

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
            versionamientoBindingSource.AddNew();
            fechaDateTimePicker.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;            
            versionamientoBindingSource.RemoveAt(versionamientoBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            this.versionamientoBindingSource.CancelEdit();
            DeshabilitarCampos();
        }

        private void bindingNavigatorExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
