﻿using COCOA.Busqueda;
using COCOA.Clases;
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
        private decimal totalSubtotal = 0;
        private decimal totalIVA = 0;
        private decimal totalImpoconsumo = 0;
        private decimal totalNeto = 0;

        public DALUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmCotizaciones()
        {
            InitializeComponent();
        }

        private void frmCotizaciones_Load(object sender, EventArgs e)
        {
            this.intervaloPreciosTableAdapter.Fill(this.dSCOCOA.IntervaloPrecios);
            this.pesoBrutoVhTableAdapter.Fill(this.dSCOCOA.PesoBrutoVh);
            this.numeroPasajerosTableAdapter.Fill(this.dSCOCOA.NumeroPasajeros);
            this.cilindrajesTableAdapter.Fill(this.dSCOCOA.Cilindrajes);
            this.segmentosTableAdapter.Fill(this.dSCOCOA.Segmentos);
            this.clientesTableAdapter.FillBy3(this.dSCOCOA.Clientes);

            clienteComboBox.SelectedIndex = -1;            
            productoLabel.Text = string.Empty;

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
                errorProvider1.SetError(numeroItemTextBox, "El campo Número Item es numerico");
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
                errorProvider1.SetError(cantidadTextBox, "El campo Cantidad es numerico");
                return;
            }
            errorProvider1.Clear();

            if (cantidad <= 0)
            {
                errorProvider1.SetError(cantidadTextBox, "La Cantidad debe ser mayor a cero");
                return;
            }
            errorProvider1.Clear();

            float estampillas;

            if (!float.TryParse(estampillasTextBox.Text, out estampillas))
            {
                errorProvider1.SetError(estampillasTextBox, "El campo Estampillas es decimal");
                return;
            }
            errorProvider1.Clear();

            //if (estampillas <= 0)
            //{
            //    errorProvider1.SetError(estampillasTextBox, "el valor de las Estampillas debe ser mayor a cero");
            //    return;
            //}
            //errorProvider1.Clear();

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
            miDetalle.Precio = ultimoProducto.Precio;
            miDetalle.DescripcionProducto = ultimoProducto.DescripcionProducto;
            miDetalle.IdProducto = ultimoProducto.IdProducto;
            miDetalle.PorcentajeIVA = (float)miIVA.Tarifa;
            miDetalle.PorcentajeImpoconsumo = (float)miImpoconsumo.Tarifa;
            miDetalle.Estampillas = estampillas;

            misDetalles.Add(miDetalle);
            RefrescaGrid();

            ultimoProducto = null;

            productoTextBox.Text = string.Empty;
            productoLabel.Text = string.Empty;
            cantidadTextBox.Text = string.Empty;
            precioTextBox.Text = string.Empty;
            estampillasTextBox.Text = "0.00";
            totalEstampillasTextBox.Text = string.Empty;
            productoTextBox.Focus();

        }

        private void RefrescaGrid()
        {
            detalleCotizacionDataGridView.DataSource = null;
            detalleCotizacionDataGridView.DataSource = misDetalles;

            totalEstampillas = 0;
            totalSubtotal = 0;
            totalIVA = 0;
            totalImpoconsumo = 0;
            totalNeto = 0;

            foreach (DetalleCotizacion miDetalle in misDetalles)
            {
                totalEstampillas += miDetalle.ValorEstampillas;
                totalSubtotal += miDetalle.Subtotal;
                totalIVA += miDetalle.ValorIVA;
                totalImpoconsumo += miDetalle.ValorImpoconsumo;
                totalNeto += miDetalle.ValorNeto;
            }

            totalEstampillasTextBox.Text = string.Format("{0:C2}", totalEstampillas);
            totalSubtotalTextBox.Text = string.Format("{0:C2}", totalSubtotal);
            totalIVATextBox.Text = string.Format("{0:C2}", totalIVA);
            totalImpoconsumoTextBox.Text = string.Format("{0:C2}", totalImpoconsumo);
            totalNetoTextBox.Text = string.Format("{0:C2}", totalNeto);

            PersonalizarGrid();
        }

        private void PersonalizarGrid()
        {
            detalleCotizacionDataGridView.Columns["DetalleNumeroItem"].Visible = false;

            detalleCotizacionDataGridView.Columns["NumeroItem"].HeaderText = "No.";
            detalleCotizacionDataGridView.Columns["NumeroItem"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["NumeroItem"].Width = 40;

            detalleCotizacionDataGridView.Columns["IdProducto"].HeaderText = "Producto";
            detalleCotizacionDataGridView.Columns["IdProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["IdProducto"].Width = 60;

            detalleCotizacionDataGridView.Columns["DescripcionProducto"].HeaderText = "Descripción";
            detalleCotizacionDataGridView.Columns["DescripcionProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            detalleCotizacionDataGridView.Columns["DescripcionProducto"].Width = 420;

            detalleCotizacionDataGridView.Columns["Precio"].HeaderText = "Precio Unitario";
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

            detalleCotizacionDataGridView.Columns["Estampillas"].HeaderText = "Estampillas";
            detalleCotizacionDataGridView.Columns["Estampillas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["Estampillas"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["Estampillas"].DefaultCellStyle.Format = "N2";
            detalleCotizacionDataGridView.Columns["Estampillas"].Width = 70;

            detalleCotizacionDataGridView.Columns["ValorEstampillas"].HeaderText = "Valor Estampillas";
            detalleCotizacionDataGridView.Columns["ValorEstampillas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["ValorEstampillas"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["ValorEstampillas"].DefaultCellStyle.Format = "C2";
            detalleCotizacionDataGridView.Columns["ValorEstampillas"].Width = 115;

            detalleCotizacionDataGridView.Columns["Subtotal"].HeaderText = "Subtotal";
            detalleCotizacionDataGridView.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["Subtotal"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
            detalleCotizacionDataGridView.Columns["Subtotal"].Width = 115;

            detalleCotizacionDataGridView.Columns["ValorIVA"].HeaderText = "Valor IVA";
            detalleCotizacionDataGridView.Columns["ValorIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["ValorIVA"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["ValorIVA"].DefaultCellStyle.Format = "C2";
            detalleCotizacionDataGridView.Columns["ValorIVA"].Width = 115;

            detalleCotizacionDataGridView.Columns["ValorImpoconsumo"].HeaderText = "Valor Impoconsumo";
            detalleCotizacionDataGridView.Columns["ValorImpoconsumo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["ValorImpoconsumo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["ValorImpoconsumo"].DefaultCellStyle.Format = "C2";
            detalleCotizacionDataGridView.Columns["ValorImpoconsumo"].Width = 115;

            detalleCotizacionDataGridView.Columns["ValorNeto"].HeaderText = "Valor Neto";
            detalleCotizacionDataGridView.Columns["ValorNeto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["ValorNeto"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            detalleCotizacionDataGridView.Columns["ValorNeto"].DefaultCellStyle.Format = "C2";
            detalleCotizacionDataGridView.Columns["ValorNeto"].Width = 115;
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

            precioTextBox.Text = string.Format("{0:C2}", ultimoProducto.Precio);            
        }

        private void numeroItemTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

            //Guarda encabezado            
            int IdCotizacion = DALCotizacion.InsertCotizacion(fecha, IdCliente, contacto, formaPago, plazoEntrega, sitioEntrega);

            //Guarda detalle           
            foreach (DetalleCotizacion miDetalle in misDetalles)
            {
                DALCotizacionDetalle.InsertCotizacionDetalle(IdCotizacion, miDetalle.NumeroItem, miDetalle.DetalleNumeroItem, miDetalle.IdProducto,
                    miDetalle.DescripcionProducto, miDetalle.Precio, miDetalle.Cantidad, miDetalle.PorcentajeIVA, miDetalle.PorcentajeImpoconsumo,
                    miDetalle.Estampillas);

            }

            MessageBox.Show(string.Format("Cotización {0} guardada exitosamente", IdCotizacion), "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmReporteCotizacion miReporte = new frmReporteCotizacion();
            miReporte.IDCotizacion = IdCotizacion;
            miReporte.Show();

            totalSubtotal = 0;
            totalIVA = 0;
            totalImpoconsumo = 0;
            totalNeto = 0;

            clienteComboBox.SelectedIndex = -1;
            misDetalles.Clear();
            plazoEntregaTextBox.Text = string.Empty;
            contactoTextBox.Text = string.Empty;
            formaPagoTextBox.Text = string.Empty;
            sitioEntregaTextBox.Text = string.Empty;
            numeroItemTextBox.Text = string.Empty;
            detalleItemTextBox.Text = string.Empty;
            RefrescaGrid();
            clienteComboBox.Focus();
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
    }

}
