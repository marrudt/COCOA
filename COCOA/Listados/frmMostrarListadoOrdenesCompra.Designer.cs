namespace COCOA.Listados
{
    partial class frmMostrarListadoOrdenesCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrarListadoOrdenesCompra));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSListados = new COCOA.Listados.DSListados();
            this.ListadoOrdenesCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListadoOrdenesCompraTableAdapter = new COCOA.Listados.DSListadosTableAdapters.ListadoOrdenesCompraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSListados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoOrdenesCompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ListadoOrdenesCompraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "COCOA.Listados.ListadoOrdenesCompra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1395, 594);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSListados
            // 
            this.DSListados.DataSetName = "DSListados";
            this.DSListados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ListadoOrdenesCompraBindingSource
            // 
            this.ListadoOrdenesCompraBindingSource.DataMember = "ListadoOrdenesCompra";
            this.ListadoOrdenesCompraBindingSource.DataSource = this.DSListados;
            // 
            // ListadoOrdenesCompraTableAdapter
            // 
            this.ListadoOrdenesCompraTableAdapter.ClearBeforeFill = true;
            // 
            // frmMostrarListadoOrdenesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 594);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMostrarListadoOrdenesCompra";
            this.Text = "Listado Ordenes de Compra";
            this.Load += new System.EventHandler(this.frmMostrarListadoOrdenesCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSListados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoOrdenesCompraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ListadoOrdenesCompraBindingSource;
        private DSListados DSListados;
        private DSListadosTableAdapters.ListadoOrdenesCompraTableAdapter ListadoOrdenesCompraTableAdapter;
    }
}