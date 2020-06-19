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
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
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
            if (usuarioComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(usuarioComboBox, "Ingrese Usuario");
                usuarioComboBox.Focus();
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

            if (DALUsuario.ValidarUsuario(usuarioComboBox.Text, passwordTextBox.Text))
            {
                MessageBox.Show("Usuario o Contraseña no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuarioComboBox.Text = "";
                passwordTextBox.Text = "";
                usuarioComboBox.Focus();
                return;
            }

            UsuarioLogueado = DALUsuario.GetUsuario(usuarioComboBox.Text);
            this.Close();
        }

        private void frmCambioUsuario_Load(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.Fill(this.dSCOCOA.Usuarios);
            usuarioComboBox.SelectedIndex = -1;
            usuarioComboBox.Focus();
        }
    }
}
