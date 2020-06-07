using DAL;
using System;
using System.Windows.Forms;

namespace COCOA.Seguridad
{
    public partial class frmCambioClave : Form
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

        public frmCambioClave()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            if (claveAnteriorTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(claveAnteriorTextBox, "El campo Contraseña Anterior es obligatorio");
                claveAnteriorTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (claveAnteriorTextBox.Text != usuarioLogueado.Clave)
            {
                errorProvider1.SetError(claveAnteriorTextBox, "La Contraseña Anterior no es correcta");
                claveAnteriorTextBox.Focus();
                return;
            }

            if (nuevaClaveTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nuevaClaveTextBox, "El campo Nueva Contraseña es obligatorio");
                nuevaClaveTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (confirmarClaveTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(confirmarClaveTextBox, "El campo Confirmación Contraseña es obligatorio");
                confirmarClaveTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (nuevaClaveTextBox.Text != confirmarClaveTextBox.Text)
            {
                errorProvider1.SetError(nuevaClaveTextBox, "Las Contraseñas no coinciden");
                errorProvider1.SetError(confirmarClaveTextBox, "Las Contraseñas no coinciden");
                nuevaClaveTextBox.Focus();
                return;
            }

            DALUsuario.CambiarClave(nuevaClaveTextBox.Text, usuarioLogueado.IdUsuario);
            MessageBox.Show("Cambio de clave exitoso", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
