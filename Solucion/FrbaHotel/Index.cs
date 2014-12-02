using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Login;
using FrbaHotel.ABM_de_Rol;
using FrbaHotel.ABM_de_Usuario;
using FrbaHotel.ABM_de_Habitacion;
using FrbaHotel.Entities;

namespace FrbaHotel
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new ABM_de_Hotel.ListadoHotel(false);
            DisplayForm(form);
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ABM_de_Rol.frmAltaRol form = new ABM_de_Rol.frmAltaRol();
            DisplayForm(form);
        }

        private void bajaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ABM_de_Rol.BajaRol form = new ABM_de_Rol.BajaRol();
            DisplayForm(form);
        }

        private void modificacionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ABM_de_Rol.ModificacionRol form = new ABM_de_Rol.ModificacionRol();
            DisplayForm(form);
        }

        private void DisplayForm(Form form)
        {
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ListadoUsuario();
            DisplayForm(form);
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new UsuarioForm();
            DisplayForm(form);
        }

        private void modificacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new ABM_de_Hotel.ListadoHotel(true);
            DisplayForm(form);
        }

        private void bajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new ABM_de_Hotel.ListadoHotel(false);
            DisplayForm(form);
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ListadoUsuario();
            DisplayForm(form);
        }

        private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new ListadoHabitacion();
            DisplayForm(form);
        }

        private void Index_Load(object sender, EventArgs e)
        {
            this.usuarioToolStripMenuItem.Visible = false;
            this.hotelToolStripMenuItem.Visible = false;
            this.rolToolStripMenuItem.Visible = false;
            this.habitacionToolStripMenuItem.Visible = false;
            this.clienteToolStripMenuItem.Visible = false;
           
            List<Funcionalidad> funcionalidades = Session.Usuario.Rol.Funcionalidades;
            if (funcionalidades.Any(x => x.Nombre == "Usuario"))
            {
                this.usuarioToolStripMenuItem.Visible = true;
                this.rolToolStripMenuItem.Visible = true;
            }

            if (funcionalidades.Any(x => x.Nombre == "Hotel"))
            {
                this.hotelToolStripMenuItem.Visible = true;
            }

            if (funcionalidades.Any(x => x.Nombre == "Habitacion"))
            {
                this.habitacionToolStripMenuItem.Visible = true;
            }

            if (funcionalidades.Any(x => x.Nombre == "Cliente"))
            {
                this.clienteToolStripMenuItem.Visible = true;
            }
        }

        private void altaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        }

        private void modificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_de_Cliente.ListadoCliente form = new ABM_de_Cliente.ListadoCliente();
            DisplayForm(form);
        }
    }
}
