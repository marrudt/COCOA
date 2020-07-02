namespace COCOA.Maestras
{
    partial class frmNumeroContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNumeroContacto));
            this.dSCOCOA = new COCOA.DSCOCOA();
            this.numeroContactoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroContactoTableAdapter = new COCOA.DSCOCOATableAdapters.NumeroContactoTableAdapter();
            this.tableAdapterManager = new COCOA.DSCOCOATableAdapters.TableAdapterManager();
            this.numeroContactoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.numeroContactoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.numeroContactoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroContactoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroContactoBindingNavigator)).BeginInit();
            this.numeroContactoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroContactoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dSCOCOA
            // 
            this.dSCOCOA.DataSetName = "DSCOCOA";
            this.dSCOCOA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numeroContactoBindingSource
            // 
            this.numeroContactoBindingSource.DataMember = "NumeroContacto";
            this.numeroContactoBindingSource.DataSource = this.dSCOCOA;
            // 
            // numeroContactoTableAdapter
            // 
            this.numeroContactoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ImpoconsumoTableAdapter = null;
            this.tableAdapterManager.IntervaloPreciosTableAdapter = null;
            this.tableAdapterManager.IVATableAdapter = null;
            this.tableAdapterManager.ListadoProveedoresTableAdapter = null;
            this.tableAdapterManager.LogTableAdapter = null;
            this.tableAdapterManager.NumeroContactoTableAdapter = this.numeroContactoTableAdapter;
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
            // numeroContactoBindingNavigator
            // 
            this.numeroContactoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.numeroContactoBindingNavigator.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.numeroContactoBindingNavigator.BindingSource = this.numeroContactoBindingSource;
            this.numeroContactoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.numeroContactoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.numeroContactoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.numeroContactoBindingNavigatorSaveItem});
            this.numeroContactoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.numeroContactoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.numeroContactoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.numeroContactoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.numeroContactoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.numeroContactoBindingNavigator.Name = "numeroContactoBindingNavigator";
            this.numeroContactoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.numeroContactoBindingNavigator.Size = new System.Drawing.Size(334, 25);
            this.numeroContactoBindingNavigator.TabIndex = 0;
            this.numeroContactoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // numeroContactoBindingNavigatorSaveItem
            // 
            this.numeroContactoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.numeroContactoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("numeroContactoBindingNavigatorSaveItem.Image")));
            this.numeroContactoBindingNavigatorSaveItem.Name = "numeroContactoBindingNavigatorSaveItem";
            this.numeroContactoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.numeroContactoBindingNavigatorSaveItem.Text = "Save Data";
            this.numeroContactoBindingNavigatorSaveItem.Click += new System.EventHandler(this.numeroContactoBindingNavigatorSaveItem_Click);
            // 
            // numeroContactoDataGridView
            // 
            this.numeroContactoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroContactoDataGridView.AutoGenerateColumns = false;
            this.numeroContactoDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.numeroContactoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numeroContactoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.numeroContactoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.numeroContactoDataGridView.DataSource = this.numeroContactoBindingSource;
            this.numeroContactoDataGridView.Location = new System.Drawing.Point(0, 28);
            this.numeroContactoDataGridView.Name = "numeroContactoDataGridView";
            this.numeroContactoDataGridView.Size = new System.Drawing.Size(334, 235);
            this.numeroContactoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdNumeroContacto";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdNumeroContacto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NumeroContacto";
            this.dataGridViewTextBoxColumn2.HeaderText = "NumeroContacto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // frmNumeroContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 264);
            this.Controls.Add(this.numeroContactoDataGridView);
            this.Controls.Add(this.numeroContactoBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNumeroContacto";
            this.Text = "Número de Contacto";
            this.Load += new System.EventHandler(this.frmNumeroContacto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroContactoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroContactoBindingNavigator)).EndInit();
            this.numeroContactoBindingNavigator.ResumeLayout(false);
            this.numeroContactoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroContactoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSCOCOA dSCOCOA;
        private System.Windows.Forms.BindingSource numeroContactoBindingSource;
        private DSCOCOATableAdapters.NumeroContactoTableAdapter numeroContactoTableAdapter;
        private DSCOCOATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator numeroContactoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton numeroContactoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView numeroContactoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}