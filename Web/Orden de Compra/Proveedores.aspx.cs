using COCOA.Clases;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Formulario_web12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void consultarButton_Click(object sender, EventArgs e)
        {
            if(nitTextBox.Text == string.Empty)
            {
                mensajeLabel.Text = "Ingrese un Nit";
                nitTextBox.Focus();
                return;
            }
            mensajeLabel.Text = string.Empty;

            DALProveedor miProveedor = DALProveedor.GetProveedorByNit(nitTextBox.Text);
            if(miProveedor == null)
            {
                mensajeLabel.Text = "Proveedor no existe";
                LimpiarCampos();
                return;
            }

            nombreProveedorTextBox.Text = miProveedor.NombreProveedor;
            nombreContactoTextBox.Text = miProveedor.NombreContacto;
            direccionTextBox.Text = miProveedor.Direccion;
            emailTextBox.Text = miProveedor.Email;
            telefono1TextBox.Text = miProveedor.Telefono1;
            telefono2TextBox.Text = miProveedor.Telefono2;
            celularTextBox.Text = miProveedor.Celular;
            ciudadDropDownList.Text = miProveedor.IdCiudad.ToString();
            activoCheckBox.Checked = miProveedor.Activo;
        }

        private void LimpiarCampos()
        {
            nitTextBox.Text = string.Empty;
            nombreProveedorTextBox.Text = string.Empty;
            nombreContactoTextBox.Text = string.Empty;
            direccionTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            telefono1TextBox.Text = string.Empty;
            telefono2TextBox.Text = string.Empty;
            celularTextBox.Text = string.Empty;
            ciudadDropDownList.SelectedIndex = -1;
            activoCheckBox.Checked = false;
            nitTextBox.Focus();
        }

        protected void editarButton_Click(object sender, EventArgs e)
        {
            if(!ValidarCampos()) return;
            DALProveedor miProveedor = DALProveedor.GetProveedorByNit(nitTextBox.Text);
            if(miProveedor == null)
            {
                mensajeLabel.Text = "Proveedor no existe";
                LimpiarCampos();
                return;
            }

            DALProveedor.UpdateProveedor(
                nitTextBox.Text,
                nombreProveedorTextBox.Text,
                nombreContactoTextBox.Text,
                direccionTextBox.Text,
                Convert.ToInt32(ciudadDropDownList.Text),
                telefono1TextBox.Text,
                telefono2TextBox.Text,
                celularTextBox.Text,
                emailTextBox.Text,
                notasTextBox.Text,
                activoCheckBox.Checked,
                miProveedor.IdProveedor);
            proveedoresGridView.DataBind();
            mensajeLabel.Text = "Proveedor actualizado";
        }

        private bool ValidarCampos()
        {
            if(nitTextBox.Text == string.Empty)
            {
                mensajeLabel.Text = "El campo Nit es obligatorio";
                nitTextBox.Focus();
                return false;
            }

            if(nombreProveedorTextBox.Text == string.Empty)
            {
                mensajeLabel.Text = "El campo Nombre es obligatorio";
                nombreProveedorTextBox.Focus();
                return false;
            }

            if(direccionTextBox.Text == string.Empty)
            {
                mensajeLabel.Text = "El campo Dirección es obligatorio";
                direccionTextBox.Focus();
                return false;
            }

            if(emailTextBox.Text == string.Empty)
            {
                mensajeLabel.Text = "El campo Email es obligatorio";
                emailTextBox.Focus();
                return false;
            }

            if(telefono1TextBox.Text == string.Empty)
            {
                mensajeLabel.Text = "El campo Teléfono 1 es obligatorio";
                telefono1TextBox.Focus();
                return false;
            }

            if(ciudadDropDownList.SelectedIndex == 0)
            {
                mensajeLabel.Text = "El campo Ciudad es obligatorio";
                ciudadDropDownList.Focus();
                return false;
            }

            if(emailTextBox.Text != string.Empty)
            {
                RegexUtilities miValidador = new RegexUtilities();
                if(!miValidador.IsValidEmail(emailTextBox.Text))
                {
                    mensajeLabel.Text = "El correo ingresado no es válido";
                    ciudadDropDownList.Focus();
                    return false;
                }
            }

            mensajeLabel.Text = string.Empty;
            return true;
        }

        protected void eliminarButton_Click(object sender, EventArgs e)
        {
            if(nitTextBox.Text == string.Empty)
            {
                mensajeLabel.Text = "El campo Nit es obligatorio";
                nitTextBox.Focus();
                return;
            }

            DALProveedor miProveedor = DALProveedor.GetProveedorByNit(nitTextBox.Text);
            if(miProveedor == null)
            {
                mensajeLabel.Text = "Proveedor no existe";
                LimpiarCampos();
                return;
            }

            DALProveedor.DeleteProveedor(miProveedor.IdProveedor);
            proveedoresGridView.DataBind();
            mensajeLabel.Text = "Proveedor eliminado";
            LimpiarCampos();
        }

        protected void crearButton_Click(object sender, EventArgs e)
        {
            if(!ValidarCampos()) return;

            DALProveedor miProveedor = DALProveedor.GetProveedorByNit(nitTextBox.Text);
            if(miProveedor != null)
            {
                mensajeLabel.Text = "Proveedor ya existe";
                LimpiarCampos();
                return;
            }

            DALProveedor.InsertProveedor(
                nitTextBox.Text,
                nombreProveedorTextBox.Text,
                nombreContactoTextBox.Text,
                direccionTextBox.Text,
                Convert.ToInt32(ciudadDropDownList.Text),
                telefono1TextBox.Text,
                telefono2TextBox.Text,
                celularTextBox.Text,
                emailTextBox.Text,
                notasTextBox.Text,
                activoCheckBox.Checked);
            proveedoresGridView.DataBind();
            mensajeLabel.Text = "Proveedor creado";
        }

        protected void nuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            mensajeLabel.Text = string.Empty;
        }
    }
}