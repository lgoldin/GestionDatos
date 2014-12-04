using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Entities.Exceptions;
using FrbaHotel.Entities;
using FrbaHotel.Services.Interfaces;
using FrbaHotel.Services;

namespace FrbaHotel.Registrar_Estadia
{
    public partial class RegistrarEstadia : Form
    {
        public RegistrarEstadia()
        {
            InitializeComponent();

            this.EstadiaService = new EstadiaService();
            this.ReservaService = new ReservaService();
        }

        public IEstadiaService EstadiaService { get; set; }

        public IReservaService ReservaService { get; set; }

        private Reserva Reserva { get; set; }

        private Estadia Estadia { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnReserva.Visible = false;

                this.ValidateForm();

                this.Reserva = this.ReservaService.GetReservaByCodigo(Convert.ToInt32(txtCodigoReserva.Text));
                if (this.Reserva != null)
                {
                    this.lblFechaDesde.Text = this.Reserva.FechaDesde.ToShortDateString();
                    this.lblFechaHasta.Text = this.Reserva.FechaHasta.ToShortDateString();
                    this.lblFechaDesde.Visible = true;
                    this.lblFechaHasta.Visible = true;
                    this.label2.Visible = true;
                    this.label3.Visible = true;

                    this.Estadia = this.EstadiaService.GetByCodigoReserva(this.Reserva.Codigo);
                    if (this.Estadia == null)
                    {
                        if (this.Reserva.FechaDesde == Session.Fecha)
                        {
                            this.btnCheckIn.Visible = true;
                            this.btnCheckOut.Visible = false;
                        }
                        else
                        {
                            if (this.Reserva.FechaDesde < Session.Fecha)
                            {
                                this.CancelReservas(this.Reserva);
                                MessageBox.Show("Ha llegado tarde a relizar el check-in. Tanto la reserva actual como las futuras han sido canceladas", "Error", MessageBoxButtons.OK);
                                this.btnReserva.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("La reserva tiene fecha posterior a la actual. Vuelva cuando corresponda", "Error", MessageBoxButtons.OK);
                            }
                        }
                    }
                    else
                    {
                        if (this.Estadia.FechaHasta < this.Estadia.FechaDesde)
                        {
                            this.btnCheckIn.Visible = false;
                            this.btnCheckOut.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Esta reserva ya fue utilizada", "OK", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro ninguna reserva", "Error", MessageBoxButtons.OK);
                }
            }
            catch (FormException formException)
            {
                MessageBox.Show(formException.Message, "Error", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Error", MessageBoxButtons.OK);
            }
        }

        private void CancelReservas(Reserva reserva)
        {
            var codigos = new List<int> { reserva.Codigo };

            IEnumerable<Reserva> reservasPosteriores = this.ReservaService.GetReservasPosteriores(reserva);
            reservasPosteriores.ToList().ForEach(x => codigos.Add(x.Codigo));

            this.ReservaService.Cancelar(codigos, "No show", Session.Usuario, true);
        }

        private void ValidateForm()
        {
            var builder = new StringBuilder();

            if (string.IsNullOrEmpty(txtCodigoReserva.Text))
            {
                builder.AppendLine("Ingrese un codigo de reserva");
            }

            int codigo;
            if (!int.TryParse(txtCodigoReserva.Text, out codigo))
            {
                builder.AppendLine("El codigo de reserva debe ser numerico");
            }

            if (!string.IsNullOrEmpty(builder.ToString()))
            {
                throw new FormException(builder.ToString());
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                this.EstadiaService.Save(new Estadia { CodigoReserva = this.Reserva.Codigo });
                this.Estadia = this.EstadiaService.GetByCodigoReserva(this.Reserva.Codigo);
                MessageBox.Show("El check-in fue exitoso", "Error", MessageBoxButtons.OK);
                this.btnCheckIn.Visible = false;
                this.btnCheckOut.Visible = true;
            }
            catch
            {
                MessageBox.Show("Ocurrio un error", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                this.EstadiaService.Save(this.Estadia);
                MessageBox.Show("El check-out fue exitoso", "Error", MessageBoxButtons.OK);
                GoToFacturacion(this.Estadia.Id);
            }
            catch
            {
                MessageBox.Show("Ocurrio un error", "Error", MessageBoxButtons.OK);
            }
        }

        private void GoToFacturacion(int estadiaId)
        {
            Form form = new Facturacion.Facturacion(estadiaId, this.Reserva.ClienteId);
            DisplayForm(form);
        }

        private void DisplayForm(Form form)
        {
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            var form = new ABM_de_Reserva.AltaReserva(null);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
            form.BringToFront();            
        }
    }
}
