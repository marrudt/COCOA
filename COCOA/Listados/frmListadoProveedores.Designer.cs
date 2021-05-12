namespace COCOA.Listados
{
    partial class frmListadoProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoProveedores));
            this.nitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nitTextBox
            // 
            this.nitTextBox.Location = new System.Drawing.Point(96, 33);
            this.nitTextBox.Name = "nitTextBox";
            this.nitTextBox.Size = new System.Drawing.Size(117, 20);
            this.nitTextBox.TabIndex = 22;
            this.nitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nitTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nit Cliente:";
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
            this.generarButton.Location = new System.Drawing.Point(75, 77);
            this.generarButton.Name = "generarButton";
            this.generarButton.Size = new System.Drawing.Size(100, 48);
            this.generarButton.TabIndex = 20;
            this.generarButton.Text = "Generar Listado";
            this.generarButton.UseVisualStyleBackColor = false;
            this.generarButton.Click += new System.EventHandler(this.generarButton_Click);
            // 
            // frmListadoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(246, 158);
            this.Controls.Add(this.nitTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Proveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nitTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generarButton;
    }
}