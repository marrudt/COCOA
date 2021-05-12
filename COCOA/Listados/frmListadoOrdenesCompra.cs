using COCOA.Clases;
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
    public partial class frmListadoOrdenesCompra : Form
    {
        public frmListadoOrdenesCompra()
        {
            InitializeComponent();
        }

        private void generarListadoButton_Click(object sender, EventArgs e)
        {
            frmMostrarListadoOrdenesCompra ListadoOrdenesCompra = new frmMostrarListadoOrdenesCompra();
            ListadoOrdenesCompra.FechaInicial = fechaInicialTimePicker.Value;
            ListadoOrdenesCompra.FechaFinal = fechaFinalTimePicker.Value;
            ListadoOrdenesCompra.NitEntidad = nitEntidadTextBox.Text;
            ListadoOrdenesCompra.NitProveedor = nitProveedorTextBox.Text;

            ListadoOrdenesCompra.ShowDialog();
        }

        private void nitEntidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }

        private void nitProveedorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }
    }
}
