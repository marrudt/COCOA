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

namespace COCOA.Consultas
{
    public partial class frmConsultaOrdenesCompraCliente : Form
    {
        public frmConsultaOrdenesCompraCliente()
        {
            InitializeComponent();
        }

        private void consultarButton_Click(object sender, EventArgs e)
        {

            frmMostrarConsultaOrdenesCompraCliente ConsultaCliente = new frmMostrarConsultaOrdenesCompraCliente();
            ConsultaCliente.Nit = nitTextBox.Text;

            ConsultaCliente.ShowDialog();
        }

        private void nitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }
    }
}
