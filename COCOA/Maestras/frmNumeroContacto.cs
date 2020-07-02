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
    public partial class frmNumeroContacto : Form
    {
        public frmNumeroContacto()
        {
            InitializeComponent();
        }

        private void numeroContactoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.numeroContactoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);

        }

        private void frmNumeroContacto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSCOCOA.NumeroContacto' table. You can move, or remove it, as needed.
            this.numeroContactoTableAdapter.Fill(this.dSCOCOA.NumeroContacto);

        }
    }
}
