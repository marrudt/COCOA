namespace COCOA.Consultas
{
    partial class frmMostrarConsultaItemByProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrarConsultaItemByProveedor));
            this.ConsultaItemsByProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsConsultas = new COCOA.Consultas.dsConsultas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ConsultaItemsByProveedorTableAdapter = new COCOA.Consultas.dsConsultasTableAdapters.ConsultaItemsByProveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaItemsByProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultaItemsByProveedorBindingSource
            // 
            this.ConsultaItemsByProveedorBindingSource.DataMember = "ConsultaItemsByProveedor";
            this.ConsultaItemsByProveedorBindingSource.DataSource = this.dsConsultas;
            // 
            // dsConsultas
            // 
            this.dsConsultas.DataSetName = "dsConsultas";
            this.dsConsultas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ConsultaItemsByProveedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "COCOA.Consultas.ConsultaItemByProveedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1433, 500);
            this.reportViewer1.TabIndex = 0;
            // 
            // ConsultaItemsByProveedorTableAdapter
            // 
            this.ConsultaItemsByProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // frmMostrarConsultaItemByProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1433, 500);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMostrarConsultaItemByProveedor";
            this.Text = "Consulta Item x Proveedor";
            this.Load += new System.EventHandler(this.frmMostrarConsultaItemByProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaItemsByProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ConsultaItemsByProveedorBindingSource;
        private dsConsultas dsConsultas;
        private dsConsultasTableAdapters.ConsultaItemsByProveedorTableAdapter ConsultaItemsByProveedorTableAdapter;
    }
}