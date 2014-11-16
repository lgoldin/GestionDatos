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
            this.FillOtherFields(usuario);
        }

        private void InitializeServices()
        {
            this.RolService = new RolService();
            this.TipoDocumentoService = new TipoDocumentoService();
            this.HotelService = new HotelService();
            this.UsuarioService = new UsuarioService();
        }

        private void FillOtherFields(Usuario usuario)
        {
            if (usuario != null)
            {
                txtUsername.Text = usuario.Username;
                txtNombre.Text = usuario.Nombre;
                txtApellido.Text = usuario.Apellido;
                txtNumeroDocumento.Text = usuario.NumeroDocumento;
                txtMail.Text = usuario.Mail;
                txtTelefono.Text = usuario.Telefono;
                txtDireccion.Text = usuario.Direccion.Calle;
                dtpFechaNacimiento.Value = usuario.FechaNacimiento;
                ckbHabilitado.Checked = usuario.Habilitado;
            }
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
            lstHotel.DataSource = this.HotelService.GetAll(null, null, null, null);
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

        private void ValidateForm()
        {
            var builder = new StringBuilder(string.Empty);

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                builder.AppendLine("Ingrese un username");
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                builder.AppendLine("Ingrese una password");
            }

            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                builder.AppendLine("Tiene que confirmar la password");
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                builder.AppendLine("Verifique la password ingresada");
            }

            if (cmbRol.SelectedValue.ToString() == "0")
            {
                builder.AppendLine("Seleccione un rol");
            }

            if (lstHotel.CheckedItems.Count == 0)
            {
                builder.AppendLine("Seleccione al menos un hotel");
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                builder.AppendLine("Ingrese un nombre");
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                builder.AppendLine("Ingrese un apellido");
            }

            if (cmbTipoDocumento.SelectedValue.ToString() == "0")
            {
                builder.AppendLine("Seleccione un tipo de documento");
            }

            if (string.IsNullOrEmpty(txtNumeroDocumento.Text))
            {
                builder.AppendLine("Ingrese un numero de documento");
            }

            if (string.IsNullOrEmpty(txtMail.Text))
            {
                builder.AppendLine("Ingrese un mail");
            }

            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                builder.AppendLine("Ingrese un telefono");
            }

            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                builder.AppendLine("Ingrese una direccion");
            }

            if (dtpFechaNacimiento.Value >= DateTime.Today)
            {
                builder.AppendLine("Seleccione una fecha de nacimiento valida");
            }

            if (!string.IsNullOrEmpty(builder.ToString()))
            {
                throw new FormException(builder.ToString());
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
                Username = txtUsername.Text,
                Habilitado = ckbHabilitado.Checked
            };

            foreach(Hotel hotel in lstHotel.CheckedItems)
            {
                usuario.Hoteles.Add(hotel);
            }

            return usuario;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.UsuarioService.Delete(new Usuario { Id = this.IdUsuario });
        }
    }
}
