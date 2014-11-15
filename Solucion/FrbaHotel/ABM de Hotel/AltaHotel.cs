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
            PaisService paisService = new PaisService();
            List<Pais> paises = paisService.GetAll().ToList();
            cmbPaises.DataSource = paises;
            cmbPaises.DisplayMember = "Nombre";
            cmbPaises.ValueMember = "Id";

            RegimenService regimenService = new RegimenService();
            List<Regimen> regimenes = regimenService.GetAll().Where(x=>x.Activo).ToList();
            ((ListBox)chListRegimenes).DataSource = regimenService.GetAll();
            ((ListBox)chListRegimenes).ValueMember = "Codigo";
            ((ListBox)chListRegimenes).DisplayMember = "Descripcion";

            rb1.Checked = true;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string error = ValidateForm();
            if (string.IsNullOrEmpty(error))
            {
                try
                {
                    Hotel hotel = new Hotel();
                    hotel.Ciudad = (Ciudad)cmbCiudades.SelectedItem;
                    hotel.Direccion = txtDireccion.Text;
                    hotel.Estrellas = GetEstrellas();
                    hotel.FechaCreacion = dateTimePicker1.Value;
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

                    HotelService service = new HotelService();
                    service.Insert(hotel);
                    MessageBox.Show("El hotel se ha creado correctamente");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al crear el hotel");
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
            if (cmbCiudades.SelectedValue == null)
            {
                errorMessage = "Seleccione una ciudad";
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
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba el telefono";
            }
            return errorMessage;
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

        private void AltaHotel_Load(object sender, EventArgs e)
        {

        }

        private void cmbCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCiudad_Click(object sender, EventArgs e)
        {

        }

        private void lblPais_Click(object sender, EventArgs e)
        {

        }
    }
}
