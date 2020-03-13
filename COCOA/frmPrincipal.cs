using COCOA.Maestras;
using COCOA.Seguridad;
using DAL;
using System;
using System.Windows.Forms;

namespace COCOA
{
    public partial class frmPrincipal : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes miForm = new frmClientes();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores miForm = new frmProveedores();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUsuarios miForm = new frmUsuarios();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            nombreUsuarioStripStatusLabel.Text = "Usuario actual: " + usuarioLogueado.Nombres;
            VerificarPermisos();
        }

        private void VerificarPermisos()
        {
            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 1))
            {
                proveedoresToolStripMenuItem.Visible = true;
            }
            else
            {
                proveedoresToolStripMenuItem.Visible = false;
            }
        }

        private void cambioDeClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioClave miForm = new frmCambioClave();
            miForm.UsuarioLogueado = this.usuarioLogueado;
            miForm.ShowDialog();
        }

        private void cambioDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioUsuario miForm = new frmCambioUsuario();
            miForm.ShowDialog();
            if (miForm.UsuarioLogueado != null)
            {
                this.usuarioLogueado = miForm.UsuarioLogueado;
                nombreUsuarioStripStatusLabel.Text = "Usuario actual: " + usuarioLogueado.Nombres;
                VerificarPermisos();
            }
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRol miForm = new frmRol();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void permisosRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPermisoRol miForm = new frmPermisoRol();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void cilindrajeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCilindraje miForm = new frmCilindraje();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void claseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmClase miForm = new frmClase();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void númeroDePasajerosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNumeroPasajeros miForm = new frmNumeroPasajeros();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void pesoBrutoVehicularToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPesoBrutoVehicular miForm = new frmPesoBrutoVehicular();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void segmentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSegmento miForm = new frmSegmento();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void tipoProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTipoProducto miForm = new frmTipoProducto();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void intervaloDePreciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmIntervaloPrecio miForm = new frmIntervaloPrecio();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void impoconsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImpoconsumo miForm = new frmImpoconsumo();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void iVAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmIVA miForm = new frmIVA();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProducto miForm = new frmProducto();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void formulariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFormulario miForm = new frmFormulario();
            miForm.MdiParent = this;
            miForm.Show();
        }
    }
}
