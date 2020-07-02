namespace COCOA.Maestras
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
            this.fillByToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nitToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.nitToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nombreProveedorToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.nombreProveedorToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nombreContactoToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.nombreContactoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.emailToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.emailToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busquedaDataGridView)).BeginInit();
            this.fillByToolStrip1.SuspendLayout();
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
            this.tableAdapterManager.ListadoProveedoresTableAdapter = null;
            this.tableAdapterManager.LogTableAdapter = null;
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
            this.tableAdapterManager.VersionamientoTableAdapter = null;
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
            this.busquedaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.busquedaDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.busquedaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.busquedaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busquedaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
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
            this.busquedaDataGridView.Size = new System.Drawing.Size(1059, 423);
            this.busquedaDataGridView.TabIndex = 17;
            // 
            // fillByToolStrip1
            // 
            this.fillByToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.fillByToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nitToolStripLabel1,
            this.nitToolStripTextBox,
            this.nombreProveedorToolStripLabel1,
            this.nombreProveedorToolStripTextBox,
            this.nombreContactoToolStripLabel1,
            this.nombreContactoToolStripTextBox,
            this.emailToolStripLabel1,
            this.emailToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip1.Name = "fillByToolStrip1";
            this.fillByToolStrip1.Size = new System.Drawing.Size(1059, 25);
            this.fillByToolStrip1.TabIndex = 19;
            this.fillByToolStrip1.Text = "fillByToolStrip1";
            // 
            // nitToolStripLabel1
            // 
            this.nitToolStripLabel1.Name = "nitToolStripLabel1";
            this.nitToolStripLabel1.Size = new System.Drawing.Size(26, 22);
            this.nitToolStripLabel1.Text = "Nit:";
            // 
            // nitToolStripTextBox
            // 
            this.nitToolStripTextBox.Name = "nitToolStripTextBox";
            this.nitToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.nitToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nitToolStripTextBox_KeyPress);
            // 
            // nombreProveedorToolStripLabel1
            // 
            this.nombreProveedorToolStripLabel1.Name = "nombreProveedorToolStripLabel1";
            this.nombreProveedorToolStripLabel1.Size = new System.Drawing.Size(64, 22);
            this.nombreProveedorToolStripLabel1.Text = "Proveedor:";
            // 
            // nombreProveedorToolStripTextBox
            // 
            this.nombreProveedorToolStripTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreProveedorToolStripTextBox.Name = "nombreProveedorToolStripTextBox";
            this.nombreProveedorToolStripTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // nombreContactoToolStripLabel1
            // 
            this.nombreContactoToolStripLabel1.Name = "nombreContactoToolStripLabel1";
            this.nombreContactoToolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.nombreContactoToolStripLabel1.Text = "Contacto:";
            // 
            // nombreContactoToolStripTextBox
            // 
            this.nombreContactoToolStripTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreContactoToolStripTextBox.Name = "nombreContactoToolStripTextBox";
            this.nombreContactoToolStripTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // emailToolStripLabel1
            // 
            this.emailToolStripLabel1.Name = "emailToolStripLabel1";
            this.emailToolStripLabel1.Size = new System.Drawing.Size(39, 22);
            this.emailToolStripLabel1.Text = "Email:";
            // 
            // emailToolStripTextBox
            // 
            this.emailToolStripTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.emailToolStripTextBox.Name = "emailToolStripTextBox";
            this.emailToolStripTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.fillByToolStripButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 22);
            this.fillByToolStripButton.Text = "Buscar";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdProveedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 41;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nit";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nit";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 45;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NombreProveedor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Proveedor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 81;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NombreContacto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Contacto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dirección";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 77;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telefono1";
            this.dataGridViewTextBoxColumn7.HeaderText = "Teléfono";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 74;
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
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Celular";
            this.dataGridViewTextBoxColumn9.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 64;
            // 
            // dataGridViewTextBoxColumn10
            // 
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
            this.dataGridViewCheckBoxColumn1.Width = 43;
            // 
            // frmBusquedaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1059, 507);
            this.ControlBox = false;
            this.Controls.Add(this.fillByToolStrip1);
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
            this.fillByToolStrip1.ResumeLayout(false);
            this.fillByToolStrip1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStrip fillByToolStrip1;
        private System.Windows.Forms.ToolStripLabel nitToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox nitToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel nombreProveedorToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox nombreProveedorToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel nombreContactoToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox nombreContactoToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel emailToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox emailToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}