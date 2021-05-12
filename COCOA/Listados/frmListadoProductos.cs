using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOA.Listados
{
    public partial class frmListadoProductos : Form
    {
        public frmListadoProductos()
        {
            InitializeComponent();
        }

        private void generarButton_Click(object sender, EventArgs e)
        {
            frmMostrarListadoProductos ListadoProductos = new frmMostrarListadoProductos();
            ListadoProductos.CodigoProducto = codigoTextBox.Text;
            ListadoProductos.DescripcionProducto = descripcionTextBox.Text;

            ListadoProductos.ShowDialog();
        }
    }
}
