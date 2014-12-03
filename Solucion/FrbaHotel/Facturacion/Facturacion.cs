using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Services;
using FrbaHotel.Entities;

namespace FrbaHotel.Facturacion
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.EstadiaId = Convert.ToInt32(txtNroEstadia.Text);
            factura.Fecha = DateTime.Now;
            factura.Items = new List<FacturaItem>();
            EstadiaService estadiaService = new EstadiaService();
            Estadia estadia = estadiaService.GetById(Convert.ToInt32(txtNroEstadia.Text));
            ReservaService reservaService = new ReservaService();
            Reserva reserva = reservaService.GetReservaByCodigo(estadia.CodigoReserva);
            CreateNightsItems(factura, estadia, reserva);
            CreateConsumibleItems(factura, estadia);
            foreach (FacturaItem fi in factura.Items)
            {
                factura.Total += fi.Precio;
            }

            factura.TipoPagoId = Convert.ToInt32(cmbMedioDePago.SelectedValue);
            if (factura.TipoPagoId == 2)
            {
                string error = string.Empty;
                error = ValidateTarjeta();
                if (string.IsNullOrEmpty(error))
                {
                    TarjetaDeCredito tarjeta = new TarjetaDeCredito();
                    tarjeta.Codigo = txtCodigo.Text;
                    tarjeta.CodigoSeguridad = Convert.ToInt32(txtCodigoSeguridad.Text);
                    tarjeta.FechaVencimiento = dateVencimiento.Value;
                    tarjeta.Numero = Convert.ToInt64(txtNumero.Text);
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
        }

        private string ValidateTarjeta()
        {
            string errorMessage = string.Empty;
            
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba el número de tarjeta";
            }
            if (string.IsNullOrEmpty(txtCodigoSeguridad.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba el código de seguridad";
            }
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba código";
            }
            
            return errorMessage;
        }

        private static void CreateConsumibleItems(Factura factura, Estadia estadia)
        {
            ConsumibleService consumibleService = new ConsumibleService();
            List<Consumible> consumibles = consumibleService.GetByIdEstadia(estadia.Id).ToList();
            foreach (Consumible c in consumibles)
            {
                FacturaItem consumibleItem = new FacturaItem();
                consumibleItem.Descripcion = "Consumible: " + c.Descripcion;
                consumibleItem.Precio = c.Precio;
                factura.Items.Add(consumibleItem);
            }
        }

        private static void CreateNightsItems(Factura factura, Estadia estadia, Reserva reserva)
        {
            List<DateTime> reservaUseDates = new List<DateTime>();
            List<DateTime> reservaNotUseDates = new List<DateTime>();

            DateTime reservaDate = reserva.FechaDesde.Date;
            int nochesUso = 0;
            int nochesSinUso = 0;
            while (reservaDate <= estadia.FechaHasta.Date)
            {
                nochesUso++;
                reservaUseDates.Add(reservaDate);
                reservaDate = reservaDate.AddDays(1);
            }

            FacturaItem useDateItem = new FacturaItem();
            useDateItem.Descripcion = "Estadia:          " + (nochesUso - 1).ToString() + " noches";
            factura.Items.Add(useDateItem);

            while (reservaDate <= reserva.FechaHasta)
            {
                nochesSinUso++;
                reservaNotUseDates.Add(reservaDate);
                reservaDate = reservaDate.AddDays(1);
            }

            if (nochesSinUso > 0)
            {
                FacturaItem notUseDateItem = new FacturaItem();
                notUseDateItem.Descripcion = "Noches de reserva sin uso:          " + reservaNotUseDates.Count.ToString() + " noches";
                factura.Items.Add(notUseDateItem);
            }
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            FacturaTipoPagoService tipoPagoService = new FacturaTipoPagoService();
            List<FacturaTipoPago> tiposDePago = tipoPagoService.GetAll().ToList();
            cmbMedioDePago.DataSource = tiposDePago;
            cmbMedioDePago.DisplayMember = "Descripcion";
            cmbMedioDePago.ValueMember = "Id";
            cmbMedioDePago.SelectedValue = 0;
        }
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCodigoSeguridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmbMedioDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedioDePago.SelectedIndex == 2)
            {
                groupDatosTarjeta.Visible = true;
            }
            else
            {
                groupDatosTarjeta.Visible = false;
            }
        }
    }
}
