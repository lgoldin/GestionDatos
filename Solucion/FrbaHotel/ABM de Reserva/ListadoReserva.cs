﻿using System;
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
    public partial class ListadoReserva : Form
    {
        public IReservaService ReservaService { get; set; }

        public IHotelService HotelService { get; set; }

        public IRegimenService RegimenService { get; set; }

        public ITipoHabitacionService TipoHabitacionService { get; set; }

        public ListadoReserva()
        {
            InitializeComponent();

            ReservaService = new ReservaService();
            HotelService = new HotelService();
            RegimenService = new RegimenService();
            TipoHabitacionService = new TipoHabitacionService();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = string.Empty;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            if (!string.IsNullOrEmpty(codigo))
            {
                Reserva reserva = ReservaService.GetReservaByCodigo(Convert.ToInt32(codigo));
                if (reserva != null)
                {
                    lblHotel.Text = HotelService.GetById(reserva.HotelId).Nombre;
                    lblFechaDesde.Text = reserva.FechaDesde.ToShortDateString();
                    lblFechaHasta.Text = reserva.FechaHasta.ToShortDateString();
                    //lblRegimen.Text = RegimenService.GetAll
                    lblTipoHabitacion.Text = TipoHabitacionService.GetByCodigo(reserva.TipoHabitacionCodigo).Descripcion;
                }
                else
                {
                    MessageBox.Show("No se ha encontrado la reserva");
                }
            }
        }

        private void dgvReserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int codigo = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["Codigo"].Value);
                AltaReserva form = new AltaReserva(ReservaService.GetReservaByCodigo(codigo));
            }
        }
    }
}
