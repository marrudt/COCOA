using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void nuevoButton_Click(object sender, EventArgs e)
        {
            if(descripcionTextBox.Text == string.Empty)
            {
                mensajeLabel.Text = "Ingrese una Descripción";
                descripcionTextBox.Focus();
                return;
            }
            mensajeLabel.Text = string.Empty;

            DALCapacidadCarga.Insert(descripcionTextBox.Text, activoCheckBox.Checked);
            CapacidadCargaGridview.DataBind();
            descripcionTextBox.Text = string.Empty;
            activoCheckBox.Checked = false;
            descripcionTextBox.Focus();
        }
    }
}