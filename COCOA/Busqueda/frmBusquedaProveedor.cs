using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOA.Maestras
{
    public partial class frmBusquedaProveedor : Form
    {
        private int IdProveedor;

        public int IDProveedor
        {
            get => IdProveedor;
        }

        public frmBusquedaProveedor()
        {
            InitializeComponent();
        }

        private void frmBusquedaProveedor_Load(object sender, EventArgs e)
        {
            this.ciudadesTableAdapter.Fill(this.dSCOCOA.Ciudades);
            this.departamentosTableAdapter.Fill(this.dSCOCOA.Departamentos);
            this.proveedoresTableAdapter.Fill(this.dSCOCOA.Proveedores);

        }        

        private void button1_Click(object sender, EventArgs e)
        {
            nitToolStripTextBox.Text = "";
            nombreProveedorToolStripTextBox.Text = "";
            nombreContactoToolStripTextBox.Text = "";
            emailToolStripTextBox.Text = "";
            fillByToolStripButton1_Click(sender, e);
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            IdProveedor = 0;
            this.Close();
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            if (busquedaDataGridView.Rows.Count == 0)
            {
                IdProveedor = 0;
            }
            else if (busquedaDataGridView.SelectedRows.Count != 0)
            {
                IdProveedor = (int)busquedaDataGridView.SelectedRows[0].Cells[0].Value;
            }
            else
            {
                IdProveedor = (int)busquedaDataGridView.Rows[0].Cells[0].Value;
            }
            this.Close();
        }        

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            string nit, nombreProveedor, nombreContacto, email;

            if (contengaRadioButton.Checked == true)
            {
                nit = "%" + nitToolStripTextBox.Text + "%";
                nombreProveedor = "%" + nombreProveedorToolStripTextBox.Text + "%";
                nombreContacto = "%" + nombreContactoToolStripTextBox.Text + "%";
                email = "%" + emailToolStripTextBox.Text + "%";
            }

            else if (empiezaRadioButton.Checked == true)
            {
                nit = nitToolStripTextBox.Text + "%";
                nombreProveedor = nombreProveedorToolStripTextBox.Text + "%";
                nombreContacto = nombreContactoToolStripTextBox.Text + "%";
                email = emailToolStripTextBox.Text + "%";
            }

            else if (terminaRadioButton.Checked == true)
            {
                nit = "%" + nitToolStripTextBox.Text;
                nombreProveedor = "%" + nombreProveedorToolStripTextBox.Text;
                nombreContacto = "%" + nombreContactoToolStripTextBox.Text;
                email = "%" + emailToolStripTextBox.Text;
            }

            else
            {
                nit = nitToolStripTextBox.Text;
                nombreProveedor = nombreProveedorToolStripTextBox.Text;
                nombreContacto = nombreContactoToolStripTextBox.Text;
                email = emailToolStripTextBox.Text;
            }

            try
            {
                this.proveedoresTableAdapter.FillBy(this.dSCOCOA.Proveedores,
                    nit,
                    nombreProveedor,
                    nombreContacto,
                    email);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
