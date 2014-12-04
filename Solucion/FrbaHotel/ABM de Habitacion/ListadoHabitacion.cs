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

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class ListadoHabitacion : Form
    {
        public ListadoHabitacion()
        {
            InitializeComponent();

            this.InitializeServices();
        }

        public IHotelService HotelService { get; set; }

        public IHabitacionService HabitacionService { get; set; }

        public ITipoHabitacionService TipoHabitacionService { get; set; }

        private void ListadoHabitacion_Load(object sender, EventArgs e)
        {
            cmbHotel.DataSource = this.HotelService.GetAll(null, null, null, null);
            cmbHotel.ValueMember = "Id";
            cmbHotel.DisplayMember = "Nombre";
            cmbHotel.SelectedValue = 0;

            cmbTipoHabitacion.DataSource = this.TipoHabitacionService.GetAll();
            cmbTipoHabitacion.ValueMember = "Codigo";
            cmbTipoHabitacion.DisplayMember = "Descripcion";
            cmbHotel.SelectedValue = 0;
        }

        private void InitializeServices()
        {
            this.HotelService = new HotelService();
            this.HabitacionService = new HabitacionService();
            this.TipoHabitacionService = new TipoHabitacionService();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int? hotelId = (int)cmbHotel.SelectedValue <= 0 ? (int?)null : (int)cmbHotel.SelectedValue;
            int? tipoHabitacion = (int)cmbTipoHabitacion.SelectedValue <= 0 ? (int?)null : (int)cmbTipoHabitacion.SelectedValue;
            int? numero = string.IsNullOrEmpty(txtNumero.Text) ? (int?)null : Convert.ToInt32(txtNumero.Text);
            int? piso = string.IsNullOrEmpty(txtPiso.Text) ? (int?)null : Convert.ToInt32(txtPiso.Text);
            bool frente = chkFrente.Checked;
            string descripcion = string.IsNullOrEmpty(txtDescripcion.Text) ? null : txtDescripcion.Text;
            bool activa = chkActiva.Checked;

            IEnumerable<HabitacionDTO> habitaciones = this.HabitacionService.GetAll(frente, numero, piso, descripcion, hotelId, tipoHabitacion, activa);
            dvgHabitacion.AutoGenerateColumns = false;
            dvgHabitacion.DataSource = habitaciones;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbHotel.SelectedValue = 0;
            cmbTipoHabitacion.SelectedValue = 0;
            txtNumero.Text = string.Empty;
            txtPiso.Text = string.Empty;
            chkFrente.Checked = false;
            txtDescripcion.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var form = new HabitacionForm();
            this.DisplayForm(form);
        }

        private void DisplayForm(Form form)
        {
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void dvgHabitacion_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = dvgHabitacion.Rows[e.RowIndex];
                DataGridViewCell cell = row.Cells["Codigo"];
                var form = new HabitacionForm((int)cell.Value);
                this.DisplayForm(form);
            }
        }
    }
}
