using COCOA.Clases;
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
    public partial class frmContactoCliente : Form
    {
        private int IdCliente;

        public int IDCliente
        {
            set { IdCliente = value; }
        }

        public frmContactoCliente()
        {
            InitializeComponent();
        }

        private void frmContactoCliente_Load(object sender, EventArgs e)
        {
            this.numeroContactoTableAdapter.Fill(this.dSCOCOA.NumeroContacto);
            this.contactosClienteTableAdapter.Fill(this.dSCOCOA.ContactosCliente);
            numeroContactoComboBox.SelectedIndex = -1;
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            if (numeroContactoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(numeroContactoComboBox, "Debe seleccionar una Número de Contacto");
                numeroContactoComboBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (nombreTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombreTextBox, "El campo nombre es Obligatorio");
                nombreTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (correoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(correoTextBox, "El campo correo es Obligatorio");
                correoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            RegexUtilities regexUtilities = new RegexUtilities();
            if (!regexUtilities.IsValidEmail(correoTextBox.Text))
            {
                errorProvider1.SetError(correoTextBox, "El formato de Correo no es válido");
                correoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (telefono1textBox.Text == string.Empty)
            {
                errorProvider1.SetError(telefono1textBox, "Debe ingresar mínimo un Número Telefónico");
                telefono1textBox.Focus();
                return;
            }
            errorProvider1.Clear();

            DALContactosCliente.UpdateContactoCliente(
                (int)numeroContactoComboBox.SelectedValue,
                IdCliente,
                nombreTextBox.Text,
                CargoTextBox.Text,
                correoTextBox.Text,
                celularTextBox.Text,
                telefono1textBox.Text,
                ext1TextBox.Text,
                telefono2TextBox.Text,
                ext2TextBox.Text,
                notasTextBox.Text,
                activocheckBox.Checked);
            this.Close();

            MessageBox.Show(string.Format("Contacto Guardado"), "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void telefono1textBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ext1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }

        private void ext2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }

        private void idContactoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numeroContactoComboBox.SelectedIndex == -1) return;

            DALContactosCliente miContactoCliente = DALContactosCliente.GetContactoClienteByIdNumeroContactoAndIdCliente((int)numeroContactoComboBox.SelectedValue, IdCliente);

            if (miContactoCliente == null)
            {
                nombreTextBox.Text = string.Empty;
                CargoTextBox.Text = string.Empty;
                correoTextBox.Text = string.Empty;
                telefono1textBox.Text = string.Empty;
                ext1TextBox.Text = string.Empty;
                telefono2TextBox.Text = string.Empty;
                ext2TextBox.Text = string.Empty;
                celularTextBox.Text = string.Empty;
                notasTextBox.Text = string.Empty;
                activocheckBox.Checked = true;
            }
            else
            {
                nombreTextBox.Text = miContactoCliente.NombreContacto;
                CargoTextBox.Text = miContactoCliente.CargoContacto;
                correoTextBox.Text = miContactoCliente.CorreoContacto;
                telefono1textBox.Text = miContactoCliente.Telefono1Contacto;
                ext1TextBox.Text = miContactoCliente.Ext1Contacto;
                telefono2TextBox.Text = miContactoCliente.Telefono2Contacto;
                ext2TextBox.Text = miContactoCliente.Ext2Contacto;
                celularTextBox.Text = miContactoCliente.CelularContacto;
                notasTextBox.Text = miContactoCliente.Notas;
                activocheckBox.Checked = miContactoCliente.Activo;
            }
        }
    }
}
