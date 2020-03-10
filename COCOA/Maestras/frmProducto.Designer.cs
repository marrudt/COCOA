namespace COCOA.Maestras
{
    partial class frmProducto
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
            System.Windows.Forms.Label idTipoProductoLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label descripcionProductoLabel;
            System.Windows.Forms.Label idClaseLabel;
            System.Windows.Forms.Label modeloAnoLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label idIVALabel;
            System.Windows.Forms.Label idImpoconsumoLabel;
            System.Windows.Forms.Label notasLabel;
            System.Windows.Forms.Label detalleProductoLabel;
            System.Windows.Forms.Label activoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            this.dSCOCOA = new COCOA.DSCOCOA();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new COCOA.DSCOCOATableAdapters.ProductosTableAdapter();
            this.tableAdapterManager = new COCOA.DSCOCOATableAdapters.TableAdapterManager();
            this.productosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productosDataGridView = new System.Windows.Forms.DataGridView();
            this.idTipoProductoComboBox = new System.Windows.Forms.ComboBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionProductoTextBox = new System.Windows.Forms.TextBox();
            this.idClaseComboBox = new System.Windows.Forms.ComboBox();
            this.modeloAnoTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.idIVAComboBox = new System.Windows.Forms.ComboBox();
            this.idImpoconsumoComboBox = new System.Windows.Forms.ComboBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.detalleProductoTextBox = new System.Windows.Forms.TextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.bindingNavigatorEdit = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCancel = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSearch = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorExit = new System.Windows.Forms.ToolStripButton();
            this.tipoProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoProductoTableAdapter = new COCOA.DSCOCOATableAdapters.TipoProductoTableAdapter();
            this.claseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.claseTableAdapter = new COCOA.DSCOCOATableAdapters.ClaseTableAdapter();
            this.iVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iVATableAdapter = new COCOA.DSCOCOATableAdapters.IVATableAdapter();
            this.impoconsumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.impoconsumoTableAdapter = new COCOA.DSCOCOATableAdapters.ImpoconsumoTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            idTipoProductoLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            descripcionProductoLabel = new System.Windows.Forms.Label();
            idClaseLabel = new System.Windows.Forms.Label();
            modeloAnoLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            idIVALabel = new System.Windows.Forms.Label();
            idImpoconsumoLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            detalleProductoLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingNavigator)).BeginInit();
            this.productosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.impoconsumoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idTipoProductoLabel
            // 
            idTipoProductoLabel.AutoSize = true;
            idTipoProductoLabel.Location = new System.Drawing.Point(61, 45);
            idTipoProductoLabel.Name = "idTipoProductoLabel";
            idTipoProductoLabel.Size = new System.Drawing.Size(35, 13);
            idTipoProductoLabel.TabIndex = 2;
            idTipoProductoLabel.Text = "Tipo*:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(177, 45);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(47, 13);
            codigoLabel.TabIndex = 4;
            codigoLabel.Text = "Codigo*:";
            // 
            // descripcionProductoLabel
            // 
            descripcionProductoLabel.AutoSize = true;
            descripcionProductoLabel.Location = new System.Drawing.Point(26, 72);
            descripcionProductoLabel.Name = "descripcionProductoLabel";
            descripcionProductoLabel.Size = new System.Drawing.Size(70, 13);
            descripcionProductoLabel.TabIndex = 6;
            descripcionProductoLabel.Text = "Descripción*:";
            // 
            // idClaseLabel
            // 
            idClaseLabel.AutoSize = true;
            idClaseLabel.Location = new System.Drawing.Point(56, 97);
            idClaseLabel.Name = "idClaseLabel";
            idClaseLabel.Size = new System.Drawing.Size(40, 13);
            idClaseLabel.TabIndex = 8;
            idClaseLabel.Text = "Clase*:";
            // 
            // modeloAnoLabel
            // 
            modeloAnoLabel.AutoSize = true;
            modeloAnoLabel.Location = new System.Drawing.Point(259, 98);
            modeloAnoLabel.Name = "modeloAnoLabel";
            modeloAnoLabel.Size = new System.Drawing.Size(71, 13);
            modeloAnoLabel.TabIndex = 10;
            modeloAnoLabel.Text = "Modelo Año*:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(52, 125);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(44, 13);
            precioLabel.TabIndex = 12;
            precioLabel.Text = "Precio*:";
            // 
            // idIVALabel
            // 
            idIVALabel.AutoSize = true;
            idIVALabel.Location = new System.Drawing.Point(65, 151);
            idIVALabel.Name = "idIVALabel";
            idIVALabel.Size = new System.Drawing.Size(31, 13);
            idIVALabel.TabIndex = 14;
            idIVALabel.Text = "IVA*:";
            // 
            // idImpoconsumoLabel
            // 
            idImpoconsumoLabel.AutoSize = true;
            idImpoconsumoLabel.Location = new System.Drawing.Point(16, 175);
            idImpoconsumoLabel.Name = "idImpoconsumoLabel";
            idImpoconsumoLabel.Size = new System.Drawing.Size(80, 13);
            idImpoconsumoLabel.TabIndex = 16;
            idImpoconsumoLabel.Text = "Impoconsumo*:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.Location = new System.Drawing.Point(432, 126);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(38, 13);
            notasLabel.TabIndex = 18;
            notasLabel.Text = "Notas:";
            // 
            // detalleProductoLabel
            // 
            detalleProductoLabel.AutoSize = true;
            detalleProductoLabel.Location = new System.Drawing.Point(427, 45);
            detalleProductoLabel.Name = "detalleProductoLabel";
            detalleProductoLabel.Size = new System.Drawing.Size(43, 13);
            detalleProductoLabel.TabIndex = 20;
            detalleProductoLabel.Text = "Detalle:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(354, 126);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 22;
            activoLabel.Text = "Activo:";
            // 
            // dSCOCOA
            // 
            this.dSCOCOA.DataSetName = "DSCOCOA";
            this.dSCOCOA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.dSCOCOA;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CilindrajesTableAdapter = null;
            this.tableAdapterManager.ClaseTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.CotizacionDetalleTableAdapter = null;
            this.tableAdapterManager.CotizacionTableAdapter = null;
            this.tableAdapterManager.ImpoconsumoTableAdapter = null;
            this.tableAdapterManager.IntervaloPreciosTableAdapter = null;
            this.tableAdapterManager.IVATableAdapter = null;
            this.tableAdapterManager.NumeroPasajerosTableAdapter = null;
            this.tableAdapterManager.OrdenCompraDetalleTableAdapter = null;
            this.tableAdapterManager.OrdenCompraTableAdapter = null;
            this.tableAdapterManager.PermisoRolTableAdapter = null;
            this.tableAdapterManager.PesoBrutoVhTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.SegmentosTableAdapter = null;
            this.tableAdapterManager.TipoProductoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = COCOA.DSCOCOATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // productosBindingNavigator
            // 
            this.productosBindingNavigator.AddNewItem = null;
            this.productosBindingNavigator.BindingSource = this.productosBindingSource;
            this.productosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productosBindingNavigator.DeleteItem = null;
            this.productosBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.productosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productosBindingNavigator.Name = "productosBindingNavigator";
            this.productosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productosBindingNavigator.Size = new System.Drawing.Size(956, 31);
            this.productosBindingNavigator.TabIndex = 0;
            this.productosBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.productosBindingNavigatorSaveItem_Click);
            // 
            // productosDataGridView
            // 
            this.productosDataGridView.AllowUserToAddRows = false;
            this.productosDataGridView.AllowUserToDeleteRows = false;
            this.productosDataGridView.AllowUserToOrderColumns = true;
            this.productosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productosDataGridView.AutoGenerateColumns = false;
            this.productosDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.productosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.productosDataGridView.DataSource = this.productosBindingSource;
            this.productosDataGridView.Location = new System.Drawing.Point(0, 202);
            this.productosDataGridView.Name = "productosDataGridView";
            this.productosDataGridView.ReadOnly = true;
            this.productosDataGridView.Size = new System.Drawing.Size(956, 359);
            this.productosDataGridView.TabIndex = 1;
            // 
            // idTipoProductoComboBox
            // 
            this.idTipoProductoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productosBindingSource, "IdTipoProducto", true));
            this.idTipoProductoComboBox.DataSource = this.tipoProductoBindingSource;
            this.idTipoProductoComboBox.DisplayMember = "DescripcionTipoProducto";
            this.idTipoProductoComboBox.Enabled = false;
            this.idTipoProductoComboBox.FormattingEnabled = true;
            this.idTipoProductoComboBox.Location = new System.Drawing.Point(98, 42);
            this.idTipoProductoComboBox.Name = "idTipoProductoComboBox";
            this.idTipoProductoComboBox.Size = new System.Drawing.Size(53, 21);
            this.idTipoProductoComboBox.TabIndex = 3;
            this.idTipoProductoComboBox.ValueMember = "IdTipoProducto";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(226, 42);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.ReadOnly = true;
            this.codigoTextBox.Size = new System.Drawing.Size(182, 20);
            this.codigoTextBox.TabIndex = 5;
            this.codigoTextBox.TextChanged += new System.EventHandler(this.codigoTextBox_TextChanged);
            // 
            // descripcionProductoTextBox
            // 
            this.descripcionProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "DescripcionProducto", true));
            this.descripcionProductoTextBox.Location = new System.Drawing.Point(99, 68);
            this.descripcionProductoTextBox.Name = "descripcionProductoTextBox";
            this.descripcionProductoTextBox.ReadOnly = true;
            this.descripcionProductoTextBox.Size = new System.Drawing.Size(309, 20);
            this.descripcionProductoTextBox.TabIndex = 7;
            // 
            // idClaseComboBox
            // 
            this.idClaseComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productosBindingSource, "IdClase", true));
            this.idClaseComboBox.DataSource = this.claseBindingSource;
            this.idClaseComboBox.DisplayMember = "DescripcionClase";
            this.idClaseComboBox.Enabled = false;
            this.idClaseComboBox.FormattingEnabled = true;
            this.idClaseComboBox.Location = new System.Drawing.Point(99, 94);
            this.idClaseComboBox.Name = "idClaseComboBox";
            this.idClaseComboBox.Size = new System.Drawing.Size(140, 21);
            this.idClaseComboBox.TabIndex = 9;
            this.idClaseComboBox.ValueMember = "IdClase";
            // 
            // modeloAnoTextBox
            // 
            this.modeloAnoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "ModeloAno", true));
            this.modeloAnoTextBox.Location = new System.Drawing.Point(332, 95);
            this.modeloAnoTextBox.Name = "modeloAnoTextBox";
            this.modeloAnoTextBox.ReadOnly = true;
            this.modeloAnoTextBox.Size = new System.Drawing.Size(76, 20);
            this.modeloAnoTextBox.TabIndex = 11;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(99, 122);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(140, 20);
            this.precioTextBox.TabIndex = 13;
            // 
            // idIVAComboBox
            // 
            this.idIVAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productosBindingSource, "IdIVA", true));
            this.idIVAComboBox.DataSource = this.iVABindingSource;
            this.idIVAComboBox.DisplayMember = "DescripcionIVA";
            this.idIVAComboBox.Enabled = false;
            this.idIVAComboBox.FormattingEnabled = true;
            this.idIVAComboBox.Location = new System.Drawing.Point(99, 148);
            this.idIVAComboBox.Name = "idIVAComboBox";
            this.idIVAComboBox.Size = new System.Drawing.Size(140, 21);
            this.idIVAComboBox.TabIndex = 15;
            this.idIVAComboBox.ValueMember = "IdIVA";
            // 
            // idImpoconsumoComboBox
            // 
            this.idImpoconsumoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productosBindingSource, "IdImpoconsumo", true));
            this.idImpoconsumoComboBox.DataSource = this.impoconsumoBindingSource;
            this.idImpoconsumoComboBox.DisplayMember = "DescripcionImpoconsumo";
            this.idImpoconsumoComboBox.Enabled = false;
            this.idImpoconsumoComboBox.FormattingEnabled = true;
            this.idImpoconsumoComboBox.Location = new System.Drawing.Point(99, 175);
            this.idImpoconsumoComboBox.Name = "idImpoconsumoComboBox";
            this.idImpoconsumoComboBox.Size = new System.Drawing.Size(140, 21);
            this.idImpoconsumoComboBox.TabIndex = 17;
            this.idImpoconsumoComboBox.ValueMember = "IdImpoconsumo";
            // 
            // notasTextBox
            // 
            this.notasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Notas", true));
            this.notasTextBox.Location = new System.Drawing.Point(476, 122);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.ReadOnly = true;
            this.notasTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notasTextBox.Size = new System.Drawing.Size(463, 72);
            this.notasTextBox.TabIndex = 19;
            // 
            // detalleProductoTextBox
            // 
            this.detalleProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "DetalleProducto", true));
            this.detalleProductoTextBox.Location = new System.Drawing.Point(476, 42);
            this.detalleProductoTextBox.Multiline = true;
            this.detalleProductoTextBox.Name = "detalleProductoTextBox";
            this.detalleProductoTextBox.ReadOnly = true;
            this.detalleProductoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.detalleProductoTextBox.Size = new System.Drawing.Size(463, 68);
            this.detalleProductoTextBox.TabIndex = 21;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productosBindingSource, "Activo", true));
            this.activoCheckBox.Enabled = false;
            this.activoCheckBox.Location = new System.Drawing.Point(396, 121);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(24, 24);
            this.activoCheckBox.TabIndex = 23;
            this.activoCheckBox.UseVisualStyleBackColor = true;
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
            // bindingNavigatorCancel
            // 
            this.bindingNavigatorCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorCancel.Enabled = false;
            this.bindingNavigatorCancel.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorCancel.Image")));
            this.bindingNavigatorCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCancel.Name = "bindingNavigatorCancel";
            this.bindingNavigatorCancel.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorCancel.Text = "toolStripButton1";
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
            // tipoProductoBindingSource
            // 
            this.tipoProductoBindingSource.DataMember = "TipoProducto";
            this.tipoProductoBindingSource.DataSource = this.dSCOCOA;
            // 
            // tipoProductoTableAdapter
            // 
            this.tipoProductoTableAdapter.ClearBeforeFill = true;
            // 
            // claseBindingSource
            // 
            this.claseBindingSource.DataMember = "Clase";
            this.claseBindingSource.DataSource = this.dSCOCOA;
            // 
            // claseTableAdapter
            // 
            this.claseTableAdapter.ClearBeforeFill = true;
            // 
            // iVABindingSource
            // 
            this.iVABindingSource.DataMember = "IVA";
            this.iVABindingSource.DataSource = this.dSCOCOA;
            // 
            // iVATableAdapter
            // 
            this.iVATableAdapter.ClearBeforeFill = true;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdProducto";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdProducto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdTipoProducto";
            this.dataGridViewTextBoxColumn2.DataSource = this.tipoProductoBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "DescripcionTipoProducto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "IdTipoProducto";
            this.dataGridViewTextBoxColumn2.Width = 142;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Código";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 65;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DescripcionProducto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 88;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DetalleProducto";
            this.dataGridViewTextBoxColumn5.HeaderText = "DetalleProducto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdClase";
            this.dataGridViewTextBoxColumn6.DataSource = this.claseBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "DescripcionClase";
            this.dataGridViewTextBoxColumn6.HeaderText = "Clase";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "IdClase";
            this.dataGridViewTextBoxColumn6.Width = 141;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ModeloAno";
            this.dataGridViewTextBoxColumn7.HeaderText = "Modelo Año";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 89;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn8.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 62;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IdIVA";
            this.dataGridViewTextBoxColumn9.DataSource = this.iVABindingSource;
            this.dataGridViewTextBoxColumn9.DisplayMember = "DescripcionIVA";
            this.dataGridViewTextBoxColumn9.HeaderText = "IVA";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "IdIVA";
            this.dataGridViewTextBoxColumn9.Width = 142;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "IdImpoconsumo";
            this.dataGridViewTextBoxColumn10.DataSource = this.impoconsumoBindingSource;
            this.dataGridViewTextBoxColumn10.DisplayMember = "DescripcionImpoconsumo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Impoconsumo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "IdImpoconsumo";
            this.dataGridViewTextBoxColumn10.Width = 141;
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
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Activo";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Activo";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 43;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 562);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(detalleProductoLabel);
            this.Controls.Add(this.detalleProductoTextBox);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(idImpoconsumoLabel);
            this.Controls.Add(this.idImpoconsumoComboBox);
            this.Controls.Add(idIVALabel);
            this.Controls.Add(this.idIVAComboBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(modeloAnoLabel);
            this.Controls.Add(this.modeloAnoTextBox);
            this.Controls.Add(idClaseLabel);
            this.Controls.Add(this.idClaseComboBox);
            this.Controls.Add(descripcionProductoLabel);
            this.Controls.Add(this.descripcionProductoTextBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(idTipoProductoLabel);
            this.Controls.Add(this.idTipoProductoComboBox);
            this.Controls.Add(this.productosDataGridView);
            this.Controls.Add(this.productosBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProducto";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingNavigator)).EndInit();
            this.productosBindingNavigator.ResumeLayout(false);
            this.productosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.impoconsumoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSCOCOA dSCOCOA;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private DSCOCOATableAdapters.ProductosTableAdapter productosTableAdapter;
        private DSCOCOATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productosBindingNavigator;
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
        private System.Windows.Forms.DataGridView productosDataGridView;
        private System.Windows.Forms.ComboBox idTipoProductoComboBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox descripcionProductoTextBox;
        private System.Windows.Forms.ComboBox idClaseComboBox;
        private System.Windows.Forms.TextBox modeloAnoTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.ComboBox idIVAComboBox;
        private System.Windows.Forms.ComboBox idImpoconsumoComboBox;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.TextBox detalleProductoTextBox;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEdit;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancel;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSearch;
        private System.Windows.Forms.ToolStripButton bindingNavigatorExit;
        private System.Windows.Forms.BindingSource tipoProductoBindingSource;
        private DSCOCOATableAdapters.TipoProductoTableAdapter tipoProductoTableAdapter;
        private System.Windows.Forms.BindingSource claseBindingSource;
        private DSCOCOATableAdapters.ClaseTableAdapter claseTableAdapter;
        private System.Windows.Forms.BindingSource iVABindingSource;
        private DSCOCOATableAdapters.IVATableAdapter iVATableAdapter;
        private System.Windows.Forms.BindingSource impoconsumoBindingSource;
        private DSCOCOATableAdapters.ImpoconsumoTableAdapter impoconsumoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}