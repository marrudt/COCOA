namespace COCOA.Listados
{
    partial class frmListadoCotizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoCotizaciones));
            this.sp_listado_resumen_cotizacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSListados = new COCOA.Listados.DSListados();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_listado_resumen_cotizacionesTableAdapter = new COCOA.Listados.DSListadosTableAdapters.sp_listado_resumen_cotizacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_listado_resumen_cotizacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSListados)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_listado_resumen_cotizacionesBindingSource
            // 
            this.sp_listado_resumen_cotizacionesBindingSource.DataMember = "sp_listado_resumen_cotizaciones";
            this.sp_listado_resumen_cotizacionesBindingSource.DataSource = this.DSListados;
            // 
            // DSListados
            // 
            this.DSListados.DataSetName = "DSListados";
            this.DSListados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSListados";
            reportDataSource1.Value = this.sp_listado_resumen_cotizacionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "COCOA.Listados.ListadoCotizacionesResumen.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1357, 598);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // sp_listado_resumen_cotizacionesTableAdapter
            // 
            this.sp_listado_resumen_cotizacionesTableAdapter.ClearBeforeFill = true;
            // 
            // frmListadoCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1357, 598);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoCotizaciones";
            this.Text = "Listado Resumen Cotizaciones";
            this.Load += new System.EventHandler(this.frmListadoCotizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_listado_resumen_cotizacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSListados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_listado_resumen_cotizacionesBindingSource;
        private DSListados DSListados;
        private DSListadosTableAdapters.sp_listado_resumen_cotizacionesTableAdapter sp_listado_resumen_cotizacionesTableAdapter;
    }
}