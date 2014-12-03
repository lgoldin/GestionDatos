using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Entities
{
    public class TarjetaDeCredito
    {
        public int Id { get; set; }

        public long FacturaNumero { get; set; }

        public string Codigo { get; set; }

        public int CodigoSeguridad { get; set; }

        public long Numero { get; set; }

        public DateTime FechaVencimiento { get; set; }
 

    }
}
