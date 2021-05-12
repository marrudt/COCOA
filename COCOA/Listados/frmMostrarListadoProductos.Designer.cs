namespace COCOA.Listados
{
    partial class frmMostrarListadoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrarListadoProductos));
            this.ListadoProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSListados = new COCOA.Listados.DSListados();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ListadoProductosTableAdapter = new COCOA.Listados.DSListadosTableAdapters.ListadoProductosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSListados)).BeginInit();
            this.SuspendLayout();
            // 
            // ListadoProductosBindingSource
            // 
            this.ListadoProductosBindingSource.DataMember = "ListadoProductos";
            this.ListadoProductosBindingSource.DataSource = this.DSListados;
            // 
            // DSListados
            // 
            this.DSListados.DataSetName = "DSListados";
            this.DSListados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ListadoProductosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "COCOA.Listados.ListadoProductos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1377, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // ListadoProductosTableAdapter
            // 
            this.ListadoProductosTableAdapter.ClearBeforeFill = true;
            // 
            // frmMostrarListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 539);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMostrarListadoProductos";
            this.Text = "Listado Productos";
            this.Load += new System.EventHandler(this.frmMostrarListadoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSListados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ListadoProductosBindingSource;
        private DSListados DSListados;
        private DSListadosTableAdapters.ListadoProductosTableAdapter ListadoProductosTableAdapter;
    }
}