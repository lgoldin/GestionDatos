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
using FrbaHotel.Entities.Exceptions;

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();

            this.InitializeServices();
        }

        public UsuarioForm(int idUsuario)
        {
            InitializeComponent();

            this.InitializeServices();

            this.IdUsuario = idUsuario;
        }

        public int IdUsuario { get; set; }

        public IRolService RolService { get; set; }

        public IHotelService HotelService { get; set; }

        public IUsuarioService UsuarioService { get; set; }

        public ITipoDocumentoService TipoDocumentoService { get; set; }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            dtpFechaNacimiento.Value = DateTime.Today;

            Usuario usuario = null;
            if (this.IdUsuario > 0)
            {
                usuario = this.UsuarioService.Get(this.IdUsuario);
            }

            this.FillRoles(usuario);
            this.FillTipoDocumentos(usuario);
            this.FillHoteles(usuario);
        }

        private void InitializeServices()
        {
            this.RolService = new RolService();
            this.TipoDocumentoService = new TipoDocumentoService();
            this.HotelService = new HotelService();
            this.UsuarioService = new UsuarioService();
        }

        private void FillTipoDocumentos(Usuario usuario)
        {
            cmbTipoDocumento.DataSource = this.TipoDocumentoService.GetAll();
            cmbTipoDocumento.ValueMember = "Id";
            cmbTipoDocumento.DisplayMember = "Nombre";
            cmbTipoDocumento.SelectedValue = usuario != null ? usuario.TipoDocumento.Id : 0;
        }

        private void FillHoteles(Usuario usuario)
        {
            lstHotel.DataSource = this.HotelService.GetAll();
            lstHotel.ValueMember = "Id";
            lstHotel.DisplayMember = "Nombre";
            if (usuario != null && usuario.Hoteles != null && usuario.Hoteles.Count > 0)
            {
                usuario.Hoteles.ForEach(x => lstHotel.SetItemChecked(x.Id, true));
            }
        }

        private void FillRoles(Usuario usuario)
        {
            cmbRol.DataSource = this.RolService.GetAll();
            cmbRol.ValueMember = "Id";
            cmbRol.DisplayMember = "Nombre";
            cmbRol.SelectedValue = usuario != null ? usuario.Rol.Id : 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidateForm();
                int idUsuario = this.UsuarioService.Save(this.GetUsuario());
                
                MessageBox.Show("El usuario fue guardado correctamente", "Success", MessageBoxButtons.OK);
                
                var form = new UsuarioForm(idUsuario);
                form.Location = this.Location;
                form.StartPosition = FormStartPosition.Manual;
                form.FormClosing += delegate { this.Show(); };
                form.Show();
                this.Hide();
            }
            catch (FormException formException)
            {
                MessageBox.Show(formException.Message, "Error", MessageBoxButtons.OK);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void ValidateForm()
        {
            if (lstHotel.CheckedItems.Count == 0)
            {
                throw new FormException("Seleccione al menos un hotel");
            }

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                throw new FormException("Ingrese un username");
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                throw new FormException("Ingrese una password");
            }

            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                throw new FormException("Tiene que confirmar la password");
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                throw new FormException("Verifique la password ingresada");
            }

            if (cmbRol.SelectedValue.ToString() == "0")
            {
                throw new FormException("Seleccione un rol");
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                throw new FormException("Ingrese un nombre");
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                throw new FormException("Ingrese un apellido");
            }

            if (cmbTipoDocumento.SelectedValue.ToString() == "0")
            {
                throw new FormException("Seleccione un tipo de documento");
            }

            if (string.IsNullOrEmpty(txtNumeroDocumento.Text))
            {
                throw new FormException("Ingrese un numero de documento");
            }

            if (string.IsNullOrEmpty(txtMail.Text))
            {
                throw new FormException("Ingrese un mail");
            }

            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                throw new FormException("Ingrese un telefono");
            }

            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                throw new FormException("Ingrese una direccion");
            }

            if (dtpFechaNacimiento.Value >= DateTime.Today)
            {
                throw new FormException("Seleccione una fecha de nacimiento valida");
            }
        }

        private Usuario GetUsuario()
        {
            var usuario = new Usuario
            {
                Apellido = txtApellido.Text,
                Direccion = new Direccion { Calle = txtDireccion.Text },
                FechaNacimiento = dtpFechaNacimiento.Value,
                Id = this.IdUsuario,
                Mail = txtMail.Text,
                Hoteles = new List<Hotel>(),
                Nombre = txtNombre.Text,
                NumeroDocumento = txtNumeroDocumento.Text,
                Password = txtPassword.Text,
                Rol = new Rol { Id = (int)cmbRol.SelectedValue },
                Telefono = txtTelefono.Text,
                TipoDocumento = new TipoDocumento { Id = (int)cmbTipoDocumento.SelectedValue },
                Username = txtUsername.Text
            };

            foreach(Hotel hotel in lstHotel.CheckedItems)
            {
                usuario.Hoteles.Add(hotel);
            }

            return usuario;
        }
    }
}
