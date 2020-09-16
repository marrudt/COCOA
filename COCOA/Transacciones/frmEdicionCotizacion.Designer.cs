namespace COCOA.Transacciones
{
    partial class frmEdicionCotizacion
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
            System.Windows.Forms.Label idCotizacionLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label contactoLabel;
            System.Windows.Forms.Label formaPagoLabel;
            System.Windows.Forms.Label plazoEntregaLabel;
            System.Windows.Forms.Label sitioEntregaLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label remplazaCotizacionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdicionCotizacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dSCOCOA = new COCOA.DSCOCOA();
            this.cotizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cotizacionTableAdapter = new COCOA.DSCOCOATableAdapters.CotizacionTableAdapter();
            this.tableAdapterManager = new COCOA.DSCOCOATableAdapters.TableAdapterManager();
            this.cotizacionDetalleTableAdapter = new COCOA.DSCOCOATableAdapters.CotizacionDetalleTableAdapter();
            this.cotizacionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bindingNavigatorSearch = new System.Windows.Forms.ToolStripButton();
            this.idCotizacionTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.formaPagoTextBox = new System.Windows.Forms.TextBox();
            this.plazoEntregaTextBox = new System.Windows.Forms.TextBox();
            this.sitioEntregaTextBox = new System.Windows.Forms.TextBox();
            this.cotizacionDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cotizacionDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItemDetalle = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItemDetalle = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorEditDetalles = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorCancelDetalle = new System.Windows.Forms.ToolStripButton();
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busquedaClienteButton = new System.Windows.Forms.Button();
            this.clientesTableAdapter = new COCOA.DSCOCOATableAdapters.ClientesTableAdapter();
            this.remplazaCotizacionTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.PorcentajeEstampillas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idCotizacionLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            contactoLabel = new System.Windows.Forms.Label();
            formaPagoLabel = new System.Windows.Forms.Label();
            plazoEntregaLabel = new System.Windows.Forms.Label();
            sitioEntregaLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            remplazaCotizacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionBindingNavigator)).BeginInit();
            this.cotizacionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionDetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idCotizacionLabel
            // 
            idCotizacionLabel.AutoSize = true;
            idCotizacionLabel.Location = new System.Drawing.Point(74, 51);
            idCotizacionLabel.Name = "idCotizacionLabel";
            idCotizacionLabel.Size = new System.Drawing.Size(47, 13);
            idCotizacionLabel.TabIndex = 0;
            idCotizacionLabel.Text = "Número:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(81, 78);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 2;
            fechaLabel.Text = "Fecha:";
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.Location = new System.Drawing.Point(520, 129);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(53, 13);
            contactoLabel.TabIndex = 13;
            contactoLabel.Text = "Contacto:";
            // 
            // formaPagoLabel
            // 
            formaPagoLabel.AutoSize = true;
            formaPagoLabel.Location = new System.Drawing.Point(39, 103);
            formaPagoLabel.Name = "formaPagoLabel";
            formaPagoLabel.Size = new System.Drawing.Size(82, 13);
            formaPagoLabel.TabIndex = 4;
            formaPagoLabel.Text = "Forma de Pago:";
            // 
            // plazoEntregaLabel
            // 
            plazoEntregaLabel.AutoSize = true;
            plazoEntregaLabel.Location = new System.Drawing.Point(45, 129);
            plazoEntregaLabel.Name = "plazoEntregaLabel";
            plazoEntregaLabel.Size = new System.Drawing.Size(76, 13);
            plazoEntregaLabel.TabIndex = 6;
            plazoEntregaLabel.Text = "Plazo Entrega:";
            // 
            // sitioEntregaLabel
            // 
            sitioEntregaLabel.AutoSize = true;
            sitioEntregaLabel.Location = new System.Drawing.Point(488, 77);
            sitioEntregaLabel.Name = "sitioEntregaLabel";
            sitioEntregaLabel.Size = new System.Drawing.Size(85, 13);
            sitioEntregaLabel.TabIndex = 8;
            sitioEntregaLabel.Text = "Sitio de Entrega:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(531, 103);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(42, 13);
            idClienteLabel.TabIndex = 10;
            idClienteLabel.Text = "Cliente:";
            // 
            // remplazaCotizacionLabel
            // 
            remplazaCotizacionLabel.AutoSize = true;
            remplazaCotizacionLabel.Location = new System.Drawing.Point(303, 78);
            remplazaCotizacionLabel.Name = "remplazaCotizacionLabel";
            remplazaCotizacionLabel.Size = new System.Drawing.Size(109, 13);
            remplazaCotizacionLabel.TabIndex = 18;
            remplazaCotizacionLabel.Text = "Remplaza Cotización:";
            // 
            // dSCOCOA
            // 
            this.dSCOCOA.DataSetName = "DSCOCOA";
            this.dSCOCOA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cotizacionBindingSource
            // 
            this.cotizacionBindingSource.DataMember = "Cotizacion";
            this.cotizacionBindingSource.DataSource = this.dSCOCOA;
            // 
            // cotizacionTableAdapter
            // 
            this.cotizacionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CilindrajesTableAdapter = null;
            this.tableAdapterManager.CiudadesTableAdapter = null;
            this.tableAdapterManager.ClaseTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ContactosClienteTableAdapter = null;
            this.tableAdapterManager.CotizacionDetalleTableAdapter = this.cotizacionDetalleTableAdapter;
            this.tableAdapterManager.CotizacionTableAdapter = this.cotizacionTableAdapter;
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.FormularioTableAdapter = null;
            this.tableAdapterManager.ImpoconsumoTableAdapter = null;
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
            // cotizacionDetalleTableAdapter
            // 
            this.cotizacionDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // cotizacionBindingNavigator
            // 
            this.cotizacionBindingNavigator.AddNewItem = null;
            this.cotizacionBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.cotizacionBindingNavigator.BindingSource = this.cotizacionBindingSource;
            this.cotizacionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cotizacionBindingNavigator.DeleteItem = null;
            this.cotizacionBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cotizacionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cotizacionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cotizacionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cotizacionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cotizacionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cotizacionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cotizacionBindingNavigator.Name = "cotizacionBindingNavigator";
            this.cotizacionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cotizacionBindingNavigator.Size = new System.Drawing.Size(1225, 31);
            this.cotizacionBindingNavigator.TabIndex = 0;
            this.cotizacionBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
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
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
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
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
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
            this.bindingNavigatorExit.Click += new System.EventHandler(this.bindingNavigatorExit_Click);
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
            // idCotizacionTextBox
            // 
            this.idCotizacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cotizacionBindingSource, "IdCotizacion", true));
            this.idCotizacionTextBox.Location = new System.Drawing.Point(124, 48);
            this.idCotizacionTextBox.Name = "idCotizacionTextBox";
            this.idCotizacionTextBox.ReadOnly = true;
            this.idCotizacionTextBox.Size = new System.Drawing.Size(50, 20);
            this.idCotizacionTextBox.TabIndex = 1;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.CustomFormat = "dd/MMM/yyyy";
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cotizacionBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Enabled = false;
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(124, 74);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(125, 20);
            this.fechaDateTimePicker.TabIndex = 3;
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cotizacionBindingSource, "Contacto", true));
            this.contactoTextBox.Location = new System.Drawing.Point(575, 127);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.ReadOnly = true;
            this.contactoTextBox.Size = new System.Drawing.Size(332, 20);
            this.contactoTextBox.TabIndex = 14;
            // 
            // formaPagoTextBox
            // 
            this.formaPagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cotizacionBindingSource, "FormaPago", true));
            this.formaPagoTextBox.Location = new System.Drawing.Point(124, 100);
            this.formaPagoTextBox.Name = "formaPagoTextBox";
            this.formaPagoTextBox.ReadOnly = true;
            this.formaPagoTextBox.Size = new System.Drawing.Size(332, 20);
            this.formaPagoTextBox.TabIndex = 5;
            // 
            // plazoEntregaTextBox
            // 
            this.plazoEntregaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cotizacionBindingSource, "PlazoEntrega", true));
            this.plazoEntregaTextBox.Location = new System.Drawing.Point(124, 126);
            this.plazoEntregaTextBox.Name = "plazoEntregaTextBox";
            this.plazoEntregaTextBox.ReadOnly = true;
            this.plazoEntregaTextBox.Size = new System.Drawing.Size(332, 20);
            this.plazoEntregaTextBox.TabIndex = 7;
            // 
            // sitioEntregaTextBox
            // 
            this.sitioEntregaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cotizacionBindingSource, "SitioEntrega", true));
            this.sitioEntregaTextBox.Location = new System.Drawing.Point(575, 74);
            this.sitioEntregaTextBox.Name = "sitioEntregaTextBox";
            this.sitioEntregaTextBox.ReadOnly = true;
            this.sitioEntregaTextBox.Size = new System.Drawing.Size(332, 20);
            this.sitioEntregaTextBox.TabIndex = 9;
            // 
            // cotizacionDetalleBindingSource
            // 
            this.cotizacionDetalleBindingSource.DataMember = "FK_CotizacionDetalle_IdCotizacion";
            this.cotizacionDetalleBindingSource.DataSource = this.cotizacionBindingSource;
            // 
            // cotizacionDetalleDataGridView
            // 
            this.cotizacionDetalleDataGridView.AllowUserToOrderColumns = true;
            this.cotizacionDetalleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cotizacionDetalleDataGridView.AutoGenerateColumns = false;
            this.cotizacionDetalleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cotizacionDetalleDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cotizacionDetalleDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cotizacionDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cotizacionDetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.PorcentajeEstampillas,
            this.dataGridViewTextBoxColumn11,
            this.Descuento});
            this.cotizacionDetalleDataGridView.DataSource = this.cotizacionDetalleBindingSource;
            this.cotizacionDetalleDataGridView.Enabled = false;
            this.cotizacionDetalleDataGridView.Location = new System.Drawing.Point(0, 193);
            this.cotizacionDetalleDataGridView.Name = "cotizacionDetalleDataGridView";
            this.cotizacionDetalleDataGridView.Size = new System.Drawing.Size(1225, 428);
            this.cotizacionDetalleDataGridView.TabIndex = 16;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItemDetalle;
            this.bindingNavigator1.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigator1.BindingSource = this.cotizacionDetalleBindingSource;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 159);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(142, 31);
            this.bindingNavigator1.TabIndex = 15;
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
            // idClienteComboBox
            // 
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cotizacionBindingSource, "IdCliente", true));
            this.idClienteComboBox.DataSource = this.clientesBindingSource;
            this.idClienteComboBox.DisplayMember = "NombreCliente";
            this.idClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idClienteComboBox.Enabled = false;
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(575, 100);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(332, 21);
            this.idClienteComboBox.TabIndex = 11;
            this.idClienteComboBox.ValueMember = "IdCliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dSCOCOA;
            // 
            // busquedaClienteButton
            // 
            this.busquedaClienteButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.busquedaClienteButton.Enabled = false;
            this.busquedaClienteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaClienteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.busquedaClienteButton.Location = new System.Drawing.Point(913, 98);
            this.busquedaClienteButton.Name = "busquedaClienteButton";
            this.busquedaClienteButton.Size = new System.Drawing.Size(63, 23);
            this.busquedaClienteButton.TabIndex = 12;
            this.busquedaClienteButton.Text = "Buscar";
            this.busquedaClienteButton.UseVisualStyleBackColor = false;
            this.busquedaClienteButton.Click += new System.EventHandler(this.busquedaClienteButton_Click);
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // remplazaCotizacionTextBox
            // 
            this.remplazaCotizacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cotizacionBindingSource, "RemplazaCotizacion", true));
            this.remplazaCotizacionTextBox.Enabled = false;
            this.remplazaCotizacionTextBox.Location = new System.Drawing.Point(415, 75);
            this.remplazaCotizacionTextBox.Name = "remplazaCotizacionTextBox";
            this.remplazaCotizacionTextBox.Size = new System.Drawing.Size(41, 20);
            this.remplazaCotizacionTextBox.TabIndex = 19;
            this.remplazaCotizacionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.remplazaCotizacionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.remplazaCotizacionTextBox_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCotizacionDetalle";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdCotizacionDetalle";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 123;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdCotizacion";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdCotizacion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NumeroItem";
            this.dataGridViewTextBoxColumn3.HeaderText = "Número Ítem";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 92;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DetalleNumeroItem";
            this.dataGridViewTextBoxColumn4.HeaderText = "Detalle Número Ítem";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 99;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdProducto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DescripcionProducto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descripción Producto";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 2147483647;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 123;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn7.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 62;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cantidad";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn8.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 74;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PorcentajeIVA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn9.HeaderText = "IVA";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 49;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PorcentajeImpoconsumo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn10.HeaderText = "Impoc.";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 64;
            // 
            // PorcentajeEstampillas
            // 
            this.PorcentajeEstampillas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PorcentajeEstampillas.DataPropertyName = "PorcentajeEstampillas";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N1";
            dataGridViewCellStyle5.NullValue = null;
            this.PorcentajeEstampillas.DefaultCellStyle = dataGridViewCellStyle5;
            this.PorcentajeEstampillas.HeaderText = "% Estampi";
            this.PorcentajeEstampillas.Name = "PorcentajeEstampillas";
            this.PorcentajeEstampillas.Width = 74;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Estampillas";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N1";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn11.HeaderText = "Vr. Estampillas";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 92;
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Descuento";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.Descuento.DefaultCellStyle = dataGridViewCellStyle7;
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.Width = 84;
            // 
            // frmEdicionCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1225, 621);
            this.ControlBox = false;
            this.Controls.Add(remplazaCotizacionLabel);
            this.Controls.Add(this.remplazaCotizacionTextBox);
            this.Controls.Add(this.busquedaClienteButton);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteComboBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.cotizacionDetalleDataGridView);
            this.Controls.Add(idCotizacionLabel);
            this.Controls.Add(this.idCotizacionTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(contactoLabel);
            this.Controls.Add(this.contactoTextBox);
            this.Controls.Add(formaPagoLabel);
            this.Controls.Add(this.formaPagoTextBox);
            this.Controls.Add(plazoEntregaLabel);
            this.Controls.Add(this.plazoEntregaTextBox);
            this.Controls.Add(sitioEntregaLabel);
            this.Controls.Add(this.sitioEntregaTextBox);
            this.Controls.Add(this.cotizacionBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEdicionCotizacion";
            this.Text = "Edición  Cotizaciones";
            this.Load += new System.EventHandler(this.frmEdicionCotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionBindingNavigator)).EndInit();
            this.cotizacionBindingNavigator.ResumeLayout(false);
            this.cotizacionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionDetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSCOCOA dSCOCOA;
        private System.Windows.Forms.BindingSource cotizacionBindingSource;
        private DSCOCOATableAdapters.CotizacionTableAdapter cotizacionTableAdapter;
        private DSCOCOATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cotizacionBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox idCotizacionTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.TextBox formaPagoTextBox;
        private System.Windows.Forms.TextBox plazoEntregaTextBox;
        private System.Windows.Forms.TextBox sitioEntregaTextBox;
        private DSCOCOATableAdapters.CotizacionDetalleTableAdapter cotizacionDetalleTableAdapter;
        private System.Windows.Forms.BindingSource cotizacionDetalleBindingSource;
        private System.Windows.Forms.DataGridView cotizacionDetalleDataGridView;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEdit;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancel;
        private System.Windows.Forms.ToolStripButton bindingNavigatorExit;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEditDetalles;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItemDetalle;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItemDetalle;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancelDetalle;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.Button busquedaClienteButton;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DSCOCOATableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSearch;
        private System.Windows.Forms.TextBox remplazaCotizacionTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeEstampillas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
    }
}