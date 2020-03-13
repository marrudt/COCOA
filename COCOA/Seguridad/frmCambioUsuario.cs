using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Seguridad
{
    public partial class frmCambioUsuario : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmCambioUsuario()
        {
            InitializeComponent();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            usuarioLogueado = null;
            this.Close();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == "")
            {
                errorProvider1.SetError(usuarioTextBox, "Ingrese Usuario");
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

            UsuarioLogueado = DALUsuario.GetUsuario(usuarioTextBox.Text);
            this.Close();
        }
    }
}
