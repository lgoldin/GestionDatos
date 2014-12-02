using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Services;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Entities;
using FrbaHotel.ABM_de_Cliente;
namespace FrbaHotel.ABM_de_Reserva
{
    public partial class AltaReserva : Form
    {
        public IHotelService HotelService { get; set; }

        public ITipoHabitacionService TipoHabitacionService { get; set; }

        public IRegimenService RegimenService { get; set; }

        public IReservaService ReservaService { get; set; }

        public IHotelCargoPorEstrellaService HotelCargoPorEstrellaService { get; set; }

        public AltaReserva()
        {
            InitializeComponent();
            this.HotelService = new HotelService();
            this.TipoHabitacionService = new TipoHabitacionService();
            this.RegimenService = new RegimenService();
            this.ReservaService = new ReservaService();
            this.HotelCargoPorEstrellaService = new HotelCargoPorEstrellaService();
        }

        private void AltaReserva_Load(object sender, EventArgs e)
        {
            cmbHotel.DataSource = this.HotelService.GetAll(null, null, null, null);
            cmbHotel.ValueMember = "Id";
            cmbHotel.DisplayMember = "Nombre";
            cmbHotel.SelectedValue = 0;

            dateFechaDesde.MinDate = DateTime.Now.AddDays(1);
            dateFechaDesde.Value = DateTime.Now.AddDays(1);

            dateFechaHasta.MinDate = DateTime.Now.AddDays(1);
            dateFechaHasta.Value = DateTime.Now.AddDays(2);

            cmbTipoHabitacion.DataSource = this.TipoHabitacionService.GetAll();
            cmbTipoHabitacion.ValueMember = "Codigo";
            cmbTipoHabitacion.DisplayMember = "Descripcion";
            cmbTipoHabitacion.SelectedValue = 0;

            cmbRegimen.DataSource = this.RegimenService.GetAll();
            cmbRegimen.ValueMember = "Codigo";
            cmbRegimen.DisplayMember = "Descripcion";
            cmbRegimen.SelectedValue = 0;
        }

        private void btnDisponibilidad_Click(object sender, EventArgs e)
        {
            int hotelId = (int) cmbHotel.SelectedValue;
            DateTime fechaDesde = dateFechaDesde.Value;
            DateTime fechaHasta = dateFechaHasta.Value;
            int tipoHabitacionCodigo = (int) cmbTipoHabitacion.SelectedValue;

            if (!ReservaService.IsReservaAvailable(hotelId, fechaDesde, fechaHasta, tipoHabitacionCodigo))
            {
                MessageBox.Show("No hay disponibilidad para los parametros solicitados");
            }
            else
            {
                MessageBox.Show("El precio es de " + GenerarPrecio() + " USD");
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            int hotelId = (int)cmbHotel.SelectedValue;
            DateTime fechaDesde = dateFechaDesde.Value;
            DateTime fechaHasta = dateFechaHasta.Value;
            int tipoHabitacionCodigo = (int)cmbTipoHabitacion.SelectedValue;            

            if (!ReservaService.IsReservaAvailable(hotelId, fechaDesde, fechaHasta, tipoHabitacionCodigo))
            {
                MessageBox.Show("No hay disponibilidad para los parametros solicitados");
            }
            else
            {
                ListadoCliente form = new ListadoCliente(false);
                form.ShowDialog();
                int clienteId = form.ClienteId;
                
                Reserva reserva = new Reserva();
                reserva.ClienteId = clienteId;
                reserva.HotelId = hotelId;
                reserva.FechaDesde = fechaDesde;
                reserva.FechaHasta = fechaHasta;
                reserva.RegimenCodigo = (int) cmbRegimen.SelectedValue;
                reserva.FechaCreacion = DateTime.Now;
                // TODO: Ver como obtener
                reserva.EstadoId = 1;

                int codigo = ReservaService.Insert(reserva);
                MessageBox.Show("Su codigo de reserva es '" + codigo + "'.");
            }
        }

        private decimal GenerarPrecio()
        {
            DateTime fechaDesde = dateFechaDesde.Value;
            DateTime fechaHasta = dateFechaHasta.Value;            
            decimal diasEstadia = (decimal)(fechaHasta - fechaDesde).TotalDays;
            decimal precio = ((decimal)HotelCargoPorEstrellaService.GetCargo()) * ((Hotel)cmbHotel.SelectedItem).Estrellas * diasEstadia;
            if (cmbRegimen.SelectedItem != null)
            {
                precio += ((TipoHabitacion)cmbTipoHabitacion.SelectedItem).Porcentual * ((Regimen)cmbRegimen.SelectedItem).Precio * diasEstadia;
            }
            return precio;
        }
    }
}
