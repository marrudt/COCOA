using COCOA.Clases;
using System;
using System.Windows.Forms;

namespace COCOA.Consultas
{
    public partial class frmConsultaItemByProveedor : Form
    {
        public frmConsultaItemByProveedor()
        {
            InitializeComponent();
        }       
            
        private void generarButton_Click(object sender, EventArgs e)
        {           
            frmMostrarConsultaItemByProveedor ConsultaItem = new frmMostrarConsultaItemByProveedor();
            ConsultaItem.IdProducto = itemTextBox.Text;
            ConsultaItem.NombreProveedor = proveedorTextBox.Text;
            ConsultaItem.DescripcionProducto = productoTextBox.Text;
                     
            ConsultaItem.ShowDialog();            
        }

        private void itemTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }
    }
}
