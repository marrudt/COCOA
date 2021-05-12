namespace COCOA.Consultas
{
    partial class frmConsultaOrdenesCompraCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaOrdenesCompraCliente));
            this.consultarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nitTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // consultarButton
            // 
            this.consultarButton.BackColor = System.Drawing.Color.SteelBlue;
            this.consultarButton.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.consultarButton.FlatAppearance.BorderSize = 2;
            this.consultarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.consultarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.consultarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.consultarButton.Location = new System.Drawing.Point(62, 80);
            this.consultarButton.Name = "consultarButton";
            this.consultarButton.Size = new System.Drawing.Size(100, 31);
            this.consultarButton.TabIndex = 14;
            this.consultarButton.Text = "Consultar";
            this.consultarButton.UseVisualStyleBackColor = false;
            this.consultarButton.Click += new System.EventHandler(this.consultarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nit Cliente:";
            // 
            // nitTextBox
            // 
            this.nitTextBox.Location = new System.Drawing.Point(87, 31);
            this.nitTextBox.Name = "nitTextBox";
            this.nitTextBox.Size = new System.Drawing.Size(117, 20);
            this.nitTextBox.TabIndex = 16;
            this.nitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nitTextBox_KeyPress);
            // 
            // frmConsultaOrdenesCompraCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(223, 139);
            this.Controls.Add(this.nitTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consultarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaOrdenesCompraCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta OC por Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button consultarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nitTextBox;
    }
}