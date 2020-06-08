namespace COCOA.Maestras
{
    partial class frmCiudad
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
            System.Windows.Forms.Label codigoCiudadLabel;
            System.Windows.Forms.Label descripcionCiudadLabel;
            System.Windows.Forms.Label activoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCiudad));
            System.Windows.Forms.Label idCiudadLabel;
            this.ciudadesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.ciudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCOCOA = new COCOA.DSCOCOA();
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
            this.bindingNavigatorSearch = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorExit = new System.Windows.Forms.ToolStripButton();
            this.ciudadesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codigoCiudadTextBox = new System.Windows.Forms.TextBox();
            this.descripcionCiudadTextBox = new System.Windows.Forms.TextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ciudadesTableAdapter = new COCOA.DSCOCOATableAdapters.CiudadesTableAdapter();
            this.tableAdapterManager = new COCOA.DSCOCOATableAdapters.TableAdapterManager();
            this.idCiudadTextBox = new System.Windows.Forms.TextBox();
            codigoCiudadLabel = new System.Windows.Forms.Label();
            descripcionCiudadLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            idCiudadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingNavigator)).BeginInit();
            this.ciudadesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoCiudadLabel
            // 
            codigoCiudadLabel.AutoSize = true;
            codigoCiudadLabel.Location = new System.Drawing.Point(44, 71);
            codigoCiudadLabel.Name = "codigoCiudadLabel";
            codigoCiudadLabel.Size = new System.Drawing.Size(43, 13);
            codigoCiudadLabel.TabIndex = 2;
            codigoCiudadLabel.Text = "Código:";
            // 
            // descripcionCiudadLabel
            // 
            descripcionCiudadLabel.AutoSize = true;
            descripcionCiudadLabel.Location = new System.Drawing.Point(21, 97);
            descripcionCiudadLabel.Name = "descripcionCiudadLabel";
            descripcionCiudadLabel.Size = new System.Drawing.Size(66, 13);
            descripcionCiudadLabel.TabIndex = 4;
            descripcionCiudadLabel.Text = "Descripción:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(47, 122);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 8;
            activoLabel.Text = "Activo:";
            // 
            // ciudadesBindingNavigator
            // 
            this.ciudadesBindingNavigator.AddNewItem = null;
            this.ciudadesBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.ciudadesBindingNavigator.BindingSource = this.ciudadesBindingSource;
            this.ciudadesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ciudadesBindingNavigator.DeleteItem = null;
            this.ciudadesBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ciudadesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorSearch,
            this.bindingNavigatorExit});
            this.ciudadesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ciudadesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ciudadesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ciudadesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ciudadesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ciudadesBindingNavigator.Name = "ciudadesBindingNavigator";
            this.ciudadesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ciudadesBindingNavigator.Size = new System.Drawing.Size(447, 31);
            this.ciudadesBindingNavigator.TabIndex = 0;
            this.ciudadesBindingNavigator.Text = "bindingNavigator1";
            // 
            // ciudadesBindingSource
            // 
            this.ciudadesBindingSource.DataMember = "Ciudades";
            this.ciudadesBindingSource.DataSource = this.dSCOCOA;
            // 
            // dSCOCOA
            // 
            this.dSCOCOA.DataSetName = "DSCOCOA";
            this.dSCOCOA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.ciudadesBindingNavigatorSaveItem_Click);
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
            // bindingNavigatorSearch
            // 
            this.bindingNavigatorSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSearch.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSearch.Image")));
            this.bindingNavigatorSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSearch.Name = "bindingNavigatorSearch";
            this.bindingNavigatorSearch.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorSearch.Text = "toolStripButton3";
            this.bindingNavigatorSearch.ToolTipText = "Buscar";
            this.bindingNavigatorSearch.Click += new System.EventHandler(this.bindingNavigatorSearch_Click);
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
            // ciudadesDataGridView
            // 
            this.ciudadesDataGridView.AllowUserToAddRows = false;
            this.ciudadesDataGridView.AllowUserToDeleteRows = false;
            this.ciudadesDataGridView.AllowUserToOrderColumns = true;
            this.ciudadesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ciudadesDataGridView.AutoGenerateColumns = false;
            this.ciudadesDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ciudadesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ciudadesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ciudadesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.ciudadesDataGridView.DataSource = this.ciudadesBindingSource;
            this.ciudadesDataGridView.Location = new System.Drawing.Point(0, 142);
            this.ciudadesDataGridView.Name = "ciudadesDataGridView";
            this.ciudadesDataGridView.ReadOnly = true;
            this.ciudadesDataGridView.Size = new System.Drawing.Size(447, 365);
            this.ciudadesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCiudad";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 41;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodigoCiudad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 65;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DescripcionCiudad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 88;
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
            // codigoCiudadTextBox
            // 
            this.codigoCiudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ciudadesBindingSource, "CodigoCiudad", true));
            this.codigoCiudadTextBox.Location = new System.Drawing.Point(91, 68);
            this.codigoCiudadTextBox.MaxLength = 5;
            this.codigoCiudadTextBox.Name = "codigoCiudadTextBox";
            this.codigoCiudadTextBox.ReadOnly = true;
            this.codigoCiudadTextBox.Size = new System.Drawing.Size(51, 20);
            this.codigoCiudadTextBox.TabIndex = 3;
            this.codigoCiudadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigoCiudadTextBox_KeyPress);
            // 
            // descripcionCiudadTextBox
            // 
            this.descripcionCiudadTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descripcionCiudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ciudadesBindingSource, "DescripcionCiudad", true));
            this.descripcionCiudadTextBox.Location = new System.Drawing.Point(91, 94);
            this.descripcionCiudadTextBox.Name = "descripcionCiudadTextBox";
            this.descripcionCiudadTextBox.ReadOnly = true;
            this.descripcionCiudadTextBox.Size = new System.Drawing.Size(280, 20);
            this.descripcionCiudadTextBox.TabIndex = 5;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.Checked = true;
            this.activoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.ciudadesBindingSource, "Activo", true));
            this.activoCheckBox.Enabled = false;
            this.activoCheckBox.Location = new System.Drawing.Point(91, 117);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(19, 24);
            this.activoCheckBox.TabIndex = 9;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
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
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.FormularioTableAdapter = null;
            this.tableAdapterManager.ImpoconsumoTableAdapter = null;
            this.tableAdapterManager.IntervaloPreciosTableAdapter = null;
            this.tableAdapterManager.IVATableAdapter = null;
            this.tableAdapterManager.ListadoClientesTableAdapter = null;
            this.tableAdapterManager.ListadoProveedoresTableAdapter = null;
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
            // 
            // idCiudadTextBox
            // 
            this.idCiudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ciudadesBindingSource, "IdCiudad", true));
            this.idCiudadTextBox.Enabled = false;
            this.idCiudadTextBox.Location = new System.Drawing.Point(91, 42);
            this.idCiudadTextBox.Name = "idCiudadTextBox";
            this.idCiudadTextBox.ReadOnly = true;
            this.idCiudadTextBox.Size = new System.Drawing.Size(51, 20);
            this.idCiudadTextBox.TabIndex = 7;
            // 
            // idCiudadLabel
            // 
            idCiudadLabel.AutoSize = true;
            idCiudadLabel.Location = new System.Drawing.Point(68, 45);
            idCiudadLabel.Name = "idCiudadLabel";
            idCiudadLabel.Size = new System.Drawing.Size(19, 13);
            idCiudadLabel.TabIndex = 6;
            idCiudadLabel.Text = "Id:";
            // 
            // frmCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(447, 507);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(idCiudadLabel);
            this.Controls.Add(this.idCiudadTextBox);
            this.Controls.Add(descripcionCiudadLabel);
            this.Controls.Add(this.descripcionCiudadTextBox);
            this.Controls.Add(codigoCiudadLabel);
            this.Controls.Add(this.codigoCiudadTextBox);
            this.Controls.Add(this.ciudadesDataGridView);
            this.Controls.Add(this.ciudadesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCiudad";
            this.Text = "Ciudades";
            this.Load += new System.EventHandler(this.frmCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingNavigator)).EndInit();
            this.ciudadesBindingNavigator.ResumeLayout(false);
            this.ciudadesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSCOCOA dSCOCOA;
        private System.Windows.Forms.BindingSource ciudadesBindingSource;
        private DSCOCOATableAdapters.CiudadesTableAdapter ciudadesTableAdapter;
        private DSCOCOATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ciudadesBindingNavigator;
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
        private System.Windows.Forms.DataGridView ciudadesDataGridView;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEdit;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancel;
        private System.Windows.Forms.TextBox codigoCiudadTextBox;
        private System.Windows.Forms.TextBox descripcionCiudadTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSearch;
        private System.Windows.Forms.TextBox idCiudadTextBox;
    }
}