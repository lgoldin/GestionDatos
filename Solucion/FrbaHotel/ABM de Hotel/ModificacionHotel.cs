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
            string error = ValidateForm();
            if (string.IsNullOrEmpty(error))
            {
                try
                {
                    Hotel hotel = new Hotel();
                    hotel.Id = this.hotelId;
                    hotel.Ciudad = (Ciudad)cmbCiudades.SelectedItem;
                    hotel.Direccion = txtDireccion.Text;
                    hotel.Estrellas = GetEstrellas();
                    hotel.Mail = txtMail.Text;
                    hotel.Nombre = txtNombre.Text;
                    hotel.Telefono = txtTelefono.Text;

                    hotel.Regimenes = new List<Regimen>();
                    for (int i = 0; i < chListRegimenes.Items.Count; i++)
                    {
                        if (chListRegimenes.GetItemChecked(i))
                        {
                            Regimen regimen = (Regimen)chListRegimenes.Items[i];
                            hotel.Regimenes.Add(regimen);
                        }
                    }

                    ReservaService reservaService = new ReservaService();
                    List<Regimen> regimenes = reservaService.GetActiveReservaRegimenesByHotelId(this.hotelId);

                    string message = string.Empty;
                    foreach (Regimen regimen in regimenes)
                    {
                        if (!hotel.Regimenes.Any(x => x.Codigo == regimen.Codigo))
                        {
                            message += "No puede eliminar el regimen " + regimen.Descripcion + System.Environment.NewLine;
                        }
                    }

                    if (!string.IsNullOrEmpty(message))
                    {
                        message += "tiene reservas asignadas.";
                        MessageBox.Show(message);
                    }
                    else
                    {
                        HotelService hotelService = new HotelService();
                        hotelService.Update(hotel);
                        MessageBox.Show("El hotel se ha modificado correctamente");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al modificar el hotel");
                }
            }
            else
            {
                MessageBox.Show(error);
            }
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

        private string ValidateForm()
        {
            string errorMessage = string.Empty;
            if (cmbCiudades.SelectedValue == null)
            {
                errorMessage += "Seleccione una ciudad";
            }
            if (cmbPaises.SelectedValue == null)
            {
                errorMessage += System.Environment.NewLine + "Seleccione un país";
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba la dirección";
            }
            if (string.IsNullOrEmpty(txtMail.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba el mail";
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba el telefono";
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba el nombre";
            }
            
            return errorMessage;
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
