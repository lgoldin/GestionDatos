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

namespace FrbaHotel.Listado_Estadistico
{
    public partial class ListadoEstadistico : Form
    {
        private IList<int> trimestres = new List<int> { 1, 2, 3, 4 };
        private IList<String> listados = new List<String> { "HotelesReservasCanceladas", "HotelesConsumiblesFacturados", "HotelesFueraDeServicio", "HabitacionDias", "HabitacionCantidad", "ClientePuntos" };

        public IListadoEstadisticoService Service { get; set; }

        public ListadoEstadistico()
        {
            InitializeComponent();
            this.Service = new ListadoEstadisticoService();
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {
            cmbTrimestre.DataSource = trimestres;
            cmbListados.DataSource = listados;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnio.Text))
            {
                MessageBox.Show("Debe especificar un año.");
                return;
            }
            int trimestre = Convert.ToInt32(cmbTrimestre.Text);
            int anio = Convert.ToInt32(txtAnio.Text);
            int mesInicial = (3 * (trimestre - 1)) + 1;
            DateTime fechaDesde = new DateTime(anio, mesInicial, 1);
            DateTime fechaHasta = fechaDesde.AddMonths(3).AddDays(-1);

            string spName = "GetListado" + cmbListados.Text;

            dgvListado.DataSource = this.Service.Get(spName, fechaDesde, fechaHasta);
        }
    }
}
