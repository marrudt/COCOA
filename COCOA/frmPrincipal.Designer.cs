namespace COCOA
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cilindrajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervaloDePreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.númeroDePasajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesoBrutoVehicularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segmentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cambioDeClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeCompraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeCompraToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.transaccionesToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cilindrajeToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.impoToolStripMenuItem,
            this.intervaloDePreciosToolStripMenuItem,
            this.ivaToolStripMenuItem,
            this.númeroDePasajerosToolStripMenuItem,
            this.pesoBrutoVehicularToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.segmentoToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cambioDeClaveToolStripMenuItem,
            this.cambioDeUsuarioToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizacionesToolStripMenuItem,
            this.ordenesDeCompraToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.transaccionesToolStripMenuItem.Text = "&Transacciones";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizacionesToolStripMenuItem1,
            this.ordenesDeCompraToolStripMenuItem1});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "&Consultas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizacionesToolStripMenuItem2,
            this.ordenesDeCompraToolStripMenuItem2});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "&Reportes";
            // 
            // cilindrajeToolStripMenuItem
            // 
            this.cilindrajeToolStripMenuItem.Name = "cilindrajeToolStripMenuItem";
            this.cilindrajeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.cilindrajeToolStripMenuItem.Text = "Cilin&draje";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.clientesToolStripMenuItem.Text = "&Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // impoToolStripMenuItem
            // 
            this.impoToolStripMenuItem.Name = "impoToolStripMenuItem";
            this.impoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.impoToolStripMenuItem.Text = "I&mpoconsumo";
            // 
            // intervaloDePreciosToolStripMenuItem
            // 
            this.intervaloDePreciosToolStripMenuItem.Name = "intervaloDePreciosToolStripMenuItem";
            this.intervaloDePreciosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.intervaloDePreciosToolStripMenuItem.Text = "In&tervalo de Precios";
            // 
            // ivaToolStripMenuItem
            // 
            this.ivaToolStripMenuItem.Name = "ivaToolStripMenuItem";
            this.ivaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ivaToolStripMenuItem.Text = "I&VA";
            // 
            // númeroDePasajerosToolStripMenuItem
            // 
            this.númeroDePasajerosToolStripMenuItem.Name = "númeroDePasajerosToolStripMenuItem";
            this.númeroDePasajerosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.númeroDePasajerosToolStripMenuItem.Text = "&Número de Pasajeros";
            // 
            // pesoBrutoVehicularToolStripMenuItem
            // 
            this.pesoBrutoVehicularToolStripMenuItem.Name = "pesoBrutoVehicularToolStripMenuItem";
            this.pesoBrutoVehicularToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.pesoBrutoVehicularToolStripMenuItem.Text = "Peso Bruto Ve&hicular";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.productosToolStripMenuItem.Text = "&Productos";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.proveedoresToolStripMenuItem.Text = "P&roveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // segmentoToolStripMenuItem
            // 
            this.segmentoToolStripMenuItem.Name = "segmentoToolStripMenuItem";
            this.segmentoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.segmentoToolStripMenuItem.Text = "&Segmento";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolToolStripMenuItem,
            this.permisosRolToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.usuariosToolStripMenuItem.Text = "&Usuarios";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(183, 6);
            // 
            // cambioDeClaveToolStripMenuItem
            // 
            this.cambioDeClaveToolStripMenuItem.Name = "cambioDeClaveToolStripMenuItem";
            this.cambioDeClaveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.cambioDeClaveToolStripMenuItem.Text = "Cam&bio de Clave";
            // 
            // cambioDeUsuarioToolStripMenuItem
            // 
            this.cambioDeUsuarioToolStripMenuItem.Name = "cambioDeUsuarioToolStripMenuItem";
            this.cambioDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.cambioDeUsuarioToolStripMenuItem.Text = "C&ambio de Usuario";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.salirToolStripMenuItem.Text = "Sa&lir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cotizacionesToolStripMenuItem
            // 
            this.cotizacionesToolStripMenuItem.Name = "cotizacionesToolStripMenuItem";
            this.cotizacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cotizacionesToolStripMenuItem.Text = "&Cotizaciones";
            // 
            // ordenesDeCompraToolStripMenuItem
            // 
            this.ordenesDeCompraToolStripMenuItem.Name = "ordenesDeCompraToolStripMenuItem";
            this.ordenesDeCompraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordenesDeCompraToolStripMenuItem.Text = "&Ordenes de Compra";
            // 
            // cotizacionesToolStripMenuItem1
            // 
            this.cotizacionesToolStripMenuItem1.Name = "cotizacionesToolStripMenuItem1";
            this.cotizacionesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cotizacionesToolStripMenuItem1.Text = "&Cotizaciones";
            // 
            // ordenesDeCompraToolStripMenuItem1
            // 
            this.ordenesDeCompraToolStripMenuItem1.Name = "ordenesDeCompraToolStripMenuItem1";
            this.ordenesDeCompraToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ordenesDeCompraToolStripMenuItem1.Text = "&Ordenes de Compra";
            // 
            // cotizacionesToolStripMenuItem2
            // 
            this.cotizacionesToolStripMenuItem2.Name = "cotizacionesToolStripMenuItem2";
            this.cotizacionesToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.cotizacionesToolStripMenuItem2.Text = "&Cotizaciones";
            // 
            // ordenesDeCompraToolStripMenuItem2
            // 
            this.ordenesDeCompraToolStripMenuItem2.Name = "ordenesDeCompraToolStripMenuItem2";
            this.ordenesDeCompraToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.ordenesDeCompraToolStripMenuItem2.Text = "&Ordenes de Compra";
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rolToolStripMenuItem.Text = "&Rol";
            // 
            // permisosRolToolStripMenuItem
            // 
            this.permisosRolToolStripMenuItem.Name = "permisosRolToolStripMenuItem";
            this.permisosRolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.permisosRolToolStripMenuItem.Text = "&Permisos Rol";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(867, 493);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Sistemas de Compras y Cotizaciones Automayor - COCOA";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cilindrajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intervaloDePreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem númeroDePasajerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesoBrutoVehicularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segmentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cambioDeClaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeCompraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeCompraToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosRolToolStripMenuItem;
    }
}