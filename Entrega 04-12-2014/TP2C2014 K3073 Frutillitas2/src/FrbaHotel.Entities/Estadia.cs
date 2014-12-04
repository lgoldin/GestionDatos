using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Entities
{
    public class Estadia
    {
        public int Id { get; set; }

        public int CodigoReserva { get; set; }

        public DateTime FechaDesde { get; set; }

        public DateTime FechaHasta { get; set; }

        public bool IsNew
        {
            get { return this.Id == 0; }
        }
    }
}
