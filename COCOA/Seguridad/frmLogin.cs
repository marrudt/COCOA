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

namespace COCOA
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if(usuarioTextBox.Text == "")
            {
                errorProvider1.SetError(usuarioTextBox,"Ingrese Usuario");
                usuarioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (passwordTextBox.Text == "")
            {
                errorProvider1.SetError(passwordTextBox, "Ingrese Contraseña");
                passwordTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (DALUsuario.ValidarUsuario(usuarioTextBox.Text, passwordTextBox.Text))
            {
                MessageBox.Show("Usuario o Contraseña no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuarioTextBox.Text = "";
                passwordTextBox.Text = "";
                usuarioTextBox.Focus();
                return;
            }

            frmPrincipal miForm = new frmPrincipal();
            miForm.Show();
            this.Hide();
        }
    }
}
