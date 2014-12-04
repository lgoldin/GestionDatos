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
        private int EstadiaId { get; set; }
        public Facturacion()
        {
            InitializeComponent();
        }

        public Facturacion(int estadiaId)
        {
            InitializeComponent();
            this.EstadiaId = estadiaId;
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            string error = string.Empty;
            TarjetaDeCredito tarjeta = null;
            if (Convert.ToInt32(cmbMedioDePago.SelectedValue) == 0)
            {
                error += "Seleccione un medio de pago";
            }
            if (Convert.ToInt32(cmbClientes.SelectedValue) == 0)
            {
                error += System.Environment.NewLine + "Seleccione un cliente";
            }

            factura.TipoPagoId = Convert.ToInt32(cmbMedioDePago.SelectedValue);
            factura.ClienteId = Convert.ToInt32(cmbClientes.SelectedValue);

            if (factura.TipoPagoId == 2)
            {
                error += ValidateTarjeta();
                if (string.IsNullOrEmpty(error))
                {
                    tarjeta = CreateTarjetaDeCredito();
                }
            }
            if (string.IsNullOrEmpty(error))
            {
                try
                {
                    factura.EstadiaId = Convert.ToInt32(txtNroEstadia.Text);
                    factura.Fecha = DateTime.Now;
                    factura.Items = new List<FacturaItem>();
                    EstadiaService estadiaService = new EstadiaService();
                    Estadia estadia = estadiaService.GetById(Convert.ToInt32(txtNroEstadia.Text));
                    ReservaService reservaService = new ReservaService();
                    Reserva reserva = reservaService.GetReservaByCodigo(estadia.CodigoReserva);
                    RegimenService regimenService = new RegimenService();
                    Regimen regimen = regimenService.GetByCodigo(reserva.RegimenCodigo);

                    CreateNightsItems(factura, estadia, reserva, regimen.Precio);
                    CreateConsumibleItems(factura, estadia, regimen.ConsumiblesGratis);
                    foreach (FacturaItem fi in factura.Items)
                    {
                        factura.Total += fi.Precio;
                    }

                    FacturaService service = new FacturaService();
                    factura.Numero = service.Insert(factura, tarjeta);
                    MostrarFactura(factura);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al crear la factura");
                }
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private void MostrarFactura(Factura factura)
        {
            string cliente = ((Cliente)this.cmbClientes.SelectedItem).Nombre + " " + ((Cliente)this.cmbClientes.SelectedItem).Apellido;
            Form form = new FacturaFinal(factura, cliente);
            DisplayForm(form);
        }

        private void DisplayForm(Form form)
        {
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private TarjetaDeCredito CreateTarjetaDeCredito()
        {
            TarjetaDeCredito tarjeta = new TarjetaDeCredito();
            tarjeta.Codigo = txtCodigo.Text;
            tarjeta.CodigoSeguridad = Convert.ToInt32(txtCodigoSeguridad.Text);
            tarjeta.FechaVencimiento = dateVencimiento.Value;
            tarjeta.Numero = Convert.ToInt64(txtNumero.Text);
            return tarjeta;
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

        private static void CreateConsumibleItems(Factura factura, Estadia estadia, bool esGratis)
        {
            ConsumibleService consumibleService = new ConsumibleService();
            List<Consumible> consumibles = consumibleService.GetByIdEstadia(estadia.Id).ToList();
            decimal precioConsumibles = 0;
            foreach (Consumible c in consumibles)
            {
                FacturaItem consumibleItem = new FacturaItem();
                consumibleItem.Descripcion = "Consumible: " + c.Descripcion;
                consumibleItem.Precio = c.Precio;
                factura.Items.Add(consumibleItem);
                precioConsumibles += consumibleItem.Precio;
            }

            if (esGratis)
            {
                FacturaItem consumibleGratis = new FacturaItem();
                consumibleGratis.Precio = precioConsumibles * (-1);
                consumibleGratis.Descripcion = "Descuento por régimen de estadía";
                factura.Items.Add(consumibleGratis);
            }

        }

        private static void CreateNightsItems(Factura factura, Estadia estadia, Reserva reserva, decimal regimenPrecio)
        {
            TipoHabitacionService tipoHabitacionService = new TipoHabitacionService();
            TipoHabitacion tipoHab = tipoHabitacionService.GetByCodigo(reserva.TipoHabitacionCodigo);
            HotelService hotelService = new HotelService();
            Hotel hotel = hotelService.GetById(reserva.HotelId);
            HotelCargoPorEstrellaService hotelCargoPorEstrellaService = new HotelCargoPorEstrellaService();
            decimal precioNoche = ((decimal)hotelCargoPorEstrellaService.GetCargo()) * hotel.Estrellas;
            precioNoche += tipoHab.Porcentual * regimenPrecio;
            
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
            useDateItem.Precio = precioNoche * (nochesUso - 1);
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
                notUseDateItem.Precio = precioNoche * (nochesSinUso);
                notUseDateItem.Descripcion = "Noches de reserva sin uso:          " + nochesSinUso + " noches";
                factura.Items.Add(notUseDateItem);
            }
            
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            if (this.EstadiaId != 0)
            {
                txtNroEstadia.Text = this.EstadiaId.ToString();
                this.txtNroEstadia.ReadOnly = true;
            }
            else
            {
                this.txtNroEstadia.ReadOnly = false;
            }

            FacturaTipoPagoService tipoPagoService = new FacturaTipoPagoService();
            List<FacturaTipoPago> tiposDePago = tipoPagoService.GetAll().ToList();
            cmbMedioDePago.DataSource = tiposDePago;
            cmbMedioDePago.DisplayMember = "Descripcion";
            cmbMedioDePago.ValueMember = "Id";
            cmbMedioDePago.SelectedValue = 0;

            if (!string.IsNullOrEmpty(txtNroEstadia.Text))
            {
                ClienteService clienteService = new ClienteService();
                List<Cliente> clientes = clienteService.GetByEstadiaId(Convert.ToInt32(this.txtNroEstadia.Text));
                cmbClientes.DataSource = clientes;
                cmbClientes.DisplayMember = "Nombre";
                cmbClientes.ValueMember = "Id";
                cmbClientes.SelectedValue = 0;
            }
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
