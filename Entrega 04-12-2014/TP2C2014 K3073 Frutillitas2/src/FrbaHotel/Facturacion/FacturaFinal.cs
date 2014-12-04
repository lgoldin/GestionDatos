using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Entities;

namespace FrbaHotel.Facturacion
{
    public partial class FacturaFinal : Form
    {
        private Factura factura { get; set; }
        private string cliente { get; set; }

        public FacturaFinal()
        {
            InitializeComponent();
        }

        public FacturaFinal(Factura f, string NombreCliente)
        {
            InitializeComponent();
            this.factura = f;
            this.cliente = NombreCliente;
        }

        private void FacturaFinal_Load(object sender, EventArgs e)
        {
            lblFactura.Text =
                "Número de Factura: " + factura.Numero + System.Environment.NewLine + System.Environment.NewLine +
                "Factura a nombre de: " + this.cliente + System.Environment.NewLine + System.Environment.NewLine +
                "Items:" + System.Environment.NewLine + System.Environment.NewLine;

            foreach (FacturaItem fi in factura.Items)
            {
                lblFactura.Text += "*" + fi.Descripcion + "------$" + fi.Precio + System.Environment.NewLine + System.Environment.NewLine;
            }

            lblFactura.Text += System.Environment.NewLine + "Total: $" + factura.Total;
            string medioDePago = factura.TipoPagoId == 1 ? "Efectivo" : "Tarjeta";
            lblFactura.Text += System.Environment.NewLine + "Medio de pago: " + medioDePago;


            lblFactura.AutoSize = true;
            
            lblFactura.Left = (this.ClientSize.Width - lblFactura.Width) / 2;
            lblFactura.Top = (this.ClientSize.Height - lblFactura.Height) / 4;
            
            this.Controls.Add(lblFactura);

            MessageBox.Show("Factura generada");
        }
    }
}
