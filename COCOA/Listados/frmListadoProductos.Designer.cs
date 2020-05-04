﻿namespace COCOA.Listados
{
    partial class frmListadoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoProductos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.todosCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.tipoProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCOCOA = new COCOA.DSCOCOA();
            this.tipoProductoTableAdapter = new COCOA.DSCOCOATableAdapters.TipoProductoTableAdapter();
            this.verReporteButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1377, 570);
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
            this.crystalReportViewer1.Size = new System.Drawing.Size(1377, 570);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // todosCheckBox
            // 
            this.todosCheckBox.AutoSize = true;
            this.todosCheckBox.Checked = true;
            this.todosCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.todosCheckBox.Location = new System.Drawing.Point(13, 17);
            this.todosCheckBox.Name = "todosCheckBox";
            this.todosCheckBox.Size = new System.Drawing.Size(56, 17);
            this.todosCheckBox.TabIndex = 0;
            this.todosCheckBox.Text = "Todos";
            this.todosCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo Producto";
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.DataSource = this.tipoProductoBindingSource;
            this.tipoComboBox.DisplayMember = "DescripcionTipoProducto";
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Location = new System.Drawing.Point(179, 14);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(241, 21);
            this.tipoComboBox.TabIndex = 2;
            this.tipoComboBox.ValueMember = "IdTipoProducto";
            // 
            // tipoProductoBindingSource
            // 
            this.tipoProductoBindingSource.DataMember = "TipoProducto";
            this.tipoProductoBindingSource.DataSource = this.dSCOCOA;
            // 
            // dSCOCOA
            // 
            this.dSCOCOA.DataSetName = "DSCOCOA";
            this.dSCOCOA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoProductoTableAdapter
            // 
            this.tipoProductoTableAdapter.ClearBeforeFill = true;
            // 
            // verReporteButton
            // 
            this.verReporteButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.verReporteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verReporteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.verReporteButton.Location = new System.Drawing.Point(426, 9);
            this.verReporteButton.Name = "verReporteButton";
            this.verReporteButton.Size = new System.Drawing.Size(93, 30);
            this.verReporteButton.TabIndex = 4;
            this.verReporteButton.Text = "Ver Reporte";
            this.verReporteButton.UseVisualStyleBackColor = false;
            this.verReporteButton.Click += new System.EventHandler(this.verReporteButton_Click);
            // 
            // frmListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1377, 619);
            this.Controls.Add(this.verReporteButton);
            this.Controls.Add(this.tipoComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.todosCheckBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoProductos";
            this.Text = "Listado Productos";
            this.Load += new System.EventHandler(this.frmListadoProductos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.CheckBox todosCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private DSCOCOA dSCOCOA;
        private System.Windows.Forms.BindingSource tipoProductoBindingSource;
        private DSCOCOATableAdapters.TipoProductoTableAdapter tipoProductoTableAdapter;
        private System.Windows.Forms.Button verReporteButton;
    }
}