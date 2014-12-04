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
using FrbaHotel.ABM_de_Cliente;

namespace FrbaHotel.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.LoginService = new LoginService();
            this.FuncionalidadService = new FuncionalidadService();
            this.RolService = new RolService();
            this.ReservaService = new ReservaService();
        }

        public ILoginService LoginService { get; set; }

        public IReservaService ReservaService { get; set; }

        public IFuncionalidadService FuncionalidadService { get; set; }

        public IRolService RolService { get; set; }

        private void ButtonIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = this.LoginService.Login(this.TextBoxUsername.Text, this.TextBoxPassword.Text);

                if (usuario != null)
                {
                    usuario.Rol.Funcionalidades = this.FuncionalidadService.GetByRolId(usuario.Rol.Id);
                    Session.Usuario = usuario;
                    this.DisplayForm(new SeleccionarHotel());
                }
                else
                {
                    MessageBox.Show("Ingrese los datos correctamente", "Error", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Probablemente falten correr los SPs", "Error", MessageBoxButtons.OK);
            }
        }

        private void DisplayForm(Form form)
        {
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            var usuario = this.LoginService.Login("guest", "guest");

            usuario.Rol.Funcionalidades = this.FuncionalidadService.GetByRolId(usuario.Rol.Id);

            Session.Usuario = usuario;
            Session.Hotel = null;
            
            this.DisplayForm(new Index());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            IEnumerable<Reserva> reservas = this.ReservaService.GetReservasVencidas();
            var codigos = new List<int>();
            reservas.ToList().ForEach(x => codigos.Add(x.Codigo));
            this.ReservaService.Cancelar(codigos, "No show", null, true);
        }
    }
}
