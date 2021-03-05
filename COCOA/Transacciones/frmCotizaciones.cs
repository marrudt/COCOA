using COCOA.Busqueda;
using COCOA.Clases;
using COCOA.Maestras;
using COCOA.Reportes;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace COCOA.Transacciones
{
    public partial class frmCotizaciones : Form
    {
        List<DetalleCotizacion> misDetalles = new List<DetalleCotizacion>();
        private DALUsuario usuarioLogueado;
        DALProducto ultimoProducto = null;

        private decimal totalEstampillas = 0;
        private decimal totalDescuento = 0;
        private decimal totalSubtotal = 0;
        private decimal totalIVA = 0;
        private decimal totalImpoconsumo = 0;
        private decimal totalNeto = 0;

        public DALUsuario UsuarioLogueado
        {
            get { return usuarioLogueado; }
            set { usuarioLogueado = value; }
        }       

        public frmCotizaciones()
        {
            InitializeComponent();
        }

        private void frmCotizaciones_Load(object sender, EventArgs e)
        {
            this.cotizacionTableAdapter.Fill(this.dSCOCOA.Cotizacion);
            this.cotizacionDetalleTableAdapter.Fill(this.dSCOCOA.CotizacionDetalle);
            this.intervaloPreciosTableAdapter.Fill(this.dSCOCOA.IntervaloPrecios);
            this.pesoBrutoVhTableAdapter.Fill(this.dSCOCOA.PesoBrutoVh);
            this.numeroPasajerosTableAdapter.Fill(this.dSCOCOA.NumeroPasajeros);
            this.cilindrajesTableAdapter.Fill(this.dSCOCOA.Cilindrajes);
            this.segmentosTableAdapter.Fill(this.dSCOCOA.Segmentos);
            this.clientesTableAdapter.FillBy(this.dSCOCOA.Clientes);

            fechaDateTimePicker.Value = DateTime.Now;
            clienteComboBox.SelectedIndex = -1;
            contactoTextBox.Text = string.Empty;
            formaPagoTextBox.Text = string.Empty;
            plazoEntregaTextBox.Text = string.Empty;
            sitioEntregaTextBox.Text = string.Empty;
            numeroItemTextBox.Text = string.Empty;
            productoLabel.Text = string.Empty;
            cantidadTextBox.Text = string.Empty;
            precioTextBox.Text = string.Empty;
            remplazaCotiacionComboBox.SelectedIndex = -1;
            
            valorEstampillasTextBox.Text = "0.00";
            porcentajeEstampillasTextBox.Text = "0.0";
            descuentoTextBox.Text = "0.00";
            precioTextBox.Enabled = false;
            precioTextBox.ReadOnly = true;
            ultimoProducto = null;
            VerificaPermiso();
        }

        private void VerificaPermiso()
        {
            if (DALPermisoRol.Especifico(usuarioLogueado.IdRol, 20))
            {
                editarDescuentoButton.Enabled = true;
            }
            else
            {
                editarDescuentoButton.Enabled = false;
            }

            if (DALPermisoRol.Especifico(usuarioLogueado.IdRol, 20))
            {
                editarPrecioButton.Enabled = true;
            }
            else
            {
                editarPrecioButton.Enabled = false;
            }
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            if (numeroItemTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(numeroItemTextBox, "El campo Número item es obligatorio");
                return;
            }
            errorProvider1.Clear();

            int numeroItem;

            if (!int.TryParse(numeroItemTextBox.Text, out numeroItem))
            {
                errorProvider1.SetError(numeroItemTextBox, "El campo Número Item es numérico");
                return;
            }
            errorProvider1.Clear();

            if (numeroItem <= 0)
            {
                errorProvider1.SetError(numeroItemTextBox, "El Número Item debe ser mayor a cero");
                return;
            }
            errorProvider1.Clear();

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
                errorProvider1.SetError(cantidadTextBox, "El campo Cantidad es numérico");
                return;
            }
            errorProvider1.Clear();

            if (cantidad <= 0)
            {
                errorProvider1.SetError(cantidadTextBox, "La Cantidad debe ser mayor a cero");
                return;
            }
            errorProvider1.Clear();

            float porcentajeEstampillas;

            if (!float.TryParse(porcentajeEstampillasTextBox.Text, out porcentajeEstampillas))
            {
                errorProvider1.SetError(porcentajeEstampillasTextBox, "El campo Porcenteaje Estampillas es numérico");
                return;
            }
            errorProvider1.Clear();

            if (porcentajeEstampillas < 0)
            {
                errorProvider1.SetError(porcentajeEstampillasTextBox, "El Porcentaje debe ser mayor a cero");
                return;
            }
            errorProvider1.Clear();

            decimal estampillas;

            if (!decimal.TryParse(valorEstampillasTextBox.Text, out estampillas))
            {
                errorProvider1.SetError(valorEstampillasTextBox, "El campo Estampillas es numérico");
                return;
            }
            errorProvider1.Clear();

            if (estampillas < 0)
            {
                errorProvider1.SetError(valorEstampillasTextBox, "el valor de las Estampillas debe ser mayor a cero");
                return;
            }
            errorProvider1.Clear();

            decimal precio;

            if (!decimal.TryParse(precioTextBox.Text, out precio))
            {
                errorProvider1.SetError(descuentoTextBox, "El campo Precio es numérico");
                return;
            }
            errorProvider1.Clear();

            if (precio < 0)
            {
                errorProvider1.SetError(descuentoTextBox, "el valor del Precio debe ser mayor a cero");
                return;
            }
            errorProvider1.Clear();

            decimal descuento;

            if (!decimal.TryParse(descuentoTextBox.Text, out descuento))
            {
                errorProvider1.SetError(descuentoTextBox, "El campo Descuento es numérico");
                return;
            }
            errorProvider1.Clear();

            if (descuento < 0)
            {
                errorProvider1.SetError(descuentoTextBox, "el valor del Descuento debe ser mayor a cero");
                return;
            }
            errorProvider1.Clear();

            string detalleNumeroItem = detalleItemTextBox.Text;

            if (detalleItemTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(detalleItemTextBox, "El campo Detalle Número Ítem es obligatorio");
                detalleItemTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            DALIVA miIVA = DALIVA.GetIVA(ultimoProducto.IdIVA);
            DALImpoconsumo miImpoconsumo = DALImpoconsumo.GetImpoconsumo(ultimoProducto.IdImpoconsumo);

            DetalleCotizacion miDetalle = new DetalleCotizacion();
            miDetalle.NumeroItem = numeroItem;
            miDetalle.DetalleNumeroItem = detalleNumeroItem;
            miDetalle.Cantidad = cantidad;
            miDetalle.Precio = precio; //ultimoProducto.Precio;
            miDetalle.DescripcionProducto = ultimoProducto.DescripcionProducto;
            miDetalle.IdProducto = ultimoProducto.IdProducto;
            miDetalle.PorcentajeIVA = (float)miIVA.Tarifa;
            miDetalle.PorcentajeImpoconsumo = (float)miImpoconsumo.Tarifa;
            miDetalle.PorcentajeEstampillas = porcentajeEstampillas;
            miDetalle.ValorEstampillas = estampillas;
            miDetalle.Descuento = descuento;

            misDetalles.Add(miDetalle);
            RefrescaGrid();

            ultimoProducto = null;

            productoTextBox.Text = string.Empty;
            productoLabel.Text = string.Empty;
            cantidadTextBox.Text = string.Empty;
            precioTextBox.Text = string.Empty;
            descuentoTextBox.Text = "0.00";
            porcentajeEstampillasTextBox.Text = "0.0";
            valorEstampillasTextBox.Text = "0.00";
            precioTextBox.ReadOnly = true;
            precioTextBox.Enabled = false;
            productoTextBox.Focus();

        }

        private void RefrescaGrid()
        {
            detalleCotizacionDataGridView.DataSource = null;
            detalleCotizacionDataGridView.DataSource = misDetalles;

            totalEstampillas = 0;
            totalDescuento = 0;
            totalSubtotal = 0;
            totalIVA = 0;
            totalImpoconsumo = 0;
            totalNeto = 0;

            foreach (DetalleCotizacion miDetalle in misDetalles)
            {
                totalEstampillas += miDetalle.ValorEstampillas;
                totalDescuento += miDetalle.Descuento;
                totalSubtotal += miDetalle.Subtotal;
                totalIVA += miDetalle.ValorIVA;
                totalImpoconsumo += miDetalle.ValorImpoconsumo;
                totalNeto += miDetalle.ValorNeto;
            }

            totalEstampillasTextBox.Text = string.Format("{0:C2}", totalEstampillas);
            totalDescuentoTextBox.Text=string.Format("{0:C2}", totalDescuento);
            totalSubtotalTextBox.Text = string.Format("{0:C2}", totalSubtotal);
            totalIVATextBox.Text = string.Format("{0:C2}", totalIVA);
            totalImpoconsumoTextBox.Text = string.Format("{0:C2}", totalImpoconsumo);
            totalNetoTextBox.Text = string.Format("{0:C2}", totalNeto);

            PersonalizarGrid();
        }

        private void PersonalizarGrid()
        {           
            detalleCotizacionDataGridView.Columns["IdProducto"].Visible = false;

            detalleCotizacionDataGridView.Columns["NumeroItem"].HeaderText = "No.";
            detalleCotizacionDataGridView.Columns["NumeroItem"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["NumeroItem"].Width = 40;
            
            detalleCotizacionDataGridView.Columns["DetalleNumeroItem"].HeaderText = "Detalle Item.";
            detalleCotizacionDataGridView.Columns["DetalleNumeroItem"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            detalleCotizacionDataGridView.Columns["DetalleNumeroItem"].Width = 200;

            detalleCotizacionDataGridView.Columns["IdProducto"].HeaderText = "Producto";
            detalleCotizacionDataGridView.Columns["IdProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["IdProducto"].Width = 60;

            detalleCotizacionDataGridView.Columns["DescripcionProducto"].HeaderText = "Descripción";
            detalleCotizacionDataGridView.Columns["DescripcionProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            detalleCotizacionDataGridView.Columns["DescripcionProducto"].Width = 420;

            detalleCotizacionDataGridView.Columns["Precio"].HeaderText = "Precio";
            detalleCotizacionDataGridView.Columns["Precio"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["Precio"].DefaultCellStyle.Format = "C2";
            detalleCotizacionDataGridView.Columns["Precio"].Width = 100;

            detalleCotizacionDataGridView.Columns["Cantidad"].HeaderText = "Cantidad";
            detalleCotizacionDataGridView.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["Cantidad"].DefaultCellStyle.Format = "N2";
            detalleCotizacionDataGridView.Columns["Cantidad"].Width = 50;

            detalleCotizacionDataGridView.Columns["PorcentajeIVA"].HeaderText = "% IVA";
            detalleCotizacionDataGridView.Columns["PorcentajeIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["PorcentajeIVA"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["PorcentajeIVA"].Width = 70;

            detalleCotizacionDataGridView.Columns["PorcentajeImpoconsumo"].HeaderText = "% Impocon";
            detalleCotizacionDataGridView.Columns["PorcentajeImpoconsumo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["PorcentajeImpoconsumo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["PorcentajeImpoconsumo"].Width = 70;            

            detalleCotizacionDataGridView.Columns["ValorEstampillas"].HeaderText = "Vr. Estamp.";
            detalleCotizacionDataGridView.Columns["ValorEstampillas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["ValorEstampillas"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["ValorEstampillas"].DefaultCellStyle.Format = "C2";
            detalleCotizacionDataGridView.Columns["ValorEstampillas"].Width = 105;

            detalleCotizacionDataGridView.Columns["PorcentajeEstampillas"].HeaderText = "% Est.";
            detalleCotizacionDataGridView.Columns["PorcentajeEstampillas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["PorcentajeEstampillas"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["PorcentajeEstampillas"].Width = 70;

            detalleCotizacionDataGridView.Columns["Subtotal"].HeaderText = "Subtotal";
            detalleCotizacionDataGridView.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["Subtotal"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
            detalleCotizacionDataGridView.Columns["Subtotal"].Width = 105;

            detalleCotizacionDataGridView.Columns["ValorIVA"].HeaderText = "Vr. IVA";
            detalleCotizacionDataGridView.Columns["ValorIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["ValorIVA"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["ValorIVA"].DefaultCellStyle.Format = "C2";
            detalleCotizacionDataGridView.Columns["ValorIVA"].Width = 105;

            detalleCotizacionDataGridView.Columns["Descuento"].HeaderText = "Descuento";
            detalleCotizacionDataGridView.Columns["Descuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["Descuento"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["Descuento"].DefaultCellStyle.Format = "C2";
            detalleCotizacionDataGridView.Columns["Descuento"].Width = 105;

            detalleCotizacionDataGridView.Columns["ValorImpoconsumo"].HeaderText = "Vr. Impoc.";
            detalleCotizacionDataGridView.Columns["ValorImpoconsumo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["ValorImpoconsumo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["ValorImpoconsumo"].DefaultCellStyle.Format = "C2";
            detalleCotizacionDataGridView.Columns["ValorImpoconsumo"].Width = 105;

            detalleCotizacionDataGridView.Columns["ValorNeto"].HeaderText = "Valor Neto";
            detalleCotizacionDataGridView.Columns["ValorNeto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["ValorNeto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["ValorNeto"].DefaultCellStyle.Format = "C2";
            detalleCotizacionDataGridView.Columns["ValorNeto"].Width = 105;
        }

        private void productoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }

        private void cantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }

        private void itemNumeroTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }

        private void buscarProductoButton_Click_1(object sender, EventArgs e)
        {
            frmBusquedaProducto miBusqueda = new frmBusquedaProducto();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDProducto == 0) return;
            productoTextBox.Text = miBusqueda.IDProducto.ToString();
            productoTextBox_Validating_1(sender, new CancelEventArgs());
        }

        private void productoTextBox_Validating_1(object sender, CancelEventArgs e)
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

            precioTextBox.Text = string.Format("{0:N0}", ultimoProducto.Precio);            
        }

        private void numeroItemTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }

        private void vigenciaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }

        private void productoTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }

        private void cantidadTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }

        private void salirButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (vigenciaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(vigenciaTextBox, "El campo Vigencia es obligatorio");
                vigenciaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (clienteComboBox.SelectedIndex == -1) 
            {
                errorProvider1.SetError(clienteComboBox, "El campo Cliente es obligatorio");
                clienteComboBox.Focus();
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

            if (plazoEntregaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(plazoEntregaTextBox, "El campo Plazo Entrega es obligatorio");
                plazoEntregaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (sitioEntregaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(sitioEntregaTextBox, "El campo Sitio Entrega es obligatorio");
                sitioEntregaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (clienteComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(clienteComboBox, "Seleccione un Cliente");
                clienteComboBox.Focus();
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

            int IdCliente = (int)clienteComboBox.SelectedValue;
            DateTime fecha = fechaDateTimePicker.Value;
            string plazoEntrega = plazoEntregaTextBox.Text;
            string contacto = contactoTextBox.Text;
            string formaPago = formaPagoTextBox.Text;
            string sitioEntrega = sitioEntregaTextBox.Text;
            string remplazaCotizacion = remplazaCotiacionComboBox.Text;
            string notas = notasTextBox.Text;
            string vigencia = vigenciaTextBox.Text;

            //Guarda encabezado            
            int IdCotizacion = DALCotizacion.InsertCotizacion(fecha, vigencia, remplazaCotizacion, IdCliente, contacto, formaPago, plazoEntrega, sitioEntrega, notas);

            //Guarda detalle           
            foreach (DetalleCotizacion miDetalle in misDetalles)
            {
                DALCotizacionDetalle.InsertCotizacionDetalle(IdCotizacion, miDetalle.NumeroItem, miDetalle.DetalleNumeroItem, miDetalle.IdProducto,
                    miDetalle.DescripcionProducto, miDetalle.Precio, miDetalle.Cantidad, miDetalle.PorcentajeIVA, miDetalle.PorcentajeImpoconsumo,
                    miDetalle.PorcentajeEstampillas, miDetalle.ValorEstampillas, miDetalle.Descuento);

            }

            MessageBox.Show(string.Format("Cotización {0} guardada exitosamente", IdCotizacion), "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmReporteCotizacion miReporte = new frmReporteCotizacion();
            miReporte.IDCotizacion = IdCotizacion;
            miReporte.Show();

            totalSubtotal = 0;
            totalDescuento = 0;
            totalEstampillas = 0;
            totalIVA = 0;
            totalImpoconsumo = 0;
            totalNeto = 0;

            fechaDateTimePicker.Value = DateTime.Now;
            clienteComboBox.SelectedIndex = -1;
            contactoTextBox.Text = string.Empty;
            formaPagoTextBox.Text = string.Empty;
            plazoEntregaTextBox.Text = string.Empty;           
            sitioEntregaTextBox.Text = string.Empty;
            numeroItemTextBox.Text = string.Empty;
            detalleItemTextBox.Text = string.Empty;
            productoTextBox.Text = string.Empty;
            productoLabel.Text = string.Empty;
            cantidadTextBox.Text = string.Empty;
            precioTextBox.Text = string.Empty;
            valorEstampillasTextBox.Text = "0.00";
            descuentoTextBox.Text = "0.00";
            clienteComboBox.Focus();
            remplazaCotiacionComboBox.SelectedIndex = -1;

            misDetalles.Clear();
            RefrescaGrid();
            
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void borrarLineaButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (misDetalles.Count == 0) return;
            if (detalleCotizacionDataGridView.SelectedRows.Count == 0)
            {
                misDetalles.RemoveAt(misDetalles.Count - 1);
                RefrescaGrid();
            }
            else
            {
                int IDProducto = (int)detalleCotizacionDataGridView.SelectedRows[0].Cells[2].Value;
                for (int i = 0; i < misDetalles.Count; i++)
                {
                    if (misDetalles[i].IdProducto == IDProducto)
                    {
                        misDetalles.RemoveAt(i);
                        break;
                    }
                }
            }
            RefrescaGrid();
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

        private void busquedaClienteButton_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente miBusqueda = new frmBusquedaCliente();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDCliente == 0) return;
            clienteComboBox.SelectedValue = miBusqueda.IDCliente;
        }

        private void frmCotizaciones_FormClosing(object sender, FormClosingEventArgs e)
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

        private void valorEstampillasTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextBox.SoloNumeros(e);
        }

        private void productoButton_Click(object sender, EventArgs e)
        {
            frmProductos miForm = new frmProductos();
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void editarPrecioButton_Click(object sender, EventArgs e)
        {
            precioTextBox.ReadOnly = false;
            precioTextBox.Enabled = true;
        }

        private void editarDescuentoButton_Click(object sender, EventArgs e)
        {
            descuentoTextBox.ReadOnly = false;
            descuentoTextBox.Enabled = true;
        }        
    }

}
