using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Entities
{
    public class Habitacion
    {
        public int Id { get; set; }

        public Hotel Hotel { get; set; }

        public TipoHabitacion TipoHabitacion { get; set; }

        public string Numero { get; set; }

        public string Piso { get; set; }

        public bool Frente { get; set; }

        public string Descripcion { get; set; }

        public bool Activa { get; set; }
    }
}
