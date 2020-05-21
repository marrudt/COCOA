using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOA.Busqueda
{
    public partial class frmBusquedaCiudad : Form
    {
        private int IdCiudad;

        public int IDCiudad
        {
            get => IdCiudad;
        }

        public frmBusquedaCiudad()
        {
            InitializeComponent();
        }

        private void ciudadesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ciudadesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);

        }

        private void frmBusquedaCiudad_Load(object sender, EventArgs e)
        {
            this.ciudadesTableAdapter.Fill(this.dSCOCOA.Ciudades);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            string codigo, descripcion;

            if (contengaRadioButton.Checked == true)
            {
                codigo = "%" + codigoCiudadToolStripTextBox.Text + "%";
                descripcion = "%" + descripcionCiudadToolStripTextBox.Text + "%";                
            }

            else if (empiezaRadioButton.Checked == true)
            {
                codigo = codigoCiudadToolStripTextBox.Text + "%";
                descripcion = descripcionCiudadToolStripTextBox.Text + "%";                
            }

            else if (terminaRadioButton.Checked == true)
            {
                codigo = "%" + codigoCiudadToolStripTextBox.Text;
                descripcion = "%" + descripcionCiudadToolStripTextBox.Text;                
            }

            else
            {
                codigo = codigoCiudadToolStripTextBox.Text;
                descripcion = descripcionCiudadToolStripTextBox.Text;                
            }

            try
            {
                this.ciudadesTableAdapter.FillBy(this.dSCOCOA.Ciudades,
                    codigo,
                    descripcion);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }           

        }

        private void borrarFiltrosbutton_Click(object sender, EventArgs e)
        {
            codigoCiudadToolStripTextBox.Text = "";
            descripcionCiudadToolStripTextBox.Text = "";            
            fillByToolStripButton_Click(sender, e);
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            if (busquedaCiudadesDataGridView.Rows.Count == 0)
            {
                IdCiudad = 0;
            }
            else if (busquedaCiudadesDataGridView.SelectedRows.Count != 0)
            {
                IdCiudad = (int)busquedaCiudadesDataGridView.SelectedRows[0].Cells[0].Value;
            }
            else
            {
                IdCiudad = (int)busquedaCiudadesDataGridView.Rows[0].Cells[0].Value;
            }
            this.Close();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            IdCiudad = 0;
            this.Close();
        }
    }
}
