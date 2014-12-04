using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Entities
{
    public class Hotel
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public Ciudad Ciudad { get; set; }

        public string Direccion { get; set; }

        public int Estrellas { get; set; }

        public string Mail { get; set; }

        public DateTime FechaCreacion { get; set; }

        public List<Regimen> Regimenes { get; set; }

        public string Telefono{ get; set; }
    }
}
