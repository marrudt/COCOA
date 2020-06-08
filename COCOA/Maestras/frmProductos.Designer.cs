namespace COCOA.Maestras
{
    partial class frmProductos
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
            System.Windows.Forms.Label codigoProductoLabel;
            System.Windows.Forms.Label idProductoLabel;
            System.Windows.Forms.Label descripcionProductoLabel;
            System.Windows.Forms.Label idClaseLabel;
            System.Windows.Forms.Label modeloAnoLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label idIVALabel;
            System.Windows.Forms.Label idImpoconsumoLabel;
            System.Windows.Forms.Label idSegmentoLabel;
            System.Windows.Forms.Label idNumeroPasajerosLabel;
            System.Windows.Forms.Label idPesoBrutoVhLabel;
            System.Windows.Forms.Label idIntervaloPrecioLabel;
            System.Windows.Forms.Label detalleProductoLabel;
            System.Windows.Forms.Label notasLabel;
            System.Windows.Forms.Label idCilindrajeLabel;
            System.Windows.Forms.Label activoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dSCOCOA = new COCOA.DSCOCOA();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new COCOA.DSCOCOATableAdapters.ProductosTableAdapter();
            this.tableAdapterManager = new COCOA.DSCOCOATableAdapters.TableAdapterManager();
            this.cilindrajesTableAdapter = new COCOA.DSCOCOATableAdapters.CilindrajesTableAdapter();
            this.claseTableAdapter = new COCOA.DSCOCOATableAdapters.ClaseTableAdapter();
            this.impoconsumoTableAdapter = new COCOA.DSCOCOATableAdapters.ImpoconsumoTableAdapter();
            this.intervaloPreciosTableAdapter = new COCOA.DSCOCOATableAdapters.IntervaloPreciosTableAdapter();
            this.iVATableAdapter = new COCOA.DSCOCOATableAdapters.IVATableAdapter();
            this.numeroPasajerosTableAdapter = new COCOA.DSCOCOATableAdapters.NumeroPasajerosTableAdapter();
            this.pesoBrutoVhTableAdapter = new COCOA.DSCOCOATableAdapters.PesoBrutoVhTableAdapter();
            this.segmentosTableAdapter = new COCOA.DSCOCOATableAdapters.SegmentosTableAdapter();
            this.tipoProductoTableAdapter = new COCOA.DSCOCOATableAdapters.TipoProductoTableAdapter();
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
            this.bindingNavigatorEdit = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCancel = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSearch = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorExit = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPrint = new System.Windows.Forms.ToolStripButton();
            this.productosDataGridView = new System.Windows.Forms.DataGridView();
            this.tipoProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.claseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.impoconsumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segmentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cilindrajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroPasajerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pesoBrutoVhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intervaloPreciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTipoProductoComboBox = new System.Windows.Forms.ComboBox();
            this.codigoProductoTextBox = new System.Windows.Forms.TextBox();
            this.idProductoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionProductoTextBox = new System.Windows.Forms.TextBox();
            this.idClaseComboBox = new System.Windows.Forms.ComboBox();
            this.modeloAnoTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.idIVAComboBox = new System.Windows.Forms.ComboBox();
            this.idImpoconsumoComboBox = new System.Windows.Forms.ComboBox();
            this.idSegmentoComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idCilindrajeComboBox = new System.Windows.Forms.ComboBox();
            this.idIntervaloPrecioComboBox = new System.Windows.Forms.ComboBox();
            this.idPesoBrutoVhComboBox = new System.Windows.Forms.ComboBox();
            this.idNumeroPasajerosComboBox = new System.Windows.Forms.ComboBox();
            this.detalleProductoTextBox = new System.Windows.Forms.TextBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            idTipoProductoLabel = new System.Windows.Forms.Label();
            codigoProductoLabel = new System.Windows.Forms.Label();
            idProductoLabel = new System.Windows.Forms.Label();
            descripcionProductoLabel = new System.Windows.Forms.Label();
            idClaseLabel = new System.Windows.Forms.Label();
            modeloAnoLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            idIVALabel = new System.Windows.Forms.Label();
            idImpoconsumoLabel = new System.Windows.Forms.Label();
            idSegmentoLabel = new System.Windows.Forms.Label();
            idNumeroPasajerosLabel = new System.Windows.Forms.Label();
            idPesoBrutoVhLabel = new System.Windows.Forms.Label();
            idIntervaloPrecioLabel = new System.Windows.Forms.Label();
            detalleProductoLabel = new System.Windows.Forms.Label();
            notasLabel = new System.Windows.Forms.Label();
            idCilindrajeLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.segmentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cilindrajesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroPasajerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoBrutoVhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervaloPreciosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idTipoProductoLabel
            // 
            idTipoProductoLabel.AutoSize = true;
            idTipoProductoLabel.Location = new System.Drawing.Point(67, 48);
            idTipoProductoLabel.Name = "idTipoProductoLabel";
            idTipoProductoLabel.Size = new System.Drawing.Size(31, 13);
            idTipoProductoLabel.TabIndex = 0;
            idTipoProductoLabel.Text = "Tipo:";
            // 
            // codigoProductoLabel
            // 
            codigoProductoLabel.AutoSize = true;
            codigoProductoLabel.Location = new System.Drawing.Point(279, 48);
            codigoProductoLabel.Name = "codigoProductoLabel";
            codigoProductoLabel.Size = new System.Drawing.Size(43, 13);
            codigoProductoLabel.TabIndex = 2;
            codigoProductoLabel.Text = "Código:";
            // 
            // idProductoLabel
            // 
            idProductoLabel.AutoSize = true;
            idProductoLabel.Location = new System.Drawing.Point(455, 48);
            idProductoLabel.Name = "idProductoLabel";
            idProductoLabel.Size = new System.Drawing.Size(19, 13);
            idProductoLabel.TabIndex = 4;
            idProductoLabel.Text = "Id:";
            // 
            // descripcionProductoLabel
            // 
            descripcionProductoLabel.AutoSize = true;
            descripcionProductoLabel.Location = new System.Drawing.Point(32, 74);
            descripcionProductoLabel.Name = "descripcionProductoLabel";
            descripcionProductoLabel.Size = new System.Drawing.Size(66, 13);
            descripcionProductoLabel.TabIndex = 6;
            descripcionProductoLabel.Text = "Descripción:";
            // 
            // idClaseLabel
            // 
            idClaseLabel.AutoSize = true;
            idClaseLabel.Location = new System.Drawing.Point(62, 101);
            idClaseLabel.Name = "idClaseLabel";
            idClaseLabel.Size = new System.Drawing.Size(36, 13);
            idClaseLabel.TabIndex = 8;
            idClaseLabel.Text = "Clase:";
            // 
            // modeloAnoLabel
            // 
            modeloAnoLabel.AutoSize = true;
            modeloAnoLabel.Location = new System.Drawing.Point(40, 25);
            modeloAnoLabel.Name = "modeloAnoLabel";
            modeloAnoLabel.Size = new System.Drawing.Size(67, 13);
            modeloAnoLabel.TabIndex = 0;
            modeloAnoLabel.Text = "Modelo Año:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(285, 102);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(79, 13);
            precioLabel.TabIndex = 10;
            precioLabel.Text = "Precio Unitario:";
            // 
            // idIVALabel
            // 
            idIVALabel.AutoSize = true;
            idIVALabel.Location = new System.Drawing.Point(71, 128);
            idIVALabel.Name = "idIVALabel";
            idIVALabel.Size = new System.Drawing.Size(27, 13);
            idIVALabel.TabIndex = 12;
            idIVALabel.Text = "IVA:";
            // 
            // idImpoconsumoLabel
            // 
            idImpoconsumoLabel.AutoSize = true;
            idImpoconsumoLabel.Location = new System.Drawing.Point(288, 128);
            idImpoconsumoLabel.Name = "idImpoconsumoLabel";
            idImpoconsumoLabel.Size = new System.Drawing.Size(76, 13);
            idImpoconsumoLabel.TabIndex = 14;
            idImpoconsumoLabel.Text = "Impoconsumo:";
            // 
            // idSegmentoLabel
            // 
            idSegmentoLabel.AutoSize = true;
            idSegmentoLabel.Location = new System.Drawing.Point(49, 52);
            idSegmentoLabel.Name = "idSegmentoLabel";
            idSegmentoLabel.Size = new System.Drawing.Size(58, 13);
            idSegmentoLabel.TabIndex = 2;
            idSegmentoLabel.Text = "Segmento:";
            // 
            // idNumeroPasajerosLabel
            // 
            idNumeroPasajerosLabel.AutoSize = true;
            idNumeroPasajerosLabel.Location = new System.Drawing.Point(11, 106);
            idNumeroPasajerosLabel.Name = "idNumeroPasajerosLabel";
            idNumeroPasajerosLabel.Size = new System.Drawing.Size(96, 13);
            idNumeroPasajerosLabel.TabIndex = 6;
            idNumeroPasajerosLabel.Text = "Número Pasajeros:";
            // 
            // idPesoBrutoVhLabel
            // 
            idPesoBrutoVhLabel.AutoSize = true;
            idPesoBrutoVhLabel.Location = new System.Drawing.Point(29, 133);
            idPesoBrutoVhLabel.Name = "idPesoBrutoVhLabel";
            idPesoBrutoVhLabel.Size = new System.Drawing.Size(78, 13);
            idPesoBrutoVhLabel.TabIndex = 8;
            idPesoBrutoVhLabel.Text = "Peso Bruto Vh:";
            // 
            // idIntervaloPrecioLabel
            // 
            idIntervaloPrecioLabel.AutoSize = true;
            idIntervaloPrecioLabel.Location = new System.Drawing.Point(23, 160);
            idIntervaloPrecioLabel.Name = "idIntervaloPrecioLabel";
            idIntervaloPrecioLabel.Size = new System.Drawing.Size(84, 13);
            idIntervaloPrecioLabel.TabIndex = 10;
            idIntervaloPrecioLabel.Text = "Intervalo Precio:";
            // 
            // detalleProductoLabel
            // 
            detalleProductoLabel.AutoSize = true;
            detalleProductoLabel.Location = new System.Drawing.Point(55, 155);
            detalleProductoLabel.Name = "detalleProductoLabel";
            detalleProductoLabel.Size = new System.Drawing.Size(43, 13);
            detalleProductoLabel.TabIndex = 16;
            detalleProductoLabel.Text = "Detalle:";
            // 
            // notasLabel
            // 
            notasLabel.AutoSize = true;
            notasLabel.Location = new System.Drawing.Point(60, 224);
            notasLabel.Name = "notasLabel";
            notasLabel.Size = new System.Drawing.Size(38, 13);
            notasLabel.TabIndex = 18;
            notasLabel.Text = "Notas:";
            // 
            // idCilindrajeLabel
            // 
            idCilindrajeLabel.AutoSize = true;
            idCilindrajeLabel.Location = new System.Drawing.Point(55, 79);
            idCilindrajeLabel.Name = "idCilindrajeLabel";
            idCilindrajeLabel.Size = new System.Drawing.Size(52, 13);
            idCilindrajeLabel.TabIndex = 4;
            idCilindrajeLabel.Text = "Cilindraje:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(542, 240);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 20;
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
            this.tableAdapterManager.CilindrajesTableAdapter = this.cilindrajesTableAdapter;
            this.tableAdapterManager.CiudadesTableAdapter = null;
            this.tableAdapterManager.ClaseTableAdapter = this.claseTableAdapter;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.CotizacionDetalleTableAdapter = null;
            this.tableAdapterManager.CotizacionTableAdapter = null;
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.FormularioTableAdapter = null;
            this.tableAdapterManager.ImpoconsumoTableAdapter = this.impoconsumoTableAdapter;
            this.tableAdapterManager.IntervaloPreciosTableAdapter = this.intervaloPreciosTableAdapter;
            this.tableAdapterManager.IVATableAdapter = this.iVATableAdapter;
            this.tableAdapterManager.ListadoClientesTableAdapter = null;
            this.tableAdapterManager.ListadoProveedoresTableAdapter = null;
            this.tableAdapterManager.NumeroPasajerosTableAdapter = this.numeroPasajerosTableAdapter;
            this.tableAdapterManager.OrdenCompraDetalleTableAdapter = null;
            this.tableAdapterManager.OrdenCompraTableAdapter = null;
            this.tableAdapterManager.PaisesTableAdapter = null;
            this.tableAdapterManager.PermisoRolTableAdapter = null;
            this.tableAdapterManager.PesoBrutoVhTableAdapter = this.pesoBrutoVhTableAdapter;
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.SegmentosTableAdapter = this.segmentosTableAdapter;
            this.tableAdapterManager.TipoProductoTableAdapter = this.tipoProductoTableAdapter;
            this.tableAdapterManager.UpdateOrder = COCOA.DSCOCOATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // cilindrajesTableAdapter
            // 
            this.cilindrajesTableAdapter.ClearBeforeFill = true;
            // 
            // claseTableAdapter
            // 
            this.claseTableAdapter.ClearBeforeFill = true;
            // 
            // impoconsumoTableAdapter
            // 
            this.impoconsumoTableAdapter.ClearBeforeFill = true;
            // 
            // intervaloPreciosTableAdapter
            // 
            this.intervaloPreciosTableAdapter.ClearBeforeFill = true;
            // 
            // iVATableAdapter
            // 
            this.iVATableAdapter.ClearBeforeFill = true;
            // 
            // numeroPasajerosTableAdapter
            // 
            this.numeroPasajerosTableAdapter.ClearBeforeFill = true;
            // 
            // pesoBrutoVhTableAdapter
            // 
            this.pesoBrutoVhTableAdapter.ClearBeforeFill = true;
            // 
            // segmentosTableAdapter
            // 
            this.segmentosTableAdapter.ClearBeforeFill = true;
            // 
            // tipoProductoTableAdapter
            // 
            this.tipoProductoTableAdapter.ClearBeforeFill = true;
            // 
            // productosBindingNavigator
            // 
            this.productosBindingNavigator.AddNewItem = null;
            this.productosBindingNavigator.BackColor = System.Drawing.Color.Transparent;
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
            this.bindingNavigatorExit,
            this.bindingNavigatorPrint});
            this.productosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productosBindingNavigator.Name = "productosBindingNavigator";
            this.productosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productosBindingNavigator.Size = new System.Drawing.Size(1284, 31);
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
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.productosBindingNavigatorSaveItem_Click);
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
            // bindingNavigatorPrint
            // 
            this.bindingNavigatorPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorPrint.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorPrint.Image")));
            this.bindingNavigatorPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorPrint.Name = "bindingNavigatorPrint";
            this.bindingNavigatorPrint.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorPrint.Text = "toolStripButton1";
            this.bindingNavigatorPrint.ToolTipText = "Imprimir";
            this.bindingNavigatorPrint.Click += new System.EventHandler(this.bindingNavigatorPrint_Click);
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
            this.productosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productosDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.productosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewCheckBoxColumn1});
            this.productosDataGridView.DataSource = this.productosBindingSource;
            this.productosDataGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.productosDataGridView.Location = new System.Drawing.Point(0, 281);
            this.productosDataGridView.Name = "productosDataGridView";
            this.productosDataGridView.ReadOnly = true;
            this.productosDataGridView.Size = new System.Drawing.Size(1284, 414);
            this.productosDataGridView.TabIndex = 22;
            // 
            // tipoProductoBindingSource
            // 
            this.tipoProductoBindingSource.DataMember = "TipoProducto";
            this.tipoProductoBindingSource.DataSource = this.dSCOCOA;
            // 
            // claseBindingSource
            // 
            this.claseBindingSource.DataMember = "Clase";
            this.claseBindingSource.DataSource = this.dSCOCOA;
            // 
            // iVABindingSource
            // 
            this.iVABindingSource.DataMember = "IVA";
            this.iVABindingSource.DataSource = this.dSCOCOA;
            // 
            // impoconsumoBindingSource
            // 
            this.impoconsumoBindingSource.DataMember = "Impoconsumo";
            this.impoconsumoBindingSource.DataSource = this.dSCOCOA;
            // 
            // segmentosBindingSource
            // 
            this.segmentosBindingSource.DataMember = "Segmentos";
            this.segmentosBindingSource.DataSource = this.dSCOCOA;
            // 
            // cilindrajesBindingSource
            // 
            this.cilindrajesBindingSource.DataMember = "Cilindrajes";
            this.cilindrajesBindingSource.DataSource = this.dSCOCOA;
            // 
            // numeroPasajerosBindingSource
            // 
            this.numeroPasajerosBindingSource.DataMember = "NumeroPasajeros";
            this.numeroPasajerosBindingSource.DataSource = this.dSCOCOA;
            // 
            // pesoBrutoVhBindingSource
            // 
            this.pesoBrutoVhBindingSource.DataMember = "PesoBrutoVh";
            this.pesoBrutoVhBindingSource.DataSource = this.dSCOCOA;
            // 
            // intervaloPreciosBindingSource
            // 
            this.intervaloPreciosBindingSource.DataMember = "IntervaloPrecios";
            this.intervaloPreciosBindingSource.DataSource = this.dSCOCOA;
            // 
            // idTipoProductoComboBox
            // 
            this.idTipoProductoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productosBindingSource, "IdTipoProducto", true));
            this.idTipoProductoComboBox.DataSource = this.tipoProductoBindingSource;
            this.idTipoProductoComboBox.DisplayMember = "DescripcionTipoProducto";
            this.idTipoProductoComboBox.Enabled = false;
            this.idTipoProductoComboBox.FormattingEnabled = true;
            this.idTipoProductoComboBox.Location = new System.Drawing.Point(101, 45);
            this.idTipoProductoComboBox.Name = "idTipoProductoComboBox";
            this.idTipoProductoComboBox.Size = new System.Drawing.Size(153, 21);
            this.idTipoProductoComboBox.TabIndex = 1;
            this.idTipoProductoComboBox.ValueMember = "IdTipoProducto";
            // 
            // codigoProductoTextBox
            // 
            this.codigoProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "CodigoProducto", true));
            this.codigoProductoTextBox.Location = new System.Drawing.Point(325, 45);
            this.codigoProductoTextBox.Name = "codigoProductoTextBox";
            this.codigoProductoTextBox.ReadOnly = true;
            this.codigoProductoTextBox.Size = new System.Drawing.Size(114, 20);
            this.codigoProductoTextBox.TabIndex = 3;
            // 
            // idProductoTextBox
            // 
            this.idProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "IdProducto", true));
            this.idProductoTextBox.Location = new System.Drawing.Point(477, 45);
            this.idProductoTextBox.Name = "idProductoTextBox";
            this.idProductoTextBox.ReadOnly = true;
            this.idProductoTextBox.Size = new System.Drawing.Size(43, 20);
            this.idProductoTextBox.TabIndex = 5;
            // 
            // descripcionProductoTextBox
            // 
            this.descripcionProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "DescripcionProducto", true));
            this.descripcionProductoTextBox.Location = new System.Drawing.Point(101, 72);
            this.descripcionProductoTextBox.Name = "descripcionProductoTextBox";
            this.descripcionProductoTextBox.ReadOnly = true;
            this.descripcionProductoTextBox.Size = new System.Drawing.Size(419, 20);
            this.descripcionProductoTextBox.TabIndex = 7;
            // 
            // idClaseComboBox
            // 
            this.idClaseComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productosBindingSource, "IdClase", true));
            this.idClaseComboBox.DataSource = this.claseBindingSource;
            this.idClaseComboBox.DisplayMember = "DescripcionClase";
            this.idClaseComboBox.Enabled = false;
            this.idClaseComboBox.FormattingEnabled = true;
            this.idClaseComboBox.Location = new System.Drawing.Point(101, 98);
            this.idClaseComboBox.Name = "idClaseComboBox";
            this.idClaseComboBox.Size = new System.Drawing.Size(153, 21);
            this.idClaseComboBox.TabIndex = 9;
            this.idClaseComboBox.ValueMember = "IdClase";
            // 
            // modeloAnoTextBox
            // 
            this.modeloAnoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "ModeloAno", true));
            this.modeloAnoTextBox.Location = new System.Drawing.Point(110, 23);
            this.modeloAnoTextBox.Name = "modeloAnoTextBox";
            this.modeloAnoTextBox.ReadOnly = true;
            this.modeloAnoTextBox.Size = new System.Drawing.Size(61, 20);
            this.modeloAnoTextBox.TabIndex = 1;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Precio", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.precioTextBox.Location = new System.Drawing.Point(367, 98);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(153, 20);
            this.precioTextBox.TabIndex = 11;
            // 
            // idIVAComboBox
            // 
            this.idIVAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productosBindingSource, "IdIVA", true));
            this.idIVAComboBox.DataSource = this.iVABindingSource;
            this.idIVAComboBox.DisplayMember = "DescripcionIVA";
            this.idIVAComboBox.Enabled = false;
            this.idIVAComboBox.FormattingEnabled = true;
            this.idIVAComboBox.Location = new System.Drawing.Point(101, 125);
            this.idIVAComboBox.Name = "idIVAComboBox";
            this.idIVAComboBox.Size = new System.Drawing.Size(153, 21);
            this.idIVAComboBox.TabIndex = 13;
            this.idIVAComboBox.ValueMember = "IdIVA";
            // 
            // idImpoconsumoComboBox
            // 
            this.idImpoconsumoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productosBindingSource, "IdImpoconsumo", true));
            this.idImpoconsumoComboBox.DataSource = this.impoconsumoBindingSource;
            this.idImpoconsumoComboBox.DisplayMember = "DescripcionImpoconsumo";
            this.idImpoconsumoComboBox.Enabled = false;
            this.idImpoconsumoComboBox.FormattingEnabled = true;
            this.idImpoconsumoComboBox.Location = new System.Drawing.Point(367, 124);
            this.idImpoconsumoComboBox.Name = "idImpoconsumoComboBox";
            this.idImpoconsumoComboBox.Size = new System.Drawing.Size(153, 21);
            this.idImpoconsumoComboBox.TabIndex = 15;
            this.idImpoconsumoComboBox.ValueMember = "IdImpoconsumo";
            // 
            // idSegmentoComboBox
            // 
            this.idSegmentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productosBindingSource, "IdSegmento", true));
            this.idSegmentoComboBox.DataSource = this.segmentosBindingSource;
            this.idSegmentoComboBox.DisplayMember = "DescripcionSegmento";
            this.idSegmentoComboBox.Enabled = false;
            this.idSegmentoComboBox.FormattingEnabled = true;
            this.idSegmentoComboBox.Location = new System.Drawing.Point(110, 49);
            this.idSegmentoComboBox.Name = "idSegmentoComboBox";
            this.idSegmentoComboBox.Size = new System.Drawing.Size(288, 21);
            this.idSegmentoComboBox.TabIndex = 3;
            this.idSegmentoComboBox.ValueMember = "IdSegmento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idCilindrajeLabel);
            this.groupBox1.Controls.Add(this.idCilindrajeComboBox);
            this.groupBox1.Controls.Add(idIntervaloPrecioLabel);
            this.groupBox1.Controls.Add(this.idIntervaloPrecioComboBox);
            this.groupBox1.Controls.Add(idPesoBrutoVhLabel);
            this.groupBox1.Controls.Add(this.idPesoBrutoVhComboBox);
            this.groupBox1.Controls.Add(idNumeroPasajerosLabel);
            this.groupBox1.Controls.Add(this.idNumeroPasajerosComboBox);
            this.groupBox1.Controls.Add(this.modeloAnoTextBox);
            this.groupBox1.Controls.Add(idSegmentoLabel);
            this.groupBox1.Controls.Add(modeloAnoLabel);
            this.groupBox1.Controls.Add(this.idSegmentoComboBox);
            this.groupBox1.Location = new System.Drawing.Point(545, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 198);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vehículos";
            // 
            // idCilindrajeComboBox
            // 
            this.idCilindrajeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productosBindingSource, "IdCilindraje", true));
            this.idCilindrajeComboBox.DataSource = this.cilindrajesBindingSource;
            this.idCilindrajeComboBox.DisplayMember = "DescripcionCilindraje";
            this.idCilindrajeComboBox.Enabled = false;
            this.idCilindrajeComboBox.FormattingEnabled = true;
            this.idCilindrajeComboBox.Location = new System.Drawing.Point(110, 76);
            this.idCilindrajeComboBox.Name = "idCilindrajeComboBox";
            this.idCilindrajeComboBox.Size = new System.Drawing.Size(288, 21);
            this.idCilindrajeComboBox.TabIndex = 5;
            this.idCilindrajeComboBox.ValueMember = "IdCilindraje";
            // 
            // idIntervaloPrecioComboBox
            // 
            this.idIntervaloPrecioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productosBindingSource, "IdIntervaloPrecio", true));
            this.idIntervaloPrecioComboBox.DataSource = this.intervaloPreciosBindingSource;
            this.idIntervaloPrecioComboBox.DisplayMember = "DescripcionIntervaloPrecio";
            this.idIntervaloPrecioComboBox.Enabled = false;
            this.idIntervaloPrecioComboBox.FormattingEnabled = true;
            this.idIntervaloPrecioComboBox.Location = new System.Drawing.Point(110, 157);
            this.idIntervaloPrecioComboBox.Name = "idIntervaloPrecioComboBox";
            this.idIntervaloPrecioComboBox.Size = new System.Drawing.Size(288, 21);
            this.idIntervaloPrecioComboBox.TabIndex = 11;
            this.idIntervaloPrecioComboBox.ValueMember = "IdIntervaloPrecio";
            // 
            // idPesoBrutoVhComboBox
            // 
            this.idPesoBrutoVhComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productosBindingSource, "IdPesoBrutoVh", true));
            this.idPesoBrutoVhComboBox.DataSource = this.pesoBrutoVhBindingSource;
            this.idPesoBrutoVhComboBox.DisplayMember = "DescripcionPesoBrutoVh";
            this.idPesoBrutoVhComboBox.Enabled = false;
            this.idPesoBrutoVhComboBox.FormattingEnabled = true;
            this.idPesoBrutoVhComboBox.Location = new System.Drawing.Point(110, 130);
            this.idPesoBrutoVhComboBox.Name = "idPesoBrutoVhComboBox";
            this.idPesoBrutoVhComboBox.Size = new System.Drawing.Size(288, 21);
            this.idPesoBrutoVhComboBox.TabIndex = 9;
            this.idPesoBrutoVhComboBox.ValueMember = "IdPesoBrutoVh";
            // 
            // idNumeroPasajerosComboBox
            // 
            this.idNumeroPasajerosComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productosBindingSource, "IdNumeroPasajeros", true));
            this.idNumeroPasajerosComboBox.DataSource = this.numeroPasajerosBindingSource;
            this.idNumeroPasajerosComboBox.DisplayMember = "NumeroPasajeros";
            this.idNumeroPasajerosComboBox.Enabled = false;
            this.idNumeroPasajerosComboBox.FormattingEnabled = true;
            this.idNumeroPasajerosComboBox.Location = new System.Drawing.Point(110, 103);
            this.idNumeroPasajerosComboBox.Name = "idNumeroPasajerosComboBox";
            this.idNumeroPasajerosComboBox.Size = new System.Drawing.Size(288, 21);
            this.idNumeroPasajerosComboBox.TabIndex = 7;
            this.idNumeroPasajerosComboBox.ValueMember = "IdNumeroPasajeros";
            // 
            // detalleProductoTextBox
            // 
            this.detalleProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "DetalleProducto", true));
            this.detalleProductoTextBox.Location = new System.Drawing.Point(101, 152);
            this.detalleProductoTextBox.Multiline = true;
            this.detalleProductoTextBox.Name = "detalleProductoTextBox";
            this.detalleProductoTextBox.ReadOnly = true;
            this.detalleProductoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.detalleProductoTextBox.Size = new System.Drawing.Size(419, 66);
            this.detalleProductoTextBox.TabIndex = 17;
            // 
            // notasTextBox
            // 
            this.notasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Notas", true));
            this.notasTextBox.Location = new System.Drawing.Point(101, 224);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.ReadOnly = true;
            this.notasTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notasTextBox.Size = new System.Drawing.Size(419, 51);
            this.notasTextBox.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.Checked = true;
            this.activoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productosBindingSource, "Activo", true));
            this.activoCheckBox.Enabled = false;
            this.activoCheckBox.Location = new System.Drawing.Point(588, 235);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(15, 24);
            this.activoCheckBox.TabIndex = 21;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdProducto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 41;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdTipoProducto";
            this.dataGridViewTextBoxColumn2.DataSource = this.tipoProductoBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "DescripcionTipoProducto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "IdTipoProducto";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CodigoProducto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Código";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 65;
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
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdClase";
            this.dataGridViewTextBoxColumn6.DataSource = this.claseBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "DescripcionClase";
            this.dataGridViewTextBoxColumn6.HeaderText = "Clase";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "IdClase";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ModeloAno";
            this.dataGridViewTextBoxColumn7.HeaderText = "Modelo Año";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 60;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn8.HeaderText = "Precio Unitario";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 93;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "IdIVA";
            this.dataGridViewTextBoxColumn9.DataSource = this.iVABindingSource;
            this.dataGridViewTextBoxColumn9.DisplayMember = "Tarifa";
            this.dataGridViewTextBoxColumn9.HeaderText = "IVA";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "IdIVA";
            this.dataGridViewTextBoxColumn9.Width = 60;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "IdImpoconsumo";
            this.dataGridViewTextBoxColumn10.DataSource = this.impoconsumoBindingSource;
            this.dataGridViewTextBoxColumn10.DisplayMember = "Tarifa";
            this.dataGridViewTextBoxColumn10.HeaderText = "Impoconsumo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "IdImpoconsumo";
            this.dataGridViewTextBoxColumn10.Width = 60;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "IdSegmento";
            this.dataGridViewTextBoxColumn11.DataSource = this.segmentosBindingSource;
            this.dataGridViewTextBoxColumn11.DisplayMember = "DescripcionSegmento";
            this.dataGridViewTextBoxColumn11.HeaderText = "Segmento";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn11.ValueMember = "IdSegmento";
            this.dataGridViewTextBoxColumn11.Width = 250;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "IdCilindraje";
            this.dataGridViewTextBoxColumn12.DataSource = this.cilindrajesBindingSource;
            this.dataGridViewTextBoxColumn12.DisplayMember = "DescripcionCilindraje";
            this.dataGridViewTextBoxColumn12.HeaderText = "Cilindraje";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn12.ValueMember = "IdCilindraje";
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "IdNumeroPasajeros";
            this.dataGridViewTextBoxColumn13.DataSource = this.numeroPasajerosBindingSource;
            this.dataGridViewTextBoxColumn13.DisplayMember = "NumeroPasajeros";
            this.dataGridViewTextBoxColumn13.HeaderText = "Número Pasajeros";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn13.ValueMember = "IdNumeroPasajeros";
            this.dataGridViewTextBoxColumn13.Width = 280;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "IdPesoBrutoVh";
            this.dataGridViewTextBoxColumn14.DataSource = this.pesoBrutoVhBindingSource;
            this.dataGridViewTextBoxColumn14.DisplayMember = "DescripcionPesoBrutoVh";
            this.dataGridViewTextBoxColumn14.HeaderText = "Peso Bruto Vh";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn14.ValueMember = "IdPesoBrutoVh";
            this.dataGridViewTextBoxColumn14.Width = 300;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "IdIntervaloPrecio";
            this.dataGridViewTextBoxColumn15.DataSource = this.intervaloPreciosBindingSource;
            this.dataGridViewTextBoxColumn15.DisplayMember = "DescripcionIntervaloPrecio";
            this.dataGridViewTextBoxColumn15.HeaderText = "Intervalo Precio";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn15.ValueMember = "IdIntervaloPrecio";
            this.dataGridViewTextBoxColumn15.Width = 150;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Notas";
            this.dataGridViewTextBoxColumn16.HeaderText = "Notas";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
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
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 696);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(notasLabel);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(detalleProductoLabel);
            this.Controls.Add(this.detalleProductoTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(idImpoconsumoLabel);
            this.Controls.Add(this.idImpoconsumoComboBox);
            this.Controls.Add(idIVALabel);
            this.Controls.Add(this.idIVAComboBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(idClaseLabel);
            this.Controls.Add(this.idClaseComboBox);
            this.Controls.Add(descripcionProductoLabel);
            this.Controls.Add(this.descripcionProductoTextBox);
            this.Controls.Add(idProductoLabel);
            this.Controls.Add(this.idProductoTextBox);
            this.Controls.Add(codigoProductoLabel);
            this.Controls.Add(this.codigoProductoTextBox);
            this.Controls.Add(idTipoProductoLabel);
            this.Controls.Add(this.idTipoProductoComboBox);
            this.Controls.Add(this.productosDataGridView);
            this.Controls.Add(this.productosBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.segmentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cilindrajesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroPasajerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoBrutoVhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervaloPreciosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorEdit;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancel;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSearch;
        private System.Windows.Forms.ToolStripButton bindingNavigatorExit;
        private System.Windows.Forms.ComboBox idTipoProductoComboBox;
        private DSCOCOATableAdapters.TipoProductoTableAdapter tipoProductoTableAdapter;
        private System.Windows.Forms.BindingSource tipoProductoBindingSource;
        private System.Windows.Forms.TextBox codigoProductoTextBox;
        private System.Windows.Forms.TextBox idProductoTextBox;
        private System.Windows.Forms.TextBox descripcionProductoTextBox;
        private System.Windows.Forms.ComboBox idClaseComboBox;
        private System.Windows.Forms.TextBox modeloAnoTextBox;
        private DSCOCOATableAdapters.ClaseTableAdapter claseTableAdapter;
        private System.Windows.Forms.BindingSource claseBindingSource;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.ComboBox idIVAComboBox;
        private DSCOCOATableAdapters.IVATableAdapter iVATableAdapter;
        private System.Windows.Forms.BindingSource iVABindingSource;
        private DSCOCOATableAdapters.ImpoconsumoTableAdapter impoconsumoTableAdapter;
        private System.Windows.Forms.ComboBox idImpoconsumoComboBox;
        private System.Windows.Forms.BindingSource impoconsumoBindingSource;
        private System.Windows.Forms.ComboBox idSegmentoComboBox;
        private DSCOCOATableAdapters.SegmentosTableAdapter segmentosTableAdapter;
        private System.Windows.Forms.BindingSource segmentosBindingSource;
        private DSCOCOATableAdapters.PesoBrutoVhTableAdapter pesoBrutoVhTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox idPesoBrutoVhComboBox;
        private System.Windows.Forms.ComboBox idNumeroPasajerosComboBox;
        private System.Windows.Forms.BindingSource pesoBrutoVhBindingSource;
        private DSCOCOATableAdapters.IntervaloPreciosTableAdapter intervaloPreciosTableAdapter;
        private System.Windows.Forms.ComboBox idIntervaloPrecioComboBox;
        private System.Windows.Forms.BindingSource intervaloPreciosBindingSource;
        private System.Windows.Forms.TextBox detalleProductoTextBox;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DSCOCOATableAdapters.NumeroPasajerosTableAdapter numeroPasajerosTableAdapter;
        private System.Windows.Forms.BindingSource numeroPasajerosBindingSource;
        private DSCOCOATableAdapters.CilindrajesTableAdapter cilindrajesTableAdapter;
        private System.Windows.Forms.ComboBox idCilindrajeComboBox;
        private System.Windows.Forms.BindingSource cilindrajesBindingSource;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}