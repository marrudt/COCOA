using COCOA.Clases;
using System;
using System.Windows.Forms;

namespace COCOA.Listados
{
    public partial class frmListadoProveedores : Form
    {
        public frmListadoProveedores()
        {
            InitializeComponent();
        }

        private void generarButton_Click(object sender, EventArgs e)
        {
            frmMostrarListadoProveedores ListadoProveedores = new frmMostrarListadoProveedores();
            ListadoProveedores.Nit = nitTextBox.Text;

            ListadoProveedores.ShowDialog();
        }

        private void nitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }
    }
}
