using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Services;
using FrbaHotel.Entities;

namespace FrbaHotel.ABM_de_Reserva
{
    public partial class CancelacionReserva : Form
    {
        public IReservaService ReservaService { get; set; }

        public CancelacionReserva()
        {
            InitializeComponent();
            ReservaService = new ReservaService();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Reserva reserva = null;
            string codigo = txtCodigo.Text;
            if (!string.IsNullOrEmpty(codigo))
            {
                reserva = ReservaService.GetReservaByCodigo(Convert.ToInt32(codigo));
                if (reserva == null)
                {
                    MessageBox.Show("No se ha encontrado la reserva");
                    return;
                }
            }
            string motivo = txtMotivo.Text;
            if (string.IsNullOrEmpty(motivo))
                MessageBox.Show("Debe poner un motivo.");
            else
            {
                ReservaService.Cancelar(new List<int> { reserva.Codigo }, motivo, Session.Usuario, false);
                MessageBox.Show("La reserva '" + reserva.Codigo + "' ha sido cancelada correctamente.");
            }
        }
    }
}
