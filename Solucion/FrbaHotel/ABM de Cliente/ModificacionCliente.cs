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

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class ModificacionCliente : Form
    {
        private int ClienteId { get; set; }
        public ModificacionCliente()
        {
            InitializeComponent();
        }

        public ModificacionCliente(int clienteId)
        {
            InitializeComponent();
            this.ClienteId = clienteId;
        }

        private void ModificacionCliente_Load(object sender, EventArgs e)
        {
            PaisService paisService = new PaisService();
            List<Pais> paises = paisService.GetAll().ToList();
            cmbNacionalidad.DataSource = paises;
            cmbNacionalidad.DisplayMember = "Nacionalidad";
            cmbNacionalidad.ValueMember = "Id";

            TipoDocumentoService tipoDocumentoService = new TipoDocumentoService();
            List<TipoDocumento> documentos = tipoDocumentoService.GetAll().ToList();
            cmbTipoDocumento.DataSource = documentos;
            cmbTipoDocumento.DisplayMember = "Nombre";
            cmbTipoDocumento.ValueMember = "Id";

            ClienteService service = new ClienteService();
            Cliente cliente = service.GetById(this.ClienteId);
            txtApellido.Text = cliente.Apellido;
            txtDireccion.Text = cliente.Direccion;
            txtMail.Text = cliente.Mail;
            txtNombre.Text = cliente.Nombre;
            txtNumeroDocumento.Text = cliente.NumeroDocumento;
            txtTelefono.Text = cliente.Telefono;
            cmbNacionalidad.SelectedValue = cliente.Nacionalidad;
            cmbTipoDocumento.SelectedValue = cliente.TipoDeDocumento.Id;
            chbHabilitado.Checked = cliente.Habilitado;

            dateNacimiento.MaxDate = Session.Fecha;
            dateNacimiento.Value = Session.Fecha;
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            string error = ValidateForm();
            if (string.IsNullOrEmpty(error))
            {
                ClienteService clienteService = new ClienteService();
                int idMail = clienteService.GetByMail(txtMail.Text).Id;
                if (idMail == 0 || idMail == this.ClienteId)
                {
                    Cliente cliente = new Cliente();
                    cliente.Apellido = txtApellido.Text;
                    cliente.Direccion = txtDireccion.Text;
                    cliente.FechaNacimiento = dateNacimiento.Value;
                    cliente.Mail = txtMail.Text;
                    cliente.Nacionalidad = Convert.ToInt32(cmbNacionalidad.SelectedValue);
                    cliente.Nombre = txtNombre.Text;
                    cliente.NumeroDocumento = txtNumeroDocumento.Text;
                    cliente.Telefono = txtTelefono.Text;
                    cliente.TipoDeDocumento = new TipoDocumento();
                    cliente.TipoDeDocumento.Id = Convert.ToInt32(cmbTipoDocumento.SelectedValue);
                    cliente.Habilitado = chbHabilitado.Checked;
                    cliente.Id = this.ClienteId;
                    int idDocumento = clienteService.GetByTipoYNumeroDocumento(cliente.TipoDeDocumento.Id, cliente.NumeroDocumento).Id; 
                    if (idDocumento == 0 || idDocumento == this.ClienteId)
                    {
                        clienteService.Update(cliente);
                        MessageBox.Show("El cliente se ha modificado");
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un usuario con ese número y tipo de documento");
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un usuario con ese mail");
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
            if (Convert.ToInt32(cmbNacionalidad.SelectedValue) == 0)
            {
                errorMessage = "Seleccione una nacionalidad";
            }
            if (Convert.ToInt32(cmbTipoDocumento.SelectedValue) == 0)
            {
                errorMessage += System.Environment.NewLine + "Seleccione un tipo de documento";
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba el apellido";
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba la dirección";
            }
            if (string.IsNullOrEmpty(txtMail.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba el mail";
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba el nombre";
            }
            if (string.IsNullOrEmpty(txtNumeroDocumento.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba el numero de documento";
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                errorMessage += System.Environment.NewLine + "Escriba el teléfono";
            }

            return errorMessage;
        }
        
    }
}
