﻿namespace COCOA.Transacciones
{
    partial class frmCotizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCotizaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.salirButton = new System.Windows.Forms.Button();
            this.borrarTodoButton = new System.Windows.Forms.Button();
            this.borrarLineaButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.guardarButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalNetoTextBox = new System.Windows.Forms.TextBox();
            this.totalImpoconsumoTextBox = new System.Windows.Forms.TextBox();
            this.totalIVATextBox = new System.Windows.Forms.TextBox();
            this.totalSubtotalTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.detalleCotizacionDataGridView = new System.Windows.Forms.DataGridView();
            this.agregarButton = new System.Windows.Forms.Button();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCOCOA = new COCOA.DSCOCOA();
            this.clientesTableAdapter = new COCOA.DSCOCOATableAdapters.ClientesTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.sitioEntregaTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.plazoEntregaTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.formaPagoTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.busquedaClienteButton = new System.Windows.Forms.Button();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalEstampillasTextBox = new System.Windows.Forms.TextBox();
            this.detalleItemTextBox = new System.Windows.Forms.TextBox();
            this.estampillasTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.productoLabel = new System.Windows.Forms.Label();
            this.productoTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buscarProductoButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numeroItemTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.intervaloPreciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pesoBrutoVhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroPasajerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cilindrajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segmentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.segmentosTableAdapter = new COCOA.DSCOCOATableAdapters.SegmentosTableAdapter();
            this.cilindrajesTableAdapter = new COCOA.DSCOCOATableAdapters.CilindrajesTableAdapter();
            this.numeroPasajerosTableAdapter = new COCOA.DSCOCOATableAdapters.NumeroPasajerosTableAdapter();
            this.pesoBrutoVhTableAdapter = new COCOA.DSCOCOATableAdapters.PesoBrutoVhTableAdapter();
            this.intervaloPreciosTableAdapter = new COCOA.DSCOCOATableAdapters.IntervaloPreciosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCotizacionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervaloPreciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoBrutoVhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroPasajerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cilindrajesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmentosBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.salirButton.Location = new System.Drawing.Point(1182, 128);
            this.salirButton.Name = "salirButton";
            this.salirButton.Size = new System.Drawing.Size(82, 73);
            this.salirButton.TabIndex = 8;
            this.salirButton.Text = "Salir";
            this.salirButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.salirButton.UseVisualStyleBackColor = false;
            this.salirButton.Click += new System.EventHandler(this.salirButton_Click);
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
            this.borrarTodoButton.Location = new System.Drawing.Point(1094, 128);
            this.borrarTodoButton.Name = "borrarTodoButton";
            this.borrarTodoButton.Size = new System.Drawing.Size(82, 73);
            this.borrarTodoButton.TabIndex = 7;
            this.borrarTodoButton.Text = "Borra Todo";
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
            this.borrarLineaButton.Location = new System.Drawing.Point(997, 128);
            this.borrarLineaButton.Name = "borrarLineaButton";
            this.borrarLineaButton.Size = new System.Drawing.Size(91, 74);
            this.borrarLineaButton.TabIndex = 6;
            this.borrarLineaButton.Text = "Borra Línea";
            this.borrarLineaButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.borrarLineaButton.UseVisualStyleBackColor = false;
            this.borrarLineaButton.Click += new System.EventHandler(this.borrarLineaButton_Click);
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
            this.cancelarButton.Location = new System.Drawing.Point(1182, 39);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(82, 83);
            this.cancelarButton.TabIndex = 5;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cancelarButton.UseVisualStyleBackColor = false;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
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
            this.guardarButton.Location = new System.Drawing.Point(1094, 39);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(82, 83);
            this.guardarButton.TabIndex = 4;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardarButton.UseVisualStyleBackColor = false;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1337, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Total";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1285, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Impoconsumo";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1347, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "IVA";
            // 
            // totalNetoTextBox
            // 
            this.totalNetoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.totalNetoTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.totalNetoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNetoTextBox.Location = new System.Drawing.Point(1376, 184);
            this.totalNetoTextBox.Name = "totalNetoTextBox";
            this.totalNetoTextBox.ReadOnly = true;
            this.totalNetoTextBox.Size = new System.Drawing.Size(125, 21);
            this.totalNetoTextBox.TabIndex = 16;
            this.totalNetoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalImpoconsumoTextBox
            // 
            this.totalImpoconsumoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.totalImpoconsumoTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.totalImpoconsumoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalImpoconsumoTextBox.Location = new System.Drawing.Point(1376, 159);
            this.totalImpoconsumoTextBox.Name = "totalImpoconsumoTextBox";
            this.totalImpoconsumoTextBox.ReadOnly = true;
            this.totalImpoconsumoTextBox.Size = new System.Drawing.Size(125, 21);
            this.totalImpoconsumoTextBox.TabIndex = 14;
            this.totalImpoconsumoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalIVATextBox
            // 
            this.totalIVATextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.totalIVATextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.totalIVATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalIVATextBox.Location = new System.Drawing.Point(1376, 134);
            this.totalIVATextBox.Name = "totalIVATextBox";
            this.totalIVATextBox.ReadOnly = true;
            this.totalIVATextBox.Size = new System.Drawing.Size(125, 21);
            this.totalIVATextBox.TabIndex = 12;
            this.totalIVATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalSubtotalTextBox
            // 
            this.totalSubtotalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.totalSubtotalTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.totalSubtotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSubtotalTextBox.Location = new System.Drawing.Point(1376, 110);
            this.totalSubtotalTextBox.Name = "totalSubtotalTextBox";
            this.totalSubtotalTextBox.ReadOnly = true;
            this.totalSubtotalTextBox.Size = new System.Drawing.Size(125, 21);
            this.totalSubtotalTextBox.TabIndex = 10;
            this.totalSubtotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1319, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Subtotal";
            // 
            // detalleCotizacionDataGridView
            // 
            this.detalleCotizacionDataGridView.AllowUserToAddRows = false;
            this.detalleCotizacionDataGridView.AllowUserToDeleteRows = false;
            this.detalleCotizacionDataGridView.AllowUserToOrderColumns = true;
            this.detalleCotizacionDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.detalleCotizacionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detalleCotizacionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.detalleCotizacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detalleCotizacionDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.detalleCotizacionDataGridView.Location = new System.Drawing.Point(0, 211);
            this.detalleCotizacionDataGridView.Name = "detalleCotizacionDataGridView";
            this.detalleCotizacionDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detalleCotizacionDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.detalleCotizacionDataGridView.Size = new System.Drawing.Size(1513, 298);
            this.detalleCotizacionDataGridView.TabIndex = 17;
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
            this.agregarButton.Location = new System.Drawing.Point(997, 39);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(91, 83);
            this.agregarButton.TabIndex = 3;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.agregarButton.UseVisualStyleBackColor = false;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dSCOCOA;
            // 
            // dSCOCOA
            // 
            this.dSCOCOA.DataSetName = "DSCOCOA";
            this.dSCOCOA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.contactoTextBox);
            this.groupBox1.Controls.Add(this.sitioEntregaTextBox);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.plazoEntregaTextBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.formaPagoTextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.busquedaClienteButton);
            this.groupBox1.Controls.Add(this.clienteComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fechaDateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.contactoTextBox.Location = new System.Drawing.Point(66, 70);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(353, 20);
            this.contactoTextBox.TabIndex = 6;
            // 
            // sitioEntregaTextBox
            // 
            this.sitioEntregaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.sitioEntregaTextBox.Location = new System.Drawing.Point(618, 69);
            this.sitioEntregaTextBox.Name = "sitioEntregaTextBox";
            this.sitioEntregaTextBox.Size = new System.Drawing.Size(301, 20);
            this.sitioEntregaTextBox.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(545, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Sitio Entrega:";
            // 
            // plazoEntregaTextBox
            // 
            this.plazoEntregaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.plazoEntregaTextBox.Location = new System.Drawing.Point(618, 43);
            this.plazoEntregaTextBox.Name = "plazoEntregaTextBox";
            this.plazoEntregaTextBox.Size = new System.Drawing.Size(301, 20);
            this.plazoEntregaTextBox.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(538, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Plazo Entrega:";
            // 
            // formaPagoTextBox
            // 
            this.formaPagoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.formaPagoTextBox.Location = new System.Drawing.Point(618, 17);
            this.formaPagoTextBox.Name = "formaPagoTextBox";
            this.formaPagoTextBox.Size = new System.Drawing.Size(301, 20);
            this.formaPagoTextBox.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(532, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Forma de Pago:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contacto:";
            // 
            // busquedaClienteButton
            // 
            this.busquedaClienteButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.busquedaClienteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaClienteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.busquedaClienteButton.Location = new System.Drawing.Point(447, 41);
            this.busquedaClienteButton.Name = "busquedaClienteButton";
            this.busquedaClienteButton.Size = new System.Drawing.Size(63, 23);
            this.busquedaClienteButton.TabIndex = 4;
            this.busquedaClienteButton.Text = "Buscar";
            this.busquedaClienteButton.UseVisualStyleBackColor = false;
            this.busquedaClienteButton.Click += new System.EventHandler(this.busquedaClienteButton_Click);
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientesBindingSource, "IdCliente", true));
            this.clienteComboBox.DataSource = this.clientesBindingSource;
            this.clienteComboBox.DisplayMember = "NombreCliente";
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(66, 43);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(353, 21);
            this.clienteComboBox.TabIndex = 3;
            this.clienteComboBox.ValueMember = "IdCliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.CustomFormat = "";
            this.fechaDateTimePicker.Enabled = false;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(66, 17);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(198, 20);
            this.fechaDateTimePicker.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.totalEstampillasTextBox);
            this.groupBox2.Controls.Add(this.detalleItemTextBox);
            this.groupBox2.Controls.Add(this.estampillasTextBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.productoLabel);
            this.groupBox2.Controls.Add(this.productoTextBox);
            this.groupBox2.Controls.Add(this.precioTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cantidadTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.buscarProductoButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numeroItemTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(949, 80);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // totalEstampillasTextBox
            // 
            this.totalEstampillasTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.totalEstampillasTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.totalEstampillasTextBox.Enabled = false;
            this.totalEstampillasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEstampillasTextBox.Location = new System.Drawing.Point(725, 52);
            this.totalEstampillasTextBox.Name = "totalEstampillasTextBox";
            this.totalEstampillasTextBox.ReadOnly = true;
            this.totalEstampillasTextBox.Size = new System.Drawing.Size(125, 20);
            this.totalEstampillasTextBox.TabIndex = 17;
            this.totalEstampillasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.totalEstampillasTextBox.Visible = false;
            // 
            // detalleItemTextBox
            // 
            this.detalleItemTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.detalleItemTextBox.Location = new System.Drawing.Point(129, 23);
            this.detalleItemTextBox.Name = "detalleItemTextBox";
            this.detalleItemTextBox.Size = new System.Drawing.Size(290, 20);
            this.detalleItemTextBox.TabIndex = 2;
            // 
            // estampillasTextBox
            // 
            this.estampillasTextBox.Location = new System.Drawing.Point(586, 49);
            this.estampillasTextBox.Name = "estampillasTextBox";
            this.estampillasTextBox.Size = new System.Drawing.Size(67, 20);
            this.estampillasTextBox.TabIndex = 10;
            this.estampillasTextBox.Text = "0.00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(521, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Estampillas:";
            // 
            // productoLabel
            // 
            this.productoLabel.AutoSize = true;
            this.productoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoLabel.ForeColor = System.Drawing.Color.Maroon;
            this.productoLabel.Location = new System.Drawing.Point(129, 52);
            this.productoLabel.Name = "productoLabel";
            this.productoLabel.Size = new System.Drawing.Size(104, 15);
            this.productoLabel.TabIndex = 5;
            this.productoLabel.Text = "Detalle Producto";
            // 
            // productoTextBox
            // 
            this.productoTextBox.Enabled = false;
            this.productoTextBox.Location = new System.Drawing.Point(66, 48);
            this.productoTextBox.Name = "productoTextBox";
            this.productoTextBox.Size = new System.Drawing.Size(41, 20);
            this.productoTextBox.TabIndex = 4;
            this.productoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productoTextBox_KeyPress_1);
            this.productoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.productoTextBox_Validating_1);
            // 
            // precioTextBox
            // 
            this.precioTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.precioTextBox.Enabled = false;
            this.precioTextBox.Location = new System.Drawing.Point(815, 22);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(119, 20);
            this.precioTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(733, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Precio Unitario:";
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(586, 22);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(119, 20);
            this.cantidadTextBox.TabIndex = 8;
            this.cantidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadTextBox_KeyPress_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cantidad:";
            // 
            // buscarProductoButton
            // 
            this.buscarProductoButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buscarProductoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarProductoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buscarProductoButton.Location = new System.Drawing.Point(447, 46);
            this.buscarProductoButton.Name = "buscarProductoButton";
            this.buscarProductoButton.Size = new System.Drawing.Size(63, 23);
            this.buscarProductoButton.TabIndex = 6;
            this.buscarProductoButton.Text = "Buscar";
            this.buscarProductoButton.UseVisualStyleBackColor = false;
            this.buscarProductoButton.Click += new System.EventHandler(this.buscarProductoButton_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Producto:";
            // 
            // numeroItemTextBox
            // 
            this.numeroItemTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.numeroItemTextBox.Location = new System.Drawing.Point(66, 22);
            this.numeroItemTextBox.Name = "numeroItemTextBox";
            this.numeroItemTextBox.Size = new System.Drawing.Size(31, 20);
            this.numeroItemTextBox.TabIndex = 1;
            this.numeroItemTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeroItemTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "No. Item:";
            // 
            // intervaloPreciosBindingSource
            // 
            this.intervaloPreciosBindingSource.DataMember = "IntervaloPrecios";
            this.intervaloPreciosBindingSource.DataSource = this.dSCOCOA;
            // 
            // pesoBrutoVhBindingSource
            // 
            this.pesoBrutoVhBindingSource.DataMember = "PesoBrutoVh";
            this.pesoBrutoVhBindingSource.DataSource = this.dSCOCOA;
            // 
            // numeroPasajerosBindingSource
            // 
            this.numeroPasajerosBindingSource.DataMember = "NumeroPasajeros";
            this.numeroPasajerosBindingSource.DataSource = this.dSCOCOA;
            // 
            // cilindrajesBindingSource
            // 
            this.cilindrajesBindingSource.DataMember = "Cilindrajes";
            this.cilindrajesBindingSource.DataSource = this.dSCOCOA;
            // 
            // segmentosBindingSource
            // 
            this.segmentosBindingSource.DataMember = "Segmentos";
            this.segmentosBindingSource.DataSource = this.dSCOCOA;
            // 
            // segmentosTableAdapter
            // 
            this.segmentosTableAdapter.ClearBeforeFill = true;
            // 
            // cilindrajesTableAdapter
            // 
            this.cilindrajesTableAdapter.ClearBeforeFill = true;
            // 
            // numeroPasajerosTableAdapter
            // 
            this.numeroPasajerosTableAdapter.ClearBeforeFill = true;
            // 
            // pesoBrutoVhTableAdapter
            // 
            this.pesoBrutoVhTableAdapter.ClearBeforeFill = true;
            // 
            // intervaloPreciosTableAdapter
            // 
            this.intervaloPreciosTableAdapter.ClearBeforeFill = true;
            // 
            // frmCotizaciones
            // 
            this.AcceptButton = this.agregarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1513, 510);
            this.ControlBox = false;
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.groupBox2);
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
            this.Controls.Add(this.detalleCotizacionDataGridView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCotizaciones";
            this.Text = "Cotizaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCotizaciones_FormClosing);
            this.Load += new System.EventHandler(this.frmCotizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detalleCotizacionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervaloPreciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesoBrutoVhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroPasajerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cilindrajesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmentosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button salirButton;
        private System.Windows.Forms.Button borrarTodoButton;
        private System.Windows.Forms.Button borrarLineaButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalNetoTextBox;
        private System.Windows.Forms.TextBox totalImpoconsumoTextBox;
        private System.Windows.Forms.TextBox totalIVATextBox;
        private System.Windows.Forms.TextBox totalSubtotalTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView detalleCotizacionDataGridView;
        private System.Windows.Forms.Button agregarButton;
        private DSCOCOA dSCOCOA;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DSCOCOATableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox estampillasTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label productoLabel;
        private System.Windows.Forms.TextBox productoTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buscarProductoButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numeroItemTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.TextBox sitioEntregaTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox plazoEntregaTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox formaPagoTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button busquedaClienteButton;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource segmentosBindingSource;
        private DSCOCOATableAdapters.SegmentosTableAdapter segmentosTableAdapter;
        private System.Windows.Forms.BindingSource cilindrajesBindingSource;
        private DSCOCOATableAdapters.CilindrajesTableAdapter cilindrajesTableAdapter;
        private System.Windows.Forms.BindingSource numeroPasajerosBindingSource;
        private DSCOCOATableAdapters.NumeroPasajerosTableAdapter numeroPasajerosTableAdapter;
        private System.Windows.Forms.BindingSource pesoBrutoVhBindingSource;
        private DSCOCOATableAdapters.PesoBrutoVhTableAdapter pesoBrutoVhTableAdapter;
        private System.Windows.Forms.BindingSource intervaloPreciosBindingSource;
        private DSCOCOATableAdapters.IntervaloPreciosTableAdapter intervaloPreciosTableAdapter;
        private System.Windows.Forms.TextBox detalleItemTextBox;
        private System.Windows.Forms.TextBox totalEstampillasTextBox;
    }
}