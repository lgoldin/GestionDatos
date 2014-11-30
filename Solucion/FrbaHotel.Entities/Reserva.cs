using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Entities
{
    public class Reserva
    {
        public int Codigo { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }

        public int RegimenCodigo { get; set; }

        public int HotelId { get; set; }

        public int EstadoId { get; set; }

        public int ClienteId { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
