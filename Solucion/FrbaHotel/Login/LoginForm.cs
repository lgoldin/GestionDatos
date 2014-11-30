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
        }

        public ILoginService LoginService { get; set; }

        public IFuncionalidadService FuncionalidadService { get; set; }

        private void ButtonIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = this.LoginService.Login(this.TextBoxUsername.Text, this.TextBoxPassword.Text);

            if (usuario != null)
            {
                usuario.Rol.Funcionalidades = this.FuncionalidadService.GetByRolId(usuario.Rol.Id);
                Session.Usuario = usuario;
                var form = new Index();
                this.DisplayForm(form);
            }
            else
            {
                MessageBox.Show("Ingrese los datos correctamente", "Error", MessageBoxButtons.OK);
            }
        }

        private void DisplayForm(Form form)
        {
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }
    }
}
