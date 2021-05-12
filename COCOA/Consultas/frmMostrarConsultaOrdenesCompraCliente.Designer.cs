namespace COCOA.Consultas
{
    partial class frmMostrarConsultaOrdenesCompraCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrarConsultaOrdenesCompraCliente));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsConsultas = new COCOA.Consultas.dsConsultas();
            this.ConsultaOrdenesCompraClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConsultaOrdenesCompraClienteTableAdapter = new COCOA.Consultas.dsConsultasTableAdapters.ConsultaOrdenesCompraClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaOrdenesCompraClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ConsultaOrdenesCompraClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "COCOA.Consultas.ConsultaOrdenesCompraCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1445, 521);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsConsultas
            // 
            this.dsConsultas.DataSetName = "dsConsultas";
            this.dsConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ConsultaOrdenesCompraClienteBindingSource
            // 
            this.ConsultaOrdenesCompraClienteBindingSource.DataMember = "ConsultaOrdenesCompraCliente";
            this.ConsultaOrdenesCompraClienteBindingSource.DataSource = this.dsConsultas;
            // 
            // ConsultaOrdenesCompraClienteTableAdapter
            // 
            this.ConsultaOrdenesCompraClienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmMostrarConsultaOrdenesCompraCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 521);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMostrarConsultaOrdenesCompraCliente";
            this.Text = "Consulta Ordenes de Compra x Cliente";
            this.Load += new System.EventHandler(this.frmMostrarConsultaOrdenesCompraCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaOrdenesCompraClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ConsultaOrdenesCompraClienteBindingSource;
        private dsConsultas dsConsultas;
        private dsConsultasTableAdapters.ConsultaOrdenesCompraClienteTableAdapter ConsultaOrdenesCompraClienteTableAdapter;
    }
}