using COCOA.Listados;
using COCOA.Maestras;
using COCOA.Reportes;
using COCOA.Seguridad;
using COCOA.Transacciones;
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
            if (DALPermisoRol.PuedeVer(1, 1))
            {
                clientesToolStripMenuItem.Visible = true;
            }
            

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 2))
            {
                clientesToolStripMenuItem.Visible = true;
            }
            else
            {
                clientesToolStripMenuItem.Visible = false;
            }

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 1))
            {
                proveedoresToolStripMenuItem.Visible = true;
            }
            else
            {
                proveedoresToolStripMenuItem.Visible = false;
            }

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 7))
            {
                cilindrajeToolStripMenuItem1.Visible = true;
                
            }
            else
            {
                cilindrajeToolStripMenuItem1.Visible = false;
                
            }

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 8))
            {
                claseToolStripMenuItem1.Visible = true;
                
            }
            else
            {
                claseToolStripMenuItem1.Visible = false;
                
            }

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 9))
            {
                intervaloDePreciosToolStripMenuItem1.Visible = true;
                
            }
            else
            {
                intervaloDePreciosToolStripMenuItem1.Visible = false;
                
            }

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 10))
            {
                númeroDePasajerosToolStripMenuItem1.Visible = true;
                
            }
            else
            {
                númeroDePasajerosToolStripMenuItem1.Visible = false;
                
            }

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 11))
            {
                pesoBrutoVehicularToolStripMenuItem1.Visible = true;
                
            }
            else
            {
                pesoBrutoVehicularToolStripMenuItem1.Visible = false;
                
            }            

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 3))
            {
               
                productosToolStripMenuItem1.Visible = true;
            }
            else
            {
                
                productosToolStripMenuItem1.Visible = false;
            }

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 12))
            {
                segmentoToolStripMenuItem1.Visible = true;
                
            }
            else
            {
                segmentoToolStripMenuItem1.Visible = false;
                
            }

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 13))
            {
                tipoProductoToolStripMenuItem1.Visible = true;
                
            }
            else
            {
                tipoProductoToolStripMenuItem1.Visible = false;
                
            }

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 14))
            {
                impoconsumoToolStripMenuItem.Visible = true;
                impuestosToolStripMenuItem.Visible = true;
            }
            else
            {
                impoconsumoToolStripMenuItem.Visible = false;
                impuestosToolStripMenuItem.Visible = false;
            }

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 15))
            {
                iVAToolStripMenuItem1.Visible = true;
                impuestosToolStripMenuItem.Visible = true;
            }
            else
            {
                iVAToolStripMenuItem1.Visible = false;
                impuestosToolStripMenuItem.Visible = false;
            }

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 16))
            {
                formulariosToolStripMenuItem1.Visible = true;
                usuariosToolStripMenuItem.Visible = true;
            }
            else
            {
                formulariosToolStripMenuItem1.Visible = false;
                usuariosToolStripMenuItem.Visible = false;
            }

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 6))
            {
                permisosRolToolStripMenuItem.Visible = true;
                usuariosToolStripMenuItem.Visible = true;
            }
            else
            {
                permisosRolToolStripMenuItem.Visible = false;
                usuariosToolStripMenuItem.Visible = false;
            }

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 5))
            {
                rolToolStripMenuItem.Visible = true;
                usuariosToolStripMenuItem.Visible = true;
            }
            else
            {
                rolToolStripMenuItem.Visible = false;
                usuariosToolStripMenuItem.Visible = false;
            }

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 4))
            {
                usuariosToolStripMenuItem1.Visible = true;
                usuariosToolStripMenuItem.Visible = true;
            }
            else
            {
                usuariosToolStripMenuItem1.Visible = false;
                usuariosToolStripMenuItem.Visible = false;
            }

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 19))
            {
                cambioDeClaveToolStripMenuItem.Visible = true;
            }
            else
            {
                cambioDeClaveToolStripMenuItem.Visible = false;
            }

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 20))
            {
                cambioDeUsuarioToolStripMenuItem.Visible = true;
            }
            else
            {
                cambioDeUsuarioToolStripMenuItem.Visible = false;
            }

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 22))
            {
                cotizacionesToolStripMenuItem.Visible = true;
            }
            else
            {
                cotizacionesToolStripMenuItem.Visible = false;
            }

            if (DALPermisoRol.PuedeVer(usuarioLogueado.IdRol, 21))
            {
                ordenesDeCompraToolStripMenuItem.Visible = true;
            }
            else
            {
                ordenesDeCompraToolStripMenuItem.Visible = false;
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
            frmProductos miForm = new frmProductos();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void formulariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFormulario miForm = new frmFormulario();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCotizaciones miForm = new frmCotizaciones();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void ordenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdenCompras miForm = new frmOrdenCompras();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void productosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmListadoProductos miForm = new frmListadoProductos();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void cotizacionesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmReporteCotizacion miForm = new frmReporteCotizacion();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void cotizacionesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmListadoCotizaciones miForm = new frmListadoCotizaciones();
            miForm.MdiParent = this;
            miForm.Show();
        }
    }
}
