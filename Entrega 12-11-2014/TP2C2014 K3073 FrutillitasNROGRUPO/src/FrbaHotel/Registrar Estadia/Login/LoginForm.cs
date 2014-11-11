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
        }

        public ILoginService LoginService { get; set; }

        private void ButtonIngresar_Click(object sender, EventArgs e)
        {
            Usuario usuario = this.LoginService.Login(this.TextBoxUsername.Text, this.TextBoxPassword.Text);

            if (usuario != null)
            {
                var clienteForm = new ClienteForm();
                clienteForm.Activate();
                clienteForm.Show();

                Application.OpenForms["LoginForm"].Hide();
            }

            this.LabelError.Text = "Ingrese los datos correctamente";
        }
    }
}
