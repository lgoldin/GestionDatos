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

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();

            this.ClienteService = new ClienteService();
        }

        public IClienteService ClienteService { get; set; }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
        }
    }
}
