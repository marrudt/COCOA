using COCOA.Maestras;
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
    public partial class frmPrincipal : Form
    {
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
            miForm.Show();
        }

        private void cilindrajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCilindraje miForm = new frmCilindraje();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void impoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImpoconsumo miForm = new frmImpoconsumo();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void intervaloDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIntervaloPrecio miForm = new frmIntervaloPrecio();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void ivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIVA miForm = new frmIVA();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void númeroDePasajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNumeroPasajeros miForm = new frmNumeroPasajeros();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void pesoBrutoVehicularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesoBrutoVehicular miForm = new frmPesoBrutoVehicular();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto miForm = new frmProducto();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void claseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClase miForm = new frmClase();
            miForm.MdiParent = this;
            miForm.Show();
        }

        private void tipoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmTipoProducto miForm = new frmTipoProducto();
            miForm.MdiParent = this;
            miForm.Show();
        }
    }
}
