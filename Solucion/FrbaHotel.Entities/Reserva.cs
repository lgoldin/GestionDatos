using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Entities
{
    public class Reserva
    {
        int Codigo { get; set; }

        DateTime FechaDesde { get; set; }

        DateTime FechaHasta { get; set; }

        int RegimenCodigo { get; set; }

        int HotelId { get; set; }

        int EstadoId { get; set; }

        int ClienteId { get; set; }

        DateTime FechaCreacion { get; set; }
    }
}
