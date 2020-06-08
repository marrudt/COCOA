using System;
using System.Windows.Forms;

namespace COCOA.Busqueda
{
    public partial class frmBusquedaProducto : Form
    {
        private int IdProducto;

        public int IDProducto
        {
          get { return IdProducto; }  
        }

        //public int IDProducto
        //{
        //    get => IdProducto;
        //}

        public frmBusquedaProducto()
        {
            InitializeComponent();
        }

        private void frmBusquedaProducto_Load(object sender, EventArgs e)
        {
            this.intervaloPreciosTableAdapter.Fill(this.dSCOCOA.IntervaloPrecios);
            this.pesoBrutoVhTableAdapter.Fill(this.dSCOCOA.PesoBrutoVh);
            this.numeroPasajerosTableAdapter.Fill(this.dSCOCOA.NumeroPasajeros);
            this.cilindrajesTableAdapter.Fill(this.dSCOCOA.Cilindrajes);
            this.segmentosTableAdapter.Fill(this.dSCOCOA.Segmentos);
            this.impoconsumoTableAdapter.Fill(this.dSCOCOA.Impoconsumo);
            this.iVATableAdapter.Fill(this.dSCOCOA.IVA);
            this.claseTableAdapter.Fill(this.dSCOCOA.Clase);
            this.tipoProductoTableAdapter.Fill(this.dSCOCOA.TipoProducto);
            this.productosTableAdapter.Fill(this.dSCOCOA.Productos);
        }

        private void borrarFiltrosbutton_Click(object sender, EventArgs e)
        {
            codigoProductoToolStripTextBox.Text = "";
            descripcionProductoToolStripTextBox.Text = "";
            fillByToolStripButton_Click(sender, e);
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            if (busquedaDataGridView.Rows.Count == 0)
            {
                IdProducto = 0;
            }
            else if (busquedaDataGridView.SelectedRows.Count != 0)
            {
                IdProducto = (int)busquedaDataGridView.SelectedRows[0].Cells[0].Value;
            }
            else
            {
                IdProducto = (int)busquedaDataGridView.Rows[0].Cells[0].Value;
            }
            this.Close();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            IdProducto = 0;
            this.Close();
        }        

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            string codigoProducto, descripcionProducto;

            if (contengaRadioButton.Checked == true)
            {
                codigoProducto = "%" + codigoProductoToolStripTextBox.Text + "%";
                descripcionProducto = "%" + descripcionProductoToolStripTextBox.Text + "%";
            }

            else if (empiezaRadioButton.Checked == true)
            {
                codigoProducto = codigoProductoToolStripTextBox.Text + "%";
                descripcionProducto = descripcionProductoToolStripTextBox.Text + "%";
            }

            else if (terminaRadioButton.Checked == true)
            {
                codigoProducto = "%" + codigoProductoToolStripTextBox.Text;
                descripcionProducto = "%" + descripcionProductoToolStripTextBox.Text;
            }

            else
            {
                codigoProducto = codigoProductoToolStripTextBox.Text;
                descripcionProducto = descripcionProductoToolStripTextBox.Text;
            }

            try
            {
                this.productosTableAdapter.FillBy(this.dSCOCOA.Productos,
                    codigoProducto,
                    descripcionProducto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
