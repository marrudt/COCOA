using System;
using System.Windows.Forms;

namespace COCOA.Busqueda
{
    public partial class frmBusquedaCliente : Form
    {
        private int IdCliente;

        public int IDCliente
        {
            get => IdCliente;
        }

        public frmBusquedaCliente()
        {
            InitializeComponent();
        }

        private void frmBusquedaCliente_Load(object sender, EventArgs e)
        {
            this.ciudadesTableAdapter.Fill(this.dSCOCOA.Ciudades);
            this.departamentosTableAdapter.Fill(this.dSCOCOA.Departamentos);
            this.clientesTableAdapter.Fill(this.dSCOCOA.Clientes);

        }

        private void borrarFiltrosbutton_Click(object sender, EventArgs e)
        {
            nitToolStripTextBox.Text = "";
            nombreClienteToolStripTextBox.Text = "";
            nombreContactoToolStripTextBox.Text = "";
            emailToolStripTextBox.Text = "";
            fillBy1ToolStripButton_Click(sender, e);
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            IdCliente = 0;
            this.Close();
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            if (busquedaDataGridView.Rows.Count == 0)
            {
                IdCliente = 0;
            }
            else if (busquedaDataGridView.SelectedRows.Count != 0)
            {
                IdCliente = (int)busquedaDataGridView.SelectedRows[0].Cells[0].Value;
            }
            else
            {
                IdCliente = (int)busquedaDataGridView.Rows[0].Cells[0].Value;
            }
            this.Close();
        }        

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            string nit, nombreCliente, nombreContacto, email;

            if (contengaRadioButton.Checked == true)
            {
                nit = "%" + nitToolStripTextBox.Text + "%";
                nombreCliente = "%" + nombreClienteToolStripTextBox.Text + "%";
                nombreContacto = "%" + nombreContactoToolStripTextBox.Text + "%";
                email = "%" + emailToolStripTextBox.Text + "%";
            }

            else if (empiezaRadioButton.Checked == true)
            {
                nit = nitToolStripTextBox.Text + "%";
                nombreCliente = nombreClienteToolStripTextBox.Text + "%";
                nombreContacto = nombreContactoToolStripTextBox.Text + "%";
                email = emailToolStripTextBox.Text + "%";
            }

            else if (terminaRadioButton.Checked == true)
            {
                nit = "%" + nitToolStripTextBox.Text;
                nombreCliente = "%" + nombreClienteToolStripTextBox.Text;
                nombreContacto = "%" + nombreContactoToolStripTextBox.Text;
                email = "%" + emailToolStripTextBox.Text;
            }

            else
            {
                nit = nitToolStripTextBox.Text;
                nombreCliente = nombreClienteToolStripTextBox.Text;
                nombreContacto = nombreContactoToolStripTextBox.Text;
                email = emailToolStripTextBox.Text;
            }

            try
            {
                this.clientesTableAdapter.FillBy1(this.dSCOCOA.Clientes,
                    nit,
                    nombreCliente,
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
