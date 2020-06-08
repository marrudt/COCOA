namespace COCOA.Maestras
{
    partial class frmCilindraje
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
            System.Windows.Forms.Label descripcionCilindrajeLabel;
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label idCilindrajeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCilindraje));
            this.dSCOCOA = new COCOA.DSCOCOA();
            this.cilindrajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cilindrajesTableAdapter = new COCOA.DSCOCOATableAdapters.CilindrajesTableAdapter();
            this.tableAdapterManager = new COCOA.DSCOCOATableAdapters.TableAdapterManager();
            this.cilindrajesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cilindrajesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descripcionCilindrajeTextBox = new System.Windows.Forms.TextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.idCilindrajeTextBox = new System.Windows.Forms.TextBox();
            descripcionCilindrajeLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            idCilindrajeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cilindrajesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cilindrajesBindingNavigator)).BeginInit();
            this.cilindrajesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cilindrajesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionCilindrajeLabel
            // 
            descripcionCilindrajeLabel.AutoSize = true;
            descripcionCilindrajeLabel.Location = new System.Drawing.Point(10, 72);
            descripcionCilindrajeLabel.Name = "descripcionCilindrajeLabel";
            descripcionCilindrajeLabel.Size = new System.Drawing.Size(66, 13);
            descripcionCilindrajeLabel.TabIndex = 0;
            descripcionCilindrajeLabel.Text = "Descripción:";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(36, 100);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 2;
            activoLabel.Text = "Activo:";
            // 
            // idCilindrajeLabel
            // 
            idCilindrajeLabel.AutoSize = true;
            idCilindrajeLabel.Location = new System.Drawing.Point(57, 46);
            idCilindrajeLabel.Name = "idCilindrajeLabel";
            idCilindrajeLabel.Size = new System.Drawing.Size(19, 13);
            idCilindrajeLabel.TabIndex = 6;
            idCilindrajeLabel.Text = "Id:";
            // 
            // dSCOCOA
            // 
            this.dSCOCOA.DataSetName = "DSCOCOA";
            this.dSCOCOA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cilindrajesBindingSource
            // 
            this.cilindrajesBindingSource.DataMember = "Cilindrajes";
            this.cilindrajesBindingSource.DataSource = this.dSCOCOA;
            // 
            // cilindrajesTableAdapter
            // 
            this.cilindrajesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CilindrajesTableAdapter = this.cilindrajesTableAdapter;
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
            // cilindrajesBindingNavigator
            // 
            this.cilindrajesBindingNavigator.AddNewItem = null;
            this.cilindrajesBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.cilindrajesBindingNavigator.BindingSource = this.cilindrajesBindingSource;
            this.cilindrajesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cilindrajesBindingNavigator.DeleteItem = null;
            this.cilindrajesBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cilindrajesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cilindrajesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cilindrajesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cilindrajesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cilindrajesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cilindrajesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cilindrajesBindingNavigator.Name = "cilindrajesBindingNavigator";
            this.cilindrajesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cilindrajesBindingNavigator.Size = new System.Drawing.Size(423, 31);
            this.cilindrajesBindingNavigator.TabIndex = 0;
            this.cilindrajesBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorAddNewItem.ToolTipText = "Agregar";
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
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.cilindrajesBindingNavigatorSaveItem_Click);
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
            // cilindrajesDataGridView
            // 
            this.cilindrajesDataGridView.AllowUserToAddRows = false;
            this.cilindrajesDataGridView.AllowUserToDeleteRows = false;
            this.cilindrajesDataGridView.AllowUserToOrderColumns = true;
            this.cilindrajesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cilindrajesDataGridView.AutoGenerateColumns = false;
            this.cilindrajesDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cilindrajesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cilindrajesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cilindrajesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.cilindrajesDataGridView.DataSource = this.cilindrajesBindingSource;
            this.cilindrajesDataGridView.Location = new System.Drawing.Point(2, 125);
            this.cilindrajesDataGridView.Name = "cilindrajesDataGridView";
            this.cilindrajesDataGridView.ReadOnly = true;
            this.cilindrajesDataGridView.Size = new System.Drawing.Size(420, 291);
            this.cilindrajesDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdCilindraje";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 41;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DescripcionCilindraje";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 88;
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
            // descripcionCilindrajeTextBox
            // 
            this.descripcionCilindrajeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descripcionCilindrajeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cilindrajesBindingSource, "DescripcionCilindraje", true));
            this.descripcionCilindrajeTextBox.Location = new System.Drawing.Point(80, 69);
            this.descripcionCilindrajeTextBox.Name = "descripcionCilindrajeTextBox";
            this.descripcionCilindrajeTextBox.ReadOnly = true;
            this.descripcionCilindrajeTextBox.Size = new System.Drawing.Size(313, 20);
            this.descripcionCilindrajeTextBox.TabIndex = 1;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.Checked = true;
            this.activoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.cilindrajesBindingSource, "Activo", true));
            this.activoCheckBox.Enabled = false;
            this.activoCheckBox.Location = new System.Drawing.Point(80, 95);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(16, 24);
            this.activoCheckBox.TabIndex = 3;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // idCilindrajeTextBox
            // 
            this.idCilindrajeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cilindrajesBindingSource, "IdCilindraje", true));
            this.idCilindrajeTextBox.Enabled = false;
            this.idCilindrajeTextBox.Location = new System.Drawing.Point(80, 43);
            this.idCilindrajeTextBox.Name = "idCilindrajeTextBox";
            this.idCilindrajeTextBox.ReadOnly = true;
            this.idCilindrajeTextBox.Size = new System.Drawing.Size(41, 20);
            this.idCilindrajeTextBox.TabIndex = 7;
            // 
            // frmCilindraje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(423, 417);
            this.Controls.Add(idCilindrajeLabel);
            this.Controls.Add(this.idCilindrajeTextBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(descripcionCilindrajeLabel);
            this.Controls.Add(this.descripcionCilindrajeTextBox);
            this.Controls.Add(this.cilindrajesDataGridView);
            this.Controls.Add(this.cilindrajesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCilindraje";
            this.Text = "Cilindraje";
            this.Load += new System.EventHandler(this.frmCilindraje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cilindrajesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cilindrajesBindingNavigator)).EndInit();
            this.cilindrajesBindingNavigator.ResumeLayout(false);
            this.cilindrajesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cilindrajesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSCOCOA dSCOCOA;
        private System.Windows.Forms.BindingSource cilindrajesBindingSource;
        private DSCOCOATableAdapters.CilindrajesTableAdapter cilindrajesTableAdapter;
        private DSCOCOATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cilindrajesBindingNavigator;
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
        private System.Windows.Forms.DataGridView cilindrajesDataGridView;
        private System.Windows.Forms.TextBox descripcionCilindrajeTextBox;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEdit;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox idCilindrajeTextBox;
    }
}