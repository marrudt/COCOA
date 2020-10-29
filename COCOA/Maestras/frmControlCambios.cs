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
    public partial class frmControlCambios : Form
    {
        public frmControlCambios()
        {
            InitializeComponent();
        }

        private void versionamientoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.versionamientoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
        }

        private void frmControlCambios_Load(object sender, EventArgs e)
        {
            this.versionamientoTableAdapter.Fill(this.dSCOCOA.Versionamiento);
            AlternarColorFilas();
        }

        private void AlternarColorFilas()
        {
            versionamientoDataGridView.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            versionamientoDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            string version, cambio;


            version = "%" + versionToolStripTextBox.Text + "%";
            cambio = "%" + cambioToolStripTextBox.Text + "%";

            try
            {
                this.versionamientoTableAdapter.FillBy(this.dSCOCOA.Versionamiento, 
                    version, 
                    cambio);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
