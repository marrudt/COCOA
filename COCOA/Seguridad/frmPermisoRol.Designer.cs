namespace COCOA.Seguridad
{
    partial class frmPermisoRol
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
            System.Windows.Forms.Label idRolLabel;
            System.Windows.Forms.Label idFormularioLabel;
            System.Windows.Forms.Label puedeVerLabel;
            System.Windows.Forms.Label puedeEditarLabel;
            System.Windows.Forms.Label puedeEliminarLabel;
            System.Windows.Forms.Label especificoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermisoRol));
            this.dSCOCOA = new COCOA.DSCOCOA();
            this.permisoRolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permisoRolTableAdapter = new COCOA.DSCOCOATableAdapters.PermisoRolTableAdapter();
            this.tableAdapterManager = new COCOA.DSCOCOATableAdapters.TableAdapterManager();
            this.formularioTableAdapter = new COCOA.DSCOCOATableAdapters.FormularioTableAdapter();
            this.rolTableAdapter = new COCOA.DSCOCOATableAdapters.RolTableAdapter();
            this.permisoRolBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formularioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idRolComboBox = new System.Windows.Forms.ComboBox();
            this.idFormularioComboBox = new System.Windows.Forms.ComboBox();
            this.puedeVerCheckBox = new System.Windows.Forms.CheckBox();
            this.puedeEditarCheckBox = new System.Windows.Forms.CheckBox();
            this.puedeEliminarCheckBox = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.permisoRolDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.especificoCheckBox = new System.Windows.Forms.CheckBox();
            idRolLabel = new System.Windows.Forms.Label();
            idFormularioLabel = new System.Windows.Forms.Label();
            puedeVerLabel = new System.Windows.Forms.Label();
            puedeEditarLabel = new System.Windows.Forms.Label();
            puedeEliminarLabel = new System.Windows.Forms.Label();
            especificoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisoRolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisoRolBindingNavigator)).BeginInit();
            this.permisoRolBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formularioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisoRolDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idRolLabel
            // 
            idRolLabel.AutoSize = true;
            idRolLabel.Location = new System.Drawing.Point(177, 50);
            idRolLabel.Name = "idRolLabel";
            idRolLabel.Size = new System.Drawing.Size(26, 13);
            idRolLabel.TabIndex = 0;
            idRolLabel.Text = "Rol:";
            // 
            // idFormularioLabel
            // 
            idFormularioLabel.AutoSize = true;
            idFormularioLabel.Location = new System.Drawing.Point(145, 77);
            idFormularioLabel.Name = "idFormularioLabel";
            idFormularioLabel.Size = new System.Drawing.Size(58, 13);
            idFormularioLabel.TabIndex = 2;
            idFormularioLabel.Text = "Formulario:";
            // 
            // puedeVerLabel
            // 
            puedeVerLabel.AutoSize = true;
            puedeVerLabel.Location = new System.Drawing.Point(152, 106);
            puedeVerLabel.Name = "puedeVerLabel";
            puedeVerLabel.Size = new System.Drawing.Size(51, 13);
            puedeVerLabel.TabIndex = 4;
            puedeVerLabel.Text = "Consulta:";
            // 
            // puedeEditarLabel
            // 
            puedeEditarLabel.AutoSize = true;
            puedeEditarLabel.Location = new System.Drawing.Point(223, 106);
            puedeEditarLabel.Name = "puedeEditarLabel";
            puedeEditarLabel.Size = new System.Drawing.Size(45, 13);
            puedeEditarLabel.TabIndex = 6;
            puedeEditarLabel.Text = "Edición:";
            // 
            // puedeEliminarLabel
            // 
            puedeEliminarLabel.AutoSize = true;
            puedeEliminarLabel.Location = new System.Drawing.Point(288, 106);
            puedeEliminarLabel.Name = "puedeEliminarLabel";
            puedeEliminarLabel.Size = new System.Drawing.Size(63, 13);
            puedeEliminarLabel.TabIndex = 8;
            puedeEliminarLabel.Text = "Eliminación:";
            // 
            // especificoLabel
            // 
            especificoLabel.AutoSize = true;
            especificoLabel.Location = new System.Drawing.Point(372, 106);
            especificoLabel.Name = "especificoLabel";
            especificoLabel.Size = new System.Drawing.Size(61, 13);
            especificoLabel.TabIndex = 10;
            especificoLabel.Text = "Específico:";
            // 
            // dSCOCOA
            // 
            this.dSCOCOA.DataSetName = "DSCOCOA";
            this.dSCOCOA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // permisoRolBindingSource
            // 
            this.permisoRolBindingSource.DataMember = "PermisoRol";
            this.permisoRolBindingSource.DataSource = this.dSCOCOA;
            // 
            // permisoRolTableAdapter
            // 
            this.permisoRolTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.FormularioTableAdapter = this.formularioTableAdapter;
            this.tableAdapterManager.ImpoconsumoTableAdapter = null;
            this.tableAdapterManager.IntervaloPreciosTableAdapter = null;
            this.tableAdapterManager.IVATableAdapter = null;
            //this.tableAdapterManager.ListadoClientesTableAdapter = null;
            this.tableAdapterManager.ListadoProveedoresTableAdapter = null;
            this.tableAdapterManager.NumeroPasajerosTableAdapter = null;
            this.tableAdapterManager.OrdenCompraDetalleTableAdapter = null;
            this.tableAdapterManager.OrdenCompraTableAdapter = null;
            this.tableAdapterManager.PaisesTableAdapter = null;
            this.tableAdapterManager.PermisoRolTableAdapter = this.permisoRolTableAdapter;
            this.tableAdapterManager.PesoBrutoVhTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = this.rolTableAdapter;
            this.tableAdapterManager.SegmentosTableAdapter = null;
            this.tableAdapterManager.TipoProductoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = COCOA.DSCOCOATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // formularioTableAdapter
            // 
            this.formularioTableAdapter.ClearBeforeFill = true;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // permisoRolBindingNavigator
            // 
            this.permisoRolBindingNavigator.AddNewItem = null;
            this.permisoRolBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.permisoRolBindingNavigator.BindingSource = this.permisoRolBindingSource;
            this.permisoRolBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.permisoRolBindingNavigator.DeleteItem = null;
            this.permisoRolBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.permisoRolBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.permisoRolBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.permisoRolBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.permisoRolBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.permisoRolBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.permisoRolBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.permisoRolBindingNavigator.Name = "permisoRolBindingNavigator";
            this.permisoRolBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.permisoRolBindingNavigator.Size = new System.Drawing.Size(644, 31);
            this.permisoRolBindingNavigator.TabIndex = 0;
            this.permisoRolBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.permisoRolBindingNavigatorSaveItem_Click);
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
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            this.rolBindingSource.DataSource = this.dSCOCOA;
            // 
            // formularioBindingSource
            // 
            this.formularioBindingSource.DataMember = "Formulario";
            this.formularioBindingSource.DataSource = this.dSCOCOA;
            // 
            // idRolComboBox
            // 
            this.idRolComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.permisoRolBindingSource, "IdRol", true));
            this.idRolComboBox.DataSource = this.rolBindingSource;
            this.idRolComboBox.DisplayMember = "DescripcionRol";
            this.idRolComboBox.Enabled = false;
            this.idRolComboBox.FormattingEnabled = true;
            this.idRolComboBox.Location = new System.Drawing.Point(206, 47);
            this.idRolComboBox.Name = "idRolComboBox";
            this.idRolComboBox.Size = new System.Drawing.Size(245, 21);
            this.idRolComboBox.TabIndex = 1;
            this.idRolComboBox.ValueMember = "IdRol";
            // 
            // idFormularioComboBox
            // 
            this.idFormularioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.permisoRolBindingSource, "IdFormulario", true));
            this.idFormularioComboBox.DataSource = this.formularioBindingSource;
            this.idFormularioComboBox.DisplayMember = "DescripcionFormulario";
            this.idFormularioComboBox.Enabled = false;
            this.idFormularioComboBox.FormattingEnabled = true;
            this.idFormularioComboBox.Location = new System.Drawing.Point(206, 74);
            this.idFormularioComboBox.Name = "idFormularioComboBox";
            this.idFormularioComboBox.Size = new System.Drawing.Size(245, 21);
            this.idFormularioComboBox.TabIndex = 3;
            this.idFormularioComboBox.ValueMember = "IdFormulario";
            // 
            // puedeVerCheckBox
            // 
            this.puedeVerCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.permisoRolBindingSource, "PuedeVer", true));
            this.puedeVerCheckBox.Enabled = false;
            this.puedeVerCheckBox.Location = new System.Drawing.Point(206, 101);
            this.puedeVerCheckBox.Name = "puedeVerCheckBox";
            this.puedeVerCheckBox.Size = new System.Drawing.Size(23, 24);
            this.puedeVerCheckBox.TabIndex = 5;
            this.puedeVerCheckBox.UseVisualStyleBackColor = true;
            // 
            // puedeEditarCheckBox
            // 
            this.puedeEditarCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.permisoRolBindingSource, "PuedeEditar", true));
            this.puedeEditarCheckBox.Enabled = false;
            this.puedeEditarCheckBox.Location = new System.Drawing.Point(272, 101);
            this.puedeEditarCheckBox.Name = "puedeEditarCheckBox";
            this.puedeEditarCheckBox.Size = new System.Drawing.Size(23, 24);
            this.puedeEditarCheckBox.TabIndex = 7;
            this.puedeEditarCheckBox.UseVisualStyleBackColor = true;
            // 
            // puedeEliminarCheckBox
            // 
            this.puedeEliminarCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.permisoRolBindingSource, "PuedeEliminar", true));
            this.puedeEliminarCheckBox.Enabled = false;
            this.puedeEliminarCheckBox.Location = new System.Drawing.Point(353, 101);
            this.puedeEliminarCheckBox.Name = "puedeEliminarCheckBox";
            this.puedeEliminarCheckBox.Size = new System.Drawing.Size(23, 24);
            this.puedeEliminarCheckBox.TabIndex = 9;
            this.puedeEliminarCheckBox.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // permisoRolDataGridView
            // 
            this.permisoRolDataGridView.AllowUserToAddRows = false;
            this.permisoRolDataGridView.AllowUserToDeleteRows = false;
            this.permisoRolDataGridView.AllowUserToOrderColumns = true;
            this.permisoRolDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.permisoRolDataGridView.AutoGenerateColumns = false;
            this.permisoRolDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.permisoRolDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.permisoRolDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.permisoRolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permisoRolDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4});
            this.permisoRolDataGridView.DataSource = this.permisoRolBindingSource;
            this.permisoRolDataGridView.Location = new System.Drawing.Point(0, 131);
            this.permisoRolDataGridView.Name = "permisoRolDataGridView";
            this.permisoRolDataGridView.ReadOnly = true;
            this.permisoRolDataGridView.Size = new System.Drawing.Size(644, 430);
            this.permisoRolDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdPermisoRol";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 41;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdRol";
            this.dataGridViewTextBoxColumn2.DataSource = this.rolBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "DescripcionRol";
            this.dataGridViewTextBoxColumn2.HeaderText = "Rol";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "IdRol";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdFormulario";
            this.dataGridViewTextBoxColumn3.DataSource = this.formularioBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "DescripcionFormulario";
            this.dataGridViewTextBoxColumn3.HeaderText = "Formulario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IdFormulario";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "PuedeVer";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Consulta";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 54;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "PuedeEditar";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Edición";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 48;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "PuedeEliminar";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Eliminación";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn3.Width = 66;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "Especifico";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Específico";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            this.dataGridViewCheckBoxColumn4.Width = 64;
            // 
            // especificoCheckBox
            // 
            this.especificoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.permisoRolBindingSource, "Especifico", true));
            this.especificoCheckBox.Enabled = false;
            this.especificoCheckBox.Location = new System.Drawing.Point(437, 101);
            this.especificoCheckBox.Name = "especificoCheckBox";
            this.especificoCheckBox.Size = new System.Drawing.Size(16, 24);
            this.especificoCheckBox.TabIndex = 11;
            this.especificoCheckBox.UseVisualStyleBackColor = true;
            // 
            // frmPermisoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(644, 561);
            this.Controls.Add(especificoLabel);
            this.Controls.Add(this.especificoCheckBox);
            this.Controls.Add(this.permisoRolDataGridView);
            this.Controls.Add(puedeEliminarLabel);
            this.Controls.Add(this.puedeEliminarCheckBox);
            this.Controls.Add(puedeEditarLabel);
            this.Controls.Add(this.puedeEditarCheckBox);
            this.Controls.Add(puedeVerLabel);
            this.Controls.Add(this.puedeVerCheckBox);
            this.Controls.Add(idFormularioLabel);
            this.Controls.Add(this.idFormularioComboBox);
            this.Controls.Add(idRolLabel);
            this.Controls.Add(this.idRolComboBox);
            this.Controls.Add(this.permisoRolBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(670, 1000);
            this.Name = "frmPermisoRol";
            this.Text = "Permisos por Rol";
            this.Load += new System.EventHandler(this.frmPermisoRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisoRolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisoRolBindingNavigator)).EndInit();
            this.permisoRolBindingNavigator.ResumeLayout(false);
            this.permisoRolBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formularioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisoRolDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSCOCOA dSCOCOA;
        private System.Windows.Forms.BindingSource permisoRolBindingSource;
        private DSCOCOATableAdapters.PermisoRolTableAdapter permisoRolTableAdapter;
        private DSCOCOATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator permisoRolBindingNavigator;
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
        private System.Windows.Forms.ComboBox idRolComboBox;
        private System.Windows.Forms.ComboBox idFormularioComboBox;
        private System.Windows.Forms.CheckBox puedeVerCheckBox;
        private System.Windows.Forms.CheckBox puedeEditarCheckBox;
        private System.Windows.Forms.CheckBox puedeEliminarCheckBox;
        private DSCOCOATableAdapters.RolTableAdapter rolTableAdapter;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private DSCOCOATableAdapters.FormularioTableAdapter formularioTableAdapter;
        private System.Windows.Forms.BindingSource formularioBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEdit;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancel;
        private System.Windows.Forms.ToolStripButton bindingNavigatorExit;
        private System.Windows.Forms.DataGridView permisoRolDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.CheckBox especificoCheckBox;
    }
}