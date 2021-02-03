namespace COCOA.Reportes
{
    partial class frmReporteCotizacionAccesorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteCotizacionAccesorios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.filtroGroupBox = new System.Windows.Forms.GroupBox();
            this.busquedaClienteButton = new System.Windows.Forms.Button();
            this.cotizacionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.cotizacionRadioButton = new System.Windows.Forms.RadioButton();
            this.clienteRadioButton = new System.Windows.Forms.RadioButton();
            this.verReporteButton = new System.Windows.Forms.Button();
            this.dSCOCOA = new COCOA.DSCOCOA();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new COCOA.DSCOCOATableAdapters.ClientesTableAdapter();
            this.panel1.SuspendLayout();
            this.filtroGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1373, 575);
            this.panel1.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1373, 575);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // filtroGroupBox
            // 
            this.filtroGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.filtroGroupBox.Controls.Add(this.busquedaClienteButton);
            this.filtroGroupBox.Controls.Add(this.cotizacionNumericUpDown);
            this.filtroGroupBox.Controls.Add(this.clienteComboBox);
            this.filtroGroupBox.Controls.Add(this.cotizacionRadioButton);
            this.filtroGroupBox.Controls.Add(this.clienteRadioButton);
            this.filtroGroupBox.Location = new System.Drawing.Point(5, 5);
            this.filtroGroupBox.Name = "filtroGroupBox";
            this.filtroGroupBox.Size = new System.Drawing.Size(749, 61);
            this.filtroGroupBox.TabIndex = 4;
            this.filtroGroupBox.TabStop = false;
            this.filtroGroupBox.Text = "Filtros";
            // 
            // busquedaClienteButton
            // 
            this.busquedaClienteButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.busquedaClienteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaClienteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.busquedaClienteButton.Location = new System.Drawing.Point(669, 18);
            this.busquedaClienteButton.Name = "busquedaClienteButton";
            this.busquedaClienteButton.Size = new System.Drawing.Size(63, 23);
            this.busquedaClienteButton.TabIndex = 5;
            this.busquedaClienteButton.Text = "Buscar";
            this.busquedaClienteButton.UseVisualStyleBackColor = false;
            this.busquedaClienteButton.Visible = false;
            this.busquedaClienteButton.Click += new System.EventHandler(this.busquedaClienteButton_Click);
            // 
            // cotizacionNumericUpDown
            // 
            this.cotizacionNumericUpDown.Location = new System.Drawing.Point(172, 19);
            this.cotizacionNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.cotizacionNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cotizacionNumericUpDown.Name = "cotizacionNumericUpDown";
            this.cotizacionNumericUpDown.Size = new System.Drawing.Size(103, 20);
            this.cotizacionNumericUpDown.TabIndex = 4;
            this.cotizacionNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cotizacionNumericUpDown.Visible = false;
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.DataSource = this.clientesBindingSource;
            this.clienteComboBox.DisplayMember = "NombreCliente";
            this.clienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(281, 18);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(371, 21);
            this.clienteComboBox.TabIndex = 3;
            this.clienteComboBox.ValueMember = "IdCliente";
            this.clienteComboBox.Visible = false;
            // 
            // cotizacionRadioButton
            // 
            this.cotizacionRadioButton.AutoSize = true;
            this.cotizacionRadioButton.Location = new System.Drawing.Point(92, 19);
            this.cotizacionRadioButton.Name = "cotizacionRadioButton";
            this.cotizacionRadioButton.Size = new System.Drawing.Size(74, 17);
            this.cotizacionRadioButton.TabIndex = 2;
            this.cotizacionRadioButton.Text = "Cotización";
            this.cotizacionRadioButton.UseVisualStyleBackColor = true;
            this.cotizacionRadioButton.CheckedChanged += new System.EventHandler(this.cotizacionRadioButton_CheckedChanged);
            // 
            // clienteRadioButton
            // 
            this.clienteRadioButton.AutoSize = true;
            this.clienteRadioButton.Location = new System.Drawing.Point(14, 19);
            this.clienteRadioButton.Name = "clienteRadioButton";
            this.clienteRadioButton.Size = new System.Drawing.Size(57, 17);
            this.clienteRadioButton.TabIndex = 1;
            this.clienteRadioButton.Text = "Cliente";
            this.clienteRadioButton.UseVisualStyleBackColor = true;
            this.clienteRadioButton.CheckedChanged += new System.EventHandler(this.clienteRadioButton_CheckedChanged);
            // 
            // verReporteButton
            // 
            this.verReporteButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.verReporteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verReporteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.verReporteButton.Location = new System.Drawing.Point(769, 19);
            this.verReporteButton.Name = "verReporteButton";
            this.verReporteButton.Size = new System.Drawing.Size(93, 30);
            this.verReporteButton.TabIndex = 3;
            this.verReporteButton.Text = "Ver Reporte";
            this.verReporteButton.UseVisualStyleBackColor = false;
            this.verReporteButton.Click += new System.EventHandler(this.verReporteButton_Click);
            // 
            // dSCOCOA
            // 
            this.dSCOCOA.DataSetName = "DSCOCOA";
            this.dSCOCOA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dSCOCOA;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteCotizacionAccesorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1374, 647);
            this.Controls.Add(this.filtroGroupBox);
            this.Controls.Add(this.verReporteButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteCotizacionAccesorios";
            this.Text = "Reporte Cotización Accesorios";
            this.Load += new System.EventHandler(this.frmReporteCotizacionAccesorios_Load);
            this.panel1.ResumeLayout(false);
            this.filtroGroupBox.ResumeLayout(false);
            this.filtroGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.GroupBox filtroGroupBox;
        private System.Windows.Forms.Button busquedaClienteButton;
        private System.Windows.Forms.NumericUpDown cotizacionNumericUpDown;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.RadioButton cotizacionRadioButton;
        private System.Windows.Forms.RadioButton clienteRadioButton;
        private System.Windows.Forms.Button verReporteButton;
        private DSCOCOA dSCOCOA;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DSCOCOATableAdapters.ClientesTableAdapter clientesTableAdapter;
    }
}