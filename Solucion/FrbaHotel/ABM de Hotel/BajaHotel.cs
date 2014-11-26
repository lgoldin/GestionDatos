using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class BajaHotel : Form
    {
        private int hotelId { get; set; }
        private string hotelName { get; set; }

        public BajaHotel()
        {
            InitializeComponent();
        }

        public BajaHotel(int hotelId, string hotelName)
        {
            InitializeComponent();
            this.hotelId = hotelId;
            this.hotelName = hotelName;
        }


        private void BajaHotel_Load(object sender, EventArgs e)
        {
            lblNombre.Text = this.hotelName;
            dateDesde.MinDate = DateTime.Now;
            dateHasta.MinDate = DateTime.Now;
        }
    }
}
