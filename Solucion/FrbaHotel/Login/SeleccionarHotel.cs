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

namespace FrbaHotel.Login
{
    public partial class SeleccionarHotel : Form
    {
        public SeleccionarHotel()
        {
            InitializeComponent();

            this.HotelService = new HotelService();
        }

        public IHotelService HotelService { get; set; }

        public IEnumerable<Hotel> Hoteles { get; set; }

        private void SeleccionarHotel_Load(object sender, EventArgs e)
        {
            this.Hoteles = this.HotelService.GetByIdUsuario(Session.Usuario.Id);
            cmbHotel.DataSource = this.Hoteles;
            cmbHotel.ValueMember = "Id";
            cmbHotel.DisplayMember = "Nombre";
            cmbHotel.SelectedValue = 0;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (cmbHotel.SelectedValue == null|| (int)cmbHotel.SelectedValue == 0)
            {
                MessageBox.Show("Seleccione un hotel", "Error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("El hotel ha sido seleccionado correctamente", "OK", MessageBoxButtons.OK);

                Session.Hotel = this.Hoteles.First(x => x.Id == (int)cmbHotel.SelectedValue);

                DisplayForm(new Index());
            }
        }

        private void DisplayForm(Form form)
        {
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }
    }
}
