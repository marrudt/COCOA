namespace COCOA.Reportes
{
    partial class frmReporteCotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteCotizacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.verReporteButton = new System.Windows.Forms.Button();
            this.filtroGroupBox = new System.Windows.Forms.GroupBox();
            this.busquedaClienteButton = new System.Windows.Forms.Button();
            this.cotizacionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCOCOA = new COCOA.DSCOCOA();
            this.cotizacionRadioButton = new System.Windows.Forms.RadioButton();
            this.clienteRadioButton = new System.Windows.Forms.RadioButton();
            this.todosRadioButton = new System.Windows.Forms.RadioButton();
            this.clientesTableAdapter = new COCOA.DSCOCOATableAdapters.ClientesTableAdapter();
            this.panel1.SuspendLayout();
            this.filtroGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(-1, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 582);
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
            this.crystalReportViewer1.Size = new System.Drawing.Size(1371, 578);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // verReporteButton
            // 
            this.verReporteButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.verReporteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verReporteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.verReporteButton.Location = new System.Drawing.Point(836, 16);
            this.verReporteButton.Name = "verReporteButton";
            this.verReporteButton.Size = new System.Drawing.Size(93, 30);
            this.verReporteButton.TabIndex = 1;
            this.verReporteButton.Text = "Ver Reporte";
            this.verReporteButton.UseVisualStyleBackColor = false;
            this.verReporteButton.Click += new System.EventHandler(this.verReporteButton_Click);
            // 
            // filtroGroupBox
            // 
            this.filtroGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.filtroGroupBox.Controls.Add(this.busquedaClienteButton);
            this.filtroGroupBox.Controls.Add(this.cotizacionNumericUpDown);
            this.filtroGroupBox.Controls.Add(this.clienteComboBox);
            this.filtroGroupBox.Controls.Add(this.cotizacionRadioButton);
            this.filtroGroupBox.Controls.Add(this.clienteRadioButton);
            this.filtroGroupBox.Controls.Add(this.todosRadioButton);
            this.filtroGroupBox.Location = new System.Drawing.Point(6, 2);
            this.filtroGroupBox.Name = "filtroGroupBox";
            this.filtroGroupBox.Size = new System.Drawing.Size(824, 61);
            this.filtroGroupBox.TabIndex = 2;
            this.filtroGroupBox.TabStop = false;
            this.filtroGroupBox.Text = "Filtros";
            // 
            // busquedaClienteButton
            // 
            this.busquedaClienteButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.busquedaClienteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaClienteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.busquedaClienteButton.Location = new System.Drawing.Point(741, 18);
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
            this.cotizacionNumericUpDown.Location = new System.Drawing.Point(255, 19);
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
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(364, 18);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(371, 21);
            this.clienteComboBox.TabIndex = 3;
            this.clienteComboBox.ValueMember = "IdCliente";
            this.clienteComboBox.Visible = false;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dSCOCOA;
            // 
            // dSCOCOA
            // 
            this.dSCOCOA.DataSetName = "DSCOCOA";
            this.dSCOCOA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cotizacionRadioButton
            // 
            this.cotizacionRadioButton.AutoSize = true;
            this.cotizacionRadioButton.Location = new System.Drawing.Point(175, 19);
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
            this.clienteRadioButton.Location = new System.Drawing.Point(97, 19);
            this.clienteRadioButton.Name = "clienteRadioButton";
            this.clienteRadioButton.Size = new System.Drawing.Size(57, 17);
            this.clienteRadioButton.TabIndex = 1;
            this.clienteRadioButton.Text = "Cliente";
            this.clienteRadioButton.UseVisualStyleBackColor = true;
            this.clienteRadioButton.CheckedChanged += new System.EventHandler(this.clienteRadioButton_CheckedChanged);
            // 
            // todosRadioButton
            // 
            this.todosRadioButton.AutoSize = true;
            this.todosRadioButton.Checked = true;
            this.todosRadioButton.Location = new System.Drawing.Point(21, 19);
            this.todosRadioButton.Name = "todosRadioButton";
            this.todosRadioButton.Size = new System.Drawing.Size(55, 17);
            this.todosRadioButton.TabIndex = 0;
            this.todosRadioButton.TabStop = true;
            this.todosRadioButton.Text = "Todos";
            this.todosRadioButton.UseVisualStyleBackColor = true;
            this.todosRadioButton.CheckedChanged += new System.EventHandler(this.todosRadioButton_CheckedChanged);
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1374, 647);
            this.Controls.Add(this.filtroGroupBox);
            this.Controls.Add(this.verReporteButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporteCotizacion";
            this.Text = "Reporte Cotización";
            this.Load += new System.EventHandler(this.frmReporteCotizacion_Load);
            this.panel1.ResumeLayout(false);
            this.filtroGroupBox.ResumeLayout(false);
            this.filtroGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button verReporteButton;
        private System.Windows.Forms.GroupBox filtroGroupBox;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.RadioButton cotizacionRadioButton;
        private System.Windows.Forms.RadioButton clienteRadioButton;
        private System.Windows.Forms.RadioButton todosRadioButton;
        private DSCOCOA dSCOCOA;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DSCOCOATableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.NumericUpDown cotizacionNumericUpDown;
        private System.Windows.Forms.Button busquedaClienteButton;
    }
}