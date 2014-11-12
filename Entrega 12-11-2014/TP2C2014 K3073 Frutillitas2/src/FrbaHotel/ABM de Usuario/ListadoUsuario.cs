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

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class ListadoUsuario : Form
    {
        public ListadoUsuario()
        {
            InitializeComponent();

            this.InitializeServices();
        }

        public IUsuarioService UsuarioService { get; set; }

        public IRolService RolService { get; set; }

        public ITipoDocumentoService TipoDocumentoService { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string username = string.IsNullOrEmpty(txtUsername.Text) ? null : txtUsername.Text;
            string nombre = string.IsNullOrEmpty(txtNombre.Text) ? null : txtNombre.Text;
            string apellido = string.IsNullOrEmpty(txtApellido.Text) ? null : txtApellido.Text;
            int? rolId = (int)cmbRol.SelectedValue <= 0 ? (int?)null : (int)cmbRol.SelectedValue;
            int? tipoDocumentoId = (int)cmbTipoDocumento.SelectedValue <= 0 ? (int?)null : (int)cmbTipoDocumento.SelectedValue;
            string numeroDocumento = string.IsNullOrEmpty(txtNumeroDocumento.Text) ? null : txtNumeroDocumento.Text;
            string mail = string.IsNullOrEmpty(txtMail.Text) ? null : txtMail.Text;
            string telefono = string.IsNullOrEmpty(txtTelefono.Text) ? null : txtTelefono.Text;
            string direccion = string.IsNullOrEmpty(txtDireccion.Text) ? null : txtDireccion.Text;
            DateTime? fechaNacimiento = string.IsNullOrEmpty(txtFechaNacimiento.Text) ? (DateTime?)null : Convert.ToDateTime(txtFechaNacimiento.Text);
            
            IEnumerable<Usuario> usuarios = this.UsuarioService.GetAll(username, nombre, apellido, tipoDocumentoId, numeroDocumento, mail, telefono, direccion, fechaNacimiento, rolId);
            dgvUsuario.DataSource = usuarios;
        }

        private void btnSelecionarFecha_Click(object sender, EventArgs e)
        {

        }

        private void InitializeServices()
        {
            this.RolService = new RolService();
            this.TipoDocumentoService = new TipoDocumentoService();
            this.UsuarioService = new UsuarioService();
        }

        private void FillRoles()
        {
            cmbRol.DataSource = this.RolService.GetAll();
            cmbRol.ValueMember = "Id";
            cmbRol.DisplayMember = "Nombre";
            cmbRol.SelectedValue = 0;
        }

        private void FillTipoDocumentos()
        {
            cmbTipoDocumento.DataSource = this.TipoDocumentoService.GetAll();
            cmbTipoDocumento.ValueMember = "Id";
            cmbTipoDocumento.DisplayMember = "Nombre";
            cmbTipoDocumento.SelectedValue = 0;
        }

        private void ListadoUsuario_Load(object sender, EventArgs e)
        {
            this.FillRoles();
            this.FillTipoDocumentos();
        }
    }
}
