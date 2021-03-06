﻿namespace COCOA.Maestras
{
    partial class frmBusquedaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaProveedor));
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCOCOA = new COCOA.DSCOCOA();
            this.proveedoresTableAdapter = new COCOA.DSCOCOATableAdapters.ProveedoresTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.borrarFiltrosbutton = new System.Windows.Forms.Button();
            this.igualRadioButton = new System.Windows.Forms.RadioButton();
            this.terminaRadioButton = new System.Windows.Forms.RadioButton();
            this.empiezaRadioButton = new System.Windows.Forms.RadioButton();
            this.contengaRadioButton = new System.Windows.Forms.RadioButton();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.volverButton = new System.Windows.Forms.Button();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentosTableAdapter = new COCOA.DSCOCOATableAdapters.DepartamentosTableAdapter();
            this.ciudadesTableAdapter = new COCOA.DSCOCOATableAdapters.CiudadesTableAdapter();
            this.tableAdapterManager = new COCOA.DSCOCOATableAdapters.TableAdapterManager();
            this.busquedaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.nitToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nitToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nombreProveedorToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombreProveedorToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nombreContactoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombreContactoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.emailToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.emailToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busquedaDataGridView)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
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
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.borrarFiltrosbutton);
            this.groupBox1.Controls.Add(this.igualRadioButton);
            this.groupBox1.Controls.Add(this.terminaRadioButton);
            this.groupBox1.Controls.Add(this.empiezaRadioButton);
            this.groupBox1.Controls.Add(this.contengaRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios de Búsqueda";
            // 
            // borrarFiltrosbutton
            // 
            this.borrarFiltrosbutton.BackColor = System.Drawing.Color.IndianRed;
            this.borrarFiltrosbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarFiltrosbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borrarFiltrosbutton.Location = new System.Drawing.Point(331, 11);
            this.borrarFiltrosbutton.Name = "borrarFiltrosbutton";
            this.borrarFiltrosbutton.Size = new System.Drawing.Size(89, 32);
            this.borrarFiltrosbutton.TabIndex = 4;
            this.borrarFiltrosbutton.Text = "Borrar Filtros";
            this.borrarFiltrosbutton.UseVisualStyleBackColor = false;
            this.borrarFiltrosbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // igualRadioButton
            // 
            this.igualRadioButton.AutoSize = true;
            this.igualRadioButton.Location = new System.Drawing.Point(260, 19);
            this.igualRadioButton.Name = "igualRadioButton";
            this.igualRadioButton.Size = new System.Drawing.Size(48, 17);
            this.igualRadioButton.TabIndex = 3;
            this.igualRadioButton.Text = "Igual";
            this.igualRadioButton.UseVisualStyleBackColor = true;
            // 
            // terminaRadioButton
            // 
            this.terminaRadioButton.AutoSize = true;
            this.terminaRadioButton.Location = new System.Drawing.Point(176, 20);
            this.terminaRadioButton.Name = "terminaRadioButton";
            this.terminaRadioButton.Size = new System.Drawing.Size(78, 17);
            this.terminaRadioButton.TabIndex = 2;
            this.terminaRadioButton.Text = "Termina en";
            this.terminaRadioButton.UseVisualStyleBackColor = true;
            // 
            // empiezaRadioButton
            // 
            this.empiezaRadioButton.AutoSize = true;
            this.empiezaRadioButton.Location = new System.Drawing.Point(84, 20);
            this.empiezaRadioButton.Name = "empiezaRadioButton";
            this.empiezaRadioButton.Size = new System.Drawing.Size(86, 17);
            this.empiezaRadioButton.TabIndex = 1;
            this.empiezaRadioButton.Text = "Empieza con";
            this.empiezaRadioButton.UseVisualStyleBackColor = true;
            // 
            // contengaRadioButton
            // 
            this.contengaRadioButton.AutoSize = true;
            this.contengaRadioButton.Checked = true;
            this.contengaRadioButton.Location = new System.Drawing.Point(7, 20);
            this.contengaRadioButton.Name = "contengaRadioButton";
            this.contengaRadioButton.Size = new System.Drawing.Size(71, 17);
            this.contengaRadioButton.TabIndex = 0;
            this.contengaRadioButton.TabStop = true;
            this.contengaRadioButton.Text = "Contenga";
            this.contengaRadioButton.UseVisualStyleBackColor = true;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.BackColor = System.Drawing.Color.IndianRed;
            this.Cancelarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelarbutton.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.Cancelarbutton.FlatAppearance.BorderSize = 2;
            this.Cancelarbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Cancelarbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Cancelarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelarbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelarbutton.Location = new System.Drawing.Point(550, 39);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(86, 35);
            this.Cancelarbutton.TabIndex = 15;
            this.Cancelarbutton.Text = "Salir";
            this.Cancelarbutton.UseVisualStyleBackColor = false;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // volverButton
            // 
            this.volverButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.volverButton.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.volverButton.FlatAppearance.BorderSize = 2;
            this.volverButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.volverButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.volverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.volverButton.Location = new System.Drawing.Point(458, 39);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(86, 35);
            this.volverButton.TabIndex = 14;
            this.volverButton.Text = "Volver";
            this.volverButton.UseVisualStyleBackColor = false;
            this.volverButton.Click += new System.EventHandler(this.volverButton_Click);
            // 
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataMember = "Departamentos";
            this.departamentosBindingSource.DataSource = this.dSCOCOA;
            // 
            // ciudadesBindingSource
            // 
            this.ciudadesBindingSource.DataMember = "Ciudades";
            this.ciudadesBindingSource.DataSource = this.dSCOCOA;
            // 
            // departamentosTableAdapter
            // 
            this.departamentosTableAdapter.ClearBeforeFill = true;
            // 
            // ciudadesTableAdapter
            // 
            this.ciudadesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CilindrajesTableAdapter = null;
            this.tableAdapterManager.CiudadesTableAdapter = this.ciudadesTableAdapter;
            this.tableAdapterManager.ClaseTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.CotizacionDetalleTableAdapter = null;
            this.tableAdapterManager.CotizacionTableAdapter = null;
            this.tableAdapterManager.DepartamentosTableAdapter = this.departamentosTableAdapter;
            this.tableAdapterManager.FormularioTableAdapter = null;
            this.tableAdapterManager.ImpoconsumoTableAdapter = null;
            this.tableAdapterManager.IntervaloPreciosTableAdapter = null;
            this.tableAdapterManager.IVATableAdapter = null;
            this.tableAdapterManager.NumeroPasajerosTableAdapter = null;
            this.tableAdapterManager.OrdenCompraDetalleTableAdapter = null;
            this.tableAdapterManager.OrdenCompraTableAdapter = null;
            this.tableAdapterManager.PaisesTableAdapter = null;
            this.tableAdapterManager.PermisoRolTableAdapter = null;
            this.tableAdapterManager.PesoBrutoVhTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = this.proveedoresTableAdapter;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.SegmentosTableAdapter = null;
            this.tableAdapterManager.TipoProductoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = COCOA.DSCOCOATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // busquedaDataGridView
            // 
            this.busquedaDataGridView.AllowUserToAddRows = false;
            this.busquedaDataGridView.AllowUserToDeleteRows = false;
            this.busquedaDataGridView.AllowUserToOrderColumns = true;
            this.busquedaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.busquedaDataGridView.AutoGenerateColumns = false;
            this.busquedaDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.busquedaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.busquedaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busquedaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewCheckBoxColumn1});
            this.busquedaDataGridView.DataSource = this.proveedoresBindingSource;
            this.busquedaDataGridView.Location = new System.Drawing.Point(0, 83);
            this.busquedaDataGridView.Name = "busquedaDataGridView";
            this.busquedaDataGridView.ReadOnly = true;
            this.busquedaDataGridView.Size = new System.Drawing.Size(1039, 404);
            this.busquedaDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdProveedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdProveedor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nit";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nit";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 45;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NombreProveedor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Proveedor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 81;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NombreContacto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Contacto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dirección";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 77;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ciudad";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 65;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telefono1";
            this.dataGridViewTextBoxColumn7.HeaderText = "Teléfono";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Telefono2";
            this.dataGridViewTextBoxColumn8.HeaderText = "Telefono2";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Celular";
            this.dataGridViewTextBoxColumn9.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 64;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn10.HeaderText = "Email";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 57;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Notas";
            this.dataGridViewTextBoxColumn11.HeaderText = "Notas";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Activo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nitToolStripLabel,
            this.nitToolStripTextBox,
            this.nombreProveedorToolStripLabel,
            this.nombreProveedorToolStripTextBox,
            this.nombreContactoToolStripLabel,
            this.nombreContactoToolStripTextBox,
            this.emailToolStripLabel,
            this.emailToolStripTextBox,
            this.fillByToolStripButton1});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1039, 25);
            this.fillByToolStrip.TabIndex = 18;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // nitToolStripLabel
            // 
            this.nitToolStripLabel.Name = "nitToolStripLabel";
            this.nitToolStripLabel.Size = new System.Drawing.Size(26, 22);
            this.nitToolStripLabel.Text = "Nit:";
            // 
            // nitToolStripTextBox
            // 
            this.nitToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nitToolStripTextBox.Name = "nitToolStripTextBox";
            this.nitToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // nombreProveedorToolStripLabel
            // 
            this.nombreProveedorToolStripLabel.Name = "nombreProveedorToolStripLabel";
            this.nombreProveedorToolStripLabel.Size = new System.Drawing.Size(64, 22);
            this.nombreProveedorToolStripLabel.Text = "Proveedor:";
            // 
            // nombreProveedorToolStripTextBox
            // 
            this.nombreProveedorToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nombreProveedorToolStripTextBox.Name = "nombreProveedorToolStripTextBox";
            this.nombreProveedorToolStripTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // nombreContactoToolStripLabel
            // 
            this.nombreContactoToolStripLabel.Name = "nombreContactoToolStripLabel";
            this.nombreContactoToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.nombreContactoToolStripLabel.Text = "Contacto:";
            // 
            // nombreContactoToolStripTextBox
            // 
            this.nombreContactoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nombreContactoToolStripTextBox.Name = "nombreContactoToolStripTextBox";
            this.nombreContactoToolStripTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // emailToolStripLabel
            // 
            this.emailToolStripLabel.Name = "emailToolStripLabel";
            this.emailToolStripLabel.Size = new System.Drawing.Size(39, 22);
            this.emailToolStripLabel.Text = "Email:";
            // 
            // emailToolStripTextBox
            // 
            this.emailToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailToolStripTextBox.Name = "emailToolStripTextBox";
            this.emailToolStripTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // fillByToolStripButton1
            // 
            this.fillByToolStripButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.fillByToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.fillByToolStripButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fillByToolStripButton1.Name = "fillByToolStripButton1";
            this.fillByToolStripButton1.Size = new System.Drawing.Size(48, 22);
            this.fillByToolStripButton1.Text = "Buscar";
            this.fillByToolStripButton1.Click += new System.EventHandler(this.fillByToolStripButton1_Click);
            // 
            // frmBusquedaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1039, 488);
            this.ControlBox = false;
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.busquedaDataGridView);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.volverButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBusquedaProveedor";
            this.Text = "Búsqueda Proveedor";
            this.Load += new System.EventHandler(this.frmBusquedaProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busquedaDataGridView)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DSCOCOA dSCOCOA;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private DSCOCOATableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton igualRadioButton;
        private System.Windows.Forms.RadioButton terminaRadioButton;
        private System.Windows.Forms.RadioButton empiezaRadioButton;
        private System.Windows.Forms.RadioButton contengaRadioButton;
        private System.Windows.Forms.Button borrarFiltrosbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private DSCOCOATableAdapters.DepartamentosTableAdapter departamentosTableAdapter;
        private System.Windows.Forms.BindingSource ciudadesBindingSource;
        private DSCOCOATableAdapters.CiudadesTableAdapter ciudadesTableAdapter;
        private DSCOCOATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView busquedaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel nitToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nitToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel nombreProveedorToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombreProveedorToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel nombreContactoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombreContactoToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel emailToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox emailToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton1;
    }
}