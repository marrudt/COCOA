namespace COCOA.Maestras
{
    partial class frmContactoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContactoCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.CargoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telefono1textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telefono2TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ext1TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ext2TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.activocheckBox = new System.Windows.Forms.CheckBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.numeroContactoComboBox = new System.Windows.Forms.ComboBox();
            this.numeroContactoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCOCOA = new COCOA.DSCOCOA();
            this.contactosClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contactosClienteTableAdapter = new COCOA.DSCOCOATableAdapters.ContactosClienteTableAdapter();
            this.tableAdapterManager = new COCOA.DSCOCOATableAdapters.TableAdapterManager();
            this.numeroContactoTableAdapter = new COCOA.DSCOCOATableAdapters.NumeroContactoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numeroContactoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.Location = new System.Drawing.Point(71, 41);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(316, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // CargoTextBox
            // 
            this.CargoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CargoTextBox.Location = new System.Drawing.Point(71, 67);
            this.CargoTextBox.Name = "CargoTextBox";
            this.CargoTextBox.Size = new System.Drawing.Size(316, 20);
            this.CargoTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cargo:";
            // 
            // correoTextBox
            // 
            this.correoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.correoTextBox.Location = new System.Drawing.Point(71, 93);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(316, 20);
            this.correoTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo:";
            // 
            // telefono1textBox
            // 
            this.telefono1textBox.Location = new System.Drawing.Point(471, 41);
            this.telefono1textBox.Name = "telefono1textBox";
            this.telefono1textBox.Size = new System.Drawing.Size(113, 20);
            this.telefono1textBox.TabIndex = 7;
            this.telefono1textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefono1textBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teléfono 1:";
            // 
            // telefono2TextBox
            // 
            this.telefono2TextBox.Location = new System.Drawing.Point(471, 67);
            this.telefono2TextBox.Name = "telefono2TextBox";
            this.telefono2TextBox.Size = new System.Drawing.Size(113, 20);
            this.telefono2TextBox.TabIndex = 11;
            this.telefono2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefono2TextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Teléfono 2:";
            // 
            // ext1TextBox
            // 
            this.ext1TextBox.Location = new System.Drawing.Point(638, 41);
            this.ext1TextBox.Name = "ext1TextBox";
            this.ext1TextBox.Size = new System.Drawing.Size(35, 20);
            this.ext1TextBox.TabIndex = 9;
            this.ext1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ext1TextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(604, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ext.:";
            // 
            // ext2TextBox
            // 
            this.ext2TextBox.Location = new System.Drawing.Point(638, 67);
            this.ext2TextBox.Name = "ext2TextBox";
            this.ext2TextBox.Size = new System.Drawing.Size(35, 20);
            this.ext2TextBox.TabIndex = 13;
            this.ext2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ext2TextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(604, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ext.:";
            // 
            // celularTextBox
            // 
            this.celularTextBox.Location = new System.Drawing.Point(471, 93);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(113, 20);
            this.celularTextBox.TabIndex = 15;
            this.celularTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.celularTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(426, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Celular:";
            // 
            // activocheckBox
            // 
            this.activocheckBox.AutoSize = true;
            this.activocheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.activocheckBox.Checked = true;
            this.activocheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activocheckBox.Location = new System.Drawing.Point(614, 95);
            this.activocheckBox.Name = "activocheckBox";
            this.activocheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.activocheckBox.Size = new System.Drawing.Size(59, 17);
            this.activocheckBox.TabIndex = 16;
            this.activocheckBox.Text = "Activo:";
            this.activocheckBox.UseVisualStyleBackColor = true;
            // 
            // notasTextBox
            // 
            this.notasTextBox.Location = new System.Drawing.Point(71, 119);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notasTextBox.Size = new System.Drawing.Size(603, 55);
            this.notasTextBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Notas:";
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.BackColor = System.Drawing.Color.IndianRed;
            this.cancelarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarbutton.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.cancelarbutton.FlatAppearance.BorderSize = 2;
            this.cancelarbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.cancelarbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.cancelarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelarbutton.Location = new System.Drawing.Point(347, 184);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(86, 35);
            this.cancelarbutton.TabIndex = 20;
            this.cancelarbutton.Text = "Cancelar";
            this.cancelarbutton.UseVisualStyleBackColor = false;
            // 
            // aceptarButton
            // 
            this.aceptarButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.aceptarButton.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.aceptarButton.FlatAppearance.BorderSize = 2;
            this.aceptarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.aceptarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.aceptarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aceptarButton.Location = new System.Drawing.Point(255, 184);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(86, 35);
            this.aceptarButton.TabIndex = 19;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = false;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 21;
            // 
            // numeroContactoComboBox
            // 
            this.numeroContactoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.numeroContactoBindingSource, "IdNumeroContacto", true));
            this.numeroContactoComboBox.DataSource = this.numeroContactoBindingSource;
            this.numeroContactoComboBox.DisplayMember = "NumeroContacto";
            this.numeroContactoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numeroContactoComboBox.FormattingEnabled = true;
            this.numeroContactoComboBox.Location = new System.Drawing.Point(71, 14);
            this.numeroContactoComboBox.Name = "numeroContactoComboBox";
            this.numeroContactoComboBox.Size = new System.Drawing.Size(166, 21);
            this.numeroContactoComboBox.TabIndex = 22;
            this.numeroContactoComboBox.ValueMember = "IdNumeroContacto";
            this.numeroContactoComboBox.SelectedIndexChanged += new System.EventHandler(this.idContactoComboBox_SelectedIndexChanged);
            // 
            // numeroContactoBindingSource
            // 
            this.numeroContactoBindingSource.DataMember = "NumeroContacto";
            this.numeroContactoBindingSource.DataSource = this.dSCOCOA;
            // 
            // dSCOCOA
            // 
            this.dSCOCOA.DataSetName = "DSCOCOA";
            this.dSCOCOA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactosClienteBindingSource
            // 
            this.contactosClienteBindingSource.DataMember = "ContactosCliente";
            this.contactosClienteBindingSource.DataSource = this.dSCOCOA;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // contactosClienteTableAdapter
            // 
            this.contactosClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CilindrajesTableAdapter = null;
            this.tableAdapterManager.CiudadesTableAdapter = null;
            this.tableAdapterManager.ClaseTableAdapter = null;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ContactosClienteTableAdapter = this.contactosClienteTableAdapter;
            this.tableAdapterManager.CotizacionDetalleTableAdapter = null;
            this.tableAdapterManager.CotizacionTableAdapter = null;
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
            // numeroContactoTableAdapter
            // 
            this.numeroContactoTableAdapter.ClearBeforeFill = true;
            // 
            // frmContactoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(686, 227);
            this.Controls.Add(this.numeroContactoComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cancelarbutton);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.notasTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.activocheckBox);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ext2TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ext1TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telefono2TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telefono1textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CargoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmContactoCliente";
            this.Text = "Contactos Cliente";
            this.Load += new System.EventHandler(this.frmContactoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeroContactoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox CargoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telefono1textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telefono2TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ext1TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ext2TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox activocheckBox;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cancelarbutton;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox numeroContactoComboBox;
        private DSCOCOA dSCOCOA;
        private System.Windows.Forms.BindingSource contactosClienteBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DSCOCOATableAdapters.ContactosClienteTableAdapter contactosClienteTableAdapter;
        private DSCOCOATableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource numeroContactoBindingSource;
        private DSCOCOATableAdapters.NumeroContactoTableAdapter numeroContactoTableAdapter;
    }
}