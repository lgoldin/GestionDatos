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

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class ModificacionHotel : Form
    {
        private int hotelId { get; set; }

        public ModificacionHotel()
        {
            InitializeComponent();
        }

        public ModificacionHotel(int hotelId)
        {
            InitializeComponent();
            this.hotelId = hotelId;
        }

        private void ModificacionHotel_Load(object sender, EventArgs e)
        {
            HotelService service = new HotelService();
            Hotel hotel = service.GetById(this.hotelId);
            txtDireccion.Text = hotel.Direccion;
            txtMail.Text = hotel.Mail;
            txtNombre.Text = hotel.Nombre;
            txtTelefono.Text = hotel.Telefono;
            rb1.Checked = hotel.Estrellas == 1;
            rb2.Checked = hotel.Estrellas == 2;
            rb3.Checked = hotel.Estrellas == 3;
            rb4.Checked = hotel.Estrellas == 4;
            rb5.Checked = hotel.Estrellas == 5;
            dateTimePicker1.Value = hotel.FechaCreacion;

            chListRegimenes.Items.Clear();
            RegimenService regimenservice = new RegimenService();

            hotel.Regimenes = regimenservice.GetByHotelId(hotel.Id);

            List<Regimen> regimenes = regimenservice.GetAll().Where(x=>x.Activo).ToList();

                foreach (Regimen r in regimenes)
                {
                    bool esta = false;
                    foreach (Regimen hr in hotel.Regimenes)
                    {
                        if (r.Codigo == hr.Codigo)
                        {
                            esta = true;
                        }
                    }

                    chListRegimenes.Items.Add(r, esta);
                }

                ((ListBox)chListRegimenes).ValueMember = "Codigo";
                ((ListBox)chListRegimenes).DisplayMember = "Descripcion";

                PaisService paisService = new PaisService();
                List<Pais> paises = paisService.GetAll().ToList();
                cmbPaises.DataSource = paises;
                cmbPaises.DisplayMember = "Nombre";
                cmbPaises.ValueMember = "Id";
                cmbPaises.SelectedValue = hotel.Ciudad.Pais.Id;
                cmbCiudades.SelectedValue = hotel.Ciudad.Id;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

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
