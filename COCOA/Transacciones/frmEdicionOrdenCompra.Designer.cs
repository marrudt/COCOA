namespace COCOA.Transacciones
{
    partial class frmEdicionOrdenCompra
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
            System.Windows.Forms.Label idOrdenCompraLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label idProveedorLabel;
            System.Windows.Forms.Label plazoEntregaLabel;
            System.Windows.Forms.Label formaPagoLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label numeroCosteoLabel;
            System.Windows.Forms.Label contratoLabel;
            System.Windows.Forms.Label idProductoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdicionOrdenCompra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dSCOCOA = new COCOA.DSCOCOA();
            this.ordenCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenCompraTableAdapter = new COCOA.DSCOCOATableAdapters.OrdenCompraTableAdapter();
            this.tableAdapterManager = new COCOA.DSCOCOATableAdapters.TableAdapterManager();
            this.clientesTableAdapter = new COCOA.DSCOCOATableAdapters.ClientesTableAdapter();
            this.ordenCompraDetalleTableAdapter = new COCOA.DSCOCOATableAdapters.OrdenCompraDetalleTableAdapter();
            this.productosTableAdapter = new COCOA.DSCOCOATableAdapters.ProductosTableAdapter();
            this.proveedoresTableAdapter = new COCOA.DSCOCOATableAdapters.ProveedoresTableAdapter();
            this.ordenCompraBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCancel = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorExit = new System.Windows.Forms.ToolStripButton();
            this.idOrdenCompraTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plazoEntregaTextBox = new System.Windows.Forms.TextBox();
            this.formaPagoTextBox = new System.Windows.Forms.TextBox();
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroCosteoTextBox = new System.Windows.Forms.TextBox();
            this.contratoTextBox = new System.Windows.Forms.TextBox();
            this.idProductoComboBox = new System.Windows.Forms.ComboBox();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenCompraDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenCompraDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItemDetalle = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItemDetalle = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorEditDetalles = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorCancelDetalle = new System.Windows.Forms.ToolStripButton();
            this.busquedaProveedorButton = new System.Windows.Forms.Button();
            this.BusquedaClienteButton = new System.Windows.Forms.Button();
            this.BusquedaProductoButton = new System.Windows.Forms.Button();
            this.bindingNavigatorSearch = new System.Windows.Forms.ToolStripButton();
            idOrdenCompraLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            idProveedorLabel = new System.Windows.Forms.Label();
            plazoEntregaLabel = new System.Windows.Forms.Label();
            formaPagoLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            numeroCosteoLabel = new System.Windows.Forms.Label();
            contratoLabel = new System.Windows.Forms.Label();
            idProductoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenCompraBindingNavigator)).BeginInit();
            this.ordenCompraBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenCompraDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenCompraDetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idOrdenCompraLabel
            // 
            idOrdenCompraLabel.AutoSize = true;
            idOrdenCompraLabel.Location = new System.Drawing.Point(60, 47);
            idOrdenCompraLabel.Name = "idOrdenCompraLabel";
            idOrdenCompraLabel.Size = new System.Drawing.Size(47, 13);
            idOrdenCompraLabel.TabIndex = 0;
            idOrdenCompraLabel.Text = "Número:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(67, 73);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 2;
            fechaLabel.Text = "Fecha:";
            // 
            // idProveedorLabel
            // 
            idProveedorLabel.AutoSize = true;
            idProveedorLabel.Location = new System.Drawing.Point(490, 43);
            idProveedorLabel.Name = "idProveedorLabel";
            idProveedorLabel.Size = new System.Drawing.Size(59, 13);
            idProveedorLabel.TabIndex = 8;
            idProveedorLabel.Text = "Proveedor:";
            // 
            // plazoEntregaLabel
            // 
            plazoEntregaLabel.AutoSize = true;
            plazoEntregaLabel.Location = new System.Drawing.Point(31, 98);
            plazoEntregaLabel.Name = "plazoEntregaLabel";
            plazoEntregaLabel.Size = new System.Drawing.Size(76, 13);
            plazoEntregaLabel.TabIndex = 4;
            plazoEntregaLabel.Text = "Plazo Entrega:";
            // 
            // formaPagoLabel
            // 
            formaPagoLabel.AutoSize = true;
            formaPagoLabel.Location = new System.Drawing.Point(25, 125);
            formaPagoLabel.Name = "formaPagoLabel";
            formaPagoLabel.Size = new System.Drawing.Size(82, 13);
            formaPagoLabel.TabIndex = 6;
            formaPagoLabel.Text = "Forma de Pago:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(503, 71);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(46, 13);
            idClienteLabel.TabIndex = 11;
            idClienteLabel.Text = "Entidad:";
            // 
            // numeroCosteoLabel
            // 
            numeroCosteoLabel.AutoSize = true;
            numeroCosteoLabel.Location = new System.Drawing.Point(466, 98);
            numeroCosteoLabel.Name = "numeroCosteoLabel";
            numeroCosteoLabel.Size = new System.Drawing.Size(83, 13);
            numeroCosteoLabel.TabIndex = 14;
            numeroCosteoLabel.Text = "Numero Costeo:";
            // 
            // contratoLabel
            // 
            contratoLabel.AutoSize = true;
            contratoLabel.Location = new System.Drawing.Point(681, 99);
            contratoLabel.Name = "contratoLabel";
            contratoLabel.Size = new System.Drawing.Size(50, 13);
            contratoLabel.TabIndex = 16;
            contratoLabel.Text = "Contrato:";
            // 
            // idProductoLabel
            // 
            idProductoLabel.AutoSize = true;
            idProductoLabel.Location = new System.Drawing.Point(496, 124);
            idProductoLabel.Name = "idProductoLabel";
            idProductoLabel.Size = new System.Drawing.Size(53, 13);
            idProductoLabel.TabIndex = 18;
            idProductoLabel.Text = "Vehículo:";
            // 
            // dSCOCOA
            // 
            this.dSCOCOA.DataSetName = "DSCOCOA";
            this.dSCOCOA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordenCompraBindingSource
            // 
            this.ordenCompraBindingSource.DataMember = "OrdenCompra";
            this.ordenCompraBindingSource.DataSource = this.dSCOCOA;
            // 
            // ordenCompraTableAdapter
            // 
            this.ordenCompraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CilindrajesTableAdapter = null;
            this.tableAdapterManager.CiudadesTableAdapter = null;
            this.tableAdapterManager.ClaseTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.CotizacionDetalleTableAdapter = null;
            this.tableAdapterManager.CotizacionTableAdapter = null;
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.FormularioTableAdapter = null;
            this.tableAdapterManager.ImpoconsumoTableAdapter = null;
            this.tableAdapterManager.IntervaloPreciosTableAdapter = null;
            this.tableAdapterManager.IVATableAdapter = null;
            //this.tableAdapterManager.ListadoClientesTableAdapter = null;
            this.tableAdapterManager.ListadoProveedoresTableAdapter = null;
            this.tableAdapterManager.NumeroPasajerosTableAdapter = null;
            this.tableAdapterManager.OrdenCompraDetalleTableAdapter = this.ordenCompraDetalleTableAdapter;
            this.tableAdapterManager.OrdenCompraTableAdapter = this.ordenCompraTableAdapter;
            this.tableAdapterManager.PaisesTableAdapter = null;
            this.tableAdapterManager.PermisoRolTableAdapter = null;
            this.tableAdapterManager.PesoBrutoVhTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.ProveedoresTableAdapter = this.proveedoresTableAdapter;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.SegmentosTableAdapter = null;
            this.tableAdapterManager.TipoProductoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = COCOA.DSCOCOATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // ordenCompraDetalleTableAdapter
            // 
            this.ordenCompraDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // ordenCompraBindingNavigator
            // 
            this.ordenCompraBindingNavigator.AddNewItem = null;
            this.ordenCompraBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.ordenCompraBindingNavigator.BindingSource = this.ordenCompraBindingSource;
            this.ordenCompraBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordenCompraBindingNavigator.DeleteItem = null;
            this.ordenCompraBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ordenCompraBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorSaveItem,
            this.bindingNavigatorCancel,
            this.bindingNavigatorExit,
            this.bindingNavigatorSearch});
            this.ordenCompraBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ordenCompraBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordenCompraBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordenCompraBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordenCompraBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordenCompraBindingNavigator.Name = "ordenCompraBindingNavigator";
            this.ordenCompraBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordenCompraBindingNavigator.Size = new System.Drawing.Size(993, 31);
            this.ordenCompraBindingNavigator.TabIndex = 0;
            this.ordenCompraBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Enabled = false;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorSaveItem.Text = "Actualizar";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.ordenCompraBindingNavigatorSaveItem_Click);
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
            this.bindingNavigatorExit.Text = "toolStripButton2";
            this.bindingNavigatorExit.ToolTipText = "Salir";
            this.bindingNavigatorExit.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // idOrdenCompraTextBox
            // 
            this.idOrdenCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenCompraBindingSource, "IdOrdenCompra", true));
            this.idOrdenCompraTextBox.Location = new System.Drawing.Point(110, 44);
            this.idOrdenCompraTextBox.Name = "idOrdenCompraTextBox";
            this.idOrdenCompraTextBox.ReadOnly = true;
            this.idOrdenCompraTextBox.Size = new System.Drawing.Size(47, 20);
            this.idOrdenCompraTextBox.TabIndex = 1;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.CustomFormat = "dd/MMM/yyyy";
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordenCompraBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Enabled = false;
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(110, 70);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(125, 20);
            this.fechaDateTimePicker.TabIndex = 3;
            // 
            // idProveedorComboBox
            // 
            this.idProveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordenCompraBindingSource, "IdProveedor", true));
            this.idProveedorComboBox.DataSource = this.proveedoresBindingSource;
            this.idProveedorComboBox.DisplayMember = "NombreProveedor";
            this.idProveedorComboBox.Enabled = false;
            this.idProveedorComboBox.FormattingEnabled = true;
            this.idProveedorComboBox.Location = new System.Drawing.Point(552, 41);
            this.idProveedorComboBox.Name = "idProveedorComboBox";
            this.idProveedorComboBox.Size = new System.Drawing.Size(332, 21);
            this.idProveedorComboBox.TabIndex = 9;
            this.idProveedorComboBox.ValueMember = "IdProveedor";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.dSCOCOA;
            // 
            // plazoEntregaTextBox
            // 
            this.plazoEntregaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenCompraBindingSource, "PlazoEntrega", true));
            this.plazoEntregaTextBox.Location = new System.Drawing.Point(110, 96);
            this.plazoEntregaTextBox.Name = "plazoEntregaTextBox";
            this.plazoEntregaTextBox.ReadOnly = true;
            this.plazoEntregaTextBox.Size = new System.Drawing.Size(332, 20);
            this.plazoEntregaTextBox.TabIndex = 5;
            // 
            // formaPagoTextBox
            // 
            this.formaPagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenCompraBindingSource, "FormaPago", true));
            this.formaPagoTextBox.Location = new System.Drawing.Point(110, 122);
            this.formaPagoTextBox.Name = "formaPagoTextBox";
            this.formaPagoTextBox.ReadOnly = true;
            this.formaPagoTextBox.Size = new System.Drawing.Size(332, 20);
            this.formaPagoTextBox.TabIndex = 7;
            // 
            // idClienteComboBox
            // 
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordenCompraBindingSource, "IdCliente", true));
            this.idClienteComboBox.DataSource = this.clientesBindingSource;
            this.idClienteComboBox.DisplayMember = "NombreCliente";
            this.idClienteComboBox.Enabled = false;
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(552, 68);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(332, 21);
            this.idClienteComboBox.TabIndex = 12;
            this.idClienteComboBox.ValueMember = "IdCliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dSCOCOA;
            // 
            // numeroCosteoTextBox
            // 
            this.numeroCosteoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenCompraBindingSource, "NumeroCosteo", true));
            this.numeroCosteoTextBox.Location = new System.Drawing.Point(552, 95);
            this.numeroCosteoTextBox.Name = "numeroCosteoTextBox";
            this.numeroCosteoTextBox.ReadOnly = true;
            this.numeroCosteoTextBox.Size = new System.Drawing.Size(123, 20);
            this.numeroCosteoTextBox.TabIndex = 15;
            this.numeroCosteoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroCosteoTextBox_KeyPress);
            // 
            // contratoTextBox
            // 
            this.contratoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenCompraBindingSource, "Contrato", true));
            this.contratoTextBox.Location = new System.Drawing.Point(737, 95);
            this.contratoTextBox.Name = "contratoTextBox";
            this.contratoTextBox.ReadOnly = true;
            this.contratoTextBox.Size = new System.Drawing.Size(147, 20);
            this.contratoTextBox.TabIndex = 17;
            // 
            // idProductoComboBox
            // 
            this.idProductoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordenCompraBindingSource, "IdProducto", true));
            this.idProductoComboBox.DataSource = this.productosBindingSource;
            this.idProductoComboBox.DisplayMember = "DescripcionProducto";
            this.idProductoComboBox.Enabled = false;
            this.idProductoComboBox.FormattingEnabled = true;
            this.idProductoComboBox.Location = new System.Drawing.Point(552, 121);
            this.idProductoComboBox.Name = "idProductoComboBox";
            this.idProductoComboBox.Size = new System.Drawing.Size(332, 21);
            this.idProductoComboBox.TabIndex = 19;
            this.idProductoComboBox.ValueMember = "IdProducto";
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.dSCOCOA;
            // 
            // ordenCompraDetalleBindingSource
            // 
            this.ordenCompraDetalleBindingSource.DataMember = "FK_OrdenCompraDetalle_OrdenCompra";
            this.ordenCompraDetalleBindingSource.DataSource = this.ordenCompraBindingSource;
            // 
            // ordenCompraDetalleDataGridView
            // 
            this.ordenCompraDetalleDataGridView.AllowUserToOrderColumns = true;
            this.ordenCompraDetalleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordenCompraDetalleDataGridView.AutoGenerateColumns = false;
            this.ordenCompraDetalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordenCompraDetalleDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ordenCompraDetalleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ordenCompraDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordenCompraDetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.ordenCompraDetalleDataGridView.DataSource = this.ordenCompraDetalleBindingSource;
            this.ordenCompraDetalleDataGridView.Enabled = false;
            this.ordenCompraDetalleDataGridView.Location = new System.Drawing.Point(0, 191);
            this.ordenCompraDetalleDataGridView.Name = "ordenCompraDetalleDataGridView";
            this.ordenCompraDetalleDataGridView.Size = new System.Drawing.Size(992, 293);
            this.ordenCompraDetalleDataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdOrdenCompraDetalle";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdOrdenCompraDetalle";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdOrdenCompra";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdOrdenCompra";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdProducto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DescripcionProducto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripción Producto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 123;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 62;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cantidad";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn6.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 74;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IVA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn7.HeaderText = "IVA";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 49;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Impoconsumo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn8.HeaderText = "Impoc.";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 64;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItemDetalle;
            this.bindingNavigator1.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigator1.BindingSource = this.ordenCompraDetalleBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItemDetalle;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorEditDetalles,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorAddNewItemDetalle,
            this.bindingNavigatorDeleteItemDetalle,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorCancelDetalle});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 157);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(142, 31);
            this.bindingNavigator1.TabIndex = 21;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItemDetalle
            // 
            this.bindingNavigatorAddNewItemDetalle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItemDetalle.Enabled = false;
            this.bindingNavigatorAddNewItemDetalle.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItemDetalle.Image")));
            this.bindingNavigatorAddNewItemDetalle.Name = "bindingNavigatorAddNewItemDetalle";
            this.bindingNavigatorAddNewItemDetalle.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItemDetalle.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItemDetalle.Text = "Agregar Línea";
            // 
            // bindingNavigatorDeleteItemDetalle
            // 
            this.bindingNavigatorDeleteItemDetalle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItemDetalle.Enabled = false;
            this.bindingNavigatorDeleteItemDetalle.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItemDetalle.Image")));
            this.bindingNavigatorDeleteItemDetalle.Name = "bindingNavigatorDeleteItemDetalle";
            this.bindingNavigatorDeleteItemDetalle.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItemDetalle.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItemDetalle.Text = "Eliminar Línea";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorEditDetalles
            // 
            this.bindingNavigatorEditDetalles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorEditDetalles.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorEditDetalles.Image")));
            this.bindingNavigatorEditDetalles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEditDetalles.Name = "bindingNavigatorEditDetalles";
            this.bindingNavigatorEditDetalles.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorEditDetalles.Text = "toolStripButton1";
            this.bindingNavigatorEditDetalles.ToolTipText = "Editar";
            this.bindingNavigatorEditDetalles.Click += new System.EventHandler(this.bindingNavigatorEditDetalles_Click);
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorCancelDetalle
            // 
            this.bindingNavigatorCancelDetalle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorCancelDetalle.Enabled = false;
            this.bindingNavigatorCancelDetalle.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorCancelDetalle.Image")));
            this.bindingNavigatorCancelDetalle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCancelDetalle.Name = "bindingNavigatorCancelDetalle";
            this.bindingNavigatorCancelDetalle.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorCancelDetalle.Text = "Cancelar";
            this.bindingNavigatorCancelDetalle.Click += new System.EventHandler(this.bindingNavigatorCancelDetalle_Click);
            // 
            // busquedaProveedorButton
            // 
            this.busquedaProveedorButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.busquedaProveedorButton.Enabled = false;
            this.busquedaProveedorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaProveedorButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.busquedaProveedorButton.Location = new System.Drawing.Point(890, 39);
            this.busquedaProveedorButton.Name = "busquedaProveedorButton";
            this.busquedaProveedorButton.Size = new System.Drawing.Size(63, 23);
            this.busquedaProveedorButton.TabIndex = 10;
            this.busquedaProveedorButton.Text = "Buscar";
            this.busquedaProveedorButton.UseVisualStyleBackColor = false;
            this.busquedaProveedorButton.Click += new System.EventHandler(this.busquedaProveedorButton_Click);
            // 
            // BusquedaClienteButton
            // 
            this.BusquedaClienteButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BusquedaClienteButton.Enabled = false;
            this.BusquedaClienteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusquedaClienteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BusquedaClienteButton.Location = new System.Drawing.Point(890, 68);
            this.BusquedaClienteButton.Name = "BusquedaClienteButton";
            this.BusquedaClienteButton.Size = new System.Drawing.Size(63, 23);
            this.BusquedaClienteButton.TabIndex = 13;
            this.BusquedaClienteButton.Text = "Buscar";
            this.BusquedaClienteButton.UseVisualStyleBackColor = false;
            this.BusquedaClienteButton.Click += new System.EventHandler(this.BusquedaClienteButton_Click);
            // 
            // BusquedaProductoButton
            // 
            this.BusquedaProductoButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BusquedaProductoButton.Enabled = false;
            this.BusquedaProductoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusquedaProductoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BusquedaProductoButton.Location = new System.Drawing.Point(890, 120);
            this.BusquedaProductoButton.Name = "BusquedaProductoButton";
            this.BusquedaProductoButton.Size = new System.Drawing.Size(63, 23);
            this.BusquedaProductoButton.TabIndex = 20;
            this.BusquedaProductoButton.Text = "Buscar";
            this.BusquedaProductoButton.UseVisualStyleBackColor = false;
            this.BusquedaProductoButton.Click += new System.EventHandler(this.BusquedaProductoButton_Click);
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
            // frmEdicionOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(993, 484);
            this.ControlBox = false;
            this.Controls.Add(this.BusquedaProductoButton);
            this.Controls.Add(this.BusquedaClienteButton);
            this.Controls.Add(this.busquedaProveedorButton);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.ordenCompraDetalleDataGridView);
            this.Controls.Add(idOrdenCompraLabel);
            this.Controls.Add(this.idOrdenCompraTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(idProveedorLabel);
            this.Controls.Add(this.idProveedorComboBox);
            this.Controls.Add(plazoEntregaLabel);
            this.Controls.Add(this.plazoEntregaTextBox);
            this.Controls.Add(formaPagoLabel);
            this.Controls.Add(this.formaPagoTextBox);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteComboBox);
            this.Controls.Add(numeroCosteoLabel);
            this.Controls.Add(this.numeroCosteoTextBox);
            this.Controls.Add(contratoLabel);
            this.Controls.Add(this.contratoTextBox);
            this.Controls.Add(idProductoLabel);
            this.Controls.Add(this.idProductoComboBox);
            this.Controls.Add(this.ordenCompraBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEdicionOrdenCompra";
            this.Text = "Edición Ordenes de Compra";
            this.Load += new System.EventHandler(this.frmEdicionOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenCompraBindingNavigator)).EndInit();
            this.ordenCompraBindingNavigator.ResumeLayout(false);
            this.ordenCompraBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenCompraDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenCompraDetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSCOCOA dSCOCOA;
        private System.Windows.Forms.BindingSource ordenCompraBindingSource;
        private DSCOCOATableAdapters.OrdenCompraTableAdapter ordenCompraTableAdapter;
        private DSCOCOATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ordenCompraBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idOrdenCompraTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.ComboBox idProveedorComboBox;
        private System.Windows.Forms.TextBox plazoEntregaTextBox;
        private System.Windows.Forms.TextBox formaPagoTextBox;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.TextBox numeroCosteoTextBox;
        private System.Windows.Forms.TextBox contratoTextBox;
        private System.Windows.Forms.ComboBox idProductoComboBox;
        private DSCOCOATableAdapters.OrdenCompraDetalleTableAdapter ordenCompraDetalleTableAdapter;
        private System.Windows.Forms.BindingSource ordenCompraDetalleBindingSource;
        private System.Windows.Forms.DataGridView ordenCompraDetalleDataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItemDetalle;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItemDetalle;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private DSCOCOATableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private DSCOCOATableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DSCOCOATableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEdit;
        private System.Windows.Forms.ToolStripButton bindingNavigatorExit;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancel;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancelDetalle;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditDetalles;
        private System.Windows.Forms.Button busquedaProveedorButton;
        private System.Windows.Forms.Button BusquedaClienteButton;
        private System.Windows.Forms.Button BusquedaProductoButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSearch;
    }
}