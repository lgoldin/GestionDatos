using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Entities
{
    public class Regimen
    {
        public int Codigo { get; set; }

        public string Descripcion { get; set; }

        public bool Activo { get; set; }

        public decimal Precio { get; set; }
    }
}
