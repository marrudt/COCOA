namespace COCOA.Busqueda
{
    partial class frmBusquedaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaCliente));
            this.busquedaDataGridView = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCOCOA = new COCOA.DSCOCOA();
            this.clientesTableAdapter = new COCOA.DSCOCOATableAdapters.ClientesTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.nitToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nitToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nombreClienteToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombreClienteToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.nombreContactoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombreContactoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.emailToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.emailToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.borrarFiltrosbutton = new System.Windows.Forms.Button();
            this.igualRadioButton = new System.Windows.Forms.RadioButton();
            this.terminaRadioButton = new System.Windows.Forms.RadioButton();
            this.empiezaRadioButton = new System.Windows.Forms.RadioButton();
            this.contengaRadioButton = new System.Windows.Forms.RadioButton();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.volverButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.busquedaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // busquedaDataGridView
            // 
            this.busquedaDataGridView.AllowUserToAddRows = false;
            this.busquedaDataGridView.AllowUserToDeleteRows = false;
            this.busquedaDataGridView.AllowUserToOrderColumns = true;
            this.busquedaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.busquedaDataGridView.AutoGenerateColumns = false;
            this.busquedaDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.busquedaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busquedaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.nitDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.nombreContactoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefono1DataGridViewTextBoxColumn,
            this.telefono2DataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.notasDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn});
            this.busquedaDataGridView.DataSource = this.clientesBindingSource;
            this.busquedaDataGridView.Location = new System.Drawing.Point(1, 84);
            this.busquedaDataGridView.Name = "busquedaDataGridView";
            this.busquedaDataGridView.ReadOnly = true;
            this.busquedaDataGridView.Size = new System.Drawing.Size(997, 364);
            this.busquedaDataGridView.TabIndex = 0;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // nitDataGridViewTextBoxColumn
            // 
            this.nitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nitDataGridViewTextBoxColumn.DataPropertyName = "Nit";
            this.nitDataGridViewTextBoxColumn.HeaderText = "Nit";
            this.nitDataGridViewTextBoxColumn.Name = "nitDataGridViewTextBoxColumn";
            this.nitDataGridViewTextBoxColumn.ReadOnly = true;
            this.nitDataGridViewTextBoxColumn.Width = 45;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "Nombre Cliente";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreClienteDataGridViewTextBoxColumn.Width = 96;
            // 
            // nombreContactoDataGridViewTextBoxColumn
            // 
            this.nombreContactoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreContactoDataGridViewTextBoxColumn.DataPropertyName = "NombreContacto";
            this.nombreContactoDataGridViewTextBoxColumn.HeaderText = "Nombre Contacto";
            this.nombreContactoDataGridViewTextBoxColumn.Name = "nombreContactoDataGridViewTextBoxColumn";
            this.nombreContactoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreContactoDataGridViewTextBoxColumn.Width = 105;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefono1DataGridViewTextBoxColumn
            // 
            this.telefono1DataGridViewTextBoxColumn.DataPropertyName = "Telefono1";
            this.telefono1DataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefono1DataGridViewTextBoxColumn.Name = "telefono1DataGridViewTextBoxColumn";
            this.telefono1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefono2DataGridViewTextBoxColumn
            // 
            this.telefono2DataGridViewTextBoxColumn.DataPropertyName = "Telefono2";
            this.telefono2DataGridViewTextBoxColumn.HeaderText = "Telefono2";
            this.telefono2DataGridViewTextBoxColumn.Name = "telefono2DataGridViewTextBoxColumn";
            this.telefono2DataGridViewTextBoxColumn.ReadOnly = true;
            this.telefono2DataGridViewTextBoxColumn.Visible = false;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            this.celularDataGridViewTextBoxColumn.Width = 64;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 57;
            // 
            // notasDataGridViewTextBoxColumn
            // 
            this.notasDataGridViewTextBoxColumn.DataPropertyName = "Notas";
            this.notasDataGridViewTextBoxColumn.HeaderText = "Notas";
            this.notasDataGridViewTextBoxColumn.Name = "notasDataGridViewTextBoxColumn";
            this.notasDataGridViewTextBoxColumn.ReadOnly = true;
            this.notasDataGridViewTextBoxColumn.Visible = false;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activoDataGridViewCheckBoxColumn.Visible = false;
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
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nitToolStripLabel,
            this.nitToolStripTextBox,
            this.nombreClienteToolStripLabel,
            this.nombreClienteToolStripTextBox,
            this.nombreContactoToolStripLabel,
            this.nombreContactoToolStripTextBox,
            this.emailToolStripLabel,
            this.emailToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(999, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // nitToolStripLabel
            // 
            this.nitToolStripLabel.Name = "nitToolStripLabel";
            this.nitToolStripLabel.Size = new System.Drawing.Size(26, 22);
            this.nitToolStripLabel.Text = "Nit:";
            // 
            // nitToolStripTextBox
            // 
            this.nitToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nitToolStripTextBox.Name = "nitToolStripTextBox";
            this.nitToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // nombreClienteToolStripLabel
            // 
            this.nombreClienteToolStripLabel.Name = "nombreClienteToolStripLabel";
            this.nombreClienteToolStripLabel.Size = new System.Drawing.Size(47, 22);
            this.nombreClienteToolStripLabel.Text = "Cliente:";
            // 
            // nombreClienteToolStripTextBox
            // 
            this.nombreClienteToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nombreClienteToolStripTextBox.Name = "nombreClienteToolStripTextBox";
            this.nombreClienteToolStripTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // nombreContactoToolStripLabel
            // 
            this.nombreContactoToolStripLabel.Name = "nombreContactoToolStripLabel";
            this.nombreContactoToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.nombreContactoToolStripLabel.Text = "Contacto:";
            // 
            // nombreContactoToolStripTextBox
            // 
            this.nombreContactoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nombreContactoToolStripTextBox.Name = "nombreContactoToolStripTextBox";
            this.nombreContactoToolStripTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // emailToolStripLabel
            // 
            this.emailToolStripLabel.Name = "emailToolStripLabel";
            this.emailToolStripLabel.Size = new System.Drawing.Size(39, 22);
            this.emailToolStripLabel.Text = "Email:";
            // 
            // emailToolStripTextBox
            // 
            this.emailToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailToolStripTextBox.Name = "emailToolStripTextBox";
            this.emailToolStripTextBox.Size = new System.Drawing.Size(150, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.fillByToolStripButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 22);
            this.fillByToolStripButton.Text = "Buscar";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.borrarFiltrosbutton);
            this.groupBox1.Controls.Add(this.igualRadioButton);
            this.groupBox1.Controls.Add(this.terminaRadioButton);
            this.groupBox1.Controls.Add(this.empiezaRadioButton);
            this.groupBox1.Controls.Add(this.contengaRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 49);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios de Búsqueda";
            // 
            // borrarFiltrosbutton
            // 
            this.borrarFiltrosbutton.BackColor = System.Drawing.Color.IndianRed;
            this.borrarFiltrosbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarFiltrosbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borrarFiltrosbutton.Location = new System.Drawing.Point(331, 11);
            this.borrarFiltrosbutton.Name = "borrarFiltrosbutton";
            this.borrarFiltrosbutton.Size = new System.Drawing.Size(89, 32);
            this.borrarFiltrosbutton.TabIndex = 4;
            this.borrarFiltrosbutton.Text = "Borrar Filtros";
            this.borrarFiltrosbutton.UseVisualStyleBackColor = false;
            this.borrarFiltrosbutton.Click += new System.EventHandler(this.borrarFiltrosbutton_Click);
            // 
            // igualRadioButton
            // 
            this.igualRadioButton.AutoSize = true;
            this.igualRadioButton.Location = new System.Drawing.Point(260, 19);
            this.igualRadioButton.Name = "igualRadioButton";
            this.igualRadioButton.Size = new System.Drawing.Size(48, 17);
            this.igualRadioButton.TabIndex = 3;
            this.igualRadioButton.Text = "Igual";
            this.igualRadioButton.UseVisualStyleBackColor = true;
            // 
            // terminaRadioButton
            // 
            this.terminaRadioButton.AutoSize = true;
            this.terminaRadioButton.Location = new System.Drawing.Point(176, 20);
            this.terminaRadioButton.Name = "terminaRadioButton";
            this.terminaRadioButton.Size = new System.Drawing.Size(78, 17);
            this.terminaRadioButton.TabIndex = 2;
            this.terminaRadioButton.Text = "Termina en";
            this.terminaRadioButton.UseVisualStyleBackColor = true;
            // 
            // empiezaRadioButton
            // 
            this.empiezaRadioButton.AutoSize = true;
            this.empiezaRadioButton.Location = new System.Drawing.Point(84, 20);
            this.empiezaRadioButton.Name = "empiezaRadioButton";
            this.empiezaRadioButton.Size = new System.Drawing.Size(86, 17);
            this.empiezaRadioButton.TabIndex = 1;
            this.empiezaRadioButton.Text = "Empieza con";
            this.empiezaRadioButton.UseVisualStyleBackColor = true;
            // 
            // contengaRadioButton
            // 
            this.contengaRadioButton.AutoSize = true;
            this.contengaRadioButton.Checked = true;
            this.contengaRadioButton.Location = new System.Drawing.Point(7, 20);
            this.contengaRadioButton.Name = "contengaRadioButton";
            this.contengaRadioButton.Size = new System.Drawing.Size(71, 17);
            this.contengaRadioButton.TabIndex = 0;
            this.contengaRadioButton.TabStop = true;
            this.contengaRadioButton.Text = "Contenga";
            this.contengaRadioButton.UseVisualStyleBackColor = true;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.BackColor = System.Drawing.Color.IndianRed;
            this.Cancelarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelarbutton.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.Cancelarbutton.FlatAppearance.BorderSize = 2;
            this.Cancelarbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Cancelarbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Cancelarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelarbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancelarbutton.Location = new System.Drawing.Point(551, 39);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(86, 35);
            this.Cancelarbutton.TabIndex = 17;
            this.Cancelarbutton.Text = "Salir";
            this.Cancelarbutton.UseVisualStyleBackColor = false;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // volverButton
            // 
            this.volverButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.volverButton.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.volverButton.FlatAppearance.BorderSize = 2;
            this.volverButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.volverButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.volverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.volverButton.Location = new System.Drawing.Point(459, 39);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(86, 35);
            this.volverButton.TabIndex = 16;
            this.volverButton.Text = "Volver";
            this.volverButton.UseVisualStyleBackColor = false;
            this.volverButton.Click += new System.EventHandler(this.volverButton_Click);
            // 
            // frmBusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(999, 448);
            this.ControlBox = false;
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.volverButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.busquedaDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBusquedaCliente";
            this.Text = "Búsqueda Cliente";
            this.Load += new System.EventHandler(this.frmBusquedaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.busquedaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView busquedaDataGridView;
        private DSCOCOA dSCOCOA;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DSCOCOATableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel nitToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nitToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel nombreClienteToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombreClienteToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel nombreContactoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombreContactoToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel emailToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox emailToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button borrarFiltrosbutton;
        private System.Windows.Forms.RadioButton igualRadioButton;
        private System.Windows.Forms.RadioButton terminaRadioButton;
        private System.Windows.Forms.RadioButton empiezaRadioButton;
        private System.Windows.Forms.RadioButton contengaRadioButton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button volverButton;
    }
}