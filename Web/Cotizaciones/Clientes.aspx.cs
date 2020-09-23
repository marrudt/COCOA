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
    public partial class Formulario_web11 : System.Web.UI.Page
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

            DALCliente miCliente = DALCliente.GetClienteByNit(nitTextBox.Text);
            if(miCliente == null)
            {
                mensajeLabel.Text = "Cliente no existe";
                LimpiarCampos();
                return;
            }

            nombreClienteTextBox.Text = miCliente.NombreCliente;
            nombreContactoTextBox.Text = miCliente.NombreContacto;
            direccionTextBox.Text = miCliente.Direccion;
            emailTextBox.Text = miCliente.Email;
            telefono1TextBox.Text = miCliente.Telefono1;
            telefono2TextBox.Text = miCliente.Telefono2;
            celularTextBox.Text = miCliente.Celular;
            ciudadDropDownList.Text = miCliente.IdCiudad.ToString();
            activoCheckBox.Checked = miCliente.Activo;
        }

        private void LimpiarCampos()
        {
            nitTextBox.Text = string.Empty;
            nombreClienteTextBox.Text = string.Empty;
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

        protected void modificarButton_Click(object sender, EventArgs e)
        {
            if(!ValidarCampos()) return;
            DALCliente miCliente = DALCliente.GetClienteByNit(nitTextBox.Text);
            if(miCliente == null)
            {
                mensajeLabel.Text = "Cliente no existe";
                nitTextBox.Focus();
                return;
            }

            DALCliente.UpdateCliente(
                nitTextBox.Text,
                nombreClienteTextBox.Text,
                nombreContactoTextBox.Text,
                direccionTextBox.Text,
                Convert.ToInt32(ciudadDropDownList.Text),
                telefono1TextBox.Text,
                telefono2TextBox.Text,
                celularTextBox.Text,
                emailTextBox.Text,
                notasTextBox.Text,
                activoCheckBox.Checked,
                miCliente.IdCliente);
            clientesGridView.DataBind();
            mensajeLabel.Text = "Cliente actualizado";
        }

        private bool ValidarCampos()
        {
            if(nitTextBox.Text == string.Empty)
            {
                mensajeLabel.Text = "El campo Nit es obligatorio";
                nitTextBox.Focus();
                return false;
            }

            if(nombreClienteTextBox.Text == string.Empty)
            {
                mensajeLabel.Text = "El campo Nombre es obligatorio";
                nombreClienteTextBox.Focus();
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

        protected void nuevoButton_Click(object sender, EventArgs e)
        {
            if(!ValidarCampos()) return;

            DALCliente miCliente = DALCliente.GetClienteByNit(nitTextBox.Text);
            if(miCliente != null)
            {
                mensajeLabel.Text = "Cliente ya existe";
                nitTextBox.Focus();
                return;
            }

            DALCliente.InsertCliente(
                nitTextBox.Text,
                nombreClienteTextBox.Text,
                nombreContactoTextBox.Text,
                direccionTextBox.Text,
                Convert.ToInt32(ciudadDropDownList.Text),
                telefono1TextBox.Text,
                telefono2TextBox.Text,
                celularTextBox.Text,
                emailTextBox.Text,
                notasTextBox.Text,
                activoCheckBox.Checked);
            clientesGridView.DataBind();
            mensajeLabel.Text = "Cliente creado";
        }

        protected void eliminarButton_Click(object sender, EventArgs e)
        {
            if(nitTextBox.Text == string.Empty)
            {
                mensajeLabel.Text = "El campo Nit es obligatorio";
                nitTextBox.Focus();
                return;
            }

            DALCliente miCliente = DALCliente.GetClienteByNit(nitTextBox.Text);
            if(miCliente == null)
            {
                mensajeLabel.Text = "Cliente no existe";
                nitTextBox.Focus();
                return;
            }

            DALCliente.DeleteCliente(miCliente.IdCliente);
            clientesGridView.DataBind();
            mensajeLabel.Text = "Cliente eliminado";
            LimpiarCampos();
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            mensajeLabel.Text = string.Empty;
        }

    }
}