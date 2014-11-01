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

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();

            this.RolService = new RolService();
        }

        public IRolService RolService { get; set; }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            this.FillRoles();
        }

        private void FillRoles()
        {
            cmbRol.DataSource = this.RolService.GetAll();
            cmbRol.ValueMember = "Id";
            cmbRol.DisplayMember = "Nombre";
        }
    }
}
