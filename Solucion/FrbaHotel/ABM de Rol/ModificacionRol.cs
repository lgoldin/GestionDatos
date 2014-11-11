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

namespace FrbaHotel.ABM_de_Rol
{
    public partial class ModificacionRol : Form
    {
        public ModificacionRol()
        {
            InitializeComponent();
        }

        private void ModificacionRol_Load(object sender, EventArgs e)
        {
            RolService service = new RolService();
            List<Rol> roles = service.GetAll().ToList();
            cmbRoles.DataSource = roles;
            cmbRoles.DisplayMember = "Nombre";
            cmbRoles.ValueMember = "Id";
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lstFuncionalidades.Items.Clear();
            FuncionalidadService service = new FuncionalidadService();
            Rol rol = (Rol)cmbRoles.SelectedItem;
            if (rol.Id != 0)
            {
                rol.Funcionalidades = service.GetByRolId(rol.Id);

                List<Funcionalidad> funcionalidades = service.GetAll();

                foreach (Funcionalidad f in funcionalidades)
                {
                    bool esta = false;
                    foreach (Funcionalidad rf in rol.Funcionalidades)
                    {
                        if (f.Id == rf.Id)
                        {
                            esta = true;
                        }
                    }

                    lstFuncionalidades.Items.Add(f, esta);
                }

                ((ListBox)lstFuncionalidades).ValueMember = "Id";
                ((ListBox)lstFuncionalidades).DisplayMember = "Nombre";

                txtNombreRol.Text = rol.Nombre;
                chbActivo.Checked = rol.Activo;
            }
        }

        private void btnModificarRol_Click(object sender, EventArgs e)
        {
            string errorMessage = string.Empty;
            if (string.IsNullOrEmpty(txtNombreRol.Text))
            {
                errorMessage += "Ingrese un nombre para el rol";
            }
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                try
                {
                    Rol rol = (Rol)cmbRoles.SelectedItem;
                    rol.Nombre = txtNombreRol.Text;
                    rol.Activo = chbActivo.Checked;
                    rol.Funcionalidades = new List<Funcionalidad>();
                    for (int i = 0; i < lstFuncionalidades.Items.Count; i++)
                    {
                        if (lstFuncionalidades.GetItemChecked(i))
                        {
                            Funcionalidad funcionalidad = (Funcionalidad)lstFuncionalidades.Items[i];
                            rol.Funcionalidades.Add(funcionalidad);
                        }
                    }

                    RolService service = new RolService();
                    service.Update(rol);
                    MessageBox.Show("El rol se ha actualizado correctamente");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al actualizar el rol");
                }
            }
        }
    }
}
