namespace COCOA.Listados
{
    partial class frmMostrarListadoProveedores
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
            this.ListadoProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSListados = new COCOA.Listados.DSListados();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ListadoProveedoresTableAdapter = new COCOA.Listados.DSListadosTableAdapters.ListadoProveedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSListados)).BeginInit();
            this.SuspendLayout();
            // 
            // ListadoProveedoresBindingSource
            // 
            this.ListadoProveedoresBindingSource.DataMember = "ListadoProveedores";
            this.ListadoProveedoresBindingSource.DataSource = this.DSListados;
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
            reportDataSource1.Value = this.ListadoProveedoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "COCOA.Listados.ListadoProveedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1360, 592);
            this.reportViewer1.TabIndex = 0;
            // 
            // ListadoProveedoresTableAdapter
            // 
            this.ListadoProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // frmMostrarListadoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 592);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMostrarListadoProveedores";
            this.Text = "frmMostrarListadoProveedores";
            this.Load += new System.EventHandler(this.frmMostrarListadoProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSListados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ListadoProveedoresBindingSource;
        private DSListados DSListados;
        private DSListadosTableAdapters.ListadoProveedoresTableAdapter ListadoProveedoresTableAdapter;
    }
}