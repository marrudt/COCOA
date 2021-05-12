namespace COCOA.Listados
{
    partial class frmListadoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoProductos));
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generarButton = new System.Windows.Forms.Button();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.codigoTextBox.Location = new System.Drawing.Point(94, 28);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(95, 20);
            this.codigoTextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Código:";
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
            this.generarButton.Location = new System.Drawing.Point(84, 106);
            this.generarButton.Name = "generarButton";
            this.generarButton.Size = new System.Drawing.Size(100, 48);
            this.generarButton.TabIndex = 20;
            this.generarButton.Text = "Generar Listado";
            this.generarButton.UseVisualStyleBackColor = false;
            this.generarButton.Click += new System.EventHandler(this.generarButton_Click);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descripcionTextBox.Location = new System.Drawing.Point(94, 67);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(152, 20);
            this.descripcionTextBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Descripción:";
            // 
            // frmListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(267, 173);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generarButton;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Label label2;
    }
}