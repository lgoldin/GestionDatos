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
    public partial class AltaHotel: Form
    {
        public AltaHotel()
        {
            InitializeComponent();
            PaisService service = new PaisService();
            List<Pais> paises = service.GetAll().ToList();
            cmbPaises.DataSource = paises;
            cmbPaises.DisplayMember = "Nombre";
            cmbPaises.ValueMember = "Id";
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtFecha.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel();
            hotel.Ciudad = (Ciudad)cmbCiudades.SelectedItem;
            hotel.Direccion = txtDireccion.Text;
            hotel.Estrellas = GetEstrellas();
            hotel.FechaCreacion = monthCalendar1.SelectionStart;
            hotel.Mail = txtMail.Text;
            hotel.Nombre = txtNombre.Text;

            HotelService service = new HotelService();
            service.Insert(hotel);
        }

        private int GetEstrellas()
        {
            if (rb1.Checked)
                return 1;

            if (rb2.Checked)
                return 2;

            if (rb3.Checked)
                return 3;

            if (rb4.Checked)
            {
                return 4;
            }
            else
            {
                return 5;
            }   
        }

        private void cmbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCiudades.DataSource = null;
            
            if (((Pais)cmbPaises.SelectedItem).Id != 0)
            {
                PaisService service = new PaisService();
                List<Ciudad> ciudades = service.GetCiudades((Pais)cmbPaises.SelectedItem);
                cmbCiudades.DataSource = ciudades;
                cmbCiudades.DisplayMember = "Nombre";
                cmbCiudades.ValueMember = "Id";
            }
        }
    }
}
