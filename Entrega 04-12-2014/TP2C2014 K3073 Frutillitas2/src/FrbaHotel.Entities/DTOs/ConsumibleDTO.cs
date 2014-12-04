using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Entities
{
    public class ConsumibleDTO
    {
        public int Codigo { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public string Modificar { get; set; }

        public string Eliminar { get; set; }
    }
}
