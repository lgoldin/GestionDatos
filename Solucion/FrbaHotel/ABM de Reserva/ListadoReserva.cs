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
using FrbaHotel.Entities.DTOs;

namespace FrbaHotel.ABM_de_Reserva
{
    public partial class ListadoReserva : Form
    {
        public IReservaService ReservaService { get; set; }

        public ListadoReserva()
        {
            InitializeComponent();

            ReservaService = new ReservaService();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = string.Empty;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvReserva.DataSource = null;
            string codigo = txtCodigo.Text;
            if (!string.IsNullOrEmpty(codigo))
            {
                ReservaDTO reserva = ReservaService.GetReservaByCodigo(Convert.ToInt32(codigo));
                if (reserva != null)
                {
                    dgvReserva.DataSource = new List<ReservaDTO> { reserva };
                }
            }
        }
    }
}
