namespace COCOA.Maestras
{
    partial class frmControlCambios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlCambios));
            this.dSCOCOA = new COCOA.DSCOCOA();
            this.versionamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.versionamientoTableAdapter = new COCOA.DSCOCOATableAdapters.VersionamientoTableAdapter();
            this.tableAdapterManager = new COCOA.DSCOCOATableAdapters.TableAdapterManager();
            this.versionamientoDataGridView = new System.Windows.Forms.DataGridView();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.versionToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.versionToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.cambioToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.cambioToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionamientoDataGridView)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSCOCOA
            // 
            this.dSCOCOA.DataSetName = "DSCOCOA";
            this.dSCOCOA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // versionamientoBindingSource
            // 
            this.versionamientoBindingSource.DataMember = "Versionamiento";
            this.versionamientoBindingSource.DataSource = this.dSCOCOA;
            // 
            // versionamientoTableAdapter
            // 
            this.versionamientoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CilindrajesTableAdapter = null;
            this.tableAdapterManager.CiudadesTableAdapter = null;
            this.tableAdapterManager.ClaseTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.CotizacionDetalleTableAdapter = null;
            this.tableAdapterManager.CotizacionTableAdapter = null;
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.FormularioTableAdapter = null;
            this.tableAdapterManager.ImpoconsumoTableAdapter = null;
            this.tableAdapterManager.IntervaloPreciosTableAdapter = null;
            this.tableAdapterManager.IVATableAdapter = null;
            this.tableAdapterManager.ListadoProveedoresTableAdapter = null;
            this.tableAdapterManager.LogTableAdapter = null;
            this.tableAdapterManager.NumeroPasajerosTableAdapter = null;
            this.tableAdapterManager.OrdenCompraDetalleTableAdapter = null;
            this.tableAdapterManager.OrdenCompraTableAdapter = null;
            this.tableAdapterManager.PaisesTableAdapter = null;
            this.tableAdapterManager.PermisoRolTableAdapter = null;
            this.tableAdapterManager.PesoBrutoVhTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.SegmentosTableAdapter = null;
            this.tableAdapterManager.TipoProductoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = COCOA.DSCOCOATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            this.tableAdapterManager.VersionamientoTableAdapter = this.versionamientoTableAdapter;
            // 
            // versionamientoDataGridView
            // 
            this.versionamientoDataGridView.AllowUserToAddRows = false;
            this.versionamientoDataGridView.AllowUserToDeleteRows = false;
            this.versionamientoDataGridView.AllowUserToOrderColumns = true;
            this.versionamientoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.versionamientoDataGridView.AutoGenerateColumns = false;
            this.versionamientoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.versionamientoDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.versionamientoDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.versionamientoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.versionamientoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.versionamientoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.versionamientoDataGridView.DataSource = this.versionamientoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.versionamientoDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.versionamientoDataGridView.Location = new System.Drawing.Point(0, 28);
            this.versionamientoDataGridView.Name = "versionamientoDataGridView";
            this.versionamientoDataGridView.ReadOnly = true;
            this.versionamientoDataGridView.Size = new System.Drawing.Size(983, 513);
            this.versionamientoDataGridView.TabIndex = 1;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripLabel,
            this.versionToolStripTextBox,
            this.cambioToolStripLabel,
            this.cambioToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(983, 25);
            this.fillByToolStrip.TabIndex = 2;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // versionToolStripLabel
            // 
            this.versionToolStripLabel.Name = "versionToolStripLabel";
            this.versionToolStripLabel.Size = new System.Drawing.Size(48, 22);
            this.versionToolStripLabel.Text = "Versión:";
            // 
            // versionToolStripTextBox
            // 
            this.versionToolStripTextBox.Name = "versionToolStripTextBox";
            this.versionToolStripTextBox.Size = new System.Drawing.Size(50, 25);
            // 
            // cambioToolStripLabel
            // 
            this.cambioToolStripLabel.Name = "cambioToolStripLabel";
            this.cambioToolStripLabel.Size = new System.Drawing.Size(52, 22);
            this.cambioToolStripLabel.Text = "Cambio:";
            // 
            // cambioToolStripTextBox
            // 
            this.cambioToolStripTextBox.Name = "cambioToolStripTextBox";
            this.cambioToolStripTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.fillByToolStripButton.ForeColor = System.Drawing.SystemColors.Window;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 22);
            this.fillByToolStripButton.Text = "Buscar";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdVersion";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdVersion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 76;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fecha";
            dataGridViewCellStyle1.Format = "dd/MMM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 62;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Version";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Versión";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 67;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cambio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cambio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 500;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Notas";
            this.dataGridViewTextBoxColumn5.HeaderText = "Notas";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // frmControlCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 540);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.versionamientoDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(999, 1000);
            this.MinimumSize = new System.Drawing.Size(999, 579);
            this.Name = "frmControlCambios";
            this.Text = "Control de Cambios";
            this.Load += new System.EventHandler(this.frmControlCambios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionamientoDataGridView)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSCOCOA dSCOCOA;
        private System.Windows.Forms.BindingSource versionamientoBindingSource;
        private DSCOCOATableAdapters.VersionamientoTableAdapter versionamientoTableAdapter;
        private DSCOCOATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView versionamientoDataGridView;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel versionToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox versionToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel cambioToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox cambioToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}