using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COCOA.Seguridad
{
    public partial class frmAuditoria : Form
    {
        private DALUsuario usuarioLogueado;

        public DALUsuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }        

        public frmAuditoria()
        {
            InitializeComponent();
        }

        private void logBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.logBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCOCOA);
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            this.logTableAdapter.Fill(this.dSCOCOA.Log);
        }       
        
        private void borrarFiltrosbutton_Click(object sender, EventArgs e)
        {
            tipoToolStripTextBox.Text = "";
            nombreTablaToolStripTextBox.Text = "";
            nombreCampoToolStripTextBox.Text = "";
            antesToolStripTextBox.Text = "";
            despuesToolStripTextBox.Text = "";
            usuarioSistemaToolStripTextBox.Text = "";
            fillByToolStripButton_Click(sender, e);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            string tipo, tabla, campo, antes, despues, usuario;

            if (contengaRadioButton.Checked == true)
            {
                tipo = "%" + tipoToolStripTextBox.Text + "%";
                tabla = "%" + nombreTablaToolStripTextBox.Text + "%";
                campo = "%" + nombreTablaToolStripTextBox.Text + "%";
                antes = "%" + antesToolStripTextBox.Text + "%";
                despues = "%" + despuesToolStripTextBox.Text + "%";
                usuario = "%" + usuarioSistemaToolStripTextBox.Text + "%";
            }

            else if (empiezaRadioButton.Checked == true)
            {
                tipo = tipoToolStripTextBox.Text + "%";
                tabla = nombreTablaToolStripTextBox.Text + "%";
                campo = nombreTablaToolStripTextBox.Text + "%";
                antes = antesToolStripTextBox.Text + "%";
                despues = despuesToolStripTextBox.Text + "%";
                usuario = usuarioSistemaToolStripTextBox.Text + "%";
            }

            else if (terminaRadioButton.Checked == true)
            {
                tipo = "%" + tipoToolStripTextBox.Text;
                tabla = "%" + nombreTablaToolStripTextBox.Text;
                campo = "%" + nombreTablaToolStripTextBox.Text;
                antes = "%" + antesToolStripTextBox.Text;
                despues = "%" + despuesToolStripTextBox.Text;
                usuario = "%" + usuarioSistemaToolStripTextBox.Text;
            }

            else
            {
                tipo = tipoToolStripTextBox.Text;
                tabla = nombreTablaToolStripTextBox.Text;
                campo = nombreTablaToolStripTextBox.Text;
                antes = antesToolStripTextBox.Text;
                despues = despuesToolStripTextBox.Text;
                usuario = usuarioSistemaToolStripTextBox.Text;
            }
            try
            {
                this.logTableAdapter.FillBy(this.dSCOCOA.Log,
                    tipo,
                    tabla,
                    campo,
                    antes,
                    despues,
                    usuario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
