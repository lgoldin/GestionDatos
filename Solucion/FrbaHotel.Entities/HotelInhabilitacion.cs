using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Entities
{
    public class HotelInhabilitacion
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Descripcion { get; set; }
        public int HotelId { get; set; }
        public DateTime FechaCreacion { get; set; }
            
    }
}
