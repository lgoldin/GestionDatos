using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Services;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Entities;
using FrbaHotel.Entities.Exceptions;

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class HabitacionForm : Form
    {
        public HabitacionForm()
        {
            InitializeComponent();

            this.InitializeServices();
        }

        public HabitacionForm(int idHabitacion)
        {
            InitializeComponent();

            this.InitializeServices();

            this.IdHabitacion = idHabitacion;
        }

        public int IdHabitacion { get; set; }

        public IHotelService HotelService { get; set; }

        public IHabitacionService HabitacionService { get; set; }

        public ITipoHabitacionService TipoHabitacionService { get; set; }

        private void HabitacionForm_Load(object sender, EventArgs e)
        {
            Habitacion habitacion = null;
            if (this.IdHabitacion > 0)
            {
                habitacion = this.HabitacionService.Get(this.IdHabitacion);
            }

            this.FillHoteles(habitacion);
            this.FillTipoHabitaciones(habitacion);
            this.FillOtherFields(habitacion);
        }

        private void FillOtherFields(Habitacion habitacion)
        {
            if (habitacion != null)
            {
                this.chkFrente.Checked = habitacion.Frente;
                this.chkActiva.Checked = habitacion.Activa;
                this.txtNumero.Text = habitacion.Numero;
                this.txtPiso.Text = habitacion.Piso;
                this.txtDescripcion.Text = habitacion.Descripcion;
            }
        }

        private void FillHoteles(Habitacion habitacion)
        {
            cmbHotel.DataSource = this.HotelService.GetAll(null, null, null, null);
            cmbHotel.ValueMember = "Id";
            cmbHotel.DisplayMember = "Nombre";
            cmbHotel.SelectedValue = habitacion != null ? habitacion.Hotel.Id : 0;
        }

        private void FillTipoHabitaciones(Habitacion habitacion)
        {
            cmbTipoHabitacion.DataSource = this.TipoHabitacionService.GetAll();
            cmbTipoHabitacion.ValueMember = "Codigo";
            cmbTipoHabitacion.DisplayMember = "Descripcion";
            cmbTipoHabitacion.SelectedValue = habitacion != null ? habitacion.TipoHabitacion.Codigo : 0;
        }

        private void InitializeServices()
        {
            this.HotelService = new HotelService();
            this.HabitacionService = new HabitacionService();
            this.TipoHabitacionService = new TipoHabitacionService();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateForm();
                int idHabitacion = this.HabitacionService.Save(this.GetHabitacion());

                MessageBox.Show("El usuario fue guardado correctamente", "Success", MessageBoxButtons.OK);
            }
            catch (FormException formException)
            {
                MessageBox.Show(formException.Message, "Error", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Ocurrio un error", "Error", MessageBoxButtons.OK);
            }
        }

        private Habitacion GetHabitacion()
        {
            return new Habitacion
                        {
                            Activa = this.chkActiva.Checked,
                            Descripcion = this.txtDescripcion.Text,
                            Frente = this.chkFrente.Checked,
                            Hotel = new Hotel { Id = (int)cmbHotel.SelectedValue },
                            Id = this.IdHabitacion,
                            Numero = txtNumero.Text,
                            Piso = txtPiso.Text,
                            TipoHabitacion = new TipoHabitacion { Codigo = (int)cmbTipoHabitacion.SelectedValue }
                        };
        }

        private void ValidateForm()
        {
            var builder = new StringBuilder(string.Empty);

            if (cmbHotel.SelectedValue.ToString() == "0")
            {
                builder.AppendLine("Seleccione un Hotel");
            }

            if (cmbTipoHabitacion.SelectedValue.ToString() == "0")
            {
                builder.AppendLine("Seleccione un Tipo de Habitacion");
            }

            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                builder.AppendLine("Ingrese un numero");
            }

            if (string.IsNullOrEmpty(txtPiso.Text))
            {
                builder.AppendLine("Ingrese un piso");
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                builder.AppendLine("Ingrese una descripcion");
            }

            if (!string.IsNullOrEmpty(builder.ToString()))
            {
                throw new FormException(builder.ToString());
            }
        }
    }
}
