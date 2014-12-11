using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrbaHotel.Entities.DTOs
{
    public class HotelDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Ciudad { get; set; }

        public string Pais { get; set; }

        public string Direccion { get; set; }

        public int Estrellas { get; set; }

        public string Mail { get; set; }

        public string FechaCreacion { get; set; }

        public string Telefono{ get; set; }

        public string Modificar { get; set; }

        public string Inhabilitar { get; set; }
    }
}
