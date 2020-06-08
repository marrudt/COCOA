namespace COCOA
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.usuarioComboBox = new System.Windows.Forms.ComboBox();
            this.dSCOCOA = new COCOA.DSCOCOA();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new COCOA.DSCOCOATableAdapters.UsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.Cancelarbutton.Location = new System.Drawing.Point(190, 193);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(86, 35);
            this.Cancelarbutton.TabIndex = 13;
            this.Cancelarbutton.Text = "Salir";
            this.Cancelarbutton.UseVisualStyleBackColor = false;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // AceptarButton
            // 
            this.AceptarButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AceptarButton.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.AceptarButton.FlatAppearance.BorderSize = 2;
            this.AceptarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.AceptarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.AceptarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AceptarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceptarButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AceptarButton.Location = new System.Drawing.Point(98, 193);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(86, 35);
            this.AceptarButton.TabIndex = 12;
            this.AceptarButton.Text = "Entrar";
            this.AceptarButton.UseVisualStyleBackColor = false;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(132, 152);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "&Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "&Usuario";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // usuarioComboBox
            // 
            this.usuarioComboBox.DataSource = this.usuariosBindingSource;
            this.usuarioComboBox.DisplayMember = "IdUsuario";
            this.usuarioComboBox.FormattingEnabled = true;
            this.usuarioComboBox.Location = new System.Drawing.Point(132, 108);
            this.usuarioComboBox.Name = "usuarioComboBox";
            this.usuarioComboBox.Size = new System.Drawing.Size(100, 21);
            this.usuarioComboBox.TabIndex = 14;
            this.usuarioComboBox.ValueMember = "IdUsuario";
            // 
            // dSCOCOA
            // 
            this.dSCOCOA.DataSetName = "DSCOCOA";
            this.dSCOCOA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.dSCOCOA;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.AceptarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.Cancelarbutton;
            this.ClientSize = new System.Drawing.Size(365, 269);
            this.Controls.Add(this.usuarioComboBox);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login COCOA";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCOCOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox usuarioComboBox;
        private DSCOCOA dSCOCOA;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DSCOCOATableAdapters.UsuariosTableAdapter usuariosTableAdapter;
    }
}

