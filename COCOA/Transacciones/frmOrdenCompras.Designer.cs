﻿namespace COCOA.Transacciones
{
    partial class frmOrdenCompras
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
            System.Windows.Forms.Label formaPagoLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label numeroCosteoLabel;
            System.Windows.Forms.Label contratoLabel;
            System.Windows.Forms.Label idProductoLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenCompras));
            this.label2 = new System.Windows.Forms.Label();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.proveedorComboBox = new System.Windows.Forms.ComboBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCOCOA = new COCOA.DSCOCOA();
            this.label4 = new System.Windows.Forms.Label();
            this.plazoEntregaTextBox = new System.Windows.Forms.TextBox();
            this.proveedoresTableAdapter = new COCOA.DSCOCOATableAdapters.ProveedoresTableAdapter();
            this.busquedaProveedorButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buscarProductoButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new COCOA.DSCOCOATableAdapters.ProductosTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.agregarButton = new System.Windows.Forms.Button();
            this.detalleOrdenCompraDataGridView = new System.Windows.Forms.DataGridView();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.productoTextBox = new System.Windows.Forms.TextBox();
            this.productoLabel = new System.Windows.Forms.Label();
            this.ordenCompraDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenCompraDetalleTableAdapter = new COCOA.DSCOCOATableAdapters.OrdenCompraDetalleTableAdapter();
            this.tableAdapterManager = new COCOA.DSCOCOATableAdapters.TableAdapterManager();
            this.label8 = new System.Windows.Forms.Label();
            this.totalSubtotalTextBox = new System.Windows.Forms.TextBox();
            this.totalIVATextBox = new System.Windows.Forms.TextBox();
            this.totalImpoconsumoTextBox = new System.Windows.Forms.TextBox();
            this.totalNetoTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.guardarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.borrarTodoButton = new System.Windows.Forms.Button();
            this.borrarLineaButton = new System.Windows.Forms.Button();
            this.salirButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.terminosGarantiaTextBox = new System.Windows.Forms.TextBox();
            this.ordenCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BusquedaProductoButton = new System.Windows.Forms.Button();
            this.vehiculoComboBox = new System.Windows.Forms.ComboBox();
            this.contratoTextBox = new System.Windows.Forms.TextBox();
            this.numeroCosteoTextBox = new System.Windows.Forms.TextBox();
            this.BusquedaClienteButton = new System.Windows.Forms.Button();
            this.entidadComboBox = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formaPagoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productoButton = new System.Windows.Forms.Button();
            this.editarDescuentoButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.descuentoTextBox = new System.Windows.Forms.TextBox();
            this.ordenCompraTableAdapter = new COCOA.DSCOCOATableAdapters.OrdenCompraTableAdapter();
            this.clientesTableAdapter = new COCOA.DSCOCOATableAdapters.ClientesTableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            this.totalDescuentoTextBox = new System.Windows.Forms.TextBox();
            this.editarPrecioButton = new System.Windows.Forms.Button();
            formaPagoLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            numeroCosteoLabel = new System.Windows.Forms.Label();
            contratoLabel = new System.Windows.Forms.Label();
            idProductoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleOrdenCompraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenCompraDetalleBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordenCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // formaPagoLabel
            // 
            formaPagoLabel.AutoSize = true;
            formaPagoLabel.Location = new System.Drawing.Point(21, 81);
            formaPagoLabel.Name = "formaPagoLabel";
            formaPagoLabel.Size = new System.Drawing.Size(82, 13);
            formaPagoLabel.TabIndex = 4;
            formaPagoLabel.Text = "Forma de Pago:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(57, 133);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(46, 13);
            idClienteLabel.TabIndex = 8;
            idClienteLabel.Text = "Entidad:";
            // 
            // numeroCosteoLabel
            // 
            numeroCosteoLabel.AutoSize = true;
            numeroCosteoLabel.Location = new System.Drawing.Point(20, 160);
            numeroCosteoLabel.Name = "numeroCosteoLabel";
            numeroCosteoLabel.Size = new System.Drawing.Size(83, 13);
            numeroCosteoLabel.TabIndex = 11;
            numeroCosteoLabel.Text = "Número Costeo:";
            // 
            // contratoLabel
            // 
            contratoLabel.AutoSize = true;
            contratoLabel.Location = new System.Drawing.Point(246, 160);
            contratoLabel.Name = "contratoLabel";
            contratoLabel.Size = new System.Drawing.Size(50, 13);
            contratoLabel.TabIndex = 13;
            contratoLabel.Text = "Contrato:";
            // 
            // idProductoLabel
            // 
            idProductoLabel.AutoSize = true;
            idProductoLabel.Location = new System.Drawing.Point(50, 186);
            idProductoLabel.Name = "idProductoLabel";
            idProductoLabel.Size = new System.Drawing.Size(53, 13);
            idProductoLabel.TabIndex = 15;
            idProductoLabel.Text = "Vehículo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 107);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 13);
            label1.TabIndex = 6;
            label1.Text = "Términos Garantía:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.CustomFormat = "dd/MMM/yyyy";
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(105, 27);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(125, 20);
            this.fechaDateTimePicker.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Proveedor:";
            // 
            // proveedorComboBox
            // 
            this.proveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.proveedoresBindingSource, "IdProveedor", true));
            this.proveedorComboBox.DataSource = this.proveedoresBindingSource;
            this.proveedorComboBox.DisplayMember = "NombreProveedor";
            this.proveedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proveedorComboBox.FormattingEnabled = true;
            this.proveedorComboBox.Location = new System.Drawing.Point(103, 23);
            this.proveedorComboBox.Name = "proveedorComboBox";
            this.proveedorComboBox.Size = new System.Drawing.Size(410, 21);
            this.proveedorComboBox.TabIndex = 1;
            this.proveedorComboBox.ValueMember = "IdProveedor";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Plazo Entrega:";
            // 
            // plazoEntregaTextBox
            // 
            this.plazoEntregaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.plazoEntregaTextBox.Location = new System.Drawing.Point(105, 52);
            this.plazoEntregaTextBox.Name = "plazoEntregaTextBox";
            this.plazoEntregaTextBox.Size = new System.Drawing.Size(408, 20);
            this.plazoEntregaTextBox.TabIndex = 3;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // busquedaProveedorButton
            // 
            this.busquedaProveedorButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.busquedaProveedorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaProveedorButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.busquedaProveedorButton.Location = new System.Drawing.Point(537, 21);
            this.busquedaProveedorButton.Name = "busquedaProveedorButton";
            this.busquedaProveedorButton.Size = new System.Drawing.Size(76, 23);
            this.busquedaProveedorButton.TabIndex = 2;
            this.busquedaProveedorButton.Text = "Buscar";
            this.busquedaProveedorButton.UseVisualStyleBackColor = false;
            this.busquedaProveedorButton.Click += new System.EventHandler(this.busquedaProveedorButton_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Producto:";
            // 
            // buscarProductoButton
            // 
            this.buscarProductoButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buscarProductoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarProductoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buscarProductoButton.Location = new System.Drawing.Point(537, 48);
            this.buscarProductoButton.Name = "buscarProductoButton";
            this.buscarProductoButton.Size = new System.Drawing.Size(76, 23);
            this.buscarProductoButton.TabIndex = 6;
            this.buscarProductoButton.Text = "Buscar";
            this.buscarProductoButton.UseVisualStyleBackColor = false;
            this.buscarProductoButton.Click += new System.EventHandler(this.buscarProductoButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cantidad:";
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(103, 76);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(119, 20);
            this.cantidadTextBox.TabIndex = 8;
            this.cantidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadTextBox_KeyPress);
            // 
            // agregarButton
            // 
            this.agregarButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.agregarButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.agregarButton.FlatAppearance.BorderSize = 2;
            this.agregarButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.agregarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.agregarButton.Image = ((System.Drawing.Image)(resources.GetObject("agregarButton.Image")));
            this.agregarButton.Location = new System.Drawing.Point(637, 313);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(94, 74);
            this.agregarButton.TabIndex = 0;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.agregarButton.UseVisualStyleBackColor = false;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click_1);
            // 
            // detalleOrdenCompraDataGridView
            // 
            this.detalleOrdenCompraDataGridView.AllowUserToAddRows = false;
            this.detalleOrdenCompraDataGridView.AllowUserToDeleteRows = false;
            this.detalleOrdenCompraDataGridView.AllowUserToOrderColumns = true;
            this.detalleOrdenCompraDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detalleOrdenCompraDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.detalleOrdenCompraDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.detalleOrdenCompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleOrdenCompraDataGridView.Location = new System.Drawing.Point(0, 393);
            this.detalleOrdenCompraDataGridView.Name = "detalleOrdenCompraDataGridView";
            this.detalleOrdenCompraDataGridView.Size = new System.Drawing.Size(1174, 283);
            this.detalleOrdenCompraDataGridView.TabIndex = 16;
            // 
            // precioTextBox
            // 
            this.precioTextBox.Enabled = false;
            this.precioTextBox.Location = new System.Drawing.Point(328, 78);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(185, 20);
            this.precioTextBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Precio Unitario:";
            // 
            // productoTextBox
            // 
            this.productoTextBox.Enabled = false;
            this.productoTextBox.Location = new System.Drawing.Point(103, 50);
            this.productoTextBox.Name = "productoTextBox";
            this.productoTextBox.ReadOnly = true;
            this.productoTextBox.Size = new System.Drawing.Size(39, 20);
            this.productoTextBox.TabIndex = 4;
            this.productoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productoTextBox_KeyPress);
            this.productoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.productoTextBox_Validating);
            // 
            // productoLabel
            // 
            this.productoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoLabel.ForeColor = System.Drawing.Color.Maroon;
            this.productoLabel.Location = new System.Drawing.Point(166, 53);
            this.productoLabel.Name = "productoLabel";
            this.productoLabel.Size = new System.Drawing.Size(347, 17);
            this.productoLabel.TabIndex = 5;
            this.productoLabel.Text = "Detalle Producto";
            // 
            // ordenCompraDetalleBindingSource
            // 
            this.ordenCompraDetalleBindingSource.DataMember = "OrdenCompraDetalle";
            this.ordenCompraDetalleBindingSource.DataSource = this.dSCOCOA;
            // 
            // ordenCompraDetalleTableAdapter
            // 
            this.ordenCompraDetalleTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.OrdenCompraDetalleTableAdapter = this.ordenCompraDetalleTableAdapter;
            this.tableAdapterManager.OrdenCompraTableAdapter = null;
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
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(978, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Subtotal";
            // 
            // totalSubtotalTextBox
            // 
            this.totalSubtotalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalSubtotalTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.totalSubtotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSubtotalTextBox.Location = new System.Drawing.Point(1037, 256);
            this.totalSubtotalTextBox.Name = "totalSubtotalTextBox";
            this.totalSubtotalTextBox.ReadOnly = true;
            this.totalSubtotalTextBox.Size = new System.Drawing.Size(125, 21);
            this.totalSubtotalTextBox.TabIndex = 7;
            this.totalSubtotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalIVATextBox
            // 
            this.totalIVATextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalIVATextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.totalIVATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalIVATextBox.Location = new System.Drawing.Point(1037, 283);
            this.totalIVATextBox.Name = "totalIVATextBox";
            this.totalIVATextBox.ReadOnly = true;
            this.totalIVATextBox.Size = new System.Drawing.Size(125, 21);
            this.totalIVATextBox.TabIndex = 9;
            this.totalIVATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalImpoconsumoTextBox
            // 
            this.totalImpoconsumoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalImpoconsumoTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.totalImpoconsumoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalImpoconsumoTextBox.Location = new System.Drawing.Point(1037, 310);
            this.totalImpoconsumoTextBox.Name = "totalImpoconsumoTextBox";
            this.totalImpoconsumoTextBox.ReadOnly = true;
            this.totalImpoconsumoTextBox.Size = new System.Drawing.Size(125, 21);
            this.totalImpoconsumoTextBox.TabIndex = 11;
            this.totalImpoconsumoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalNetoTextBox
            // 
            this.totalNetoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalNetoTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.totalNetoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNetoTextBox.Location = new System.Drawing.Point(1037, 364);
            this.totalNetoTextBox.Name = "totalNetoTextBox";
            this.totalNetoTextBox.ReadOnly = true;
            this.totalNetoTextBox.Size = new System.Drawing.Size(125, 21);
            this.totalNetoTextBox.TabIndex = 15;
            this.totalNetoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1006, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "IVA";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(944, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Impoconsumo";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(996, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "Total";
            // 
            // guardarButton
            // 
            this.guardarButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guardarButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.guardarButton.FlatAppearance.BorderSize = 2;
            this.guardarButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.guardarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guardarButton.Image = ((System.Drawing.Image)(resources.GetObject("guardarButton.Image")));
            this.guardarButton.Location = new System.Drawing.Point(737, 313);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(91, 74);
            this.guardarButton.TabIndex = 1;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardarButton.UseVisualStyleBackColor = false;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cancelarButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.cancelarButton.FlatAppearance.BorderSize = 2;
            this.cancelarButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cancelarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelarButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelarButton.Image")));
            this.cancelarButton.Location = new System.Drawing.Point(834, 313);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(86, 74);
            this.cancelarButton.TabIndex = 2;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // borrarTodoButton
            // 
            this.borrarTodoButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.borrarTodoButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.borrarTodoButton.FlatAppearance.BorderSize = 2;
            this.borrarTodoButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.borrarTodoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarTodoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarTodoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.borrarTodoButton.Image = ((System.Drawing.Image)(resources.GetObject("borrarTodoButton.Image")));
            this.borrarTodoButton.Location = new System.Drawing.Point(737, 233);
            this.borrarTodoButton.Name = "borrarTodoButton";
            this.borrarTodoButton.Size = new System.Drawing.Size(91, 78);
            this.borrarTodoButton.TabIndex = 4;
            this.borrarTodoButton.Text = "Borrar Todo";
            this.borrarTodoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.borrarTodoButton.UseVisualStyleBackColor = false;
            this.borrarTodoButton.Click += new System.EventHandler(this.borrarTodoButton_Click);
            // 
            // borrarLineaButton
            // 
            this.borrarLineaButton.AutoEllipsis = true;
            this.borrarLineaButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.borrarLineaButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.borrarLineaButton.FlatAppearance.BorderSize = 2;
            this.borrarLineaButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.borrarLineaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrarLineaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarLineaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.borrarLineaButton.Image = ((System.Drawing.Image)(resources.GetObject("borrarLineaButton.Image")));
            this.borrarLineaButton.Location = new System.Drawing.Point(637, 233);
            this.borrarLineaButton.Name = "borrarLineaButton";
            this.borrarLineaButton.Size = new System.Drawing.Size(94, 78);
            this.borrarLineaButton.TabIndex = 3;
            this.borrarLineaButton.Text = "Borrar Línea";
            this.borrarLineaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.borrarLineaButton.UseVisualStyleBackColor = false;
            this.borrarLineaButton.Click += new System.EventHandler(this.borrarLineaButton_Click);
            // 
            // salirButton
            // 
            this.salirButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.salirButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.salirButton.FlatAppearance.BorderSize = 2;
            this.salirButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.salirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salirButton.Image = ((System.Drawing.Image)(resources.GetObject("salirButton.Image")));
            this.salirButton.Location = new System.Drawing.Point(834, 233);
            this.salirButton.Name = "salirButton";
            this.salirButton.Size = new System.Drawing.Size(86, 78);
            this.salirButton.TabIndex = 5;
            this.salirButton.Text = "Salir";
            this.salirButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.salirButton.UseVisualStyleBackColor = false;
            this.salirButton.Click += new System.EventHandler(this.salirButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.terminosGarantiaTextBox);
            this.groupBox1.Controls.Add(this.BusquedaProductoButton);
            this.groupBox1.Controls.Add(idProductoLabel);
            this.groupBox1.Controls.Add(this.vehiculoComboBox);
            this.groupBox1.Controls.Add(contratoLabel);
            this.groupBox1.Controls.Add(this.contratoTextBox);
            this.groupBox1.Controls.Add(numeroCosteoLabel);
            this.groupBox1.Controls.Add(this.numeroCosteoTextBox);
            this.groupBox1.Controls.Add(this.BusquedaClienteButton);
            this.groupBox1.Controls.Add(idClienteLabel);
            this.groupBox1.Controls.Add(this.entidadComboBox);
            this.groupBox1.Controls.Add(formaPagoLabel);
            this.groupBox1.Controls.Add(this.formaPagoTextBox);
            this.groupBox1.Controls.Add(this.plazoEntregaTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fechaDateTimePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 226);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            // 
            // terminosGarantiaTextBox
            // 
            this.terminosGarantiaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.terminosGarantiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenCompraBindingSource, "FormaPago", true));
            this.terminosGarantiaTextBox.Location = new System.Drawing.Point(105, 104);
            this.terminosGarantiaTextBox.Name = "terminosGarantiaTextBox";
            this.terminosGarantiaTextBox.Size = new System.Drawing.Size(408, 20);
            this.terminosGarantiaTextBox.TabIndex = 7;
            // 
            // ordenCompraBindingSource
            // 
            this.ordenCompraBindingSource.DataMember = "OrdenCompra";
            this.ordenCompraBindingSource.DataSource = this.dSCOCOA;
            // 
            // BusquedaProductoButton
            // 
            this.BusquedaProductoButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BusquedaProductoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusquedaProductoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BusquedaProductoButton.Location = new System.Drawing.Point(537, 181);
            this.BusquedaProductoButton.Name = "BusquedaProductoButton";
            this.BusquedaProductoButton.Size = new System.Drawing.Size(76, 23);
            this.BusquedaProductoButton.TabIndex = 17;
            this.BusquedaProductoButton.Text = "Buscar";
            this.BusquedaProductoButton.UseVisualStyleBackColor = false;
            this.BusquedaProductoButton.Click += new System.EventHandler(this.BusquedaProductoButton_Click);
            // 
            // vehiculoComboBox
            // 
            this.vehiculoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordenCompraBindingSource, "IdProducto", true));
            this.vehiculoComboBox.DataSource = this.productosBindingSource;
            this.vehiculoComboBox.DisplayMember = "DescripcionProducto";
            this.vehiculoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehiculoComboBox.FormattingEnabled = true;
            this.vehiculoComboBox.Location = new System.Drawing.Point(105, 183);
            this.vehiculoComboBox.Name = "vehiculoComboBox";
            this.vehiculoComboBox.Size = new System.Drawing.Size(408, 21);
            this.vehiculoComboBox.TabIndex = 16;
            this.vehiculoComboBox.ValueMember = "IdProducto";
            // 
            // contratoTextBox
            // 
            this.contratoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.contratoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenCompraBindingSource, "Contrato", true));
            this.contratoTextBox.Location = new System.Drawing.Point(302, 157);
            this.contratoTextBox.Name = "contratoTextBox";
            this.contratoTextBox.Size = new System.Drawing.Size(211, 20);
            this.contratoTextBox.TabIndex = 14;
            // 
            // numeroCosteoTextBox
            // 
            this.numeroCosteoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenCompraBindingSource, "NumeroCosteo", true));
            this.numeroCosteoTextBox.Location = new System.Drawing.Point(105, 157);
            this.numeroCosteoTextBox.Name = "numeroCosteoTextBox";
            this.numeroCosteoTextBox.Size = new System.Drawing.Size(117, 20);
            this.numeroCosteoTextBox.TabIndex = 12;
            this.numeroCosteoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroCosteoTextBox_KeyPress);
            // 
            // BusquedaClienteButton
            // 
            this.BusquedaClienteButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BusquedaClienteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusquedaClienteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BusquedaClienteButton.Location = new System.Drawing.Point(537, 128);
            this.BusquedaClienteButton.Name = "BusquedaClienteButton";
            this.BusquedaClienteButton.Size = new System.Drawing.Size(76, 23);
            this.BusquedaClienteButton.TabIndex = 10;
            this.BusquedaClienteButton.Text = "Buscar";
            this.BusquedaClienteButton.UseVisualStyleBackColor = false;
            this.BusquedaClienteButton.Click += new System.EventHandler(this.BusquedaClienteButton_Click);
            // 
            // entidadComboBox
            // 
            this.entidadComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ordenCompraBindingSource, "IdCliente", true));
            this.entidadComboBox.DataSource = this.clientesBindingSource;
            this.entidadComboBox.DisplayMember = "NombreCliente";
            this.entidadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entidadComboBox.FormattingEnabled = true;
            this.entidadComboBox.Location = new System.Drawing.Point(105, 130);
            this.entidadComboBox.Name = "entidadComboBox";
            this.entidadComboBox.Size = new System.Drawing.Size(408, 21);
            this.entidadComboBox.TabIndex = 9;
            this.entidadComboBox.ValueMember = "IdCliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dSCOCOA;
            // 
            // formaPagoTextBox
            // 
            this.formaPagoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.formaPagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenCompraBindingSource, "FormaPago", true));
            this.formaPagoTextBox.Location = new System.Drawing.Point(105, 78);
            this.formaPagoTextBox.Name = "formaPagoTextBox";
            this.formaPagoTextBox.Size = new System.Drawing.Size(408, 20);
            this.formaPagoTextBox.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.editarPrecioButton);
            this.groupBox2.Controls.Add(this.productoButton);
            this.groupBox2.Controls.Add(this.editarDescuentoButton);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.descuentoTextBox);
            this.groupBox2.Controls.Add(this.productoTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.proveedorComboBox);
            this.groupBox2.Controls.Add(this.busquedaProveedorButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buscarProductoButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cantidadTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.precioTextBox);
            this.groupBox2.Controls.Add(this.productoLabel);
            this.groupBox2.Location = new System.Drawing.Point(6, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 143);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // productoButton
            // 
            this.productoButton.BackColor = System.Drawing.Color.SteelBlue;
            this.productoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoButton.ForeColor = System.Drawing.SystemColors.Window;
            this.productoButton.Location = new System.Drawing.Point(537, 105);
            this.productoButton.Name = "productoButton";
            this.productoButton.Size = new System.Drawing.Size(76, 23);
            this.productoButton.TabIndex = 11;
            this.productoButton.Text = "Producto";
            this.productoButton.UseVisualStyleBackColor = false;
            this.productoButton.Click += new System.EventHandler(this.productoButton_Click);
            // 
            // editarDescuentoButton
            // 
            this.editarDescuentoButton.BackColor = System.Drawing.Color.Tomato;
            this.editarDescuentoButton.Enabled = false;
            this.editarDescuentoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarDescuentoButton.ForeColor = System.Drawing.SystemColors.Window;
            this.editarDescuentoButton.Location = new System.Drawing.Point(249, 102);
            this.editarDescuentoButton.Name = "editarDescuentoButton";
            this.editarDescuentoButton.Size = new System.Drawing.Size(76, 23);
            this.editarDescuentoButton.TabIndex = 14;
            this.editarDescuentoButton.Text = "Editar";
            this.editarDescuentoButton.UseVisualStyleBackColor = false;
            this.editarDescuentoButton.Click += new System.EventHandler(this.desbloquearDescuentoButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Descuento:";
            // 
            // descuentoTextBox
            // 
            this.descuentoTextBox.Enabled = false;
            this.descuentoTextBox.Location = new System.Drawing.Point(103, 102);
            this.descuentoTextBox.Name = "descuentoTextBox";
            this.descuentoTextBox.ReadOnly = true;
            this.descuentoTextBox.Size = new System.Drawing.Size(119, 20);
            this.descuentoTextBox.TabIndex = 13;
            this.descuentoTextBox.Text = "0.00";
            this.descuentoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descuentoTextBox_KeyPress);
            // 
            // ordenCompraTableAdapter
            // 
            this.ordenCompraTableAdapter.ClearBeforeFill = true;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(964, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "Descuento";
            // 
            // totalDescuentoTextBox
            // 
            this.totalDescuentoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalDescuentoTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.totalDescuentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDescuentoTextBox.Location = new System.Drawing.Point(1037, 337);
            this.totalDescuentoTextBox.Name = "totalDescuentoTextBox";
            this.totalDescuentoTextBox.ReadOnly = true;
            this.totalDescuentoTextBox.Size = new System.Drawing.Size(125, 21);
            this.totalDescuentoTextBox.TabIndex = 13;
            this.totalDescuentoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // editarPrecioButton
            // 
            this.editarPrecioButton.BackColor = System.Drawing.Color.Tomato;
            this.editarPrecioButton.Enabled = false;
            this.editarPrecioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarPrecioButton.ForeColor = System.Drawing.SystemColors.Window;
            this.editarPrecioButton.Location = new System.Drawing.Point(537, 76);
            this.editarPrecioButton.Name = "editarPrecioButton";
            this.editarPrecioButton.Size = new System.Drawing.Size(76, 23);
            this.editarPrecioButton.TabIndex = 15;
            this.editarPrecioButton.Text = "Editar";
            this.editarPrecioButton.UseVisualStyleBackColor = false;
            this.editarPrecioButton.Click += new System.EventHandler(this.editarPrecioButton_Click);
            // 
            // frmOrdenCompras
            // 
            this.AcceptButton = this.agregarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1174, 677);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.totalDescuentoTextBox);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.salirButton);
            this.Controls.Add(this.borrarTodoButton);
            this.Controls.Add(this.borrarLineaButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalNetoTextBox);
            this.Controls.Add(this.totalImpoconsumoTextBox);
            this.Controls.Add(this.totalIVATextBox);
            this.Controls.Add(this.totalSubtotalTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.detalleOrdenCompraDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrdenCompras";
            this.Text = "Ordenes de Compra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrdenCompras_FormClosing);
            this.Load += new System.EventHandler(this.frmOrdenCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleOrdenCompraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenCompraDetalleBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordenCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox proveedorComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox plazoEntregaTextBox;
        private DSCOCOA dSCOCOA;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private DSCOCOATableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.Button busquedaProveedorButton;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buscarProductoButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private DSCOCOATableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridView detalleOrdenCompraDataGridView;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label productoLabel;
        private System.Windows.Forms.TextBox productoTextBox;
        private System.Windows.Forms.BindingSource ordenCompraDetalleBindingSource;
        private DSCOCOATableAdapters.OrdenCompraDetalleTableAdapter ordenCompraDetalleTableAdapter;
        private DSCOCOATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totalNetoTextBox;
        private System.Windows.Forms.TextBox totalImpoconsumoTextBox;
        private System.Windows.Forms.TextBox totalIVATextBox;
        private System.Windows.Forms.TextBox totalSubtotalTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.Button borrarTodoButton;
        private System.Windows.Forms.Button borrarLineaButton;
        private System.Windows.Forms.Button salirButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource ordenCompraBindingSource;
        private DSCOCOATableAdapters.OrdenCompraTableAdapter ordenCompraTableAdapter;
        private System.Windows.Forms.TextBox formaPagoTextBox;
        private System.Windows.Forms.TextBox contratoTextBox;
        private System.Windows.Forms.TextBox numeroCosteoTextBox;
        private System.Windows.Forms.Button BusquedaClienteButton;
        private System.Windows.Forms.ComboBox entidadComboBox;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DSCOCOATableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.ComboBox vehiculoComboBox;
        private System.Windows.Forms.Button BusquedaProductoButton;
        private System.Windows.Forms.TextBox terminosGarantiaTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox descuentoTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox totalDescuentoTextBox;
        private System.Windows.Forms.Button editarDescuentoButton;
        private System.Windows.Forms.Button productoButton;
        private System.Windows.Forms.Button editarPrecioButton;
    }
}