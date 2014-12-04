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
    public partial class frmAltaRol : Form
    {
        public frmAltaRol()
        {
            InitializeComponent();
        }

        private void frmAltaRol_Load(object sender, EventArgs e)
        {
            FuncionalidadService service = new FuncionalidadService();
            ((ListBox)lstFuncionalidades).DataSource = service.GetAll();
            ((ListBox)lstFuncionalidades).ValueMember = "Id";
            ((ListBox)lstFuncionalidades).DisplayMember = "Nombre";
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
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
                    Rol rol = new Rol();
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
                    service.Insert(rol);
                    MessageBox.Show("El rol se ha creado correctamente");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al crear el rol");
                }
            }

        }
    }
}
