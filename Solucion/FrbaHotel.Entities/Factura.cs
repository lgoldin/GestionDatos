using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Entities
{
    public class Factura
    {
        public long Numero { get; set; }

        public DateTime Fecha { get; set; }
        
        public decimal Total { get; set; }
        
        public int EstadiaId { get; set; }
        
        public int TipoPagoId { get; set; }
        
        public List<FacturaItem> Items {get; set;}

        public int ClienteId { get; set; }
    }
}
