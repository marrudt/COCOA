namespace COCOA.Listados
{
    partial class frmListadoResumenCotizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoResumenCotizaciones));
            this.fechaInicialTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaFinalTimePicker = new System.Windows.Forms.DateTimePicker();
            this.generarListadoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fechaInicialTimePicker
            // 
            this.fechaInicialTimePicker.CustomFormat = "dd/MMM/yyyy";
            this.fechaInicialTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaInicialTimePicker.Location = new System.Drawing.Point(117, 35);
            this.fechaInicialTimePicker.Name = "fechaInicialTimePicker";
            this.fechaInicialTimePicker.Size = new System.Drawing.Size(103, 20);
            this.fechaInicialTimePicker.TabIndex = 0;
            // 
            // fechaFinalTimePicker
            // 
            this.fechaFinalTimePicker.CustomFormat = "dd/MMM/yyyy";
            this.fechaFinalTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaFinalTimePicker.Location = new System.Drawing.Point(117, 70);
            this.fechaFinalTimePicker.Name = "fechaFinalTimePicker";
            this.fechaFinalTimePicker.Size = new System.Drawing.Size(103, 20);
            this.fechaFinalTimePicker.TabIndex = 1;
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
            this.generarListadoButton.Location = new System.Drawing.Point(75, 117);
            this.generarListadoButton.Name = "generarListadoButton";
            this.generarListadoButton.Size = new System.Drawing.Size(120, 49);
            this.generarListadoButton.TabIndex = 20;
            this.generarListadoButton.Text = "Generar Listado";
            this.generarListadoButton.UseVisualStyleBackColor = false;
            this.generarListadoButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Fecha Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fecha Final:";
            // 
            // frmListadoResumenCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(265, 199);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generarListadoButton);
            this.Controls.Add(this.fechaFinalTimePicker);
            this.Controls.Add(this.fechaInicialTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoResumenCotizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Cotizaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaInicialTimePicker;
        private System.Windows.Forms.DateTimePicker fechaFinalTimePicker;
        private System.Windows.Forms.Button generarListadoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}