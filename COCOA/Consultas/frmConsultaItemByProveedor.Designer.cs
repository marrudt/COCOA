namespace COCOA.Consultas
{
    partial class frmConsultaItemByProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaItemByProveedor));
            this.generarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.proveedorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // generarButton
            // 
            this.generarButton.BackColor = System.Drawing.Color.SteelBlue;
            this.generarButton.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.generarButton.FlatAppearance.BorderSize = 2;
            this.generarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.generarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.generarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generarButton.Location = new System.Drawing.Point(100, 150);
            this.generarButton.Name = "generarButton";
            this.generarButton.Size = new System.Drawing.Size(100, 31);
            this.generarButton.TabIndex = 13;
            this.generarButton.Text = "Consultar";
            this.generarButton.UseVisualStyleBackColor = false;
            this.generarButton.Click += new System.EventHandler(this.generarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código Ítem:";
            // 
            // proveedorTextBox
            // 
            this.proveedorTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.proveedorTextBox.Location = new System.Drawing.Point(76, 68);
            this.proveedorTextBox.Name = "proveedorTextBox";
            this.proveedorTextBox.Size = new System.Drawing.Size(205, 20);
            this.proveedorTextBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Proveedor:";
            // 
            // productoTextBox
            // 
            this.productoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.productoTextBox.Location = new System.Drawing.Point(76, 106);
            this.productoTextBox.Name = "productoTextBox";
            this.productoTextBox.Size = new System.Drawing.Size(205, 20);
            this.productoTextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Producto:";
            // 
            // itemTextBox
            // 
            this.itemTextBox.Location = new System.Drawing.Point(76, 29);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(47, 20);
            this.itemTextBox.TabIndex = 15;
            this.itemTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.itemTextBox_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // frmConsultaItemByProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(292, 204);
            this.Controls.Add(this.productoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.proveedorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaItemByProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Item por Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox proveedorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}