using COCOA.Clases;
using System;
using System.Windows.Forms;

namespace COCOA.Listados
{
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        private void generarButton_Click(object sender, EventArgs e)
        {
            frmMostrarListadoClientes ListadoClientes = new frmMostrarListadoClientes();
            ListadoClientes.Nit = nitTextBox.Text;

            ListadoClientes.ShowDialog();
        }

        private void nitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }
    }
}
