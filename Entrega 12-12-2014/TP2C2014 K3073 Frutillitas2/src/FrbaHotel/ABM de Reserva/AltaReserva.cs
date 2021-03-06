﻿using System;
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
        private Reserva Reserva = null;

        public IHotelService HotelService { get; set; }

        public ITipoHabitacionService TipoHabitacionService { get; set; }

        public IRegimenService RegimenService { get; set; }

        public IReservaService ReservaService { get; set; }

        public IHotelCargoPorEstrellaService HotelCargoPorEstrellaService { get; set; }

        public AltaReserva(Reserva reserva)
        {
            InitializeComponent();
            this.HotelService = new HotelService();
            this.TipoHabitacionService = new TipoHabitacionService();
            this.RegimenService = new RegimenService();
            this.ReservaService = new ReservaService();
            this.HotelCargoPorEstrellaService = new HotelCargoPorEstrellaService();
            this.Reserva = reserva;
            if (Reserva != null)
                btnReservar.Text = "Modificar";
            if (Session.Hotel != null)
            {
                lblHotel.Visible = false;
                cmbHotel.Visible = false;
            }

        }

        private void AltaReserva_Load(object sender, EventArgs e)
        {
            cmbHotel.DataSource = this.HotelService.GetAll(null, null, null, null);
            cmbHotel.ValueMember = "Id";
            cmbHotel.DisplayMember = "Nombre";
            cmbHotel.SelectedValue = Reserva == null ? 0 : Reserva.HotelId;

            dateFechaDesde.MinDate = Reserva == null ? Session.Fecha.AddDays(1) : Session.Fecha;
            dateFechaDesde.Value = Reserva == null ? Session.Fecha.AddDays(1) : Reserva.FechaDesde;

            dateFechaHasta.MinDate = Session.Fecha.AddDays(1);
            dateFechaHasta.Value = Reserva == null ? Session.Fecha.AddDays(2) : Reserva.FechaHasta;

            cmbTipoHabitacion.DataSource = this.TipoHabitacionService.GetAll();
            cmbTipoHabitacion.ValueMember = "Codigo";
            cmbTipoHabitacion.DisplayMember = "Descripcion";
            cmbTipoHabitacion.SelectedValue = Reserva == null ? 0 : Reserva.TipoHabitacionCodigo;

            cmbRegimen.DataSource = this.RegimenService.GetAll();
            cmbRegimen.ValueMember = "Codigo";
            cmbRegimen.DisplayMember = "Descripcion";
            cmbRegimen.SelectedValue = Reserva == null ? 0 : Reserva.RegimenCodigo;
        }

        private bool esValidoSinRegimen()
        {
            if (Session.Hotel == null && (int)cmbHotel.SelectedValue == 0)
            {
                MessageBox.Show("Debe especificar un hotel");
                return false;
            }
            if ((int)cmbTipoHabitacion.SelectedValue == 0)
            {
                MessageBox.Show("Debe especificar un tipo de habitación");
                return false;
            }
            return true;
        }

        private bool esValido()
        {
            if (cmbRegimen.SelectedValue == null)
            {
                MessageBox.Show("Debe especificar un regimen");
                return false;
            }
            return esValidoSinRegimen();
        }

        private int getHotelId()
        {
            return Session.Hotel == null ? (int)cmbHotel.SelectedValue : Session.Hotel.Id;
        }

        private void btnDisponibilidad_Click(object sender, EventArgs e)
        {
            if (esValidoSinRegimen())
            {
                int hotelId = getHotelId();
                DateTime fechaDesde = dateFechaDesde.Value;
                DateTime fechaHasta = dateFechaHasta.Value;
                int tipoHabitacionCodigo = (int)cmbTipoHabitacion.SelectedValue;

                if (!ReservaService.IsReservaAvailable(hotelId, fechaDesde, fechaHasta, tipoHabitacionCodigo))
                {
                    MessageBox.Show("No hay disponibilidad para los parametros solicitados");
                }
                else
                {
                    MessageBox.Show("El precio es de " + GenerarPrecio() + " USD");
                }
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (esValido())
            {
                int hotelId = getHotelId();
                DateTime fechaDesde = dateFechaDesde.Value;
                DateTime fechaHasta = dateFechaHasta.Value;
                int tipoHabitacionCodigo = (int)cmbTipoHabitacion.SelectedValue;

                if (!ReservaService.IsReservaAvailable(hotelId, fechaDesde, fechaHasta, tipoHabitacionCodigo))
                {
                    MessageBox.Show("No hay disponibilidad para los parametros solicitados");
                }
                else
                {
                    if (Reserva == null)
                    {
                        ListadoCliente form = new ListadoCliente(false);
                        form.ShowDialog();
                        int clienteId = form.ClienteId;

                        if (clienteId == 0)
                        {
                            MessageBox.Show("Tiene que seleccionar un cliente");
                        }
                        else
                        {
                            Reserva reserva = new Reserva();
                            reserva.ClienteId = clienteId;
                            reserva.HotelId = hotelId;
                            reserva.FechaDesde = fechaDesde;
                            reserva.FechaHasta = fechaHasta;
                            reserva.RegimenCodigo = (int)cmbRegimen.SelectedValue;
                            reserva.FechaCreacion = Session.Fecha;
                            reserva.TipoHabitacionCodigo = tipoHabitacionCodigo;
                            // TODO: Ver como obtener
                            reserva.EstadoId = 1;

                            int codigo = ReservaService.Insert(reserva);
                            MessageBox.Show("Su codigo de reserva es '" + codigo + "'.");
                        }
                    }
                    else
                    {
                        Reserva reserva = new Reserva();
                        reserva.Codigo = Reserva.Codigo;
                        reserva.ClienteId = Reserva.ClienteId;
                        reserva.HotelId = hotelId;
                        reserva.FechaDesde = fechaDesde;
                        reserva.FechaHasta = fechaHasta;
                        reserva.RegimenCodigo = (int)cmbRegimen.SelectedValue;
                        reserva.FechaCreacion = Reserva.FechaCreacion;
                        reserva.TipoHabitacionCodigo = tipoHabitacionCodigo;
                        // TODO: Ver como obtener
                        reserva.EstadoId = 2;

                        ReservaService.Update(reserva);
                        MessageBox.Show("Su reserva ha sido modificada.");
                    }
                    this.Close();
                }
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
