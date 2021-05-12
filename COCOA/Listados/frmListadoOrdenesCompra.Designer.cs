namespace COCOA.Listados
{
    partial class frmListadoOrdenesCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoOrdenesCompra));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.generarListadoButton = new System.Windows.Forms.Button();
            this.fechaFinalTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaInicialTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nitEntidadTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nitProveedorTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fecha Final:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Fecha Inicial:";
            // 
            // generarListadoButton
            // 
            this.generarListadoButton.BackColor = System.Drawing.Color.SteelBlue;
            this.generarListadoButton.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.generarListadoButton.FlatAppearance.BorderSize = 2;
            this.generarListadoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.generarListadoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.generarListadoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generarListadoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarListadoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generarListadoButton.Location = new System.Drawing.Point(72, 183);
            this.generarListadoButton.Name = "generarListadoButton";
            this.generarListadoButton.Size = new System.Drawing.Size(120, 49);
            this.generarListadoButton.TabIndex = 25;
            this.generarListadoButton.Text = "Generar Listado";
            this.generarListadoButton.UseVisualStyleBackColor = false;
            this.generarListadoButton.Click += new System.EventHandler(this.generarListadoButton_Click);
            // 
            // fechaFinalTimePicker
            // 
            this.fechaFinalTimePicker.CustomFormat = "dd/MMM/yyyy";
            this.fechaFinalTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaFinalTimePicker.Location = new System.Drawing.Point(110, 60);
            this.fechaFinalTimePicker.Name = "fechaFinalTimePicker";
            this.fechaFinalTimePicker.Size = new System.Drawing.Size(103, 20);
            this.fechaFinalTimePicker.TabIndex = 24;
            // 
            // fechaInicialTimePicker
            // 
            this.fechaInicialTimePicker.CustomFormat = "dd/MMM/yyyy";
            this.fechaInicialTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaInicialTimePicker.Location = new System.Drawing.Point(110, 25);
            this.fechaInicialTimePicker.Name = "fechaInicialTimePicker";
            this.fechaInicialTimePicker.Size = new System.Drawing.Size(103, 20);
            this.fechaInicialTimePicker.TabIndex = 23;
            // 
            // nitEntidadTextBox
            // 
            this.nitEntidadTextBox.Location = new System.Drawing.Point(110, 100);
            this.nitEntidadTextBox.Name = "nitEntidadTextBox";
            this.nitEntidadTextBox.Size = new System.Drawing.Size(103, 20);
            this.nitEntidadTextBox.TabIndex = 28;
            this.nitEntidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nitEntidadTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nit Entidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nit Proveedor:";
            // 
            // nitProveedorTextBox
            // 
            this.nitProveedorTextBox.Location = new System.Drawing.Point(110, 139);
            this.nitProveedorTextBox.Name = "nitProveedorTextBox";
            this.nitProveedorTextBox.Size = new System.Drawing.Size(103, 20);
            this.nitProveedorTextBox.TabIndex = 30;
            this.nitProveedorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nitProveedorTextBox_KeyPress);
            // 
            // frmListadoOrdenesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(256, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nitProveedorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nitEntidadTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generarListadoButton);
            this.Controls.Add(this.fechaFinalTimePicker);
            this.Controls.Add(this.fechaInicialTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoOrdenesCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Ordenes de Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generarListadoButton;
        private System.Windows.Forms.DateTimePicker fechaFinalTimePicker;
        private System.Windows.Forms.DateTimePicker fechaInicialTimePicker;
        private System.Windows.Forms.TextBox nitEntidadTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nitProveedorTextBox;
    }
}