namespace COCOA.Maestras
{
    partial class frmImpoconsumo
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
            System.Windows.Forms.Label descripcionImpoconsumoLabel;
            System.Windows.Forms.Label tarifaLabel;
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label idImpoconsumoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImpoconsumo));
            this.dSCOCOA = new COCOA.DSCOCOA();
            this.impoconsumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.impoconsumoTableAdapter = new COCOA.DSCOCOATableAdapters.ImpoconsumoTableAdapter();
            this.tableAdapterManager = new COCOA.DSCOCOATableAdapters.TableAdapterManager();
            this.impoconsumoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorEdit = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCancel = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorExit = new System.Windows.Forms.ToolStripButton();
            this.impoconsumoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descripcionImpoconsumoTextBox = new System.Windows.Forms.TextBox();
            this.tarifaTextBox = new System.Windows.Forms.TextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.idImpoconsumoTextBox = new System.Windows.Forms.TextBox();
            descripcionImpoconsumoLabel = new System.Windows.Forms.Label();
            tarifaLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            idImpoconsumoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impoconsumoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impoconsumoBindingNavigator)).BeginInit();
            this.impoconsumoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.impoconsumoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionImpoconsumoLabel
            // 
            descripcionImpoconsumoLabel.AutoSize = true;
            descripcionImpoconsumoLabel.Location = new System.Drawing.Point(11, 69);
            descripcionImpoconsumoLabel.Name = "descripcionImpoconsumoLabel";
            descripcionImpoconsumoLabel.Size = new System.Drawing.Size(66, 13);
            descripcionImpoconsumoLabel.TabIndex = 0;
            descripcionImpoconsumoLabel.Text = "Descripción:";
            // 
            // tarifaLabel
            // 
            tarifaLabel.AutoSize = true;
            tarifaLabel.Location = new System.Drawing.Point(40, 95);
            tarifaLabel.Name = "tarifaLabel";
            tarifaLabel.Size = new System.Drawing.Size(37, 13);
            tarifaLabel.TabIndex = 2;
            tarifaLabel.Text = "Tarifa:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(194, 95);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 4;
            activoLabel.Text = "Activo:";
            // 
            // idImpoconsumoLabel
            // 
            idImpoconsumoLabel.AutoSize = true;
            idImpoconsumoLabel.Location = new System.Drawing.Point(58, 43);
            idImpoconsumoLabel.Name = "idImpoconsumoLabel";
            idImpoconsumoLabel.Size = new System.Drawing.Size(19, 13);
            idImpoconsumoLabel.TabIndex = 8;
            idImpoconsumoLabel.Text = "Id:";
            // 
            // dSCOCOA
            // 
            this.dSCOCOA.DataSetName = "DSCOCOA";
            this.dSCOCOA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // impoconsumoBindingSource
            // 
            this.impoconsumoBindingSource.DataMember = "Impoconsumo";
            this.impoconsumoBindingSource.DataSource = this.dSCOCOA;
            // 
            // impoconsumoTableAdapter
            // 
            this.impoconsumoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CilindrajesTableAdapter = null;
            this.tableAdapterManager.CiudadesTableAdapter = null;
            this.tableAdapterManager.ClaseTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ContactosClienteTableAdapter = null;
            this.tableAdapterManager.CotizacionDetalleTableAdapter = null;
            this.tableAdapterManager.CotizacionTableAdapter = null;
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.FormularioTableAdapter = null;
            this.tableAdapterManager.ImpoconsumoTableAdapter = this.impoconsumoTableAdapter;
            this.tableAdapterManager.IntervaloPreciosTableAdapter = null;
            this.tableAdapterManager.IVATableAdapter = null;
            this.tableAdapterManager.ListadoProveedoresTableAdapter = null;
            this.tableAdapterManager.LogTableAdapter = null;
            this.tableAdapterManager.NumeroContactoTableAdapter = null;
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
            this.tableAdapterManager.VersionamientoTableAdapter = null;
            // 
            // impoconsumoBindingNavigator
            // 
            this.impoconsumoBindingNavigator.AddNewItem = null;
            this.impoconsumoBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.impoconsumoBindingNavigator.BindingSource = this.impoconsumoBindingSource;
            this.impoconsumoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.impoconsumoBindingNavigator.DeleteItem = null;
            this.impoconsumoBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.impoconsumoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorEdit,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem,
            this.bindingNavigatorCancel,
            this.bindingNavigatorExit});
            this.impoconsumoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.impoconsumoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.impoconsumoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.impoconsumoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.impoconsumoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.impoconsumoBindingNavigator.Name = "impoconsumoBindingNavigator";
            this.impoconsumoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.impoconsumoBindingNavigator.Size = new System.Drawing.Size(414, 31);
            this.impoconsumoBindingNavigator.TabIndex = 0;
            this.impoconsumoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorEdit
            // 
            this.bindingNavigatorEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorEdit.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorEdit.Image")));
            this.bindingNavigatorEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEdit.Name = "bindingNavigatorEdit";
            this.bindingNavigatorEdit.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorEdit.Text = "toolStripButton1";
            this.bindingNavigatorEdit.ToolTipText = "Editar";
            this.bindingNavigatorEdit.Click += new System.EventHandler(this.bindingNavigatorEdit_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.ToolTipText = "Nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.ToolTipText = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Enabled = false;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorSaveItem.Text = "Save Data";
            this.bindingNavigatorSaveItem.ToolTipText = "Guardar";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.impoconsumoBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorCancel
            // 
            this.bindingNavigatorCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorCancel.Enabled = false;
            this.bindingNavigatorCancel.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorCancel.Image")));
            this.bindingNavigatorCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCancel.Name = "bindingNavigatorCancel";
            this.bindingNavigatorCancel.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorCancel.Text = "toolStripButton1";
            this.bindingNavigatorCancel.ToolTipText = "Cancelar";
            this.bindingNavigatorCancel.Click += new System.EventHandler(this.bindingNavigatorCancel_Click);
            // 
            // bindingNavigatorExit
            // 
            this.bindingNavigatorExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorExit.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorExit.Image")));
            this.bindingNavigatorExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorExit.Name = "bindingNavigatorExit";
            this.bindingNavigatorExit.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorExit.Text = "toolStripButton4";
            this.bindingNavigatorExit.ToolTipText = "Salir";
            this.bindingNavigatorExit.Click += new System.EventHandler(this.bindingNavigatorExit_Click);
            // 
            // impoconsumoDataGridView
            // 
            this.impoconsumoDataGridView.AllowUserToAddRows = false;
            this.impoconsumoDataGridView.AllowUserToDeleteRows = false;
            this.impoconsumoDataGridView.AllowUserToOrderColumns = true;
            this.impoconsumoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.impoconsumoDataGridView.AutoGenerateColumns = false;
            this.impoconsumoDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.impoconsumoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.impoconsumoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.impoconsumoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.impoconsumoDataGridView.DataSource = this.impoconsumoBindingSource;
            this.impoconsumoDataGridView.Location = new System.Drawing.Point(1, 120);
            this.impoconsumoDataGridView.Name = "impoconsumoDataGridView";
            this.impoconsumoDataGridView.ReadOnly = true;
            this.impoconsumoDataGridView.Size = new System.Drawing.Size(413, 188);
            this.impoconsumoDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdImpoconsumo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 41;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DescripcionImpoconsumo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 88;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Tarifa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tarifa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 59;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Activo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 43;
            // 
            // descripcionImpoconsumoTextBox
            // 
            this.descripcionImpoconsumoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descripcionImpoconsumoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.impoconsumoBindingSource, "DescripcionImpoconsumo", true));
            this.descripcionImpoconsumoTextBox.Location = new System.Drawing.Point(80, 66);
            this.descripcionImpoconsumoTextBox.Name = "descripcionImpoconsumoTextBox";
            this.descripcionImpoconsumoTextBox.ReadOnly = true;
            this.descripcionImpoconsumoTextBox.Size = new System.Drawing.Size(297, 20);
            this.descripcionImpoconsumoTextBox.TabIndex = 1;
            // 
            // tarifaTextBox
            // 
            this.tarifaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.impoconsumoBindingSource, "Tarifa", true));
            this.tarifaTextBox.Location = new System.Drawing.Point(80, 92);
            this.tarifaTextBox.Name = "tarifaTextBox";
            this.tarifaTextBox.ReadOnly = true;
            this.tarifaTextBox.Size = new System.Drawing.Size(100, 20);
            this.tarifaTextBox.TabIndex = 3;
            this.tarifaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tarifaTextBox_KeyPress);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.Checked = true;
            this.activoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.impoconsumoBindingSource, "Activo", true));
            this.activoCheckBox.Enabled = false;
            this.activoCheckBox.Location = new System.Drawing.Point(240, 90);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(29, 24);
            this.activoCheckBox.TabIndex = 5;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // idImpoconsumoTextBox
            // 
            this.idImpoconsumoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.impoconsumoBindingSource, "IdImpoconsumo", true));
            this.idImpoconsumoTextBox.Enabled = false;
            this.idImpoconsumoTextBox.Location = new System.Drawing.Point(80, 40);
            this.idImpoconsumoTextBox.Name = "idImpoconsumoTextBox";
            this.idImpoconsumoTextBox.ReadOnly = true;
            this.idImpoconsumoTextBox.Size = new System.Drawing.Size(44, 20);
            this.idImpoconsumoTextBox.TabIndex = 9;
            // 
            // frmImpoconsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(414, 309);
            this.Controls.Add(idImpoconsumoLabel);
            this.Controls.Add(this.idImpoconsumoTextBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(tarifaLabel);
            this.Controls.Add(this.tarifaTextBox);
            this.Controls.Add(descripcionImpoconsumoLabel);
            this.Controls.Add(this.descripcionImpoconsumoTextBox);
            this.Controls.Add(this.impoconsumoDataGridView);
            this.Controls.Add(this.impoconsumoBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImpoconsumo";
            this.Text = "Tarifa de Impoconsumo";
            this.Load += new System.EventHandler(this.frmImpoconsumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impoconsumoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impoconsumoBindingNavigator)).EndInit();
            this.impoconsumoBindingNavigator.ResumeLayout(false);
            this.impoconsumoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.impoconsumoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSCOCOA dSCOCOA;
        private System.Windows.Forms.BindingSource impoconsumoBindingSource;
        private DSCOCOATableAdapters.ImpoconsumoTableAdapter impoconsumoTableAdapter;
        private DSCOCOATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator impoconsumoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView impoconsumoDataGridView;
        private System.Windows.Forms.TextBox descripcionImpoconsumoTextBox;
        private System.Windows.Forms.TextBox tarifaTextBox;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEdit;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancel;
        private System.Windows.Forms.ToolStripButton bindingNavigatorExit;
        private System.Windows.Forms.TextBox idImpoconsumoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}