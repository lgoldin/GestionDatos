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

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class ListadoCliente : Form
    {
        private bool IsForUpdate = true;
        public int ClienteId = 0;

        public ListadoCliente(bool isForUpdate)
        {
            InitializeComponent();
            this.IsForUpdate = isForUpdate;
            if (!IsForUpdate)
            {
                DataGridViewButtonColumn column = (DataGridViewButtonColumn) dgClientes.Columns[0];
                column.Text = "Seleccionar";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ABM_de_Cliente.AltaCliente form = new ABM_de_Cliente.AltaCliente();
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

        private void ListadoCliente_Load(object sender, EventArgs e)
        {
            TipoDocumentoService tipoDocumentoService = new TipoDocumentoService();
            List<TipoDocumento> documentos = tipoDocumentoService.GetAll().ToList();
            cmbTipoDocumento.DataSource = documentos;
            cmbTipoDocumento.DisplayMember = "Nombre";
            cmbTipoDocumento.ValueMember = "Id";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgClientes.DataSource = null;
            int? tipoDocumentoId = null;
            string nombre = !string.IsNullOrEmpty(txtNombre.Text) ? txtNombre.Text : null;
            string apellido = !string.IsNullOrEmpty(txtApellido.Text) ? txtApellido.Text : null;
            string mail = !string.IsNullOrEmpty(txtEmail.Text) ? txtEmail.Text : null;
            string numeroDocumento = !string.IsNullOrEmpty(txtnroIdentificacion.Text) ? txtnroIdentificacion.Text : null;
            

            ClienteService service = new ClienteService();
            if (Convert.ToInt32(cmbTipoDocumento.SelectedValue) > 0)
            {
                tipoDocumentoId = Convert.ToInt32(cmbTipoDocumento.SelectedValue);
            }
            
            List<ClienteDTO> clientes = service.GetAllDTO(nombre, apellido, mail, numeroDocumento, tipoDocumentoId).Where(x => x.Id != 0).ToList();
            dgClientes.DataSource = clientes;
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgClientes.DataSource = null;
            txtnroIdentificacion.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtApellido.Text = string.Empty;
            cmbTipoDocumento.SelectedValue = 0;
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int clienteId = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["Id"].Value);
                ClienteId = clienteId;
                if (IsForUpdate)
                {
                    Form form = new ABM_de_Cliente.ModificacionCliente(clienteId);

                    form.Location = this.Location;
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.FormClosing += delegate { this.Show(); };
                    form.Show();
                    this.Hide();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void txtnroIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnroIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
