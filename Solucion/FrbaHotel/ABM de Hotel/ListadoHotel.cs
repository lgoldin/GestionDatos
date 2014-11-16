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
using FrbaHotel.Entities.DTOs;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class ListadoHotel : Form
    {
        private bool isUpdate { get; set; }

        public ListadoHotel()
        {
            InitializeComponent();
        }

        public ListadoHotel(bool isUpdate)
        {
            InitializeComponent();
            this.isUpdate = isUpdate;
        }

        private void ListadoHotel_Load(object sender, EventArgs e)
        {
            PaisService paisService = new PaisService();
            List<Pais> paises = paisService.GetAll().ToList();
            cmbPaises.DataSource = paises;
            cmbPaises.DisplayMember = "Nombre";
            cmbPaises.ValueMember = "Id";

            CiudadService ciudadService = new CiudadService();
            List<Ciudad> ciudades = ciudadService.GetAll().ToList();
            cmbCiudades.DataSource = ciudades;
            cmbCiudades.DisplayMember = "Nombre";
            cmbCiudades.ValueMember = "Id";

            List<object> estrellas = new List<object>();
            estrellas.Add(new { text = "-No especificado-", value = 0 });
            estrellas.Add(new { text = "1", value = 1 });
            estrellas.Add(new { text = "2", value = 2 });
            estrellas.Add(new { text = "3", value = 3 });
            estrellas.Add(new { text = "4", value = 4 });
            estrellas.Add(new { text = "5", value = 5 });
            cmbEstrellas.DataSource = estrellas;
            cmbEstrellas.DisplayMember = "text";
            cmbEstrellas.ValueMember = "value";

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int? estrellas = null;
            int? ciudad = null;
            int? pais = null;
            string nombre = !string.IsNullOrEmpty(txtNombre.Text) ? txtNombre.Text : null;

            HotelService service = new HotelService();
            if(Convert.ToInt32(cmbEstrellas.SelectedValue) > 0)
            {
                estrellas  = Convert.ToInt32(cmbEstrellas.SelectedValue);
            }
            if(Convert.ToInt32(cmbPaises.SelectedValue) != 0)
            {
                pais = Convert.ToInt32(cmbPaises.SelectedValue);
            }
            if(Convert.ToInt32(cmbCiudades.SelectedValue) != 0)
            {
                ciudad = Convert.ToInt32(cmbCiudades.SelectedValue);    
            }

            dgHoteles.AutoGenerateColumns = false;
            List<HotelDTO> hoteles = service.GetAllDTO(nombre, estrellas, pais, ciudad).Where(x => x.Id != 0).ToList();
            dgHoteles.DataSource = hoteles;
            
        }

        private void dgHoteles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Form form = this.isUpdate ? new ABM_de_Hotel.ModificacionHotel(Convert.ToInt32(grid.Rows[e.RowIndex].Cells[1].Value)) : null;
                form.Location = this.Location;
                form.StartPosition = FormStartPosition.Manual;
                form.FormClosing += delegate { this.Show(); };
                form.Show();
                this.Hide();
            }
        }
    }
}
