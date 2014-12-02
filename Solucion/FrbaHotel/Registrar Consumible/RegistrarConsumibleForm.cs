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

namespace FrbaHotel.Registrar_Consumible
{
    public partial class RegistrarConsumibleForm : Form
    {
        private List<ComboBox> comboBoxes = new List<ComboBox>();
        
        public RegistrarConsumibleForm()
        {
            InitializeComponent();

            this.EstadiaService = new EstadiaService();
            this.ConsumibleService = new ConsumibleService();
        }

        public IEstadiaService EstadiaService { get; set; }

        public IConsumibleService ConsumibleService { get; set; }

        private Estadia Estadia { get; set; }

        public IList<Consumible> Consumibles { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateForm();
                this.Estadia = this.EstadiaService.GetByCodigoReserva(Convert.ToInt32(this.txtCodigoReserva.Text));

                if (this.Estadia != null)
                {
                    this.dgvConsumible.AutoGenerateColumns = false;
                    this.Consumibles = this.ConsumibleService.GetByIdEstadia(this.Estadia.Id).ToList();
                    if (this.Consumibles.Count() > 0)
                    {
                        this.dgvConsumible.DataSource = this.GetConsumiblesDTO(this.Consumibles);
                        this.dgvConsumible.Enabled = false;
                        this.btnAgregar.Enabled = false;
                        this.btnFinalizar.Enabled = false;
                    }
                    else
                    {
                        this.Consumibles = new List<Consumible>();
                        this.dgvConsumible.DataSource = null;
                        this.dgvConsumible.Enabled = true;
                        this.btnAgregar.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro ninguna estadia para la reserva", "Error", MessageBoxButtons.OK);
                }
            }
            catch (FormatException formException)
            {
                MessageBox.Show(formException.Message, "Error", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Ocurrio un error", "Error", MessageBoxButtons.OK);
            }
        }

        private IEnumerable<ConsumibleDTO> GetConsumiblesDTO(IEnumerable<Consumible> consumibles)
        {
            var consumiblesDTO = new List<ConsumibleDTO>();

            foreach (Consumible consumible in consumibles)
            {
                consumiblesDTO.Add(new ConsumibleDTO
                                        {
                                            Codigo = consumible.Codigo,
                                            Descripcion = consumible.Descripcion,
                                            Precio = consumible.Precio,
                                            Eliminar = "Eliminar"
                                        });
            }

            return consumiblesDTO;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var form = new AgregarConsumibleForm(this);
            this.DisplayForm(form);
        }

        private void DisplayForm(Form form)
        {
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.ShowDialog();
        }

        private void RegistrarConsumibleForm_Load(object sender, EventArgs e)
        {
        }

        internal void RefreshGrid()
        {
            this.dgvConsumible.AutoGenerateColumns = false;
            this.dgvConsumible.DataSource = this.GetConsumiblesDTO(this.Consumibles);
            this.btnFinalizar.Enabled = this.Consumibles.Count() > 0 ? true : false;
        }

        private void dgvConsumible_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = this.dgvConsumible.Rows[e.RowIndex];
                this.Consumibles.Remove(this.Consumibles.ElementAt(e.RowIndex));
                this.RefreshGrid();
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.EstadiaService.RegistrarConsumibles(this.Consumibles, this.Estadia.Id);
                MessageBox.Show("Se han registrado los consumibles correctamente", "OK", MessageBoxButtons.OK);
                this.btnAgregar.Enabled = false;
                this.btnFinalizar.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Ocurrio un error", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
