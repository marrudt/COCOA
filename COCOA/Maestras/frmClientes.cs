using COCOA.Busqueda;
using COCOA.Clases;
using COCOA.Listados;
using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Maestras
{
    public partial class frmClientes : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }        

        public frmClientes()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.contactosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);

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

        private bool ValidarCampos()
        {
            if (nitTextBox.Text == "")
            {
                errorProvider1.SetError(nitTextBox, "El campo Nit es obligatorio");
                nitTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (nombreClienteTextBox.Text == "")
            {
                errorProvider1.SetError(nombreClienteTextBox, "El campo Nombre de Cliente es obligatorio");
                nombreClienteTextBox.Focus();
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

            if (idCiudadComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(idCiudadComboBox, "El campo Ciudad es oblitorio");
                idCiudadComboBox.Focus();
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
                errorProvider1.SetError(telefono1TextBox, "Debe ingresar mínimo un número teléfonico");
                nitTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void DeshabilitarCampos()
        {
            nitTextBox.ReadOnly = true;
            nombreClienteTextBox.ReadOnly = true;
            nombreContactoTextBox.ReadOnly = true;
            direccionTextBox.ReadOnly = true;
            idCiudadComboBox.Enabled = false;
            emailTextBox.ReadOnly = true;
            telefono1TextBox.ReadOnly = true;
            telefono2TextBox.ReadOnly = true;
            celularTextBox.ReadOnly = true;
            notasTextBox.ReadOnly = true;
            activoCheckBox.Enabled = false;
            contactosGroupBox.Enabled = false;

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
            busquedaCiudadButton.Enabled = false;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            this.contactosClienteTableAdapter.Fill(this.dSCOCOA.ContactosCliente);
            this.ciudadesTableAdapter.FillBy1(this.dSCOCOA.Ciudades);
            this.clientesTableAdapter.Fill(this.dSCOCOA.Clientes);
            VerificaPermisos();
            LlenarCuadricula();
            errorProvider1.Clear();
        }

        private void LlenarCuadricula()
        {
            this.contactosClienteTableAdapter.FillBy(this.dSCOCOA.ContactosCliente, Convert.ToInt32(idClienteTextBox.Text));
        }

        private void VerificaPermisos()
        {
            if (DALPermisoRol.PuedeEditar(usuarioLogueado.IdRol, 2))
            {
                bindingNavigatorAddNewItem.Enabled = true;
                bindingNavigatorEdit.Enabled = true;
            }
            else
            {
                bindingNavigatorAddNewItem.Enabled = false;
                bindingNavigatorEdit.Enabled = false;
            }

            if (DALPermisoRol.PuedeEliminar(usuarioLogueado.IdRol, 2))
            {
                bindingNavigatorDeleteItem.Enabled = true;
            }
            else
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private void bindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            nitTextBox.ReadOnly = false;
            nombreClienteTextBox.ReadOnly = false;
            nombreContactoTextBox.ReadOnly = false;
            direccionTextBox.ReadOnly = false;
            idCiudadComboBox.Enabled = true;
            emailTextBox.ReadOnly = false;
            telefono1TextBox.ReadOnly = false;
            telefono2TextBox.ReadOnly = false;
            celularTextBox.ReadOnly = false;
            notasTextBox.ReadOnly = false;
            activoCheckBox.Enabled = true;
            contactosGroupBox.Enabled = true;

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
            busquedaCiudadButton.Enabled = true;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            clientesBindingSource.AddNew();
            nitTextBox.Focus();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            if (DALCotizacion.ClienteTieneCotizacion(Convert.ToInt32(idClienteTextBox.Text)))
            {
                MessageBox.Show("El Cliente tiene Cotizaciones", "No es posible eliminarlo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clientesBindingSource.RemoveAt(clientesBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
        }

        private void bindingNavigatorCancel_Click(object sender, EventArgs e)
        {
            this.clientesBindingSource.CancelEdit();
            DeshabilitarCampos();
            VerificaPermisos();
            errorProvider1.Clear();
        }

        private void bindingNavigatorSearch_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente miBusqueda = new frmBusquedaCliente();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDCliente == 0) return;
            int posicion = clientesBindingSource.Find("IDCliente", miBusqueda.IDCliente);
            clientesBindingSource.Position = posicion;
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

        private void bindingNavigatorPrint_Click(object sender, EventArgs e)
        {
            frmListadoClientes miForm = new frmListadoClientes();
            miForm.ShowDialog();
        }

        private void busquedaCiudadButton_Click(object sender, EventArgs e)
        {
            frmBusquedaCiudad miBusqueda = new frmBusquedaCiudad();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDCiudad == 0) return;
            int posicion = ciudadesBindingSource.Find("IDCiudad", miBusqueda.IDCiudad);
            ciudadesBindingSource.Position = posicion;
        }               

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactosBindingSource.EndEdit();
        }        

        private void cancelStripButton_Click(object sender, EventArgs e)
        {
            this.contactosBindingSource.CancelEdit();
        }

        private void contactosButton_Click(object sender, EventArgs e)
        {
            frmContactoCliente miForm = new frmContactoCliente();
            miForm.IDCliente = Convert.ToInt32(idClienteTextBox.Text);
            miForm.ShowDialog();
            this.contactosClienteTableAdapter.FillBy(this.dSCOCOA.ContactosCliente, Convert.ToInt32(idClienteTextBox.Text));
        }        

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            LlenarCuadricula();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            LlenarCuadricula();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            LlenarCuadricula();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            LlenarCuadricula();
        }                
    }
}
