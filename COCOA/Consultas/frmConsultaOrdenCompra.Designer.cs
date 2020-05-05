namespace COCOA.Consultas
{
    partial class frmConsultaOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaOrdenCompra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.filtroGroupBox = new System.Windows.Forms.GroupBox();
            this.busquedaProveedorButton = new System.Windows.Forms.Button();
            this.ordenCompraNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.proveedorComboBox = new System.Windows.Forms.ComboBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCOCOA = new COCOA.DSCOCOA();
            this.ordenCompraRadioButton = new System.Windows.Forms.RadioButton();
            this.proveedorRadioButton = new System.Windows.Forms.RadioButton();
            this.verReporteButton = new System.Windows.Forms.Button();
            this.proveedoresTableAdapter = new COCOA.DSCOCOATableAdapters.ProveedoresTableAdapter();
            this.panel1.SuspendLayout();
            this.filtroGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordenCompraNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1374, 573);
            this.panel1.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1370, 569);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // filtroGroupBox
            // 
            this.filtroGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.filtroGroupBox.Controls.Add(this.busquedaProveedorButton);
            this.filtroGroupBox.Controls.Add(this.ordenCompraNumericUpDown);
            this.filtroGroupBox.Controls.Add(this.proveedorComboBox);
            this.filtroGroupBox.Controls.Add(this.ordenCompraRadioButton);
            this.filtroGroupBox.Controls.Add(this.proveedorRadioButton);
            this.filtroGroupBox.Location = new System.Drawing.Point(8, 3);
            this.filtroGroupBox.Name = "filtroGroupBox";
            this.filtroGroupBox.Size = new System.Drawing.Size(792, 65);
            this.filtroGroupBox.TabIndex = 6;
            this.filtroGroupBox.TabStop = false;
            this.filtroGroupBox.Text = "Filtros";
            // 
            // busquedaProveedorButton
            // 
            this.busquedaProveedorButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.busquedaProveedorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaProveedorButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.busquedaProveedorButton.Location = new System.Drawing.Point(705, 22);
            this.busquedaProveedorButton.Name = "busquedaProveedorButton";
            this.busquedaProveedorButton.Size = new System.Drawing.Size(63, 23);
            this.busquedaProveedorButton.TabIndex = 5;
            this.busquedaProveedorButton.Text = "Buscar";
            this.busquedaProveedorButton.UseVisualStyleBackColor = false;
            this.busquedaProveedorButton.Visible = false;
            this.busquedaProveedorButton.Click += new System.EventHandler(this.busquedaProveedorButton_Click);
            // 
            // ordenCompraNumericUpDown
            // 
            this.ordenCompraNumericUpDown.Location = new System.Drawing.Point(248, 25);
            this.ordenCompraNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.ordenCompraNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ordenCompraNumericUpDown.Name = "ordenCompraNumericUpDown";
            this.ordenCompraNumericUpDown.Size = new System.Drawing.Size(103, 20);
            this.ordenCompraNumericUpDown.TabIndex = 4;
            this.ordenCompraNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ordenCompraNumericUpDown.Visible = false;
            // 
            // proveedorComboBox
            // 
            this.proveedorComboBox.DataSource = this.proveedoresBindingSource;
            this.proveedorComboBox.DisplayMember = "NombreProveedor";
            this.proveedorComboBox.FormattingEnabled = true;
            this.proveedorComboBox.Location = new System.Drawing.Point(357, 24);
            this.proveedorComboBox.Name = "proveedorComboBox";
            this.proveedorComboBox.Size = new System.Drawing.Size(342, 21);
            this.proveedorComboBox.TabIndex = 3;
            this.proveedorComboBox.ValueMember = "IdProveedor";
            this.proveedorComboBox.Visible = false;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.dSCOCOA;
            // 
            // dSCOCOA
            // 
            this.dSCOCOA.DataSetName = "DSCOCOA";
            this.dSCOCOA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordenCompraRadioButton
            // 
            this.ordenCompraRadioButton.AutoSize = true;
            this.ordenCompraRadioButton.Location = new System.Drawing.Point(134, 25);
            this.ordenCompraRadioButton.Name = "ordenCompraRadioButton";
            this.ordenCompraRadioButton.Size = new System.Drawing.Size(108, 17);
            this.ordenCompraRadioButton.TabIndex = 2;
            this.ordenCompraRadioButton.Text = "Orden de Compra";
            this.ordenCompraRadioButton.UseVisualStyleBackColor = true;
            this.ordenCompraRadioButton.CheckedChanged += new System.EventHandler(this.ordenCompraRadioButton_CheckedChanged);
            // 
            // proveedorRadioButton
            // 
            this.proveedorRadioButton.AutoSize = true;
            this.proveedorRadioButton.Location = new System.Drawing.Point(38, 25);
            this.proveedorRadioButton.Name = "proveedorRadioButton";
            this.proveedorRadioButton.Size = new System.Drawing.Size(74, 17);
            this.proveedorRadioButton.TabIndex = 1;
            this.proveedorRadioButton.Text = "Proveedor";
            this.proveedorRadioButton.UseVisualStyleBackColor = true;
            this.proveedorRadioButton.CheckedChanged += new System.EventHandler(this.proveedorRadioButton_CheckedChanged);
            // 
            // verReporteButton
            // 
            this.verReporteButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.verReporteButton.Enabled = false;
            this.verReporteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verReporteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.verReporteButton.Location = new System.Drawing.Point(806, 21);
            this.verReporteButton.Name = "verReporteButton";
            this.verReporteButton.Size = new System.Drawing.Size(134, 30);
            this.verReporteButton.TabIndex = 5;
            this.verReporteButton.Text = "Ver Orden Compra";
            this.verReporteButton.UseVisualStyleBackColor = false;
            this.verReporteButton.Click += new System.EventHandler(this.verReporteButton_Click);
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // frmConsultaOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1374, 647);
            this.Controls.Add(this.filtroGroupBox);
            this.Controls.Add(this.verReporteButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaOrdenCompra";
            this.Text = "Consulta Orden de Compra";
            this.Load += new System.EventHandler(this.frmConsultaOrdenCompra_Load);
            this.panel1.ResumeLayout(false);
            this.filtroGroupBox.ResumeLayout(false);
            this.filtroGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordenCompraNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.GroupBox filtroGroupBox;
        private System.Windows.Forms.Button busquedaProveedorButton;
        private System.Windows.Forms.NumericUpDown ordenCompraNumericUpDown;
        private System.Windows.Forms.ComboBox proveedorComboBox;
        private System.Windows.Forms.RadioButton ordenCompraRadioButton;
        private System.Windows.Forms.RadioButton proveedorRadioButton;
        private System.Windows.Forms.Button verReporteButton;
        private DSCOCOA dSCOCOA;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private DSCOCOATableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
    }
}