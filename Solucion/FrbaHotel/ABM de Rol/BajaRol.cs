using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Entities;
using FrbaHotel.Services;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class BajaRol : Form
    {
        public BajaRol()
        {
            InitializeComponent();

            RolService service = new RolService();
            List<Rol> roles = service.GetAll().ToList();
            cmbRoles.DataSource = roles.Where(x=>x.Activo).ToList();
            cmbRoles.DisplayMember = "Nombre";
            cmbRoles.ValueMember = "Id";
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            Rol rol = (Rol)cmbRoles.SelectedItem;
            rol.Activo = false;
            RolService service = new RolService();
            service.Delete(rol);
        }

        private void BajaRol_Load(object sender, EventArgs e)
        {

        }
    }
}
