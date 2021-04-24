﻿using BL.SMF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.SMF
{
    public partial class FormFacturacion : Form
    {
        FacturaBL _facturaBL;
        ClientesBL _clientesBL;
        ProductosBL _productosBL;

        public FormFacturacion()
        {
            InitializeComponent();

            _facturaBL = new FacturaBL();
            listaFacturaBindingSource.DataSource = _facturaBL.ObtenerFacturas();

            _clientesBL = new ClientesBL();
            listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();

            _productosBL = new ProductosBL();
            listaProductosBindingSource.DataSource = _productosBL.ObtenerProductos();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _facturaBL.AgregarFactura();
            listaFacturaBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void listaFacturaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaFacturaBindingSource.EndEdit();

            var factura = (Factura)listaFacturaBindingSource.Current;
            
            var resultado = _facturaBL.GuardarFactura(factura);

            if (resultado.Exitoso == true)
            {
                listaFacturaBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Factura guardada con exito!!");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            _facturaBL.CancelarCambios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturaBindingSource.Current;
            _facturaBL.AgregarFacturaDetalle(factura);

            DeshabilitarHabilitarBotones(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturaBindingSource.Current;
            var facturaDetalle = (FacturaDetalle)facturaDetalleBindingSource.Current;

            _facturaBL.RemoverFacturaDetalle(factura, facturaDetalle);

            DeshabilitarHabilitarBotones(false);
        }

        private void facturaDetalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)listaFacturaBindingSource.Current;
            _facturaBL.CalcularFactura(factura);

            listaFacturaBindingSource.ResetBindings(false);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
                if (idTextBox.Text != "")
                {
                    var resultado = MessageBox.Show("Desea anular esta factura?", "Anular", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes)
                    {
                        var id = Convert.ToInt32(idTextBox.Text);
                        Anular(id);
                    }
                }

        }


        private void Anular(int id)
        {
            var resultado = _facturaBL.AnularFactura(id);

            if (resultado == true)
            {
                listaFacturaBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al anular la factura");
            }
        }

        private void listaFacturaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturaBindingSource.Current;

            if (factura != null && factura.Id != 0 && factura.Activo == false)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }
    }
 }

