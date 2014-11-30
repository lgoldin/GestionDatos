using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Entities.DTOs
{
    public class ReservaDTO
    {
        public int Codigo { get; set; }

        public string FechaDesde { get; set; }

        public string FechaHasta { get; set; }

        public string Regimen { get; set; }
    }
}
