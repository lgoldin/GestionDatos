using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Entities;
using FrbaHotel.Services;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class BajaHotel : Form
    {
        private int hotelId { get; set; }
        private string hotelName { get; set; }

        public BajaHotel()
        {
            InitializeComponent();
        }

        public BajaHotel(int hotelId, string hotelName)
        {
            InitializeComponent();
            this.hotelId = hotelId;
            this.hotelName = hotelName;
        }

        private void BajaHotel_Load(object sender, EventArgs e)
        {
            lblNombre.Text = this.hotelName;
            dateDesde.MinDate = DateTime.Now;
            dateHasta.MinDate = DateTime.Now;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string error = ValidateForm();
            if (string.IsNullOrEmpty(error))
            {
                try
                {
                    HotelInhabilitacion hotelInhabilitado = new HotelInhabilitacion();
                    hotelInhabilitado.FechaCreacion = DateTime.Now;
                    hotelInhabilitado.FechaInicio = dateDesde.Value;
                    hotelInhabilitado.FechaFin = dateHasta.Value;
                    hotelInhabilitado.Descripcion = txtDescripcion.Text;
                    hotelInhabilitado.HotelId = this.hotelId;

                    ReservaService reservaService = new ReservaService();
                    if (reservaService.GetCountActiveReservaBetweenDatesByHotelId(hotelInhabilitado.HotelId, hotelInhabilitado.FechaInicio, hotelInhabilitado.FechaFin) == 0)
                    {
                        HotelService hotelService = new HotelService();
                        hotelService.InsertHotelInhabilitado(hotelInhabilitado);
                        MessageBox.Show("El hotel se ha inhabilitado.");
                    }
                    else
                    {
                        MessageBox.Show("El hotel no puede ser inhabilitado ya que posee reservas en esas fechas");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error, no se ha podido inhabilitar el hotel.");
                }
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        private string ValidateForm()
        {
            string errorMessage = string.Empty;
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                errorMessage += "Escriba una descripción";
            }
            if (dateDesde.Value > dateHasta.Value)
            {
                errorMessage += System.Environment.NewLine + "La fecha Hasta debe ser posterior a la fecha Desde";
            }
            
            return errorMessage;
        }
    }
}
