using COCOA.Busqueda;
using COCOA.Clases;
using COCOA.Maestras;
using COCOA.Reportes;
using DAL;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace COCOA.Transacciones
{
    public partial class frmOrdenCompras : Form
    {
        BindingList<DetalleOrdenCompra> misDetalles = new BindingList<DetalleOrdenCompra>();
        DALProducto ultimoProducto = null;
        private DALUsuario usuarioLogueado;

        private decimal totalSubtotal = 0;
        private decimal totalIVA = 0;
        private decimal totalImpoconsumo = 0;
        private decimal totalNeto = 0;

        public DALUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmOrdenCompras()
        {
            InitializeComponent();
        }

        private void frmOrdenCompras_Load(object sender, EventArgs e)
        {
            this.clientesTableAdapter.FillBy(this.dSCOCOA.Clientes);
            this.ordenCompraTableAdapter.Fill(this.dSCOCOA.OrdenCompra);
            this.ordenCompraDetalleTableAdapter.Fill(this.dSCOCOA.OrdenCompraDetalle);
            this.proveedoresTableAdapter.FillBy1(this.dSCOCOA.Proveedores);
            this.productosTableAdapter.FillBy4(this.dSCOCOA.Productos);

            fechaDateTimePicker.Value = DateTime.Now;
            proveedorComboBox.SelectedIndex = -1;
            vehiculoComboBox.SelectedIndex = -1;
            entidadComboBox.SelectedIndex = -1;
            plazoEntregaTextBox.Text = string.Empty;
            numeroCosteoTextBox.Text = string.Empty;
            contratoTextBox.Text = string.Empty;
            formaPagoTextBox.Text = string.Empty;
            productoLabel.Text = string.Empty;
            detalleOrdenCompraDataGridView.DataSource = misDetalles;
            ultimoProducto = null;
        }

        private void busquedaProveedorButton_Click_1(object sender, EventArgs e)
        {
            frmBusquedaProveedor miBusqueda = new frmBusquedaProveedor();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDProveedor == 0) return;
            proveedorComboBox.SelectedValue = miBusqueda.IDProveedor;
        }

        private void buscarProductoButton_Click(object sender, EventArgs e)
        {
            frmBusquedaProducto miBusqueda = new frmBusquedaProducto();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDProducto == 0) return;
            productoTextBox.Text = miBusqueda.IDProducto.ToString();
            productoTextBox_Validating(sender, new CancelEventArgs());
        }

        private void productoTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (productoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(productoTextBox, "El campo Producto es obligatorio");
                return;
            }
            errorProvider1.Clear();

            long producto;

            if (!long.TryParse(productoTextBox.Text, out producto))
            {
                errorProvider1.SetError(productoTextBox, "El campo Producto es un numero entero");
                return;
            }
            errorProvider1.Clear();

            if (producto <= 0)
            {
                errorProvider1.SetError(productoTextBox, "El campo Producto es un numero mayor que cero");
                return;
            }
            errorProvider1.Clear();

            DALProducto miProducto = DALProducto.GetProductoByIdProducto((int)producto);

            if (miProducto == null)
            {
                errorProvider1.SetError(productoTextBox, "Producto no existe");
                productoLabel.Text = string.Empty;
                ultimoProducto = null;
            }
            else
            {
                productoLabel.Text = miProducto.DescripcionProducto;
                ultimoProducto = miProducto;
            }

            precioTextBox.Text = string.Format("{0:C2}", ultimoProducto.Precio);
        }

        private void agregarButton_Click_1(object sender, EventArgs e)
        {
            if (ultimoProducto == null)
            {
                errorProvider1.SetError(productoTextBox, "El campo Producto es obligatorio");
                productoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (cantidadTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(cantidadTextBox, "El campo cantidad es obligatorio");
                cantidadTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            float cantidad;

            if (!float.TryParse(cantidadTextBox.Text, out cantidad))
            {
                errorProvider1.SetError(cantidadTextBox, "El campo cantidad es numerico");
                return;
            }
            errorProvider1.Clear();

            if (cantidad <= 0)
            {
                errorProvider1.SetError(cantidadTextBox, "La cantidad debe ser mayor a cero");
                return;
            }
            errorProvider1.Clear();

            DALIVA miIVA = DALIVA.GetIVA(ultimoProducto.IdIVA);
            DALImpoconsumo miImpoconsumo = DALImpoconsumo.GetImpoconsumo(ultimoProducto.IdImpoconsumo);

            DetalleOrdenCompra miDetalle = new DetalleOrdenCompra();
            miDetalle.Cantidad = cantidad;
            miDetalle.Precio = ultimoProducto.Precio;
            miDetalle.DescripcionProducto = ultimoProducto.DescripcionProducto;
            miDetalle.IdProducto = ultimoProducto.IdProducto;
            miDetalle.IVA = (float)miIVA.Tarifa;
            miDetalle.Impoconsumo = (float)miImpoconsumo.Tarifa;

            misDetalles.Add(miDetalle);
            RefrescaGrid();

            ultimoProducto = null;

            productoTextBox.Text = string.Empty;
            productoLabel.Text = string.Empty;
            cantidadTextBox.Text = string.Empty;
            precioTextBox.Text = string.Empty;
            productoTextBox.Focus();
        }

        private void RefrescaGrid()
        {
            detalleOrdenCompraDataGridView.DataSource = null;
            detalleOrdenCompraDataGridView.DataSource = misDetalles;

            totalSubtotal = 0;
            totalIVA = 0;
            totalImpoconsumo = 0;
            totalNeto = 0;

            foreach (DetalleOrdenCompra miDetalle in misDetalles)
            {
                totalSubtotal += miDetalle.Subtotal;
                totalIVA += miDetalle.ValorIVA;
                totalImpoconsumo += miDetalle.ValorImpoconsumo;
                totalNeto += miDetalle.ValorNeto;
            }

            totalSubtotalTextBox.Text = string.Format("{0:C2}", totalSubtotal);
            totalIVATextBox.Text = string.Format("{0:C2}", totalIVA);
            totalImpoconsumoTextBox.Text = string.Format("{0:C2}", totalImpoconsumo);
            totalNetoTextBox.Text = string.Format("{0:C2}", totalNeto);

            PersonalizarGrid();
        }

        private void PersonalizarGrid()
        {
            detalleOrdenCompraDataGridView.Columns["IdProducto"].HeaderText = "Producto";
            detalleOrdenCompraDataGridView.Columns["IdProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleOrdenCompraDataGridView.Columns["IdProducto"].Width = 60;

            detalleOrdenCompraDataGridView.Columns["DescripcionProducto"].HeaderText = "Descripción";
            detalleOrdenCompraDataGridView.Columns["DescripcionProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            detalleOrdenCompraDataGridView.Columns["DescripcionProducto"].Width = 500;

            detalleOrdenCompraDataGridView.Columns["Precio"].HeaderText = "Precio Unitario";
            detalleOrdenCompraDataGridView.Columns["Precio"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleOrdenCompraDataGridView.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleOrdenCompraDataGridView.Columns["Precio"].DefaultCellStyle.Format = "C2";
            detalleOrdenCompraDataGridView.Columns["Precio"].Width = 100;

            detalleOrdenCompraDataGridView.Columns["Cantidad"].HeaderText = "Cantidad";
            detalleOrdenCompraDataGridView.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleOrdenCompraDataGridView.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            detalleOrdenCompraDataGridView.Columns["Cantidad"].Width = 50;

            detalleOrdenCompraDataGridView.Columns["IVA"].HeaderText = "% IVA";
            detalleOrdenCompraDataGridView.Columns["IVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleOrdenCompraDataGridView.Columns["IVA"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleOrdenCompraDataGridView.Columns["IVA"].Width = 70;

            detalleOrdenCompraDataGridView.Columns["Impoconsumo"].HeaderText = "% Impocon";
            detalleOrdenCompraDataGridView.Columns["Impoconsumo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleOrdenCompraDataGridView.Columns["Impoconsumo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleOrdenCompraDataGridView.Columns["Impoconsumo"].Width = 70;

            detalleOrdenCompraDataGridView.Columns["Subtotal"].HeaderText = "Subtotal";
            detalleOrdenCompraDataGridView.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleOrdenCompraDataGridView.Columns["Subtotal"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleOrdenCompraDataGridView.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
            detalleOrdenCompraDataGridView.Columns["Subtotal"].Width = 150;

            detalleOrdenCompraDataGridView.Columns["ValorIVA"].HeaderText = "Valor IVA";
            detalleOrdenCompraDataGridView.Columns["ValorIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleOrdenCompraDataGridView.Columns["ValorIVA"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleOrdenCompraDataGridView.Columns["ValorIVA"].DefaultCellStyle.Format = "C2";
            detalleOrdenCompraDataGridView.Columns["ValorIVA"].Width = 150;

            detalleOrdenCompraDataGridView.Columns["ValorImpoconsumo"].HeaderText = "Valor Impoconsumo";
            detalleOrdenCompraDataGridView.Columns["ValorImpoconsumo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleOrdenCompraDataGridView.Columns["ValorImpoconsumo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleOrdenCompraDataGridView.Columns["ValorImpoconsumo"].DefaultCellStyle.Format = "C2";
            detalleOrdenCompraDataGridView.Columns["ValorImpoconsumo"].Width = 150;

            detalleOrdenCompraDataGridView.Columns["ValorNeto"].HeaderText = "Valor Neto";
            detalleOrdenCompraDataGridView.Columns["ValorNeto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleOrdenCompraDataGridView.Columns["ValorNeto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleOrdenCompraDataGridView.Columns["ValorNeto"].DefaultCellStyle.Format = "C2";
            detalleOrdenCompraDataGridView.Columns["ValorNeto"].Width = 150;

        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (plazoEntregaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(plazoEntregaTextBox, "El campo Plazo Entrega es obligatorio");
                plazoEntregaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (formaPagoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(formaPagoTextBox, "El campo Forma de Pago es obligatorio");
                formaPagoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (entidadComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(entidadComboBox, "Seleccione una Entidad");
                entidadComboBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (numeroCosteoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(numeroCosteoTextBox, "El campo Número Costeo es obligatorio");
                numeroCosteoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (contratoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(contratoTextBox, "El campo Contrato es obligatorio");
                contratoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (vehiculoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(vehiculoComboBox, "Seleccione un Vehículo");
                vehiculoComboBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (proveedorComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(proveedorComboBox, "Seleccione un Proveedor");
                proveedorComboBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (misDetalles.Count == 0)
            {
                errorProvider1.SetError(productoTextBox, "Ingrese un producto");
                productoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            DialogResult rta = MessageBox.Show("¿Seguro?", "Grabar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;

            int IdProveedor = (int)proveedorComboBox.SelectedValue;
            string plazoEntrega = plazoEntregaTextBox.Text;
            string formaPago = formaPagoTextBox.Text;
            DateTime fecha = fechaDateTimePicker.Value;
            int IdCliente = (int)entidadComboBox.SelectedValue;
            string numeroCosteo = numeroCosteoTextBox.Text;
            string contrato = contratoTextBox.Text;
            int IdProducto = (int)vehiculoComboBox.SelectedValue;

            //Guarda encabezado            
            int IdOrdenCompra = DALOrdenCompra.InsertOrdenCompra(fecha, IdProveedor, plazoEntrega, formaPago, IdCliente, numeroCosteo, contrato, IdProducto);

            //Guarda detalle           
            foreach (DetalleOrdenCompra miDetalle in misDetalles)
            {
                DALOrdenCompraDetalle.InsertOrdenCompraDetalle(IdOrdenCompra, miDetalle.IdProducto, miDetalle.DescripcionProducto, miDetalle.Precio,
                    miDetalle.Cantidad, miDetalle.IVA, miDetalle.Impoconsumo);
            }

            MessageBox.Show(string.Format("Orden de Compra {0} guardada exitosamente", IdOrdenCompra), "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmReporteOrdenCompra miReporte = new frmReporteOrdenCompra();
            miReporte.IDOrdenCompra = IdOrdenCompra;
            miReporte.Show();

            totalSubtotal = 0;
            totalIVA = 0;
            totalImpoconsumo = 0;
            totalNeto = 0;

            proveedorComboBox.SelectedIndex = -1;
            misDetalles.Clear();
            plazoEntregaTextBox.Text = string.Empty;
            formaPagoTextBox.Text = string.Empty;
            RefrescaGrid();
            plazoEntregaTextBox.Focus();
        }

        private void borrarTodoButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (misDetalles.Count == 0) return;
            DialogResult rta = MessageBox.Show("¿Eliminar todo?", "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            misDetalles.Clear();
            RefrescaGrid();

        }

        private void borrarLineaButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (misDetalles.Count == 0) return;
            if (detalleOrdenCompraDataGridView.SelectedRows.Count == 0)
            {
                misDetalles.RemoveAt(misDetalles.Count - 1);
                RefrescaGrid();
            }
            else
            {
                int IdProducto = (int)detalleOrdenCompraDataGridView.SelectedRows[0].Cells[0].Value;
                for (int i = 0; i < misDetalles.Count; i++)
                {
                    if (misDetalles[i].IdProducto == IdProducto)
                    {
                        misDetalles.RemoveAt(i);
                        break;
                    }
                }
            }
            RefrescaGrid();
        }

        private void frmOrdenCompras_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (misDetalles.Count != 0)
            {
                DialogResult rta = MessageBox.Show("Perderá el documento actual...", "¿Salir?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (rta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }

        private void productoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }

        private void BusquedaClienteButton_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente miBusqueda = new frmBusquedaCliente();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDCliente == 0) return;
            entidadComboBox.SelectedValue = miBusqueda.IDCliente;
        }

        private void numeroCosteoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }
    }
}
