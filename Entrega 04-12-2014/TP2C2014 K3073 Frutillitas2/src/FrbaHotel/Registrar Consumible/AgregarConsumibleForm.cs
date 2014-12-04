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

namespace FrbaHotel.Registrar_Consumible
{
    public partial class AgregarConsumibleForm : Form
    {
        public AgregarConsumibleForm(RegistrarConsumibleForm form)
        {
            InitializeComponent();

            this.ConsumibleService = new ConsumibleService();
            this.Form = form;
        }

        private RegistrarConsumibleForm Form { get; set; }

        private IEnumerable<Consumible> Consumibles { get; set; }

        public IConsumibleService ConsumibleService { get; set; }

        private void AgregarConsumibleForm_Load(object sender, EventArgs e)
        {
            this.Consumibles = this.ConsumibleService.GetAll();
            this.cmbConsumible.DataSource = this.Consumibles;
            this.cmbConsumible.ValueMember = "Codigo";
            this.cmbConsumible.DisplayMember = "Descripcion";
            this.cmbConsumible.SelectedValue = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ((int)this.cmbConsumible.SelectedValue != 0)
            {
                Consumible consumible = this.Consumibles.First(x => x.Codigo == (int)this.cmbConsumible.SelectedValue);
                this.Form.Consumibles.Add(consumible);
                this.Form.RefreshGrid();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un consumible", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
