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
            this.TipoDocumentoService = new TipoDocumentoService();
            this.HotelService = new HotelService();
        }

        public IRolService RolService { get; set; }

        public IHotelService HotelService { get; set; }

        public ITipoDocumentoService TipoDocumentoService { get; set; }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            this.FillRoles();
            this.FillTipoDocumentos();
            this.FillHoteles();
        }

        private void FillTipoDocumentos()
        {
            cmbTipoDocumento.DataSource = this.TipoDocumentoService.GetAll();
            cmbTipoDocumento.ValueMember = "Id";
            cmbTipoDocumento.DisplayMember = "Nombre";
            cmbTipoDocumento.SelectedValue = 0;
        }

        private void FillHoteles()
        {
            cmbHotel.DataSource = this.HotelService.GetAll();
            cmbHotel.ValueMember = "Id";
            cmbHotel.DisplayMember = "Nombre";
            cmbHotel.SelectedValue = 0;
        }

        private void FillRoles()
        {
            cmbRol.DataSource = this.RolService.GetAll();
            cmbRol.ValueMember = "Id";
            cmbRol.DisplayMember = "Nombre";
        }
    }
}
