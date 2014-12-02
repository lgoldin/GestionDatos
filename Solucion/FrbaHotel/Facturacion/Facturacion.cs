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
            EstadiaService estadiaService = new EstadiaService();
            Estadia estadia = estadiaService.GetById(Convert.ToInt32(txtNroEstadia.Text));
            ReservaService reservaService = new ReservaService();
            Reserva reserva = reservaService.GetReservaByCodigo(estadia.CodigoReserva);
            List<DateTime> reservaUseDates = new List<DateTime>();
            List<DateTime> reservaNotUseDates = new List<DateTime>();

            DateTime reservaDate = reserva.FechaDesde.Date;
            while (reservaDate <= estadia.FechaHasta.Date)
            {
                reservaUseDates.Add(reservaDate);
                reservaDate = reservaDate.AddDays(1);
            }

            while (reservaDate <= reserva.FechaHasta)
            {
                reservaNotUseDates.Add(reservaDate);
                reservaDate = reservaDate.AddDays(1);
            }

        }
    }
}
