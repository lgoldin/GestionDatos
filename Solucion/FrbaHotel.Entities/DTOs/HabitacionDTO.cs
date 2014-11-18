using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Entities.DTOs
{
    public class HabitacionDTO
    {
        public int Codigo { get; set; }

        public string Hotel { get; set; }

        public string TipoHabitacion { get; set; }

        public string Numero { get; set; }

        public string Piso { get; set;}

        public bool Frente { get; set; }

        public string Descripcion { get; set; }

        public bool Activa { get; set; }

        public string Modificar { get; set; }
    }
}
